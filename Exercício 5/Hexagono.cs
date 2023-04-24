using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercício_5
{
    internal class Hexagono : Forma
    {
        public double lado;

        public override void CalcularArea()
        {
            Area = (3 * (lado * lado) * 1.73) / 2;
        }

        public override void CalcularPerimetro()
        {
            Perimetro = lado * 6;
            Console.WriteLine("O perímetro do triângulo é: " + Perimetro.ToString("F2"));
        }
    }
}
