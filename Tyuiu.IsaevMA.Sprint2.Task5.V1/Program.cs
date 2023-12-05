using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IsaevMA.Sprint2.Task5.V1.Lib;

namespace Tyuiu.IsaevMA.Sprint2.Task5.V1
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
            Console.WriteLine("* Задание #5                                                                                                         *");
            Console.WriteLine("* Вариант #1                                                                                                         *");
            Console.WriteLine("* Выполнил: Исаев Максим Александрович| ACOиУБ-23-3                                                                  *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                           *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет требуемое значение и возвращает результат.        *");
            Console.WriteLine("*По данному номеру месяца, определите количество дней в этом месяце.                                                 *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                   *");
            Console.WriteLine("**********************************************************************************************************************");

            Console.WriteLine("Введите номер месяца:");
            int numMonth = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((numMonth < 1) || (numMonth > 12))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "В этом месяца столько дней: " + ds.FindMonth(numMonth);
            }
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                         *");
            Console.WriteLine("**********************************************************************************************************************");

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
