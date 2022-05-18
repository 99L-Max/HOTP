using System;
using System.Drawing;
using System.Windows.Forms;

namespace HOTP
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            numericUpDownCounterHOTP.Maximum = long.MaxValue;
            comboBoxHash.SelectedIndex = 0;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (textBoxKey.ForeColor == Color.Silver)
            {
                textBoxResult.Text = "";
                return;
            }
            if (comboBoxHash.SelectedIndex == 0)
                textBoxResult.Text = HashFunction.SHA1(textBoxKey.Text);
            else
            {
                textBoxResult.Text = HashFunction.HMACHSHA1(textBoxKey.Text).ToString("000000");
                numericUpDownCounterHOTP.Value = HashFunction.counter;
            }
        }

        private void textBoxKey_Enter(object sender, EventArgs e)
        {
            if (textBoxKey.Text == "Ключ" && textBoxKey.ForeColor == Color.Silver)
            {
                textBoxKey.Text = "";
                textBoxKey.ForeColor = Color.Black;
            }
        }

        private void textBoxKey_Leave(object sender, EventArgs e)
        {
            if (textBoxKey.Text == "")
            {
                textBoxKey.Text = "Ключ";
                textBoxKey.ForeColor = Color.Silver;
            }
        }

        private void comboBoxHash_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDownCounterHOTP.Enabled = comboBoxHash.SelectedIndex == 1;
        }

        private void numericUpDownCounterHOTP_ValueChanged(object sender, EventArgs e)
        {
            HashFunction.counter = (long)numericUpDownCounterHOTP.Value;
        }
    }
}
