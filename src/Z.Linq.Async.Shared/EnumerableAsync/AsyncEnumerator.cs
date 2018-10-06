// Description: Async extension methods for LINQ (Language Integrated Query).
// Website & Documentation: https://github.com/zzzprojects/LINQ-Async
// Forum: https://github.com/zzzprojects/LINQ-Async/issues
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

using System.Collections;
using System.Threading;

namespace Z.Linq
{
    public class AsyncEnumerator : IEnumerator
    {
        public AsyncEnumerator(IEnumerator source, CancellationToken cancellationToken)
        {
            CancellationToken = cancellationToken;
            Source = source;
        }

        public CancellationToken CancellationToken { get; set; }

        public IEnumerator Source { get; set; }

        public object Current
        {
            get { return Source.Current; }
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