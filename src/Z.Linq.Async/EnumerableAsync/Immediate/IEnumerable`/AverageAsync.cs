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
        public static Task<double> AverageAsync(this IEnumerable<int> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, Enumerable.Average, cancellationToken);
        }

        public static Task<double?> AverageAsync(this IEnumerable<int?> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, Enumerable.Average, cancellationToken);
        }

        public static Task<double> AverageAsync(this IEnumerable<long> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, Enumerable.Average, cancellationToken);
        }

        public static Task<double?> AverageAsync(this IEnumerable<long?> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, Enumerable.Average, cancellationToken);
        }

        public static Task<float> AverageAsync(this IEnumerable<float> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, Enumerable.Average, cancellationToken);
        }

        public static Task<float?> AverageAsync(this IEnumerable<float?> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, Enumerable.Average, cancellationToken);
        }

        public static Task<double> AverageAsync(this IEnumerable<double> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, Enumerable.Average, cancellationToken);
        }

        public static Task<double?> AverageAsync(this IEnumerable<double?> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, Enumerable.Average, cancellationToken);
        }

        public static Task<decimal> AverageAsync(this IEnumerable<decimal> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, Enumerable.Average, cancellationToken);
        }

        public static Task<decimal?> AverageAsync(this IEnumerable<decimal?> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, Enumerable.Average, cancellationToken);
        }

        public static Task<double> AverageAsync<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, selector, Enumerable.Average, cancellationToken);
        }

        public static Task<double?> AverageAsync<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, selector, Enumerable.Average, cancellationToken);
        }

        public static Task<double> AverageAsync<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, selector, Enumerable.Average, cancellationToken);
        }

        public static Task<double?> AverageAsync<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, selector, Enumerable.Average, cancellationToken);
        }

        public static Task<float> AverageAsync<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, selector, Enumerable.Average, cancellationToken);
        }

        public static Task<float?> AverageAsync<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, selector, Enumerable.Average, cancellationToken);
        }

        public static Task<double> AverageAsync<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, selector, Enumerable.Average, cancellationToken);
        }

        public static Task<double?> AverageAsync<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, selector, Enumerable.Average, cancellationToken);
        }

        public static Task<decimal> AverageAsync<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, selector, Enumerable.Average, cancellationToken);
        }

        public static Task<decimal?> AverageAsync<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal?> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerableAsync(source, selector, Enumerable.Average, cancellationToken);
        }
    }
}