using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using Modbus.Device;

namespace TesterAppUI
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Переменная хранящая данные порта
        /// </summary>
        private SerialPort _port;

        /// <summary>
        /// Переменная для ввода и вывода данных в регистрв данных
        /// </summary>
        public IModbusMaster _masrerRTU;

        /// <summary>
        /// Переменная хранящая адрес устройства 
        /// </summary>
        private byte _slaveAddress = 10;

        /// <summary>
        /// Переменная хранящая колличество регистров для чтения
        /// </summary>
        private ushort _numberOfPoints = 1;

        /// <summary>
        /// Перенная хранящая адресс датчика температуры
        /// </summary>
        private byte _slaveAddressThermometer = 10;

        /// <summary>
        /// Массив хранящий данные параметра контроллера
        /// </summary>
        private string[] _controllerParameters=new string[5];

        /// <summary>
        /// Переменная хранящая время всего тестирования
        /// </summary>
        public DateTime _timeTest = new DateTime(0, 0);

        /// <summary>
        /// Переменная хранящая время активного режима установки
        /// </summary>
        public DateTime _timeStart;

        /// <summary>
        /// Переменная хранящая время установки в выключенном состоянии
        /// </summary>
        public DateTime _timeStop;

        /// <summary>
        /// Переменная для обнеления времени
        /// </summary>
        public DateTime _timeNull = new DateTime(0, 0);

        private bool _key;



        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Вызывает окно настройки порта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettingСonnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm settingConnection = new SettingForm();
            var result = settingConnection.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            _port = settingConnection.Port;
            
        }

        /// <summary>
        /// Подключение к контроллеру
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            _key = true;
            try
            {
                _port.Open();
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Не указаны настройки порта", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //("Проверьте настройки подключения", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            
            _masrerRTU = ModbusSerialMaster.CreateRtu(_port);

            ConnectButton.Enabled = false;
            DisableButton.Enabled = true;
            StartButton.Enabled = true;
            ParametersTestGroupBox.Enabled = true;


            ControllerParameters();
            WorkParameters();
            ManagementParameters();
        }

        /// <summary>
        /// Отключение от контроллера 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisableButton_Click(object sender, EventArgs e)
        {
            _key = false;
            try
            {
                StartStopController(false);
                _port.Close();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Не выбранны настройки подключения", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //("Проверьте настройки подключения", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            timer1.Enabled = false;
            ConnectButton.Enabled = true;
            DisableButton.Enabled = false;
            StartButton.Enabled = false;
            StopButton.Enabled = false;
            ResetButton.Enabled = false;
            ParametersTestGroupBox.Enabled = false;
        }

        /// <summary>
        /// Вывоит значения параметров контроллера
        /// </summary>
        private void ControllerParameters()
        {
            ushort[] startAddress= {0xA430, 0xA432, 0xA433, 0xA434, 0xA437};
            for (int i = 0; i <= 4; i++)
            {
                ushort[] result = _masrerRTU.ReadHoldingRegisters(_slaveAddress, startAddress[i], _numberOfPoints);
                string a;
                double e;
                switch (i)
                {
                    case 0:
                        FrequencyVoltageTextBox.Text = string.Empty;
                        a = String.Concat<ushort>(result);
                        e = Convert.ToDouble(a)/100;
                        //FrequencyVoltageTextBox.Text = String.Concat<ushort>(result);
                        FrequencyVoltageTextBox.Text = e.ToString();
                        _controllerParameters[i] = FrequencyVoltageTextBox.Text;
                        break;
                    case 1:
                        VoltageEntranceTextBox.Text = string.Empty;
                        //a = String.Concat<ushort>(result);
                        //e = Convert.ToDouble(a);
                        VoltageEntranceTextBox.Text = String.Concat<ushort>(result);
                        _controllerParameters[i] = VoltageEntranceTextBox.Text;
                        break;
                    case 2:
                        VoltageOutputTextBox.Text = string.Empty;
                        a = String.Concat<ushort>(result);
                        e = Convert.ToDouble(a);
                        VoltageOutputTextBox.Text = String.Concat<ushort>(result);
                        _controllerParameters[i] = VoltageOutputTextBox.Text;
                        break;
                    case 3:
                        CurrentOutputTextBox.Text = string.Empty;
                        a = string.Concat(result);
                        e = Convert.ToDouble(a)/10;
                        CurrentOutputTextBox.Text = e.ToString();//String.Concat<ushort>(result);
                        _controllerParameters[i] = CurrentOutputTextBox.Text;
                        break;
                    case 4:
                        PowerOutputTextBox.Text = string.Empty;
                        a = String.Concat<ushort>(result);
                        e = Convert.ToDouble(a)/10;
                        PowerOutputTextBox.Text = e.ToString();//String.Concat<ushort>(result);
                        _controllerParameters[i] = PowerOutputTextBox.Text;
                        break;
                }
            }
        }

        /// <summary>
        /// Выводит параметры граничных условий работы ПЧ на экран
        /// </summary>
        private void WorkParameters()
        {
            ushort[] startAddress = {0xA440, 0xA441, 0xa442, 0xa443, 0xA444 };
            string a;
            double e;
            for (int i = 0; i <= 4; i++)
            {
                ushort[] result = _masrerRTU.ReadHoldingRegisters(_slaveAddress, startAddress[i], _numberOfPoints);
                switch (i)
                {
                    case 0:
                        textBox14.Text = string.Empty;
                        textBox14.Text = String.Concat<ushort>(result);
                        break;
                    case 1:
                        textBox13.Text = string.Empty;
                        textBox13.Text = String.Concat<ushort>(result);
                        break;
                    case 2:
                        textBox12.Text = string.Empty;
                        a = String.Concat<ushort>(result);
                        e = Convert.ToDouble(a)/10;
                        textBox12.Text = e.ToString();//String.Concat<ushort>(result);
                        break;
                    case 3:
                        textBox11.Text = string.Empty;
                        a = String.Concat<ushort>(result);
                        e = Convert.ToDouble(a)/10;
                        textBox11.Text = e.ToString();//String.Concat<ushort>(result);
                        break;
                    case 4:
                        textBox10.Text = string.Empty;
                        a = String.Concat<ushort>(result);
                        e = Convert.ToDouble(a);
                        textBox10.Text = e.ToString();//String.Concat<ushort>(result);
                        break;
                }
            }

        }

        /// <summary>
        /// Вывод данных управления параметров на экран
        /// </summary>
        private void ManagementParameters()
        {
            ushort[] startAddress = {0xA420, 0xa421, 0xa422};
            string a;
            double e;
            for (int i = 0; i <= 2; i++)
            {
                ushort[] result = _masrerRTU.ReadHoldingRegisters(_slaveAddress, startAddress[i], _numberOfPoints);

                switch (i)
                {
                    case 0:
                        CurrentNumericUpDown.Text = string.Empty;
                        a = String.Concat<ushort>(result);
                        e = Convert.ToDouble(a) / 10;
                        CurrentNumericUpDown.Text = e.ToString();// String.Concat<ushort>(result);
                        break;
                    case 1:
                        VoltageNumericUpDown.Text = string.Empty;
                        VoltageNumericUpDown.Text = String.Concat<ushort>(result);
                        break;
                    case 2:
                        PowerNumericUpDown.Text = string.Empty;
                        a = String.Concat<ushort>(result);
                        e = Convert.ToDouble(a) / 10;
                        PowerNumericUpDown.Text = String.Concat<ushort>(result);
                        break;
                }
            }
        }

        /// <summary>
        /// Запись данных в регистры управления параметров работы ПЧ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WriteRegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                ushort[] startAddress = { 0xA420, 0xa421, 0xa422 };
                ushort value;
                for (int i = 0; i <= 2; i++)
                {
                    switch (i)
                    {
                        case 0:
                            value = (ushort) (Convert.ToUInt16(CurrentNumericUpDown.Text)*Convert.ToUInt16(10));
                            _masrerRTU.WriteSingleRegister(_slaveAddress, startAddress[i], value);
                            break;
                        case 1:

                            //value = Convert.ToUInt16(VoltageNumericUpDown.Text);
                            ///значения в регистр а421 не записывается!!!!!
                            //_masrerRTU.WriteSingleRegister(_slaveAddress, startAddress[i], value);
                            break;
                        case 2:
                            value = (ushort) (Convert.ToUInt16(PowerNumericUpDown.Text) * Convert.ToUInt16(10));
                            _masrerRTU.WriteSingleRegister(_slaveAddress, startAddress[i], value);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        /// <summary>
        /// Запускает установку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartButton_Click(object sender, EventArgs e)
        {
            StartStopController(true);
        }

        /// <summary>
        /// Включает/Выключает установку
        /// </summary>
        /// <param name="variable"></param>
        public void StartStopController(bool variable)
        {
            ushort startAddress = 0xA410;
            ushort value;
            if (variable)
            {
                value = Convert.ToUInt16(1);
                _masrerRTU.WriteSingleRegister(_slaveAddress, startAddress, value);
                timer1.Enabled = true;
                StopButton.Enabled = true;
                ResetButton.Enabled = true;
                StartButton.Enabled = false;
                WriteRegisterButton.Enabled = false;
                
                CurrentNumericUpDown.ReadOnly = true;
                PowerNumericUpDown.ReadOnly = true;
                VoltageNumericUpDown.ReadOnly = true;
            }
            else
            {
                value = Convert.ToUInt16(0);
                _masrerRTU.WriteSingleRegister(_slaveAddress, startAddress, value);
                timer1.Enabled = true;
                StopButton.Enabled = false;
                ResetButton.Enabled = false;
                StartButton.Enabled = true;
                WriteRegisterButton.Enabled = true;
                
                CurrentNumericUpDown.ReadOnly = false;
                PowerNumericUpDown.ReadOnly = false;
                VoltageNumericUpDown.ReadOnly = false;
            }
        }

        
        /// <summary>
        /// Запускает таймер 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            ControllerParameters();
            WorkParameters();
            
            SatusController();
        }

        /// <summary>
        /// Выводит состояние контроллера
        /// </summary>
        private void SatusController()
        {
            ushort startAddress = 0xA411;
            ushort[] result = _masrerRTU.ReadHoldingRegisters(_slaveAddress, startAddress, _numberOfPoints);
            
            switch (result[0])
            {
                case 0:
                    StatusBox.Text = "Установка выключена";
                    break;
                case 1:
                    StatusBox.Text = "Установка включена";
                    break;
                case 2:
                    StatusBox.Text = "Авария";
                    ushort startAddress1 = 0xA412;
                    ushort[] result1 = _masrerRTU.ReadHoldingRegisters(_slaveAddress, startAddress1, _numberOfPoints);
                    StatusBox.Text = StatusBox.Text + " " + String.Concat<ushort>(result1);

                    ushort startAddress2 = 0xA413;
                    ushort[] result2 = _masrerRTU.ReadHoldingRegisters(_slaveAddress, startAddress2, _numberOfPoints);
                    StatusBox.Text = StatusBox.Text + " " + String.Concat<ushort>(result2);
                    break;
            }
            
        }

        /// <summary>
        /// Убирает фокус с комбобокса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }

        /// <summary>
        /// Задает тип теста 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TypeTestComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TypeTestComboBox.SelectedIndex)
            {
                case 0:
                    ResourceTestsGroupBox.Enabled = true;
                    PeriodicTestsGroupBox.Enabled = false;

                    break;
                case 1:
                    ResourceTestsGroupBox.Enabled = false;
                    PeriodicTestsGroupBox.Enabled = true;

                    break;
            }
        }

        /// <summary>
        /// Выключает установку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StopButton_Click(object sender, EventArgs e)
        {
            _key = false;
            StartStopController(false);
        }

        /// <summary>
        /// Сброс аварии
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            ushort startAddress = 0xA410;
            ushort value = Convert.ToUInt16(2);
            _masrerRTU.WriteSingleRegister(_slaveAddress, startAddress, value);
            timer1.Enabled = false;
            StopButton.Enabled = false;
            ResetButton.Enabled = false;
            StartButton.Enabled = true;
        }

        /// <summary>
        /// Запуск тестирования
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LaunchButton_Click(object sender, EventArgs e)
        {
            try
            {
                CheckData();
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show($"{exception.Message}", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            if (_port == null) 
            {
                MessageBox.Show("Проверьте настройки подключения", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            //TimeTest();
            var testing = new TestingForm();
            testing._controllerParameters = _controllerParameters;
            //testing._timeRemeining = _timeTest;

            if (Application.OpenForms.OfType<TestingForm>().Count() == 0) 
            {
                testing.Show();

            }
            //Testing();

        }

        /// <summary>
        /// Проверяет указанно ли время работы установки
        /// </summary>
        private void CheckData()
        {
            if (TypeInstallationComboBox.SelectedIndex == -1)
            {
                throw new ArgumentException("Не выбран тип установки");
            }
            if (TypeTestComboBox.SelectedIndex == -1)
            {
                throw new ArgumentException("Не выбран тип испытания");
            }
            switch (TypeTestComboBox.SelectedIndex)
            {
                case 0:
                    if (TimeResourceOffNumericUpDown.Value == 0
                        || TimeResourceOnNumericUpDown.Value == 0)
                    {
                        throw new ArgumentException("Не указанно время работы");
                    }
                    break;
                case 1:
                    if (TimePeriodicOffNumericUpDown.Value == 0
                        || TimePeriodicOnNumericUpDown.Value == 0)
                    {
                        throw new ArgumentException("Не указанно время работы");
                    }

                    if (NumberPeriodsNumericUpDown.Value == 0)
                    {
                        throw new ArgumentException("Не указанно коллиество периодов");
                    }
                    break;
            }
        }

        /// <summary>
        /// Задает время тестирования установки
        /// </summary>
        private void TimeTest()
        {
            switch (TypeTestComboBox.SelectedIndex)
            {
                case 0:
                    _timeStart = _timeTest.AddSeconds(Convert.ToDouble(TimeResourceOnNumericUpDown.Text));
                    _timeStop = _timeTest.AddSeconds(Convert.ToDouble(TimeResourceOffNumericUpDown.Text));
                    _timeTest = _timeTest.AddSeconds(Convert.ToDouble(TimeResourceOffNumericUpDown.Text) 
                                                     + Convert.ToDouble(TimeResourceOnNumericUpDown.Text));
                    break;
                case 1:
                    _timeStart = _timeTest.AddSeconds(Convert.ToDouble(TimePeriodicOnNumericUpDown.Text));
                    _timeStop = _timeTest.AddSeconds(Convert.ToDouble(TimePeriodicOffNumericUpDown.Text));
                    double value = (Convert.ToDouble(TimePeriodicOffNumericUpDown.Text)
                                    + Convert.ToDouble(TimePeriodicOnNumericUpDown.Text))*Convert.ToDouble(NumberPeriodsNumericUpDown.Text);
                    _timeTest = _timeTest.AddSeconds(value);
                    break;
            }
        }

        /// <summary>
        /// Запускает сценарий тестирования
        /// </summary>
        private void Testing()
        {
            TimerStart.Enabled = true;
            StartStopController(true);
            
        }

        /// <summary>
        /// Запускает таймер отсчета времени активного состояния контроллера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerStart_Tick(object sender, EventArgs e)
        {
            _timeStart = _timeStart.AddSeconds(-1);
            TypeTimeTestCheked();
        }

        /// <summary>
        /// Запускает таймер отчета времни для выключенного состояния контроллера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerStop_Tick(object sender, EventArgs e)
        {
            _timeStop = _timeStop.AddSeconds(-1);
            TypeTimeTestCheked();
        }

        private void TimePeriodicOnNumericUpDown_MouseClick(object sender, MouseEventArgs e)
        {
            TimePeriodicOnNumericUpDown.Select(0,TimePeriodicOnNumericUpDown.Value.ToString().Length);
        }

        private void TimePeriodicOffNumericUpDown_MouseClick(object sender, MouseEventArgs e)
        {
            TimePeriodicOffNumericUpDown.Select(0, TimePeriodicOffNumericUpDown.Value.ToString().Length);
        }

        private void TimeResourceOnNumericUpDown_MouseClick(object sender, MouseEventArgs e)
        {
            TimeResourceOnNumericUpDown.Select(0, TimeResourceOnNumericUpDown.Value.ToString().Length);
        }

        private void TimeResourceOffNumericUpDown_MouseClick(object sender, MouseEventArgs e)
        {
            TimeResourceOffNumericUpDown.Select(0, TimeResourceOffNumericUpDown.Value.ToString().Length);
        }

        private void CurrentNumericUpDown_MouseClick(object sender, MouseEventArgs e)
        {
            CurrentNumericUpDown.Select(0, CurrentNumericUpDown.Value.ToString().Length);
        }

        private void VoltageNumericUpDown_MouseClick(object sender, MouseEventArgs e)
        {
            VoltageNumericUpDown.Select(0, VoltageNumericUpDown.Value.ToString().Length);
        }

        private void PowerNumericUpDown_MouseClick(object sender, MouseEventArgs e)
        {
            PowerNumericUpDown.Select(0, PowerNumericUpDown.Value.ToString().Length);
        }

        private void TypeInstallationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TypeInstallationComboBox.SelectedIndex)
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
        }


        private int d = 1;

        private void TypeTimeTestCheked()
        {
            switch (TypeTestComboBox.SelectedIndex)
            {
                case 0:
                    if (_timeStart.Hour == 0 && _timeStart.Minute == 0 && _timeStart.Second == 0)
                    {
                        StartStopController(false);
                        TimerStart.Enabled = false;
                        TimerStop.Enabled = true;
                    }
                    if (_timeStop.Hour == 0 && _timeStop.Minute == 0 && _timeStop.Second == 0)
                    {
                        TimerStop.Enabled = false;
                        _timeTest = _timeNull;
                    }
                    break;
                case 1:
                    if (_timeStart.Hour == 0 && _timeStart.Minute == 0 && _timeStart.Second == 0)
                    {
                        StartStopController(false);
                        TimerStart.Enabled = false;
                        TimerStop.Enabled = true;
                        
                    }

                    if (_timeStop.Hour == 0 && _timeStop.Minute == 0 && _timeStop.Second == 0)
                    {
                        TimerStop.Enabled = false;
                        _timeTest = _timeNull;
                        
                        if (d < NumberPeriodsNumericUpDown.Value)
                        {
                            TimeTest();
                            TimerStart.Enabled = true;
                            StartStopController(true);
                            d++;
                        }
                    }


                    break;
            }

        }
    }


}
