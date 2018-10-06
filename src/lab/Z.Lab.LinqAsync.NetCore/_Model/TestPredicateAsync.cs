using System;
using System.Threading.Tasks;

namespace Z.Test.Linq.Async.Model
{
    public class TestPredicateAsync<T>
    {
        public Func<T, Task<bool>> ErrorPredicate;
        public Func<T, Task<bool>> OriginalPredicate;

        public TestPredicateAsync(Func<T, Task<bool>> originalPredicate)
        {
            OriginalPredicate = originalPredicate;
        }

        public TestPredicateAsync(Func<T, Task<bool>> originalPredicate, Func<T, Task<bool>> errorPredicate)
        {
            ErrorPredicate = errorPredicate;
            OriginalPredicate = originalPredicate;
        }

        public int Count { get; set; }


        public async Task<bool> Predicate(T item)
        {
            Count++;

            if (ErrorPredicate != null && await ErrorPredicate(item).ConfigureAwait(false))
            {
                throw new Exception("TestPredicateAsync;ErrorPredicateAsync;Value=" + item);
            }

            return await OriginalPredicate(item).ConfigureAwait(false);
        }
    }
}