using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1Pruebas
{
    using System;
    using System.Runtime.CompilerServices;

    class Perro
    {
        public string raza;
        public string nombre;

        private int edad;
        public int Edad
        {
            set
            {
                this.edad=value;
            }
            get
            {
                return this.edad;
            }
        }

        private int nOrganos;
        private int NOrganos
        {
            set { this.nOrganos=value; }
            get { return this.nOrganos; }
        }

        public Perro()
        {
            this.Edad=0;
            this.raza = "";
            this.nombre = "";
        }

        ~Perro()
        {
            Console.WriteLine("Finalizado el perro");
        }

    }

}
