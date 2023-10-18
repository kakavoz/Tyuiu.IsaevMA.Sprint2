using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            for (int i = 1; i < 5; i++)
            {
                a++;
                b-=a;
                c = b - a;
                d = (c+a) + i;
            }
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}

