using System;
using System.Drawing;

namespace Applicationcsharp
{
    internal class Line : Shape
    {
        public Line(Point start, Point end, Color color, float penWidth)
            : base(start, end, color, penWidth)
        {
        }

        public override void Draw(Graphics g)
        {
            Pen p = new Pen(color, penWidth);
            int width = Math.Abs(end.X - start.X);
            int height = Math.Abs(end.Y - start.Y);
            Point drawStart = new Point(start.X, start.Y);
            g.DrawLine(p, drawStart.X, drawStart.Y, end.X, end.Y);
        }
        public override float face(Shape shape)
        {
            return 0;
        }
    }
}