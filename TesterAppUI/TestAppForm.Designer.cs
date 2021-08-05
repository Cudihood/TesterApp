
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
            this.StartAddresTextBox = new System.Windows.Forms.TextBox();
            this.OpenButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.GetButton = new System.Windows.Forms.Button();
            this.SetButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumberOfPointsTextBox = new System.Windows.Forms.TextBox();
            this.GetTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SetTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PortsComboBox
            // 
            this.PortsComboBox.FormattingEnabled = true;
            this.PortsComboBox.Location = new System.Drawing.Point(145, 110);
            this.PortsComboBox.Name = "PortsComboBox";
            this.PortsComboBox.Size = new System.Drawing.Size(121, 33);
            this.PortsComboBox.TabIndex = 0;
            this.PortsComboBox.Text = "COM3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Порт:";
            // 
            // SlaveAddressTextBox
            // 
            this.SlaveAddressTextBox.Location = new System.Drawing.Point(275, 156);
            this.SlaveAddressTextBox.Name = "SlaveAddressTextBox";
            this.SlaveAddressTextBox.Size = new System.Drawing.Size(100, 31);
            this.SlaveAddressTextBox.TabIndex = 2;
            this.SlaveAddressTextBox.Text = "10";
            // 
            // StartAddresTextBox
            // 
            this.StartAddresTextBox.Location = new System.Drawing.Point(252, 209);
            this.StartAddresTextBox.Name = "StartAddresTextBox";
            this.StartAddresTextBox.Size = new System.Drawing.Size(100, 31);
            this.StartAddresTextBox.TabIndex = 3;
            this.StartAddresTextBox.Text = "0xA441";
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(73, 320);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(173, 51);
            this.OpenButton.TabIndex = 4;
            this.OpenButton.Text = "Открыть порт";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Enabled = false;
            this.CloseButton.Location = new System.Drawing.Point(271, 320);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(164, 51);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "Закрыть порт";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // GetButton
            // 
            this.GetButton.Location = new System.Drawing.Point(71, 526);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(129, 67);
            this.GetButton.TabIndex = 6;
            this.GetButton.Text = "Получить данные";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // SetButton
            // 
            this.SetButton.Location = new System.Drawing.Point(306, 526);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(129, 67);
            this.SetButton.TabIndex = 7;
            this.SetButton.Text = "Записать данные";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Адрес устройтсва:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Адрес регистра:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Количество регистров:";
            // 
            // NumberOfPointsTextBox
            // 
            this.NumberOfPointsTextBox.Location = new System.Drawing.Point(319, 263);
            this.NumberOfPointsTextBox.Name = "NumberOfPointsTextBox";
            this.NumberOfPointsTextBox.Size = new System.Drawing.Size(100, 31);
            this.NumberOfPointsTextBox.TabIndex = 13;
            this.NumberOfPointsTextBox.Text = "1";
            // 
            // GetTextBox
            // 
            this.GetTextBox.Location = new System.Drawing.Point(71, 459);
            this.GetTextBox.Name = "GetTextBox";
            this.GetTextBox.Size = new System.Drawing.Size(129, 31);
            this.GetTextBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "(hex)";
            // 
            // SetTextBox
            // 
            this.SetTextBox.Location = new System.Drawing.Point(306, 458);
            this.SetTextBox.Name = "SetTextBox";
            this.SetTextBox.Size = new System.Drawing.Size(129, 31);
            this.SetTextBox.TabIndex = 17;
            // 
            // TestAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 872);
            this.Controls.Add(this.SetTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GetTextBox);
            this.Controls.Add(this.NumberOfPointsTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.GetButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.StartAddresTextBox);
            this.Controls.Add(this.SlaveAddressTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PortsComboBox);
            this.Name = "TestAppForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TesterAppForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PortsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SlaveAddressTextBox;
        private System.Windows.Forms.TextBox StartAddresTextBox;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NumberOfPointsTextBox;
        private System.Windows.Forms.TextBox GetTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SetTextBox;
    }
}

