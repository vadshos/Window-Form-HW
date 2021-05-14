using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mouse_events
{
    
    public partial class Form1 : Form
    {
        Graphics graphics;
        Point rectPoint;
        enum StateBrush { Shape,Pen,Stamp}
        StateBrush currentBrush = StateBrush.Pen;
        Color currentColor = Color.Black;
        Rectangle rect = Rectangle.Empty;
        Point end_point = new Point();
        private Point point = Point.Empty;
        bool IsMouseDown = false;
        int currentSize = 10;
        public Form1()
        {
            InitializeComponent();
            graphics = panel1.CreateGraphics();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"Location : {e.Location} Buttons : {e.Button}";
            
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Label lbl = new Label();
            lbl.Size = new Size(10, 10);
            if(e.Button == MouseButtons.Left) 
            lbl.BackColor = Color.Black;
            else
                lbl.BackColor = Color.Red;

            lbl.Location = e.Location;
            this.Controls.Add(lbl);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (currentBrush == StateBrush.Pen)
                {
                    Label lbl = new Label();
                    lbl.Size = new Size(currentSize, currentSize);  
                    lbl.BackColor = currentColor;
                    lbl.Location = e.Location;
                    panel1.Controls.Add(lbl);
                    lbl.BringToFront();
                }else if(currentBrush == StateBrush.Shape)
                {
                    Point p = e.Location;
                    int x = rectPoint.Y;
                    int y = rectPoint.X;
                    int width = (p.X - rectPoint.X);
                    int height = (p.Y - rectPoint.Y);
                    Rectangle rect = new Rectangle(rectPoint.X, rectPoint.Y, width, height);
                    graphics.DrawRectangle(new Pen(new SolidBrush(currentColor)), rect);
                    graphics.FillRectangle(new SolidBrush(currentColor), rect);
                    
                    this.Invalidate();
                   
                }
                else if(currentBrush == StateBrush.Stamp)
                {
                    var stamp = new Label();
                    stamp.Image = label1.Image;
                    stamp.Size = new Size(currentSize * 10, currentSize * 10);
                    stamp.Location = e.Location;
                    panel1.Controls.Add(stamp);
                    stamp.BringToFront();
                }
            }
        }


        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (rect != Rectangle.Empty)
            {
                IsMouseDown = true;
                point = e.Location;
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            if (rect != Rectangle.Empty)
            {
                if (IsMouseDown)
                {
                    point = e.Location;
                    IsMouseDown = false;
                }
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Red, 5), Modificate());
        }
        private Rectangle Modificate()
        {
            rect = new Rectangle();
            rect.X = Math.Min(point.X, end_point.X);
            rect.Y = Math.Min(point.Y, end_point.Y);
            rect.Width = Math.Abs(point.X - end_point.X);
            rect.Height = Math.Abs(point.Y - end_point.Y);
            return rect;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pen_Click(object sender, EventArgs e)
        {
            currentBrush = StateBrush.Pen;
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            currentBrush = StateBrush.Shape;
        }

        private void ColorYellow_Click(object sender, EventArgs e)
        {
            currentColor = Color.Yellow;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            currentColor = Color.Red;
        }

        private void ColorBlack_Click(object sender, EventArgs e)
        {
            currentColor = Color.Black;
        }

        private void ColorBlue_Click(object sender, EventArgs e)
        {
            currentColor = Color.Blue;
        }

        private void btmClear_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            graphics.Clear(Color.White);
        }

        private void size_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(size.Text, out currentSize);
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            currentBrush = StateBrush.Stamp;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if(currentBrush == StateBrush.Shape)
                 rectPoint = e.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (currentBrush == StateBrush.Shape)
                rectPoint = e.Location;
        }
    }
}
