using System;

namespace task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input score:");
            int score = int.Parse(Console.ReadLine());
            string resText = "You've passed the exam. The result - ";
            switch (score)
            {
                case < 50:
                    Console.WriteLine("You've failed the exam... :(");
                    break;
                case <= 60:
                    Console.WriteLine($"{resText}E");
                    break;
                case <= 70:
                    Console.WriteLine($"{resText}F");
                    break;
                case <= 80:
                    Console.WriteLine($"{resText}G");
                    break;
                case <= 90:
                    Console.WriteLine($"{resText}B");
                    break;
                case <= 99:
                    Console.WriteLine($"{resText}A");
                    break;
                case 100:
                    Console.WriteLine("You've passed the exam. You're an excellent student! The result - A");
                    break;
                default:
                    Console.WriteLine($"Incorrect score");
                    break;
            }
        }
    }
}
