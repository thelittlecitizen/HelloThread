using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace HelloThread
{
    class Program
    {
        public static int count;
        public static int countEmpire;
        public static int countMamas;
        public static object locker = new object();

        static void Main(string[] args)
        {
            Thread mamas = new Thread(() => PrintCount());
            mamas.IsBackground = false;
            mamas.Start();

            Thread empire = new Thread(() => PrintCount());
            empire.IsBackground = false;
            empire.Start();


            mamas.Join();
            empire.Join();

            Console.WriteLine($"mamas {countMamas} and empire {countEmpire}");
            
        }
        /*static void Print(string word)
        {
            for (int i = 0; i < 10000; i++)
                Console.WriteLine(word);
        }*/
        static void PrintCount()
        {
            while (count < 10000)
            {
                if (count % 2 == 1)
                {
                    Console.WriteLine("Empire");
                   // count++;
                    countEmpire++;
                }

                if (count % 2 == 0)
                {
                    Console.WriteLine("Mamas");
                   // count++;
                    countMamas++;
                }
                lock (locker)
                {
                    count++;

                }
            }

        }


    }
}
