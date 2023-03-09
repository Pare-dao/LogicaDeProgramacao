using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicoDaVelocidadeMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tempo, distancia;
            Console.Write("digite a distancia percorrida em seu veiculo: ");
            distancia = double.Parse(Console.ReadLine());
            Console.Write("digite o tempo que passou: ");
            tempo = double.Parse(Console.ReadLine());
            Console.WriteLine(distancia / tempo);
            Console.ReadKey();







        }
    }
}
