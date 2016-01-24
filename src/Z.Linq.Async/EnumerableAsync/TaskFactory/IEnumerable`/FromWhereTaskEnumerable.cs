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
        public static Task<AsyncWhereEnumerable<T>> FromWhereTaskEnumerable<T>(this TaskFactory taskFactory, Task<IEnumerable<T>> task, Func<T, Task<bool>> predicate, Func<IEnumerable<T>, Func<T, bool>, IEnumerable<T>> func, CancellationToken cancellationToken = default(CancellationToken))
        {
            var source = new AsyncWhereEnumerable<T>(task, predicate, cancellationToken);

            var taskEnumerable = FromTaskEnumerable(taskFactory, source, enums => enums, AsyncWhereEnumerable<T>.CreateFrom, cancellationToken);
            var taskWhereEnumerable = taskEnumerable.ContinueWith((t, x) => new AsyncWhereEnumerable<T>(t.Result), source, cancellationToken);

            return taskWhereEnumerable;
        }

        public static Task<AsyncWhereEnumerable<T>> FromWhereTaskEnumerable<T>(this TaskFactory taskFactory, Task<IEnumerable<T>> task, Func<T, int, Task<bool>> predicate, Func<IEnumerable<T>, Func<T, int, bool>, IEnumerable<T>> func, CancellationToken cancellationToken = default(CancellationToken))
        {
            var source = new AsyncWhereEnumerable<T>(task, predicate, cancellationToken);

            var taskEnumerable = FromTaskEnumerable(taskFactory, source, enums => enums, AsyncWhereEnumerable<T>.CreateFrom, cancellationToken);
            var taskWhereEnumerable = taskEnumerable.ContinueWith((t, x) => new AsyncWhereEnumerable<T>(t.Result), source, cancellationToken);

            return taskWhereEnumerable;
        }
    }
}