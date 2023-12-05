using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.IsaevMA.Sprint2.SprintReview.V11.Lib
{
    public class DataService : ISprint2Task7V11
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if (Math.Pow(x,2) + Math.Pow(y,2) == 1 && (x>=0 && y >=x ))
                return true;
            else return false;
        }
    }
}
