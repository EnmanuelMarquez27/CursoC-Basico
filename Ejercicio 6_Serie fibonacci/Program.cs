using System;

class Program
{
    static void Main()
    {
        int a = 0;
        int b = 1;

        Console.WriteLine("Serie Fibonacci del 1 al 50:");

        while (b <= 50)
        {
            if (b >= 1)
            {
                Console.WriteLine(b);
            }

            int siguiente = a + b;
            a = b;
            b = siguiente;
        }

        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}