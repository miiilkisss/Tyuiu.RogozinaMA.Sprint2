using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RogozinaMA.Sprint2.Task1.V22.Lib
{
    public class DataService : ISprint2Task1V22
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a < b) | (c > d);          // True | True → True
            res[1] = (a != b) & (c != d);        // True & True → True  
            res[2] = (a <= b) || (c >= d);       // True || True → True
            res[3] = (a > b) && (c < d);         // False && False → False
            res[4] = !(a < b);                   // !True → False
            res[5] = (a == b) ^ (c == d);        // False ^ False → False

            return res;
        }
    }
}