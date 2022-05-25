
namespace TesterAppUI
{
    partial class TestingForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.FrequencyVoltageChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeTestTextBox = new System.Windows.Forms.TextBox();
            this.RemainingTimeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.PowerOutputChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.VoltageEntranceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.VoltageOutputChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CurrentOutputChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LaunchButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PowerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.VoltageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CurrentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.WriteRegisterButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SettingTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingGraphicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StopButton = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.FrequencyVoltageChart)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PowerOutputChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoltageEntranceChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoltageOutputChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentOutputChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PowerNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoltageNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentNumericUpDown)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FrequencyVoltageChart
            // 
            this.FrequencyVoltageChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.FrequencyVoltageChart.ChartAreas.Add(chartArea1);
            this.FrequencyVoltageChart.Location = new System.Drawing.Point(6, 6);
            this.FrequencyVoltageChart.Name = "FrequencyVoltageChart";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.Name = "Частота ";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.FrequencyVoltageChart.Series.Add(series1);
            this.FrequencyVoltageChart.Size = new System.Drawing.Size(691, 229);
            this.FrequencyVoltageChart.TabIndex = 1;
            this.FrequencyVoltageChart.Text = "Частота напряжения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Время тестирования:";
            // 
            // TimeTestTextBox
            // 
            this.TimeTestTextBox.Location = new System.Drawing.Point(74, 387);
            this.TimeTestTextBox.Name = "TimeTestTextBox";
            this.TimeTestTextBox.Size = new System.Drawing.Size(56, 20);
            this.TimeTestTextBox.TabIndex = 6;
            // 
            // RemainingTimeTextBox
            // 
            this.RemainingTimeTextBox.Location = new System.Drawing.Point(74, 413);
            this.RemainingTimeTextBox.Name = "RemainingTimeTextBox";
            this.RemainingTimeTextBox.Size = new System.Drawing.Size(56, 20);
            this.RemainingTimeTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Осталось";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightSalmon;
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
            this.groupBox4.Location = new System.Drawing.Point(12, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(300, 148);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Параметры контроля ПЧ:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(259, 122);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Вт";
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
            this.label16.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
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
            this.label14.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
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
            this.label10.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Напряжение на выходе БИРН:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 44);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Напряжение на входе БИРН:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 18);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
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
            // PowerOutputChart
            // 
            this.PowerOutputChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.PowerOutputChart.ChartAreas.Add(chartArea2);
            this.PowerOutputChart.Location = new System.Drawing.Point(6, 946);
            this.PowerOutputChart.Name = "PowerOutputChart";
            this.PowerOutputChart.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Red;
            series2.Name = "Частота ";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.PowerOutputChart.Series.Add(series2);
            this.PowerOutputChart.Size = new System.Drawing.Size(691, 229);
            this.PowerOutputChart.TabIndex = 12;
            this.PowerOutputChart.Text = "chart2";
            // 
            // VoltageEntranceChart
            // 
            this.VoltageEntranceChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.VoltageEntranceChart.ChartAreas.Add(chartArea3);
            this.VoltageEntranceChart.Location = new System.Drawing.Point(6, 241);
            this.VoltageEntranceChart.Name = "VoltageEntranceChart";
            this.VoltageEntranceChart.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Red;
            series3.Name = "U на входе";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.VoltageEntranceChart.Series.Add(series3);
            this.VoltageEntranceChart.Size = new System.Drawing.Size(691, 229);
            this.VoltageEntranceChart.TabIndex = 14;
            this.VoltageEntranceChart.Text = "Напряжение на входе";
            // 
            // VoltageOutputChart
            // 
            this.VoltageOutputChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.VoltageOutputChart.ChartAreas.Add(chartArea4);
            this.VoltageOutputChart.Location = new System.Drawing.Point(6, 476);
            this.VoltageOutputChart.Name = "VoltageOutputChart";
            this.VoltageOutputChart.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Red;
            series4.Name = "Частота ";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.VoltageOutputChart.Series.Add(series4);
            this.VoltageOutputChart.Size = new System.Drawing.Size(691, 229);
            this.VoltageOutputChart.TabIndex = 15;
            this.VoltageOutputChart.Text = "Напряжение на выходе";
            // 
            // CurrentOutputChart
            // 
            this.CurrentOutputChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.Name = "ChartArea1";
            this.CurrentOutputChart.ChartAreas.Add(chartArea5);
            this.CurrentOutputChart.Location = new System.Drawing.Point(6, 711);
            this.CurrentOutputChart.Name = "CurrentOutputChart";
            this.CurrentOutputChart.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.Red;
            series5.Name = "Частота ";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.CurrentOutputChart.Series.Add(series5);
            this.CurrentOutputChart.Size = new System.Drawing.Size(691, 229);
            this.CurrentOutputChart.TabIndex = 13;
            this.CurrentOutputChart.Text = "chart2";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(3, 3);
            this.panel1.Controls.Add(this.PowerOutputChart);
            this.panel1.Controls.Add(this.VoltageEntranceChart);
            this.panel1.Controls.Add(this.FrequencyVoltageChart);
            this.panel1.Controls.Add(this.CurrentOutputChart);
            this.panel1.Controls.Add(this.VoltageOutputChart);
            this.panel1.Location = new System.Drawing.Point(330, 32);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(720, 510);
            this.panel1.TabIndex = 16;
            // 
            // LaunchButton
            // 
            this.LaunchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LaunchButton.Location = new System.Drawing.Point(12, 321);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(300, 28);
            this.LaunchButton.TabIndex = 21;
            this.LaunchButton.Text = "ЗАПУСК";
            this.LaunchButton.UseVisualStyleBackColor = true;
            this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Controls.Add(this.PowerNumericUpDown);
            this.groupBox1.Controls.Add(this.VoltageNumericUpDown);
            this.groupBox1.Controls.Add(this.CurrentNumericUpDown);
            this.groupBox1.Controls.Add(this.WriteRegisterButton);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Location = new System.Drawing.Point(12, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(300, 134);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление параметрами работы ПЧ:";
            // 
            // PowerNumericUpDown
            // 
            this.PowerNumericUpDown.Location = new System.Drawing.Point(200, 70);
            this.PowerNumericUpDown.Name = "PowerNumericUpDown";
            this.PowerNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.PowerNumericUpDown.TabIndex = 39;
            this.PowerNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // 
            // WriteRegisterButton
            // 
            this.WriteRegisterButton.Location = new System.Drawing.Point(5, 96);
            this.WriteRegisterButton.Name = "WriteRegisterButton";
            this.WriteRegisterButton.Size = new System.Drawing.Size(290, 33);
            this.WriteRegisterButton.TabIndex = 18;
            this.WriteRegisterButton.Text = "Задать";
            this.WriteRegisterButton.UseVisualStyleBackColor = true;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "А";
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
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(5, 46);
            this.label17.Margin = new System.Windows.Forms.Padding(3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(181, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Напряжение стабилизации БИРН:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(2, 20);
            this.label18.Margin = new System.Windows.Forms.Padding(3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(136, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "Ток стабилизации БИРН:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingTestToolStripMenuItem,
            this.SettingGraphicsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1050, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SettingTestToolStripMenuItem
            // 
            this.SettingTestToolStripMenuItem.Name = "SettingTestToolStripMenuItem";
            this.SettingTestToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.SettingTestToolStripMenuItem.Text = "Настройка испытания";
            this.SettingTestToolStripMenuItem.Click += new System.EventHandler(this.SettingTestToolStripMenuItem_Click);
            // 
            // SettingGraphicsToolStripMenuItem
            // 
            this.SettingGraphicsToolStripMenuItem.Name = "SettingGraphicsToolStripMenuItem";
            this.SettingGraphicsToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.SettingGraphicsToolStripMenuItem.Text = "Настройка графиков ";
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(12, 468);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(300, 74);
            this.StopButton.TabIndex = 25;
            this.StopButton.Text = "Осановить";
            this.StopButton.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 390);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 13);
            this.label19.TabIndex = 26;
            this.label19.Text = "Прошло:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 355);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 20);
            this.textBox1.TabIndex = 27;
            // 
            // TestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(6, 6);
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1050, 554);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.LaunchButton);
            this.Controls.Add(this.RemainingTimeTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeTestTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TestingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Испытательный процесс";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestingForm_FormClosing);
            this.Load += new System.EventHandler(this.TestingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FrequencyVoltageChart)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PowerOutputChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoltageEntranceChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoltageOutputChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentOutputChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PowerNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoltageNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentNumericUpDown)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart FrequencyVoltageChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TimeTestTextBox;
        private System.Windows.Forms.TextBox RemainingTimeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
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
        private System.Windows.Forms.DataVisualization.Charting.Chart PowerOutputChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart VoltageEntranceChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart VoltageOutputChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart CurrentOutputChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LaunchButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown PowerNumericUpDown;
        private System.Windows.Forms.NumericUpDown VoltageNumericUpDown;
        private System.Windows.Forms.NumericUpDown CurrentNumericUpDown;
        private System.Windows.Forms.Button WriteRegisterButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SettingTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingGraphicsToolStripMenuItem;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox1;
    }
}