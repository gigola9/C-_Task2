using System;
using System.Collections.Generic;
using System.Linq;

namespace task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number");
            List<int> tmp = Console.ReadLine().ToList().Select(m => int.Parse(m.ToString())).ToList();
            string res = "True";
            int difference = tmp[1] - tmp[0];
            for(int i=1; i<tmp.Count-1; i++)
            {
                int currentDif = tmp[i + 1] - tmp[i];
                if (difference == currentDif)
                {
                    difference = currentDif;
                } else
                {
                    res = "False";
                    break;
                }
            }
            Console.WriteLine(res);
        }
    }
}
