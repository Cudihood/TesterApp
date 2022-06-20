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

        public double[] _interval;

        public double[] _maxValue;


        public SettingChartForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            _intervalX = (double) IntervalXNumericUpDown.Value;
            _interval[0] = (double) FrequencyNumericUpDown.Value;
            _interval[1] = (double) VoltageEntranceNumericUpDown.Value;
            _interval[2] = (double) VoltageOutputNumericUpDown.Value;
            _interval[3] = (double) CurrentNumericUpDown.Value;
            _interval[4] = (double) PowerNumericUpDown.Value;
            _interval[5] = (double) Thermometer1NumericUpDown.Value;
            _interval[6] = (double) Thermometer2NumericUpDown.Value;

            _maxValue[0] = (double)MaxFrequencyNumericUpDown.Value;
            _maxValue[1] = (double)MaxVoltageEntranceNumericUpDown.Value;
            _maxValue[2] = (double)MaxVoltageOutputNumericUpDown.Value;
            _maxValue[3] = (double)MaxCurrentNumericUpDown.Value;
            _maxValue[4] = (double)MaxPowerNumericUpDown.Value;
            _maxValue[5] = (double)MaxThermometer1NumericUpDown.Value;
            _maxValue[6] = (double)MaxThermometer2NumericUpDown.Value;
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
