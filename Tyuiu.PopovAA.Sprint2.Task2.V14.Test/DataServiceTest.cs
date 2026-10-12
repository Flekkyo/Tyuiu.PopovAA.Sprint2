using Tyuiu.PopovAA.Sprint2.Task2.V14.Lib;
namespace Tyuiu.PopovAA.Sprint2.Task2.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 10;
            int y = 12;
            var res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(true, res);
        }
    }
}
