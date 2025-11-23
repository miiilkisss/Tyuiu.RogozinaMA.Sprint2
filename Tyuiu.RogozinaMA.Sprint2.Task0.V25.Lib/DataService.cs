using System;
using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.RogozinaMA.Sprint2.Task0.V25.Lib
{
    public class DataService : ISprint2Task0V25
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            // Операции сравнения в заданной последовательности
            res[0] = x == y + 46;        // 205 == 159 + 46 → 205 == 205 → True
            res[1] = x != y;             // 205 != 159 → True
            res[2] = x - 100 < y;        // 205 - 100 < 159 → 105 < 159 → True
            res[3] = x > y + 50;         // 205 > 159 + 50 → 205 > 209 → False
            res[4] = x <= y;             // 205 <= 159 → False
            res[5] = x - 46 >= y + 1;    // 205 - 46 >= 159 + 1 → 159 >= 160 → False

            return res;
        }
    }
}  