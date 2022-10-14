using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class EmpleadoEspecial : Empleado, IPastaGansa
    {
        public double ganarPasta(double beneficiosTotales)
        {
            return (beneficiosTotales * 0.5) / 100;
        }

        public override double Hacienda()
        {
            return base.Hacienda() * 1.05;
        }

        public EmpleadoEspecial(string nombre, string apellidos, int edad, string dni, double salario, double irpf, string telefono)
            : base(nombre, apellidos, edad, dni, salario, irpf, telefono)
        {
        }
    }
}
