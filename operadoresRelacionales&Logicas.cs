using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite su edad:");

        // Intentamos convertir la entrada del usuario a un número entero
        if (!int.TryParse(Console.ReadLine(), out int edad) || edad <= 0)
        {
            Console.WriteLine("Edad no válida. Por favor, ingrese un número positivo.");
            return;
        }

        // Determinamos la categoría según la edad
        if (edad < 18)
        {
            Console.WriteLine($"Con {edad} años, eres menor de edad.");
        }
        else if (edad <= 64)
        {
            Console.WriteLine($"Con {edad} años, eres adulto.");
        }
        else
        {
            Console.WriteLine($"Con {edad} años, eres adulto mayor.");
        }
    }
}
