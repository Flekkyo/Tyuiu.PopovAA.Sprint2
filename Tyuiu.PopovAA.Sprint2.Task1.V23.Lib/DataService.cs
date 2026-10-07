using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PopovAA.Sprint2.Task1.V23.Lib
{
    public class DataService : ISprint2Task1V23
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a == b) | (c == (d * 2));
            res[1] = (a != c) & (b != (d * 3 + 106));
            res[2] = (a < d) || (b < c);
            res[3] = ((a * 3) > b) && (c > d);
            res[4] = !((b + c) <= (a + d));
            res[5] = (b >= a) ^ (d >= c);

            return res;
        }
    }
}
