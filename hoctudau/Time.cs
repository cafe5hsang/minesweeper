using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper_DataStructAndAlgorithms
{
    public class Time
    {
        private int min;
        private int second;

        public Time()
        {
            this.min = 0;
            this.second = 0;
        }
        public Time(int min, int second)
        {
            this.min = min;
            this.second = second;
        }
        public void loadTime()
        {
            if (second == 59)
            {
                second = 0;
                min += 1;
            }
            else
            {
                second += 1;
            }
        }
        public override string ToString()
        {
            return min.ToString() + ":" + second.ToString();
        }
    }
}
