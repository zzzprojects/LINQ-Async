using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Z.Linq;

namespace Z.Test.Linq.Async
{
    public partial class SelectResult
    {
        [TestMethod]
        public async Task IsOrdered()
        {
            var listTask = new List<Task<int>>
            {
                Task.Delay(600).ContinueWith(task => 1),
                Task.Delay(200).ContinueWith(task => 2),
                Task.Delay(800).ContinueWith(task => 3),
                Task.Delay(500).ContinueWith(task => 4),
                Task.Delay(300).ContinueWith(task => 5)
            };

            var result = await listTask.SelectResult().ToList();

            // MUST be ordered be completion
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
            Assert.AreEqual(3, result[2]);
            Assert.AreEqual(4, result[3]);
            Assert.AreEqual(5, result[4]);
        }
    }
}