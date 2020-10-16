using System;

namespace FactorialCalculator
{
    class Program
    {
        public static void WriteBoxLine(int lenght, char first, char middle, char end)
        {
            Console.Write(first);
            for (int i = 0; i < lenght; i++)
                Console.Write(middle);
            Console.WriteLine(end);
        }

        public static void WrireBoxLineSecond(string result, char stick)
        {
            Console.Write(stick);
            Console.Write(result);
            Console.WriteLine(stick);
        }

        static int CalculateFactorial(int x)
        {
            if (x == 0)
                return 1;
            else
                return x * CalculateFactorial(x - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x < 0)
                Console.WriteLine("Ошибка");
            else
            {
                int factorial = CalculateFactorial(x);
                string result = $"Факториал {x} = {factorial}";
                int lenght = result.Length;

                WriteBoxLine(lenght, '╔', '═', '╗');
                WrireBoxLineSecond(result, '║');
                WriteBoxLine(lenght, '╚', '═', '╝');
            }
        }
    }
}
