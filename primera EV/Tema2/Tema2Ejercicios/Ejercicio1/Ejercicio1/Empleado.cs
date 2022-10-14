using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Empleado : Persona
    {
        private double salario;
        public double Salario
        {
            set
            {
                salario = value;
                if (salario < 600)
                {
                    irpf = 7;
                }
                else if (salario >= 600 && salario <= 3000)
                {
                    irpf = 15;
                }
                else
                {
                    irpf = 20;
                }
            }
            get
            {
                return salario;
            }
        }

        private double irpf;
        private double Irpf
        {
            get
            {
                return irpf;
            }
        }

        private string telefono;
        public string Telefono
        {
            set
            {
                telefono = value;
            }
            get
            {
                return "+34" + telefono;
            }
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("El salario es de : " + salario);
            Console.WriteLine("El irpf es del : " + irpf + " %");
            Console.WriteLine("El numero de telefono es : " + telefono);
        }
        public void Mostrar(int num)
        {

            switch (num)
            {
                case 0: Console.WriteLine("El salario es de : " + salario);
                    Console.WriteLine("(Y HACIENDA SE LLEVA " + Hacienda() + ")");
                    break;
                case 1: Console.WriteLine("El irpf es del : " + irpf + " %");
                    break;
                case 2: Console.WriteLine("El numero de telefono es : " + telefono);
                    break;
                case 3: Console.WriteLine("Su nombre es: " + Nombre);
                    break;
                case 4: Console.WriteLine("Su apellido es " + Apellidos);
                    break;
                case 5: Console.WriteLine("Su edad es de : " + Edad + " años");
                    break;
                case 6: Console.WriteLine("Su numero de dni es: " + Dni);
                    break;
                default: Console.WriteLine("Esa no es una opcion");
                    break;
            }
        }

        public override double Hacienda()
        {
            return (Irpf * salario) / 100;
        }

        public Empleado(string nombre, string apellidos, int edad, string dni, double salario, double irpf, string telefono)
        : base(nombre, apellidos, edad, dni)
        {
            this.Salario = salario;
            this.irpf = irpf;
            this.Telefono = telefono;
        }

        public Empleado()
            : this("", "", 0, "", 0, 0, "")
        {
        }
    }
}

