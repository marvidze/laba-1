namespace laba_1
{
    partial class WelcomeForm
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
            this.LabelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTitle.Location = new System.Drawing.Point(150, 259);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(467, 120);
            this.LabelTitle.TabIndex = 2;
            this.LabelTitle.Text = "Лабораторная работа №4\r\n\"Структурные паттерны\"\r\nГруппа: 23ВП1\r\nСостав бригады: Аю" +
    "пов М.Р. Ипатов В.М.";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LabelTitle.Click += new System.EventHandler(this.LabelTitle_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 652);
            this.Controls.Add(this.LabelTitle);
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelcomeForm";
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            this.Click += new System.EventHandler(this.FormClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitle;
    }
}