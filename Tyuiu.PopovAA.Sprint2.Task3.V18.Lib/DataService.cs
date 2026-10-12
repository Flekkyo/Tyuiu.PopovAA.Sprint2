using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PopovAA.Sprint2.Task3.V18.Lib
{
    public class DataService : ISprint2Task3V18
    {
        public double Calculate(double x)
        {
            double res = 0;
            if (x > 1)
            {
                res = Math.Pow(x, 2) * Math.Pow((x + 1) / (x - 1), x);
            }

            else if (x == 0)
            {
                res = (x * x - Math.Pow(Math.Acos(x), 2) + 10) / (x * x - Math.Pow(Math.Asin(x), 2) + 12);
            }

            else if (-22 < x && x < 2)
            {
                res = Math.Pow(1 + (1 / Math.Pow(x, 2)), x);
            }

            else
            {
                res = x + 10 * x - (1 / x);
            }
            return Math.Round(res, 3);
        }
    }
}
