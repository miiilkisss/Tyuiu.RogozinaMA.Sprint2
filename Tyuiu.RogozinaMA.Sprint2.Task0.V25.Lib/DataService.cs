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
                x == y + 46,      // True
                x != y,           // True
                x - 100 < y,      // True
                x > y + 50,       // False
                x <= y,           // False
                x - 46 >= y + 1   // False
            };
        }
    }
}