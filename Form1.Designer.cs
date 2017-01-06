namespace DynamicScheduler
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
            this.components = new System.ComponentModel.Container();
            this.buttonGo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.textBoxP0 = new System.Windows.Forms.TextBox();
            this.labelP0 = new System.Windows.Forms.Label();
            this.labelP1 = new System.Windows.Forms.Label();
            this.labelP2 = new System.Windows.Forms.Label();
            this.labelP3 = new System.Windows.Forms.Label();
            this.labelP4 = new System.Windows.Forms.Label();
            this.textBoxP1 = new System.Windows.Forms.TextBox();
            this.textBoxP2 = new System.Windows.Forms.TextBox();
            this.textBoxP3 = new System.Windows.Forms.TextBox();
            this.textBoxP4 = new System.Windows.Forms.TextBox();
            this.textBoxR0 = new System.Windows.Forms.TextBox();
            this.labelR0 = new System.Windows.Forms.Label();
            this.labelR1 = new System.Windows.Forms.Label();
            this.labelR2 = new System.Windows.Forms.Label();
            this.labelR3 = new System.Windows.Forms.Label();
            this.labelR4 = new System.Windows.Forms.Label();
            this.textBoxR1 = new System.Windows.Forms.TextBox();
            this.textBoxR2 = new System.Windows.Forms.TextBox();
            this.textBoxR3 = new System.Windows.Forms.TextBox();
            this.textBoxR4 = new System.Windows.Forms.TextBox();
            this.labelPL0 = new System.Windows.Forms.Label();
            this.labelPL1 = new System.Windows.Forms.Label();
            this.labelPL2 = new System.Windows.Forms.Label();
            this.labelPL3 = new System.Windows.Forms.Label();
            this.labelPL4 = new System.Windows.Forms.Label();
            this.textBoxPL0 = new System.Windows.Forms.TextBox();
            this.textBoxPL1 = new System.Windows.Forms.TextBox();
            this.textBoxPL2 = new System.Windows.Forms.TextBox();
            this.textBoxPL3 = new System.Windows.Forms.TextBox();
            this.textBoxPL4 = new System.Windows.Forms.TextBox();
            this.labelNumTasks = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.labelUtil = new System.Windows.Forms.Label();
            this.labelLCM = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.timelinePanel = new System.Windows.Forms.Panel();
            this.numTaskBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(1554, 1015);
            this.buttonGo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(150, 44);
            this.buttonGo.TabIndex = 0;
            this.buttonGo.Text = "Go!";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(2008, 44);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(92, 36);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(24, 827);
            this.outputBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(440, 241);
            this.outputBox.TabIndex = 4;
            this.outputBox.Text = "";
            this.outputBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // textBoxP0
            // 
            this.textBoxP0.Location = new System.Drawing.Point(626, 821);
            this.textBoxP0.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxP0.Name = "textBoxP0";
            this.textBoxP0.Size = new System.Drawing.Size(96, 31);
            this.textBoxP0.TabIndex = 5;
            this.textBoxP0.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelP0
            // 
            this.labelP0.AutoSize = true;
            this.labelP0.Location = new System.Drawing.Point(508, 827);
            this.labelP0.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelP0.Name = "labelP0";
            this.labelP0.Size = new System.Drawing.Size(105, 25);
            this.labelP0.TabIndex = 6;
            this.labelP0.Text = "T0 Period";
            // 
            // labelP1
            // 
            this.labelP1.AutoSize = true;
            this.labelP1.Location = new System.Drawing.Point(508, 879);
            this.labelP1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelP1.Name = "labelP1";
            this.labelP1.Size = new System.Drawing.Size(105, 25);
            this.labelP1.TabIndex = 7;
            this.labelP1.Text = "T1 Period";
            // 
            // labelP2
            // 
            this.labelP2.AutoSize = true;
            this.labelP2.Location = new System.Drawing.Point(508, 931);
            this.labelP2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelP2.Name = "labelP2";
            this.labelP2.Size = new System.Drawing.Size(105, 25);
            this.labelP2.TabIndex = 8;
            this.labelP2.Text = "T2 Period";
            // 
            // labelP3
            // 
            this.labelP3.AutoSize = true;
            this.labelP3.Location = new System.Drawing.Point(508, 983);
            this.labelP3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelP3.Name = "labelP3";
            this.labelP3.Size = new System.Drawing.Size(105, 25);
            this.labelP3.TabIndex = 9;
            this.labelP3.Text = "T3 Period";
            // 
            // labelP4
            // 
            this.labelP4.AutoSize = true;
            this.labelP4.Location = new System.Drawing.Point(508, 1035);
            this.labelP4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelP4.Name = "labelP4";
            this.labelP4.Size = new System.Drawing.Size(105, 25);
            this.labelP4.TabIndex = 10;
            this.labelP4.Text = "T4 Period";
            // 
            // textBoxP1
            // 
            this.textBoxP1.Location = new System.Drawing.Point(626, 873);
            this.textBoxP1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxP1.Name = "textBoxP1";
            this.textBoxP1.Size = new System.Drawing.Size(96, 31);
            this.textBoxP1.TabIndex = 11;
            // 
            // textBoxP2
            // 
            this.textBoxP2.Location = new System.Drawing.Point(626, 925);
            this.textBoxP2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxP2.Name = "textBoxP2";
            this.textBoxP2.Size = new System.Drawing.Size(96, 31);
            this.textBoxP2.TabIndex = 12;
            // 
            // textBoxP3
            // 
            this.textBoxP3.Location = new System.Drawing.Point(626, 977);
            this.textBoxP3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxP3.Name = "textBoxP3";
            this.textBoxP3.Size = new System.Drawing.Size(96, 31);
            this.textBoxP3.TabIndex = 13;
            // 
            // textBoxP4
            // 
            this.textBoxP4.Location = new System.Drawing.Point(626, 1029);
            this.textBoxP4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxP4.Name = "textBoxP4";
            this.textBoxP4.Size = new System.Drawing.Size(96, 31);
            this.textBoxP4.TabIndex = 14;
            // 
            // textBoxR0
            // 
            this.textBoxR0.Location = new System.Drawing.Point(884, 821);
            this.textBoxR0.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxR0.Name = "textBoxR0";
            this.textBoxR0.Size = new System.Drawing.Size(96, 31);
            this.textBoxR0.TabIndex = 15;
            // 
            // labelR0
            // 
            this.labelR0.AutoSize = true;
            this.labelR0.Location = new System.Drawing.Point(748, 827);
            this.labelR0.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelR0.Name = "labelR0";
            this.labelR0.Size = new System.Drawing.Size(122, 25);
            this.labelR0.TabIndex = 16;
            this.labelR0.Text = "T0 Runtime";
            // 
            // labelR1
            // 
            this.labelR1.AutoSize = true;
            this.labelR1.Location = new System.Drawing.Point(748, 879);
            this.labelR1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelR1.Name = "labelR1";
            this.labelR1.Size = new System.Drawing.Size(122, 25);
            this.labelR1.TabIndex = 17;
            this.labelR1.Text = "T1 Runtime";
            // 
            // labelR2
            // 
            this.labelR2.AutoSize = true;
            this.labelR2.Location = new System.Drawing.Point(746, 931);
            this.labelR2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelR2.Name = "labelR2";
            this.labelR2.Size = new System.Drawing.Size(122, 25);
            this.labelR2.TabIndex = 18;
            this.labelR2.Text = "T2 Runtime";
            // 
            // labelR3
            // 
            this.labelR3.AutoSize = true;
            this.labelR3.Location = new System.Drawing.Point(746, 983);
            this.labelR3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelR3.Name = "labelR3";
            this.labelR3.Size = new System.Drawing.Size(122, 25);
            this.labelR3.TabIndex = 19;
            this.labelR3.Text = "T3 Runtime";
            // 
            // labelR4
            // 
            this.labelR4.AutoSize = true;
            this.labelR4.Location = new System.Drawing.Point(746, 1035);
            this.labelR4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelR4.Name = "labelR4";
            this.labelR4.Size = new System.Drawing.Size(122, 25);
            this.labelR4.TabIndex = 20;
            this.labelR4.Text = "T4 Runtime";
            // 
            // textBoxR1
            // 
            this.textBoxR1.Location = new System.Drawing.Point(884, 873);
            this.textBoxR1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxR1.Name = "textBoxR1";
            this.textBoxR1.Size = new System.Drawing.Size(96, 31);
            this.textBoxR1.TabIndex = 21;
            // 
            // textBoxR2
            // 
            this.textBoxR2.Location = new System.Drawing.Point(884, 925);
            this.textBoxR2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxR2.Name = "textBoxR2";
            this.textBoxR2.Size = new System.Drawing.Size(96, 31);
            this.textBoxR2.TabIndex = 22;
            // 
            // textBoxR3
            // 
            this.textBoxR3.Location = new System.Drawing.Point(884, 977);
            this.textBoxR3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxR3.Name = "textBoxR3";
            this.textBoxR3.Size = new System.Drawing.Size(96, 31);
            this.textBoxR3.TabIndex = 23;
            // 
            // textBoxR4
            // 
            this.textBoxR4.Location = new System.Drawing.Point(884, 1031);
            this.textBoxR4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxR4.Name = "textBoxR4";
            this.textBoxR4.Size = new System.Drawing.Size(96, 31);
            this.textBoxR4.TabIndex = 24;
            // 
            // labelPL0
            // 
            this.labelPL0.AutoSize = true;
            this.labelPL0.Location = new System.Drawing.Point(996, 827);
            this.labelPL0.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPL0.Name = "labelPL0";
            this.labelPL0.Size = new System.Drawing.Size(69, 25);
            this.labelPL0.TabIndex = 25;
            this.labelPL0.Text = "T0 PL";
            // 
            // labelPL1
            // 
            this.labelPL1.AutoSize = true;
            this.labelPL1.Location = new System.Drawing.Point(996, 879);
            this.labelPL1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPL1.Name = "labelPL1";
            this.labelPL1.Size = new System.Drawing.Size(69, 25);
            this.labelPL1.TabIndex = 26;
            this.labelPL1.Text = "T1 PL";
            // 
            // labelPL2
            // 
            this.labelPL2.AutoSize = true;
            this.labelPL2.Location = new System.Drawing.Point(996, 931);
            this.labelPL2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPL2.Name = "labelPL2";
            this.labelPL2.Size = new System.Drawing.Size(69, 25);
            this.labelPL2.TabIndex = 27;
            this.labelPL2.Text = "T2 PL";
            // 
            // labelPL3
            // 
            this.labelPL3.AutoSize = true;
            this.labelPL3.Location = new System.Drawing.Point(996, 983);
            this.labelPL3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPL3.Name = "labelPL3";
            this.labelPL3.Size = new System.Drawing.Size(69, 25);
            this.labelPL3.TabIndex = 28;
            this.labelPL3.Text = "T3 PL";
            // 
            // labelPL4
            // 
            this.labelPL4.AutoSize = true;
            this.labelPL4.Location = new System.Drawing.Point(996, 1035);
            this.labelPL4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPL4.Name = "labelPL4";
            this.labelPL4.Size = new System.Drawing.Size(69, 25);
            this.labelPL4.TabIndex = 29;
            this.labelPL4.Text = "T4 PL";
            // 
            // textBoxPL0
            // 
            this.textBoxPL0.Location = new System.Drawing.Point(1070, 821);
            this.textBoxPL0.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxPL0.Name = "textBoxPL0";
            this.textBoxPL0.ReadOnly = true;
            this.textBoxPL0.Size = new System.Drawing.Size(96, 31);
            this.textBoxPL0.TabIndex = 30;
            // 
            // textBoxPL1
            // 
            this.textBoxPL1.Location = new System.Drawing.Point(1070, 871);
            this.textBoxPL1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxPL1.Name = "textBoxPL1";
            this.textBoxPL1.ReadOnly = true;
            this.textBoxPL1.Size = new System.Drawing.Size(96, 31);
            this.textBoxPL1.TabIndex = 31;
            // 
            // textBoxPL2
            // 
            this.textBoxPL2.Location = new System.Drawing.Point(1070, 925);
            this.textBoxPL2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxPL2.Name = "textBoxPL2";
            this.textBoxPL2.ReadOnly = true;
            this.textBoxPL2.Size = new System.Drawing.Size(96, 31);
            this.textBoxPL2.TabIndex = 32;
            // 
            // textBoxPL3
            // 
            this.textBoxPL3.Location = new System.Drawing.Point(1070, 977);
            this.textBoxPL3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxPL3.Name = "textBoxPL3";
            this.textBoxPL3.ReadOnly = true;
            this.textBoxPL3.Size = new System.Drawing.Size(96, 31);
            this.textBoxPL3.TabIndex = 33;
            // 
            // textBoxPL4
            // 
            this.textBoxPL4.Location = new System.Drawing.Point(1070, 1029);
            this.textBoxPL4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxPL4.Name = "textBoxPL4";
            this.textBoxPL4.ReadOnly = true;
            this.textBoxPL4.Size = new System.Drawing.Size(96, 31);
            this.textBoxPL4.TabIndex = 34;
            // 
            // labelNumTasks
            // 
            this.labelNumTasks.AutoSize = true;
            this.labelNumTasks.Location = new System.Drawing.Point(124, 527);
            this.labelNumTasks.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNumTasks.Name = "labelNumTasks";
            this.labelNumTasks.Size = new System.Drawing.Size(188, 25);
            this.labelNumTasks.TabIndex = 46;
            this.labelNumTasks.Text = "How many Tasks?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(452, 527);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(238, 192);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Algorithm Selection";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(12, 98);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(101, 29);
            this.radioButton3.TabIndex = 50;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Mixed";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 67);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 29);
            this.radioButton2.TabIndex = 49;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "EDF";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 37);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 29);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "RMS";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // labelUtil
            // 
            this.labelUtil.AutoSize = true;
            this.labelUtil.Location = new System.Drawing.Point(12, 71);
            this.labelUtil.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelUtil.Name = "labelUtil";
            this.labelUtil.Size = new System.Drawing.Size(0, 25);
            this.labelUtil.TabIndex = 54;
            // 
            // labelLCM
            // 
            this.labelLCM.AutoSize = true;
            this.labelLCM.Location = new System.Drawing.Point(12, 37);
            this.labelLCM.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelLCM.Name = "labelLCM";
            this.labelLCM.Size = new System.Drawing.Size(0, 25);
            this.labelLCM.TabIndex = 55;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelLCM);
            this.groupBox2.Controls.Add(this.labelUtil);
            this.groupBox2.Location = new System.Drawing.Point(702, 527);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(1164, 192);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Analytics";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(1716, 1015);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(150, 44);
            this.buttonReset.TabIndex = 57;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.button2_Click);
            // 
            // timelinePanel
            // 
            this.timelinePanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.timelinePanel.Location = new System.Drawing.Point(26, 54);
            this.timelinePanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.timelinePanel.Name = "timelinePanel";
            this.timelinePanel.Size = new System.Drawing.Size(1958, 462);
            this.timelinePanel.TabIndex = 58;
            this.timelinePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.timelinePanel_Paint);
            // 
            // numTaskBox
            // 
            this.numTaskBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numTaskBox.FormattingEnabled = true;
            this.numTaskBox.Location = new System.Drawing.Point(130, 567);
            this.numTaskBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numTaskBox.MaxDropDownItems = 5;
            this.numTaskBox.Name = "numTaskBox";
            this.numTaskBox.Size = new System.Drawing.Size(180, 33);
            this.numTaskBox.TabIndex = 59;
            this.numTaskBox.SelectedIndexChanged += new System.EventHandler(this.numTaskBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2008, 1094);
            this.Controls.Add(this.numTaskBox);
            this.Controls.Add(this.timelinePanel);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelNumTasks);
            this.Controls.Add(this.textBoxPL4);
            this.Controls.Add(this.textBoxPL3);
            this.Controls.Add(this.textBoxPL2);
            this.Controls.Add(this.textBoxPL1);
            this.Controls.Add(this.textBoxPL0);
            this.Controls.Add(this.labelPL4);
            this.Controls.Add(this.labelPL3);
            this.Controls.Add(this.labelPL2);
            this.Controls.Add(this.labelPL1);
            this.Controls.Add(this.labelPL0);
            this.Controls.Add(this.textBoxR4);
            this.Controls.Add(this.textBoxR3);
            this.Controls.Add(this.textBoxR2);
            this.Controls.Add(this.textBoxR1);
            this.Controls.Add(this.labelR4);
            this.Controls.Add(this.labelR3);
            this.Controls.Add(this.labelR2);
            this.Controls.Add(this.labelR1);
            this.Controls.Add(this.labelR0);
            this.Controls.Add(this.textBoxR0);
            this.Controls.Add(this.textBoxP4);
            this.Controls.Add(this.textBoxP3);
            this.Controls.Add(this.textBoxP2);
            this.Controls.Add(this.textBoxP1);
            this.Controls.Add(this.labelP4);
            this.Controls.Add(this.labelP3);
            this.Controls.Add(this.labelP2);
            this.Controls.Add(this.labelP1);
            this.Controls.Add(this.labelP0);
            this.Controls.Add(this.textBoxP0);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Task Scheduler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.TextBox textBoxP0;
        private System.Windows.Forms.Label labelP0;
        private System.Windows.Forms.Label labelP1;
        private System.Windows.Forms.Label labelP2;
        private System.Windows.Forms.Label labelP3;
        private System.Windows.Forms.Label labelP4;
        private System.Windows.Forms.TextBox textBoxP1;
        private System.Windows.Forms.TextBox textBoxP2;
        private System.Windows.Forms.TextBox textBoxP3;
        private System.Windows.Forms.TextBox textBoxP4;
        private System.Windows.Forms.TextBox textBoxR0;
        private System.Windows.Forms.Label labelR0;
        private System.Windows.Forms.Label labelR1;
        private System.Windows.Forms.Label labelR2;
        private System.Windows.Forms.Label labelR3;
        private System.Windows.Forms.Label labelR4;
        private System.Windows.Forms.TextBox textBoxR1;
        private System.Windows.Forms.TextBox textBoxR2;
        private System.Windows.Forms.TextBox textBoxR3;
        private System.Windows.Forms.TextBox textBoxR4;
        private System.Windows.Forms.Label labelPL0;
        private System.Windows.Forms.Label labelPL1;
        private System.Windows.Forms.Label labelPL2;
        private System.Windows.Forms.Label labelPL3;
        private System.Windows.Forms.Label labelPL4;
        private System.Windows.Forms.TextBox textBoxPL0;
        private System.Windows.Forms.TextBox textBoxPL1;
        private System.Windows.Forms.TextBox textBoxPL2;
        private System.Windows.Forms.TextBox textBoxPL3;
        private System.Windows.Forms.TextBox textBoxPL4;
        private System.Windows.Forms.Label labelNumTasks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label labelUtil;
        private System.Windows.Forms.Label labelLCM;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Panel timelinePanel;
        private System.Windows.Forms.ComboBox numTaskBox;
    }
}

