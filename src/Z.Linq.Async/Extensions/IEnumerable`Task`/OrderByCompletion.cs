// Description: Async extension methods for LINQ (Language Integrated Query).
// Website & Documentation: https://github.com/zzzprojects/LINQ-Async
// Forum: https://github.com/zzzprojects/LINQ-Async/issues
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Z.Linq.Async
{
    /// <summary>
    ///     Provides extension methods for tasks.
    /// </summary>
    public static class TaskExtensions
    {
        /// <summary>
        ///     Creates a new array of tasks which complete in order.
        /// </summary>
        /// <typeparam name="T">The type of the results of the tasks.</typeparam>
        /// <param name="tasks">The tasks to order by completion.</param>
        public static Task<T>[] OrderByCompletion<T>(this IEnumerable<Task<T>> tasks)
        {
            // This is a combination of Jon Skeet's approach and Stephen Toub's approach:
            //  http://msmvps.com/blogs/jon_skeet/archive/2012/01/16/eduasync-part-19-ordering-by-completion-ahead-of-time.aspx
            //  http://blogs.msdn.com/b/pfxteam/archive/2012/08/02/processing-tasks-as-they-complete.aspx

            // Reify the source task sequence.
            var taskArray = tasks.ToArray();

            // Allocate a TCS array and an array of the resulting tasks.
            var numTasks = taskArray.Length;
            var tcs = new TaskCompletionSource<T>[numTasks];
            var ret = new Task<T>[numTasks];

            // As each task completes, complete the next tcs.
            var lastIndex = -1;
            Action<Task<T>> continuation = task =>
            {
                var index = Interlocked.Increment(ref lastIndex);
                tcs[index].TryCompleteFromCompletedTask(task);
            };

            // Fill out the arrays and attach the continuations.
            for (var i = 0; i != numTasks; ++i)
            {
                tcs[i] = new TaskCompletionSource<T>();
                ret[i] = tcs[i].Task;
                taskArray[i].ContinueWith(continuation, CancellationToken.None, TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default);
            }

            return ret;
        }

        /// <summary>
        ///     Attempts to complete a <see cref="TaskCompletionSource{TResult}" />, propogating the completion of
        ///     <paramref name="task" />.
        /// </summary>
        /// <typeparam name="TResult">The type of the result of the asynchronous operation.</typeparam>
        /// <param name="this">The task completion source. May not be <c>null</c>.</param>
        /// <param name="task">The task. May not be <c>null</c>.</param>
        /// <returns><c>true</c> if this method completed the task completion source; <c>false</c> if it was already completed.</returns>
        public static bool TryCompleteFromCompletedTask<TResult>(this TaskCompletionSource<TResult> @this, Task<TResult> task)
        {
            Contract.Requires(@this != null);
            Contract.Requires(task != null);
            Contract.Requires(task.IsCompleted);

            if (task.IsFaulted)
            {
                Contract.Assume(task.Exception != null);
                Contract.Assume(task.Exception.InnerExceptions != null);
                Contract.Assume(Contract.ForAll(task.Exception.InnerExceptions, x => x != null));
                return @this.TrySetException(task.Exception.InnerExceptions);
            }
            if (task.IsCanceled)
                return @this.TrySetCanceled();
            return @this.TrySetResult(task.Result);
        }
    }
}