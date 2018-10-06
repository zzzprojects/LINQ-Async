using System;

namespace Z.Test.Linq.Async.Model
{
    public class TestPredicate<T>
    {
        public Func<T, bool> ErrorPredicate;
        public Func<T, bool> OriginalPredicate;

        public TestPredicate(Func<T, bool> originalPredicate)
        {
            OriginalPredicate = originalPredicate;
        }

        public TestPredicate(Func<T, bool> originalPredicate, Func<T, bool> errorPredicate)
        {
            ErrorPredicate = errorPredicate;
            OriginalPredicate = originalPredicate;
        }

        public int Count { get; set; }

        public bool Predicate(T item)
        {
            Count++;

            if (ErrorPredicate != null && ErrorPredicate(item))
            {
                throw new Exception("TestPredicate;ErrorPredicate;Value=" + item);
            }

            return OriginalPredicate(item);
        }
    }
}