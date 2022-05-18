using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp;
using Modbus.Device;
using Modbus.Utility;

namespace TesterAppUI
{
    public partial class SettingForm : Form
    {
        
 
        private SerialPort _port;
        public SettingForm()
        {
            InitializeComponent();        
            _port = new SerialPort();
        }

        private void TesterAppForm_Load(object sender, EventArgs e)
        {
            //чтение портов доступных в системе
            string[] ports = SerialPort.GetPortNames();

            //Очистка содержимого бокса
            PortsComboBox.Items.Clear();
            //Добавление найденных портов в бокс
            PortsComboBox.Items.AddRange(ports);
            if (PortsComboBox.Items.Count == 0)
            {
                MessageBox.Show("Нет доступных портов.", "Внимание!", MessageBoxButtons.OK);
            }
            else
            {
                PortsComboBox.SelectedIndex = 0;
            }
            BaudRateComboBox.SelectedIndex = 3;
            DataBitsComboBox.SelectedIndex = 1;
            ParityComboBox.SelectedIndex = 0;
            StopBitsСomboBox.SelectedIndex = 0;
        }

        /*
        /// <summary>
        /// Возвращает и задает адрес устройства
        /// </summary>
        public byte SlaveAddress
        {
            get
            {
                return slaveAddress;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Пустая строка");
                }

                if (value < 0 || value > 255) 
                {
                    throw new ArgumentException("Адрес устройства может принимать значение от 0 до 255"); 
                }
                else
                {
                    slaveAddress = value;
                }
            }
        }
        */
        /*
        /// <summary>
        /// Возвращает и задет адрес регистра
        /// </summary>
        public ushort StartAddress
        {
            get
            {
                return startAddress;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Пустая строка");
                }

                if (value < 0 || value > 0xFFFF) 
                {
                    throw new ArgumentException("Адрес регистра может принимать значение от 0 до FFFF");
                }
                else
                {
                    startAddress = value;
                }
            }
        }
        */
        /*
        /// <summary>
        /// Возвращает и задает количество регистров 
        /// </summary>
        public ushort NumberOfPoints
        {
            get
            {
                return numberOfPoints;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Пустая строка");
                }

                if (value > 9999 || value < 1) 
                {
                    throw new ArgumentException("Неверное количество регистров.\nМаксимальное количество: 9999.");
                }
                
                else
                {
                    numberOfPoints = value;
                }
            }
        }
        */

        public SerialPort Port
        {
            get { return _port;}

            set
            {
                _port = value;
                if (_port == null)
                {
                    return;
                }
            }
        }
        
        /// <summary>
        /// Открывет порт
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                _port.PortName = PortsComboBox.Text;
                _port.BaudRate = Convert.ToInt32(BaudRateComboBox.Text);

                if (ParityComboBox.Text.Substring(0, 1) == "0")
                {
                    _port.Parity = Parity.None;
                }
                else if (ParityComboBox.Text.Substring(0, 1) == "1")
                {
                    _port.Parity = Parity.Odd;
                }
                else if (ParityComboBox.Text.Substring(0, 1) == "2")
                {
                    _port.Parity = Parity.Even;
                }

                if (StopBitsСomboBox.Text == "0")
                {
                    _port.StopBits = StopBits.One;
                }
                else if(StopBitsСomboBox.Text == "1")
                {
                    _port.StopBits = StopBits.Two;
                }

                DialogResult = DialogResult.OK;
                Close();

            }
            catch (ArgumentException exception)
            {
                MessageBox.Show($"{exception.Message}", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            catch (FormatException)
            {
                MessageBox.Show("Строка должна содержать только цифры.", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        /*
        /// <summary>
        /// Получение данных с регистра
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetButton_Click(object sender, EventArgs e)
        {
            try
            {
                StartAddress = Convert.ToUInt16(StartAddressTextBox.Text, 16);
                ushort[] result = masrerRTU.ReadHoldingRegisters(SlaveAddress, StartAddress, NumberOfPoints);
                GetTextBox.Text = string.Empty;
                foreach (ushort item in result)
                {
                    GetTextBox.Text += item.ToString();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           
        }
        */
        
        /// <summary>
        /// Отмена настроик
        /// </summary>
        /// <param name="sender"></paОтмена настроик// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


        /*
        /// <summary>
        /// Запись данных в регистр 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetButton_Click(object sender, EventArgs e)
        {
            try
            {
                StartAddress = Convert.ToUInt16(StartAddressTextBox.Text, 16);
                ushort value = Convert.ToUInt16(SetTextBox.Text);
                masrerRTU.WriteSingleRegister(SlaveAddress, StartAddress, value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Проверка на ввод адреса устройства
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SlaveAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SlaveAddress = Convert.ToByte(SlaveAddressTextBox.Text);
                SlaveAddressTextBox.BackColor=Color.White;
            }
            catch
            {
                SlaveAddressTextBox.BackColor = Color.LightPink;
            }
            
        }
        
        private void StartAddresTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                StartAddress = Convert.ToUInt16(StartAddressTextBox.Text, 16);
                StartAddressTextBox.BackColor = Color.White;
            }
            catch
            {
                StartAddressTextBox.BackColor = Color.LightPink;
            }
        }

        private void NumberOfPointsTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NumberOfPoints = Convert.ToUInt16(NumberOfPointsTextBox.Text, 16);
                NumberOfPointsTextBox.BackColor = Color.White;
            }
            catch
            {
                NumberOfPointsTextBox.BackColor = Color.LightPink;
            }
        }
        */
    }
}
