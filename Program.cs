using System;

class Program
{
    static void Main()
    {
        // 1. La Calculadora Modular:
        Console.WriteLine("\n -- Calculadora Modular --");
        Console.WriteLine("Ingresa los numeros a calcular: \n");
        Console.Write("Primer numero: ");
        int a = int.Parse(Console.ReadLine()!);
        Console.Write("Segundo numero: ");
        int b = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"\nEl resultado sumarlos es: {Funciones.Sumar(a, b)}");
        Console.WriteLine($"El resultado restarlos es: {Funciones.Resta(a, b)}");
        Console.WriteLine($"El resultado Multiplicarlos es: {Funciones.Multiplicacion(a, b)}");
        Console.WriteLine($"El resultado dividirlos es: {Funciones.Division(a, b)} \n");

        // 2. El Validador de Acceso (Void):
        Console.WriteLine("\n -- Validador de Acceso (Void) --");
        Console.Write("¿Cuantos años tienes? ");
        int edad = int.Parse(Console.ReadLine()!);
        Funciones.ValidadEdad(edad);


        // 3. El Formulario Flexible:
        Console.WriteLine("\n -- El Formulario Flexible --");
        Console.Write("¿Cual es tu nombre? ");
        string nombre = Console.ReadLine()!;
        Console.Write("¿Cual es tu hobby? ");
        string hobby = Console.ReadLine()!;

        if(string.IsNullOrEmpty(hobby))Funciones.FormularioFlexible(nombre);
        else Funciones.FormularioFlexible(nombre, hobby);
        
        Funciones.FormularioFlexible(nombre);
    }
}   
