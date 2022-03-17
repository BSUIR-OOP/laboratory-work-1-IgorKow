using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1_1
{
    public partial class Form1 : Form
    {
        Graphics graphic;
        Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0), 3);
        List<Figure> list = new List<Figure>();
        public Form1()
        {
            InitializeComponent();
            graphic = CreateGraphics();
            list.Add(new Triangle(350, 15, 425, 200, 275, 200));
            list.Add(new Segment(175, 100, 475, 100));
            list.Add(new Circle(225, 15, 200, 200));
            list.Add(new Rectangle(180, 15, 300, 197));
            list.Add(new Hexagon(325, 15, 400, 75, 400, 150, 325, 200, 250, 150, 250, 75));
            list.Add(new Trapezium(200, 100, 350, 100, 450, 200, 200, 200));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            graphic.Clear(BackColor);
            list[0].PrintFigure(pen, graphic);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            graphic.Clear(BackColor);
            list[1].PrintFigure(pen, graphic);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            graphic.Clear(BackColor);
            list[2].PrintFigure(pen, graphic);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            graphic.Clear(BackColor);
            list[3].PrintFigure(pen, graphic);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            graphic.Clear(BackColor);
            list[5].PrintFigure(pen, graphic);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            graphic.Clear(BackColor);
            list[4].PrintFigure(pen, graphic);
        }
    }
}
