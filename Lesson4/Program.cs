using System;
using System.Collections.Generic;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello();
            string data = RecieveData();
            List<string> parts = SplitData(data);
            List<int> numbers = ConvertData(parts);
            int result = SummData(numbers);
            CheckResult(result);

        }
        static void Hello()
        {
            Console.WriteLine("Какое то начало");
        }
        static string RecieveData()
        {
            Console.WriteLine("Введите числа с пробелом, программа выведет сумму чисел.");
            return Console.ReadLine();
        }
        static List<string> SplitData(string data)
        {
            List<string> parts = new List<string>();
            if (string.IsNullOrWhiteSpace(data))
            {
                return parts;
            }
            parts.AddRange(data.Split(' '));
            return parts;
        }
        static List<int> ConvertData(List<string> parts)
        {
            List<int> numbers = new List<int>();
            foreach (var part in parts)
            {
                if (int.TryParse(part, out int number))
                {
                    numbers.Add(number);
                }
            }
            return numbers;
        }
        static int SummData(List<int> numbers)
        {
            int result = 0;
            foreach (var number in numbers)
            {
                result += number;
            }
            return result;
        }
        static void CheckResult(int result)
        {
            Console.WriteLine("Сумма чисел : " + result);
        }
    }
}

