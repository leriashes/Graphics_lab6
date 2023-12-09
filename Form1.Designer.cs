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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.pictureBoxGauss = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pictureBoxMedian = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBoxNoiseMini = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBoxStartMini = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tabPageSharpen = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.pictureBoxStartSharp = new System.Windows.Forms.PictureBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.pictureBoxSharp = new System.Windows.Forms.PictureBox();
            this.tabPageEdges = new System.Windows.Forms.TabPage();
            this.groupBoxEdges = new System.Windows.Forms.GroupBox();
            this.pictureBoxEdges = new System.Windows.Forms.PictureBox();
            this.groupBoxStartEdges = new System.Windows.Forms.GroupBox();
            this.pictureBoxStartEdges = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl.SuspendLayout();
            this.tabPageNoise.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoise)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).BeginInit();
            this.tabPageNoNoise.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGauss)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMedian)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoiseMini)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartMini)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tabPageSharpen.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartSharp)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSharp)).BeginInit();
            this.tabPageEdges.SuspendLayout();
            this.groupBoxEdges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdges)).BeginInit();
            this.groupBoxStartEdges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartEdges)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControl.Controls.Add(this.tabPageNoise);
            this.tabControl.Controls.Add(this.tabPageNoNoise);
            this.tabControl.Controls.Add(this.tabPageSharpen);
            this.tabControl.Controls.Add(this.tabPageEdges);
            this.tabControl.Location = new System.Drawing.Point(0, 27);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1415, 555);
            this.tabControl.TabIndex = 0;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl_Selected);
            // 
            // tabPageNoise
            // 
            this.tabPageNoise.BackColor = System.Drawing.Color.Linen;
            this.tabPageNoise.Controls.Add(this.groupBox2);
            this.tabPageNoise.Controls.Add(this.groupBox1);
            this.tabPageNoise.Location = new System.Drawing.Point(4, 4);
            this.tabPageNoise.Name = "tabPageNoise";
            this.tabPageNoise.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNoise.Size = new System.Drawing.Size(1388, 547);
            this.tabPageNoise.TabIndex = 0;
            this.tabPageNoise.Text = "Шум";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBoxNoise);
            this.groupBox2.Location = new System.Drawing.Point(834, 6);
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
            this.groupBox1.Location = new System.Drawing.Point(280, 6);
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
            this.tabPageNoNoise.Controls.Add(this.groupBox7);
            this.tabPageNoNoise.Controls.Add(this.groupBox6);
            this.tabPageNoNoise.Controls.Add(this.groupBox5);
            this.tabPageNoNoise.Controls.Add(this.groupBox4);
            this.tabPageNoNoise.Controls.Add(this.groupBox3);
            this.tabPageNoNoise.Location = new System.Drawing.Point(4, 4);
            this.tabPageNoNoise.Name = "tabPageNoNoise";
            this.tabPageNoNoise.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNoNoise.Size = new System.Drawing.Size(1388, 547);
            this.tabPageNoNoise.TabIndex = 1;
            this.tabPageNoNoise.Text = "Шумоподавление";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.pictureBoxGauss);
            this.groupBox7.Location = new System.Drawing.Point(834, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(548, 535);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Фильтр Гаусса";
            // 
            // pictureBoxGauss
            // 
            this.pictureBoxGauss.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxGauss.Name = "pictureBoxGauss";
            this.pictureBoxGauss.Size = new System.Drawing.Size(535, 510);
            this.pictureBoxGauss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGauss.TabIndex = 3;
            this.pictureBoxGauss.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pictureBoxMedian);
            this.groupBox6.Location = new System.Drawing.Point(280, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(548, 535);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Медианный фильтр";
            // 
            // pictureBoxMedian
            // 
            this.pictureBoxMedian.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxMedian.Name = "pictureBoxMedian";
            this.pictureBoxMedian.Size = new System.Drawing.Size(536, 510);
            this.pictureBoxMedian.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMedian.TabIndex = 2;
            this.pictureBoxMedian.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBoxNoiseMini);
            this.groupBox5.Location = new System.Drawing.Point(6, 313);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(268, 228);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Изображение с шумом";
            // 
            // pictureBoxNoiseMini
            // 
            this.pictureBoxNoiseMini.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxNoiseMini.Name = "pictureBoxNoiseMini";
            this.pictureBoxNoiseMini.Size = new System.Drawing.Size(255, 203);
            this.pictureBoxNoiseMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNoiseMini.TabIndex = 1;
            this.pictureBoxNoiseMini.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBoxStartMini);
            this.groupBox4.Location = new System.Drawing.Point(6, 79);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(268, 228);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Исходное изображение";
            // 
            // pictureBoxStartMini
            // 
            this.pictureBoxStartMini.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxStartMini.Name = "pictureBoxStartMini";
            this.pictureBoxStartMini.Size = new System.Drawing.Size(257, 203);
            this.pictureBoxStartMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStartMini.TabIndex = 1;
            this.pictureBoxStartMini.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.trackBar1);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 67);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Апертура";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "2";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 19);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(242, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 2;
            this.trackBar1.ValueChanged += new System.EventHandler(this.TrackBar1_ValueChanged);
            this.trackBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrackBar1_MouseUp);
            // 
            // tabPageSharpen
            // 
            this.tabPageSharpen.BackColor = System.Drawing.Color.Linen;
            this.tabPageSharpen.Controls.Add(this.groupBox11);
            this.tabPageSharpen.Controls.Add(this.groupBox10);
            this.tabPageSharpen.Controls.Add(this.groupBox9);
            this.tabPageSharpen.Controls.Add(this.groupBox8);
            this.tabPageSharpen.Location = new System.Drawing.Point(4, 4);
            this.tabPageSharpen.Name = "tabPageSharpen";
            this.tabPageSharpen.Size = new System.Drawing.Size(1388, 547);
            this.tabPageSharpen.TabIndex = 2;
            this.tabPageSharpen.Text = "Повышение резкости";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label3);
            this.groupBox11.Controls.Add(this.trackBar3);
            this.groupBox11.Location = new System.Drawing.Point(6, 76);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(268, 67);
            this.groupBox11.TabIndex = 6;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Коэффициент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "1";
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(6, 19);
            this.trackBar3.Maximum = 100;
            this.trackBar3.Minimum = 1;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(242, 45);
            this.trackBar3.TabIndex = 0;
            this.trackBar3.Value = 10;
            this.trackBar3.ValueChanged += new System.EventHandler(this.TrackBar3_ValueChanged);
            this.trackBar3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrackBar3_MouseUp);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label2);
            this.groupBox10.Controls.Add(this.trackBar2);
            this.groupBox10.Location = new System.Drawing.Point(6, 6);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(268, 67);
            this.groupBox10.TabIndex = 5;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Апертура";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "1";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(6, 19);
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(242, 45);
            this.trackBar2.TabIndex = 0;
            this.trackBar2.Value = 1;
            this.trackBar2.ValueChanged += new System.EventHandler(this.TrackBar2_ValueChanged);
            this.trackBar2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrackBar2_MouseUp);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.pictureBoxStartSharp);
            this.groupBox9.Location = new System.Drawing.Point(280, 6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(548, 535);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Исходное изображение";
            // 
            // pictureBoxStartSharp
            // 
            this.pictureBoxStartSharp.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxStartSharp.Name = "pictureBoxStartSharp";
            this.pictureBoxStartSharp.Size = new System.Drawing.Size(536, 510);
            this.pictureBoxStartSharp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStartSharp.TabIndex = 2;
            this.pictureBoxStartSharp.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.pictureBoxSharp);
            this.groupBox8.Location = new System.Drawing.Point(834, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(548, 535);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Повышение резкости";
            // 
            // pictureBoxSharp
            // 
            this.pictureBoxSharp.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxSharp.Name = "pictureBoxSharp";
            this.pictureBoxSharp.Size = new System.Drawing.Size(535, 510);
            this.pictureBoxSharp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSharp.TabIndex = 3;
            this.pictureBoxSharp.TabStop = false;
            // 
            // tabPageEdges
            // 
            this.tabPageEdges.BackColor = System.Drawing.Color.Linen;
            this.tabPageEdges.Controls.Add(this.groupBoxEdges);
            this.tabPageEdges.Controls.Add(this.groupBoxStartEdges);
            this.tabPageEdges.Location = new System.Drawing.Point(4, 4);
            this.tabPageEdges.Name = "tabPageEdges";
            this.tabPageEdges.Size = new System.Drawing.Size(1388, 547);
            this.tabPageEdges.TabIndex = 3;
            this.tabPageEdges.Text = "Оконтуривание";
            // 
            // groupBoxEdges
            // 
            this.groupBoxEdges.Controls.Add(this.pictureBoxEdges);
            this.groupBoxEdges.Location = new System.Drawing.Point(837, 3);
            this.groupBoxEdges.Name = "groupBoxEdges";
            this.groupBoxEdges.Size = new System.Drawing.Size(548, 535);
            this.groupBoxEdges.TabIndex = 6;
            this.groupBoxEdges.TabStop = false;
            this.groupBoxEdges.Text = "Оконтуривание";
            // 
            // pictureBoxEdges
            // 
            this.pictureBoxEdges.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxEdges.Name = "pictureBoxEdges";
            this.pictureBoxEdges.Size = new System.Drawing.Size(535, 510);
            this.pictureBoxEdges.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEdges.TabIndex = 3;
            this.pictureBoxEdges.TabStop = false;
            // 
            // groupBoxStartEdges
            // 
            this.groupBoxStartEdges.Controls.Add(this.pictureBoxStartEdges);
            this.groupBoxStartEdges.Location = new System.Drawing.Point(283, 3);
            this.groupBoxStartEdges.Name = "groupBoxStartEdges";
            this.groupBoxStartEdges.Size = new System.Drawing.Size(548, 535);
            this.groupBoxStartEdges.TabIndex = 5;
            this.groupBoxStartEdges.TabStop = false;
            this.groupBoxStartEdges.Text = "Исходное изображение";
            // 
            // pictureBoxStartEdges
            // 
            this.pictureBoxStartEdges.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxStartEdges.Name = "pictureBoxStartEdges";
            this.pictureBoxStartEdges.Size = new System.Drawing.Size(536, 510);
            this.pictureBoxStartEdges.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStartEdges.TabIndex = 2;
            this.pictureBoxStartEdges.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.progressBar1.Location = new System.Drawing.Point(1093, 1);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(299, 20);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Visible = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1418, 24);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1418, 581);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1434, 620);
            this.MinimumSize = new System.Drawing.Size(1434, 620);
            this.Name = "MainForm";
            this.Text = "Лабораторная работа 6";
            this.tabControl.ResumeLayout(false);
            this.tabPageNoise.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoise)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).EndInit();
            this.tabPageNoNoise.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGauss)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMedian)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoiseMini)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartMini)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tabPageSharpen.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartSharp)).EndInit();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSharp)).EndInit();
            this.tabPageEdges.ResumeLayout(false);
            this.groupBoxEdges.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdges)).EndInit();
            this.groupBoxStartEdges.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartEdges)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
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
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageSharpen;
        private System.Windows.Forms.TabPage tabPageEdges;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.PictureBox pictureBoxStartSharp;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.PictureBox pictureBoxSharp;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.GroupBox groupBoxEdges;
        private System.Windows.Forms.PictureBox pictureBoxEdges;
        private System.Windows.Forms.GroupBox groupBoxStartEdges;
        private System.Windows.Forms.PictureBox pictureBoxStartEdges;
    }
}

