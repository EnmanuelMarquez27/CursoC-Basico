using System;

class ProgramaMultiplicacion
{
    static void Main()
    {
        // Muestra un mensaje de bienvenida
        Console.WriteLine("Programa para multiplicar dos números");

        // Solicita el primer número al usuario
        Console.Write("Ingrese el primer número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine()); // Convierte la entrada a tipo double

        // Solicita el segundo número al usuario
        Console.Write("Ingrese el segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine()); // Convierte la entrada a tipo double

        // Realiza la multiplicación
        double resultado = numero1 * numero2;

        // Muestra el resultado
        Console.WriteLine($"El resultado de la multiplicación es: {resultado}");

        // Espera que el usuario presione una tecla para salir
        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}