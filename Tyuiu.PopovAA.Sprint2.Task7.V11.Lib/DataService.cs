using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PopovAA.Sprint2.Task7.V11.Lib
{
    public class DataService : ISprint2Task7V11
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if ((Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && (x <= y))
            {
                return true;
            }
            else if ((Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && (x <= 0))
            {
                return true;
            }
            else
            {
                return false; 
            }
        }
    }
}
