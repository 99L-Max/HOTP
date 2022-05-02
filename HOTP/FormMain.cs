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
                textBoxResult.Text = HashFunction.HMACHSHA1(textBoxKey.Text).ToString("000000");
        }
        private void buttonChangeCounterHMACSHA1_Click(object sender, EventArgs e)
        {
            new FormCounterHMACSHA1().ShowDialog();
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
            buttonChangeCounterHMACSHA1.Enabled = comboBoxHash.SelectedIndex == 1;
        }
    }
}
