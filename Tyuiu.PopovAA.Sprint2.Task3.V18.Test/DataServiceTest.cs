using Tyuiu.PopovAA.Sprint2.Task3.V18.Lib;
namespace Tyuiu.PopovAA.Sprint2.Task3.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var x = -50;
            var res = ds.Calculate(x);
            Assert.AreEqual(-549.98, res);
        }
    }
}
