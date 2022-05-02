
namespace HOTP
{
    partial class FormCounterHMACSHA1
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
            this.buttonSetCounter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSetCounter
            // 
            this.buttonSetCounter.Location = new System.Drawing.Point(135, 65);
            this.buttonSetCounter.Name = "buttonSetCounter";
            this.buttonSetCounter.Size = new System.Drawing.Size(160, 30);
            this.buttonSetCounter.TabIndex = 0;
            this.buttonSetCounter.Text = "Установить";
            this.buttonSetCounter.UseVisualStyleBackColor = true;
            this.buttonSetCounter.Click += new System.EventHandler(this.buttonSetCounter_Click);
            // 
            // FormCounterHMACSHA1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 109);
            this.Controls.Add(this.buttonSetCounter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCounterHMACSHA1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Счётчик";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSetCounter;
    }
}