// Description: Async extension methods for LINQ (Language Integrated Query).
// Website & Documentation: https://github.com/zzzprojects/LINQ-Async
// Forum: https://github.com/zzzprojects/LINQ-Async/issues
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

namespace Z.Linq.Async
{
    public static class LinqAsyncManager
    {
        static LinqAsyncManager()
        {
            DefaultValue.OrderByPredicateCompletion = false;
            DefaultValue.StartPredicateConcurrently = false;
        }

        public static class DefaultValue
        {
            public static bool OrderByPredicateCompletion { get; set; }
            public static bool StartPredicateConcurrently { get; set; }
        }
    }
}