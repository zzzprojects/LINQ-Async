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
        public async Task PredicateAsyncError()
        {
            var list = new List<int> {1, 2, 3, 4, 5};
            var enumerable = new TestEnumerable<int>(list);
            var predicateError = new TestPredicateAsync<int>(x => Task.FromResult(x < 10), x => Task.FromResult(x > 2));

            try
            {
                await enumerable.WhereAsync(x => predicateError.Predicate(x)).ToList();

                throw new Exception("Oops!");
            }
            catch (AggregateException ex)
            {
                // MUST throw an error
                Assert.AreEqual("TestPredicateAsync;ErrorPredicateAsync;Value=3", ex.Flatten().InnerExceptions[0].Message);

                // MUST have 1 exception
                Assert.AreEqual(1, ex.Flatten().InnerExceptions.Count);

                // MUST have 2 iterations for enumerable
                Assert.AreEqual(2, enumerable.CurrentIndex);

                // MUST have 3 iterations for predicateError
                Assert.AreEqual(3, predicateError.Count);
            }
        }
    }
}