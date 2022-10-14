using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    abstract class Persona
    {

        private string nombre;
        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }    
        }

        private string apellidos;
        public string Apellidos
        {
            set
            {
                apellidos = value;
            }
            get
            {
                return apellidos;
            }
        }

        private int edad;
        public int Edad
        {
            set
            {
                if (value < 0)
                {
                    edad = 0;
                }
                else
                {
                    edad = value;
                }
            }
            get
            {
                return edad;
            }
        }

        private string dni;
        public String Dni
        {
            set
            {
                if (value.Length==9)
                {
                    value.Remove(value.Length - 1);
                }
                else
                {
                    dni = value;
                }
            }
            get
            {
                try
                {
                    int res = (Convert.ToInt32(dni)) % 23;
                    string[] letras = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
                    return dni + letras[res];
                }
                catch(StackOverflowException ex)
                {
                    return dni;
                }
            }
        }

        public virtual void Mostrar()
        {
            Console.WriteLine("Su nombre es: " + nombre);
            Console.WriteLine("Su apellido es " + apellidos);
            Console.WriteLine("Su edad es de : " + edad + " años");
            Console.WriteLine("Su numero de dni es: " + dni);
        }

        public virtual void Pedir()
        {
            Console.WriteLine("Introduzca el Nombre De la persona");
            nombre = Console.ReadLine();
            Console.WriteLine("Introduzca sus Apellidos");
            apellidos = Console.ReadLine();
            Console.WriteLine("Introduzca la que tiene Edad");
            Edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca su numero de DNI");
            dni = Console.ReadLine();

        }

        public Persona(string nombre, string apellidos, int edad, string dni)
        {
            this.Nombre = nombre;

            this.Apellidos = apellidos;

            this.Edad = edad;

            this.Dni = dni;
        }

        public Persona()
            :this("", "", 0, "")
        {
        }

        public abstract double Hacienda();
    }
}
