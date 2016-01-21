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
    public static partial class TaskFactoryExtensions
    {
        public static Task<TResult> FromTaskEnumerable<TElement, TResult>(this TaskFactory taskFactory, Task<IOrderedEnumerable<TElement>> task, Func<IOrderedEnumerable<TElement>, TResult> func, CancellationToken cancellationToken = default(CancellationToken))
        {
            return FromTaskEnumerable(taskFactory, task, func, AsyncOrderedEnumerable<TElement>.CreateFrom, cancellationToken);
        }

        public static Task<TResult> FromTaskEnumerable<TElement, TP1, TResult>(this TaskFactory taskFactory, Task<IOrderedEnumerable<TElement>> task, TP1 p1, Func<IOrderedEnumerable<TElement>, TP1, TResult> func, CancellationToken cancellationToken = default(CancellationToken))
        {
            return FromTaskEnumerable(taskFactory, task, enums => func(enums, p1), AsyncOrderedEnumerable<TElement>.CreateFrom, cancellationToken);
        }

        public static Task<TResult> FromTaskEnumerable<TElement, TP1, TP2, TResult>(this TaskFactory taskFactory, Task<IOrderedEnumerable<TElement>> task, TP1 p1, TP2 p2, Func<IOrderedEnumerable<TElement>, TP1, TP2, TResult> func, CancellationToken cancellationToken = default(CancellationToken))
        {
            return FromTaskEnumerable(taskFactory, task, enums => func(enums, p1, p2), AsyncOrderedEnumerable<TElement>.CreateFrom, cancellationToken);
        }
    }
}