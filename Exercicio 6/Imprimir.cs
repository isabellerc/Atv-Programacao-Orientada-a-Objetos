using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_6
{
    internal class Imprimir
    {
        Documento documento = new Documento();  

        public void enviarImpressao()
        {

        }

        public void solicitarTexto() 
        {
            Console.WriteLine("Por favor, digite o texto que deseja imprimir:");
            documento.texto = Console.ReadLine();

            Console.WriteLine("Quantas cópias deseja?:");
        }
    }
}
