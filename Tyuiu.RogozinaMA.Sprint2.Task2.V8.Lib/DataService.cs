using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RogozinaMA.Sprint2.Task2.V8.Lib
{
    public class DataService : ISprint2Task2V8
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            
            bool mainRect = (x >= 2 && x <= 12) && (y >= 2 && y <= 7);

           
            bool topProtrusion = (x >= 4 && x <= 10) && (y >= 8 && y <= 9);
 
            bool bottomProtrusion = (x >= 5 && x <= 9) && (y >= 0 && y <= 1);

            
            bool leftEar = (x >= 0 && x <= 1) && (y >= 4 && y <= 5);

           
            bool rightEar = (x >= 13 && x <= 14) && (y >= 3 && y <= 6);

            return mainRect || topProtrusion || bottomProtrusion || leftEar || rightEar;
        }
    }
}