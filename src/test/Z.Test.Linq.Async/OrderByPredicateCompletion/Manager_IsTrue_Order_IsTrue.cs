using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Z.Linq;
using Z.Linq.Async;
using Z.Test.Linq.Async.Model;

namespace Z.Test.Linq.Async
{
    public partial class OrderByPredicateCompletion
    {
        [TestMethod]
        public async Task Manager_IsTrue_Order_IsTrue()
        {
            var list = new List<int> {1, 2, 3, 4, 5};
            var enumerable = new TestEnumerable<int>(list);
            var predicateAsync = new TestPredicateAsync<int>(i =>
            {
                switch (i)
                {
                    case 1:
                        return Task.Delay(600).ContinueWith(task => true);
                    case 2:
                        return Task.Delay(200).ContinueWith(task => true);
                    case 3:
                        return Task.Delay(800).ContinueWith(task => true);
                    case 4:
                        return Task.Delay(500).ContinueWith(task => true);
                    case 5:
                        return Task.Delay(300).ContinueWith(task => true);
                    default:
                        throw new Exception("Oops!");
                }
            });

            var defaultValue = LinqAsyncManager.DefaultValue.OrderByPredicateCompletion;

            try
            {
                LinqAsyncManager.DefaultValue.OrderByPredicateCompletion = true;

                var result = await enumerable.WhereAsync(x => predicateAsync.Predicate(x)).OrderByPredicateCompletion(true).ToList();

                // MUST have 5 iterations for enumerable
                Assert.AreEqual(4, enumerable.CurrentIndex);

                // MUST be ordered be completion
                Assert.AreEqual(2, result[0]);
                Assert.AreEqual(5, result[1]);
                Assert.AreEqual(4, result[2]);
                Assert.AreEqual(1, result[3]);
                Assert.AreEqual(3, result[4]);
            }
            finally
            {
                LinqAsyncManager.DefaultValue.OrderByPredicateCompletion = defaultValue;
            }
        }
    }
}