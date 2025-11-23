using System;
using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.RogozinaMA.Sprint2.Task0.V25.Lib
{
    public class DataService : ISprint2Task0V25
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            return new bool[6]
            {
                x == y + 46,      // 205 == 159 + 46 → True
                x != y,           // 205 != 159 → True
                x - 100 < y,      // 205 - 100 < 159 → True
                x > y + 50,       // 205 > 159 + 50 → False
                x <= y,           // 205 <= 159 → False
                x - 46 >= y + 1   // 205 - 46 >= 159 + 1 → False
            };
        }
    }
}