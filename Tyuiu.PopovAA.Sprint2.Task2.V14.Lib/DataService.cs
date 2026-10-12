using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PopovAA.Sprint2.Task2.V14.Lib
{
    public class DataService : ISprint2Task2V14
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res = false;

            if ((x == 2) && (y == 4 || y == 5))
            {
                res = true;
            }

            if ((3 <= x && x <= 5) && (3 <= y && y <= 7 || y == 11))
            {
                res = true;
            }

            if ((x == 6) && (5 <= y && y <= 11))
            {
                res = true;
            }

            if ((7 <= x && x <= 8) && (5 <= y && y <= 12))
            {
                res = true;
            }

            if ((x == 9) && (y == 5 || y == 11 || y == 12))
            {
                res = true;
            }

            if ((x == 10) && (2 <= y && y <= 5 || y == 11 || y == 12))
            {
                res = true;
            }

            if ((11 <= x && x <= 12) && (2 <= y && y <= 5 || y == 11))
            {
                res = true;
            }

            if ((x == 13) && (2 <= y && y <= 3 || 9 <= y && y <= 13))
            {
                res = true;
            }
            return res;
        }
    }
}
