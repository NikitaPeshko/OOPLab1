using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Draw();
          //  DrawTreangle();


        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Red);
            
            graph.DrawLine(pen, 10, 50, 150, 200);
          
            Rectangle rect = new Rectangle(150, 50, 200, 100);
            graph.DrawEllipse(pen, rect);
           
            
            Rectangle rect1 = new Rectangle(350, 50, 200, 100);
            Pen penRect = new Pen(Color.Black);


            Color customColor = Color.FromArgb(50, Color.Gray);
            
            SolidBrush shadowBrush = new SolidBrush(customColor);
            graph.DrawRectangle(penRect,rect1);
            graph.FillRectangle(shadowBrush, rect1);

            PointF point1 = new PointF(50.0F, 50.0F);
            PointF point2 = new PointF(100.0F, 50.0F);
            PointF point3 = new PointF(200.0F, 35.0F);
            PointF point4 = new PointF(250.0F, 50.0F);
            PointF point5 = new PointF(300.0F, 100.0F);
            PointF point6 = new PointF(350.0F, 200.0F);
            PointF point7 = new PointF(250.0F, 250.0F);
            PointF[] curvePoints =
                     {
                 point1,
                 point2,
                 point3,
                 point4,
                 point5,
                 point6,
                 point7
             };
            graph.DrawPolygon(pen, curvePoints);
            pictureBox1.Image = bmp;

        }
        


        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
