using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IsaevMA.Sprint2.Task3.V6.Lib;

namespace Tyuiu.IsaevMA.Sprint2.Task3.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Исаев.М.А. | ACОиУБ-23-3";
            //Длина строки 75 символов
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                                          *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                                                                *");
            Console.WriteLine("* Задание #3                                                                                                         *");
            Console.WriteLine("* Вариант #6                                                                                                        *");
            Console.WriteLine("* Выполнил: Исаев Максим Александрович | ACOиУБ-23-3                                                                *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                           *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с использованием вложенных оператор if-else,    *");
            Console.WriteLine("* где пользователь вводит значение переменной X с клавиатуры.                                                        *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                   *");
            Console.WriteLine("**********************************************************************************************************************");

            Console.WriteLine("Введите значение переменной X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);

            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                         *");
            Console.WriteLine("**********************************************************************************************************************");

            Console.WriteLine("Значение функции = " + res);

            Console.ReadKey();
        }
    }
}
