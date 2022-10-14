using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Tema3
{
    internal class Menu
    {
        public Aula a1;

        public Menu(params string[] nombres)
        {
            a1 = new Aula(nombres);
        }

        int opcion;

        public void Inicio()
        {
            double suma = 0;
            double divisor = 0;
            double media;

            do 
            { 
                Console.WriteLine("Bienvenido al menú de la escuela. que desea hacer? \n" +
                    "1-) Calcular la media de notas de toda la tabla.\n" +
                    "2-) Media de un alumno\n" +
                    "3-) Media de una asignatura\n" +
                    "4-) Visualizar notas de un alumno\n" +
                    "5-) Visualizar notas de una asignatura\n" +
                    "6-) Nota máxima y mínima de un alumno\n" +
                    "7-) Visualizar tabla completa\n" +
                    "8-) Salir del programa");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        a1.MediaAbsoluta();
                        break;

                    case 2:
                        a1.MediaAlumno();
                        break;

                    case 3:
                        a1.MediaAsignatura();
                        break;

                    case 4:
                        a1.NotasAlumno();
                        break;

                    case 5:
                        a1.NotasMateria();
                        break;

                    case 6:
                        a1.MinMaxing();
                        break;

                    case 7:
                        a1.EnseñaTodo();
                        break;

                    case 8:
                        Console.WriteLine("Gracias por usar el programa de notas de la escuela.");
                        break;

                    default:
                        Console.WriteLine("ESA NO ES UNA OPCIÓN");
                        break;
                }
                suma = 0;
                divisor = 0;
            } while(opcion != 8);
        }















    }
}
