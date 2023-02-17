using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY8LINES
{
    public class LineModelling
    {
        int x1, y1, x2, y2;
        public LineModelling(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public void Compare()
        {
            double length = Math.Sqrt(Math.Pow((this.x2 - this.x1), 2) + Math.Pow((this.y2 - this.y1), 2));
            Console.WriteLine("Length of the line: " + length);
        }
    }
}
