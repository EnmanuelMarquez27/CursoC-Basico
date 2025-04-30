using System;

class Program
{
    static void Main()
    {
        // Solicitar al usuario los coeficientes a, b y c
        Console.Write("Ingrese el valor de a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el valor de b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el valor de c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Calcular el discriminante
        double discriminante = b * b - 4 * a * c;

        // Verificar el tipo de soluciones
        if (discriminante > 0)
        {
            double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
            Console.WriteLine("La ecuación tiene dos soluciones reales:");
            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
        }
        else if (discriminante == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("La ecuación tiene una única solución real:");
            Console.WriteLine("x = " + x);
        }
        else
        {
            Console.WriteLine("La ecuación no tiene soluciones reales.");
        }

        // Esperar antes de cerrar
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}
