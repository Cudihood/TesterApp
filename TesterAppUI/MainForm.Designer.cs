
namespace TesterAppUI
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SettingnСonnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.StatusBox = new System.Windows.Forms.TextBox();
            this.ParametrsGroupBox = new System.Windows.Forms.GroupBox();
            this.PowerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.VoltageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CurrentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.WriteRegisterButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.PowerOutputTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.CurrentOutputTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.VoltageOutputTextBox = new System.Windows.Forms.TextBox();
            this.VoltageEntranceTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.FrequencyVoltageTextBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.DisableButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LaunchButton = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.ParametrsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PowerNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoltageNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingnСonnectionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(750, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SettingnСonnectionToolStripMenuItem
            // 
            this.SettingnСonnectionToolStripMenuItem.Name = "SettingnСonnectionToolStripMenuItem";
            this.SettingnСonnectionToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.SettingnСonnectionToolStripMenuItem.Text = "Настройки подключения";
            this.SettingnСonnectionToolStripMenuItem.Click += new System.EventHandler(this.SettingСonnectionToolStripMenuItem_Click);
            // 
            // StartButton
            // 
            this.StartButton.Enabled = false;
            this.StartButton.Location = new System.Drawing.Point(5, 18);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(96, 42);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Пуск";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(107, 18);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(96, 42);
            this.StopButton.TabIndex = 3;
            this.StopButton.Text = "Стоп";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StatusBox
            // 
            this.StatusBox.Location = new System.Drawing.Point(4, 16);
            this.StatusBox.Multiline = true;
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.ReadOnly = true;
            this.StatusBox.Size = new System.Drawing.Size(197, 73);
            this.StatusBox.TabIndex = 5;
            // 
            // ParametrsGroupBox
            // 
            this.ParametrsGroupBox.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ParametrsGroupBox.Controls.Add(this.PowerNumericUpDown);
            this.ParametrsGroupBox.Controls.Add(this.VoltageNumericUpDown);
            this.ParametrsGroupBox.Controls.Add(this.CurrentNumericUpDown);
            this.ParametrsGroupBox.Controls.Add(this.WriteRegisterButton);
            this.ParametrsGroupBox.Controls.Add(this.label6);
            this.ParametrsGroupBox.Controls.Add(this.label5);
            this.ParametrsGroupBox.Controls.Add(this.label1);
            this.ParametrsGroupBox.Controls.Add(this.label4);
            this.ParametrsGroupBox.Controls.Add(this.label3);
            this.ParametrsGroupBox.Controls.Add(this.label2);
            this.ParametrsGroupBox.Enabled = false;
            this.ParametrsGroupBox.Location = new System.Drawing.Point(438, 181);
            this.ParametrsGroupBox.Name = "ParametrsGroupBox";
            this.ParametrsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.ParametrsGroupBox.Size = new System.Drawing.Size(300, 134);
            this.ParametrsGroupBox.TabIndex = 7;
            this.ParametrsGroupBox.TabStop = false;
            this.ParametrsGroupBox.Text = "Управление параметрами работы ПЧ:";
            // 
            // PowerNumericUpDown
            // 
            this.PowerNumericUpDown.Location = new System.Drawing.Point(200, 70);
            this.PowerNumericUpDown.Name = "PowerNumericUpDown";
            this.PowerNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.PowerNumericUpDown.TabIndex = 39;
            this.PowerNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PowerNumericUpDown.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PowerNumericUpDown_MouseClick);
            // 
            // VoltageNumericUpDown
            // 
            this.VoltageNumericUpDown.Location = new System.Drawing.Point(200, 44);
            this.VoltageNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.VoltageNumericUpDown.Name = "VoltageNumericUpDown";
            this.VoltageNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.VoltageNumericUpDown.TabIndex = 38;
            this.VoltageNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.VoltageNumericUpDown.MouseClick += new System.Windows.Forms.MouseEventHandler(this.VoltageNumericUpDown_MouseClick);
            // 
            // CurrentNumericUpDown
            // 
            this.CurrentNumericUpDown.Location = new System.Drawing.Point(200, 18);
            this.CurrentNumericUpDown.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.CurrentNumericUpDown.Name = "CurrentNumericUpDown";
            this.CurrentNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.CurrentNumericUpDown.TabIndex = 37;
            this.CurrentNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CurrentNumericUpDown.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CurrentNumericUpDown_MouseClick);
            // 
            // WriteRegisterButton
            // 
            this.WriteRegisterButton.Location = new System.Drawing.Point(5, 96);
            this.WriteRegisterButton.Name = "WriteRegisterButton";
            this.WriteRegisterButton.Size = new System.Drawing.Size(290, 33);
            this.WriteRegisterButton.TabIndex = 18;
            this.WriteRegisterButton.Text = "Применить";
            this.WriteRegisterButton.UseVisualStyleBackColor = true;
            this.WriteRegisterButton.Click += new System.EventHandler(this.WriteRegisterButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "кВт";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "В";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "А";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Мощность на выходе БИРН:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Напряжение стабилизации БИРН:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ток стабилизации БИРН:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox2.Controls.Add(this.StatusBox);
            this.groupBox2.Location = new System.Drawing.Point(209, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(206, 94);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Статус контроллера:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox3.Controls.Add(this.ResetButton);
            this.groupBox3.Controls.Add(this.StartButton);
            this.groupBox3.Controls.Add(this.StopButton);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(12, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(420, 117);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Управление контроллером:";
            // 
            // ResetButton
            // 
            this.ResetButton.Enabled = false;
            this.ResetButton.Location = new System.Drawing.Point(5, 66);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(197, 44);
            this.ResetButton.TabIndex = 4;
            this.ResetButton.Text = "Сброс аварии";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.MediumTurquoise;
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.PowerOutputTextBox);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.CurrentOutputTextBox);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.VoltageOutputTextBox);
            this.groupBox4.Controls.Add(this.VoltageEntranceTextBox);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.FrequencyVoltageTextBox);
            this.groupBox4.Location = new System.Drawing.Point(438, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(300, 148);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Параметры контроля ПЧ:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(259, 122);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "кВт";
            // 
            // PowerOutputTextBox
            // 
            this.PowerOutputTextBox.Location = new System.Drawing.Point(202, 119);
            this.PowerOutputTextBox.Name = "PowerOutputTextBox";
            this.PowerOutputTextBox.ReadOnly = true;
            this.PowerOutputTextBox.Size = new System.Drawing.Size(52, 20);
            this.PowerOutputTextBox.TabIndex = 22;
            this.PowerOutputTextBox.Text = "0";
            this.PowerOutputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 122);
            this.label16.Margin = new System.Windows.Forms.Padding(3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(151, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Мощность на выходе БИРН:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(259, 96);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "А";
            // 
            // CurrentOutputTextBox
            // 
            this.CurrentOutputTextBox.Location = new System.Drawing.Point(202, 93);
            this.CurrentOutputTextBox.Name = "CurrentOutputTextBox";
            this.CurrentOutputTextBox.ReadOnly = true;
            this.CurrentOutputTextBox.Size = new System.Drawing.Size(52, 20);
            this.CurrentOutputTextBox.TabIndex = 19;
            this.CurrentOutputTextBox.Text = "0";
            this.CurrentOutputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 96);
            this.label14.Margin = new System.Windows.Forms.Padding(3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Ток на выходе БИРН:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 70);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "В";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(259, 44);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "В";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(259, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "кГц";
            // 
            // VoltageOutputTextBox
            // 
            this.VoltageOutputTextBox.Location = new System.Drawing.Point(202, 67);
            this.VoltageOutputTextBox.Name = "VoltageOutputTextBox";
            this.VoltageOutputTextBox.ReadOnly = true;
            this.VoltageOutputTextBox.Size = new System.Drawing.Size(52, 20);
            this.VoltageOutputTextBox.TabIndex = 14;
            this.VoltageOutputTextBox.Text = "0";
            this.VoltageOutputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // VoltageEntranceTextBox
            // 
            this.VoltageEntranceTextBox.Location = new System.Drawing.Point(202, 41);
            this.VoltageEntranceTextBox.Name = "VoltageEntranceTextBox";
            this.VoltageEntranceTextBox.ReadOnly = true;
            this.VoltageEntranceTextBox.Size = new System.Drawing.Size(52, 20);
            this.VoltageEntranceTextBox.TabIndex = 13;
            this.VoltageEntranceTextBox.Text = "0";
            this.VoltageEntranceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 70);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Напряжение на выходе БИРН:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 44);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Напряжение на входе БИРН:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 18);
            this.label12.Margin = new System.Windows.Forms.Padding(3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(191, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Частота напряжения на выходе ПЧ:";
            // 
            // FrequencyVoltageTextBox
            // 
            this.FrequencyVoltageTextBox.Location = new System.Drawing.Point(202, 15);
            this.FrequencyVoltageTextBox.Name = "FrequencyVoltageTextBox";
            this.FrequencyVoltageTextBox.ReadOnly = true;
            this.FrequencyVoltageTextBox.Size = new System.Drawing.Size(52, 20);
            this.FrequencyVoltageTextBox.TabIndex = 9;
            this.FrequencyVoltageTextBox.Text = "0";
            this.FrequencyVoltageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Plum;
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.textBox10);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.textBox11);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.textBox12);
            this.groupBox5.Controls.Add(this.textBox13);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.textBox14);
            this.groupBox5.Location = new System.Drawing.Point(14, 210);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(418, 146);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Параметры уставок работы ПЧ:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(386, 123);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "кГц";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(331, 120);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(52, 20);
            this.textBox10.TabIndex = 22;
            this.textBox10.Text = "0";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 123);
            this.label18.Margin = new System.Windows.Forms.Padding(3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(197, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "Минимальная частота на выходе ПЧ:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(386, 97);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(25, 13);
            this.label19.TabIndex = 20;
            this.label19.Text = "кГц";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(331, 94);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(52, 20);
            this.textBox11.TabIndex = 19;
            this.textBox11.Text = "0";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(5, 97);
            this.label20.Margin = new System.Windows.Forms.Padding(3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(203, 13);
            this.label20.TabIndex = 18;
            this.label20.Text = "Максимальная частота на выходе ПЧ:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(386, 72);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(14, 13);
            this.label21.TabIndex = 17;
            this.label21.Text = "А";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(386, 45);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(14, 13);
            this.label22.TabIndex = 16;
            this.label22.Text = "В";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(386, 21);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(14, 13);
            this.label23.TabIndex = 15;
            this.label23.Text = "В";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(331, 67);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(52, 20);
            this.textBox12.TabIndex = 14;
            this.textBox12.Text = "0";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(331, 42);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(52, 20);
            this.textBox13.TabIndex = 13;
            this.textBox13.Text = "0";
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(5, 19);
            this.label26.Margin = new System.Windows.Forms.Padding(3);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(320, 13);
            this.label26.TabIndex = 10;
            this.label26.Text = "Максимальное допустимое выпрямленное напряжение сети:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(4, 70);
            this.label24.Margin = new System.Windows.Forms.Padding(3);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(328, 13);
            this.label24.TabIndex = 12;
            this.label24.Text = "Максимальный ток понижающего стабилизатора напряжения:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(5, 45);
            this.label25.Margin = new System.Windows.Forms.Padding(3);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(314, 13);
            this.label25.TabIndex = 11;
            this.label25.Text = "Минимальное допустимое выпрямленное напряжение сети:";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(331, 16);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(52, 20);
            this.textBox14.TabIndex = 9;
            this.textBox14.Text = "0";
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(12, 27);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(207, 54);
            this.ConnectButton.TabIndex = 20;
            this.ConnectButton.Text = "Подкючится";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // DisableButton
            // 
            this.DisableButton.Enabled = false;
            this.DisableButton.Location = new System.Drawing.Point(225, 27);
            this.DisableButton.Name = "DisableButton";
            this.DisableButton.Size = new System.Drawing.Size(207, 54);
            this.DisableButton.TabIndex = 21;
            this.DisableButton.Text = "Отключиться";
            this.DisableButton.UseVisualStyleBackColor = true;
            this.DisableButton.Click += new System.EventHandler(this.DisableButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LaunchButton
            // 
            this.LaunchButton.Enabled = false;
            this.LaunchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LaunchButton.Location = new System.Drawing.Point(438, 321);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(300, 35);
            this.LaunchButton.TabIndex = 21;
            this.LaunchButton.Text = "ЗАПУК ИСПЫТАНИЯ";
            this.LaunchButton.UseVisualStyleBackColor = true;
            this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(750, 369);
            this.Controls.Add(this.DisableButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.LaunchButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ParametrsGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(766, 408);
            this.MinimumSize = new System.Drawing.Size(766, 408);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JobForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ParametrsGroupBox.ResumeLayout(false);
            this.ParametrsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PowerNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoltageNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentNumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SettingnСonnectionToolStripMenuItem;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.TextBox StatusBox;
        private System.Windows.Forms.GroupBox ParametrsGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox PowerOutputTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox CurrentOutputTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox VoltageOutputTextBox;
        private System.Windows.Forms.TextBox VoltageEntranceTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox FrequencyVoltageTextBox;
        private System.Windows.Forms.Button WriteRegisterButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button DisableButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button LaunchButton;
        private System.Windows.Forms.NumericUpDown VoltageNumericUpDown;
        public System.Windows.Forms.NumericUpDown CurrentNumericUpDown;
        public System.Windows.Forms.NumericUpDown PowerNumericUpDown;
        private System.Windows.Forms.Timer timer2;
    }
}