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

namespace Z.Linq
{
    public static partial class EnumerableAsync
    {
        public static Task<TSource> SingleOrDefault<TSource>(this Task<IOrderedEnumerable<TSource>> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, Enumerable.SingleOrDefault, cancellationToken);
        }

        public static Task<TSource> SingleOrDefault<TSource>(this Task<IOrderedEnumerable<TSource>> source, Func<TSource, bool> predicate, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, predicate, Enumerable.SingleOrDefault, cancellationToken);
        }
    }
}