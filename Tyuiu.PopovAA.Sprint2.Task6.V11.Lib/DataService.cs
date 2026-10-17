using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PopovAA.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            switch (m, n)
            {
                case (1, 31): return $"{g}, {m + 1}, 1";
                case (2, 28): return $"{g}, {m + 1}, 1";
                case (3, 31): return $"{g}, {m + 1}, 1";
                case (4, 30): return $"{g}, {m + 1}, 1";
                case (5, 31): return $"{g}, {m + 1}, 1";
                case (6, 30): return $"{g}, {m + 1}, 1";
                case (7, 31): return $"{g}, {m + 1}, 1";
                case (8, 31): return $"{g}, {m + 1}, 1";
                case (9, 30): return $"{g}, {m + 1}, 1";
                case (10, 31): return $"{g}, {m + 1}, 1";
                case (11, 30): return $"{g}, {m + 1}, 1";
                case (12, 31): return $"{g + 1}, 1, 1";
                default: return $"{g}, {m}, {n + 1}";
            }
        }
    }
}
