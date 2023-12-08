namespace Graphics_lab6
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageNoise = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxNoise = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxStart = new System.Windows.Forms.PictureBox();
            this.tabPageNoNoise = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBoxNoiseMini = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBoxStartMini = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.pictureBoxMedian = new System.Windows.Forms.PictureBox();
            this.pictureBoxGauss = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tabPageNoise.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoise)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).BeginInit();
            this.tabPageNoNoise.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoiseMini)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartMini)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMedian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGauss)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControl.Controls.Add(this.tabPageNoise);
            this.tabControl.Controls.Add(this.tabPageNoNoise);
            this.tabControl.Location = new System.Drawing.Point(0, 27);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1143, 555);
            this.tabControl.TabIndex = 0;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl1_Selected);
            // 
            // tabPageNoise
            // 
            this.tabPageNoise.BackColor = System.Drawing.Color.Linen;
            this.tabPageNoise.Controls.Add(this.groupBox2);
            this.tabPageNoise.Controls.Add(this.groupBox1);
            this.tabPageNoise.Location = new System.Drawing.Point(4, 4);
            this.tabPageNoise.Name = "tabPageNoise";
            this.tabPageNoise.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNoise.Size = new System.Drawing.Size(1116, 547);
            this.tabPageNoise.TabIndex = 0;
            this.tabPageNoise.Text = "Шум";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBoxNoise);
            this.groupBox2.Location = new System.Drawing.Point(562, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 535);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Изображение с шумом";
            // 
            // pictureBoxNoise
            // 
            this.pictureBoxNoise.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxNoise.Name = "pictureBoxNoise";
            this.pictureBoxNoise.Size = new System.Drawing.Size(536, 510);
            this.pictureBoxNoise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNoise.TabIndex = 0;
            this.pictureBoxNoise.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxStart);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 535);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходное изображение";
            // 
            // pictureBoxStart
            // 
            this.pictureBoxStart.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStart.Image")));
            this.pictureBoxStart.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxStart.Name = "pictureBoxStart";
            this.pictureBoxStart.Size = new System.Drawing.Size(536, 510);
            this.pictureBoxStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStart.TabIndex = 0;
            this.pictureBoxStart.TabStop = false;
            // 
            // tabPageNoNoise
            // 
            this.tabPageNoNoise.BackColor = System.Drawing.Color.Linen;
            this.tabPageNoNoise.Controls.Add(this.pictureBoxGauss);
            this.tabPageNoNoise.Controls.Add(this.groupBox7);
            this.tabPageNoNoise.Controls.Add(this.groupBox6);
            this.tabPageNoNoise.Controls.Add(this.groupBox5);
            this.tabPageNoNoise.Controls.Add(this.groupBox4);
            this.tabPageNoNoise.Controls.Add(this.groupBox3);
            this.tabPageNoNoise.Location = new System.Drawing.Point(4, 4);
            this.tabPageNoNoise.Name = "tabPageNoNoise";
            this.tabPageNoNoise.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNoNoise.Size = new System.Drawing.Size(1116, 547);
            this.tabPageNoNoise.TabIndex = 1;
            this.tabPageNoNoise.Text = "Шумоподавление";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBoxNoiseMini);
            this.groupBox5.Location = new System.Drawing.Point(6, 328);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(281, 210);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Изображение с шумом";
            // 
            // pictureBoxNoiseMini
            // 
            this.pictureBoxNoiseMini.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxNoiseMini.Name = "pictureBoxNoiseMini";
            this.pictureBoxNoiseMini.Size = new System.Drawing.Size(269, 185);
            this.pictureBoxNoiseMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNoiseMini.TabIndex = 1;
            this.pictureBoxNoiseMini.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBoxStartMini);
            this.groupBox4.Location = new System.Drawing.Point(6, 112);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(281, 210);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Исходное изображение";
            // 
            // pictureBoxStartMini
            // 
            this.pictureBoxStartMini.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxStartMini.Name = "pictureBoxStartMini";
            this.pictureBoxStartMini.Size = new System.Drawing.Size(269, 185);
            this.pictureBoxStartMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStartMini.TabIndex = 1;
            this.pictureBoxStartMini.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(281, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Аппертура";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1143, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.openFileToolStripMenuItem.Text = "Открыть файл";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pictureBoxMedian);
            this.groupBox6.Location = new System.Drawing.Point(293, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(405, 532);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Медианный фильтр";
            this.groupBox6.Visible = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Location = new System.Drawing.Point(705, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(405, 54);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Фильтр Гаусса";
            this.groupBox7.Visible = false;
            // 
            // pictureBoxMedian
            // 
            this.pictureBoxMedian.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxMedian.Name = "pictureBoxMedian";
            this.pictureBoxMedian.Size = new System.Drawing.Size(393, 507);
            this.pictureBoxMedian.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMedian.TabIndex = 2;
            this.pictureBoxMedian.TabStop = false;
            this.pictureBoxMedian.Visible = false;
            // 
            // pictureBoxGauss
            // 
            this.pictureBoxGauss.Location = new System.Drawing.Point(299, 25);
            this.pictureBoxGauss.Name = "pictureBoxGauss";
            this.pictureBoxGauss.Size = new System.Drawing.Size(805, 507);
            this.pictureBoxGauss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGauss.TabIndex = 3;
            this.pictureBoxGauss.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1143, 581);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Лабораторная работа 6";
            this.tabControl.ResumeLayout(false);
            this.tabPageNoise.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoise)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).EndInit();
            this.tabPageNoNoise.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoiseMini)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartMini)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMedian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGauss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageNoise;
        private System.Windows.Forms.TabPage tabPageNoNoise;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBoxNoise;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxStart;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureBoxNoiseMini;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBoxStartMini;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox pictureBoxGauss;
        private System.Windows.Forms.PictureBox pictureBoxMedian;
    }
}

