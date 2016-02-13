using System;
using System.Collections;
using System.Collections.Generic;
using Z.Test.Linq.Async.Model;

namespace Z.Test.Linq.Async
{
    public class TestEnumerable<T> : IEnumerable<T>
    {
        public TestEnumerable(List<T> originalValues)
        {
            CurrentIndex = -1;
            OriginalValues = originalValues;
        }

        public TestEnumerable(List<T> originalValues, Func<T, bool> errorPredicate)
        {
            CurrentIndex = -1;
            ErrorPredicate = errorPredicate;
            OriginalValues = originalValues;
        }

        public List<T> OriginalValues { get; set; }

        public int CurrentIndex { get; set; }

        public Func<T, bool> ErrorPredicate { get; set; }

        public IEnumerator<T> GetEnumerator()
        {
            return new TestEnumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}