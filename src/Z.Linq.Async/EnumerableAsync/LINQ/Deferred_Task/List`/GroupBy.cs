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
        public static Task<IEnumerable<IGrouping<TKey, TSource>>> GroupBy<TSource, TKey>(this Task<List<TSource>> source, Func<TSource, TKey> keySelector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, keySelector, Enumerable.GroupBy, cancellationToken);
        }

        public static Task<IEnumerable<IGrouping<TKey, TSource>>> GroupBy<TSource, TKey>(this Task<List<TSource>> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, keySelector, comparer, Enumerable.GroupBy, cancellationToken);
        }

        public static Task<IEnumerable<IGrouping<TKey, TElement>>> GroupBy<TSource, TKey, TElement>(this Task<List<TSource>> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, keySelector, elementSelector, Enumerable.GroupBy, cancellationToken);
        }

        public static Task<IEnumerable<IGrouping<TKey, TElement>>> GroupBy<TSource, TKey, TElement>(this Task<List<TSource>> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, keySelector, elementSelector, comparer, Enumerable.GroupBy, cancellationToken);
        }

        public static Task<IEnumerable<TResult>> GroupBy<TSource, TKey, TResult>(this Task<List<TSource>> source, Func<TSource, TKey> keySelector, Func<TKey, IEnumerable<TSource>, TResult> resultSelector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, keySelector, resultSelector, Enumerable.GroupBy, cancellationToken);
        }

        public static Task<IEnumerable<TResult>> GroupBy<TSource, TKey, TElement, TResult>(this Task<List<TSource>> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, TResult> resultSelector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, keySelector, elementSelector, resultSelector, Enumerable.GroupBy, cancellationToken);
        }

        public static Task<IEnumerable<TResult>> GroupBy<TSource, TKey, TResult>(this Task<List<TSource>> source, Func<TSource, TKey> keySelector, Func<TKey, IEnumerable<TSource>, TResult> resultSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, keySelector, resultSelector, comparer, Enumerable.GroupBy, cancellationToken);
        }

        public static Task<IEnumerable<TResult>> GroupBy<TSource, TKey, TElement, TResult>(this Task<List<TSource>> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, TResult> resultSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, keySelector, elementSelector, resultSelector, comparer, Enumerable.GroupBy, cancellationToken);
        }
    }
}