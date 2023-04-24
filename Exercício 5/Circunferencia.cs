using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercício_5
{
    internal class Circunferencia : Forma 
    {
        public double raio;

        public override void CalcularArea()
        {

            double Area = (raio * raio) * 3.14;
            Console.WriteLine("A área da circunferência é: " + Area.ToString("F2"));
        }

        public override void CalcularPerimetro()
        {
            double Perimetro = 2 * 3.14 * raio;

            Console.WriteLine("O perímetro da circunferência é: " + Perimetro.ToString("F2"));
        }
    }
}
