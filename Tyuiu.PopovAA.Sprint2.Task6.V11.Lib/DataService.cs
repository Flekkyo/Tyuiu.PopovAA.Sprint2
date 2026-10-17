using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PopovAA.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            switch (m, n)
            {
                case (01, 31): return $"01.02.{g}";
                case (02, 28): return $"01.03.{g}";
                case (03, 31): return $"01.04.{g}";
                case (04, 30): return $"01.05.{g}";
                case (05, 31): return $"01.06.{g}";
                case (06, 30): return $"01.07.{g}";
                case (07, 31): return $"01.08.{g}";
                case (08, 31): return $"01.09.{g}";
                case (09, 30): return $"01.10.{g}";
                case (10, 31): return $"01.11.{g}";
                case (11, 30): return $"01.12.{g}";
                case (12, 31): return $"01.01.{g + 1}";
                default: 
                    if (n < 10)
                    {
                        if (m < 10)
                        {
                            return $"0{n + 1}.0{m}.{g}";
                        }
                        else
                        {
                            return $"0{n + 1}.{m}.g";
                        }
                    }
                    else
                    {
                        return $"{n + 1}.{m}.{g}";
                    }
            }
        }
    }
} 
