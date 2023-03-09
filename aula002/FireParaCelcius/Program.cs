using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireParaCelcius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celcius, fire;
            Console.WriteLine("digite a quantidade em fahrenheit ");
            fire = Convert.ToDouble(Console.ReadLine());
            celcius = ((fire - 32 ) * 5/9);
            Console.WriteLine(celcius);
            Console.ReadKey();







        }
    }
}
