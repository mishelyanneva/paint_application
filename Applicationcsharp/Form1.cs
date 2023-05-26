using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Imaging;

namespace Applicationcsharp
{
    public partial class Form1 : Form
    {
        List<Shape> Shapes = new List<Shape>();
        List<Shape> UndoShapes = new List<Shape>();

        int A = 0;
        int B = 0;

        int index = 0;
        ColorDialog cd = new ColorDialog();
        Color new_color;
        Bitmap bm;
        Graphics g;
        Pen p = new Pen(Color.Black, 1);
        bool isClicked;

        Point startPos;
        Shape selectedShape;
        int selectedIndex;
        bool isSelectedShape = false;
        public Form1()
        {
            InitializeComponent();

            this.Width = 780;
            this.Height = 410;
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;

            isClicked = false;
        }


        private void DrawShape(Shape shape)
        {
            g.Clear(Color.White);
            foreach (var s in Shapes)
            {
                s.Draw(g);
            }
            shape.Draw(g);
            pic.Image = bm;

        }
        private void DrawShapes()
        {
            g.Clear(Color.White);
            foreach (var s in Shapes)
            {
                s.Draw(g);
            }
            pic.Image = bm;
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (isClicked)// && startPos != new Point(e.X, e.Y))
            {
                Point endP = new Point(e.X, e.Y);
                switch (index)
                {
                    case 3:
                        DrawShape(new Ellipse(startPos, endP, p.Color, p.Width));
                        break;
                    case 4:
                        DrawShape(new Kvadrat(startPos, endP, p.Color, p.Width));
                        break;
                    case 5:
                        DrawShape(new Line(startPos, endP, p.Color, p.Width));
                        break;
                    case 6:
                        if (selectedShape != null)
                        {
                            selectedShape.move(startPos, endP);
                        }
                        DrawShapes();
                        break;
                    default: break;
                }
            }
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isClicked)
            {
                isSelectedShape = false;
                startPos = new Point(e.X, e.Y);
                switch (index) {
                    case 6:
                        selectedShape = null;
                        foreach (var s in Shapes)
                        {
                            if (s.contain(startPos)){
                                selectedShape = s;
                                selectedIndex = Shapes.IndexOf(s);
                                face.Text = "S = " + selectedShape.face(s).ToString();
                                isSelectedShape = true;
                                break;
                            }
                        }
                        break;
                    default: break;
                }
            }
            isClicked = true;
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            if (isClicked)
            {
                Point endP = new Point(e.X, e.Y);
                switch (index) { 
                    case 3:
                        Shapes.Add(new Ellipse(startPos, endP, p.Color, p.Width));
                        break;
                    case 4:
                        Shapes.Add(new Kvadrat(startPos, endP, p.Color, p.Width));
                        break;
                    case 5:
                        Shapes.Add(new Line(startPos, endP, p.Color, p.Width));
                        break;
                    case 6:
                        if(selectedShape != null)
                        {
                            selectedShape.move(startPos, endP);
                            Shapes.RemoveAt(selectedIndex);
                            selectedShape.setStatic();
                            Shapes.Add(selectedShape);
                        }
                        DrawShapes();
                        break;

                    default: break;
                }
            }
            isClicked = false;
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pic_MouseDoubleClick(object sender, MouseEventArgs e) {

        }
        private void Undo_Click(object sender, EventArgs e)
        {
            if (Shapes.Count > 0)
            {
                UndoShapes.Add(Shapes.Last());
                Shapes.RemoveAt(Shapes.Count - 1);
                DrawShapes();
            }
        }

        private void Redo_Click(object sender, EventArgs e)
        {
            if (UndoShapes.Count > 0)
            {
                Shapes.Add(UndoShapes.Last());
                UndoShapes.RemoveAt(UndoShapes.Count - 1);
                DrawShapes();
            }
        }
        private void Select_Click(object sender, EventArgs e) {
            index = 6;
        }

        private void btn_pencil_Click(object sender, EventArgs e)
        {
            //index = 1;
        }

        private void btn_eraser_click(object sender, EventArgs e)
        {
            //index = 2;
        }

        private void btn_ellipse_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btn_rectangle_Click(object sender, EventArgs e)
        {
            index = 4;
        }
        private void btn_line_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Shapes.Clear();
            UndoShapes.Clear();
            g.Clear(Color.White);
            pic.Image = bm;
        }
        private void btn_color_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_color = cd.Color;
            pic_color.BackColor = cd.Color;
            p.Color = cd.Color;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textA_Changed(object sender, EventArgs e)
        {
            if (index == 6 && isSelectedShape == true)
            {
                if (int.TryParse(textA.Text, out A))
                {
                    if (B == 0)
                    {
                        error.Text = "add number on B";
                    }
                    else
                    {
                        selectedShape.resize(A, B);
                        Shapes.RemoveAt(selectedIndex);
                        Shapes.Add(selectedShape);
                        DrawShapes();
                    }
                }
                else
                {
                    error.Text = "input int";
                }
            }
        }
        

        private void textB_Changed(object sender, EventArgs e)
        {
            if (index == 6 && isSelectedShape == true)
            {
                if (int.TryParse(textB.Text, out B))
                {
                    if (A == 0)
                    {
                        error.Text = "add number on A";
                    }
                    else
                    {
                        selectedShape.resize(A, B);
                        Shapes.RemoveAt(selectedIndex);
                        Shapes.Add(selectedShape);
                        DrawShapes();
                    }
                }
                else {
                    error.Text = "input int";
                }
            }
        }
        private void error_TextChanged(object sender, EventArgs e) { 
        
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Rectangle form = this.Bounds;
            Rectangle formRectangle = new Rectangle(form.X+95, form.Y+50, 980, 500);

            Bitmap bitmap = new Bitmap(formRectangle.Width, formRectangle.Height);

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.CopyFromScreen(formRectangle.Left, formRectangle.Top, 0, 0, bitmap.Size);
            }
            bitmap.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\screenshot.png", ImageFormat.Png);
        }
    }
}