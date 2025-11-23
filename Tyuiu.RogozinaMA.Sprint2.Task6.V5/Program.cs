using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.RogozinaMA.Sprint2.Task6.V5.Lib;

namespace Tyuiu.RogozinaMA.Sprint2.Task6.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Рогозина М.А. | ИСПб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнила: Рогозина Милана Андреевна | ИСПб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
            Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.   *");
            Console.WriteLine("* Игральным картам условно присвоены следующие порядковые номера:         *");
            Console.WriteLine("* «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14.                *");
            Console.WriteLine("* Порядковые номера остальных карт соответствуют их названиям.            *");
            Console.WriteLine("* По заданному номеру карты k (6 <= k <= 14) определить достоинство      *");
            Console.WriteLine("* соответствующей карты.                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите номер карты (6-14): ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                string result = ds.FindCardValue(k);
                Console.WriteLine($"Карта с номером {k} — это {result}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}