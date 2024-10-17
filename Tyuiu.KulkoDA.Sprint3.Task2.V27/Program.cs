using Tyuiu.KulkoDA.Sprint3.Task2.V27.Lib;

namespace Tyuiu.KulkoDA.Sprint3.Task2.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Кулько Д. А. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнила: Кулько Дарья Андреевна | ИИПб-24-2                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл do...while,                           *");
            Console.WriteLine("* которая вычисляет сумму ряда по формуле, при х=5.                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* (4/(1+x^i))^i                                                           *");
            int x = 5;
            int y = 14;
            int i = 1;
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.GetSumSeries(x,i,y));
            Console.ReadLine();
        }
    }
}
