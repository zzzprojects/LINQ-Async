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
    public class AsyncEnumerator<T> : IEnumerator<T>
    {
        public AsyncEnumerator(IEnumerator<T> source, CancellationToken cancellationToken)
        {
            CancellationToken = cancellationToken;
            Source = source;
        }

        public CancellationToken CancellationToken { get; set; }

        public IEnumerator<T> Source { get; set; }

        public T Current
        {
            get { return Source.Current; }
        }

        object IEnumerator.Current
        {
            get { return Source.Current; }
        }

        public void Dispose()
        {
            Source.Dispose();
        }

        public bool MoveNext()
        {
            CancellationToken.ThrowIfCancellationRequested();
            return Source.MoveNext();
        }

        public void Reset()
        {
            Source.Reset();
        }
    }
}