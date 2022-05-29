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
    public partial class WriteTextForm : Form
    {
        public string _textComment;
        public WriteTextForm()
        {
            InitializeComponent();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBox.Text.TrimEnd('\n', '\r');
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _textComment = TextBox.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
