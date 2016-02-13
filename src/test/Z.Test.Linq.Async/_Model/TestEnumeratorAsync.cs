using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Z.Test.Linq.Async.Model
{
    public class TestEnumeratorAsync<T, TItem> : IEnumerator<T> where T : Task<TItem>
    {
        public TestEnumeratorAsync(TestEnumerableAsync<T, TItem> testTestEnumerable)
        {
            TestEnumerable = testTestEnumerable;
        }

        private TestEnumerableAsync<T, TItem> TestEnumerable { get; }

        public T Current
        {
            get
            {
                var currentValue = TestEnumerable.OriginalValues[TestEnumerable.CurrentIndex];
                if (TestEnumerable.ErrorPredicate != null)
                {
                    if (TestEnumerable.ErrorPredicate(currentValue))
                    {
                        throw new Exception("TestEnumerable;ErrorPredicate;Value=" + currentValue);
                    }
                }
                return (T) Task.Delay(100*(int) (object) currentValue);
            }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (TestEnumerable.CurrentIndex + 1 < TestEnumerable.OriginalValues.Count)
            {
                TestEnumerable.CurrentIndex++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            TestEnumerable.CurrentIndex = -1;
        }
    }
}