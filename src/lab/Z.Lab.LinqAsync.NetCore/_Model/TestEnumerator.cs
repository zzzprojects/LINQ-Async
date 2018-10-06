using System;
using System.Collections;
using System.Collections.Generic;

namespace Z.Test.Linq.Async.Model
{
    public class TestEnumerator<T> : IEnumerator<T>
    {
        public TestEnumerator(TestEnumerable<T> testTestEnumerable)
        {
            TestEnumerable = testTestEnumerable;
        }

        private TestEnumerable<T> TestEnumerable { get; }

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
                return currentValue;
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