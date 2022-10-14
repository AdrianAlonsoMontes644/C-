using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Directivo : Persona, IPastaGansa
    {
        private double pastaGanada;

        private string nombreDepartamento;
        public string NombreDepartamento
        {
            set
            {
                nombreDepartamento = value;
            }
            get
            {
                return nombreDepartamento;
            }
        }

        private double beneficios;
        public double Beneficios
        {
            get
            {
                return beneficios;
            }
        }

        private int acargo;
        public int Acargo
        {
            set
            {
                acargo = value;
                if (value <= 10)
                {
                    beneficios = 2;
                }
                else if (value <= 50)
                {
                    beneficios = 3.5;
                }
                else
                {
                    beneficios = 4;
                }
            }
            get
            {
                return acargo;
            }
        }

        public static Directivo operator --(Directivo d1)
        {
            d1.beneficios--;

            if (d1.beneficios < 0)
            {
                d1.beneficios = 0;
            }
            return d1;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("El nombre del departamento es " + NombreDepartamento);
            Console.WriteLine("El porcentaje de beneficios es de: " + Beneficios + "%");
            Console.WriteLine("El numero personas comandadas es de : " + Acargo);
        }

        public override void Pedir()
        {
            base.Pedir();
            Console.WriteLine("¿Cual es el nombre del departamento?");
            this.NombreDepartamento = Console.ReadLine();
            Console.WriteLine("¿Cuantas personas trabajan para el directivo?");
            this.Acargo = Convert.ToInt32(Console.ReadLine());
        }

        double IPastaGansa.ganarPasta(double beneficiosTotales)
        {
            pastaGanada = (beneficiosTotales * beneficios) / 100;
            if (pastaGanada <= 0)
            {
                Directivo d1 = this;
                d1--;
                return 0;
            }
            else
            {
                return pastaGanada;
            }
        }


        public override double Hacienda()
        {
            double vuelta = (pastaGanada*30) / 100;
            return vuelta;  
        }
    }
}
