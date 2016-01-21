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
using Z.Linq.Async;

namespace Z.Linq
{
    public static partial class TaskFactoryExtensions
    {
        public static Task<TResult> FromEnumerable<T, TResult>(this TaskFactory taskFactory, IEnumerable<T> source, Func<IEnumerable<T>, TResult> func, CancellationToken cancellationToken = default(CancellationToken))
        {
            return FromTaskEnumerable(taskFactory, source, func, AsyncEnumerable<T>.CreateFrom, cancellationToken);
        }

        public static Task<TResult> FromEnumerable<T, TP1, TResult>(this TaskFactory taskFactory, IEnumerable<T> source, TP1 p1, Func<IEnumerable<T>, TP1, TResult> func, CancellationToken cancellationToken = default(CancellationToken))
        {
            return FromTaskEnumerable(taskFactory, source, enums => func(enums, p1), AsyncEnumerable<T>.CreateFrom, cancellationToken);
        }

        public static Task<TResult> FromEnumerable<T, TP1, TP2, TResult>(this TaskFactory taskFactory, IEnumerable<T> source, TP1 p1, TP2 p2, Func<IEnumerable<T>, TP1, TP2, TResult> func, CancellationToken cancellationToken = default(CancellationToken))
        {
            return FromTaskEnumerable(taskFactory, source, enums => func(enums, p1, p2), AsyncEnumerable<T>.CreateFrom, cancellationToken);
        }

        public static Task<TResult> FromEnumerable<T, TP1, TP2, TP3, TResult>(this TaskFactory taskFactory, IEnumerable<T> source, TP1 p1, TP2 p2, TP3 p3, Func<IEnumerable<T>, TP1, TP2, TP3, TResult> func, CancellationToken cancellationToken = default(CancellationToken))
        {
            return FromTaskEnumerable(taskFactory, source, enums => func(enums, p1, p2, p3), AsyncEnumerable<T>.CreateFrom, cancellationToken);
        }

        public static Task<TResult> FromEnumerable<T, TP1, TP2, TP3, TP4, TResult>(this TaskFactory taskFactory, IEnumerable<T> source, TP1 p1, TP2 p2, TP3 p3, TP4 p4, Func<IEnumerable<T>, TP1, TP2, TP3, TP4, TResult> func, CancellationToken cancellationToken = default(CancellationToken))
        {
            return FromTaskEnumerable(taskFactory, source, enums => func(enums, p1, p2, p3, p4), AsyncEnumerable<T>.CreateFrom, cancellationToken);
        }

        public static Task<TResult> FromEnumerable<T, TP1, TP2, TP3, TP4, TP5, TResult>(this TaskFactory taskFactory, IEnumerable<T> souce, TP1 p1, TP2 p2, TP3 p3, TP4 p4, TP5 p5, Func<IEnumerable<T>, TP1, TP2, TP3, TP4, TP5, TResult> func, CancellationToken cancellationToken = default(CancellationToken))
        {
            return FromTaskEnumerable(taskFactory, souce, enums => func(enums, p1, p2, p3, p4, p5), AsyncEnumerable<T>.CreateFrom, cancellationToken);
        }

        public static Task<TResult> FromEnumerable<T, TP1, TResult>(this TaskFactory taskFactory, IEnumerable<T> source, TP1 p1, Func<IEnumerable<T>, TP1, TResult> func, Func<T, Task<bool>> funcAsync, CancellationToken cancellationToken = default(CancellationToken))
        {
            return FromTaskEnumerable(taskFactory, source, enums => func(enums, p1), AsyncEnumerable<T>.CreateFrom, cancellationToken);
        }

        public static Task<TResult> FromEnumerable<T, TResult>(this TaskFactory taskFactory, IEnumerable<T> source, Func<T, Task<bool>> predicate, Func<IEnumerable<T>, Func<T, bool>, TResult> func, CancellationToken cancellationToken = default(CancellationToken))
        {
            source = new AsyncWhereEnumerable<T>(source, predicate, cancellationToken);

            Func<T, bool> predicateOrdered = source1 => predicate(source1).Result;
            return Task.Factory.FromEnumerable(source, predicateOrdered, func, cancellationToken);
        }
    }
}