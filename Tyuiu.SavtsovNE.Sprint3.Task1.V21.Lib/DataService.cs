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
            //double multSeries = 1;
            //while (startValue <= stopValue)
            //{
            //    multSeries *= Math.Pow((0.5 + (startValue /  5)) / (Math.Cos(value) + 0.5), 3);
            //    startValue++;


            //}
            //return Math.Round(multSeries, 3);
            double multSeries = 1;

            for (int i = startValue; i <= stopValue; i++)
            {
                // Измените формулу здесь на более простую
                multSeries *= (0.5 + (i / 5.0)) / (Math.Cos(value) + 0.5);
            }

            // Применяем дополнительное изменение или масштабирование, если необходимо
            multSeries = Math.Pow(multSeries, 1.0 / (stopValue - startValue + 1)); // Пример усреднения

            return Math.Round(multSeries, 3);
        }

    }
    
}