#define PRINCIPAL
class Ejercicio6
{
    public static bool factorial(ref int numero)
    {
        int facto = 1;
        if (numero < 0 || numero > 10)
        {
            return false;
        }
        else
        {
            for (int i = 1; i <= numero; i++)
            {
                facto = facto * i;
            }
        }
        numero = facto;
        return true;
    }

    public static void asterisco(int asteriscos)
    {
        Random generador = new Random();
        for (int i = 0; i < asteriscos; i++)
        {
            int num1 = generador.Next(1, 11);
            int num2 = generador.Next(1, 21);
            Console.SetCursorPosition(num1, num2);
            Console.WriteLine("*");
        }
    }

    public static void Main()
    {
        int numero;
        int asteriscos = 0;


#if PRINCIPAL
        Console.WriteLine("Introduzca un un numero del 1 al 10");
        numero = Convert.ToInt32(Console.ReadLine());
        factorial(ref numero);
        Console.WriteLine("El factorial del numero introducido es : " + numero);
#else
        Console.WriteLine("Introduzca el numero de asteríscos que quiere. (Dejar en blanco equivale a 10))");
        try
        {
            asteriscos = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException ex)
        {
            asteriscos = 10;
        }
#endif


    }
}


