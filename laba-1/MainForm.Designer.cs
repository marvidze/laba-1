namespace laba_1
{
    partial class MainForm
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
            this.buttonCreateObjectOneParametr = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxExeptions = new System.Windows.Forms.TextBox();
            this.formObjectsList = new System.Windows.Forms.ListBox();
            this.buttonCreateObjectTwoParametr = new System.Windows.Forms.Button();
            this.buttonCreateObjectAllParametrs = new System.Windows.Forms.Button();
            this.buttonCreateObjectNullParametrs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreateObjectOneParametr
            // 
            this.buttonCreateObjectOneParametr.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCreateObjectOneParametr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateObjectOneParametr.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCreateObjectOneParametr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateObjectOneParametr.Location = new System.Drawing.Point(555, 394);
            this.buttonCreateObjectOneParametr.Name = "buttonCreateObjectOneParametr";
            this.buttonCreateObjectOneParametr.Size = new System.Drawing.Size(167, 67);
            this.buttonCreateObjectOneParametr.TabIndex = 0;
            this.buttonCreateObjectOneParametr.Text = "Создать объект \r\n(1 параметром)";
            this.buttonCreateObjectOneParametr.UseVisualStyleBackColor = false;
            this.buttonCreateObjectOneParametr.Click += new System.EventHandler(this.buttonCreateObject_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(555, 613);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(167, 36);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxExeptions
            // 
            this.textBoxExeptions.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxExeptions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxExeptions.Location = new System.Drawing.Point(12, 571);
            this.textBoxExeptions.Multiline = true;
            this.textBoxExeptions.Name = "textBoxExeptions";
            this.textBoxExeptions.ReadOnly = true;
            this.textBoxExeptions.Size = new System.Drawing.Size(537, 78);
            this.textBoxExeptions.TabIndex = 2;
            this.textBoxExeptions.Text = "\r\nЗдесь будут отображаться ошибки";
            this.textBoxExeptions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // formObjectsList
            // 
            this.formObjectsList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formObjectsList.FormattingEnabled = true;
            this.formObjectsList.ItemHeight = 21;
            this.formObjectsList.Location = new System.Drawing.Point(12, 12);
            this.formObjectsList.Name = "formObjectsList";
            this.formObjectsList.Size = new System.Drawing.Size(298, 550);
            this.formObjectsList.TabIndex = 3;
            // 
            // buttonCreateObjectTwoParametr
            // 
            this.buttonCreateObjectTwoParametr.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCreateObjectTwoParametr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateObjectTwoParametr.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCreateObjectTwoParametr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateObjectTwoParametr.Location = new System.Drawing.Point(555, 467);
            this.buttonCreateObjectTwoParametr.Name = "buttonCreateObjectTwoParametr";
            this.buttonCreateObjectTwoParametr.Size = new System.Drawing.Size(167, 67);
            this.buttonCreateObjectTwoParametr.TabIndex = 0;
            this.buttonCreateObjectTwoParametr.Text = "Создать объект \r\n(2 параметрами)";
            this.buttonCreateObjectTwoParametr.UseVisualStyleBackColor = false;
            // 
            // buttonCreateObjectAllParametrs
            // 
            this.buttonCreateObjectAllParametrs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCreateObjectAllParametrs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateObjectAllParametrs.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCreateObjectAllParametrs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateObjectAllParametrs.Location = new System.Drawing.Point(555, 540);
            this.buttonCreateObjectAllParametrs.Name = "buttonCreateObjectAllParametrs";
            this.buttonCreateObjectAllParametrs.Size = new System.Drawing.Size(167, 67);
            this.buttonCreateObjectAllParametrs.TabIndex = 0;
            this.buttonCreateObjectAllParametrs.Text = "Создать объект \r\n(всеми параметрами)";
            this.buttonCreateObjectAllParametrs.UseVisualStyleBackColor = false;
            // 
            // buttonCreateObjectNullParametrs
            // 
            this.buttonCreateObjectNullParametrs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCreateObjectNullParametrs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateObjectNullParametrs.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCreateObjectNullParametrs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateObjectNullParametrs.Location = new System.Drawing.Point(555, 321);
            this.buttonCreateObjectNullParametrs.Name = "buttonCreateObjectNullParametrs";
            this.buttonCreateObjectNullParametrs.Size = new System.Drawing.Size(167, 67);
            this.buttonCreateObjectNullParametrs.TabIndex = 0;
            this.buttonCreateObjectNullParametrs.Text = "Создать объект \r\n(без параметров)";
            this.buttonCreateObjectNullParametrs.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 661);
            this.Controls.Add(this.formObjectsList);
            this.Controls.Add(this.buttonCreateObjectNullParametrs);
            this.Controls.Add(this.buttonCreateObjectAllParametrs);
            this.Controls.Add(this.buttonCreateObjectTwoParametr);
            this.Controls.Add(this.buttonCreateObjectOneParametr);
            this.Controls.Add(this.textBoxExeptions);
            this.Controls.Add(this.buttonExit);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateObjectOneParametr;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxExeptions;
        private System.Windows.Forms.ListBox formObjectsList;
        private System.Windows.Forms.Button buttonCreateObjectTwoParametr;
        private System.Windows.Forms.Button buttonCreateObjectAllParametrs;
        private System.Windows.Forms.Button buttonCreateObjectNullParametrs;
    }
}