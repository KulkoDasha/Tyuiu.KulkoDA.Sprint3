using Tyuiu.KulkoDA.Sprint3.Task4.V21.Lib;
namespace Tyuiu.KulkoDA.Sprint3.Task4.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Кулько Д. А. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнила: Кулько Дарья Андреевна | ИИПб-24-2                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке,где x принимает значения от -5до5,вычислить значение функции *");
            Console.WriteLine("* y=(cos(x)-x)/x. Полученные значения перемножать.                        *");
            Console.WriteLine("*                                                                         *");
            int a = -5;
            int z = 5;
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Старт шага: "+a);
            Console.WriteLine("Конец шага: "+z);
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Старт шага: " + a);
            Console.WriteLine("Конец шага: " + z);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(a,z));
            Console.ReadLine();
        }
    }
}
