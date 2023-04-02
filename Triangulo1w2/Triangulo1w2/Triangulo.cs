using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo1w2
{
    class Triangulo
    {
        private double ladoA;
        private double ladoB;
        private double ladoC;
        public double pLadoA
        {
            set { ladoA = value; }
            get { return ladoA; }
        }
        public double pLadoB
        {
            set { ladoB = value; }
            get { return ladoB; }

        }
        public double pLadoC
        {
            set { ladoC = value; }
            get { return ladoC; }
        }
        public double calcularPerimetro()
        {
            double p;
            p = (ladoA + ladoB + ladoC);
            return p;
        }
        public string toString()
        {
            return "LadoA: " + Convert.ToString(ladoA) +
                   "LadoB: " + Convert.ToString(ladoB) + 
                   "LadoC: " + Convert.ToString(ladoC);

        }
        public Triangulo()
        {
            ladoA = 0;
            ladoB = 0;
            ladoC = 0;
        }
        public Triangulo(double l1, double l2, double l3)
        {
            ladoA = l1;
            ladoB = l2;
            ladoC = l3;
        }
        public string calcularTipo()
        {
            string tipo;
            if (ladoA == ladoB && ladoB == ladoC)
            {
                tipo = "Equilatero";
            }
            else
            {
                if (ladoA != ladoB && ladoB != ladoC)
                {
                    tipo = "Escaleno";
                }
                else
                {
                    tipo = "Isosceles";
                }
            }
            return tipo;
                

        }

        
    }
}
