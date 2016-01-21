// Description: Async extension methods for LINQ (Language Integrated Query).
// Website & Documentation: https://github.com/zzzprojects/LINQ-Async
// Forum: https://github.com/zzzprojects/LINQ-Async/issues
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Z.Linq
{
    public static partial class EnumerableAsync
    {
        public static Task<IEnumerable<TResult>> SelectMany<TSource, TResult>(this Task<IEnumerable<TSource>> source, Func<TSource, IEnumerable<TResult>> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, selector, Enumerable.SelectMany, cancellationToken);
        }

        public static Task<IEnumerable<TResult>> SelectMany<TSource, TResult>(this Task<IEnumerable<TSource>> source, Func<TSource, int, IEnumerable<TResult>> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, selector, Enumerable.SelectMany, cancellationToken);
        }

        public static Task<IEnumerable<TResult>> SelectMany<TSource, TCollection, TResult>(this Task<IEnumerable<TSource>> source, Func<TSource, int, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, collectionSelector, resultSelector, Enumerable.SelectMany, cancellationToken);
        }

        public static Task<IEnumerable<TResult>> SelectMany<TSource, TCollection, TResult>(this Task<IEnumerable<TSource>> source, Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, collectionSelector, resultSelector, Enumerable.SelectMany, cancellationToken);
        }
    }
}