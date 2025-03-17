namespace laba_1
{
    partial class CreateOneParametrObject
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_createObject = new System.Windows.Forms.Button();
            this.button_closeForm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_adress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_tel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_rating = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_books = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_place = new System.Windows.Forms.NumericUpDown();
            this.button_change = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_type_library = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_books)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_place)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(180, 45);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(142, 20);
            this.textBox_name.TabIndex = 0;
            this.textBox_name.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название:";
            // 
            // button_createObject
            // 
            this.button_createObject.Location = new System.Drawing.Point(12, 260);
            this.button_createObject.Name = "button_createObject";
            this.button_createObject.Size = new System.Drawing.Size(75, 23);
            this.button_createObject.TabIndex = 2;
            this.button_createObject.Text = "Создать";
            this.button_createObject.UseVisualStyleBackColor = true;
            this.button_createObject.Click += new System.EventHandler(this.button_createObject_Click);
            // 
            // button_closeForm
            // 
            this.button_closeForm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_closeForm.Location = new System.Drawing.Point(255, 260);
            this.button_closeForm.Name = "button_closeForm";
            this.button_closeForm.Size = new System.Drawing.Size(75, 23);
            this.button_closeForm.TabIndex = 3;
            this.button_closeForm.Text = "Закрыть";
            this.button_closeForm.UseVisualStyleBackColor = false;
            this.button_closeForm.Click += new System.EventHandler(this.button_closeForm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Адресс:";
            // 
            // textBox_adress
            // 
            this.textBox_adress.Location = new System.Drawing.Point(180, 75);
            this.textBox_adress.Name = "textBox_adress";
            this.textBox_adress.Size = new System.Drawing.Size(142, 20);
            this.textBox_adress.TabIndex = 5;
            this.textBox_adress.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Рейтинг:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Номер телефона:";
            // 
            // textBox_tel
            // 
            this.textBox_tel.Location = new System.Drawing.Point(180, 135);
            this.textBox_tel.Name = "textBox_tel";
            this.textBox_tel.Size = new System.Drawing.Size(142, 20);
            this.textBox_tel.TabIndex = 9;
            this.textBox_tel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Кол-во книг:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Мест в ЧЗ:";
            // 
            // numericUpDown_rating
            // 
            this.numericUpDown_rating.Location = new System.Drawing.Point(180, 105);
            this.numericUpDown_rating.Name = "numericUpDown_rating";
            this.numericUpDown_rating.Size = new System.Drawing.Size(142, 20);
            this.numericUpDown_rating.TabIndex = 14;
            // 
            // numericUpDown_books
            // 
            this.numericUpDown_books.Location = new System.Drawing.Point(180, 165);
            this.numericUpDown_books.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_books.Name = "numericUpDown_books";
            this.numericUpDown_books.Size = new System.Drawing.Size(142, 20);
            this.numericUpDown_books.TabIndex = 15;
            // 
            // numericUpDown_place
            // 
            this.numericUpDown_place.Location = new System.Drawing.Point(180, 197);
            this.numericUpDown_place.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_place.Name = "numericUpDown_place";
            this.numericUpDown_place.Size = new System.Drawing.Size(142, 20);
            this.numericUpDown_place.TabIndex = 16;
            // 
            // button_change
            // 
            this.button_change.Location = new System.Drawing.Point(12, 231);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(75, 23);
            this.button_change.TabIndex = 1;
            this.button_change.Text = "Применить";
            this.button_change.UseVisualStyleBackColor = true;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Тип библиотеки:";
            // 
            // comboBox_type_library
            // 
            this.comboBox_type_library.FormattingEnabled = true;
            this.comboBox_type_library.Location = new System.Drawing.Point(180, 16);
            this.comboBox_type_library.Name = "comboBox_type_library";
            this.comboBox_type_library.Size = new System.Drawing.Size(142, 21);
            this.comboBox_type_library.TabIndex = 18;
            // 
            // CreateOneParametrObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 295);
            this.Controls.Add(this.comboBox_type_library);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_change);
            this.Controls.Add(this.numericUpDown_place);
            this.Controls.Add(this.numericUpDown_books);
            this.Controls.Add(this.numericUpDown_rating);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_tel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_adress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_closeForm);
            this.Controls.Add(this.button_createObject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_name);
            this.Name = "CreateOneParametrObject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CreateOneParametrObject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_books)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_place)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_createObject;
        private System.Windows.Forms.Button button_closeForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_adress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_tel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_rating;
        private System.Windows.Forms.NumericUpDown numericUpDown_books;
        private System.Windows.Forms.NumericUpDown numericUpDown_place;
        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_type_library;
    }
}