using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite algo: ");
            string texto = (Console.ReadLine());

            Console.Write("Quantas vezes voce quer que repita o que digitou?: ");
            int quantTexto = Convert.ToInt32(Console.ReadLine());

            int x = 1;
  
            while (x <= quantTexto)
            {
                Console.WriteLine(texto);
                x = x + 1;
            }
            Console.ReadKey();
        }
    }
}
