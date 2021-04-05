using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Windows.Forms;
using System.Reflection;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        LinkedList<Type> UsedTypes = new LinkedList<Type>();
        LinkedList<ICreateFig> Creators = new LinkedList<ICreateFig>();
        UndoRedoStack FiguresBackBuffer = new UndoRedoStack(), FiguresFrontBuffer = null;

        
        Graphics gr;
        Pen pen;
        Figure CurrentFigure;
        Bitmap MainPicture = new Bitmap(1000, 1000), TemporaryImage = new Bitmap(1000, 1000);
        int FpsCounter = 0;



        public Form1()
        {

            InitializeComponent();

            if (!LoadModules())
            {
                MessageBox.Show("Error. No figures");
                Application.Exit();
            }



            comboBox1.SelectedIndex = 0;
            gr = Graphics.FromImage(MainPicture);


            gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.Width = PenWidthBar.Value;

            ICreateFig CurrentCreator = Creators.ElementAt<ICreateFig>(comboBox1.SelectedIndex);
            CurrentFigure = CurrentCreator.Create(-1, -1, gr, pen, FillColorPanel.BackColor);

            pictureBox1.Image = MainPicture;


        }

        private bool LoadModules()
        {
            bool FiguresExist = false;
            try
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                Type[] types = assembly.GetTypes();
                int k = 0;
                for (int i = 0; i < types.Length; i++)
                {
                    if (types[i].GetInterface(typeof(ICreateFig).FullName) != null)
                    {
                        Creators.AddLast((ICreateFig)Activator.CreateInstance(types[i]));


                        comboBox1.Items.Add(Creators.ElementAt<ICreateFig>(k).Name);
                        FiguresExist = true;
                        k++;
                    }
                }
            }
            catch
            {
                FiguresExist = false;
            }
            return FiguresExist;
        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {


            CurrentFigure.StartPoint = new Point(e.X, e.Y);
            PreDrawTimer.Enabled = true;


        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (CurrentFigure.StartPoint.X < 0)
                return;

            if (!PreDrawTimer.Enabled)
            {


                TemporaryImage.Dispose();

                TemporaryImage = (Bitmap)MainPicture.Clone();

                pictureBox1.Image = TemporaryImage;
                gr = Graphics.FromImage(TemporaryImage);
                CurrentFigure.DrawPanel = gr;


                CurrentFigure.PreDrawEndPoint = e.Location;
                gr.Dispose();
                PreDrawTimer.Enabled = true;



            }


        }




        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {

            PreDrawTimer.Enabled = false;

            try
            {

                gr = Graphics.FromImage(MainPicture);
                CurrentFigure.DrawPanel = gr;


                if (e.Button == MouseButtons.Right)
                    CurrentFigure.EndOfCurrentFigure = true;




                CurrentFigure.EndPoint = new Point(e.X, e.Y);

                if (FiguresBackBuffer.Count < 1)
                {
                    FiguresBackBuffer.Push(CurrentFigure);
                    UndoButton.Enabled = true;
                }
                else
                {
                    if (FiguresBackBuffer.LastEnd())
                    {
                        FiguresBackBuffer.Push(CurrentFigure);
                    }
                    else
                    {
                        FiguresBackBuffer.Pop();
                        FiguresBackBuffer.Push(CurrentFigure);
                    }

                }




                CurrentFigure.StartPoint = new Point(-2, -2);
                pictureBox1.Image = MainPicture;

                if (FiguresFrontBuffer != null)
                {
                    FiguresFrontBuffer = null;
                    RedoButton.Enabled = false;
                }

            }
            catch { }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            gr = Graphics.FromImage(MainPicture);

            gr.Clear(pictureBox1.BackColor);
            pictureBox1.Image = MainPicture;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDown1.Visible = false;
            TopsLabel.Visible = false;

            ICreateFig CurrentCreator = Creators.ElementAt<ICreateFig>(comboBox1.SelectedIndex);

            CurrentFigure = CurrentCreator.Create(-1, -1, gr, pen, FillColorPanel.BackColor);

            if (CurrentCreator.TopsNeeded)
            {
                numericUpDown1.Visible = true;
                TopsLabel.Visible = true;
            }
            if (FiguresBackBuffer.Count > 0)
                FiguresBackBuffer.ElementAt(0).EndOfCurrentFigure = true;


        }

        private void PenWidthBar_Scroll(object sender, EventArgs e)
        {
            pen.Width = PenWidthBar.Value;
            label3.Text = String.Format("Текущее значение: {0}", PenWidthBar.Value);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            (CurrentFigure as RigthPolygon).TopAmount = (int)numericUpDown1.Value;
        }

        private void PenColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                PenColorPanel.BackColor = colorDialog1.Color;
                pen.Color = colorDialog1.Color;
            }
        }

        private void FillColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                FillColorPanel.BackColor = colorDialog1.Color;
                CurrentFigure.FillColor = colorDialog1.Color;


            }
        }






        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            int N = FiguresBackBuffer.Count;
            if (N <= 0)
                return;
            if (FiguresFrontBuffer == null)
                FiguresFrontBuffer = new UndoRedoStack();


            Figure Last = FiguresBackBuffer.ElementAt(0);

            Last.EndOfCurrentFigure = true;
            FiguresFrontBuffer.Push(Last);
            FiguresBackBuffer.Pop();


            RedoButton.Enabled = true;

            gr = Graphics.FromImage(MainPicture);
            gr.Clear(pictureBox1.BackColor);

            FiguresBackBuffer.DrawStack(gr);


            pictureBox1.Image = MainPicture;

            if (FiguresBackBuffer.Count <= 0)
                UndoButton.Enabled = false;



            ICreateFig CurrentCreator = Creators.ElementAt<ICreateFig>(comboBox1.SelectedIndex);
            CurrentFigure = CurrentCreator.Create(-1, -1, gr, pen, FillColorPanel.BackColor);

        }

        private void RedoButton_Click(object sender, EventArgs e)
        {
            Figure tmp = FiguresFrontBuffer.Pop();
            gr = Graphics.FromImage(MainPicture);
            tmp.DrawPanel = gr;
            tmp.Redraw();



            FiguresBackBuffer.Push(tmp);



            UndoButton.Enabled = true;

            pictureBox1.Image = MainPicture;
            gr.Dispose();
            if (FiguresFrontBuffer.Count == 0)
            {
                RedoButton.Enabled = false;
            }
        }



        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PreDrawTimer_Tick(object sender, EventArgs e)
        {
            PreDrawTimer.Enabled = false;
        }
    }






   


    


}
