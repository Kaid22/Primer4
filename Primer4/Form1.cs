using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a, b, x, y;

        private void timer1_Tick(object sender, EventArgs e)
        {
            x += 5;
            Refresh();
            if (x > ClientRectangle.Width + 2 * a)
                x = -2 * a;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Point p1 = new Point(x - 2 * a, y);
            Point p2 = new Point(x + 2 * a, y);
            Point p3 = new Point(x + a, y + b);
            Point p4 = new Point(x - a, y + b);
            Point p5 = new Point(x, y - 3*b);
            Point p6 = new Point(x + 2 * a, y-2*b);
            Point p7 = new Point(x, y-b);
            Point[] camac = { p1, p2, p3, p4 };
            Point[] jedro = { p5, p6, p7 };
            Graphics g = CreateGraphics();
            SolidBrush cetka = new SolidBrush(Color.PeachPuff);
            g.FillPolygon(cetka, camac);
            Pen olovka = new Pen(Color.Black, 2);
            g.DrawPolygon(olovka, camac);
            cetka.Color = Color.White;
            g.FillPolygon(cetka, jedro);
            olovka.Color = Color.Chocolate;
            olovka.Width = 10;
            g.DrawLine(olovka, x, y, x, y - 3 * b);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            a = 40;
            b = 40;
            x = -2 * a;
            y = ClientRectangle.Height / 2;
            timer1.Start();


        }
    }
}
