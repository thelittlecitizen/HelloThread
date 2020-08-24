using System;
using System.Threading;

namespace HelloThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(() => Print("Mamas"));
            thread1.IsBackground = true;
            thread1.Start();
            Thread thread2 = new Thread(() => Print("Empire"));
            thread2.IsBackground = true;
            thread2.Start();
        
        static void Print(string word)
            {
                for (int i=0; i <1000; i++)
                    Console.WriteLine(word);
            }
                

        }
        
    }
}
