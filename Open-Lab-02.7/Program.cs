using System;

namespace Open_Lab_02._7
{
    class Program
    {
        public static bool IsTimeForMilkAndCookies(int year, int month, int day)
        {
            return (month == 12 && day == 24);
           
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year!");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month!");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter day!");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsTimeForMilkAndCookies(a, b, c));
        }
    }
}
