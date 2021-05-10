namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ClearButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.TopsLabel = new System.Windows.Forms.Label();
            this.PreDrawTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PenWidthBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.PenColorButton = new System.Windows.Forms.Button();
            this.PenColorPanel = new System.Windows.Forms.Panel();
            this.FillColorButton = new System.Windows.Forms.Button();
            this.FillColorPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьCTRLYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoButton = new System.Windows.Forms.Button();
            this.RedoButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openDllDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PenWidthBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(854, 410);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(159, 46);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(863, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(945, 62);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // TopsLabel
            // 
            this.TopsLabel.Location = new System.Drawing.Point(860, 62);
            this.TopsLabel.Name = "TopsLabel";
            this.TopsLabel.Size = new System.Drawing.Size(70, 29);
            this.TopsLabel.TabIndex = 5;
            this.TopsLabel.Text = "Количество вершин";
            // 
            // PreDrawTimer
            // 
            this.PreDrawTimer.Interval = 10;
            this.PreDrawTimer.Tick += new System.EventHandler(this.PreDrawTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(811, 544);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // PenWidthBar
            // 
            this.PenWidthBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.PenWidthBar.Location = new System.Drawing.Point(843, 146);
            this.PenWidthBar.Maximum = 50;
            this.PenWidthBar.Minimum = 1;
            this.PenWidthBar.Name = "PenWidthBar";
            this.PenWidthBar.Size = new System.Drawing.Size(170, 45);
            this.PenWidthBar.TabIndex = 10;
            this.PenWidthBar.TickFrequency = 5;
            this.PenWidthBar.Value = 6;
            this.PenWidthBar.Scroll += new System.EventHandler(this.PenWidthBar_Scroll);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(841, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Толщина";
            // 
            // PenColorButton
            // 
            this.PenColorButton.Location = new System.Drawing.Point(829, 223);
            this.PenColorButton.Name = "PenColorButton";
            this.PenColorButton.Size = new System.Drawing.Size(101, 40);
            this.PenColorButton.TabIndex = 8;
            this.PenColorButton.Text = "Цвет линии";
            this.PenColorButton.UseVisualStyleBackColor = true;
            this.PenColorButton.Click += new System.EventHandler(this.PenColorButton_Click);
            // 
            // PenColorPanel
            // 
            this.PenColorPanel.BackColor = System.Drawing.Color.Black;
            this.PenColorPanel.Location = new System.Drawing.Point(951, 223);
            this.PenColorPanel.Name = "PenColorPanel";
            this.PenColorPanel.Size = new System.Drawing.Size(62, 41);
            this.PenColorPanel.TabIndex = 9;
            this.PenColorPanel.Click += new System.EventHandler(this.PenColorButton_Click);
            // 
            // FillColorButton
            // 
            this.FillColorButton.Location = new System.Drawing.Point(829, 270);
            this.FillColorButton.Name = "FillColorButton";
            this.FillColorButton.Size = new System.Drawing.Size(101, 40);
            this.FillColorButton.TabIndex = 10;
            this.FillColorButton.Text = "Цвет заливки";
            this.FillColorButton.UseVisualStyleBackColor = true;
            this.FillColorButton.Click += new System.EventHandler(this.FillColorButton_Click);
            // 
            // FillColorPanel
            // 
            this.FillColorPanel.BackColor = System.Drawing.Color.White;
            this.FillColorPanel.Location = new System.Drawing.Point(951, 269);
            this.FillColorPanel.Name = "FillColorPanel";
            this.FillColorPanel.Size = new System.Drawing.Size(62, 41);
            this.FillColorPanel.TabIndex = 10;
            this.FillColorPanel.Click += new System.EventHandler(this.FillColorButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(860, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Текущее значение:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1025, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьКакToolStripMenuItem,
            this.отменитьToolStripMenuItem,
            this.вернутьCTRLYToolStripMenuItem,
            this.открытьToolStripMenuItem1});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // отменитьToolStripMenuItem
            // 
            this.отменитьToolStripMenuItem.Name = "отменитьToolStripMenuItem";
            this.отменитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.отменитьToolStripMenuItem.Text = "Отменить(CTRL+Z)";
            this.отменитьToolStripMenuItem.Click += new System.EventHandler(this.отменитьToolStripMenuItem_Click);
            // 
            // вернутьCTRLYToolStripMenuItem
            // 
            this.вернутьCTRLYToolStripMenuItem.Name = "вернутьCTRLYToolStripMenuItem";
            this.вернутьCTRLYToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вернутьCTRLYToolStripMenuItem.Text = "Вернуть(CTRL+Y)";
            this.вернутьCTRLYToolStripMenuItem.Click += new System.EventHandler(this.вернутьCTRLYToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem1
            // 
            this.открытьToolStripMenuItem1.Name = "открытьToolStripMenuItem1";
            this.открытьToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem1.Text = "Открыть";
            this.открытьToolStripMenuItem1.Click += new System.EventHandler(this.открытьToolStripMenuItem1_Click);
            // 
            // UndoButton
            // 
            this.UndoButton.Location = new System.Drawing.Point(829, 349);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(75, 23);
            this.UndoButton.TabIndex = 14;
            this.UndoButton.Text = "Отменить";
            this.UndoButton.UseVisualStyleBackColor = true;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // RedoButton
            // 
            this.RedoButton.Location = new System.Drawing.Point(938, 349);
            this.RedoButton.Name = "RedoButton";
            this.RedoButton.Size = new System.Drawing.Size(75, 23);
            this.RedoButton.TabIndex = 15;
            this.RedoButton.Text = "Вернуть";
            this.RedoButton.UseVisualStyleBackColor = true;
            this.RedoButton.Click += new System.EventHandler(this.RedoButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openDllDialog
            // 
            this.openDllDialog.FileName = "openDllDialog";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 568);
            this.Controls.Add(this.RedoButton);
            this.Controls.Add(this.UndoButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FillColorPanel);
            this.Controls.Add(this.FillColorButton);
            this.Controls.Add(this.PenColorPanel);
            this.Controls.Add(this.PenColorButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PenWidthBar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TopsLabel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PenWidthBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label TopsLabel;
        private System.Windows.Forms.Timer PreDrawTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar PenWidthBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button PenColorButton;
        private System.Windows.Forms.Panel PenColorPanel;
        private System.Windows.Forms.Button FillColorButton;
        private System.Windows.Forms.Panel FillColorPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьCTRLYToolStripMenuItem;
        private System.Windows.Forms.Button UndoButton;
        private System.Windows.Forms.Button RedoButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openDllDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem1;
    }
}

