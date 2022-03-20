using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_1_1
{
    class Hexagon: Figure
    {
        public Hexagon(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4, int x5, int y5, int x6, int y6)
        {
            point.Add(x1);
            point.Add(y1);
            point.Add(x2);
            point.Add(y2);
            point.Add(x3);
            point.Add(y3);
            point.Add(x4);
            point.Add(y4);
            point.Add(x5);
            point.Add(y5);
            point.Add(x6);
            point.Add(y6); 
        }

        public override void PrintFigure(Pen pen, Graphics graphic)
        {
            Point a = new Point(point[0], point[1]);
            Point b = new Point(point[2], point[3]);
            Point c = new Point(point[4], point[5]);
            Point d = new Point(point[6], point[7]);
            Point e = new Point(point[8], point[9]);
            Point f = new Point(point[10], point[11]);

            graphic.DrawLine(pen, a, b);
            graphic.DrawLine(pen, b, c);
            graphic.DrawLine(pen, c, d);
            graphic.DrawLine(pen, d, e);
            graphic.DrawLine(pen, e, f);
            graphic.DrawLine(pen, f, a);
        }
    }
}
