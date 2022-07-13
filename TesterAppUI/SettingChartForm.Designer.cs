
namespace TesterAppUI
{
    partial class SettingChartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingChartForm));
            this.OkButton = new System.Windows.Forms.Button();
            this.ChanclButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IntervalXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FrequencyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.VoltageEntranceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.VoltageOutputNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CurrentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PowerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MaxPowerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.MaxCurrentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.MaxVoltageOutputNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.MaxVoltageEntranceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.MaxFrequencyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.MaxThermometer2NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MaxThermometer1NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Thermometer2NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Thermometer1NumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrequencyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoltageEntranceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoltageOutputNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPowerNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxCurrentNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxVoltageOutputNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxVoltageEntranceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxFrequencyNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxThermometer2NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxThermometer1NumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Thermometer2NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Thermometer1NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(201, 220);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(135, 33);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "Применить";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // ChanclButton
            // 
            this.ChanclButton.Location = new System.Drawing.Point(342, 220);
            this.ChanclButton.Name = "ChanclButton";
            this.ChanclButton.Size = new System.Drawing.Size(135, 33);
            this.ChanclButton.TabIndex = 1;
            this.ChanclButton.Text = "Отмена";
            this.ChanclButton.UseVisualStyleBackColor = true;
            this.ChanclButton.Click += new System.EventHandler(this.ChanclButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Интервал на оси Х";
            // 
            // IntervalXNumericUpDown
            // 
            this.IntervalXNumericUpDown.Location = new System.Drawing.Point(120, 228);
            this.IntervalXNumericUpDown.Name = "IntervalXNumericUpDown";
            this.IntervalXNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.IntervalXNumericUpDown.TabIndex = 3;
            this.IntervalXNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrequencyNumericUpDown
            // 
            this.FrequencyNumericUpDown.Location = new System.Drawing.Point(138, 19);
            this.FrequencyNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.FrequencyNumericUpDown.Name = "FrequencyNumericUpDown";
            this.FrequencyNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.FrequencyNumericUpDown.TabIndex = 5;
            this.FrequencyNumericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // VoltageEntranceNumericUpDown
            // 
            this.VoltageEntranceNumericUpDown.Location = new System.Drawing.Point(138, 45);
            this.VoltageEntranceNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.VoltageEntranceNumericUpDown.Name = "VoltageEntranceNumericUpDown";
            this.VoltageEntranceNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.VoltageEntranceNumericUpDown.TabIndex = 7;
            this.VoltageEntranceNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // VoltageOutputNumericUpDown
            // 
            this.VoltageOutputNumericUpDown.Location = new System.Drawing.Point(138, 71);
            this.VoltageOutputNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.VoltageOutputNumericUpDown.Name = "VoltageOutputNumericUpDown";
            this.VoltageOutputNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.VoltageOutputNumericUpDown.TabIndex = 9;
            this.VoltageOutputNumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // CurrentNumericUpDown
            // 
            this.CurrentNumericUpDown.Location = new System.Drawing.Point(138, 97);
            this.CurrentNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.CurrentNumericUpDown.Name = "CurrentNumericUpDown";
            this.CurrentNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.CurrentNumericUpDown.TabIndex = 11;
            this.CurrentNumericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // PowerNumericUpDown
            // 
            this.PowerNumericUpDown.Location = new System.Drawing.Point(138, 123);
            this.PowerNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PowerNumericUpDown.Name = "PowerNumericUpDown";
            this.PowerNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.PowerNumericUpDown.TabIndex = 13;
            this.PowerNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // MaxPowerNumericUpDown
            // 
            this.MaxPowerNumericUpDown.Location = new System.Drawing.Point(138, 122);
            this.MaxPowerNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MaxPowerNumericUpDown.Name = "MaxPowerNumericUpDown";
            this.MaxPowerNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.MaxPowerNumericUpDown.TabIndex = 23;
            this.MaxPowerNumericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Мощность на выходе";
            // 
            // MaxCurrentNumericUpDown
            // 
            this.MaxCurrentNumericUpDown.Location = new System.Drawing.Point(138, 96);
            this.MaxCurrentNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MaxCurrentNumericUpDown.Name = "MaxCurrentNumericUpDown";
            this.MaxCurrentNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.MaxCurrentNumericUpDown.TabIndex = 21;
            this.MaxCurrentNumericUpDown.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Ток на выходе";
            // 
            // MaxVoltageOutputNumericUpDown
            // 
            this.MaxVoltageOutputNumericUpDown.Location = new System.Drawing.Point(138, 70);
            this.MaxVoltageOutputNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MaxVoltageOutputNumericUpDown.Name = "MaxVoltageOutputNumericUpDown";
            this.MaxVoltageOutputNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.MaxVoltageOutputNumericUpDown.TabIndex = 19;
            this.MaxVoltageOutputNumericUpDown.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Напряжение на выходе";
            // 
            // MaxVoltageEntranceNumericUpDown
            // 
            this.MaxVoltageEntranceNumericUpDown.Location = new System.Drawing.Point(138, 44);
            this.MaxVoltageEntranceNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MaxVoltageEntranceNumericUpDown.Name = "MaxVoltageEntranceNumericUpDown";
            this.MaxVoltageEntranceNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.MaxVoltageEntranceNumericUpDown.TabIndex = 17;
            this.MaxVoltageEntranceNumericUpDown.Value = new decimal(new int[] {
            700,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Напряжение на вхое";
            // 
            // MaxFrequencyNumericUpDown
            // 
            this.MaxFrequencyNumericUpDown.Location = new System.Drawing.Point(138, 18);
            this.MaxFrequencyNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MaxFrequencyNumericUpDown.Name = "MaxFrequencyNumericUpDown";
            this.MaxFrequencyNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.MaxFrequencyNumericUpDown.TabIndex = 15;
            this.MaxFrequencyNumericUpDown.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Частота напряжения";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.MaxThermometer2NumericUpDown);
            this.groupBox1.Controls.Add(this.MaxThermometer1NumericUpDown);
            this.groupBox1.Controls.Add(this.MaxPowerNumericUpDown);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.MaxFrequencyNumericUpDown);
            this.groupBox1.Controls.Add(this.MaxCurrentNumericUpDown);
            this.groupBox1.Controls.Add(this.MaxVoltageEntranceNumericUpDown);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.MaxVoltageOutputNumericUpDown);
            this.groupBox1.Location = new System.Drawing.Point(246, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 202);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Max значение оси Y";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Температура 2:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 150);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Температура 1:";
            // 
            // MaxThermometer2NumericUpDown
            // 
            this.MaxThermometer2NumericUpDown.Location = new System.Drawing.Point(138, 174);
            this.MaxThermometer2NumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MaxThermometer2NumericUpDown.Name = "MaxThermometer2NumericUpDown";
            this.MaxThermometer2NumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.MaxThermometer2NumericUpDown.TabIndex = 23;
            this.MaxThermometer2NumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // MaxThermometer1NumericUpDown
            // 
            this.MaxThermometer1NumericUpDown.Location = new System.Drawing.Point(138, 148);
            this.MaxThermometer1NumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MaxThermometer1NumericUpDown.Name = "MaxThermometer1NumericUpDown";
            this.MaxThermometer1NumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.MaxThermometer1NumericUpDown.TabIndex = 23;
            this.MaxThermometer1NumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Thermometer2NumericUpDown);
            this.groupBox2.Controls.Add(this.Thermometer1NumericUpDown);
            this.groupBox2.Controls.Add(this.PowerNumericUpDown);
            this.groupBox2.Controls.Add(this.FrequencyNumericUpDown);
            this.groupBox2.Controls.Add(this.VoltageEntranceNumericUpDown);
            this.groupBox2.Controls.Add(this.CurrentNumericUpDown);
            this.groupBox2.Controls.Add(this.VoltageOutputNumericUpDown);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 202);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Интервал оси Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Напряжение на вхое";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Частота напряжения";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 177);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Температура 2:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Температура 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Мощность на выходе";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Ток на выходе";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Напряжение на выходе";
            // 
            // Thermometer2NumericUpDown
            // 
            this.Thermometer2NumericUpDown.Location = new System.Drawing.Point(138, 175);
            this.Thermometer2NumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Thermometer2NumericUpDown.Name = "Thermometer2NumericUpDown";
            this.Thermometer2NumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.Thermometer2NumericUpDown.TabIndex = 13;
            this.Thermometer2NumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Thermometer1NumericUpDown
            // 
            this.Thermometer1NumericUpDown.Location = new System.Drawing.Point(138, 149);
            this.Thermometer1NumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Thermometer1NumericUpDown.Name = "Thermometer1NumericUpDown";
            this.Thermometer1NumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.Thermometer1NumericUpDown.TabIndex = 13;
            this.Thermometer1NumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // SettingChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 265);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.IntervalXNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChanclButton);
            this.Controls.Add(this.OkButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingChartForm";
            this.Text = "Настройка графиков";
            ((System.ComponentModel.ISupportInitialize)(this.IntervalXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrequencyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoltageEntranceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoltageOutputNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPowerNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxCurrentNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxVoltageOutputNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxVoltageEntranceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxFrequencyNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxThermometer2NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxThermometer1NumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Thermometer2NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Thermometer1NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button ChanclButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown IntervalXNumericUpDown;
        private System.Windows.Forms.NumericUpDown FrequencyNumericUpDown;
        private System.Windows.Forms.NumericUpDown VoltageEntranceNumericUpDown;
        private System.Windows.Forms.NumericUpDown VoltageOutputNumericUpDown;
        private System.Windows.Forms.NumericUpDown CurrentNumericUpDown;
        private System.Windows.Forms.NumericUpDown PowerNumericUpDown;
        private System.Windows.Forms.NumericUpDown MaxPowerNumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown MaxCurrentNumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown MaxVoltageOutputNumericUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown MaxVoltageEntranceNumericUpDown;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown MaxFrequencyNumericUpDown;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown MaxThermometer2NumericUpDown;
        private System.Windows.Forms.NumericUpDown MaxThermometer1NumericUpDown;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown Thermometer2NumericUpDown;
        private System.Windows.Forms.NumericUpDown Thermometer1NumericUpDown;
    }
}