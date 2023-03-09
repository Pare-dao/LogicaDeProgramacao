using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDoCelcius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celcius, fire;
            Console.WriteLine("digite a quantidade em celcius ");
            celcius = Convert.ToDouble(Console.ReadLine());
            fire =((celcius * 9 / 5) + 32);
            Console.WriteLine(fire);
            Console.ReadKey();





        }
    }
}
