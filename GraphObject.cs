using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab2
{
    class GraphObject
    {
        Color c;
        int x, y;
        int w, h;
        static Random r = new Random();
        SolidBrush brush;

        public GraphObject()
        {
             Color[] cols = { Color.Red, Color.Green, Color.Yellow, Color.Tomato,Color.Cyan };
             c = cols[r.Next(cols.Length)];
             x = r.Next(200);
             y = r.Next(200);
             w = 50;
             h = 50;
             brush = new SolidBrush(c);

        }
        public void Draw(Graphics g)
        {
            g.FillRectangle(brush, x, y, w, h);
            g.DrawRectangle(Pens.Black, x, y, w, h);
        }


    }

}
