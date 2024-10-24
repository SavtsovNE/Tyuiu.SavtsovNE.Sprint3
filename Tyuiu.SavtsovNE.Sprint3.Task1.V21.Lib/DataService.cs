using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SavtsovNE.Sprint3.Task1.V21.Lib
{
    public class DataService : ISprint3Task1V21
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multSeries = 1;
            while (startValue <= stopValue)
            {
                multSeries *= Math.Pow((0.5 + (startValue / 4.0)) / (Math.Cos(value) + 0.3), 3);
                startValue++;


            }
            return Math.Round(multSeries, 3);
        }
    }
}