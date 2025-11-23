using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.RogozinaMA.Sprint2.Task0.V25.Lib;
 
namespace Tyuiu.RogozinaMA.Sprint2.Task0.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Рогозина М.А. | ИСПб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнила: Рогозина Милана Андреевна | ИСПб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
            Console.WriteLine("* последовательность операций не должна нарушаться) и арифметических      *");
            Console.WriteLine("* выражений, которая вернет логическую последовательность(массив):        *");
            Console.WriteLine("* (True, True, True, False, False, False), при x = 205, y = 159           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 205;
            int y = 159;

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Получение результата через библиотеку
            bool[] result = ds.GetCompareOperations(x, y);

            Console.WriteLine("Результат сравнений:");
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"Операция {i + 1}: {result[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("Ожидаемая последовательность: (True, True, True, False, False, False)");

            Console.ReadLine();
        }
    }
}