using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_5
{
    internal class Quadrado : Forma
    {
        public double lado;

        public override void CalcularArea()
        {
            Area = lado * lado;

            Console.WriteLine("A área do quadrado é: " + Area.ToString("F2"));
        }

        public override void CalcularPerimetro()
        {
            Perimetro = lado * 4;
            Console.WriteLine("O perímetro do quadrado é: " + Perimetro.ToString("F2"));
        }
    }
}

