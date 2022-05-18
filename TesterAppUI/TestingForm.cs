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

        public DateTime _date1 = new DateTime(0, 0);
        public DateTime _date2;
        public string[] _controllerParameters;
        

        private void TestingForm_Load(object sender, EventArgs e)
        {
            
            VoltageFrequency();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ControllerParameters();
            _date1 = _date1.AddSeconds(1);
            TimeTestTextBox.Text = _date1.ToString("HH:mm:ss");
            

            VoltageFrequencyChart.Series[0].Points.AddXY(_date1, _controllerParameters[0]);
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
                        textBox7.Text = string.Empty;
                        textBox7.Text = _controllerParameters[i];
                        break;
                    case 1:
                        textBox6.Text = string.Empty;
                        textBox6.Text = _controllerParameters[i];
                        break;
                    case 2:
                        textBox5.Text = string.Empty;
                        textBox5.Text = _controllerParameters[i];
                        break;
                    case 3:
                        textBox8.Text = string.Empty;
                        textBox8.Text = _controllerParameters[i];
                        break;
                    case 4:
                        textBox9.Text = string.Empty;
                        textBox9.Text = _controllerParameters[i];
                        break;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void VoltageFrequency()
        {
            VoltageFrequencyChart.ChartAreas[0].AxisY.Maximum = 6000;
            VoltageFrequencyChart.ChartAreas[0].AxisY.Minimum = 0;

            VoltageFrequencyChart.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
            VoltageFrequencyChart.Series[0].XValueType = ChartValueType.DateTime;

            VoltageFrequencyChart.ChartAreas[0].AxisX.Minimum = _date1.ToOADate();
            VoltageFrequencyChart.ChartAreas[0].AxisX.Maximum = _date2.ToOADate();

            VoltageFrequencyChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Minutes;
            VoltageFrequencyChart.ChartAreas[0].AxisX.Interval = 10;
        }
    }
}
