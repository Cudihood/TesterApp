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
using Task = System.Threading.Tasks.Task;


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

        private DateTime _timeBeginningTest;

        private DateTime _timeFinalTest;

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
        public double[] _controllerParameters;

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
        private SettingTestForm _settingTest = new SettingTestForm();

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

        public double[] _intervalY = {20, 100, 50, 20, 10, 100, 100};

        public double[] _maxValueY = {60, 700, 200, 70, 20, 100, 100};

        private int _oneTick = 0;

        private string _typeTest;

        private IModbusMaster _masterRTU;
        private void TestingForm_Load(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            ChartSetting();
            StopButton.Enabled = false;
            CurrentNumericUpDown.Value = Program._mainForm.CurrentNumericUpDown.Value;
            PowerNumericUpDown.Value = Program._mainForm.PowerNumericUpDown.Value;
            VoltageNumericUpDown.Value = Program._mainForm.VoltageNumericUpDown.Value;
            _masterRTU = Program._mainForm._masterRTU;
            _thermometerFlag = Program._mainForm._thermometerFlag;
        }

        /// <summary>
        /// Запуск таймера 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (Program._mainForm._accidentChecked)
            {
                timer1.Enabled = false;
                LaunchButton.Enabled = true;
                StopButton.Enabled = false;
                menuStrip1.Enabled = true;
                _timeBeginning = _timeNull;
                _timeRemeining = _timeTest;
                GetTime();
                _oneTick = 0;
                count = 1;
                var result = MessageBox.Show(Program._mainForm.StatusController() + "\r\nДля сброса аварии нажмите OK", "Внимание!", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    Program._mainForm._masterRTU.WriteSingleRegister(Program._mainForm._slaveAddress, 0xA410, 2);
                }
                return;
            }
            if (_oneTick != 0)
            {
                _timeBeginning = _timeBeginning.AddSeconds(1);
                _timeRemeining = _timeRemeining.AddSeconds(-1);
            }
            TimeBeginningTextBox.Text = _timeBeginning.ToString("mm:ss");
            RemainingTimeTextBox.Text = _timeRemeining.ToString("mm:ss");
            ChartParameters();
            if (_timeStart.Hour == 0 && _timeStart.Minute == 0 && _timeStart.Second == 0)
            {
                await Program._mainForm.StartStopController(false);
                if (_timeStop.Hour == 0 && _timeStop.Minute == 0 && _timeStop.Second == 0)
                {
                    _timeStart = _settingTest._timeStart;
                    _timeStop = _settingTest._timeStop;
                    if (count != _numberPeriodsNumeric)
                    {
                        await Program._mainForm.StartStopController(true);
                        _timeStart = _timeStart.AddSeconds(-1);
                        count++;
                        return;
                    }
                }
                if (_timeRemeining.Hour == 0 && _timeRemeining.Minute == 0 && _timeRemeining.Second == 0)
                {
                    _timeFinalTest = DateTime.Now;
                    timer1.Enabled = false;
                    ChartParameters();
                    MessageBox.Show("Испытание завершено", "Внимание", MessageBoxButtons.OK);
                    _timeStart = _settingTest._timeStart;
                    _timeStop = _settingTest._timeStop;
                    _timeRemeining = _timeTest;
                    _timeBeginning = _timeNull;
                    LaunchButton.Enabled = true;
                    menuStrip1.Enabled = true;
                    StopButton.Enabled = false;
                    SaveButton.Enabled = true;
                    GetTime();
                    _oneTick = 0;
                    count = 1;
                    return;
                }
                _timeStop = _timeStop.AddSeconds(-1);
                return;
            }
            _timeStart = _timeStart.AddSeconds(-1);
            _oneTick = 1;
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
                        FrequencyVoltageTextBox.Text = _controllerParameters[i].ToString();
                        break;
                    case 1:
                        VoltageEntranceTextBox.Text = string.Empty;
                        VoltageEntranceTextBox.Text = _controllerParameters[i].ToString();
                        break;
                    case 2:
                        VoltageOutputTextBox.Text = string.Empty;
                        VoltageOutputTextBox.Text = _controllerParameters[i].ToString();
                        break;
                    case 3:
                        CurrentOutputTextBox.Text = string.Empty;
                        CurrentOutputTextBox.Text = _controllerParameters[i].ToString();
                        break;
                    case 4:
                        PowerOutputTextBox.Text = string.Empty;
                        PowerOutputTextBox.Text = _controllerParameters[i].ToString();
                        break;
                    case 5:
                        Thermometer1TextBox.Text = string.Empty;
                        Thermometer1TextBox.Text = _controllerParameters[i].ToString();
                        break;
                    case 6:
                        Thermometer2TextBox.Text = string.Empty;
                        Thermometer2TextBox.Text = _controllerParameters[i].ToString();
                        break;
                }
            }
        }

        /// <summary>
        /// Задает настройки графиков
        /// </summary>
        private void ChartSetting()
        {
            FrequencyVoltageChart.ChartAreas[0].AxisY.Maximum = _maxValueY[0];
            FrequencyVoltageChart.ChartAreas[0].AxisY.Minimum = 0;
            FrequencyVoltageChart.ChartAreas[0].AxisY.Interval = _intervalY[0];
            FrequencyVoltageChart.ChartAreas[0].AxisY.LabelStyle.Format ="0";
            FrequencyVoltageChart.ChartAreas[0].AxisX.LabelStyle.Format = "mm:ss";
            FrequencyVoltageChart.Series[0].XValueType = ChartValueType.DateTime;
            FrequencyVoltageChart.ChartAreas[0].AxisX.Minimum = _timeNull.ToOADate();
            FrequencyVoltageChart.ChartAreas[0].AxisX.Maximum = _timeTest.ToOADate();
            FrequencyVoltageChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            FrequencyVoltageChart.ChartAreas[0].AxisX.Interval = _intervalX;

            VoltageEntranceChart.ChartAreas[0].AxisY.Maximum = _maxValueY[1];
            VoltageEntranceChart.ChartAreas[0].AxisY.Minimum = 0;
            VoltageEntranceChart.ChartAreas[0].AxisY.Interval = _intervalY[1];
            VoltageEntranceChart.ChartAreas[0].AxisX.LabelStyle.Format = "mm:ss";
            VoltageEntranceChart.Series[0].XValueType = ChartValueType.DateTime;
            VoltageEntranceChart.ChartAreas[0].AxisX.Minimum = _timeNull.ToOADate();
            VoltageEntranceChart.ChartAreas[0].AxisX.Maximum = _timeTest.ToOADate();
            VoltageEntranceChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            VoltageEntranceChart.ChartAreas[0].AxisX.Interval = _intervalX;

            VoltageOutputChart.ChartAreas[0].AxisY.Maximum = _maxValueY[2];
            VoltageOutputChart.ChartAreas[0].AxisY.Minimum = 0;
            VoltageOutputChart.ChartAreas[0].AxisY.Interval = _intervalY[2];
            VoltageOutputChart.ChartAreas[0].AxisX.LabelStyle.Format = "mm:ss";
            VoltageOutputChart.Series[0].XValueType = ChartValueType.DateTime;
            VoltageOutputChart.ChartAreas[0].AxisX.Minimum = _timeNull.ToOADate();
            VoltageOutputChart.ChartAreas[0].AxisX.Maximum = _timeTest.ToOADate();
            VoltageOutputChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            VoltageOutputChart.ChartAreas[0].AxisX.Interval = _intervalX;

            CurrentOutputChart.ChartAreas[0].AxisY.Maximum = _maxValueY[3];
            CurrentOutputChart.ChartAreas[0].AxisY.Minimum = 0;
            CurrentOutputChart.ChartAreas[0].AxisY.Interval = _intervalY[3];
            CurrentOutputChart.ChartAreas[0].AxisX.LabelStyle.Format = "mm:ss";
            CurrentOutputChart.Series[0].XValueType = ChartValueType.DateTime;
            CurrentOutputChart.ChartAreas[0].AxisX.Minimum = _timeNull.ToOADate();
            CurrentOutputChart.ChartAreas[0].AxisX.Maximum = _timeTest.ToOADate();
            CurrentOutputChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            CurrentOutputChart.ChartAreas[0].AxisX.Interval = _intervalX;

            PowerOutputChart.ChartAreas[0].AxisY.Maximum = _maxValueY[4];
            PowerOutputChart.ChartAreas[0].AxisY.Minimum = 0;
            PowerOutputChart.ChartAreas[0].AxisY.Interval = _intervalY[4];
            PowerOutputChart.ChartAreas[0].AxisX.LabelStyle.Format = "mm:ss";
            PowerOutputChart.Series[0].XValueType = ChartValueType.DateTime;
            PowerOutputChart.ChartAreas[0].AxisX.Minimum = _timeNull.ToOADate();
            PowerOutputChart.ChartAreas[0].AxisX.Maximum = _timeTest.ToOADate();
            PowerOutputChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            PowerOutputChart.ChartAreas[0].AxisX.Interval = _intervalX;

            ThermometerСhart1.ChartAreas[0].AxisY.Maximum = _maxValueY[5];
            ThermometerСhart1.ChartAreas[0].AxisY.Minimum = 0;
            ThermometerСhart1.ChartAreas[0].AxisY.Interval = _intervalY[5];
            ThermometerСhart1.ChartAreas[0].AxisX.LabelStyle.Format = "mm:ss";
            ThermometerСhart1.Series[0].XValueType = ChartValueType.DateTime;
            ThermometerСhart1.ChartAreas[0].AxisX.Minimum = _timeNull.ToOADate();
            ThermometerСhart1.ChartAreas[0].AxisX.Maximum = _timeTest.ToOADate();
            ThermometerСhart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            ThermometerСhart1.ChartAreas[0].AxisX.Interval = _intervalX;

            ThermometerСhart2.ChartAreas[0].AxisY.Maximum = _maxValueY[6];
            ThermometerСhart2.ChartAreas[0].AxisY.Minimum = 0;
            ThermometerСhart2.ChartAreas[0].AxisY.Interval = _intervalY[6];
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

            

            _timeStart = _settingTest._timeStart;
            _timeStop = _settingTest._timeStop;
            _timeTest = _settingTest._timeTest;
            _timeRemeining = _timeTest;
            _numberPeriodsNumeric = _settingTest._numberPeriodsNumeric;
            _typeTest = _settingTest._typeTest;
            GetTime();
            ChartSetting();
            timer2.Enabled = true;
            LaunchButton.Enabled = true;
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            if (_timeTest.Hour == 0 && _timeTest.Minute == 0 && _timeTest.Second == 0)
            {
                MessageBox.Show("Не заданы настройки испытания", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            ClearCharts();
            _timeBeginningTest = DateTime.Now;
            _timeStart = _settingTest._timeStart;
            _timeStop = _settingTest._timeStop;
            _timeTest = _settingTest._timeTest;
            _timeRemeining = _timeTest;
            _numberPeriodsNumeric = _settingTest._numberPeriodsNumeric;
            _typeTest = _settingTest._typeTest;
            GetTime();
            LaunchButton.Enabled = false;
            StopButton.Enabled = true;
            menuStrip1.Enabled = false;
            Program._mainForm.StartStopController(true);
            timer1.Enabled = true;
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
            _oneTick = 0;
            count = 1;
        }

        private void WriteRegisterButton_Click(object sender, EventArgs e)
        {
            Program._mainForm.WriteRegister(CurrentNumericUpDown.Text,VoltageNumericUpDown.Text, PowerNumericUpDown.Text);
            Program._mainForm.CurrentNumericUpDown.Value = CurrentNumericUpDown.Value;
            Program._mainForm.PowerNumericUpDown.Value = PowerNumericUpDown.Value;
            Program._mainForm.VoltageNumericUpDown.Value = VoltageNumericUpDown.Value;
        }

        private void GetTime()
        {
            TimeTestTextBox.Text = _timeTest.ToString("mm:ss");
            TimeBeginningTextBox.Text = _timeBeginning.ToString("mm:ss");
            RemainingTimeTextBox.Text = _timeRemeining.ToString("mm:ss");
            textBox1.Text = _settingTest._timeStart.ToString("mm:ss");
            textBox2.Text = _settingTest._timeStop.ToString("mm:ss");
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
            _intervalY = _settingChart._interval;
            _maxValueY = _settingChart._maxValue;
            ChartSetting();
        }

        /*public async Task ReadRegisterThermometerAsync(bool flag)
        {
            timer2.Stop();
            double[] controllerParameters = { 0, 0 };
            if (flag)
            {
                try
                {
                    await Task.Run(() =>
                    {
                        controllerParameters = ReadRegisterThermometer();
                    });
                    _controllerParameters[5] = controllerParameters[0];
                    _controllerParameters[6] = controllerParameters[1];
                    timer2.Start();
                }
                catch (TimeoutException)
                {
                    timer2.Enabled = false;
                    timer2.Stop();
                    LaunchButton.Enabled = true;
                    MessageBox.Show("Время ожидания истекло. Проверьте подключение датчиков температуры",
                        "Внимание",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    _thermometerFlag = false;
                    return;
                }
                catch (Exception ex)
                {
                    timer2.Enabled = false;
                    timer2.Stop();
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                _controllerParameters[5] = controllerParameters[0];
                _controllerParameters[6] = controllerParameters[1];
                timer2.Start();
            }
        }
        */

        

        private void timer2_Tick(object sender, EventArgs e)
        {
            ControllerParameters();
            if (Program._mainForm._port.IsOpen == false)
            {
                timer2.Enabled = false;
                this.Close();
            }
        }

        public static string DefaultFileName
        {
            get
            {
                var appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                var defaultFileName = appDataFolder + $@"\TesterApp\";
                return defaultFileName;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var _defaultFileName = DefaultFileName;
            string comment = "";
            string numberInstallation = "";
            string thermometer = "Не использовались";
            if (_thermometerFlag)
            {
                thermometer = "Использовались";
            }
            var writeText = new WriteTextForm(); 
            var key = writeText.ShowDialog();
            if (key != DialogResult.OK)
            {
                MessageBox.Show("Коментарий не добавлен", "Внимание", MessageBoxButtons.OK);
            }
            else
            {
                comment = writeText._textComment;
                numberInstallation = writeText._numberInstallation;
            }


            if (!File.Exists(_defaultFileName))
            {
                Directory.CreateDirectory(_defaultFileName);
            }
            Application app = new Application();
            Document doc = app.Documents.Add(Visible: true);
            
            Paragraph titleParagraph = doc.Paragraphs.Add();
            Range titleRange = titleParagraph.Range;
            titleRange.Text = "Отчет по испытанию";
            titleRange.InsertParagraphAfter();
            titleRange.Font.Bold = 1;
            titleRange.Font.Size = 18;
            titleRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

            Paragraph textParagraph = doc.Paragraphs.Add();
            Range textRange = textParagraph.Range;
            textRange.Text = $"\nКомментарий к испытанию: {comment}\n" +
                             $"\nТип испытания: {_typeTest}\n" + 
                              $"Начало испытания: {_timeBeginningTest.ToString("G")}\n" +
                              $"Окончание испытания: {_timeFinalTest.ToString("G")}\n" +
                              $"Длительность процесса: {_timeTest.ToString("T")}\n" +
                              $"Время во включенном состоянии: {_timeStart.ToString("T")}\n" +
                              $"Время в выключенном состоянии: {_timeStop.ToString("T")}\n" +
                              $"Количество периодов: {_numberPeriodsNumeric}\n" +
                              $"Датчики температуры: {thermometer}\n" +
                              $"Серийный номер установки: {numberInstallation}\n\n";
            var path = _defaultFileName;
            for (int i = 0; i < 7; i++)
            {
                switch (i)
                {
                    case 0:
                        path += "Частота.png";
                        FrequencyVoltageChart.SaveImage(path, ChartImageFormat.Png);
                        doc.Bookmarks.get_Item("\\endofdoc").Range.InlineShapes.AddPicture(path);
                        File.Delete(path);
                        break;
                    case 1:
                        path += "НапряжениеНаВх.png";
                        VoltageEntranceChart.SaveImage(path, ChartImageFormat.Png);
                        doc.Bookmarks.get_Item("\\endofdoc").Range.InlineShapes.AddPicture(path);
                        File.Delete(path);
                        break;
                    case 2:
                        path += "НапряжениеНаВых.png";
                        VoltageOutputChart.SaveImage(path, ChartImageFormat.Png);
                        doc.Bookmarks.get_Item("\\endofdoc").Range.InlineShapes.AddPicture(path);
                        File.Delete(path);
                        break;
                    case 3:
                        path += "Ток.png";
                        CurrentOutputChart.SaveImage(path, ChartImageFormat.Png);
                        doc.Bookmarks.get_Item("\\endofdoc").Range.InlineShapes.AddPicture(path);
                        File.Delete(path);
                        break;
                    case 4:
                        path += "Мощность.png";
                        PowerOutputChart.SaveImage(path, ChartImageFormat.Png);
                        doc.Bookmarks.get_Item("\\endofdoc").Range.InlineShapes.AddPicture(path);
                        File.Delete(path);
                        break;
                    case 5:
                        if (!Program._mainForm.Sensor1СheckBox.Checked)
                        {
                            break;
                        }
                        path += "Температура1.png";
                        ThermometerСhart1.SaveImage(path, ChartImageFormat.Png);
                        doc.Bookmarks.get_Item("\\endofdoc").Range.InlineShapes.AddPicture(path);
                        File.Delete(path);
                        break;
                    case 6:
                        if (!Program._mainForm.Sensor2CheckBox.Checked)
                        {
                            break;
                        }
                        path += "Температура2.png";
                        ThermometerСhart2.SaveImage(path, ChartImageFormat.Png);
                        doc.Bookmarks.get_Item("\\endofdoc").Range.InlineShapes.AddPicture(path);
                        File.Delete(path);
                        break;
                }
                
            }
            //Clipboard.SetImage(FrequencyVoltageChart);
            try
            {
                doc.Save();
                doc.Close();
                app.Quit();
                MessageBox.Show("Файл сохранен", "Уведомление", MessageBoxButtons.OK);
                return;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                app.Quit();
                return;
            }
            
        }

        private void TestingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program._mainForm.LaunchButton.Enabled = true;
        }
    }
}
