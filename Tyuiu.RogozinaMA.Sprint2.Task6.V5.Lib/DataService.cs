using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RogozinaMA.Sprint2.Task6.V5.Lib
{
    public class DataService : ISprint2Task6V5
    {
        public string FindCardValue(int value)
        {
            string cardName = value switch
            {
                6 => "Шестерка",
                7 => "Семерка",
                8 => "Восьмерка",
                9 => "Девятка",
                10 => "Десятка",
                11 => "Валет",
                12 => "Дама",
                13 => "Король",
                14 => "Туз",
                _ => throw new ArgumentException($"Некорректное значение карты: {value}. Допустимый диапазон: 6-14")
            };

            return cardName;
        }
    }
}