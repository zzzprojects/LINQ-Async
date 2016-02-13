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
        public async Task Predicate_ToList_PredicateError()
        {
            var list = new List<int> {1, 2, 3, 4, 5};
            var enumerable = new TestEnumerable<int>(list);
            var predicate = new TestPredicate<int>(x => x < 10);
            var predicateError = new TestPredicate<int>(x => x < 10, x => x > 2);

            try
            {
                await enumerable.WhereAsync(x => predicate.Predicate(x)).ToList().Where(x => predicateError.Predicate(x)).ToList();

                throw new Exception("Oops!");
            }
            catch (Exception ex)
            {
                // MUST throw an error
                Assert.AreEqual("TestPredicate;ErrorPredicate;Value=3", ex.Message);

                // MUST have 5 iterations for enumerable
                Assert.AreEqual(4, enumerable.CurrentIndex);

                // MUST have 5 iterations for predicate
                Assert.AreEqual(5, predicate.Count);

                // MUST have 3 iterations for predicateError
                Assert.AreEqual(3, predicateError.Count);
            }
        }
    }
}