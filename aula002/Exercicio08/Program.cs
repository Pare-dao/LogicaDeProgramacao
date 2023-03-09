using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;

            Console.Write("digite o primeiro numero");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("digite o segundo numero");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("somando "+ (num1 + num2));
            Console.WriteLine("subitraindo " + (num1 - num2));
            Console.WriteLine("mutiplicando " + (num1 * num2));
            Console.WriteLine("dividindo " + (num1 / num2));








        }
    }
}
