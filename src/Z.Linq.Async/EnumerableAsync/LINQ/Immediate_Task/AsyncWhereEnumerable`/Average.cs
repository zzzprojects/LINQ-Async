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
        public static Task<double> Average(this Task<AsyncWhereEnumerable<int>> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, Enumerable.Average, cancellationToken);
        }

        public static Task<double?> Average(this Task<AsyncWhereEnumerable<int?>> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, Enumerable.Average, cancellationToken);
        }

        public static Task<double> Average(this Task<AsyncWhereEnumerable<long>> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, Enumerable.Average, cancellationToken);
        }

        public static Task<double?> Average(this Task<AsyncWhereEnumerable<long?>> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, Enumerable.Average, cancellationToken);
        }

        public static Task<float> Average(this Task<AsyncWhereEnumerable<float>> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, Enumerable.Average, cancellationToken);
        }

        public static Task<float?> Average(this Task<AsyncWhereEnumerable<float?>> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, Enumerable.Average, cancellationToken);
        }

        public static Task<double> Average(this Task<AsyncWhereEnumerable<double>> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, Enumerable.Average, cancellationToken);
        }

        public static Task<double?> Average(this Task<AsyncWhereEnumerable<double?>> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, Enumerable.Average, cancellationToken);
        }

        public static Task<decimal> Average(this Task<AsyncWhereEnumerable<decimal>> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, Enumerable.Average, cancellationToken);
        }

        public static Task<decimal?> Average(this Task<AsyncWhereEnumerable<decimal?>> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, Enumerable.Average, cancellationToken);
        }

        public static Task<double> Average<TSource>(this Task<AsyncWhereEnumerable<TSource>> source, Func<TSource, int> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, selector, Enumerable.Average, cancellationToken);
        }

        public static Task<double?> Average<TSource>(this Task<AsyncWhereEnumerable<TSource>> source, Func<TSource, int?> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, selector, Enumerable.Average, cancellationToken);
        }

        public static Task<double> Average<TSource>(this Task<AsyncWhereEnumerable<TSource>> source, Func<TSource, long> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, selector, Enumerable.Average, cancellationToken);
        }

        public static Task<double?> Average<TSource>(this Task<AsyncWhereEnumerable<TSource>> source, Func<TSource, long?> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, selector, Enumerable.Average, cancellationToken);
        }

        public static Task<float> Average<TSource>(this Task<AsyncWhereEnumerable<TSource>> source, Func<TSource, float> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, selector, Enumerable.Average, cancellationToken);
        }

        public static Task<float?> Average<TSource>(this Task<AsyncWhereEnumerable<TSource>> source, Func<TSource, float?> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, selector, Enumerable.Average, cancellationToken);
        }

        public static Task<double> Average<TSource>(this Task<AsyncWhereEnumerable<TSource>> source, Func<TSource, double> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, selector, Enumerable.Average, cancellationToken);
        }

        public static Task<double?> Average<TSource>(this Task<AsyncWhereEnumerable<TSource>> source, Func<TSource, double?> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, selector, Enumerable.Average, cancellationToken);
        }

        public static Task<decimal> Average<TSource>(this Task<AsyncWhereEnumerable<TSource>> source, Func<TSource, decimal> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, selector, Enumerable.Average, cancellationToken);
        }

        public static Task<decimal?> Average<TSource>(this Task<AsyncWhereEnumerable<TSource>> source, Func<TSource, decimal?> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, selector, Enumerable.Average, cancellationToken);
        }
    }
}