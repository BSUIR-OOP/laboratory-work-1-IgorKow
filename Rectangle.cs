using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_1_1
{
    class Rectangle: Figure
    {
        public Rectangle(int x, int y, int width, int height)
        {
            point.Add(x);
            point.Add(y);
            point.Add(width);
            point.Add(height);
        }

        public override void PrintFigure(Pen pen, Graphics graphic)
        {
            graphic.DrawRectangle(pen, point[0], point[1], point[2], point[3]);
        }

    }
}
