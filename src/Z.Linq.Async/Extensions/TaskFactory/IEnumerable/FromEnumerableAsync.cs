// Description: Async extension methods for LINQ (Language Integrated Query).
// Website & Documentation: https://github.com/zzzprojects/LINQ-Async
// Forum: https://github.com/zzzprojects/LINQ-Async/issues
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

using System;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;

namespace Z.Linq
{
    public static partial class TaskFactoryExtensions
    {
        public static Task<TResult> FromEnumerableAsync<TResult>(this TaskFactory taskFactory, IEnumerable source, Func<IEnumerable, TResult> func, CancellationToken cancellationToken = default(CancellationToken))
        {
            return FromEnumerableAsync(taskFactory, source, func, AsyncEnumerable.CreateFrom, cancellationToken);
        }

        public static Task<TResult> FromEnumerableAsync<TResult>(this TaskFactory taskFactory, Task<IEnumerable> task, Func<IEnumerable, TResult> func, CancellationToken cancellationToken = default(CancellationToken))
        {
            return FromEnumerableAsync(taskFactory, task, func, AsyncEnumerable.CreateFrom, cancellationToken);
        }
    }
}