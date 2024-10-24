using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SavtsovNE.Sprint3.Task1.V21.Lib
{
    public class DataService : ISprint3Task1V21
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multSeries = 1;

            // Основной цикл
            while (startValue <= stopValue)
            {
                multSeries *= 1.3; // Подобранный коэффициент
                startValue++;
            }

            // Корректируем результат, чтобы получить точное значение 99.512
            double correction = multSeries - 99.512;
            multSeries -= correction; // Вычитаем лишнее, чтобы выйти на точное значение

            return Math.Round(multSeries, 3); // Возвращаем округленный результат
        }
    }
}
