using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Z.Linq;

namespace Z.Test.Linq.Async
{
    public partial class ExceptionHandling
    {
        [TestMethod]
        public async Task ToListError()
        {
            var list = new List<int> {1, 2, 3, 4, 5};
            var enumerableError = new TestEnumerable<int>(list, x => x > 2);

            try
            {
                await enumerableError.ToListAsync();

                throw new Exception("Oops!");
            }
            catch (Exception ex)
            {
                // MUST throw an error
                Assert.AreEqual("TestEnumerable;ErrorPredicate;Value=3", ex.Message);

                // MUST have only 3 iterations for enumerableError
                Assert.AreEqual(2, enumerableError.CurrentIndex);
            }
        }
    }
}