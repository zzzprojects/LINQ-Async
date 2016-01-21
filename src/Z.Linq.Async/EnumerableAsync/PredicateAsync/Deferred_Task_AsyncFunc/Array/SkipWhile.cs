// Description: Async extension methods for LINQ (Language Integrated Query).
// Website & Documentation: https://github.com/zzzprojects/LINQ-Async
// Forum: https://github.com/zzzprojects/LINQ-Async/issues
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

using System;
using System.Threading;
using System.Threading.Tasks;
using Z.Linq.Async;

namespace Z.Linq
{
    public static partial class EnumerableAsync
    {
        public static Task<AsyncWhereEnumerable<TSource>> SkipWhile<TSource>(this Task<TSource[]> source, Func<TSource, Task<bool>> predicate, CancellationToken cancellationToken = default(CancellationToken))
        {
            return source.AsEnumerable(cancellationToken).SkipWhile(predicate, cancellationToken);
        }

        public static Task<AsyncWhereEnumerable<TSource>> SkipWhile<TSource>(this Task<TSource[]> source, Func<TSource, int, Task<bool>> predicate, CancellationToken cancellationToken = default(CancellationToken))
        {
            return source.AsEnumerable(cancellationToken).SkipWhile(predicate, cancellationToken);
        }
    }
}