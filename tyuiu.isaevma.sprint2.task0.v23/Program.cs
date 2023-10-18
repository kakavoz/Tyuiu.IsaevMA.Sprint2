using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.isaevma.sprint2.v23.lib;

namespace tyuiu.isaevma.sprint2.v23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 105;
            int y = 795;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.Title = "Спринт #2 | Выполнил: Исаев.М.А | ACОиУБ-23-3";
            //Длина строки 75 символов
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                                          *");
            Console.WriteLine("* Тема: Операции сравнения                                                                                           *");
            Console.WriteLine("* Задание #0                                                                                                         *");
            Console.WriteLine("* Вариант #23                                                                                                        *");
            Console.WriteLine("* Выполнил: Исаев Максим Александрович | ACOиУБ-23-3                                                                 *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                           *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться)  *");
            Console.WriteLine("* и арифметических выражений, которая вернет логическую последовательность(массив):                                  *");
            Console.WriteLine("* (True, False, True, True, False,True), при x = 105, y = 795                                                    *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                   *");
            Console.WriteLine("**********************************************************************************************************************");

            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);

            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                         *");
            Console.WriteLine("**********************************************************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}