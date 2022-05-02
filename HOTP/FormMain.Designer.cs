
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
            this.buttonChangeCounterHMACSHA1 = new System.Windows.Forms.Button();
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
            this.comboBoxHash.Size = new System.Drawing.Size(280, 28);
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
            // buttonChangeCounterHMACSHA1
            // 
            this.buttonChangeCounterHMACSHA1.Location = new System.Drawing.Point(298, 12);
            this.buttonChangeCounterHMACSHA1.Name = "buttonChangeCounterHMACSHA1";
            this.buttonChangeCounterHMACSHA1.Size = new System.Drawing.Size(94, 28);
            this.buttonChangeCounterHMACSHA1.TabIndex = 5;
            this.buttonChangeCounterHMACSHA1.Text = "Счётчик";
            this.buttonChangeCounterHMACSHA1.UseVisualStyleBackColor = true;
            this.buttonChangeCounterHMACSHA1.Click += new System.EventHandler(this.buttonChangeCounterHMACSHA1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 206);
            this.Controls.Add(this.buttonChangeCounterHMACSHA1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.ComboBox comboBoxHash;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Button buttonChangeCounterHMACSHA1;
    }
}

