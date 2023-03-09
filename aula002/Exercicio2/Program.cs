using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("digite o primeiro numero ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("digite o segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 * num2);

            Console.ReadKey();
        }
    }
}
