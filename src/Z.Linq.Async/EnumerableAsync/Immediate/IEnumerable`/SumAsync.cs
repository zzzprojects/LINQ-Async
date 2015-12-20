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
        public static Task<int> SumAsync(this IEnumerable<int> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, Enumerable.Sum, cancellationToken);
        }

        public static Task<int?> SumAsync(this IEnumerable<int?> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, Enumerable.Sum, cancellationToken);
        }

        public static Task<long> SumAsync(this IEnumerable<long> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, Enumerable.Sum, cancellationToken);
        }

        public static Task<long?> SumAsync(this IEnumerable<long?> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, Enumerable.Sum, cancellationToken);
        }

        public static Task<float> SumAsync(this IEnumerable<float> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, Enumerable.Sum, cancellationToken);
        }

        public static Task<float?> SumAsync(this IEnumerable<float?> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, Enumerable.Sum, cancellationToken);
        }

        public static Task<double> SumAsync(this IEnumerable<double> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, Enumerable.Sum, cancellationToken);
        }

        public static Task<double?> SumAsync(this IEnumerable<double?> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, Enumerable.Sum, cancellationToken);
        }

        public static Task<decimal> SumAsync(this IEnumerable<decimal> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, Enumerable.Sum, cancellationToken);
        }

        public static Task<decimal?> SumAsync(this IEnumerable<decimal?> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, Enumerable.Sum, cancellationToken);
        }

        public static Task<int> SumAsync<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, selector, Enumerable.Sum, cancellationToken);
        }

        public static Task<int?> SumAsync<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, selector, Enumerable.Sum, cancellationToken);
        }

        public static Task<long> SumAsync<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, selector, Enumerable.Sum, cancellationToken);
        }

        public static Task<long?> SumAsync<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, selector, Enumerable.Sum, cancellationToken);
        }

        public static Task<float> SumAsync<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, selector, Enumerable.Sum, cancellationToken);
        }

        public static Task<float?> SumAsync<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, selector, Enumerable.Sum, cancellationToken);
        }

        public static Task<double> SumAsync<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, selector, Enumerable.Sum, cancellationToken);
        }

        public static Task<double?> SumAsync<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, selector, Enumerable.Sum, cancellationToken);
        }

        public static Task<decimal> SumAsync<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, selector, Enumerable.Sum, cancellationToken);
        }

        public static Task<decimal?> SumAsync<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal?> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, selector, Enumerable.Sum, cancellationToken);
        }
    }
}