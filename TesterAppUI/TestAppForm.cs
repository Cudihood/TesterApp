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

namespace TesterAppUI
{
    public partial class TestAppForm : Form
    {

        private ModbusRTUProtocol objModbusRtuProtocol;

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
            SerialPort port = new SerialPort(PortsComboBox.Text, 9600, Parity.None, 8, StopBits.One); ;
            objModbusRtuProtocol.Port = port;
            objModbusRtuProtocol.SlaveAddress = Convert.ToByte(SlaveAddressTextBox.Text);
            objModbusRtuProtocol.StartAddress = Convert.ToUInt16(StartAddresTextBox.Text);
            objModbusRtuProtocol.NumberOfPoints = Convert.ToUInt32(NumberOfPointsTextBox.Text);
            objModbusRtuProtocol.Port.Open();
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ReadRadioButton.Checked == true)
                {
                    objModbusRtuProtocol.Function = 3;
                }
                AddressLabel.DataBindings.Add("Text", objModbusRtuProtocol.Registers[0], "Address", 
                    true, DataSourceUpdateMode.OnPropertyChanged);

                ValueTextBox.DataBindings.Add(new Binding("Text", objModbusRtuProtocol.Registers[0], "Value", 
                    true, DataSourceUpdateMode.OnPropertyChanged));

                objModbusRtuProtocol.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
