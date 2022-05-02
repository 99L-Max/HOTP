using System.Windows.Forms;

namespace HOTP
{
    public partial class FormCounterHMACSHA1 : Form
    {
        NumericUpDown[] numericUpDown = new NumericUpDown[8];
        public FormCounterHMACSHA1()
        {
            InitializeComponent();
            int width = 50;
            for (byte i = 0; i < numericUpDown.Length; i++)
            {
                numericUpDown[i] = new NumericUpDown();
                numericUpDown[i].Name = "numericUpDown" + i;
                numericUpDown[i].Size = new System.Drawing.Size(width, 26);
                numericUpDown[i].Location = new System.Drawing.Point(15 + i * width, 15);
                numericUpDown[i].Maximum = byte.MaxValue;
                numericUpDown[i].Value = HashFunction.counter[i];
                numericUpDown[i].TabIndex = i;
                Controls.Add(numericUpDown[i]);
            }
        }

        private void buttonSetCounter_Click(object sender, System.EventArgs e)
        {
            for (byte i = 0; i < HashFunction.counter.Length; i++)
                HashFunction.counter[i] = (byte)numericUpDown[i].Value;
            Close();
        }
    }
}
