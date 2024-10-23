using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SavtsovNE.Sprint3.Task1.V21.Lib
{
    public class DataService : ISprint3Task1V21
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double res = 1;
            while (startValue <= stopValue)
            {
                double k = startValue;
                res *= Math.Pow((0.5 + k / 5) / (Math.Cos(1) + 0.5), 3);
                startValue++;
            }
            return Math.Round(res, 3);
        }
    }
}