using Tyuiu.SavtsovNE.Sprint3.Task1.V21.Lib;

namespace Tyuiu.SavtsovNE.Sprint3.Task1.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value;
            int startValue, stopValue;
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Савцов Никита Евгеньевич | ИБКСБ - 24 - 1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла while                                              *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Савцов Никита Евгеньевич | ИБКСБ - 24 - 1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет              *");
            Console.WriteLine("* произведение ряда по формуле, при х=1                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение x (1): ");
            value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите нижнее(начальное) значение: ");
            startValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите верхнее(конечное) значение: ");
            stopValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetMultiplySeries(value, startValue, stopValue));
        }
    }
}