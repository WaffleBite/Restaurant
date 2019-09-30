using System;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();

                Console.WriteLine("[1] Add order");
                Console.WriteLine("[2] List order");
                Console.WriteLine("[3] Exit");

                ConsoleKeyInfo keyPressed = Console.ReadKey(true);

                Console.Clear();

                switch (keyPressed.Key)
                {
                    case ConsoleKey.D1:

                        break;

                    case ConsoleKey.D2:

                        break;

                    case ConsoleKey.D3:

                        break;
                }
            }
        }
    }
}
