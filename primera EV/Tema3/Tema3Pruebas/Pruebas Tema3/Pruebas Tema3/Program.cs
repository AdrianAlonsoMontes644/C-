using System;
using System.Collections;
public delegate int Operation(int a, int b);
class Program
{
    static void Main()
    {
        /*
        
        int[] v = { 5, 1, 4, 0 };
        DateTime date = DateTime.Now;
        //Uso var para evitar el using y una declaración excesivamente larga

        var culture = new System.Globalization.CultureInfo("es-ES");
        String day = culture.DateTimeFormat.GetDayName(date.DayOfWeek);
        Console.WriteLine($"¡Hola! Hoy es {day}, y son las {date:HH:mm}.");
        Console.WriteLine("Veamos el contenido de un vector");

        for (int i = 0; i < v.Length; i++)
        {
            Console.WriteLine($"Posición: {i,3}\tValor: {v[i],3}");
        }
        
        */

        /*

        Hashtable edades = new Hashtable();
        //Dictionary<String, int> edades = new Dictionary<string, int>(); /*TIPADA*\
        // Introducir elementos (calve, valor)
        edades.Add("Ana", 20);
        edades.Add("Juan", 31);
        edades.Add("Pablo", 2);
        edades.Add("Maria", 12);
        // Mostrar un elemento mediante hashing
        Console.WriteLine("Ana tiene {0} años", edades["Ana"]);
        //Recorrer la colección pares clave/valor
        foreach (DictionaryEntry de in edades)
        {
            Console.WriteLine("{0} tiene {1} años", de.Key, de.Value);
        }
        //SUSTITUYE A LA ANTERIOR EN LA FORMA TIPADA
        /*foreach (KeyValuePair<string, int> de in edades)
        {
            Console.WriteLine("{0} tiene {1} años", de.Key, de.Value);
        }*\

        //Recorrer la colección solo de valores
        foreach (int de in edades.Values)
        {
            Console.WriteLine(de);
        }
        //Recorrer la colección solo de claves
        foreach (string de in edades.Keys)
        {
            Console.WriteLine(de);
        }

        */


        /*
        int num;
        bool error = false;
        do
        {
            //Planteamos un bucle para volver a ejecutar la opción
            try
            {
                error = false;
                Console.WriteLine("Por favor, introduce un número positivo");
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 0)
                    throw new System.ArgumentOutOfRangeException();

                //Mediante checked se controlan desbordamientos en operaciones
                checked
                {
                    Console.WriteLine("El cuadrado de {0} es {1}", num, num * num);
                }
            }//Fin del try
            catch (System.FormatException)
            {
                Console.WriteLine("Ha introducido un valor no numérico o no entero");
                error = true;
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("Número demasiado grande para obtener su cuadrado");
                error = true;
            }

            catch (System.ArgumentOutOfRangeException)
            {
                Console.WriteLine("Se ha pedido un número positivo");
                error = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error del tipo:\n\t{0}", e.ToString());
                Environment.Exit(-1);
            }
        } while (error);
        */

        /*
        Operation op = (a, b) => a - b;
        string res;
        int n1, n2;
        Console.WriteLine("Do you want to add or substract?(A/S)");
        res = Console.ReadLine().Trim().ToUpper();
        if (res == "A")
        {
            op = (a, b) => a + b;
        }
        Console.WriteLine("Input first operand");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input second operand");
        n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Result: {0}", op(n1, n2));
        Console.ReadKey();
        */
    }
}
