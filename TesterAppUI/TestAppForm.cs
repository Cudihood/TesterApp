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
    public partial class TestAppForm : Form
    {
        //private ModbusRTUProtocol objModbusRtuProtocol = new ModbusRTUProtocol();
 
        private SerialPort port;
        private IModbusMaster masrerRTU;
        private byte slaveAddress;
        private ushort startAddress;
        private ushort numberOfPoints;

        public TestAppForm()
        {
            InitializeComponent();
        }

        private void TesterAppForm_Load(object sender, EventArgs e)
        {
            //чтение портов доступных в системе
            string[] ports = SerialPort.GetPortNames();

            //Очистка содержимого бокса
            PortsComboBox.Items.Clear();
            //Добавление найденных портов в бокс
            PortsComboBox.Items.AddRange(ports);
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            /*
            objModbusRtuProtocol.Port = port;
            objModbusRtuProtocol.SlaveAddress = Convert.ToByte(SlaveAddressTextBox.Text);
            objModbusRtuProtocol.StartAddress = Convert.ToUInt16(StartAddresTextBox.Text, 16); 
            objModbusRtuProtocol.NumberOfPoints = Convert.ToUInt32(NumberOfPointsTextBox.Text);
            objModbusRtuProtocol.Port.Open();
            */
            try
            {
                port = new SerialPort(PortsComboBox.Text, 9600, Parity.None, 8, StopBits.One);
                port.Open();

                slaveAddress = Convert.ToByte(SlaveAddressTextBox.Text);
                startAddress = Convert.ToUInt16(StartAddresTextBox.Text, 16);
                numberOfPoints = Convert.ToUInt16(NumberOfPointsTextBox.Text);

                masrerRTU = ModbusSerialMaster.CreateRtu(port); 

                OpenButton.Enabled = false;
                CloseButton.Enabled = true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            try
            {
                startAddress = Convert.ToUInt16(StartAddresTextBox.Text, 16);
                ushort[] result = masrerRTU.ReadHoldingRegisters(slaveAddress, startAddress, numberOfPoints);
                GetTextBox.Text = string.Empty;
                foreach (ushort item in result)
                {
                    GetTextBox.Text += item.ToString();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            /* 
             try
             {
                 if (ReadRadioButton.Checked == true)
                 {
                     objModbusRtuProtocol.Function = 3;
                 } 
                 AddressLabel.DataBindings.Add("Text", objModbusRtuProtocol.Registers[0], "Address", 
                     true, DataSourceUpdateMode.OnPropertyChanged);

                 ValueTextBox.DataBindings.Add("Text", objModbusRtuProtocol.Registers[0], "Value",
                     true, DataSourceUpdateMode.OnPropertyChanged);

                 objModbusRtuProtocol.Start();
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
            */
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            //objModbusRtuProtocol.Port.Close();
            port.Close();
            OpenButton.Enabled = true;
            CloseButton.Enabled = false;
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            try
            {
                startAddress = Convert.ToUInt16(StartAddresTextBox.Text, 16);
                ushort value = Convert.ToUInt16(SetTextBox.Text);
                masrerRTU.WriteSingleRegister(slaveAddress, startAddress, value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
