using System;

namespace Task_4
{
    public delegate double Delegate(double num);

    internal class Program
    {
        static double Sum(Delegate _delegate, double num)
        {
            double sum = 0;
            double term = 1;
            for (int i = 0 ; Math.Abs(term) > num; i++) 
            {
                term = _delegate(i);
                sum += term;
            }
            return sum;
        }

        static double Func1(double num)
        {
            return 1 / Math.Pow(2, num);
        }

        static double Func2(double num) 
        {
            double factorial = 1;

            for (int i = 2; i <= num; i++)
            {
                factorial *= i;
            }

            return 1 / factorial;
        }

        static double Func3(double num)
        {
            return Math.Pow(-1, num) / Math.Pow(2, num);
        }


        static void Main(string[] args)
        {
            double lim = 0.01;
            Console.WriteLine($"Sum of Func 1: {Sum(Func1, lim)}");
            Console.WriteLine($"Sum of Func 2: {Sum(Func2, lim)}");
            Console.WriteLine($"Sum of Func 3: {Sum(Func3, lim)}");
        }
    }
}
