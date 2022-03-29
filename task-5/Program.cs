using System;

namespace task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double usd = 3.12;
            double eur = 3.45;
            double gbp = 4.19;
            Console.WriteLine("Enter amount: ");
            double gel = double.Parse(Console.ReadLine());
            Console.WriteLine($"USD - { gel / usd}");
            Console.WriteLine($"EUR - { gel / eur}");
            Console.WriteLine($"GBP - { gel / gbp}");
        }
    }
}
