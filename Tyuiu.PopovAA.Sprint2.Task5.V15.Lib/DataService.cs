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
                    return "Понедельник";

                case 2:
                    return "Вторник";

                case 3:
                    return "Среда";

                case 4:
                    return "Четверг";

                case 5:
                    return "Пятница";

                case 6:
                    return "Суббота";

                default:
                    return "Воскресенье";
            }
        }
    }
}
