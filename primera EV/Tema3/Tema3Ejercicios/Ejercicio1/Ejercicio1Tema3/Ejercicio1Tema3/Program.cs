using System.Collections;
using System.Text.RegularExpressions;

namespace Ejercicio1
{
    // Comprobaci´`on ip y memoria
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Hashtable direccionesIP = new Hashtable();

            do
            {

                bool correcta;
                Console.WriteLine("Bienvenido al Menú de IPs. ¿Que Desea Hacer? \n" +
                    "1-)Introducir un Dato \n" +
                    "2-)Eliminar un Dato (por clave) \n" +
                    "3-)Mostrar la Colección de IPs \n" +
                    "4-)Mostrar un Elemento de la Coleccion \n" +
                    "5-)Salir del Programa");

                correcta = int.TryParse(Console.ReadLine(), out opcion);
                Regex IPCheck = new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b");

                if (correcta)
                {
                    switch (opcion)
                    {
                        case 1:

                            bool existe;
                            string IP;
                            int memoria;
                            string[] a = { };
                            do
                            {
                                existe = false;
                                Console.WriteLine("Introduzca una IP");
                                IP = Console.ReadLine();
                                if (!IPCheck.IsMatch(IP) || IP.Length > 15)
                                {
                                    Console.WriteLine("La IP está mal escrita");
                                }

                                else
                                {

                                    a = IP.Split('.');
                                    if (a.Length > 4)
                                    {
                                        Console.WriteLine("La IP está mal escrita, vuelva a introducirla");
                                        existe = true;
                                    }
                                    else
                                    {
                                        for (int i = 0; i < a.Length; i++)
                                        {
                                            try
                                            {
                                                Convert.ToByte(a[i]);
                                            }
                                            catch (OverflowException)
                                            {
                                                Console.WriteLine("Los numeros de la IP no pueden sobrepasar 255, introduzca una nueva IP");
                                                existe = true;
                                            }
                                        }
                                    }

                                    foreach (string clave in direccionesIP.Keys)
                                    {
                                        if (clave == IP)
                                        {
                                            existe = true;
                                            Console.WriteLine("Es una clave ya exitente, introduzca otra por favor");
                                        }
                                    }
                                }
                            } while (!IPCheck.IsMatch(IP) || existe || IP.Length > 15);

                            Console.WriteLine("Introduzca su capacidad en GB");
                            do
                            {
                                if (int.TryParse(Console.ReadLine(), out memoria) && IPCheck.IsMatch(IP) && !existe && memoria >= 0)
                                {
                                    direccionesIP.Add(IP, memoria);
                                    Console.WriteLine("Se ha añadido con exito");
                                }
                                else
                                {
                                    Console.WriteLine("Debido a que ha no ha introducido un numero segun las especificaciones se le pide que vuelva a introducirla");
                                    memoria = 0;
                                }
                            } while (memoria == 0);
                            break;

                        case 2:
                            bool claveBorrar = false;
                            string Borrar;

                            if (direccionesIP.Count == 0)
                            {
                                Console.WriteLine("La base de datos se encuentra vacia, No hay nada para borrar");
                            }
                            else
                            {
                                do
                                {
                                    Console.WriteLine("Introduzca la IP a borrar");
                                    Borrar = Console.ReadLine();
                                    if (!IPCheck.IsMatch(Borrar))
                                    {
                                        Console.WriteLine("Error, las IP no se escriben así");
                                    }
                                } while (!IPCheck.IsMatch(Borrar));
                                foreach (string claves in direccionesIP.Keys)
                                {
                                    if (claves == Borrar)
                                    {
                                        claveBorrar = true;
                                    }
                                }
                                if (claveBorrar)
                                {
                                    direccionesIP.Remove(Borrar);
                                    Console.WriteLine("Ha sido borrada con éxito");
                                }
                                else
                                {
                                    Console.WriteLine("La IP no existe en la base de datos");
                                }
                            }

                            break;

                        case 3:
                            if (direccionesIP.Count == 0)
                            {
                                Console.WriteLine("La base de datos se encuentra vacia :(");
                            }
                            else
                            {

                                foreach (DictionaryEntry item in direccionesIP)
                                {
                                    Console.WriteLine("La dirección {0} tiene {1} GB de memoria", item.Key, item.Value);
                                }
                            }
                            break;
                        case 4:
                            if (direccionesIP.Count == 0)
                            {
                                Console.WriteLine("La base de datos se encuentra vacia :(");
                            }
                            else
                            {
                                string muestra = "";
                                bool encuentro = false;

                                Console.WriteLine("Diga la IP a buscar en la base de datos");
                                muestra = Console.ReadLine();

                                foreach (DictionaryEntry direccion in direccionesIP) //Sin bucle, con indexacion de clave
                                {
                                    if (Convert.ToString(direccion.Key) == muestra)
                                    {
                                        Console.WriteLine("Se encontro la direccion {0}, que tiene {1} GB de memoria", direccion.Key, direccion.Value);
                                        encuentro = true;
                                    }
                                }
                                if (!encuentro)
                                {
                                    Console.WriteLine("La direccion {0} no está en la base de datos", muestra);
                                }
                            }

                            break;
                        case 5:
                            Console.WriteLine("Adios y gracias por usar el programa");
                            break;
                        default:
                            Console.WriteLine("Eso no es una opcion...");
                            break;
                    }
                }
            } while (opcion != 5);
        }
    }
}