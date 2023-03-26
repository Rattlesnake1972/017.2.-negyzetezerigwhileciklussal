using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017._2.negyzetezerigwhileciklussal
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i * i < 1000)

            {
                Console.WriteLine("A(z) " + i + " négyzete: " + i * i);
                i++;
            }

            Console.ReadKey();
        }
    }
}
