using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, endereco;
            int cel;

            Console.Write ("digite seu nome ");
            nome = Console.ReadLine();
            Console.WriteLine ("digite o seu endereço ");
            endereco = Console.ReadLine();
            Console.WriteLine("digite o seu numero de telefone ");
            cel = Convert.ToInt32( Console.ReadLine());

            Console.Clear();

            Console.WriteLine("\t\t---dados do usuario---");
            Console.WriteLine($"Nome: {nome}\n endereço {endereco}\n telefone{cel}");


            Console.ReadKey();
        }
    }
}
