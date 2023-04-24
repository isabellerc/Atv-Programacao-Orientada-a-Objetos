using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_5
{
    internal class GerarForma
    {
        public void SolicitarForma()
        {
            Quadrado quadrado = new Quadrado();
            Hexagono hexagono = new Hexagono();
            Triangulo triangulo = new Triangulo();  
            Circunferencia circunferencia= new Circunferencia();

            int formaDigitada = 1;
            do
            {
                Console.WriteLine("Digite o nº correspondente a forma que deseja calcular: ");
                Console.WriteLine("1 - Triângulo");
                Console.WriteLine("2 - Quadrado");
                Console.WriteLine("3 - Circunferência");
                Console.WriteLine("4 - Hexagono");
                Console.WriteLine("5 - Sair");
                Console.Write("R: ");
                formaDigitada = int.Parse(Console.ReadLine());
                Console.Clear();


                if (formaDigitada == 1)
            {
                Console.Write("Digite um valor para lado A: ");
                triangulo.ladoA = double.Parse(Console.ReadLine());

                Console.Write("Digite um valor para lado B: ");
                triangulo.ladoB = double.Parse(Console.ReadLine());

                Console.Write("Digite um valor para lado C: ");
                triangulo.ladoC = double.Parse(Console.ReadLine());
                
                triangulo.CalcularArea();
                triangulo.CalcularPerimetro();
                Console.WriteLine();
            }

            else if (formaDigitada == 2)
            {
                Console.Write("Digite um valor para o lado do quadrado: ");
                quadrado.lado = double.Parse(Console.ReadLine());

                quadrado.CalcularArea();
                quadrado.CalcularPerimetro();
                Console.WriteLine();

            }

            else if (formaDigitada == 3)
            {
                Console.Write("Digite um valor para o raio da circunferência: ");
                circunferencia.raio = double.Parse(Console.ReadLine());

                circunferencia.CalcularArea();  
                circunferencia.CalcularPerimetro();
                Console.WriteLine();
            }

            else if (formaDigitada == 4)
            {
                Console.Write("Digite um valor para lado do hexágono: ");
                hexagono.lado = double.Parse(Console.ReadLine());
                

                hexagono.CalcularArea();
                hexagono.CalcularPerimetro();
                
                Console.WriteLine();
            }

            } while (formaDigitada == 1 || formaDigitada == 2 || formaDigitada == 3 || formaDigitada == 4);
        }
    }
}
