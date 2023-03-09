using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercico07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double parcelas, qtdparce, vlrpercel;
            Console.WriteLine("informe a quantidade de prestaçoes");
            qtdparce = double.Parse(Console.ReadLine());
            Console.WriteLine("informe a quantidade de prestaçoes pagas ");
            parcelas = double.Parse(Console.ReadLine());
            Console.WriteLine("informe o valor da prestaçao");
            vlrpercel = double.Parse(Console.ReadLine());

            Console.WriteLine("o valor pago foi"+ parcelas*vlrpercel);
            Console.WriteLine($"o valor que falta para pagar é {(+qtdparce-vlrpercel) *vlrpercel}");
            Console.ReadKey();  





        }
    }
}
