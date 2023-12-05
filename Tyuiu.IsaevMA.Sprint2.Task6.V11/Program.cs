using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IsaevMA.Sprint2.Task6.V11.Lib;

namespace Tyuiu.IsaevMA.Sprint2.Task6.V11
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
            Console.WriteLine("* Тема: Оператор switch                                                                                              *");
            Console.WriteLine("* Задание #6                                                                                                         *");
            Console.WriteLine("* Вариант #11                                                                                                        *");
            Console.WriteLine("* Выполнил: Исаев Максим Александрович| ACOиУБ-23-3                                                                  *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                           *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет требуемое значение и возвращает результат.        *");
            Console.WriteLine("*Дата некоторого дня характеризуется тремя натуральными числами: g (год), m (порядковый номер месяца) и n (число)     ");
            Console.WriteLine(" По заданным g, n и m определить дату следующего дня. Заданный год не является високосным.                            ");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                   *");
            Console.WriteLine("**********************************************************************************************************************");

            Console.Write("Введите год: ");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите месяц: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите Число: ");
            int n = Convert.ToInt32(Console.ReadLine());
      

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Следующий день - {DataService.FindDateOfNextDay(g, m, n)}");

            Console.ReadKey();
        }
    }
}