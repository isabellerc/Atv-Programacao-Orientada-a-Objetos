using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_5
{
    internal class Triangulo : Forma
    {
        public double ladoA;
        public double ladoB;
        public double ladoC;

        public override void CalcularArea()
        {
            double p = (ladoA + ladoB + ladoC) / 2;
            Area = Math.Sqrt(p * (p-ladoA) * (p-ladoB) * (p-ladoC));

            Console.WriteLine("A área do triângulo é: " + Area.ToString("F2"));
        }

        public override void CalcularPerimetro()
        {
            double Perimetro = ladoA + ladoB + ladoC;
            Console.WriteLine("O perímetro do triângulo é: " + Perimetro.ToString("F2"));
        }
    }
}
