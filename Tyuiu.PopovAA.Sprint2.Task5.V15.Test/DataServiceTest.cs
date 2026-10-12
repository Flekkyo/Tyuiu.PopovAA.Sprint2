using Tyuiu.PopovAA.Sprint2.Task5.V15.Lib;
namespace Tyuiu.PopovAA.Sprint2.Task5.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var x = 150;
            string res = ds.FindDayName(x);
            Assert.AreEqual("Среда", res);
        }
    }
}
