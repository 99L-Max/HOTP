
namespace HOTP
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.comboBoxHash = new System.Windows.Forms.ComboBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.numericUpDownCounterHOTP = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCounterHOTP)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(12, 112);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(380, 26);
            this.textBoxResult.TabIndex = 1;
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxHash
            // 
            this.comboBoxHash.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHash.FormattingEnabled = true;
            this.comboBoxHash.Items.AddRange(new object[] {
            "SHA1",
            "HMAC-SHA-1"});
            this.comboBoxHash.Location = new System.Drawing.Point(12, 12);
            this.comboBoxHash.Name = "comboBoxHash";
            this.comboBoxHash.Size = new System.Drawing.Size(176, 28);
            this.comboBoxHash.TabIndex = 2;
            this.comboBoxHash.SelectedIndexChanged += new System.EventHandler(this.comboBoxHash_SelectedIndexChanged);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(118, 152);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(174, 42);
            this.buttonGenerate.TabIndex = 3;
            this.buttonGenerate.Text = "Сгенерировать";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.ForeColor = System.Drawing.Color.Silver;
            this.textBoxKey.Location = new System.Drawing.Point(12, 63);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(380, 26);
            this.textBoxKey.TabIndex = 4;
            this.textBoxKey.Text = "Ключ";
            this.textBoxKey.Enter += new System.EventHandler(this.textBoxKey_Enter);
            this.textBoxKey.Leave += new System.EventHandler(this.textBoxKey_Leave);
            // 
            // numericUpDownCounterHOTP
            // 
            this.numericUpDownCounterHOTP.Location = new System.Drawing.Point(194, 13);
            this.numericUpDownCounterHOTP.Name = "numericUpDownCounterHOTP";
            this.numericUpDownCounterHOTP.Size = new System.Drawing.Size(198, 26);
            this.numericUpDownCounterHOTP.TabIndex = 5;
            this.numericUpDownCounterHOTP.ValueChanged += new System.EventHandler(this.numericUpDownCounterHOTP_ValueChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 206);
            this.Controls.Add(this.numericUpDownCounterHOTP);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.comboBoxHash);
            this.Controls.Add(this.textBoxResult);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOTP";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCounterHOTP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.ComboBox comboBoxHash;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.NumericUpDown numericUpDownCounterHOTP;
    }
}

