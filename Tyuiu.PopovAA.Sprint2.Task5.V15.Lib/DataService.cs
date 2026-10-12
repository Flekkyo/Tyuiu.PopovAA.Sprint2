using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.PopovAA.Sprint2.Task5.V15.Lib
{
    public class DataService : ISprint2Task5V15
    {
        public string FindDayName(int k)
        {
            switch (k % 7)
            {
                case 1:
                    return $"{k}-й день - Понедельник";

                case 2:
                    return $"{k}-й день - Вторник";

                case 3:
                    return $"{k}-й день - Среда";

                case 4:
                    return $"{k}-й день - Четверг";

                case 5:
                    return $"{k}-й день - Пятница";

                case 6:
                    return $"{k}-й день - Суббота";

                default:
                    return $"{k}-й день - Воскресенье";
            }
        }
    }
}
