
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.FrequencyVoltageChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeTestTextBox = new System.Windows.Forms.TextBox();
            this.RemainingTimeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.CurrentOutputChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.VoltageEntranceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.VoltageOutputChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.FrequencyVoltageChart)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PowerOutputChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentOutputChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoltageEntranceChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoltageOutputChart)).BeginInit();
            this.SuspendLayout();
            // 
            // FrequencyVoltageChart
            // 
            this.FrequencyVoltageChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.FrequencyVoltageChart.ChartAreas.Add(chartArea1);
            this.FrequencyVoltageChart.Location = new System.Drawing.Point(12, 191);
            this.FrequencyVoltageChart.Name = "FrequencyVoltageChart";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.Name = "Частота ";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.FrequencyVoltageChart.Series.Add(series1);
            this.FrequencyVoltageChart.Size = new System.Drawing.Size(472, 197);
            this.FrequencyVoltageChart.TabIndex = 1;
            this.FrequencyVoltageChart.Text = "Частота напряжения";
            title1.Name = "Title1";
            title1.Text = "График частоты напряжения на выходе ПЧ";
            this.FrequencyVoltageChart.Titles.Add(title1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Время тестирования:";
            // 
            // TimeTestTextBox
            // 
            this.TimeTestTextBox.Location = new System.Drawing.Point(134, 6);
            this.TimeTestTextBox.Name = "TimeTestTextBox";
            this.TimeTestTextBox.Size = new System.Drawing.Size(56, 20);
            this.TimeTestTextBox.TabIndex = 6;
            // 
            // RemainingTimeTextBox
            // 
            this.RemainingTimeTextBox.Location = new System.Drawing.Point(315, 6);
            this.RemainingTimeTextBox.Name = "RemainingTimeTextBox";
            this.RemainingTimeTextBox.Size = new System.Drawing.Size(51, 20);
            this.RemainingTimeTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Оставшееся время:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightSalmon;
            this.groupBox4.Controls.Add(this.button1);
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
            this.groupBox4.Location = new System.Drawing.Point(15, 32);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(351, 153);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Параметры контроля ПЧ:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(321, 122);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Вт";
            // 
            // PowerOutputTextBox
            // 
            this.PowerOutputTextBox.Location = new System.Drawing.Point(264, 119);
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
            this.label13.Location = new System.Drawing.Point(321, 96);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "А";
            // 
            // CurrentOutputTextBox
            // 
            this.CurrentOutputTextBox.Location = new System.Drawing.Point(264, 93);
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
            this.label7.Location = new System.Drawing.Point(321, 70);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "В";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(321, 44);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "В";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(321, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Гц";
            // 
            // VoltageOutputTextBox
            // 
            this.VoltageOutputTextBox.Location = new System.Drawing.Point(264, 67);
            this.VoltageOutputTextBox.Name = "VoltageOutputTextBox";
            this.VoltageOutputTextBox.ReadOnly = true;
            this.VoltageOutputTextBox.Size = new System.Drawing.Size(52, 20);
            this.VoltageOutputTextBox.TabIndex = 14;
            this.VoltageOutputTextBox.Text = "0";
            this.VoltageOutputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // VoltageEntranceTextBox
            // 
            this.VoltageEntranceTextBox.Location = new System.Drawing.Point(264, 41);
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
            this.FrequencyVoltageTextBox.Location = new System.Drawing.Point(264, 15);
            this.FrequencyVoltageTextBox.Name = "FrequencyVoltageTextBox";
            this.FrequencyVoltageTextBox.ReadOnly = true;
            this.FrequencyVoltageTextBox.Size = new System.Drawing.Size(52, 20);
            this.FrequencyVoltageTextBox.TabIndex = 9;
            this.FrequencyVoltageTextBox.Text = "0";
            this.FrequencyVoltageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PowerOutputChart
            // 
            this.PowerOutputChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.PowerOutputChart.ChartAreas.Add(chartArea2);
            this.PowerOutputChart.Location = new System.Drawing.Point(372, 9);
            this.PowerOutputChart.Name = "PowerOutputChart";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Red;
            series2.Name = "Частота ";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.PowerOutputChart.Series.Add(series2);
            this.PowerOutputChart.Size = new System.Drawing.Size(614, 176);
            this.PowerOutputChart.TabIndex = 12;
            this.PowerOutputChart.Text = "chart2";
            title2.Name = "Title1";
            title2.Text = "График мощности на выходе БИРН";
            this.PowerOutputChart.Titles.Add(title2);
            // 
            // CurrentOutputChart
            // 
            this.CurrentOutputChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.CurrentOutputChart.ChartAreas.Add(chartArea3);
            this.CurrentOutputChart.Location = new System.Drawing.Point(490, 191);
            this.CurrentOutputChart.Name = "CurrentOutputChart";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Red;
            series3.Name = "Частота ";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.CurrentOutputChart.Series.Add(series3);
            this.CurrentOutputChart.Size = new System.Drawing.Size(496, 197);
            this.CurrentOutputChart.TabIndex = 13;
            this.CurrentOutputChart.Text = "chart2";
            title3.Name = "Title1";
            title3.Text = "График тока на выходе БИРН";
            this.CurrentOutputChart.Titles.Add(title3);
            // 
            // VoltageEntranceChart
            // 
            this.VoltageEntranceChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.VoltageEntranceChart.ChartAreas.Add(chartArea4);
            this.VoltageEntranceChart.Location = new System.Drawing.Point(490, 394);
            this.VoltageEntranceChart.Name = "VoltageEntranceChart";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Red;
            series4.Name = "Частота ";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.VoltageEntranceChart.Series.Add(series4);
            this.VoltageEntranceChart.Size = new System.Drawing.Size(496, 190);
            this.VoltageEntranceChart.TabIndex = 14;
            this.VoltageEntranceChart.Text = "Напряжение на входе";
            title4.Name = "Title1";
            title4.Text = "График напряжения на входе БИРН";
            this.VoltageEntranceChart.Titles.Add(title4);
            // 
            // VoltageOutputChart
            // 
            this.VoltageOutputChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.Name = "ChartArea1";
            this.VoltageOutputChart.ChartAreas.Add(chartArea5);
            this.VoltageOutputChart.Location = new System.Drawing.Point(12, 394);
            this.VoltageOutputChart.Name = "VoltageOutputChart";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.Red;
            series5.Name = "Частота ";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.VoltageOutputChart.Series.Add(series5);
            this.VoltageOutputChart.Size = new System.Drawing.Size(472, 190);
            this.VoltageOutputChart.TabIndex = 15;
            this.VoltageOutputChart.Text = "Напряжение на выходе";
            title5.Name = "Title1";
            title5.Text = "График напряжения на выходе БИРН";
            this.VoltageOutputChart.Titles.Add(title5);
            // 
            // TestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(998, 596);
            this.Controls.Add(this.VoltageOutputChart);
            this.Controls.Add(this.VoltageEntranceChart);
            this.Controls.Add(this.CurrentOutputChart);
            this.Controls.Add(this.PowerOutputChart);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.RemainingTimeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TimeTestTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FrequencyVoltageChart);
            this.Name = "TestingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Испытательный процесс";
            this.Load += new System.EventHandler(this.TestingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FrequencyVoltageChart)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PowerOutputChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentOutputChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoltageEntranceChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoltageOutputChart)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart PowerOutputChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart CurrentOutputChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart VoltageEntranceChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart VoltageOutputChart;
    }
}