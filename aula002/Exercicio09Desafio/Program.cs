using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09Desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string func;
            double salario, comissao, vendas, salariof;
            Console.Write("digite seu nome: ");
            func = Convert.ToString(Console.ReadLine());
            Console.Write("qual o total de vendas realizadas: ");
            comissao = Convert.ToDouble(Console.ReadLine());
            Console.Write("informe seu salario: ");
            salario = Convert.ToDouble(Console.ReadLine());
            Console.Write("informe seu percentual");
            vendas = Convert.ToDouble(Console.ReadLine());
            salariof = vendas + (vendas * salario) / 100;

            Console.WriteLine($"{func}seu salario final é de: {salario}");
            Console.ReadLine();
            

            Console.ReadKey();







        }
    }
}
