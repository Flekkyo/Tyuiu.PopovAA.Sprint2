using Tyuiu.PopovAA.Sprint2.Task6.V11.Lib;
namespace Tyuiu.PopovAA.Sprint2.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int g = 2019;
            int m = 12;
            int n = 15;
            var res = ds.FindDateOfNextDay(g, m, n);
            Assert.AreEqual("2019, 12, 16", res);
        }
    }
}
