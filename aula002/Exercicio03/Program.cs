using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idd1, idd2, idd3, idd4, idd5 ;
            Console.WriteLine("qual a idade do primeiro aluno?");
            idd1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("qual a idade do segundo aluno?");
            idd2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("qual a idade do terceiro aluno?");
            idd3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("qual a idade do quarto aluno?");
            idd4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("qual a idade do quinto aluno?");
            idd5 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(idd1+ idd2+ idd3+ idd4+ idd5 / 5 );
            Console.ReadKey();

        }
    }
}
