// Description: Async extension methods for LINQ (Language Integrated Query).
// Website & Documentation: https://github.com/zzzprojects/LINQ-Async
// Forum: https://github.com/zzzprojects/LINQ-Async/issues
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Z.Linq.Async;

namespace Z.Linq
{
    public static partial class EnumerableAsync
    {
        public static Task<TSource> Aggregate<TSource>(this Task<AsyncWhereEnumerable<TSource>> source, Func<TSource, TSource, TSource> func, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, func, Enumerable.Aggregate, cancellationToken);
        }

        public static Task<TAccumulate> Aggregate<TSource, TAccumulate>(this Task<AsyncWhereEnumerable<TSource>> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, seed, func, Enumerable.Aggregate, cancellationToken);
        }

        public static Task<TResult> Aggregate<TSource, TAccumulate, TResult>(this Task<AsyncWhereEnumerable<TSource>> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, seed, func, resultSelector, Enumerable.Aggregate, cancellationToken);
        }
    }
}