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
    public class AsyncEnumerable : IEnumerable
    {
        public AsyncEnumerable(IEnumerable source, CancellationToken cancellationToken)
        {
            CancellationToken = cancellationToken;
            Source = source;
        }

        public CancellationToken CancellationToken { get; set; }

        public IEnumerable Source { get; set; }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new AsyncEnumerator(Source.GetEnumerator(), CancellationToken);
        }

        public static AsyncEnumerable CreateFrom(IEnumerable source, CancellationToken cancellationToken)
        {
            return new AsyncEnumerable(source, cancellationToken);
        }
    }
}