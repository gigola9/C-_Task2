using System;
using System.Text;

namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight:");
            double weigth = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your height:");
            double height = Double.Parse(Console.ReadLine());
            double bmi = weigth / height * 2;
            switch (bmi)
            {
                case < 16:
                    Console.WriteLine("wonis mwvave deficiti");
                    break;
                case < 18.5:
                    Console.WriteLine("wonis deficiti");
                    break;
                case < 25:
                    Console.WriteLine("normaluri wona");
                    break;
                case < 30:
                    Console.WriteLine("zedmeti wona");
                    break;
                default:
                    Console.WriteLine($"simsuqne");
                    break;
            }
        }
    }
}
