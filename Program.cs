// Console.WriteLine("Enter a three-digit number.:");
// int n = Convert.ToInt32(Console.ReadLine());
// if(n>99)
//     {
//         Console.WriteLine(n.ToString()[2]);
//     }
//     else
//     {
//         Console.WriteLine("no third digit");
//     }
using System;
 
namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while (true)
            {
                Console.Write("Введите число: ");
                if (int.TryParse(Console.ReadLine(), out number)) 
                    break;
                else
                    Console.WriteLine("Неверное число.");
            }
            int oldValue = number;
            int newValue = 0;
            while (number > 0)
            {
                int dig = number % 10;
                newValue = newValue * 10 + dig;
                number = number / 10;
            }
            if (newValue == oldValue)
                Console.WriteLine("Да");
            else
                Console.WriteLine("Нет");
            Console.Write("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}

