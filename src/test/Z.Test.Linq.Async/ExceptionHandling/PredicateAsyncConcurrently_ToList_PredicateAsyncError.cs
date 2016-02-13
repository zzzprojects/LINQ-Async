using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Z.Linq;
using Z.Test.Linq.Async.Model;

namespace Z.Test.Linq.Async
{
    public partial class ExceptionHandling
    {
        [TestMethod]
        public async Task PredicateConcurrentlyAsync_ToList_PredicateAsyncError()
        {
            var list = new List<int> {1, 2, 3, 4, 5};
            var enumerable = new TestEnumerable<int>(list);
            var predicate = new TestPredicateAsync<int>(x => Task.FromResult(true));
            var predicateError = new TestPredicateAsync<int>(x => Task.FromResult(x < 10), x => Task.FromResult(x > 2));

            try
            {
                await enumerable.WhereAsync(x => predicate.Predicate(x)).ToList().Where(x => predicateError.Predicate(x)).StartPredicateConcurrently().ToList();

                throw new Exception("Oops!");
            }
            catch (AggregateException ex)
            {
                // MUST throw an error
                Assert.AreEqual("TestPredicateAsync;ErrorPredicateAsync;Value=3", ex.Flatten().InnerExceptions[0].Message);

                // MUST have 1 exception
                Assert.AreEqual(1, ex.Flatten().InnerExceptions.Count);

                // MUST have 5 iterations for enumerable
                Assert.AreEqual(4, enumerable.CurrentIndex);
            }
        }
    }
}