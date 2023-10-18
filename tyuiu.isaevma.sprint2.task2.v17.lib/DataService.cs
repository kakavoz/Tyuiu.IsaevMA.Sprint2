using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace tyuiu.isaevma.sprint2.task2.v17.lib
{
    public class DataService : ISprint2Task2V17
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if (((x >= 3) && (x <= 5) && (y >= 3) && (y <= 7) || (y == 11)) || ((x == 6) && (y <=11) && (y >= 5)) || ((x == 7) && (y <= 12) && (y >= 5)) || ((x == 8) && (y >= 5) && (y <= 7))|| ((x == 9) && (y >= 3) && (y <= 7)) || (x == 10) && (y >= 3) && (y <= 12) || ((x >= 11) && (x <= 12) && (y >= 3) && (y <= 5) || (y >= 10) && (y <= 12)) || (x == 13) && (y ==4 ))

            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}