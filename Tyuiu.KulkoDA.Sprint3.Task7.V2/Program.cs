using Tyuiu.KulkoDA.Sprint3.Task7.V2.Lib;
namespace Tyuiu.KulkoDA.Sprint3.Task7.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Кулько Д. А. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                  *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнила: Кулько Дарья Андреевна | ИИПб-24-2                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
            Console.WriteLine("* на заданном диапазоне [-5;5]                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");
            int a = -5;
            int b = 5;
            Console.WriteLine("Старт шага = "+a);
            Console.WriteLine("Кoнец шага = "+b);
            int len = b - a + 1;
            double[] mass= new double[len];
            mass = ds.GetMassFunction(a,b);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   f(x)   |");
            Console.WriteLine("+----------+----------+");
            for(int i = 0; i <= len-1; i++)
            {
                Console.WriteLine("|{0,5:d}     | {1, 5:f2}   |", a, mass[i]);
                a++;
            }
            Console.WriteLine("+----------+----------+");
            Console.ReadLine();

        }
    }
}
