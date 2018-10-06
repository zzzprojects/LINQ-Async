using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Z.Test.Linq.Async.Model;

namespace Z.Test.Linq.Async
{
    public class TestEnumerableAsync<T, TItem> : IEnumerable<T> where T : Task<TItem>
    {
        public TestEnumerableAsync(List<TItem> originalValues)
        {
            CurrentIndex = -1;
            OriginalValues = originalValues;
        }

        public TestEnumerableAsync(List<TItem> originalValues, Func<TItem, bool> errorPredicate)
        {
            CurrentIndex = -1;
            ErrorPredicate = errorPredicate;
            OriginalValues = originalValues;
        }

        public List<TItem> OriginalValues { get; set; }

        public int CurrentIndex { get; set; }

        public Func<TItem, bool> ErrorPredicate { get; set; }

        public IEnumerator<T> GetEnumerator()
        {
            return new TestEnumeratorAsync<T, TItem>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}