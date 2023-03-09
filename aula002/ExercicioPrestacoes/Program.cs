using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPrestacoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double jrs, vlr ;
            int dia ;
            Console.Write("digite que dia era para ser pago seu produto: ");
            dia = int.Parse(Console.ReadLine());
            Console.Write("digite o valor do produto: ");
            vlr = int.Parse(Console.ReadLine());
            Console.Write("digite a quantidade de juros por dia: ");
            jrs = int.Parse(Console.ReadLine());
            Console.WriteLine((vlr * jrs) * dia);
            Console.ReadKey();



        }
    }
}
