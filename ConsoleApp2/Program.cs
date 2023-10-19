using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 0, k = 7;

            if (k > 0) if (k > 10) y = 1;

                else y = 2;
            else y = 3;


            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
