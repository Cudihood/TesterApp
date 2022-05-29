using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Modbus.Device;
using Microsoft.Office.Interop.Word;
using Application = Microsoft.Office.Interop.Word.Application;


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
        private DateTime _timeTest = new DateTime(0, 0);

        private DateTime _timeNull = new DateTime(0, 0);

        /// <summary>
        /// Переменная хранящая время от начала испытания 
        /// </summary>
        private DateTime _timeBeginning = new DateTime(0, 0);

        /// <summary>
        /// Переменная хранящая время активного режима установки
        /// </summary>
        private DateTime _timeStart;

        /// <summary>
        /// Переменная хранящая время установки в выключенном состоянии
        /// </summary>
        private DateTime _timeStop;

        /// <summary>
        /// Переменная хранящая оставщееся время
        /// </summary>
        private DateTime _timeRemeining;

        /// <summary>
        /// Массив хранящий данные параметра контроллера
        /// </summary>
        public string[] _controllerParameters;

        /// <summary>
        /// Перенная хранящая адресс датчика температуры
        /// </summary>
        private byte _slaveAddressThermometer = 2;

        /// <summary>
        /// Переменная хранящая колличество периодов;
        /// </summary>
        private int _numberPeriodsNumeric = 1;

        /// <summary>
        /// Переменная хранящая колличество регистров для чтения
        /// </summary>
        public ushort _numberOfPoints = 1;

        /// <summary>
        /// Переменная хранящая тип установки
        /// </summary>
        private int _typeInstallation;

        /// <summary>
        /// Переменная класса SettingTestForm
        /// </summary>
        private readonly SettingTestForm _settingTest = new SettingTestForm();

        /// <summary>
        /// Переменная класса SettingChartForm
        /// </summary>
        private SettingChartForm _settingChart = new SettingChartForm();

        /// <summary>
        /// Переменная хранящая количество периодов тестирования
        /// </summary>
        private int count = 1;

        /// <summary>
        /// Переменная показывающая включен ли датчик температуры
        /// </summary>
        private bool _thermometerFlag=false;

        /// <summary>
        /// Переменная хранящая интервал оси ОХ
        /// </summary>
        public double _intervalX = 1;

        public double _intervalFrequency = 20;

        public double _intervalVoltageEntrance = 100;

        public double _intervalVoltageOutput = 50;

        public double _intervalCurrent= 20;

        public double _intervalPower= 10;

        public double _intervalThermometer1;

        public double _intervalThermometer2;
        private void TestingForm_Load(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            ChartSetting();
            StopButton.Enabled = false;
            CurrentNumericUpDown.Value = Program._mainForm.CurrentNumericUpDown.Value;
            PowerNumericUpDown.Value = Program._mainForm.PowerNumericUpDown.Value;
        }

        /// <summary>
        /// Запуск таймера 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            ChartParameters();

            _timeBeginning = _timeBeginning.AddSeconds(1);
            TimeBeginningTextBox.Text = _timeBeginning.ToString("mm:ss");


            _timeRemeining = _timeRemeining.AddSeconds(-1);
            RemainingTimeTextBox.Text = _timeRemeining.ToString("mm:ss");

            if (_timeStart.Hour == 0 && _timeStart.Minute == 0 && _timeStart.Second == 0)
            {

                Program._mainForm.StartStopController(false);
                _timeStop = _timeStop.AddSeconds(-1);
                if (_timeStop.Hour == 0 && _timeStop.Minute == 0 && _timeStop.Second == 0)
                {
                    _timeStart = _settingTest._timeStart;
                    _timeStop = _settingTest._timeStop;
                    if (count != _numberPeriodsNumeric)
                    {
                        Program._mainForm.StartStopController(true);
                        timer1.Enabled = true;
                        count++;
                    }
                }

                if (_timeRemeining.Hour == 0 && _timeRemeining.Minute == 0 && _timeRemeining.Second == 0)
                {
                    timer1.Enabled = false;
                    ChartParameters();
                    MessageBox.Show("Испытание завершенно", "Внимание", MessageBoxButtons.OK);
                    _timeRemeining = _timeTest;
                    _timeBeginning = _timeNull;
                    LaunchButton.Enabled = true;
                    menuStrip1.Enabled = true;
                    StopButton.Enabled = false;
                    SaveButton.Enabled = true;
                    GetTime();
                }
                return;
            }
            _timeStart = _timeStart.AddSeconds(-1);
        }

        /// <summary>
        /// Вывоит значения параметров контроллера
        /// </summary>
        private void ControllerParameters()
        {

            for (int i = 0; i <= 6; i++)
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
                    case 5:
                        Thermometer1TextBox.Text = string.Empty;
                        Thermometer1TextBox.Text = _controllerParameters[i];
                        break;
                    case 6:
                        Thermometer2TextBox.Text = string.Empty;
                        Thermometer2TextBox.Text = _controllerParameters[i];
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
            FrequencyVoltageChart.ChartAreas[0].AxisY.Interval = _intervalFrequency;
            FrequencyVoltageChart.ChartAreas[0].AxisY.LabelStyle.Format ="0";
            FrequencyVoltageChart.ChartAreas[0].AxisX.LabelStyle.Format = "mm:ss";
            FrequencyVoltageChart.Series[0].XValueType = ChartValueType.DateTime;
            FrequencyVoltageChart.ChartAreas[0].AxisX.Minimum = _timeNull.ToOADate();
            FrequencyVoltageChart.ChartAreas[0].AxisX.Maximum = _timeTest.ToOADate();
            FrequencyVoltageChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            FrequencyVoltageChart.ChartAreas[0].AxisX.Interval = _intervalX;

            VoltageEntranceChart.ChartAreas[0].AxisY.Maximum = 600;
            VoltageEntranceChart.ChartAreas[0].AxisY.Minimum = 0;
            VoltageEntranceChart.ChartAreas[0].AxisY.Interval = _intervalVoltageEntrance;
            VoltageEntranceChart.ChartAreas[0].AxisX.LabelStyle.Format = "mm:ss";
            VoltageEntranceChart.Series[0].XValueType = ChartValueType.DateTime;
            VoltageEntranceChart.ChartAreas[0].AxisX.Minimum = _timeNull.ToOADate();
            VoltageEntranceChart.ChartAreas[0].AxisX.Maximum = _timeTest.ToOADate();
            VoltageEntranceChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            VoltageEntranceChart.ChartAreas[0].AxisX.Interval = _intervalX;

            VoltageOutputChart.ChartAreas[0].AxisY.Maximum = 200;
            VoltageOutputChart.ChartAreas[0].AxisY.Minimum = 0;
            VoltageOutputChart.ChartAreas[0].AxisY.Interval = _intervalVoltageOutput;
            VoltageOutputChart.ChartAreas[0].AxisX.LabelStyle.Format = "mm:ss";
            VoltageOutputChart.Series[0].XValueType = ChartValueType.DateTime;
            VoltageOutputChart.ChartAreas[0].AxisX.Minimum = _timeNull.ToOADate();
            VoltageOutputChart.ChartAreas[0].AxisX.Maximum = _timeTest.ToOADate();
            VoltageOutputChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            VoltageOutputChart.ChartAreas[0].AxisX.Interval = _intervalX;

            CurrentOutputChart.ChartAreas[0].AxisY.Maximum = 70;
            CurrentOutputChart.ChartAreas[0].AxisY.Minimum = 0;
            CurrentOutputChart.ChartAreas[0].AxisY.Interval = _intervalCurrent;
            CurrentOutputChart.ChartAreas[0].AxisX.LabelStyle.Format = "mm:ss";
            CurrentOutputChart.Series[0].XValueType = ChartValueType.DateTime;
            CurrentOutputChart.ChartAreas[0].AxisX.Minimum = _timeNull.ToOADate();
            CurrentOutputChart.ChartAreas[0].AxisX.Maximum = _timeTest.ToOADate();
            CurrentOutputChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            CurrentOutputChart.ChartAreas[0].AxisX.Interval = _intervalX;

            PowerOutputChart.ChartAreas[0].AxisY.Maximum = 20;
            PowerOutputChart.ChartAreas[0].AxisY.Minimum = 0;
            PowerOutputChart.ChartAreas[0].AxisY.Interval = _intervalPower;
            PowerOutputChart.ChartAreas[0].AxisX.LabelStyle.Format = "mm:ss";
            PowerOutputChart.Series[0].XValueType = ChartValueType.DateTime;
            PowerOutputChart.ChartAreas[0].AxisX.Minimum = _timeNull.ToOADate();
            PowerOutputChart.ChartAreas[0].AxisX.Maximum = _timeTest.ToOADate();
            PowerOutputChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            PowerOutputChart.ChartAreas[0].AxisX.Interval = _intervalX;

            ThermometerСhart1.ChartAreas[0].AxisY.Maximum = 1000;
            ThermometerСhart1.ChartAreas[0].AxisY.Minimum = 0;
            ThermometerСhart1.ChartAreas[0].AxisX.LabelStyle.Format = "mm:ss";
            ThermometerСhart1.Series[0].XValueType = ChartValueType.DateTime;
            ThermometerСhart1.ChartAreas[0].AxisX.Minimum = _timeNull.ToOADate();
            ThermometerСhart1.ChartAreas[0].AxisX.Maximum = _timeTest.ToOADate();
            ThermometerСhart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            ThermometerСhart1.ChartAreas[0].AxisX.Interval = _intervalX;

            ThermometerСhart2.ChartAreas[0].AxisY.Maximum = 1000;
            ThermometerСhart2.ChartAreas[0].AxisY.Minimum = 0;
            ThermometerСhart2.ChartAreas[0].AxisX.LabelStyle.Format = "mm:ss";
            ThermometerСhart2.Series[0].XValueType = ChartValueType.DateTime;
            ThermometerСhart2.ChartAreas[0].AxisX.Minimum = _timeNull.ToOADate();
            ThermometerСhart2.ChartAreas[0].AxisX.Maximum = _timeTest.ToOADate();
            ThermometerСhart2.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            ThermometerСhart2.ChartAreas[0].AxisX.Interval = _intervalX;

        }

        /// <summary>
        /// Задает данные X и Y
        /// </summary>
        private void ChartParameters()
        {
            FrequencyVoltageChart.Series[0].Points.AddXY(_timeBeginning, _controllerParameters[0]);
            VoltageEntranceChart.Series[0].Points.AddXY(_timeBeginning, Convert.ToDouble(_controllerParameters[1]));
            VoltageOutputChart.Series[0].Points.AddXY(_timeBeginning, Convert.ToDouble(_controllerParameters[2]));
            CurrentOutputChart.Series[0].Points.AddXY(_timeBeginning, Convert.ToDouble(_controllerParameters[3]));
            PowerOutputChart.Series[0].Points.AddXY(_timeBeginning, Convert.ToDouble(_controllerParameters[4]));
            ThermometerСhart1.Series[0].Points.AddXY(_timeBeginning, Convert.ToDouble(_controllerParameters[5]));
            ThermometerСhart2.Series[0].Points.AddXY(_timeBeginning, Convert.ToDouble(_controllerParameters[6]));
        }


        private void SettingTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = _settingTest.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            _typeInstallation = Program._mainForm._typeInstallation;
            switch (_typeInstallation)
            {
                case 0:
                    CurrentNumericUpDown.Maximum = 30;
                    PowerNumericUpDown.Maximum = 15;
                    break;
                case 1:
                    CurrentNumericUpDown.Maximum = 50;
                    PowerNumericUpDown.Maximum = 25;
                    break;
                case 2:
                    CurrentNumericUpDown.Maximum = 60;
                    PowerNumericUpDown.Maximum = 30;
                    break;
            }

            if (_settingTest.ThermometerOnRadioButton.Checked)
            {
                _thermometerFlag = true;
            }

            _timeStart = _settingTest._timeStart;
            _timeStop = _settingTest._timeStop;
            _timeTest = _settingTest._timeTest;
            _timeRemeining = _timeTest;
            _numberPeriodsNumeric = _settingTest._numberPeriodsNumeric;

            GetTime();
            ChartSetting();
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            if (_timeTest.Hour == 0 && _timeTest.Minute == 0 && _timeTest.Second == 0)
            {
                MessageBox.Show("Не заданын настройки испытания", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            ClearCharts();
            Program._mainForm.StartStopController(true);
            timer1.Enabled = true;
            LaunchButton.Enabled = false;
            StopButton.Enabled = true;
            menuStrip1.Enabled = false;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            Program._mainForm.StartStopController(false);
            timer1.Enabled = false;
            LaunchButton.Enabled = true;
            StopButton.Enabled = false;
            menuStrip1.Enabled = true;
            _timeBeginning = _timeNull;
            _timeRemeining = _timeTest; 
            GetTime();
        }

        private void WriteRegisterButton_Click(object sender, EventArgs e)
        {
            Program._mainForm.WriteRegister(CurrentNumericUpDown.Text, PowerNumericUpDown.Text);
            Program._mainForm.CurrentNumericUpDown.Value = CurrentNumericUpDown.Value;
            Program._mainForm.PowerNumericUpDown.Value = PowerNumericUpDown.Value;
        }


        /*
        private void timer2_Tick(object sender, EventArgs e)
        {
            Program._mainForm.StartStopController(false);
            _timeStop = _timeStop.AddSeconds(-1);
            if (_timeStop.Hour == 0 && _timeStop.Minute == 0 && _timeStop.Second == 0)
            {
                _timeStart = _settingTest._timeStart;
                _timeStop = _settingTest._timeStop;
                if (count != _numberPeriodsNumeric)
                {
                    timer2.Enabled = false;
                    Program._mainForm.StartStopController(true);
                    timer1.Enabled = true;
                    count++;
                }

            }

            if (_timeRemeining.Hour == 0 && _timeRemeining.Minute == 0 && _timeRemeining.Second == 0)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                MessageBox.Show("Испытание завершенно", "Внимание", MessageBoxButtons.OKCancel);
                _timeRemeining = _timeTest;
                _timeBeginning = _timeNull;
                LaunchButton.Enabled = true;
                menuStrip1.Enabled = true;
                StopButton.Enabled = false;
                GetTime();

            }
        }
        */
        private void GetTime()
        {
            TimeTestTextBox.Text = _timeTest.ToString("mm:ss");
            TimeBeginningTextBox.Text = _timeBeginning.ToString("mm:ss");
            RemainingTimeTextBox.Text = _timeRemeining.ToString("mm:ss");
            textBox1.Text = _timeStart.ToString("mm:ss");
            textBox2.Text = _timeStop.ToString("mm:ss");
        }

        private void ClearCharts()
        {
            FrequencyVoltageChart.Series[0].Points.Clear();
            VoltageEntranceChart.Series[0].Points.Clear();
            VoltageOutputChart.Series[0].Points.Clear();
            CurrentOutputChart.Series[0].Points.Clear();
            PowerOutputChart.Series[0].Points.Clear();
            ThermometerСhart1.Series[0].Points.Clear();
            ThermometerСhart2.Series[0].Points.Clear();
        }

        private void SettingChartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = _settingChart.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            _intervalX = _settingChart._intervalX;
            _intervalFrequency = _settingChart._intervalFrequency;
            _intervalVoltageEntrance = _settingChart._intervalVoltageEntrance;
            _intervalVoltageOutput = _settingChart._intervalVoltageOutput;
            _intervalCurrent = _settingChart._intervalCurrent;
            _intervalPower = _settingChart._intervalPower;
            _intervalThermometer1 = _settingChart._intervalThermometer1;
            _intervalThermometer2 = _settingChart._intervalThermometer2;
            ChartSetting();
        }

        public void ReadRegisterThermometer(bool flag)
        {
            if (flag)
            {
                try
                {
                    ushort[] startAddress = { 0x100B, 0x100C };
                    string a;
                    double e;
                    for (int i = 0; i <= 1; i++)
                    {
                        ushort[] result = Program._mainForm._masrerRTU.ReadHoldingRegisters(_slaveAddressThermometer, 
                            startAddress[i], _numberOfPoints);

                        switch (i)
                        {
                            case 0:
                                _controllerParameters[5] = String.Concat<ushort>(result);
                                break;
                            case 1:
                                _controllerParameters[6] = String.Concat<ushort>(result);
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                _controllerParameters[5] = "0";
                _controllerParameters[6] = "0";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ReadRegisterThermometer(_thermometerFlag);
            ControllerParameters();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string comment = "";
            var result = MessageBox.Show("Добавить комментарий?", "Уведомление", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var writeText = new WriteTextForm();
                var key = writeText.ShowDialog();
                if (key != DialogResult.OK)
                {
                    MessageBox.Show("Коментарий не добавлен", "Внимание", MessageBoxButtons.OK);
                }

                comment = writeText._textComment;
            }

            string path="";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Png Image (.png)|*.png";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                path = sfd.FileName;

                if (!string.IsNullOrEmpty(path))
                {
                    FrequencyVoltageChart.SaveImage(path, ChartImageFormat.Png);
                }
            }
            
            Application app = new Application();
            Document doc = app.Documents.Add(Visible: true);
            Range range = doc.Range();
            range.Text = comment;
            
            range.InlineShapes.AddPicture(path,Type.Missing,Type.Missing, range);
            doc.Save();
            doc.Close();
            File.Delete(path);
            MessageBox.Show("Файл сохранен", "Уведомление", MessageBoxButtons.OK);
        }
    }
}
