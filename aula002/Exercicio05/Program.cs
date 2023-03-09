using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double litros,km, percorrido;
            Console.Write("quantos litros foi colocado em seu veiculo");
            litros = double.Parse(Console.ReadLine());
            Console.Write("quantos km foi percorrido?");
            km = double.Parse(Console.ReadLine());
            percorrido = km / litros;
            Console.Write($"o total do km que voce irá percorrer é {percorrido}km");
            Console.ReadLine();






        }
    }
}
