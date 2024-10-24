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
                // Пример формулы
                double term = (0.5 + (i / 5.0)) / (Math.Cos(value) + 0.5);

                // Проверяем, чтобы не было деления на ноль
                if (double.IsInfinity(term) || double.IsNaN(term))
                {
                    return 0; // Или другое значение, если возникает ошибка
                }

                multSeries *= term;
            }

            return Math.Round(multSeries, 3);
        }
    }

    

}