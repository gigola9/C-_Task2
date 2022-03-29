using System;

namespace task_7
{
    internal class Program
    {
        static string convertNumber(int amount, int number)
        {
            string toStr = number.ToString();
            while (toStr.Length != amount)
            {
                toStr = " " + toStr;
            }
            return toStr;
        }

        static void Main(string[] args)
        {
            for(int i=1; i<=10; i++)
            {
                Console.WriteLine($"{convertNumber(2, i)}     {convertNumber(3, i * i)}");
            }
        }
    }
}
