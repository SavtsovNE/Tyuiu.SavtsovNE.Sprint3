using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SavtsovNE.Sprint3.Task3.V1.Lib
{
    public class DataService : ISprint3Task3V1
    {
        public int GetCharCount(string value, char item)
        {
            int res = 0;
            foreach (var str in value)
            {
                if (str == item)
                {
                    res++;
                }
            }

            return res;
        }
    }
}