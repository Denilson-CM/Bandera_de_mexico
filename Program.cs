using System;

namespace Bandera_de_mexico
{
    class Program
    {
        static void Main(string[] args)
        {
            Body body;
            bool quit;
            do
            {
                Console.WriteLine("¡¡VIVAAAA MÉXICOOO!!...");
                ConsoleKeyInfo key = Console.ReadKey(true);

                Console.Clear();
                body = null;
                quit = false;
                switch (key.Key)
                {
                    case ConsoleKey.Enter:
                        body = new Paint();
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("No quieres a tu patria");
                        Console.ReadKey(true);
                        break;
                }

                if (body != null)
                {
                    Console.Clear();
                    body.Draw();
                    Console.ReadKey(true);
                    Console.ResetColor();
                }
            } while (!quit);

        }
    }
}
