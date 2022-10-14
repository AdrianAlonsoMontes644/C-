namespace Ejercicio1
{
    class Program
    {
        public static void funcion(IPastaGansa pasta)
        {
            double ganancia;
            Console.WriteLine("Cuanto gana la empresa?");
            ganancia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El empresario gana " + pasta.ganarPasta(ganancia));

        }

        public static void Main()
        {
            Directivo d1 = new Directivo();
            Empleado e1 = new Empleado("Pedro", "Mencia", 34, "76874989N", 800, 4, "698145611");
            EmpleadoEspecial s1 = new EmpleadoEspecial("Pablo", "Escobar", 39, "76923889N", 4000, 3, "698141121");

            d1.Pedir();
            int opcion;
            int opcion2;

            do
            {
                Console.WriteLine("Que quiere hacer? \n" +
                " 1-) Visualizar los datos del Directivo \n" +
                " 2-) Visualizar datos del Empleado \n" +
                " 3-) Visualizar datos del EmpleadoEspecial \n" +
                " 4-) Salir");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        d1.Mostrar();
                        funcion(d1);
                        Console.WriteLine("Hacienda se lleva =" + d1.Hacienda());
                        break;

                    case 2:
                        Console.WriteLine("Que info desea visualizar sobre el Empleado? \n" +
                            " 0-) Su salario \n" +
                            " 1-) El irpf \n" +
                            " 2-) su número de teléfono \n" +
                            " 3-) Su nombre \n" +
                            " 4-) Sus apellidos \n" +
                            " 5-) Su edad \n" +
                            " 6-) Su numero de DNI");
                        opcion2 = Convert.ToInt32(Console.ReadLine());
                        e1.Mostrar(opcion2);
                        break;

                    case 3:
                        Console.WriteLine("Que info desea visualizar sobre el Empleado Especial? \n" +
                            " 0-) Su salario \n" +
                            " 1-) El irpf \n" +
                            " 2-) su número de teléfono \n" +
                            " 3-) Su nombre \n" +
                            " 4-) Sus apellidos \n" +
                            " 5-) Su edad \n" +
                            " 6-) Su numero de DNI");
                        opcion2 = Convert.ToInt32(Console.ReadLine());
                        s1.Mostrar(opcion2);
                        funcion(s1);
                        break;

                    case 4:
                        Console.WriteLine("Adios");
                        break;

                    default:
                        Console.WriteLine("Esa no es una opcion");
                        break;
                }
            } while (opcion != 4);
            
        }

    }
}

