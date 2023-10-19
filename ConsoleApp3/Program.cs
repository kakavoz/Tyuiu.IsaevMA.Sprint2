using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;

            int y = (x > 0) && (x < 2) ? x * x : -x;


            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
