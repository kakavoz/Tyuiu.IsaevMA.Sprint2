using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

// ЗАДАНИЕ
// Написать программу из операций сравнений (==, !=, <, >, <=, >=,
// последовательность можно чередовать, но использовать один раз в выражении)
// и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться)
// и а также арифметических выражений, которая вернет логическую последовательность(массив): (False, False, True, False, True, False),
// при a = 654, b = 325, c = 154, d = 333



namespace tyuiu.isaevma.sprint2.task1.v27.lib
{
    public class DataService : ISprint2Task1V27
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {

            bool[] res = new bool[6];

            res[0] = (a == b) | (c > d);
            res[1] = (a + 10 > b) & (c == d);
            res[2] = (a > b) || (c < d);
            res[3] = (a - 350 > b) && (c < d);
            res[4] = !res[0];
            res[5] = (a > b) ^ (c < d);

            return res;
        }
    }
}
