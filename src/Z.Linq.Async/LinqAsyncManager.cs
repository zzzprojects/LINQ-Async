// Description: Async extension methods for LINQ (Language Integrated Query).
// Website & Documentation: https://github.com/zzzprojects/LINQ-Async
// Forum: https://github.com/zzzprojects/LINQ-Async/issues
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

namespace Z.Linq.Async
{
    public class LinqAsyncManager
    {
        static LinqAsyncManager()
        {
            DefaultValueOrderByPredicateCompletion = false;
            DefaultValueStartAllPredicate = false;
        }

        public static bool DefaultValueOrderByPredicateCompletion { get; set; }
        public static bool DefaultValueStartAllPredicate { get; set; }
    }
}