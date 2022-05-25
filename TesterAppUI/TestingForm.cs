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
        /// Переменная хранящая время от начала испытания 
        /// </summary>
        public DateTime _timeBeginning = new DateTime(0, 0);

        /// <summary>
        /// Переменная хранящая время активного режима установки
        /// </summary>
        public DateTime _timeStart;

        /// <summary>
        /// Переменная хранящая время установки в выключенном состоянии
        /// </summary>
        public DateTime _timeStop;

        /// <summary>
        /// Переменная хранящая оставщееся время
        /// </summary>
        public DateTime _timeRemeining;

        /// <summary>
        /// Массив хранящий данные параметра контроллера
        /// </summary>
        public string[] _controllerParameters;

        /// <summary>
        /// Переменная хранящая колличество периодов;
        /// </summary>
        public int _numberPeriodsNumeric = 1;

        MainForm mainForm = new MainForm();

        private void TestingForm_Load(object sender, EventArgs e)
        {

            ChartSetting();
            StopButton.Enabled = false;
            
        }

        /// <summary>
        /// Запуск таймера 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        { 
            ControllerParameters();
            ChartParameters();

            _timeTest = _timeTest.AddSeconds(1);
            _timeBeginning = _timeBeginning.AddSeconds(1);
            TimeTestTextBox.Text = _timeBeginning.ToString("mm:ss");
            
            
            _timeRemeining = _timeRemeining.AddSeconds(-1);
            RemainingTimeTextBox.Text = _timeRemeining.ToString("mm:ss");
            
            

            if (_timeRemeining.Hour == 0 && _timeRemeining.Minute == 0 && _timeRemeining.Second == 0)
            {
                timer1.Enabled = false;
                ChartParameters();
                MessageBox.Show("Испытание завершенно", "Внимание", MessageBoxButtons.OKCancel);
                
            }
            
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

        /// <summary>
        /// Задает настройки графиков
        /// </summary>
        private void ChartSetting()
        {
            FrequencyVoltageChart.ChartAreas[0].AxisY.Maximum = 60;
            FrequencyVoltageChart.ChartAreas[0].AxisY.Minimum = 0;
            FrequencyVoltageChart.ChartAreas[0].AxisX.LabelStyle.Format = "mm:ss";
            FrequencyVoltageChart.Series[0].XValueType = ChartValueType.DateTime;
            FrequencyVoltageChart.ChartAreas[0].AxisX.Minimum = _timeBeginning.ToOADate();
            FrequencyVoltageChart.ChartAreas[0].AxisX.Maximum = _timeRemeining.ToOADate();
            FrequencyVoltageChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            FrequencyVoltageChart.ChartAreas[0].AxisX.Interval = 1;

            VoltageEntranceChart.ChartAreas[0].AxisY.Maximum = 600;
            VoltageEntranceChart.ChartAreas[0].AxisY.Minimum = 0;
            VoltageEntranceChart.ChartAreas[0].AxisX.LabelStyle.Format = "mm:ss";
            VoltageEntranceChart.Series[0].XValueType = ChartValueType.DateTime;
            VoltageEntranceChart.ChartAreas[0].AxisX.Minimum = _timeBeginning.ToOADate();
            VoltageEntranceChart.ChartAreas[0].AxisX.Maximum = _timeRemeining.ToOADate();
            VoltageEntranceChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            VoltageEntranceChart.ChartAreas[0].AxisX.Interval = 1;

            VoltageOutputChart.ChartAreas[0].AxisY.Maximum = 200;
            VoltageOutputChart.ChartAreas[0].AxisY.Minimum = 0;
            VoltageOutputChart.ChartAreas[0].AxisX.LabelStyle.Format = "mm:ss";
            VoltageOutputChart.Series[0].XValueType = ChartValueType.DateTime;
            VoltageOutputChart.ChartAreas[0].AxisX.Minimum = _timeBeginning.ToOADate();
            VoltageOutputChart.ChartAreas[0].AxisX.Maximum = _timeRemeining.ToOADate();
            VoltageOutputChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            VoltageOutputChart.ChartAreas[0].AxisX.Interval = 1;

            CurrentOutputChart.ChartAreas[0].AxisY.Maximum = 70;
            CurrentOutputChart.ChartAreas[0].AxisY.Minimum = 0;
            CurrentOutputChart.ChartAreas[0].AxisX.LabelStyle.Format = "mm:ss";
            CurrentOutputChart.Series[0].XValueType = ChartValueType.DateTime;
            CurrentOutputChart.ChartAreas[0].AxisX.Minimum = _timeBeginning.ToOADate();
            CurrentOutputChart.ChartAreas[0].AxisX.Maximum = _timeRemeining.ToOADate();
            CurrentOutputChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            CurrentOutputChart.ChartAreas[0].AxisX.Interval = 1;

            PowerOutputChart.ChartAreas[0].AxisY.Maximum = 20;
            PowerOutputChart.ChartAreas[0].AxisY.Minimum = 0;
            PowerOutputChart.ChartAreas[0].AxisX.LabelStyle.Format = "mm:ss";
            PowerOutputChart.Series[0].XValueType = ChartValueType.DateTime;
            PowerOutputChart.ChartAreas[0].AxisX.Minimum = _timeBeginning.ToOADate();
            PowerOutputChart.ChartAreas[0].AxisX.Maximum = _timeRemeining.ToOADate();
            PowerOutputChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            PowerOutputChart.ChartAreas[0].AxisX.Interval = 1;
        }

        /// <summary>
        /// Задает данные X и Y
        /// </summary>
        private void ChartParameters()
        {
            FrequencyVoltageChart.Series[0].Points.AddXY(_timeBeginning, Convert.ToDouble(_controllerParameters[0]));
            VoltageEntranceChart.Series[0].Points.AddXY(_timeBeginning, Convert.ToDouble(_controllerParameters[1]));
            VoltageOutputChart.Series[0].Points.AddXY(_timeBeginning, Convert.ToDouble(_controllerParameters[2]));
            CurrentOutputChart.Series[0].Points.AddXY(_timeBeginning, Convert.ToDouble(_controllerParameters[3]));
            PowerOutputChart.Series[0].Points.AddXY(_timeBeginning, Convert.ToDouble(_controllerParameters[4]));
        }

        private void TestingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            _timeRemeining = mainForm._timeNull;
            _timeTest = mainForm._timeNull;
            mainForm._timeStart = _timeTest;
            mainForm._timeTest = _timeTest;
            mainForm._timeStop = _timeTest;
        }

        private void SettingTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingTestForm settingTest = new SettingTestForm();
            var result = settingTest.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            _timeStart = settingTest._timeStart;
            _timeStop = settingTest._timeStop;
            _timeTest = settingTest._timeTest;

        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            if (_timeTest.Hour == 0 && _timeTest.Minute == 0 && _timeTest.Second == 0)
            {
                MessageBox.Show("Не заданын настройки испытания", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            timer1.Enabled = true;
            mainForm.StartStopController(true);
            LaunchButton.Enabled = false;
            StopButton.Enabled = true;
        }
    }
}
