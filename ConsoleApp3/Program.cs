using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число а");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите оператор");
            string c = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Введите число b");
            double b = Convert.ToDouble(Console.ReadLine());



            if (c == "+")
            {
                Console.WriteLine("Результат равен");
                Console.WriteLine(a + b);
            }
            if (c == "/")
            {
                Console.WriteLine("Результат равен");
                Console.WriteLine(a / b);
            }
            if (c == "-")
            {
                Console.WriteLine("Результат равен");
                Console.WriteLine(a - b);
            }
            if (c == "*")
            {
                Console.WriteLine("Результат равен");
                Console.WriteLine(a * b);
            }

        }
    }
}
