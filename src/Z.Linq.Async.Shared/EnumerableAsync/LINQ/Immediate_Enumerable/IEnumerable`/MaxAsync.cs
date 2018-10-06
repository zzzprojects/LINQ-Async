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
        public static Task<int> MaxAsync(this IEnumerable<int> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerable(source, Enumerable.Max, cancellationToken);
        }

        public static Task<int?> MaxAsync(this IEnumerable<int?> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerable(source, Enumerable.Max, cancellationToken);
        }

        public static Task<long> MaxAsync(this IEnumerable<long> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerable(source, Enumerable.Max, cancellationToken);
            ;
        }

        public static Task<long?> MaxAsync(this IEnumerable<long?> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerable(source, Enumerable.Max, cancellationToken);
        }

        public static Task<double> MaxAsync(this IEnumerable<double> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerable(source, Enumerable.Max, cancellationToken);
        }

        public static Task<double?> MaxAsync(this IEnumerable<double?> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerable(source, Enumerable.Max, cancellationToken);
        }

        public static Task<float> MaxAsync(this IEnumerable<float> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerable(source, Enumerable.Max, cancellationToken);
        }

        public static Task<float?> MaxAsync(this IEnumerable<float?> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerable(source, Enumerable.Max, cancellationToken);
        }

        public static Task<decimal> MaxAsync(this IEnumerable<decimal> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerable(source, Enumerable.Max, cancellationToken);
        }

        public static Task<decimal?> MaxAsync(this IEnumerable<decimal?> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerable(source, Enumerable.Max, cancellationToken);
        }

        public static Task<TSource> MaxAsync<TSource>(this IEnumerable<TSource> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerable(source, Enumerable.Max, cancellationToken);
        }

        public static Task<int> MaxAsync<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerable(source, selector, Enumerable.Max, cancellationToken);
        }

        public static Task<int?> MaxAsync<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerable(source, selector, Enumerable.Max, cancellationToken);
        }

        public static Task<long> MaxAsync<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerable(source, selector, Enumerable.Max, cancellationToken);
        }

        public static Task<long?> MaxAsync<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerable(source, selector, Enumerable.Max, cancellationToken);
        }

        public static Task<float> MaxAsync<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerable(source, selector, Enumerable.Max, cancellationToken);
        }

        public static Task<float?> MaxAsync<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerable(source, selector, Enumerable.Max, cancellationToken);
        }

        public static Task<double> MaxAsync<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerable(source, selector, Enumerable.Max, cancellationToken);
        }

        public static Task<double?> MaxAsync<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerable(source, selector, Enumerable.Max, cancellationToken);
        }

        public static Task<decimal> MaxAsync<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerable(source, selector, Enumerable.Max, cancellationToken);
        }

        public static Task<decimal?> MaxAsync<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal?> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerable(source, selector, Enumerable.Max, cancellationToken);
        }

        public static Task<TResult> MaxAsync<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromEnumerable(source, selector, Enumerable.Max, cancellationToken);
        }
    }
}