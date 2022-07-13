using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public SerialPort _port;

        /// <summary>
        /// Переменная для ввода и вывода данных с регистров
        /// </summary>
        public IModbusMaster _masterRTU;

        /// <summary>
        /// Переменная хранящая адрес устройства 
        /// </summary>
        public byte _slaveAddress = 10;

        /// <summary>
        /// Переменная хранящая колличество регистров для чтения
        /// </summary>
        public ushort _numberOfPoints = 1;

        /// <summary>
        /// Перенная хранящая адресс датчика температуры
        /// </summary>
        private byte _slaveAddressThermometer = 2;

        /// <summary>
        /// Массив хранящий данные параметра контроллера
        /// </summary>
        private double[] _controllerParameters=new Double[7];

        public bool _thermometerFlag;

        private bool _controllerFlag;

        public int _typeInstallation;

        private SettingForm _settingForm = new SettingForm();

        public bool _accidentChecked = false;
        public MainForm()
        {
            Program._mainForm = this;
            InitializeComponent();
        }

        /// <summary>
        /// Вызывает окно настройки порта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettingСonnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = _settingForm.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            _typeInstallation = _settingForm._typeInstallation;
            _slaveAddress = _settingForm._slaveAddress;
            _port = _settingForm.Port;
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
                case 3:
                    CurrentNumericUpDown.Maximum = 120;
                    VoltageNumericUpDown.Maximum = 500;
                    PowerNumericUpDown.Maximum = 1110;
                    break;
            }

        }

        /// <summary>
        /// Подключение к контроллеру
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (!ControllerСheckBox.Checked && !ThermometeСheckBox.Checked)
            {
                MessageBox.Show("Не указаны подключённые устройства", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                _port.Open();
            }
            catch (UnauthorizedAccessException exception)
            {
                MessageBox.Show(this, exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Не указаны настройки подключения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //("Проверьте настройки подключения", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            catch (IOException exception)
            {
                MessageBox.Show(this, exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _masterRTU = ModbusSerialMaster.CreateRtu(_port);
            _masterRTU.Transport.ReadTimeout = 200;
           
            timer2.Enabled = true;
            ConnectButton.Enabled = false;
            DisableButton.Enabled = true;
            if (_controllerFlag)
            {
                StartButton.Enabled = true;
            }
            ParametrsGroupBox.Enabled = true;
            LaunchButton.Enabled = true;
            ResetButton.Enabled = false;
            ConnectedGroupBox.Enabled = false;
            _masterRTU.WriteSingleRegister(_slaveAddress, 0xA410, 2);
            timer1.Enabled = true;
            ManagementParameters(_controllerFlag);
            WorkParameters(_controllerFlag);
            
        }

        /// <summary>
        /// Отключение от контроллера 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisableButton_Click(object sender, EventArgs e)
        {
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

            timer2.Enabled = false;
            timer1.Enabled = false;
            ConnectButton.Enabled = true;
            DisableButton.Enabled = false;
            StartButton.Enabled = false;
            StopButton.Enabled = false;
            ResetButton.Enabled = false;
            LaunchButton.Enabled = false;
            ParametrsGroupBox.Enabled = false;
            ConnectedGroupBox.Enabled = true;
        }

        /// <summary>
        /// Вывоит значения параметров контроллера
        /// </summary>
        private async Task ControllerParametersAsync(bool flag1, bool flag2)
        {
            if (flag1||flag2)
            {
                timer1.Stop();
                try
                {
                    await Task.Run(() => { ControllerParameters(flag1, flag2); });
                }
                catch (InvalidOperationException)
                {
                    ConnectedGroupBox.Enabled = true;
                    return;
                }
                catch (Exception e)
                {
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    ConnectButton.Enabled = true;
                    DisableButton.Enabled = false;
                    StartButton.Enabled = false;
                    StopButton.Enabled = false;
                    ResetButton.Enabled = false;
                    LaunchButton.Enabled = false;
                    ParametrsGroupBox.Enabled = false;
                    ConnectedGroupBox.Enabled = true;
                    MessageBox.Show(e.Message,"Ошибка");
                    _port.Close();
                    return;
                }
                ShowTextBox();
                timer1.Start();
            }
        }
        
        private void ControllerParameters(bool flag1,bool flag2)
        {
            
            if (_port.IsOpen == false)
            {
                return;
            }
            ushort[] result;
            if (flag2)
            {
                ushort[] startAddress1 = { 0x0001, 0x0002 };
                ushort[] buffer = { 0, 0 };
                if (Sensor1СheckBox.Checked == true &&
                    Sensor2CheckBox.Checked == true)
                {

                    for (int i = 0; i <= 1; i++)
                    {
                        result = _masterRTU.ReadHoldingRegisters(_slaveAddressThermometer,
                            startAddress1[i], _numberOfPoints);
                        buffer[i] = result[0];

                    }
                    _controllerParameters[5] = checkBox1.Checked ? Convert.ToDouble(buffer[0]) / 10 : Convert.ToDouble(buffer[0]);
                    _controllerParameters[6] = checkBox1.Checked ? Convert.ToDouble(buffer[1]) / 10 : Convert.ToDouble(buffer[1]);
                    
                }
                else if (Sensor1СheckBox.Checked == true &&
                         Sensor2CheckBox.Checked == false)
                {
                    result = _masterRTU.ReadHoldingRegisters(_slaveAddressThermometer,
                        startAddress1[0], _numberOfPoints);
                    buffer[0] = result[0];

                    _controllerParameters[5] = checkBox1.Checked ? Convert.ToDouble(buffer[0]) / 10 : Convert.ToDouble(buffer[0]);
                    _controllerParameters[6] = 0;
                }
                else if (Sensor1СheckBox.Checked == false &&
                         Sensor2CheckBox.Checked == true)
                {

                    result = _masterRTU.ReadHoldingRegisters(_slaveAddressThermometer,
                        startAddress1[1], _numberOfPoints);
                    buffer[1] = result[0];
                    _controllerParameters[5] = 0;
                    _controllerParameters[6] = checkBox1.Checked ? Convert.ToDouble(buffer[1]) / 10 : Convert.ToDouble(buffer[1]);
                }
            }
            if (!flag1)
            {
                return;
            }
            ushort[] startAddress = {0xA430, 0xA432, 0xA433, 0xA434, 0xA437};
            string a;
            double e;
            for (int i = 0; i <= 4; i++)
            {
                result = _masterRTU.ReadHoldingRegisters(_slaveAddress, startAddress[i], _numberOfPoints);
                switch (i)
                {
                    case 0:
                        a = String.Concat<ushort>(result);
                        e = Convert.ToDouble(a) / 100;
                        _controllerParameters[i] = e;
                        break;
                    case 1:
                        a = String.Concat<ushort>(result);
                        e = Convert.ToDouble(a);
                        _controllerParameters[i] = e;
                        break;
                    case 2:
                        a = String.Concat<ushort>(result);
                        e = Convert.ToDouble(a);
                        _controllerParameters[i] = e;
                        break;
                    case 3:
                        a = string.Concat<ushort>(result);
                        e = Convert.ToDouble(a) / 10;
                        _controllerParameters[i] = e;
                        break;
                    case 4:
                        a = String.Concat<ushort>(result);
                        e = Convert.ToDouble(a) / 10;
                        _controllerParameters[i] = e;
                        break;
                }
            }
        }

        private void ShowTextBox()
        {
            FrequencyVoltageTextBox.Text = _controllerParameters[0].ToString();
            VoltageEntranceTextBox.Text = _controllerParameters[1].ToString();
            VoltageOutputTextBox.Text = _controllerParameters[2].ToString();
            CurrentOutputTextBox.Text = _controllerParameters[3].ToString();
            PowerOutputTextBox.Text = _controllerParameters[4].ToString();
            Thermometer1TextBox.Text = _controllerParameters[5].ToString();
            Thermometer2TextBox.Text = _controllerParameters[6].ToString();
        }

        /// <summary>
        /// Выводит параметры граничных условий работы ПЧ на экран
        /// </summary>
        private async Task WorkParameters(bool flag)
        {
            if (flag)
            {
                ushort[] startAddress = {0xA440, 0xA441, 0xa442, 0xa443, 0xA444};
                string a;
                double e;
                ushort[] result;
                string[] text = new string[5];
                try
                {
                    await Task.Run(() =>
                    {
                        for (int i = 0; i <= 4; i++)
                        {

                            result = _masterRTU.ReadHoldingRegisters(_slaveAddress, startAddress[i], _numberOfPoints);

                            switch (i)
                            {
                                case 0:
                                    text[i] = String.Concat<ushort>(result);
                                    break;
                                case 1:
                                    text[i] = String.Concat<ushort>(result);
                                    break;
                                case 2:
                                    a = String.Concat<ushort>(result);
                                    e = Convert.ToDouble(a) / 10;
                                    text[i] = e.ToString(); //String.Concat<ushort>(result);
                                    break;
                                case 3:
                                    a = String.Concat<ushort>(result);
                                    e = Convert.ToDouble(a) / 100;
                                    text[i] = e.ToString(); //String.Concat<ushort>(result);
                                    break;
                                case 4:
                                    a = String.Concat<ushort>(result);
                                    e = Convert.ToDouble(a) / 100;
                                    text[i] = e.ToString(); //String.Concat<ushort>(result);
                                    break;
                            }
                        }
                    });
                }
                catch (InvalidOperationException)
                {
                    timer1.Stop();
                    ConnectedGroupBox.Enabled = true;
                    return;
                }
                textBox14.Text = text[0];
                textBox13.Text = text[1];
                textBox12.Text = text[2];
                textBox11.Text = text[3];
                textBox10.Text = text[4];
                return;
            }
            textBox14.Text = "0";
            textBox13.Text = "0";
            textBox12.Text = "0";
            textBox11.Text = "0";
            textBox10.Text = "0";
        }

        /// <summary>
        /// Вывод данных управления параметров на экран
        /// </summary>
        private async void ManagementParameters(bool flag)
        {
            if (flag)
            {
                ushort[] startAddress = {0xA420, 0xa421, 0xa422};
                string a;
                double e;
                ushort[] result;
                await Task.Run(() =>
                {
                    Invoke((MethodInvoker) delegate
                    {
                        for (int i = 0; i <= 2; i++)
                        {
                            try
                            {
                                result = _masterRTU.ReadHoldingRegisters(_slaveAddress, startAddress[i],
                                    _numberOfPoints);
                            }
                            catch (InvalidOperationException)
                            {

                                timer1.Enabled = false;
                                ConnectedGroupBox.Enabled = true;

                                return;
                            }
                            catch (TimeoutException)
                            {

                                timer1.Enabled = false;
                                timer2.Enabled = false;
                                ConnectButton.Enabled = true;
                                DisableButton.Enabled = false;
                                StartButton.Enabled = false;
                                StopButton.Enabled = false;
                                ResetButton.Enabled = false;
                                LaunchButton.Enabled = false;
                                ParametrsGroupBox.Enabled = false;
                                _port.Close();
                                ConnectedGroupBox.Enabled = true;
                                MessageBox.Show("Время ожидания истекло. Проверьте настройки подключения", "Внимание",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }

                            switch (i)
                            {
                                case 0:
                                    CurrentNumericUpDown.Text = string.Empty;
                                    a = String.Concat<ushort>(result);
                                    e = Convert.ToDouble(a) / 10;
                                    CurrentNumericUpDown.Text = e.ToString(); // String.Concat<ushort>(result);
                                    break;
                                case 1:
                                    VoltageNumericUpDown.Text = string.Empty;
                                    VoltageNumericUpDown.Text = String.Concat<ushort>(result);
                                    break;
                                case 2:
                                    PowerNumericUpDown.Text = string.Empty;
                                    a = String.Concat<ushort>(result);
                                    e = Convert.ToDouble(a) / 10;
                                    PowerNumericUpDown.Text = e.ToString(); //String.Concat<ushort>(result);
                                    break;
                            }
                        }
                    });
                });
            }
        }

        /// <summary>
        /// Запись данных в регистры управления параметров работы ПЧ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void WriteRegisterButton_Click(object sender, EventArgs e)
        {
           await WriteRegister(CurrentNumericUpDown.Text, VoltageNumericUpDown.Text, PowerNumericUpDown.Text);
        }

        /// <summary>
        /// Функция записи данных в регистр
        /// </summary>
        /// <param name="current"></param>
        /// <param name="power"></param>
        public async Task WriteRegister(string current, string voltage, string power)
        {
            try
            {
                ushort[] startAddress = { 0xA420, 0xa421, 0xa422 };
                ushort value;
                await Task.Run(() =>
                {
                    Invoke((MethodInvoker)delegate
                    {
                        for (int i = 0; i <= 2; i++)
                        {
                            switch (i)
                            {
                                case 0:
                                    value = (ushort)(Convert.ToUInt16(current) * Convert.ToUInt16(10));
                                    try
                                    {
                                        _masterRTU.WriteSingleRegister(_slaveAddress, startAddress[i], value);
                                    }
                                    catch (InvalidOperationException)
                                    {
                                        timer1.Enabled = false;
                                        ConnectedGroupBox.Enabled = true;
                                        return;
                                    }

                                    break;
                                case 1:

                                    value = Convert.ToUInt16(voltage);
                                    try
                                    {
                                        _masterRTU.WriteSingleRegister(_slaveAddress, startAddress[i], value);
                                    }
                                    catch (InvalidOperationException)
                                    {
                                        timer1.Enabled = false;
                                        ConnectedGroupBox.Enabled = true;
                                        return;
                                    }
                                    break;
                                case 2:
                                    value = (ushort)(Convert.ToUInt16(power) * Convert.ToUInt16(10));
                                    try
                                    {
                                        _masterRTU.WriteSingleRegister(_slaveAddress, startAddress[i], value);
                                    }
                                    catch (InvalidOperationException)
                                    {
                                        timer1.Enabled = false;
                                        ConnectedGroupBox.Enabled = true;
                                        return;
                                    }

                                    break;
                            }
                        }
                    });
                });
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
        private async void StartButton_Click(object sender, EventArgs e)
        { 
            timer1.Stop();
            await StartStopController(true);
            timer1.Start();
        }

        /// <summary>
        /// Включает/Выключает установку
        /// </summary>
        /// <param name="variable"></param>
        public async Task StartStopController(bool variable)
        {
            ushort startAddress = 0xA410;
            ushort value;
            if (variable)
            {
                value = Convert.ToUInt16(1);
                try
                {
                    await Task.Run(() =>
                    {
                        _masterRTU.WriteSingleRegister(_slaveAddress, startAddress, value);
                    });

                }
                catch (InvalidOperationException)
                {
                    timer1.Enabled = false;
                    ConnectedGroupBox.Enabled = true;
                    return;
                }

                StopButton.Enabled = true;
                StartButton.Enabled = false;
                WriteRegisterButton.Enabled = false;
                CurrentNumericUpDown.ReadOnly = true;
                PowerNumericUpDown.ReadOnly = true;
                VoltageNumericUpDown.ReadOnly = true;
                SatusControllerAsync(_thermometerFlag);
            }
            else
            {
                value = Convert.ToUInt16(0);
                try
                {
                    await Task.Run(() =>
                    {
                        _masterRTU.WriteSingleRegister(_slaveAddress, startAddress, value);
                    });
                }
                catch (InvalidOperationException)
                {
                    timer1.Enabled = false;
                    ConnectedGroupBox.Enabled = true;
                    return;
                }

                StopButton.Enabled = false;
                StartButton.Enabled = true;
                WriteRegisterButton.Enabled = true;
                CurrentNumericUpDown.ReadOnly = false;
                PowerNumericUpDown.ReadOnly = false;
                VoltageNumericUpDown.ReadOnly = false;
                SatusControllerAsync(_controllerFlag);
            }
        }

        /// <summary>
        /// Запускает таймер 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void timer1_Tick(object sender, EventArgs e)
        {
            await ControllerParametersAsync(_controllerFlag, _thermometerFlag);
            await SatusControllerAsync(_controllerFlag);
        }

        /// <summary>
        /// Выводит состояние контроллера
        /// </summary>
        private async Task SatusControllerAsync(bool flag)
        {
            if (flag)
            {
                timer1.Stop();
                string text = "";
                try
                {
                    await Task.Run(() => { text = StatusController(); });
                }
                catch (InvalidOperationException)
                {
                    timer1.Enabled = false;
                    ConnectedGroupBox.Enabled = true;
                    return;
                }

                StatusBox.Text = text;
                timer1.Start();
            }
        }

        public string StatusController()
        {
            ushort startAddress = 0xA411;
            ushort[] result;
            string text = "";
            result = _masterRTU.ReadHoldingRegisters(_slaveAddress, startAddress, _numberOfPoints);
            switch (result[0])
            {
                case 0:
                    text = "Установка выключена";
                    break;
                case 1:
                    text = "Установка включена";
                    break;
                case 2:
                    ushort startAddress1 = 0xA412;
                    ushort[] result1 =
                        _masterRTU.ReadHoldingRegisters(_slaveAddress, startAddress1, _numberOfPoints);

                    ushort startAddress2 = 0xA413;
                    ushort[] result2 =
                        _masterRTU.ReadHoldingRegisters(_slaveAddress, startAddress2, _numberOfPoints);
                    text = $"Авария!" +
                           $"\r\nРегистры аварий:" +
                           $"\r\n0xA412: {Convert.ToString(result1[0], 2)}" +
                           $"\r\n0xA413: {Convert.ToString(result2[0], 2)}";
                    break;
            }
            return text;
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
        /// Выключает установку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void StopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            await StartStopController(false);
            timer1.Start();
        }

        /// <summary>
        /// Сброс аварии
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ResetButton_Click(object sender, EventArgs e)
        {
            ushort startAddress = 0xA410;
            ushort value = Convert.ToUInt16(2);
            try
            {
                await Task.Run(() => { _masterRTU.WriteSingleRegister(_slaveAddress, startAddress, value); });
            }
            catch (InvalidOperationException)
            {
                timer1.Enabled = false;
                return;
            }

            timer1.Enabled = true;
            await SatusControllerAsync(_controllerFlag);
            if (!StatusBox.Text.Contains("Авария"))
            {
                ResetButton.Enabled = false;
                StopButton.Enabled = false;
                StartButton.Enabled = true;
                LaunchButton.Enabled = true;
                WriteRegisterButton.Enabled = true;
                _accidentChecked = false;
            }
        }

        /// <summary>
        /// Запуск тестирования
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LaunchButton_Click(object sender, EventArgs e)
        {
            
            if (_port == null) 
            {
                MessageBox.Show("Проверьте настройки подключения", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            //TimeTest();
            var testing = new TestingForm();
            testing.Owner = this;
            testing._controllerParameters = _controllerParameters;
            //testing._timeRemeining = _timeTest;

            if (Application.OpenForms.OfType<TestingForm>().Count() == 0)
            {
                LaunchButton.Enabled = false;
                testing.Show();
            }
            //Testing();

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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (_port.IsOpen == false)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                ConnectButton.Enabled = true;
                DisableButton.Enabled = false;
                StartButton.Enabled = false;
                StopButton.Enabled = false;
                ResetButton.Enabled = false;
                LaunchButton.Enabled = false;
                ParametrsGroupBox.Enabled = false;
                ConnectedGroupBox.Enabled = true;
                _port.Close();
                MessageBox.Show("Потеря соединения", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void StatusBox_TextChanged(object sender, EventArgs e)
        {
            if (StatusBox.Text.Contains("Авария"))
            {
                StartButton.Enabled = false;
                StopButton.Enabled = false;
                ResetButton.Enabled = true;
                _accidentChecked = true;
            }

            StatusBox.SelectionLength = 0;
        }

        private void ThermometeСheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ThermometeСheckBox.Checked)
            {
                ThermometerGroupBox.Enabled = true;
                _thermometerFlag = true;
            }
            else
            {
                ThermometerGroupBox.Enabled = false;
                _thermometerFlag = false;
            }
        }

        private void ControllerСheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ControllerСheckBox.Checked)
            {
                _controllerFlag = true;
            }
            else
            {
                _controllerFlag = false;
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }
    }

}
