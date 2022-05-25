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
        public SettingTestForm()
        {
            InitializeComponent();
        }

        private void SettingTestForm_Load(object sender, EventArgs e)
        {

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
        private void OkButton_Click(object sender, EventArgs e)
        {
            CheckData();
            DialogResult = DialogResult.OK;
            Close();
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
                    NumberPeriodsNumericUpDown.Enabled = true;
                    break;
                case 1:
                    NumberPeriodsNumericUpDown.Enabled = false;
                    break;
            }
        }

    }
}
