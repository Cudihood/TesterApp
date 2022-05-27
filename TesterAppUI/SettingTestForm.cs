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
    public partial class SettingTestForm : Form
    {
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
        /// Переменная для обновления времени
        /// </summary>
        public DateTime _timeNull = new DateTime(0, 0);

        /// <summary>
        /// Переменная хранящая колличество периодов;
        /// </summary>
        public int _numberPeriodsNumeric = 1;
        
        

        public int _typeTest;
        public int _typeInstallation;
        public SettingTestForm()
        {
            InitializeComponent();
        }

        private void SettingTestForm_Load(object sender, EventArgs e)
        {
            _timeStart = _timeNull;
            _timeStop = _timeNull;
            _timeTest = _timeNull;
        }

        /// <summary>
        /// Проверяет указанно ли время работы установки
        /// </summary>
        private void CheckData()
        {
            if (TypeTestComboBox.SelectedIndex == -1)
            {
                throw new ArgumentException("Не выбран тип испытания");
            }
            switch (TypeTestComboBox.SelectedIndex)
            {
                case 0:
                    if (TimeOffNumericUpDown.Value == 0
                        || TimeOnNumericUpDown.Value == 0)
                    {
                        throw new ArgumentException("Не указанно время работы");
                    }
                    break;
                case 1:
                    if (TimeOffNumericUpDown.Value == 0
                        || TimeOnNumericUpDown.Value == 0)
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
                    _timeStart = _timeTest.AddSeconds(Convert.ToDouble(TimeOnNumericUpDown.Text));
                    _timeStop = _timeTest.AddSeconds(Convert.ToDouble(TimeOffNumericUpDown.Text));
                    _timeTest = _timeTest.AddSeconds(Convert.ToDouble(TimeOffNumericUpDown.Text)
                                                     + Convert.ToDouble(TimeOnNumericUpDown.Text));
                    break;
                case 1:
                    _timeStart = _timeTest.AddSeconds(Convert.ToDouble(TimeOnNumericUpDown.Text));
                    _timeStop = _timeTest.AddSeconds(Convert.ToDouble(TimeOffNumericUpDown.Text));
                    double value = (Convert.ToDouble(TimeOffNumericUpDown.Text)
                                    + Convert.ToDouble(TimeOnNumericUpDown.Text)) * Convert.ToDouble(NumberPeriodsNumericUpDown.Text);
                    _timeTest = _timeTest.AddSeconds(value);
                    _numberPeriodsNumeric = Convert.ToInt32(NumberPeriodsNumericUpDown.Text);
                    break;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                CheckData();
                TimeTest();
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK);
                return;
            }
            
        }

        private void TimeOnNumericUpDown_MouseClick(object sender, MouseEventArgs e)
        {
            TimeOnNumericUpDown.Select(0, TimeOnNumericUpDown.Value.ToString().Length);
        }

        private void TimeOffNumericUpDown_MouseClick(object sender, MouseEventArgs e)
        {
            TimeOnNumericUpDown.Select(0, TimeOnNumericUpDown.Value.ToString().Length);
        }

        private void NumberPeriodsNumericUpDown_MouseClick(object sender, MouseEventArgs e)
        {
            NumberPeriodsNumericUpDown.Select(0, NumberPeriodsNumericUpDown.Value.ToString().Length);
        }

        private void TypeTestComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TypeTestComboBox.SelectedIndex)
            {
                case 0:
                    NumberPeriodsNumericUpDown.Enabled = false;
                    TestsGroupBox.Enabled = true;
                    _typeTest = 0;
                    break;
                case 1:
                    NumberPeriodsNumericUpDown.Enabled = true;
                    TestsGroupBox.Enabled = true;
                    _typeTest = 1;
                    break;
            }
        }

        private void CancleButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
