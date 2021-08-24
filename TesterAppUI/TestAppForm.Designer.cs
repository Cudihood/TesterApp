
namespace TesterAppUI
{
    partial class TestAppForm
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
            this.PortsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SlaveAddressTextBox = new System.Windows.Forms.TextBox();
            this.StartAddressTextBox = new System.Windows.Forms.TextBox();
            this.OpenButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.GetButton = new System.Windows.Forms.Button();
            this.SetButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumberOfPointsTextBox = new System.Windows.Forms.TextBox();
            this.GetTextBox = new System.Windows.Forms.TextBox();
            this.SetTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataBitsComboBox = new System.Windows.Forms.ComboBox();
            this.StopBitsСomboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BaudRateComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ParityComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PortsComboBox
            // 
            this.PortsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortsComboBox.FormattingEnabled = true;
            this.PortsComboBox.Location = new System.Drawing.Point(118, 19);
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
            // SlaveAddressTextBox
            // 
            this.SlaveAddressTextBox.Location = new System.Drawing.Point(154, 18);
            this.SlaveAddressTextBox.Name = "SlaveAddressTextBox";
            this.SlaveAddressTextBox.Size = new System.Drawing.Size(52, 20);
            this.SlaveAddressTextBox.TabIndex = 2;
            this.SlaveAddressTextBox.Text = "10";
            this.SlaveAddressTextBox.TextChanged += new System.EventHandler(this.SlaveAddressTextBox_TextChanged);
            // 
            // StartAddressTextBox
            // 
            this.StartAddressTextBox.Location = new System.Drawing.Point(154, 44);
            this.StartAddressTextBox.Name = "StartAddressTextBox";
            this.StartAddressTextBox.Size = new System.Drawing.Size(52, 20);
            this.StartAddressTextBox.TabIndex = 3;
            this.StartAddressTextBox.Text = "0xA441";
            this.StartAddressTextBox.TextChanged += new System.EventHandler(this.StartAddresTextBox_TextChanged);
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(26, 169);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(86, 27);
            this.OpenButton.TabIndex = 4;
            this.OpenButton.Text = "Открыть порт";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Enabled = false;
            this.CloseButton.Location = new System.Drawing.Point(118, 169);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(92, 27);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "Закрыть порт";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // GetButton
            // 
            this.GetButton.Location = new System.Drawing.Point(5, 106);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(105, 31);
            this.GetButton.TabIndex = 6;
            this.GetButton.Text = "Получить данные";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // SetButton
            // 
            this.SetButton.Location = new System.Drawing.Point(5, 145);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(105, 31);
            this.SetButton.TabIndex = 7;
            this.SetButton.Text = "Записать данные";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Адрес устройтсва:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Адрес регистра (в hex):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Количество регистров:";
            // 
            // NumberOfPointsTextBox
            // 
            this.NumberOfPointsTextBox.Location = new System.Drawing.Point(154, 70);
            this.NumberOfPointsTextBox.Name = "NumberOfPointsTextBox";
            this.NumberOfPointsTextBox.Size = new System.Drawing.Size(52, 20);
            this.NumberOfPointsTextBox.TabIndex = 13;
            this.NumberOfPointsTextBox.Text = "1";
            this.NumberOfPointsTextBox.TextChanged += new System.EventHandler(this.NumberOfPointsTextBox_TextChanged);
            // 
            // GetTextBox
            // 
            this.GetTextBox.Location = new System.Drawing.Point(140, 112);
            this.GetTextBox.Name = "GetTextBox";
            this.GetTextBox.Size = new System.Drawing.Size(66, 20);
            this.GetTextBox.TabIndex = 15;
            // 
            // SetTextBox
            // 
            this.SetTextBox.Location = new System.Drawing.Point(140, 151);
            this.SetTextBox.Name = "SetTextBox";
            this.SetTextBox.Size = new System.Drawing.Size(66, 20);
            this.SetTextBox.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataBitsComboBox);
            this.groupBox1.Controls.Add(this.StopBitsСomboBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.BaudRateComboBox);
            this.groupBox1.Controls.Add(this.PortsComboBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.OpenButton);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CloseButton);
            this.groupBox1.Controls.Add(this.ParityComboBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(215, 201);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки порта";
            // 
            // DataBitsComboBox
            // 
            this.DataBitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataBitsComboBox.FormattingEnabled = true;
            this.DataBitsComboBox.Items.AddRange(new object[] {
            "7",
            "8"});
            this.DataBitsComboBox.Location = new System.Drawing.Point(118, 73);
            this.DataBitsComboBox.Name = "DataBitsComboBox";
            this.DataBitsComboBox.Size = new System.Drawing.Size(92, 21);
            this.DataBitsComboBox.TabIndex = 15;
            // 
            // StopBitsСomboBox
            // 
            this.StopBitsСomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StopBitsСomboBox.FormattingEnabled = true;
            this.StopBitsСomboBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.StopBitsСomboBox.Location = new System.Drawing.Point(118, 127);
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
            // BaudRateComboBox
            // 
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
            this.BaudRateComboBox.Location = new System.Drawing.Point(118, 46);
            this.BaudRateComboBox.Name = "BaudRateComboBox";
            this.BaudRateComboBox.Size = new System.Drawing.Size(92, 21);
            this.BaudRateComboBox.TabIndex = 11;
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
            // ParityComboBox
            // 
            this.ParityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParityComboBox.FormattingEnabled = true;
            this.ParityComboBox.Items.AddRange(new object[] {
            "0-None Parity",
            "1-Odd Parity",
            "2-Even Parity"});
            this.ParityComboBox.Location = new System.Drawing.Point(118, 100);
            this.ParityComboBox.Name = "ParityComboBox";
            this.ParityComboBox.Size = new System.Drawing.Size(92, 21);
            this.ParityComboBox.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.SetButton);
            this.groupBox2.Controls.Add(this.SetTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.GetTextBox);
            this.groupBox2.Controls.Add(this.StartAddressTextBox);
            this.groupBox2.Controls.Add(this.NumberOfPointsTextBox);
            this.groupBox2.Controls.Add(this.GetButton);
            this.groupBox2.Controls.Add(this.SlaveAddressTextBox);
            this.groupBox2.Location = new System.Drawing.Point(266, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(211, 182);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Работа с регистром";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 219);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(215, 160);
            this.listBox1.TabIndex = 20;
            // 
            // TestAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 405);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TestAppForm";
            this.Text = "TesterApp";
            this.Load += new System.EventHandler(this.TesterAppForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox PortsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SlaveAddressTextBox;
        private System.Windows.Forms.TextBox StartAddressTextBox;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NumberOfPointsTextBox;
        private System.Windows.Forms.TextBox GetTextBox;
        private System.Windows.Forms.TextBox SetTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox DataBitsComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox StopBitsСomboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox BaudRateComboBox;
        private System.Windows.Forms.ComboBox ParityComboBox;
        private System.Windows.Forms.ListBox listBox1;
    }
}

