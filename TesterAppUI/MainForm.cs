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
        private SerialPort _port; 
        public IModbusMaster _masrerRTU;
        private byte _slaveAddress = 10;
        private ushort _numberOfPoints = 1;
        private byte _slaveAddressThermometer = 10;
        private string[] _controllerParameters=new string[5];

        public MainForm()
        {
            InitializeComponent();
        }

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
            try
            {
                _port.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //("Проверьте настройки подключения", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            _masrerRTU = ModbusSerialMaster.CreateRtu(_port);

            ConnectButton.Enabled = false;
            DisableButton.Enabled = true;
            StartButton.Enabled = true;
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
            try
            {
                _port.Close();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Не выбранны настройки подключения", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            ConnectButton.Enabled = true;
            DisableButton.Enabled = false;
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
                switch (i)
                {
                    case 0:
                        textBox7.Text = string.Empty;
                        textBox7.Text = String.Concat<ushort>(result);
                        _controllerParameters[i] = textBox7.Text;
                        break;
                    case 1:
                        textBox6.Text = string.Empty;
                        textBox6.Text = String.Concat<ushort>(result);
                        _controllerParameters[i] = textBox6.Text;
                        break;
                    case 2:
                        textBox5.Text = string.Empty;
                        textBox5.Text = String.Concat<ushort>(result);
                        _controllerParameters[i] = textBox5.Text;
                        break;
                    case 3:
                        textBox8.Text = string.Empty;
                        textBox8.Text = String.Concat<ushort>(result);
                        _controllerParameters[i] = textBox8.Text;
                        break;
                    case 4:
                        textBox9.Text = string.Empty;
                        textBox9.Text = String.Concat<ushort>(result);
                        _controllerParameters[i] = textBox9.Text;
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
                        textBox12.Text = String.Concat<ushort>(result);
                        break;
                    case 3:
                        textBox11.Text = string.Empty;
                        textBox11.Text = String.Concat<ushort>(result);
                        break;
                    case 4:
                        textBox10.Text = string.Empty;
                        textBox10.Text = String.Concat<ushort>(result);
                        break;
                }
                
                /* Вывод не рабочик регистров a449, a44a, a450
                if (i == 3)
                {
                    textBox11.Text = string.Empty;
                    //textBox11.Text = String.Concat<ushort>(result);
                    foreach (ushort item in result)
                    {
                        textBox7.Text += item.ToString();
                    }
                }

                if (i == 4)
                {
                    textBox10.Text = string.Empty;
                    //textBox10.Text = String.Concat<ushort>(result);
                    foreach (ushort item in result)
                    {
                        textBox10.Text += item.ToString();
                    }
                }

                if (i == 5)
                {
                    textBox15.Text = string.Empty;
                    //textBox15.Text = String.Concat<ushort>(result);
                    foreach (ushort item in result)
                    {
                        textBox15.Text += item.ToString();
                    }
                }
                */

            }

        }

        /// <summary>
        /// Вывод данных управления параметров на экран
        /// </summary>
        private void ManagementParameters()
        {
            ushort[] startAddress = {0xA420, 0xa421, 0xa422};

            for (int i = 0; i <= 2; i++)
            {
                ushort[] result = _masrerRTU.ReadHoldingRegisters(_slaveAddress, startAddress[i], _numberOfPoints);

                switch (i)
                {
                    case 0:
                        textBox2.Text = string.Empty;
                        textBox2.Text = String.Concat<ushort>(result);
                        break;
                    case 1:
                        textBox3.Text = string.Empty;
                        textBox3.Text = String.Concat<ushort>(result);
                        break;
                    case 2:
                        textBox4.Text = string.Empty;
                        textBox4.Text = String.Concat<ushort>(result);
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
                            value = Convert.ToUInt16(textBox2.Text);
                            _masrerRTU.WriteSingleRegister(_slaveAddress, startAddress[i], value);
                            break;
                        case 1:
                            value = Convert.ToUInt16(textBox3.Text);
                            ///значения в регистр а421 не записывается!!!!!
                            _masrerRTU.WriteSingleRegister(_slaveAddress, startAddress[i], value);
                            break;
                        case 2:
                            value = Convert.ToUInt16(textBox4.Text);
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

        

        private void StartButton_Click(object sender, EventArgs e)
        {
            ushort startAddress = 0xA410;
            ushort value = Convert.ToUInt16(1);
            _masrerRTU.WriteSingleRegister(_slaveAddress, startAddress, value);
            timer1.Enabled = true;
            StopButton.Enabled = true;
            ResetButton.Enabled = true;
            StartButton.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ControllerParameters();
            WorkParameters();
            ManagementParameters();
            SatusController();
        }


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

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }

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

        private void StopButton_Click(object sender, EventArgs e)
        {
            ushort startAddress = 0xA410;
            ushort value = Convert.ToUInt16(0);
            _masrerRTU.WriteSingleRegister(_slaveAddress, startAddress, value);
            timer1.Enabled = false;
            StopButton.Enabled = false;
            ResetButton.Enabled = false;
            StartButton.Enabled = true;
        }

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

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            DateTime timeTest = new DateTime(0, 0);
            double a = Convert.ToDouble(TimeOffTextBox.Text);
            timeTest = timeTest.AddMinutes(Convert.ToDouble(TimeOffTextBox.Text)+ Convert.ToDouble(TimeOnTextBox.Text));

            if (_port.IsOpen == false) 
            {
                MessageBox.Show("Проверьте настройки подключения", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            var testing = new TestingForm();
            testing._controllerParameters = _controllerParameters;
            testing._date2 = timeTest;
            testing.ShowDialog();
            var result = testing.DialogResult;
            if (result != DialogResult.OK)
            {
                return;
            }
            
        }
    }

}
