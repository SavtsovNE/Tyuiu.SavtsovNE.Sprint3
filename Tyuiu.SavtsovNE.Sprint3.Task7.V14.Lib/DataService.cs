using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SavtsovNE.Sprint3.Task7.V14.Lib
{
    public class DataService : ISprint3Task7V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] massfunValue = new double[11];
            int i = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Sin(x) + 1 == 0) massfunValue[i] = 0;
                else massfunValue[i] = Math.Round(2 * x - 4 + ((2 * x - 1) / (Math.Sin(x) + 1)), 2);
                i++;
            }
            return massfunValue;
        }


    }
}