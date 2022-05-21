using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Modbus.Device;

namespace TesterAppUI
{
    public partial class TestingForm : Form
    {
        public TestingForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Переменная хранящая время тестирования
        /// </summary>
        public DateTime _timeTest = new DateTime(0, 0);

        /// <summary>
        /// Переменная хранящая оставщееся время
        /// </summary>
        public DateTime _timeRemeining;

        /// <summary>
        /// Массив хранящий данные параметра контроллера
        /// </summary>
        public string[] _controllerParameters;
        

        private void TestingForm_Load(object sender, EventArgs e)
        {

            ChartSetting();
            timer1.Enabled = true;
            
        }

        /// <summary>
        /// Запуск таймера 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            ControllerParameters();

            _timeTest = _timeTest.AddSeconds(1);
            TimeTestTextBox.Text = _timeTest.ToString("HH:mm:ss");

            _timeRemeining = _timeRemeining.AddSeconds(-1);

                RemainingTimeTextBox.Text = _timeRemeining.ToString("HH:mm:ss");
            if (_timeRemeining.Hour == 0 && _timeRemeining.Minute == 0 && _timeRemeining.Second == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("Испытание завершенно", "Внимание", MessageBoxButtons.OKCancel);
            }

            ChartParameters();
        }

        /// <summary>
        /// Вывоит значения параметров контроллера
        /// </summary>
        private void ControllerParameters()
        {
            for (int i = 0; i <= 4; i++)
            {
                switch (i)
                {
                    case 0:
                        FrequencyVoltageTextBox.Text = string.Empty;
                        FrequencyVoltageTextBox.Text = _controllerParameters[i];
                        break;
                    case 1:
                        VoltageEntranceTextBox.Text = string.Empty;
                        VoltageEntranceTextBox.Text = _controllerParameters[i];
                        break;
                    case 2:
                        VoltageOutputTextBox.Text = string.Empty;
                        VoltageOutputTextBox.Text = _controllerParameters[i];
                        break;
                    case 3:
                        CurrentOutputTextBox.Text = string.Empty;
                        CurrentOutputTextBox.Text = _controllerParameters[i];
                        break;
                    case 4:
                        PowerOutputTextBox.Text = string.Empty;
                        PowerOutputTextBox.Text = _controllerParameters[i];
                        break;
                }
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void ChartSetting()
        {
            FrequencyVoltageChart.ChartAreas[0].AxisY.Maximum = 6000;
            FrequencyVoltageChart.ChartAreas[0].AxisY.Minimum = 0;
            FrequencyVoltageChart.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
            FrequencyVoltageChart.Series[0].XValueType = ChartValueType.DateTime;
            FrequencyVoltageChart.ChartAreas[0].AxisX.Minimum = _timeTest.ToOADate();
            FrequencyVoltageChart.ChartAreas[0].AxisX.Maximum = _timeRemeining.ToOADate();
            FrequencyVoltageChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Minutes;
            FrequencyVoltageChart.ChartAreas[0].AxisX.Interval = 1;

            VoltageEntranceChart.ChartAreas[0].AxisY.Maximum = 6000;
            VoltageEntranceChart.ChartAreas[0].AxisY.Minimum = 0;
            VoltageEntranceChart.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
            VoltageEntranceChart.Series[0].XValueType = ChartValueType.DateTime;
            VoltageEntranceChart.ChartAreas[0].AxisX.Minimum = _timeTest.ToOADate();
            VoltageEntranceChart.ChartAreas[0].AxisX.Maximum = _timeRemeining.ToOADate();
            VoltageEntranceChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Minutes;
            VoltageEntranceChart.ChartAreas[0].AxisX.Interval = 1;

            VoltageOutputChart.ChartAreas[0].AxisY.Maximum = 6000;
            VoltageOutputChart.ChartAreas[0].AxisY.Minimum = 0;
            VoltageOutputChart.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
            VoltageOutputChart.Series[0].XValueType = ChartValueType.DateTime;
            VoltageOutputChart.ChartAreas[0].AxisX.Minimum = _timeTest.ToOADate();
            VoltageOutputChart.ChartAreas[0].AxisX.Maximum = _timeRemeining.ToOADate();
            VoltageOutputChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Minutes;
            VoltageOutputChart.ChartAreas[0].AxisX.Interval = 1;

            CurrentOutputChart.ChartAreas[0].AxisY.Maximum = 6000;
            CurrentOutputChart.ChartAreas[0].AxisY.Minimum = 0;
            CurrentOutputChart.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
            CurrentOutputChart.Series[0].XValueType = ChartValueType.DateTime;
            CurrentOutputChart.ChartAreas[0].AxisX.Minimum = _timeTest.ToOADate();
            CurrentOutputChart.ChartAreas[0].AxisX.Maximum = _timeRemeining.ToOADate();
            CurrentOutputChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Minutes;
            CurrentOutputChart.ChartAreas[0].AxisX.Interval = 1;

            PowerOutputChart.ChartAreas[0].AxisY.Maximum = 6000;
            PowerOutputChart.ChartAreas[0].AxisY.Minimum = 0;
            PowerOutputChart.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
            PowerOutputChart.Series[0].XValueType = ChartValueType.DateTime;
            PowerOutputChart.ChartAreas[0].AxisX.Minimum = _timeTest.ToOADate();
            PowerOutputChart.ChartAreas[0].AxisX.Maximum = _timeRemeining.ToOADate();
            PowerOutputChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Minutes;
            PowerOutputChart.ChartAreas[0].AxisX.Interval = 1;
        }

        private void ChartParameters()
        {
            FrequencyVoltageChart.Series[0].Points.AddXY(_timeTest, _controllerParameters[0]);
            VoltageEntranceChart.Series[0].Points.AddXY(_timeTest, _controllerParameters[1]);
            VoltageOutputChart.Series[0].Points.AddXY(_timeTest, _controllerParameters[2]);
            CurrentOutputChart.Series[0].Points.AddXY(_timeTest, _controllerParameters[3]);
            PowerOutputChart.Series[0].Points.AddXY(_timeTest, _controllerParameters[4]);
        }
    }
}
