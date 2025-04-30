using System;

class ProgramaDivision
{
    static void Main()
    {
        Console.WriteLine("Programa para dividir dos números");

        Console.Write("Ingrese el primer número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        if (numero2 != 0)
        {
            double resultado = numero1 / numero2;
            Console.WriteLine($"El resultado de la división es: {resultado}");
        }
        else
        {
            Console.WriteLine("Error: No se puede dividir entre cero.");
        }

        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}