using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello user! Please enter a number: ");
            int userInput = Int16.Parse(Console.ReadLine());
            int n = 1;
            do
            {
                int o = n * n * n;
                Console.WriteLine(o);
                n++;
            } while (n <= userInput);

            Console.ReadKey();
        }
    }
}
