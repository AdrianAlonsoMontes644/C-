#define FRASE
class Ejercicio2
{
    public static void Main()
    {
        Console.WriteLine("Introduzca una frase");
        String frase1 = Console.ReadLine();
        Console.WriteLine("Introduzca una segunda frase");
        String frase2 = Console.ReadLine();
#if FRASE
        Console.WriteLine(" {0} \t {1} \n {0} \n {1}", frase1, frase2);
#else
        Console.WriteLine("\"{0}\" \\{1}\\", frase1, frase2);
#endif
    }
}
