using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Applicationcsharp
{
    public abstract class Shape
    {
        protected Point start;
        protected Point notSureStart;
        protected Point end;
        protected Point notSureEnd;
        protected Color color;
        protected float penWidth;

        public Shape(Point start, Point end, Color color, float penWidth)
        {
            this.start = start;
            this.end = end;
            this.notSureStart = start;
            this.notSureEnd = end;
            this.color = color;
            this.penWidth = penWidth;
        }

        public abstract void Draw(Graphics g);
        public bool contain(Point p)
        {
            Debug.WriteLine("" + start + "" + p + "" + end);
            int max = Math.Max(start.X, end.X);
            int min = Math.Min(start.X, end.X);
            if(min < p.X && p.X < max)
            {
                max = Math.Max(start.Y, end.Y);
                min = Math.Min(start.Y, end.Y);
                if (min < p.Y && p.Y < max) {
                    return true;
                }
            }
            return false;
        }
        public void move(Point p1, Point p2)
        {
            int width = p1.X - p2.X;
            int height = p1.Y - p2.Y;
            start = notSureStart;
            end = notSureEnd;
            start.X -= width;
            end.X -= width;
            start.Y -= height;
            end.Y -= height;
        }

        public void setStatic()
        {
            notSureStart = start;
            notSureEnd = end;
        }
        public abstract float face(Shape shape);
        public void resize(int a, int b) {
            end.X = start.X + a;
            end.Y = start.Y - b;
        }
    }   
}
