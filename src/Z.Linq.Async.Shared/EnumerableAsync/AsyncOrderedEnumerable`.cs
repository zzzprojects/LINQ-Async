// Description: Async extension methods for LINQ (Language Integrated Query).
// Website & Documentation: https://github.com/zzzprojects/LINQ-Async
// Forum: https://github.com/zzzprojects/LINQ-Async/issues
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Z.Linq
{
    public class AsyncOrderedEnumerable<T> : IOrderedEnumerable<T>
    {
        public AsyncOrderedEnumerable(IOrderedEnumerable<T> source, CancellationToken cancellationToken)
        {
            CancellationToken = cancellationToken;
            Source = source;
        }

        public CancellationToken CancellationToken { get; set; }

        public IOrderedEnumerable<T> Source { get; set; }

        public IEnumerator<T> GetEnumerator()
        {
            return new AsyncEnumerator<T>(Source.GetEnumerator(), CancellationToken);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new AsyncEnumerator<T>(Source.GetEnumerator(), CancellationToken);
        }

        public IOrderedEnumerable<T> CreateOrderedEnumerable<TKey>(Func<T, TKey> keySelector, IComparer<TKey> comparer, bool descending)
        {
            return Source.CreateOrderedEnumerable(keySelector, comparer, descending);
        }

        public static AsyncOrderedEnumerable<T> CreateFrom(IOrderedEnumerable<T> source, CancellationToken cancellationToken)
        {
            return new AsyncOrderedEnumerable<T>(source, cancellationToken);
        }
    }
}