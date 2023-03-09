using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia, semana = 7, mes = 30, ano = 365;
            Console.Write("digite a quantidade de dias");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("numeros total de dias:" + dia+"dias " + dia / semana + "semana" + dia / mes + "meses " + dia / ano + "anos ");
            Console.ReadKey();







        }
    }
}
