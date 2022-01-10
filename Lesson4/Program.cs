using System;

namespace Lesson4
{
    class Program
    {
        enum season { Seasons, Winter, Spring, Summer, Autumn }
        static season OfMonth(int month)
        {
            try
            {
                if (month <= 0 || month > 12)
                    throw new Exception("Ошибка! Введите число от 1 до 12");
                switch ((month % 12) / 3)
                {
                    case 0:
                        return season.Winter;
                    case 1:
                        return season.Spring;
                    case 2:
                        return season.Summer;
                    default: 
                        return season.Autumn;
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                return season.Seasons;
            }
        }
        static string Season(season s)
        {
            switch (s)
            {
                case season.Winter:
                    return "Зима";
                case season.Spring:
                    return "Весна";
                case season.Summer:
                    return "Лето";
                case season.Autumn:
                    return "Осень";
                default: return "";
            }
        }
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Введите номер месяца: ");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Season(OfMonth(month)));
            }
            while (true);
        }

    }
}

