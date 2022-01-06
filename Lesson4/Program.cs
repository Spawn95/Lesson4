using System;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first personal data");
            string firstInfo = GetFullName();
            
            Console.WriteLine("Enter second personal data");
            string secondInfo = GetFullName();
            
            Console.WriteLine("Enter third personal data");
            string thirdInfo = GetFullName();
            
            Console.WriteLine($"Users:\n{firstInfo} \n{secondInfo} \n{thirdInfo}");
        }
        static string GetFullName()
        {
            Console.WriteLine("Please enter your firstName, lastName and patronymic");
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string patronymic = Console.ReadLine();
            string infoUser = firstName + ' ' + lastName + ' ' + patronymic;
            Console.WriteLine($"Hello {infoUser}");
            return infoUser;
        }
    }
}
