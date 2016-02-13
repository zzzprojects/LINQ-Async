using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Z.Linq;
using Z.Linq.Async;
using Z.Test.Linq.Async.Model;

namespace Z.Test.Linq.Async
{
    public partial class StartPredicateConcurrently
    {
        [TestMethod]
        public async Task Manager_IsTrue_Order_IsTrue()
        {
            var resultPredicate = new List<int>();
            var list = new List<int> { 1, 2, 3, 4, 5 };
            var enumerable = new TestEnumerable<int>(list);
            var predicateAsync = new TestPredicateAsync<int>(i =>
            {
                switch (i)
                {
                    case 1:
                        return Task.Delay(600).ContinueWith(task =>
                        {
                            resultPredicate.Add(i);
                            return true;
                        });
                    case 2:
                        return Task.Delay(200).ContinueWith(task =>
                        {
                            resultPredicate.Add(i);
                            return true;
                        });
                    case 3:
                        return Task.Delay(800).ContinueWith(task =>
                        {
                            resultPredicate.Add(i);
                            return true;
                        });
                    case 4:
                        return Task.Delay(500).ContinueWith(task =>
                        {
                            resultPredicate.Add(i);
                            return true;
                        });
                    case 5:
                        return Task.Delay(300).ContinueWith(task =>
                        {
                            resultPredicate.Add(i);
                            return true;
                        });
                    default:
                        throw new Exception("Oops!");
                }
            });

            var defaultValue = LinqAsyncManager.DefaultValue.StartPredicateConcurrently;

            try
            {
                LinqAsyncManager.DefaultValue.StartPredicateConcurrently = true;

                var result = await enumerable.WhereAsync(x => predicateAsync.Predicate(x)).StartPredicateConcurrently(true).ToList();

                // MUST have 5 iterations for enumerable
                Assert.AreEqual(4, enumerable.CurrentIndex);

                // MUST Keep the original order
                Assert.AreEqual(1, result[0]);
                Assert.AreEqual(2, result[1]);
                Assert.AreEqual(3, result[2]);
                Assert.AreEqual(4, result[3]);
                Assert.AreEqual(5, result[4]);

                // MUST be ordered be completion for predicate
                Assert.AreEqual(2, resultPredicate[0]);
                Assert.AreEqual(5, resultPredicate[1]);
                Assert.AreEqual(4, resultPredicate[2]);
                Assert.AreEqual(1, resultPredicate[3]);
                Assert.AreEqual(3, resultPredicate[4]);
            }
            finally
            {
                LinqAsyncManager.DefaultValue.StartPredicateConcurrently = defaultValue;
            }
        }
    }
}