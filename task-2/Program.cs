using System;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input day:");
            string day = Console.ReadLine();
            switch (day)
            {
                case "monday":
                case "thuesday":
                case "wednesday":
                case "thursday":
                case "friday":
                    Console.WriteLine("working days");
                    break;
                case "saturday":
                    Console.WriteLine("Saturday");
                    break;
                case "sunday":
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine($"{day} is an incorrect name of a week days.");
                    break;
            }
        }
    }
}
