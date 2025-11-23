using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RogozinaMA.Sprint2.Task4.V2.Lib
{
    public class DataService : ISprint2Task4V2
    {
        public double Calculate(double x, double y)
        {
            double z = x > y + 3
                ? x + (x + 1) / y
                : Math.Pow((y + 5) / (y + 2), x);

            return Math.Round(z, 3);
        }
    }
}