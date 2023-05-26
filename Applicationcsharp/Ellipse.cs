using System;
using System.Drawing;

namespace Applicationcsharp
{
    internal class Ellipse : Shape
    {
        public Ellipse(Point start, Point end, Color color, float penWidth)
                : base(start, end, color, penWidth)
        {
        }

        public override void Draw(Graphics g)
        {
            Pen p = new Pen(color, penWidth);
            int width = Math.Abs(end.X - start.X);
            int height = Math.Abs(end.Y - start.Y);
            Point drawStart = new Point(start.X, start.Y);
            if (start.X - end.X > 0)
                drawStart.X = end.X;
            if (start.Y - end.Y > 0)
                drawStart.Y = end.Y;
            g.DrawEllipse(p, drawStart.X, drawStart.Y, width, height);
        }

        public override float face(Shape shape)
        {
            return 0;
        }
    }
 }