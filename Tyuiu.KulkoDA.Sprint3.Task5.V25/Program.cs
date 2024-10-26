using Tyuiu.KulkoDA.Sprint3.Task5.V25.Lib;

namespace Tyuiu.KulkoDA.Sprint3.Task5.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Кулько Д. А. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнила: Кулько Дарья Андреевна | ИИПб-24-2                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение по указанной формуле    *");
            int i = 1;
            int k = 1;
            int v = 3;
            int z = 10;
            int x = 2;
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Переменная X = " + x);
            Console.WriteLine("Старт шага первой суммы ряда = " + i);
            Console.WriteLine("Старт шага второй суььы ряда = " + k);
            Console.WriteLine("Конец шага первой суммы ряда = " + v);
            Console.WriteLine("Конец шага второй суммы ряда = " + z);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.GetSumSumSeries(x,i,k,v,z));
            Console.ReadLine();
            //
        }
    }
}
