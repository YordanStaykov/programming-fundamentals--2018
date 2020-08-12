using System;
using System.Collections.Generic;
using System.Text;

namespace p05_ClosestTwoPoints
{
    class Point
    {
        public int X { get; set; }

        public int Y { get; set; }

        public string Display()
        {
            return $"({X}, {Y})";
        }
    }
}
