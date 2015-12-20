// Description: Async extension methods for LINQ (Language Integrated Query).
// Website & Documentation: https://github.com/zzzprojects/LINQ-Async
// Forum: https://github.com/zzzprojects/LINQ-Async/issues
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Z.Linq
{
    public class AsyncEnumerable<T> : IEnumerable<T>
    {
        public AsyncEnumerable(IEnumerable<T> source, CancellationToken cancellationToken)
        {
            CancellationToken = cancellationToken;
            Source = source;
        }

        public CancellationToken CancellationToken { get; set; }

        public IEnumerable<T> Source { get; set; }

        public IEnumerator<T> GetEnumerator()
        {
            return new AsyncEnumerator<T>(Source.GetEnumerator(), CancellationToken);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new AsyncEnumerator<T>(Source.GetEnumerator(), CancellationToken);
        }

        public static AsyncEnumerable<T> CreateFrom(IEnumerable<T> source, CancellationToken cancellationToken)
        {
            return new AsyncEnumerable<T>(source, cancellationToken);
        }
    }
}