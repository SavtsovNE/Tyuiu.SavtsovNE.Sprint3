using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SavtsovNE.Sprint3.Task4.V3.Lib
{
    public class DataService : ISprint3Task4V3
    {
        public double Calculate(int startValue, int stopValue)
        {
            int i2 = stopValue;
            double sum = 0;
            for (int i = startValue; i < i2; i++)
            {
                if (i == 0)
                {
                    break;
                }
                sum = sum + ((Math.Cos(i) + Math.Sin(i)) / i);

            }
            return Math.Round (sum,3);
        }
    }
}