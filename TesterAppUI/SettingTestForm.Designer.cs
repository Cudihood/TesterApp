﻿
namespace TesterAppUI
{
    partial class SettingTestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ParametersTestGroupBox = new System.Windows.Forms.GroupBox();
            this.label41 = new System.Windows.Forms.Label();
            this.TypeInstallationComboBox = new System.Windows.Forms.ComboBox();
            this.TestsGroupBox = new System.Windows.Forms.GroupBox();
            this.NumberPeriodsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TimeOffNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TimeOnNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.ThermometerGroupBox = new System.Windows.Forms.GroupBox();
            this.ThermometerOnRadioButton = new System.Windows.Forms.RadioButton();
            this.ThermometerOffRadioButton = new System.Windows.Forms.RadioButton();
            this.label27 = new System.Windows.Forms.Label();
            this.TypeTestComboBox = new System.Windows.Forms.ComboBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancleButton = new System.Windows.Forms.Button();
            this.ParametersTestGroupBox.SuspendLayout();
            this.TestsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberPeriodsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeOffNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeOnNumericUpDown)).BeginInit();
            this.ThermometerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParametersTestGroupBox
            // 
            this.ParametersTestGroupBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ParametersTestGroupBox.Controls.Add(this.label41);
            this.ParametersTestGroupBox.Controls.Add(this.TypeInstallationComboBox);
            this.ParametersTestGroupBox.Controls.Add(this.TestsGroupBox);
            this.ParametersTestGroupBox.Controls.Add(this.ThermometerGroupBox);
            this.ParametersTestGroupBox.Controls.Add(this.label27);
            this.ParametersTestGroupBox.Controls.Add(this.TypeTestComboBox);
            this.ParametersTestGroupBox.Enabled = false;
            this.ParametersTestGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ParametersTestGroupBox.Name = "ParametersTestGroupBox";
            this.ParametersTestGroupBox.Size = new System.Drawing.Size(314, 224);
            this.ParametersTestGroupBox.TabIndex = 24;
            this.ParametersTestGroupBox.TabStop = false;
            this.ParametersTestGroupBox.Text = "Параметры испытания:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(6, 49);
            this.label41.Margin = new System.Windows.Forms.Padding(3);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(84, 13);
            this.label41.TabIndex = 24;
            this.label41.Text = "Тип установки:";
            // 
            // TypeInstallationComboBox
            // 
            this.TypeInstallationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeInstallationComboBox.FormattingEnabled = true;
            this.TypeInstallationComboBox.Items.AddRange(new object[] {
            "IHM-15",
            "IHM-25",
            "IHM-30"});
            this.TypeInstallationComboBox.Location = new System.Drawing.Point(96, 46);
            this.TypeInstallationComboBox.Name = "TypeInstallationComboBox";
            this.TypeInstallationComboBox.Size = new System.Drawing.Size(210, 21);
            this.TypeInstallationComboBox.TabIndex = 23;
            // 
            // TestsGroupBox
            // 
            this.TestsGroupBox.BackColor = System.Drawing.Color.LimeGreen;
            this.TestsGroupBox.Controls.Add(this.NumberPeriodsNumericUpDown);
            this.TestsGroupBox.Controls.Add(this.TimeOffNumericUpDown);
            this.TestsGroupBox.Controls.Add(this.TimeOnNumericUpDown);
            this.TestsGroupBox.Controls.Add(this.label28);
            this.TestsGroupBox.Controls.Add(this.label33);
            this.TestsGroupBox.Controls.Add(this.label36);
            this.TestsGroupBox.Controls.Add(this.label38);
            this.TestsGroupBox.Controls.Add(this.label40);
            this.TestsGroupBox.Enabled = false;
            this.TestsGroupBox.Location = new System.Drawing.Point(6, 120);
            this.TestsGroupBox.Name = "TestsGroupBox";
            this.TestsGroupBox.Size = new System.Drawing.Size(300, 96);
            this.TestsGroupBox.TabIndex = 22;
            this.TestsGroupBox.TabStop = false;
            this.TestsGroupBox.Text = "Время испытания";
            // 
            // NumberPeriodsNumericUpDown
            // 
            this.NumberPeriodsNumericUpDown.Location = new System.Drawing.Point(200, 69);
            this.NumberPeriodsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberPeriodsNumericUpDown.Name = "NumberPeriodsNumericUpDown";
            this.NumberPeriodsNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.NumberPeriodsNumericUpDown.TabIndex = 36;
            this.NumberPeriodsNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumberPeriodsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberPeriodsNumericUpDown.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumberPeriodsNumericUpDown_MouseClick);
            // 
            // TimeOffNumericUpDown
            // 
            this.TimeOffNumericUpDown.Location = new System.Drawing.Point(200, 43);
            this.TimeOffNumericUpDown.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.TimeOffNumericUpDown.Name = "TimeOffNumericUpDown";
            this.TimeOffNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.TimeOffNumericUpDown.TabIndex = 35;
            this.TimeOffNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TimeOffNumericUpDown.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TimeOffNumericUpDown_MouseClick);
            // 
            // TimeOnNumericUpDown
            // 
            this.TimeOnNumericUpDown.Location = new System.Drawing.Point(200, 17);
            this.TimeOnNumericUpDown.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.TimeOnNumericUpDown.Name = "TimeOnNumericUpDown";
            this.TimeOnNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.TimeOnNumericUpDown.TabIndex = 34;
            this.TimeOnNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TimeOnNumericUpDown.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TimeOnNumericUpDown_MouseClick);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(265, 45);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(25, 13);
            this.label28.TabIndex = 33;
            this.label28.Text = "сек";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(265, 19);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(25, 13);
            this.label33.TabIndex = 32;
            this.label33.Text = "сек";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(6, 71);
            this.label36.Margin = new System.Windows.Forms.Padding(3);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(120, 13);
            this.label36.TabIndex = 27;
            this.label36.Text = "Количество периодов:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(6, 45);
            this.label38.Margin = new System.Windows.Forms.Padding(3);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(188, 13);
            this.label38.TabIndex = 24;
            this.label38.Text = "Время во выключенном состоянии:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(6, 19);
            this.label40.Margin = new System.Windows.Forms.Padding(3);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(180, 13);
            this.label40.TabIndex = 21;
            this.label40.Text = "Время во включенном состоянии:";
            // 
            // ThermometerGroupBox
            // 
            this.ThermometerGroupBox.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ThermometerGroupBox.Controls.Add(this.ThermometerOnRadioButton);
            this.ThermometerGroupBox.Controls.Add(this.ThermometerOffRadioButton);
            this.ThermometerGroupBox.ForeColor = System.Drawing.Color.Black;
            this.ThermometerGroupBox.Location = new System.Drawing.Point(6, 73);
            this.ThermometerGroupBox.Name = "ThermometerGroupBox";
            this.ThermometerGroupBox.Size = new System.Drawing.Size(300, 41);
            this.ThermometerGroupBox.TabIndex = 14;
            this.ThermometerGroupBox.TabStop = false;
            this.ThermometerGroupBox.Text = "Датчик температуры";
            // 
            // ThermometerOnRadioButton
            // 
            this.ThermometerOnRadioButton.AutoSize = true;
            this.ThermometerOnRadioButton.Location = new System.Drawing.Point(6, 18);
            this.ThermometerOnRadioButton.Name = "ThermometerOnRadioButton";
            this.ThermometerOnRadioButton.Size = new System.Drawing.Size(79, 17);
            this.ThermometerOnRadioButton.TabIndex = 12;
            this.ThermometerOnRadioButton.Text = "ВКЛЮЧЕН";
            this.ThermometerOnRadioButton.UseVisualStyleBackColor = true;
            // 
            // ThermometerOffRadioButton
            // 
            this.ThermometerOffRadioButton.AutoSize = true;
            this.ThermometerOffRadioButton.Checked = true;
            this.ThermometerOffRadioButton.Location = new System.Drawing.Point(91, 18);
            this.ThermometerOffRadioButton.Name = "ThermometerOffRadioButton";
            this.ThermometerOffRadioButton.Size = new System.Drawing.Size(89, 17);
            this.ThermometerOffRadioButton.TabIndex = 13;
            this.ThermometerOffRadioButton.TabStop = true;
            this.ThermometerOffRadioButton.Text = "ВЫКЛЮЧЕН";
            this.ThermometerOffRadioButton.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 22);
            this.label27.Margin = new System.Windows.Forms.Padding(3);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(67, 13);
            this.label27.TabIndex = 11;
            this.label27.Text = "Испытание:";
            // 
            // TypeTestComboBox
            // 
            this.TypeTestComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeTestComboBox.FormattingEnabled = true;
            this.TypeTestComboBox.Items.AddRange(new object[] {
            "ресурсное",
            "переодическое "});
            this.TypeTestComboBox.Location = new System.Drawing.Point(96, 19);
            this.TypeTestComboBox.Name = "TypeTestComboBox";
            this.TypeTestComboBox.Size = new System.Drawing.Size(210, 21);
            this.TypeTestComboBox.TabIndex = 0;
            this.TypeTestComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeTestComboBox_SelectedIndexChanged);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(92, 249);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(112, 27);
            this.OkButton.TabIndex = 25;
            this.OkButton.Text = "Применить";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancleButton
            // 
            this.CancleButton.Location = new System.Drawing.Point(214, 249);
            this.CancleButton.Name = "CancleButton";
            this.CancleButton.Size = new System.Drawing.Size(112, 27);
            this.CancleButton.TabIndex = 26;
            this.CancleButton.Text = "Отмена";
            this.CancleButton.UseVisualStyleBackColor = true;
            // 
            // SettingTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 288);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancleButton);
            this.Controls.Add(this.ParametersTestGroupBox);
            this.Name = "SettingTestForm";
            this.Text = "SettingTestForm";
            this.Load += new System.EventHandler(this.SettingTestForm_Load);
            this.ParametersTestGroupBox.ResumeLayout(false);
            this.ParametersTestGroupBox.PerformLayout();
            this.TestsGroupBox.ResumeLayout(false);
            this.TestsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberPeriodsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeOffNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeOnNumericUpDown)).EndInit();
            this.ThermometerGroupBox.ResumeLayout(false);
            this.ThermometerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ParametersTestGroupBox;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.ComboBox TypeInstallationComboBox;
        private System.Windows.Forms.GroupBox TestsGroupBox;
        private System.Windows.Forms.NumericUpDown NumberPeriodsNumericUpDown;
        private System.Windows.Forms.NumericUpDown TimeOffNumericUpDown;
        private System.Windows.Forms.NumericUpDown TimeOnNumericUpDown;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.GroupBox ThermometerGroupBox;
        private System.Windows.Forms.RadioButton ThermometerOnRadioButton;
        private System.Windows.Forms.RadioButton ThermometerOffRadioButton;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox TypeTestComboBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancleButton;
    }
}