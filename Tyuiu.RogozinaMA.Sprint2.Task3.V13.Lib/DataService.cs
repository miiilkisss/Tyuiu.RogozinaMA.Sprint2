using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RogozinaMA.Sprint2.Task3.V13.Lib
{
    public class DataService : ISprint2Task3V13
    {
        public double Calculate(double x)
        {
            double y;

            if (x > 1)
            {
                // y = [x - ((x+1)/(x-1))^x] / [7x² - cos(x²) + 10]
                double temp = (x + 1) / (x - 1);
                double numerator = x - Math.Pow(temp, x);
                double denominator = 7 * Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 10;
                y = numerator / denominator;
            }
            else if (x == 0)
            {
                // y = 8x² - sin(x²) + 12
                y = 8 * Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12;
            }
            else if (x > -17 && x < 2 && x != 0)
            {
                // y = (3 + 8/x²)^x
                double baseValue = 3 + 8 / Math.Pow(x, 2);
                y = Math.Pow(baseValue, x);
            }
            else if (x < -17)
            {
                // y = x + 10x - (1/x) = 11x - 1/x
                y = 11 * x - (1 / x);
            }
            else
            {
                throw new ArgumentException($"x = {x} не попадает в определенные интервалы");
            }

            return Math.Round(y, 3);
        }
    }
}