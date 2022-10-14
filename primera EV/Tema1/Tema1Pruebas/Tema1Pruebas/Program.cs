#define PRUEBA
using System;
using System.Drawing;
using Tema1Pruebas;

namespace ConsoleApplication1
{

    class A
    {
        class Program
        {
            static void Main()
            {
                Perro objPerro = new Perro();
                objPerro.raza = "Mastín";
                objPerro.nombre = "Laika";
                objPerro.Edad=5;
                Console.WriteLine(objPerro.Edad);
                objPerro=null;
                GC.Collect();
                Console.ReadLine();
            }
        }

        /*public static void Main()
        {
    #if PRUEBA
            Console.Write("Esto es una prueba");
    #if TRAZA
            Console.Write(" con traza");
    #elif !TRAZA
            Console.Write(" sin traza");
    #endif
    #endif
        }*/
    }

    /*class MiClase
    {
        static void Main()
        {
            //String z = 10.ToString();
            //int b = null;
            //int? b = null;

            /*int a = 10;
            int b = 10;
            int c, d;
            c = a++; //incremento posterior a la asignacion
            d = ++b;

            Console.WriteLine("a: {0},\tb:{1}", a, b);
            Console.WriteLine("c: {0},\td:{1}", c, d);
            
            Console.WriteLine("Hello, World!");
            Console.WriteLine(@"Ho0la \ttabulao");

            /int i = 0;
            do
            {
                Console.WriteLine(i++); ;
            } while (i < 5);
            Console.WriteLine(); //Llega a 4

            i = 0;
            do
            {
                Console.WriteLine(++i); ;   //Llega a 5
            } while (i < 5);

            /*Random generador = new Random();
            double d;
            int r;
            //Nº real entre 0 y 1 (excluido)
            d = generador.NextDouble();
            //Nº entero entre 1 y 7 (excluido, es decir, de 1 a 6)
            r = generador.Next(1, 7);

            Console.WriteLine(d+" "+r);

            for (int e = 0; e < 10; e++)
            {
                Random gen = new Random(3);

                int num;
                num = gen.Next(1, 7);
                Console.WriteLine(num);

                int a = 10, b = 3, totalsuma, totalresta;
                string moneda;
                totalsuma = a + b;
                totalresta = a - b;
                moneda = "Euros";
                Console.WriteLine("El valor {0} sumado con el {1} resulta un total de {2} {3}. Pero dicho valor {0} si se le resta {1} queda un total de {4} {3}\n",
                a, b, totalsuma, moneda, totalresta);

            string nom;
            Console.WriteLine("Por favor introduce tu nombre");
            nom = Console.ReadLine();
            switch (nom)
            {
                case "adios":
                case "Adios":
                case "ADIOS":
                    Console.WriteLine("Hasta la próxima");
                    break;
                case "Curro":
                    Console.WriteLine("Acceso denegado, cámbiate el nombre");
                    goto case "ADIOS";
                default:
                    Console.WriteLine("Hola {0}, bienvenido a este programa", nom);
                    break;
            }
            int edad = 22;
            switch (edad)
            {
                case < 0:
                    Console.WriteLine("No has nacido");
                    break;
                case >= 0 and <= 18:
                    Console.WriteLine("Menor de edad");
                    break;
                default:
                    Console.WriteLine("Mayor de edad...supuestamente ;-)");
                    break;
            }

        }
    }*/
}
