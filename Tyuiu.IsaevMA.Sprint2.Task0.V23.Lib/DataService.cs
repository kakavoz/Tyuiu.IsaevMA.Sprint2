﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace tyuiu.isaevma.sprint2.v23.lib
{
    public class DataService : ISprint2Task0V23
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x == y - 690;
            res[1] = x != y - 690;
            res[2] = x < y;
            res[3] = x > y - 691;
            res[4] = x <= y - 691;
            res[5] = x + 690 >= y;

            return res;
        }
    }
}
