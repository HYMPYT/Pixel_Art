namespace PixelArt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClearFieldBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioBtn16 = new System.Windows.Forms.RadioButton();
            this.radioBtn32 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HorizontalBn = new System.Windows.Forms.Button();
            this.VerticalBtn = new System.Windows.Forms.Button();
            this.EraseBtn = new System.Windows.Forms.Button();
            this.ColorFillBtn = new System.Windows.Forms.Button();
            this.PipetteBtn = new System.Windows.Forms.Button();
            this.PencilBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ColorMixerBtn = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RightColorBtn = new System.Windows.Forms.Button();
            this.LeftColorBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Field = new System.Windows.Forms.Panel();
            this.BlackAndWhiteBtn = new System.Windows.Forms.Button();
            this.RotateLeftBtn = new System.Windows.Forms.Button();
            this.RotateRightBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ClearFieldBtn);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(733, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 718);
            this.panel1.TabIndex = 0;
            // 
            // ClearFieldBtn
            // 
            this.ClearFieldBtn.Location = new System.Drawing.Point(22, 633);
            this.ClearFieldBtn.Name = "ClearFieldBtn";
            this.ClearFieldBtn.Size = new System.Drawing.Size(318, 46);
            this.ClearFieldBtn.TabIndex = 3;
            this.ClearFieldBtn.Text = "Очистить поле";
            this.toolTip1.SetToolTip(this.ClearFieldBtn, "Данная кнопка очистит поле");
            this.ClearFieldBtn.UseVisualStyleBackColor = true;
            this.ClearFieldBtn.Click += new System.EventHandler(this.ClearFieldBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioBtn16);
            this.groupBox3.Controls.Add(this.radioBtn32);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 379);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(363, 83);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Выбор поля";
            // 
            // radioBtn16
            // 
            this.radioBtn16.AutoSize = true;
            this.radioBtn16.Checked = true;
            this.radioBtn16.Location = new System.Drawing.Point(22, 37);
            this.radioBtn16.Name = "radioBtn16";
            this.radioBtn16.Size = new System.Drawing.Size(88, 24);
            this.radioBtn16.TabIndex = 1;
            this.radioBtn16.TabStop = true;
            this.radioBtn16.Text = "16 Х 16";
            this.toolTip1.SetToolTip(this.radioBtn16, "Поле 16 Х 16 пикселей");
            this.radioBtn16.UseVisualStyleBackColor = true;
            // 
            // radioBtn32
            // 
            this.radioBtn32.AutoSize = true;
            this.radioBtn32.Location = new System.Drawing.Point(166, 37);
            this.radioBtn32.Name = "radioBtn32";
            this.radioBtn32.Size = new System.Drawing.Size(88, 24);
            this.radioBtn32.TabIndex = 0;
            this.radioBtn32.Text = "32 Х 32";
            this.toolTip1.SetToolTip(this.radioBtn32, "Поле 32 Х 32 пикселей");
            this.radioBtn32.UseVisualStyleBackColor = true;
            this.radioBtn32.CheckedChanged += new System.EventHandler(this.radioBtn32_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RotateRightBtn);
            this.groupBox2.Controls.Add(this.RotateLeftBtn);
            this.groupBox2.Controls.Add(this.BlackAndWhiteBtn);
            this.groupBox2.Controls.Add(this.HorizontalBn);
            this.groupBox2.Controls.Add(this.VerticalBtn);
            this.groupBox2.Controls.Add(this.EraseBtn);
            this.groupBox2.Controls.Add(this.ColorFillBtn);
            this.groupBox2.Controls.Add(this.PipetteBtn);
            this.groupBox2.Controls.Add(this.PencilBtn);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 159);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Инструменты";
            // 
            // HorizontalBn
            // 
            this.HorizontalBn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HorizontalBn.BackgroundImage")));
            this.HorizontalBn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HorizontalBn.Location = new System.Drawing.Point(307, 26);
            this.HorizontalBn.Name = "HorizontalBn";
            this.HorizontalBn.Size = new System.Drawing.Size(50, 50);
            this.HorizontalBn.TabIndex = 5;
            this.toolTip1.SetToolTip(this.HorizontalBn, "Отразить по горизонтали");
            this.HorizontalBn.UseVisualStyleBackColor = true;
            this.HorizontalBn.Click += new System.EventHandler(this.HorizontalBn_Click);
            // 
            // VerticalBtn
            // 
            this.VerticalBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VerticalBtn.BackgroundImage")));
            this.VerticalBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.VerticalBtn.Location = new System.Drawing.Point(238, 26);
            this.VerticalBtn.Name = "VerticalBtn";
            this.VerticalBtn.Size = new System.Drawing.Size(50, 50);
            this.VerticalBtn.TabIndex = 4;
            this.toolTip1.SetToolTip(this.VerticalBtn, "Отразить по вертикали");
            this.VerticalBtn.UseVisualStyleBackColor = true;
            this.VerticalBtn.Click += new System.EventHandler(this.VerticalBtn_Click);
            // 
            // EraseBtn
            // 
            this.EraseBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EraseBtn.BackgroundImage")));
            this.EraseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EraseBtn.Location = new System.Drawing.Point(22, 93);
            this.EraseBtn.Name = "EraseBtn";
            this.EraseBtn.Size = new System.Drawing.Size(50, 50);
            this.EraseBtn.TabIndex = 3;
            this.toolTip1.SetToolTip(this.EraseBtn, "Ластик");
            this.EraseBtn.UseVisualStyleBackColor = true;
            this.EraseBtn.Click += new System.EventHandler(this.EraseBtn_Click);
            // 
            // ColorFillBtn
            // 
            this.ColorFillBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ColorFillBtn.BackgroundImage")));
            this.ColorFillBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ColorFillBtn.Location = new System.Drawing.Point(166, 26);
            this.ColorFillBtn.Name = "ColorFillBtn";
            this.ColorFillBtn.Size = new System.Drawing.Size(50, 50);
            this.ColorFillBtn.TabIndex = 2;
            this.toolTip1.SetToolTip(this.ColorFillBtn, "Заливка");
            this.ColorFillBtn.UseVisualStyleBackColor = true;
            this.ColorFillBtn.Click += new System.EventHandler(this.ColorFillBtn_Click);
            // 
            // PipetteBtn
            // 
            this.PipetteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PipetteBtn.BackgroundImage")));
            this.PipetteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PipetteBtn.Location = new System.Drawing.Point(94, 26);
            this.PipetteBtn.Name = "PipetteBtn";
            this.PipetteBtn.Size = new System.Drawing.Size(50, 50);
            this.PipetteBtn.TabIndex = 1;
            this.toolTip1.SetToolTip(this.PipetteBtn, "Палитра");
            this.PipetteBtn.UseVisualStyleBackColor = true;
            this.PipetteBtn.Click += new System.EventHandler(this.PipetteBtn_Click);
            // 
            // PencilBtn
            // 
            this.PencilBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PencilBtn.BackgroundImage")));
            this.PencilBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PencilBtn.Location = new System.Drawing.Point(22, 26);
            this.PencilBtn.Name = "PencilBtn";
            this.PencilBtn.Size = new System.Drawing.Size(50, 50);
            this.PencilBtn.TabIndex = 0;
            this.toolTip1.SetToolTip(this.PencilBtn, "Карандаш");
            this.PencilBtn.UseVisualStyleBackColor = true;
            this.PencilBtn.Click += new System.EventHandler(this.PencilBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ColorMixerBtn);
            this.groupBox1.Controls.Add(this.button27);
            this.groupBox1.Controls.Add(this.button26);
            this.groupBox1.Controls.Add(this.button25);
            this.groupBox1.Controls.Add(this.button24);
            this.groupBox1.Controls.Add(this.button23);
            this.groupBox1.Controls.Add(this.button22);
            this.groupBox1.Controls.Add(this.button21);
            this.groupBox1.Controls.Add(this.button20);
            this.groupBox1.Controls.Add(this.button19);
            this.groupBox1.Controls.Add(this.button18);
            this.groupBox1.Controls.Add(this.button17);
            this.groupBox1.Controls.Add(this.button16);
            this.groupBox1.Controls.Add(this.button15);
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Controls.Add(this.button13);
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.RightColorBtn);
            this.groupBox1.Controls.Add(this.LeftColorBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Цвета";
            // 
            // ColorMixerBtn
            // 
            this.ColorMixerBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ColorMixerBtn.BackgroundImage")));
            this.ColorMixerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ColorMixerBtn.Location = new System.Drawing.Point(290, 18);
            this.ColorMixerBtn.Name = "ColorMixerBtn";
            this.ColorMixerBtn.Size = new System.Drawing.Size(50, 50);
            this.ColorMixerBtn.TabIndex = 30;
            this.toolTip1.SetToolTip(this.ColorMixerBtn, "Нажмите для добавления нового цвета в палитру");
            this.ColorMixerBtn.UseVisualStyleBackColor = true;
            this.ColorMixerBtn.Click += new System.EventHandler(this.ColorMixerBtn_Click);
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.White;
            this.button27.Location = new System.Drawing.Point(310, 150);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(30, 30);
            this.button27.TabIndex = 29;
            this.button27.UseVisualStyleBackColor = false;
            this.button27.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaletteMouseClick);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.White;
            this.button26.Location = new System.Drawing.Point(274, 150);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(30, 30);
            this.button26.TabIndex = 28;
            this.button26.UseVisualStyleBackColor = false;
            this.button26.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaletteMouseClick);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.White;
            this.button25.Location = new System.Drawing.Point(238, 150);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(30, 30);
            this.button25.TabIndex = 27;
            this.button25.UseVisualStyleBackColor = false;
            this.button25.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaletteMouseClick);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.White;
            this.button24.Location = new System.Drawing.Point(202, 150);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(30, 30);
            this.button24.TabIndex = 26;
            this.button24.UseVisualStyleBackColor = false;
            this.button24.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaletteMouseClick);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.White;
            this.button23.Location = new System.Drawing.Point(166, 150);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(30, 30);
            this.button23.TabIndex = 25;
            this.button23.UseVisualStyleBackColor = false;
            this.button23.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaletteMouseClick);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.White;
            this.button22.Location = new System.Drawing.Point(130, 150);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(30, 30);
            this.button22.TabIndex = 24;
            this.button22.UseVisualStyleBackColor = false;
            this.button22.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaletteMouseClick);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.White;
            this.button21.Location = new System.Drawing.Point(94, 150);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(30, 30);
            this.button21.TabIndex = 23;
            this.button21.UseVisualStyleBackColor = false;
            this.button21.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaletteMouseClick);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.White;
            this.button20.Location = new System.Drawing.Point(58, 150);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(30, 30);
            this.button20.TabIndex = 22;
            this.button20.UseVisualStyleBackColor = false;
            this.button20.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaletteMouseClick);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.White;
            this.button19.Location = new System.Drawing.Point(22, 150);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(30, 30);
            this.button19.TabIndex = 21;
            this.button19.UseVisualStyleBackColor = false;
            this.button19.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaletteMouseClick);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.MediumPurple;
            this.button18.Location = new System.Drawing.Point(310, 114);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(30, 30);
            this.button18.TabIndex = 20;
            this.button18.UseVisualStyleBackColor = false;
            this.button18.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaletteMouseClick);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button17.Location = new System.Drawing.Point(274, 114);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(30, 30);
            this.button17.TabIndex = 19;
            this.button17.UseVisualStyleBackColor = false;
            this.button17.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaletteMouseClick);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.SkyBlue;
            this.button16.Location = new System.Drawing.Point(238, 114);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(30, 30);
            this.button16.TabIndex = 18;
            this.button16.UseVisualStyleBackColor = false;
            this.button16.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaletteMouseClick);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.GreenYellow;
            this.button15.Location = new System.Drawing.Point(202, 114);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(30, 30);
            this.button15.TabIndex = 17;
            this.button15.UseVisualStyleBackColor = false;
            this.button15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaletteMouseClick);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Khaki;
            this.button14.Location = new System.Drawing.Point(166, 114);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(30, 30);
            this.button14.TabIndex = 16;
            this.button14.UseVisualStyleBackColor = false;
            this.button14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaletteMouseClick);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Gold;
            this.button13.Location = new System.Drawing.Point(130, 114);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(30, 30);
            this.button13.TabIndex = 15;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaletteMouseClick);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Pink;
            this.button12.Location = new System.Drawing.Point(94, 114);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(30, 30);
            this.button12.TabIndex = 14;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaletteMouseClick);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Sienna;
            this.button11.Location = new System.Drawing.Point(58, 114);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(30, 30);
            this.button11.TabIndex = 13;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaletteMouseClick);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(22, 114);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(30, 30);
            this.button10.TabIndex = 12;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaletteMouseClick);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Purple;
            this.button9.Location = new System.Drawing.Point(310, 78);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(30, 30);
            this.button9.TabIndex = 11;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaletteMouseClick);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Blue;
            this.button8.Location = new System.Drawing.Point(274, 78);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(30, 30);
            this.button8.TabIndex = 10;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaletteMouseClick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DodgerBlue;
            this.button7.Location = new System.Drawing.Point(238, 78);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(30, 30);
            this.button7.TabIndex = 9;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaletteMouseClick);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button6.Location = new System.Drawing.Point(202, 78);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(30, 30);
            this.button6.TabIndex = 8;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaletteMouseClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Yellow;
            this.button5.Location = new System.Drawing.Point(166, 78);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 30);
            this.button5.TabIndex = 7;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaletteMouseClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Orange;
            this.button4.Location = new System.Drawing.Point(130, 78);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 30);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaletteMouseClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(94, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaletteMouseClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Location = new System.Drawing.Point(58, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaletteMouseClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(22, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaletteMouseClick);
            // 
            // RightColorBtn
            // 
            this.RightColorBtn.Location = new System.Drawing.Point(202, 28);
            this.RightColorBtn.Name = "RightColorBtn";
            this.RightColorBtn.Size = new System.Drawing.Size(30, 30);
            this.RightColorBtn.TabIndex = 2;
            this.toolTip1.SetToolTip(this.RightColorBtn, "Этот цвет используется для ластика и заливки");
            this.RightColorBtn.UseVisualStyleBackColor = true;
            // 
            // LeftColorBtn
            // 
            this.LeftColorBtn.Location = new System.Drawing.Point(166, 28);
            this.LeftColorBtn.Name = "LeftColorBtn";
            this.LeftColorBtn.Size = new System.Drawing.Size(30, 30);
            this.LeftColorBtn.TabIndex = 1;
            this.toolTip1.SetToolTip(this.LeftColorBtn, "Основной цвет");
            this.LeftColorBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текущие цвета:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1108, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.toolTip1.SetToolTip(this.menuStrip1, "Щелкните здесь чтобы создать, открыть или сохранить рисунок  ");
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(66, 27);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.создатьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("создатьToolStripMenuItem.Image")));
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.открытьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripMenuItem.Image")));
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.сохранитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripMenuItem.Image")));
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // Field
            // 
            this.Field.Dock = System.Windows.Forms.DockStyle.Left;
            this.Field.Location = new System.Drawing.Point(0, 31);
            this.Field.Name = "Field";
            this.Field.Size = new System.Drawing.Size(727, 718);
            this.Field.TabIndex = 2;
            // 
            // BlackAndWhiteBtn
            // 
            this.BlackAndWhiteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BlackAndWhiteBtn.BackgroundImage")));
            this.BlackAndWhiteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BlackAndWhiteBtn.Location = new System.Drawing.Point(94, 93);
            this.BlackAndWhiteBtn.Name = "BlackAndWhiteBtn";
            this.BlackAndWhiteBtn.Size = new System.Drawing.Size(50, 50);
            this.BlackAndWhiteBtn.TabIndex = 6;
            this.toolTip1.SetToolTip(this.BlackAndWhiteBtn, "Черно белое изображение");
            this.BlackAndWhiteBtn.UseVisualStyleBackColor = true;
            this.BlackAndWhiteBtn.Click += new System.EventHandler(this.BlackAndWhiteBtn_Click);
            // 
            // RotateLeftBtn
            // 
            this.RotateLeftBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RotateLeftBtn.BackgroundImage")));
            this.RotateLeftBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RotateLeftBtn.Location = new System.Drawing.Point(238, 93);
            this.RotateLeftBtn.Name = "RotateLeftBtn";
            this.RotateLeftBtn.Size = new System.Drawing.Size(50, 50);
            this.RotateLeftBtn.TabIndex = 7;
            this.toolTip1.SetToolTip(this.RotateLeftBtn, "Повернуть влево");
            this.RotateLeftBtn.UseVisualStyleBackColor = true;
            this.RotateLeftBtn.Click += new System.EventHandler(this.RotateLeftBtn_Click);
            // 
            // RotateRightBtn
            // 
            this.RotateRightBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RotateRightBtn.BackgroundImage")));
            this.RotateRightBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RotateRightBtn.Location = new System.Drawing.Point(307, 93);
            this.RotateRightBtn.Name = "RotateRightBtn";
            this.RotateRightBtn.Size = new System.Drawing.Size(50, 50);
            this.RotateRightBtn.TabIndex = 8;
            this.toolTip1.SetToolTip(this.RotateRightBtn, "Повернуть вправо");
            this.RotateRightBtn.UseVisualStyleBackColor = true;
            this.RotateRightBtn.Click += new System.EventHandler(this.RotateRightBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 749);
            this.Controls.Add(this.Field);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PixelArt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RightColorBtn;
        private System.Windows.Forms.Button LeftColorBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioBtn16;
        private System.Windows.Forms.RadioButton radioBtn32;
        private System.Windows.Forms.Button EraseBtn;
        private System.Windows.Forms.Button ColorFillBtn;
        private System.Windows.Forms.Button PipetteBtn;
        private System.Windows.Forms.Button PencilBtn;
        private System.Windows.Forms.Button ColorMixerBtn;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ClearFieldBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel Field;
        private System.Windows.Forms.Button HorizontalBn;
        private System.Windows.Forms.Button VerticalBtn;
        private System.Windows.Forms.Button BlackAndWhiteBtn;
        private System.Windows.Forms.Button RotateRightBtn;
        private System.Windows.Forms.Button RotateLeftBtn;
    }
}

