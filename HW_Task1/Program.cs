using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите коэфициент к:");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ведите коэфициент b:");
            double b = Convert.ToDouble(Console.ReadLine());

            LinearEquation linearEquation = new LinearEquation(k,b);
            Console.WriteLine(linearEquation.Root());
            Console.ReadKey();
        }
    }
}
