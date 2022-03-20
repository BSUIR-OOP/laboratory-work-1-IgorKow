using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_1_1
{
    class Triangle: Figure
    {
        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            point.Add(x1);
            point.Add(y1);
            point.Add(x2);
            point.Add(y2);
            point.Add(x3);
            point.Add(y3);
        }

        public override void PrintFigure(Pen pen, Graphics graphic)
        {
            Point a = new Point(point[0], point[1]);
            Point b = new Point(point[2], point[3]);
            Point c = new Point(point[4], point[5]);

            graphic.DrawLine(pen, a, b);
            graphic.DrawLine(pen, b, c);
            graphic.DrawLine(pen, c, a);
        }

    }
}
