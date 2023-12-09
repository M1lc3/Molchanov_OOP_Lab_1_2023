using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int>  { 1, 2, 3, 7, 6, 9, 14, 25, 36, 49 };
            var by3 = array.Where(x => x % 3 == 0); // 
            string answer = "Numbers divisible by 3: ";
            foreach (int number in by3)
            {
                answer = answer + number.ToString() + " ";
            }
            var by7 = array.Where(x => x % 7 == 0); //
            answer = answer + "\nNumbers divisible by 7: ";
            foreach (int number in by7)
            {
                answer = answer + number.ToString() + " ";
            }
            Console.WriteLine(answer); 
            Console.ReadKey();

        }
    }
}
