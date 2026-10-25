using Tyuiu.PopovAA.Sprint2.Task7.V11.Lib;
namespace Tyuiu.PopovAA.Sprint2.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var x = -0.2;
            var y = -0.5;
            var res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(true, res); 
        }
    }
}
