// Description: Async extension methods for LINQ (Language Integrated Query).
// Website & Documentation: https://github.com/zzzprojects/LINQ-Async
// Forum: https://github.com/zzzprojects/LINQ-Async/issues
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Z.Linq.Async;

namespace Z.Linq
{
    public static partial class TaskFactoryExtensions
    {
        public static Task<AsyncWhereEnumerable<T>> FromWhereEnumerable<T>(this TaskFactory taskFactory, IEnumerable<T> source, Func<T, Task<bool>> predicate, Func<IEnumerable<T>, Func<T, bool>, IEnumerable<T>> func, CancellationToken cancellationToken = default(CancellationToken))
        {
            source = new AsyncWhereEnumerable<T>(source, predicate, cancellationToken);

            var taskEnumerable = FromTaskEnumerable(taskFactory, source, enums => enums, AsyncWhereEnumerable<T>.CreateFrom, cancellationToken);
            var taskWhereEnumerable = taskEnumerable.ContinueWith((t, x) => new AsyncWhereEnumerable<T>(t.Result), source, cancellationToken, TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default);

            return taskWhereEnumerable;
        }

        public static Task<AsyncWhereEnumerable<T>> FromWhereEnumerable<T>(this TaskFactory taskFactory, IEnumerable<T> source, Func<T, int, Task<bool>> predicate, Func<IEnumerable<T>, Func<T, int, bool>, IEnumerable<T>> func, CancellationToken cancellationToken = default(CancellationToken))
        {
            source = new AsyncWhereEnumerable<T>(source, predicate, cancellationToken);

            var taskEnumerable = FromTaskEnumerable(taskFactory, source, enums => enums, AsyncWhereEnumerable<T>.CreateFrom, cancellationToken);
            var taskWhereEnumerable = taskEnumerable.ContinueWith((t, x) => new AsyncWhereEnumerable<T>(t.Result), source, cancellationToken, TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default);

            return taskWhereEnumerable;
        }
    }
}