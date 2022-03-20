using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_1_1
{
    class Segment: Figure
    {
        public Segment(int x1, int y1, int x2, int y2)
        {
            point.Add(x1);
            point.Add(y1);
            point.Add(x2);
            point.Add(y2);
        }

        public override void PrintFigure(Pen pen, Graphics graphic)
        {
            Point a = new Point(point[0], point[1]);
            Point b = new Point(point[2], point[3]);

            graphic.DrawLine(pen, a, b);
        }
    }
}
