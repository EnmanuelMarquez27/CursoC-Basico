using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Números impares del 1 al 30:");

        for (int i = 1; i <= 30; i++)
        {
            if (i % 2 != 0) // si el residuo de dividir entre 2 no es 0, es impar
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}
