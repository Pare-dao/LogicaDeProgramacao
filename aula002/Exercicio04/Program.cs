using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int larg, alt, prof;

            Console.Write("digite a altura da caixa retangular");
            alt = Convert.ToInt32(Console.ReadLine());
            Console.Write("digite a largura da caixa retangular");
            larg = Convert.ToInt32(Console.ReadLine());
            Console.Write("digite a profundidade da caixa retangular");
            prof = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(larg * alt * prof );



        }
    }
}
