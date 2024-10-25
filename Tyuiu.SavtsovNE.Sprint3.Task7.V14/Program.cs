using Tyuiu.SavtsovNE.Sprint3.Task7.V14.Lib;

namespace Tyuiu.SavtsovNE.Sprint3.Task7.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Савцов Никита Евгеньевич | ИБКСб - 24 - 1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# Спринт #3                                                               #");
            Console.WriteLine("# Тема: Добавление к решению итоговых проектов по спринту                 #");
            Console.WriteLine("# Задание #7                                                              #");
            Console.WriteLine("# Вариант #14                                                            #");
            Console.WriteLine("# Выполнил Савцов Никита Евгеньевич | ИБКСб - 24 - 1                      #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# УСЛОВИЕ:                                                                #");
            Console.WriteLine("# Написать программу, которая выводит таблицу значений функции            #");
            Console.WriteLine("#                                                                         #");
            Console.WriteLine("#                                                                         #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
            Console.WriteLine("###########################################################################");

            int startValue = -5;
            int stopValue = 5;
            double[] res = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("Начало числового отрезка = " + startValue);
            Console.WriteLine("Конец числового отрезка = " + stopValue);


            Console.WriteLine("###########################################################################");
            Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}