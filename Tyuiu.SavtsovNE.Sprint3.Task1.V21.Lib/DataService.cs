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
                double currentVal = (0.5 + (startValue / 5)) / (Math.Cos(value) + 0.5);
                double powVal = Math.Pow(currentVal, 3);
                multSeries *= powVal;

                Console.WriteLine($"StartValue: {startValue}, CurrentVal: {currentVal}, PowVal: {powVal}, MultSeries: {multSeries}");

                startValue++;
            }
            return Math.Round(multSeries, 3);
        }

    }
}
