using System;
using System.Threading;

namespace Task_2
{
    public delegate void Delegate();
    public class Timer
    {
        private Delegate delegateDelegate;
        private int delay;

        public Timer(Delegate delegateDelegate, int delay)
        {
            this.delegateDelegate = delegateDelegate;
            this.delay = delay;
        }

        public void Dispose()
        {
            if (delegateDelegate != null) { delegateDelegate = null; }
            Console.WriteLine("Dispose");
        }

        public void Start()
        {
            Thread.Sleep(delay * 1000);
            delegateDelegate();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Timer timer = new Timer(Print, 1);
                Timer timer = new Timer(() => Console.WriteLine("Funny words"), 1);
                timer.Start();
                timer.Dispose();
            }
        }
    }
}
