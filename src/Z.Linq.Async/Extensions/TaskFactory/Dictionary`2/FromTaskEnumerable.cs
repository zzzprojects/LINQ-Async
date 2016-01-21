// Description: Async extension methods for LINQ (Language Integrated Query).
// Website & Documentation: https://github.com/zzzprojects/LINQ-Async
// Forum: https://github.com/zzzprojects/LINQ-Async/issues
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Z.Linq
{
    public static partial class TaskFactoryExtensions
    {
        public static Task<TResult> FromTaskEnumerable<TKey, TValue, TResult>(this TaskFactory taskFactory, Task<Dictionary<TKey, TValue>> task, Func<IEnumerable<KeyValuePair<TKey, TValue>>, TResult> func, CancellationToken cancellationToken = default(CancellationToken))
        {
            return FromTaskEnumerable(taskFactory, task, func, AsyncEnumerable<KeyValuePair<TKey, TValue>>.CreateFrom, cancellationToken);
        }
    }
}