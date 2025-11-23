using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RogozinaMA.Sprint2.Task1.V22.Lib
{
    public class DataService : ISprint2Task1V22
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            // Операции сравнения и логические операции
            res[0] = (a < b) | (c > d);          // (324 < 696) | (254 > 155) → True | True → True
            res[1] = (a == b) & (c != d);        // (324 == 696) & (254 != 155) → False & True → False
            res[2] = (a <= b) || (c >= d);       // (324 <= 696) || (254 >= 155) → True || True → True
            res[3] = (a > b) && (c < d);         // (324 > 696) && (254 < 155) → False && False → False
            res[4] = !(a != b);                  // !(324 != 696) → !True → False
            res[5] = (a == b) ^ (c == d);        // (324 == 696) ^ (254 == 155) → False ^ False → False

            return res;
        }
    }
}