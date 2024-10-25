using Tyuiu.SavtsovNE.Sprint3.Task3.V1.Lib;
namespace Tyuiu.SavtsovNE.Sprint3.Task3.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Савцов Никита Евгеньевич | ИБКСб - 24 - 1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Оператор цикла foreach                                                  *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Савцов Никита Евгеньевич | ИБКСб - 24 - 1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");

            Console.WriteLine("*Используя цикл foreach подсчитать количество букв “а” в строке: have a ni*");
            Console.WriteLine("*ice time                                                                 *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            var data = "have a nice time";

            var result = ds.GetCharCount(data, 'a');
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}