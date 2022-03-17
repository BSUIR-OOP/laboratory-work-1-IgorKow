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
        int x, y, width, height;

        public Rectangle(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public override void PrintFigure(Pen pen, Graphics graphic)
        {
            graphic.DrawRectangle(pen, x, y, width, height);
        }

    }
}
