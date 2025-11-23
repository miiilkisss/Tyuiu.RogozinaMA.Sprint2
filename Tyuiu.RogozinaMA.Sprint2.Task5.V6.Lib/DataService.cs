using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RogozinaMA.Sprint2.Task5.V6.Lib
{
    public class DataService : ISprint2Task5V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string suit = "";
            string rank = "";

            
            switch (value1)
            {
                case 1:
                    suit = "пик";
                    break;
                case 2:
                    suit = "треф";
                    break;
                case 3:
                    suit = "бубен";
                    break;
                case 4:
                    suit = "червей";
                    break;
                default:
                    throw new ArgumentException("Некорректный номер масти. Допустимые значения: 1-4");
            }

            
            switch (value2)
            {
                case 6:
                    rank = "шестерка";
                    break;
                case 7:
                    rank = "семерка";
                    break;
                case 8:
                    rank = "восьмерка";
                    break;
                case 9:
                    rank = "девятка";
                    break;
                case 10:
                    rank = "десятка";
                    break;
                case 11:
                    rank = "валет";
                    break;
                case 12:
                    rank = "дама";
                    break;
                case 13:
                    rank = "король";
                    break;
                case 14:
                    rank = "туз";
                    break;
                default:
                    throw new ArgumentException("Некорректный номер достоинства. Допустимые значения: 6-14");
            }

            return $"{rank} {suit}";
        }
    }
}