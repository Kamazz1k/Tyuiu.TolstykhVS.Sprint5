using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TolstykhVS.Sprint5.Task5.V15.Lib;
using System.IO;

namespace Tyuiu.TolstykhVS.Sprint5.Task4.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Толстых В.С. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Толстых Вячеслав Сергеевич | СМАРТб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:/InPutDataFileTask4V0.txt (файл взять из архива  *");
            Console.WriteLine("*согласно вашему варианту.Создать папку в ручную С:/DataSprint5/          *");
            Console.WriteLine("и скопировать в неё файл) в котором есть вещественное значение.           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            string path = @"C:\DataSprint5\InPutDataFileTask5V15.txt";
            Console.WriteLine("Данные находятся в файле:" + path);
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double rez = ds.LoadFromDataFile(path);
            Console.WriteLine(rez);
            Console.ReadKey();

        }
    }
}

