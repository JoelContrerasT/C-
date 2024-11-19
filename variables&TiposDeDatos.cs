using System;

class Program
{
    static void Main(string[] args)
    {
        // Declarar variables
        int edad = 20;
        decimal altura = 1.75m;
        string nombre = "Joel Contreras";
        bool esEstudiante = true;

        // Edad dentro de 10 años
        int edadFuturo = edad + 10;

        // Mostrar variables con interpolación de cadenas
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Altura: {altura} m");
        Console.WriteLine($"¿Es estudiante? {esEstudiante}");
        Console.WriteLine($"Edad en 10 años: {edadFuturo}");

        // Final del programa
        Console.WriteLine("\nPrograma finalizado.");
    }
}
