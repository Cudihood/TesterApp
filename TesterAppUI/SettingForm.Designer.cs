
namespace TesterAppUI
{
    partial class SettingForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.PortsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SlaveAddressNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label41 = new System.Windows.Forms.Label();
            this.TypeInstallationComboBox = new System.Windows.Forms.ComboBox();
            this.DataBitsComboBox = new System.Windows.Forms.ComboBox();
            this.StopBitsСomboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BaudRateComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ParityComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SlaveAddressNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PortsComboBox
            // 
            this.PortsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PortsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortsComboBox.FormattingEnabled = true;
            this.PortsComboBox.Location = new System.Drawing.Point(174, 19);
            this.PortsComboBox.Name = "PortsComboBox";
            this.PortsComboBox.Size = new System.Drawing.Size(92, 21);
            this.PortsComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Порт:";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(57, 229);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(112, 27);
            this.OkButton.TabIndex = 4;
            this.OkButton.Text = "Применить";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SlaveAddressNumericUpDown);
            this.groupBox1.Controls.Add(this.label41);
            this.groupBox1.Controls.Add(this.TypeInstallationComboBox);
            this.groupBox1.Controls.Add(this.DataBitsComboBox);
            this.groupBox1.Controls.Add(this.StopBitsСomboBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.BaudRateComboBox);
            this.groupBox1.Controls.Add(this.PortsComboBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ParityComboBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(275, 211);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки порта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Адрес устройства:";
            // 
            // SlaveAddressNumericUpDown
            // 
            this.SlaveAddressNumericUpDown.Location = new System.Drawing.Point(174, 181);
            this.SlaveAddressNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.SlaveAddressNumericUpDown.Name = "SlaveAddressNumericUpDown";
            this.SlaveAddressNumericUpDown.Size = new System.Drawing.Size(92, 20);
            this.SlaveAddressNumericUpDown.TabIndex = 27;
            this.SlaveAddressNumericUpDown.ValueChanged += new System.EventHandler(this.SlaveAddressNumericUpDown_ValueChanged);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(5, 157);
            this.label41.Margin = new System.Windows.Forms.Padding(3);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(84, 13);
            this.label41.TabIndex = 26;
            this.label41.Text = "Тип установки:";
            // 
            // TypeInstallationComboBox
            // 
            this.TypeInstallationComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeInstallationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeInstallationComboBox.FormattingEnabled = true;
            this.TypeInstallationComboBox.Items.AddRange(new object[] {
            "IHM-15",
            "IHM-25",
            "IHM-30",
            "IHM-60"});
            this.TypeInstallationComboBox.Location = new System.Drawing.Point(174, 154);
            this.TypeInstallationComboBox.Name = "TypeInstallationComboBox";
            this.TypeInstallationComboBox.Size = new System.Drawing.Size(92, 21);
            this.TypeInstallationComboBox.TabIndex = 25;
            // 
            // DataBitsComboBox
            // 
            this.DataBitsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DataBitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataBitsComboBox.FormattingEnabled = true;
            this.DataBitsComboBox.Items.AddRange(new object[] {
            "7",
            "8"});
            this.DataBitsComboBox.Location = new System.Drawing.Point(174, 73);
            this.DataBitsComboBox.Name = "DataBitsComboBox";
            this.DataBitsComboBox.Size = new System.Drawing.Size(92, 21);
            this.DataBitsComboBox.TabIndex = 15;
            // 
            // StopBitsСomboBox
            // 
            this.StopBitsСomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StopBitsСomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StopBitsСomboBox.FormattingEnabled = true;
            this.StopBitsСomboBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.StopBitsСomboBox.Location = new System.Drawing.Point(174, 127);
            this.StopBitsСomboBox.Name = "StopBitsСomboBox";
            this.StopBitsСomboBox.Size = new System.Drawing.Size(92, 21);
            this.StopBitsСomboBox.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 130);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Стоп битов:";
            // 
            // BaudRateComboBox
            // 
            this.BaudRateComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BaudRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudRateComboBox.FormattingEnabled = true;
            this.BaudRateComboBox.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.BaudRateComboBox.Location = new System.Drawing.Point(174, 46);
            this.BaudRateComboBox.Name = "BaudRateComboBox";
            this.BaudRateComboBox.Size = new System.Drawing.Size(92, 21);
            this.BaudRateComboBox.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 76);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Количество бит:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cкорость передачи:";
            // 
            // ParityComboBox
            // 
            this.ParityComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ParityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParityComboBox.FormattingEnabled = true;
            this.ParityComboBox.Items.AddRange(new object[] {
            "0-None Parity",
            "1-Odd Parity",
            "2-Even Parity"});
            this.ParityComboBox.Location = new System.Drawing.Point(174, 100);
            this.ParityComboBox.Name = "ParityComboBox";
            this.ParityComboBox.Size = new System.Drawing.Size(92, 21);
            this.ParityComboBox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 103);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Контроль четности:";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(175, 229);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(112, 27);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "Отмена";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 263);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.OkButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(315, 302);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(315, 302);
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройка подклюения";
            this.Load += new System.EventHandler(this.TesterAppForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SlaveAddressNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox PortsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox DataBitsComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox StopBitsСomboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox BaudRateComboBox;
        private System.Windows.Forms.ComboBox ParityComboBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.ComboBox TypeInstallationComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown SlaveAddressNumericUpDown;
    }
}

