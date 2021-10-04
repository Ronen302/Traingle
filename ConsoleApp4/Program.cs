using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = 3, c = 4;
            if (ABC(a, b, c))
                Console.WriteLine($"Периметр треугольника = {PABC(a, b, c)}");
            Console.WriteLine($"Площадь треугольника = {SABC(a, b, c)}");
        }
        static bool ABC(int a, int b, int c)
        {
            if ((a + b > c) && (a + c > b) && (b + c > a))
                return true;
            else
                return false;
        }
        static int PABC(int a, int b, int c)
        {
            return a + b + c;
        }
        static Double SABC(int a, int b, int c)
        {
            int S = PABC(a, b, c);
            return (int)Math.Sqrt((S * (S - a) * (S - b) * (S - c)) / 4);
        }
    }
}
