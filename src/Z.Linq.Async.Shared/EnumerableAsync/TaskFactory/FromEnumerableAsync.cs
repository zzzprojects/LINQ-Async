// Description: Async extension methods for LINQ (Language Integrated Query).
// Website & Documentation: https://github.com/zzzprojects/LINQ-Async
// Forum: https://github.com/zzzprojects/LINQ-Async/issues
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Z.Linq
{
    public static partial class TaskFactoryExtensions
    {
        private static Task<TResult> FromTaskEnumerable<T, TAsyncEnumerable, TResult>(this TaskFactory taskFactory, T source, Func<TAsyncEnumerable, TResult> func, Func<T, CancellationToken, TAsyncEnumerable> converter, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Run(() => func(converter(source, cancellationToken)), cancellationToken);
        }

        private static async Task<TResult> FromTaskEnumerable<T, TAsyncEnumerable, TResult>(this TaskFactory taskFactory, Task<T> task, Func<TAsyncEnumerable, TResult> func, Func<T, CancellationToken, TAsyncEnumerable> converter, CancellationToken cancellationToken = default(CancellationToken))
        {
            var result = await task.ConfigureAwait(false);
            return func(converter(result, cancellationToken));
        }
    }
}