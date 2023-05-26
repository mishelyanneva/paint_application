namespace Applicationcsharp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Select = new System.Windows.Forms.Button();
            this.Undo = new System.Windows.Forms.Button();
            this.Redo = new System.Windows.Forms.Button();
            this.pic_color = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_rectangle = new System.Windows.Forms.Button();
            this.btn_ellipse = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.error = new System.Windows.Forms.TextBox();
            this.textB = new System.Windows.Forms.TextBox();
            this.textA = new System.Windows.Forms.TextBox();
            this.face = new System.Windows.Forms.TextBox();
            this.pic = new System.Windows.Forms.PictureBox();
            this.btn_color = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 72);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 72);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MistyRose;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Select);
            this.panel3.Controls.Add(this.Undo);
            this.panel3.Controls.Add(this.Redo);
            this.panel3.Controls.Add(this.pic_color);
            this.panel3.Controls.Add(this.btn_save);
            this.panel3.Controls.Add(this.btn_clear);
            this.panel3.Controls.Add(this.btn_line);
            this.panel3.Controls.Add(this.btn_rectangle);
            this.panel3.Controls.Add(this.btn_ellipse);
            this.panel3.Controls.Add(this.btn_color);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(796, 73);
            this.panel3.TabIndex = 2;
            // 
            // Select
            // 
            this.Select.BackColor = System.Drawing.Color.Transparent;
            this.Select.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Select.Image = ((System.Drawing.Image)(resources.GetObject("Select.Image")));
            this.Select.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Select.Location = new System.Drawing.Point(7, 6);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(65, 63);
            this.Select.TabIndex = 4;
            this.Select.Text = "Select";
            this.Select.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Select.UseVisualStyleBackColor = false;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // Undo
            // 
            this.Undo.BackColor = System.Drawing.Color.Transparent;
            this.Undo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Undo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Undo.Image = ((System.Drawing.Image)(resources.GetObject("Undo.Image")));
            this.Undo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Undo.Location = new System.Drawing.Point(78, 6);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(63, 63);
            this.Undo.TabIndex = 4;
            this.Undo.Text = "Undo";
            this.Undo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Undo.UseVisualStyleBackColor = false;
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // Redo
            // 
            this.Redo.BackColor = System.Drawing.Color.Transparent;
            this.Redo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Redo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Redo.Image = ((System.Drawing.Image)(resources.GetObject("Redo.Image")));
            this.Redo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Redo.Location = new System.Drawing.Point(147, 6);
            this.Redo.Name = "Redo";
            this.Redo.Size = new System.Drawing.Size(61, 63);
            this.Redo.TabIndex = 4;
            this.Redo.Text = "Redo";
            this.Redo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Redo.UseVisualStyleBackColor = false;
            this.Redo.Click += new System.EventHandler(this.Redo_Click);
            // 
            // pic_color
            // 
            this.pic_color.Location = new System.Drawing.Point(213, 6);
            this.pic_color.Margin = new System.Windows.Forms.Padding(2);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(29, 24);
            this.pic_color.TabIndex = 15;
            this.pic_color.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.Location = new System.Drawing.Point(684, 40);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(62, 29);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Location = new System.Drawing.Point(684, 6);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(62, 30);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_line
            // 
            this.btn_line.BackColor = System.Drawing.Color.Transparent;
            this.btn_line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_line.ForeColor = System.Drawing.Color.Black;
            this.btn_line.Image = ((System.Drawing.Image)(resources.GetObject("btn_line.Image")));
            this.btn_line.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_line.Location = new System.Drawing.Point(618, 6);
            this.btn_line.Margin = new System.Windows.Forms.Padding(2);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(62, 63);
            this.btn_line.TabIndex = 11;
            this.btn_line.Text = "Line";
            this.btn_line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_line.UseVisualStyleBackColor = false;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // btn_rectangle
            // 
            this.btn_rectangle.BackColor = System.Drawing.Color.Transparent;
            this.btn_rectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_rectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rectangle.ForeColor = System.Drawing.Color.Black;
            this.btn_rectangle.Image = ((System.Drawing.Image)(resources.GetObject("btn_rectangle.Image")));
            this.btn_rectangle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_rectangle.Location = new System.Drawing.Point(546, 6);
            this.btn_rectangle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_rectangle.Name = "btn_rectangle";
            this.btn_rectangle.Size = new System.Drawing.Size(68, 63);
            this.btn_rectangle.TabIndex = 10;
            this.btn_rectangle.Text = "Rectangle";
            this.btn_rectangle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rectangle.UseVisualStyleBackColor = false;
            this.btn_rectangle.Click += new System.EventHandler(this.btn_rectangle_Click);
            // 
            // btn_ellipse
            // 
            this.btn_ellipse.BackColor = System.Drawing.Color.Transparent;
            this.btn_ellipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ellipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_ellipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ellipse.ForeColor = System.Drawing.Color.Black;
            this.btn_ellipse.Image = ((System.Drawing.Image)(resources.GetObject("btn_ellipse.Image")));
            this.btn_ellipse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ellipse.Location = new System.Drawing.Point(486, 6);
            this.btn_ellipse.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ellipse.Name = "btn_ellipse";
            this.btn_ellipse.Size = new System.Drawing.Size(56, 63);
            this.btn_ellipse.TabIndex = 9;
            this.btn_ellipse.Text = "Ellipse";
            this.btn_ellipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ellipse.UseVisualStyleBackColor = false;
            this.btn_ellipse.Click += new System.EventHandler(this.btn_ellipse_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.error);
            this.panel4.Controls.Add(this.textB);
            this.panel4.Controls.Add(this.textA);
            this.panel4.Controls.Add(this.face);
            this.panel4.Location = new System.Drawing.Point(0, 344);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(840, 42);
            this.panel4.TabIndex = 2;
            // 
            // error
            // 
            this.error.Location = new System.Drawing.Point(487, 0);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(100, 20);
            this.error.TabIndex = 3;
            this.error.TextChanged += new System.EventHandler(this.error_TextChanged);
            // 
            // textB
            // 
            this.textB.Location = new System.Drawing.Point(266, 0);
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(100, 20);
            this.textB.TabIndex = 2;
            this.textB.TextChanged += new System.EventHandler(this.textB_Changed);
            // 
            // textA
            // 
            this.textA.Location = new System.Drawing.Point(160, 0);
            this.textA.Name = "textA";
            this.textA.Size = new System.Drawing.Size(100, 20);
            this.textA.TabIndex = 1;
            this.textA.TextChanged += new System.EventHandler(this.textA_Changed);
            // 
            // face
            // 
            this.face.AcceptsTab = true;
            this.face.Location = new System.Drawing.Point(0, 0);
            this.face.Name = "face";
            this.face.Size = new System.Drawing.Size(85, 20);
            this.face.TabIndex = 0;
            this.face.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.Transparent;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Margin = new System.Windows.Forms.Padding(2);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(756, 384);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic.TabIndex = 3;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDoubleClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // btn_color
            // 
            this.btn_color.BackColor = System.Drawing.Color.Transparent;
            this.btn_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_color.ForeColor = System.Drawing.Color.Black;
            this.btn_color.Image = ((System.Drawing.Image)(resources.GetObject("btn_color.Image")));
            this.btn_color.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_color.Location = new System.Drawing.Point(246, 6);
            this.btn_color.Margin = new System.Windows.Forms.Padding(2);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(56, 63);
            this.btn_color.TabIndex = 6;
            this.btn_color.Text = "Color";
            this.btn_color.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_color.UseVisualStyleBackColor = false;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 384);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_rectangle;
        private System.Windows.Forms.Button btn_ellipse;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.Button Undo;
        private System.Windows.Forms.Button Redo;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.TextBox face;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.TextBox textA;
        private System.Windows.Forms.TextBox error;
        private System.Windows.Forms.Button btn_color;
    }
}

