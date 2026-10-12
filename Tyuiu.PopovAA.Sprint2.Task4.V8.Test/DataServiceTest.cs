using Tyuiu.PopovAA.Sprint2.Task4.V8.Lib;
namespace Tyuiu.PopovAA.Sprint2.Task4.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var x = 2;
            var y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(6.5, res);
        }
    }
} 
