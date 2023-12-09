using System;

namespace Task_5
{
    public delegate double Delegate(double num);
    internal class Program
    {
        static void Main(string[] args)
        {
            Delegate[] options = { (x) => Math.Sqrt(Math.Abs(x)), (x) => Math.Pow(x,3), (x) => x + 3.5 };

            Console.WriteLine("Вводьте рядки послідовно один за одним.\n" +
                              "Поки вони матимуть вигляд 0 х чи 1 х чи 2 х\n" +
                              "(тобто, цифра від 0 до 2, а після неї запис конкретного дійсного числа),\n" +
                              "програма обчислюватиме одну з трьох функцій\n" +
                              "\t0 -- sqrt(abs(x))\n" +
                              "\t1 -- x^3 (x*x*x)\n" +
                              "\t2 -- x + 3.5\n" +
                              "(згідно цифри на початку) і виводитиме результат.\n\n" +
                              "Якщо вхідний рядок не задовільнятиме цей формат, програма завершить роботу.");
            while (true)
            {
                try
                {
                    string[] data = Console.ReadLine().Trim().Split();
                    int[] array = new int[data.Length];
                    for (int i = 0; i < data.Length; i++)
                    { 
                        int num = int.Parse(data[i]);
                        array[i] = num;
                    }
                    double answer = options[array[0]](array[1]);
                    Console.WriteLine($"Answer: {answer}");
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("Invalid input. Please enter numbers only.");
                    break;
                }
            }
        }
    }
}
