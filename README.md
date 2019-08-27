# Calculadora
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Operaciones
    {
        // Constructores
        public Operaciones ()
        {}
        public Operaciones (double nro)
        {
            this.nro1 = nro;
        }
        public Operaciones (double nro1, double nro2)
        {
            this.nro1 = nro1;
            this.nro2 = nro2;
        }
        // Declarar los atributos
        protected double nro1;
        protected double nro2;
        //  Propiedades
        public double Nro1
        {
            get { return this.nro1;}
            set { this.nro2 = value; }
        }
        // Metodos u operaciones
        public double Sumar()
        {
            return this.nro1 + this.nro2;
        }   
        public double Restar()
        {
            return this.nro1 - this.nro2;
        }
        public double Multiplicar()
        {
            return this.nro1 * this.nro2;
        }
        public double Dividir()
        {
            return this.nro1 / this.nro2;
        }

        public double Raiz()
        {
            return Math.Sqrt(nro1);
        }
        public double Inverso()
        {
            return 1/this.nro1;
        }

        public double MasMenos()
        {
            return -this.nro1;
        }
    }
}
