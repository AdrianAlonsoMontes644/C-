using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Tema3
{
    internal class Aula
    {
        public void MediaAbsoluta()
        {
            double suma = 0, divisor = 0, media = 0;
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    suma = suma + this[i, j];
                    divisor++;
                }
            }
            media = suma / divisor;
            Console.Clear();
            Console.WriteLine("La media de todas las notas es: " + media.ToString("N2"));
        }
        public void MediaAlumno()
        {
            bool correcto;
            double mediarama = 0, suma = 0, divisor = 0, media=0;
            do
            {
                correcto = true;
                Console.WriteLine("De que alumno quiere ver la media?");
                try
                {
                    mediarama = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Solo números por favor");
                    correcto = false;
                }
                if (mediarama < 0 || mediarama >= notas.GetLength(0))
                {
                    Console.WriteLine("ESA NO ES UNA OPCIÓN");
                    correcto = false;
                }
            } while (mediarama < 0 || mediarama > notas.GetLength(0) || !correcto);

            for (int i = 0; i < Enum.GetNames(typeof(Enumerado)).GetLength(0); i++)
            {
                suma = suma + this[Convert.ToInt32(mediarama), i];
                divisor++;
            }
            media = suma / divisor;
            Console.Clear();
            Console.WriteLine("La media de " + aNombres.GetValue(Convert.ToInt32(mediarama)) + " es: " + media.ToString("N2"));
        }
        public void MediaAsignatura()
        {
            bool correcto;
            double mediarama = 0, suma = 0, divisor = 0, media = 0;
            do
            {
                correcto = true;
                Console.WriteLine("De que materia quiere ver la media?");
                try
                {
                    mediarama = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Solo números por favor");
                    correcto = false;
                }
                if (mediarama < 0 || mediarama >= Enum.GetNames(typeof(Enumerado)).GetLength(0))
                {
                    Console.WriteLine("ESA NO ES UNA OPCIÓN");
                    correcto = false;
                }
            } while (mediarama < 0 || mediarama > Enum.GetNames(typeof(Enumerado)).GetLength(0) || !correcto);

            for (int i = 0; i < notas.GetLength(0); i++)
            {
                suma = suma + notas[i, Convert.ToInt32(mediarama)];
                divisor++;
            }
            media = suma / divisor;
            Console.Clear();
            Console.WriteLine("La media de " + Enum.GetNames(typeof(Enumerado)).GetValue(Convert.ToInt32(mediarama)) + " es: " + media.ToString("N2"));
        }
        public void NotasAlumno()
        {
            bool correcto;
            double suma = 0, divisor = 0, media = 0;
            int alumno = 0;
            do
            {
                correcto = true;
                Console.WriteLine("De que alumno quiere ver las notas?");
                try
                {
                    alumno = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Solo números por favor");
                    correcto = false;

                }
                if (alumno < 0 || alumno >= notas.GetLength(0))
                {
                    Console.WriteLine("ESA NO ES UNA OPCIÓN");
                    correcto = false;
                }
            } while (alumno < 0 || alumno > notas.GetLength(0) || !correcto);

            Console.Clear();

            for (int i = 0; i < Enum.GetNames(typeof(Enumerado)).GetLength(0); i++)
            {
                Console.WriteLine("La nota de " + aNombres.GetValue(alumno) + " en " + Enum.GetNames(typeof(Enumerado)).GetValue(i) + " es = " + notas[alumno, i] + "\n");
            }
        }
        public void NotasMateria()
        {
            bool correcto;
            double suma = 0, divisor = 0, media = 0;
            int materia = 0;
            do
            {
                correcto = true;
                Console.WriteLine("De que materia quiere ver las notas?");
                try
                {
                    materia = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Solo números por favor");
                    correcto = false;
                }

                if (materia < 0 || materia >= Enum.GetNames(typeof(Enumerado)).GetLength(0))
                {
                    Console.WriteLine("ESA NO ES UNA OPCIÓN");
                    correcto = false;
                }
            } while (materia < 0 || materia > Enum.GetNames(typeof(Enumerado)).GetLength(0) || !correcto);

            Console.Clear();

            for (int i = 0; i < notas.GetLength(0); i++)
            {
                Console.WriteLine("La nota de " + aNombres.GetValue(i) + " en " + Enum.GetNames(typeof(Enumerado)).GetValue(materia) + " es: " + notas[i, materia] + "\n");
            }
        }
        public void MinMaxing()


        {
            bool correcto;
            double suma = 0, divisor = 0, media = 0;
            int alumno = 0, minima = 10, maxima = 0;
            do
            {
                correcto = true;
                Console.WriteLine("De que alumno quiere ver la máxima y mínima nota?");
                try
                {
                    alumno = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Solo números por favor");
                    correcto = false;
                }

                if (alumno < 0 || alumno > notas.Length)
                {
                    Console.WriteLine("ESA NO ES UNA OPCIÓN");
                    correcto = false;
                }
            } while (alumno < 0 || alumno > notas.Length || !correcto);

            string nAlumno = aNombres[alumno];

            nota(alumno, ref minima, ref maxima);
            Console.Clear();
            Console.WriteLine("La nota máxima del alumno " + nAlumno + " es: " + maxima + " y la minima es: " + minima);
        }
        public void EnseñaTodo()
        {
            Console.Clear();
            Console.Write($"{" ",10}");
            for (int i = 0; i < Enum.GetNames(typeof(Enumerado)).GetLength(0); i++)
            {
                Console.Write($"{Enum.GetNames(typeof(Enumerado)).GetValue(i),15}");
            }

            for (int i = 0; i < notas.GetLength(0); i++)
            {
                Console.Write("\n");
                Console.Write("\n");
                Console.Write($"{aNombres.GetValue(i),10}");
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    Console.Write($"{notas[i, j],15}");
                }
            }
            Console.Write("\n \n");
        }

        public void nota(int numeroAlumno, ref int minimo, ref int maximo)
        {
            for (int i = 0; i < notas.Length; i++)
            {
                try
                {
                    if (notas[numeroAlumno, i] > maximo)
                    {
                        maximo = notas[numeroAlumno, i];
                    }
                    if (notas[numeroAlumno, i] < minimo)
                    {
                        minimo = notas[numeroAlumno, i];
                    }
                }
                catch (Exception)
                {
                }        
            }
        }

        public void tabla()
        {
            Random r = new Random();
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    notas[i, j] = r.Next(0, 11);
                }
            }
        }
        public string[] aNombres;
        public string this[int nombres]
        {
            get
            {
                return aNombres[nombres];
            }
            set
            {
                aNombres[nombres] = value;
            }
        }

        public int[,] notas;
        public int this[int indice, int col]
        {
            set
            {
                notas[indice, col] = value;
            }
            get
            {
                return notas[indice, col];
            }
        }

        public Aula(string[] nombres)
        {
            aNombres = nombres;
            for (int i = 0; i < nombres.GetLength(0); i++)
            {
                if (aNombres.Length > i)
                {
                    aNombres[i] = aNombres[i].Trim().ToUpper();
                }
            }

            notas = new int[nombres.Length, 4];
            tabla();
        }

        public Aula(string nombres)
        {
            aNombres = nombres.Split(',');
            for (int i = 0; i < nombres.Length; i++)
            {
                if (aNombres.Length > i)
                {
                    aNombres[i] = aNombres[i].Trim().ToUpper();
                }
            }
            notas = new int[aNombres.Length, 4];
            tabla();
        }
    }
}
