
public class Funciones
{
    /* Crea 4 funciones: Sumar, Restar, Multiplicar, Dividir. Todas deben recibir 2 números 
    y retornar (return) el resultado. */
    public static double Sumar(double a, double b)
    {
        double suma = a+b;
        return suma;
    }
    public static double Resta(double a, double b)
    {
        double resta = a-b;
        return resta;
    }

    public static double Multiplicacion(double a, double b)
    {
        double Multiplicacion = a+b;
        return Multiplicacion;
    }

    public static double Division(double a, double b)
    {
        double Division = a+b;
        return Division;
    }

        /* - Crea una función `ValidarEdad(int edad)`.
        - Si es < 18, imprime "Acceso Denegado".
       - Si es >= 18, imprime "Bienvenido". */
    
    public static void ValidadEdad(int edad)
    {
        if(edad < 18)
        {
            Console.WriteLine("Acceso Denegado");
        }
        else if(edad >= 18)
        {
            Console.WriteLine("Bienvenido");
        }
    }


    /* - Crea una función `CrearPerfil` que pida `nombre` (obligatorio) y `hobby` (opcional, valor por defecto "Dormir").
    - Llama la función dos veces: una con hobby y otra sin él. */

    public static void FormularioFlexible(string nombre, string hobby = "Domir")
    {
        Console.WriteLine($"\n Mi nombre es {nombre}\n y Mi hobby es {hobby}.");
    }
}