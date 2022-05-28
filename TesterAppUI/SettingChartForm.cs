using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesterAppUI
{
    public partial class SettingChartForm : Form
    {
        /// <summary>
        /// Интервал оси ОХ
        /// </summary>
        public double _intervalX;

        public double _intervalFrequency;

        public double _intervalVoltageEntrance;

        public double _intervalVoltageOutput;

        public double _intervalCurrent;

        public double _intervalPower;

        public double _intervalThermometer1;

        public double _intervalThermometer2;
        public SettingChartForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            _intervalX = (double) IntervalXNumericUpDown.Value;
            _intervalFrequency = (double) FrequencyNumericUpDown.Value;
            _intervalVoltageEntrance = (double) VoltageEntranceNumericUpDown.Value;
            _intervalVoltageOutput = (double) VoltageOutputNumericUpDown.Value;
            _intervalCurrent = (double) CurrentNumericUpDown.Value;
            _intervalPower = (double) PowerNumericUpDown.Value;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ChanclButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
