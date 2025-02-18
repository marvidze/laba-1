using System.Windows.Forms;

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
            this.formObjectsList = new System.Windows.Forms.ListBox();
            this.buttonDeleteObject = new System.Windows.Forms.Button();
            this.formListInfoObject = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonShowAllParametrs = new System.Windows.Forms.Button();
            this.buttonShowAddres = new System.Windows.Forms.Button();
            this.buttonShowNumberOfPhone = new System.Windows.Forms.Button();
            this.buttonShowCountOfSeats = new System.Windows.Forms.Button();
            this.buttonShowCountOfBooks = new System.Windows.Forms.Button();
            this.buttonShowRating = new System.Windows.Forms.Button();
            this.buttonChangeFields = new System.Windows.Forms.Button();
            this.button_ChangeFields = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.formCountOfObjects = new System.Windows.Forms.Label();
            this.buttonDontClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreateObjectOneParametr
            // 
            this.buttonCreateObjectOneParametr.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCreateObjectOneParametr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateObjectOneParametr.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCreateObjectOneParametr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateObjectOneParametr.Location = new System.Drawing.Point(555, 540);
            this.buttonCreateObjectOneParametr.Name = "buttonCreateObjectOneParametr";
            this.buttonCreateObjectOneParametr.Size = new System.Drawing.Size(167, 67);
            this.buttonCreateObjectOneParametr.TabIndex = 0;
            this.buttonCreateObjectOneParametr.Text = "Создать объект ";
            this.buttonCreateObjectOneParametr.UseVisualStyleBackColor = false;
            this.buttonCreateObjectOneParametr.Click += new System.EventHandler(this.buttonCreateObjectOneParametr_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(643, 613);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(167, 36);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // formObjectsList
            // 
            this.formObjectsList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formObjectsList.FormattingEnabled = true;
            this.formObjectsList.ItemHeight = 21;
            this.formObjectsList.Location = new System.Drawing.Point(12, 33);
            this.formObjectsList.Name = "formObjectsList";
            this.formObjectsList.Size = new System.Drawing.Size(206, 613);
            this.formObjectsList.TabIndex = 3;
            // 
            // buttonDeleteObject
            // 
            this.buttonDeleteObject.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDeleteObject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteObject.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDeleteObject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteObject.Location = new System.Drawing.Point(728, 540);
            this.buttonDeleteObject.Name = "buttonDeleteObject";
            this.buttonDeleteObject.Size = new System.Drawing.Size(167, 67);
            this.buttonDeleteObject.TabIndex = 0;
            this.buttonDeleteObject.Text = "Удалить объект";
            this.buttonDeleteObject.UseVisualStyleBackColor = false;
            this.buttonDeleteObject.Click += new System.EventHandler(this.buttonDeleteObject_Click);
            // 
            // formListInfoObject
            // 
            this.formListInfoObject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formListInfoObject.FormattingEnabled = true;
            this.formListInfoObject.ItemHeight = 21;
            this.formListInfoObject.Location = new System.Drawing.Point(224, 33);
            this.formListInfoObject.Name = "formListInfoObject";
            this.formListInfoObject.Size = new System.Drawing.Size(325, 613);
            this.formListInfoObject.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(220, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Информация об объекте";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Объекты";
            // 
            // buttonShowAllParametrs
            // 
            this.buttonShowAllParametrs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonShowAllParametrs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowAllParametrs.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonShowAllParametrs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowAllParametrs.Location = new System.Drawing.Point(555, 33);
            this.buttonShowAllParametrs.Name = "buttonShowAllParametrs";
            this.buttonShowAllParametrs.Size = new System.Drawing.Size(167, 67);
            this.buttonShowAllParametrs.TabIndex = 0;
            this.buttonShowAllParametrs.Text = "Показать все поля";
            this.buttonShowAllParametrs.UseVisualStyleBackColor = false;
            this.buttonShowAllParametrs.Click += new System.EventHandler(this.buttonShowAllParametrs_Click);
            // 
            // buttonShowAddres
            // 
            this.buttonShowAddres.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonShowAddres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowAddres.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonShowAddres.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowAddres.Location = new System.Drawing.Point(728, 33);
            this.buttonShowAddres.Name = "buttonShowAddres";
            this.buttonShowAddres.Size = new System.Drawing.Size(167, 67);
            this.buttonShowAddres.TabIndex = 0;
            this.buttonShowAddres.Text = "Показать адрес";
            this.buttonShowAddres.UseVisualStyleBackColor = false;
            this.buttonShowAddres.Click += new System.EventHandler(this.buttonShowAdress_Click);
            // 
            // buttonShowNumberOfPhone
            // 
            this.buttonShowNumberOfPhone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonShowNumberOfPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowNumberOfPhone.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonShowNumberOfPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowNumberOfPhone.Location = new System.Drawing.Point(555, 179);
            this.buttonShowNumberOfPhone.Name = "buttonShowNumberOfPhone";
            this.buttonShowNumberOfPhone.Size = new System.Drawing.Size(167, 67);
            this.buttonShowNumberOfPhone.TabIndex = 0;
            this.buttonShowNumberOfPhone.Text = "Показать номер телефона";
            this.buttonShowNumberOfPhone.UseVisualStyleBackColor = false;
            this.buttonShowNumberOfPhone.Click += new System.EventHandler(this.buttonShowNumberOfPhone_Click);
            // 
            // buttonShowCountOfSeats
            // 
            this.buttonShowCountOfSeats.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonShowCountOfSeats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowCountOfSeats.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonShowCountOfSeats.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowCountOfSeats.Location = new System.Drawing.Point(728, 106);
            this.buttonShowCountOfSeats.Name = "buttonShowCountOfSeats";
            this.buttonShowCountOfSeats.Size = new System.Drawing.Size(167, 67);
            this.buttonShowCountOfSeats.TabIndex = 0;
            this.buttonShowCountOfSeats.Text = "Показать количество мест в читальном зале";
            this.buttonShowCountOfSeats.UseVisualStyleBackColor = false;
            this.buttonShowCountOfSeats.Click += new System.EventHandler(this.buttonShowCountOfSeats_Click);
            // 
            // buttonShowCountOfBooks
            // 
            this.buttonShowCountOfBooks.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonShowCountOfBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowCountOfBooks.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonShowCountOfBooks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowCountOfBooks.Location = new System.Drawing.Point(728, 179);
            this.buttonShowCountOfBooks.Name = "buttonShowCountOfBooks";
            this.buttonShowCountOfBooks.Size = new System.Drawing.Size(167, 67);
            this.buttonShowCountOfBooks.TabIndex = 0;
            this.buttonShowCountOfBooks.Text = "Показать количество книг";
            this.buttonShowCountOfBooks.UseVisualStyleBackColor = false;
            this.buttonShowCountOfBooks.Click += new System.EventHandler(this.buttonShowCountOfBooks_Click);
            // 
            // buttonShowRating
            // 
            this.buttonShowRating.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonShowRating.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowRating.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonShowRating.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowRating.Location = new System.Drawing.Point(555, 106);
            this.buttonShowRating.Name = "buttonShowRating";
            this.buttonShowRating.Size = new System.Drawing.Size(167, 67);
            this.buttonShowRating.TabIndex = 0;
            this.buttonShowRating.Text = "Показать рейтинг";
            this.buttonShowRating.UseVisualStyleBackColor = false;
            this.buttonShowRating.Click += new System.EventHandler(this.buttonShowRating_Click);
            // 
            // buttonChangeFields
            // 
            this.buttonChangeFields.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonChangeFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChangeFields.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonChangeFields.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeFields.Location = new System.Drawing.Point(642, 252);
            this.buttonChangeFields.Name = "buttonChangeFields";
            this.buttonChangeFields.Size = new System.Drawing.Size(167, 67);
            this.buttonChangeFields.TabIndex = 5;
            this.buttonChangeFields.Text = "Изменить поля";
            this.buttonChangeFields.UseVisualStyleBackColor = false;
            this.buttonChangeFields.Click += new System.EventHandler(this.button_ChangeFields_Click);
            // 
            // button_ChangeFields
            // 
            this.button_ChangeFields.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_ChangeFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ChangeFields.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_ChangeFields.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ChangeFields.Location = new System.Drawing.Point(643, 252);
            this.button_ChangeFields.Name = "button_ChangeFields";
            this.button_ChangeFields.Size = new System.Drawing.Size(167, 67);
            this.button_ChangeFields.TabIndex = 5;
            this.button_ChangeFields.Text = "Редактировать поля ";
            this.button_ChangeFields.UseVisualStyleBackColor = false;
            this.button_ChangeFields.Click += new System.EventHandler(this.button_ChangeFields_Click);
            // 
            // button_ChangeFields
            // 
            this.button_ChangeFields.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_ChangeFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ChangeFields.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_ChangeFields.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ChangeFields.Location = new System.Drawing.Point(643, 252);
            this.button_ChangeFields.Name = "button_ChangeFields";
            this.button_ChangeFields.Size = new System.Drawing.Size(167, 67);
            this.button_ChangeFields.TabIndex = 0;
            this.button_ChangeFields.Text = "Изменить поля";
            this.button_ChangeFields.UseVisualStyleBackColor = false;
            this.button_ChangeFields.Click += new System.EventHandler(this.button_ChangeFields_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(551, 506);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Счётчик созданных объектов:";
            // 
            // formCountOfObjects
            // 
            this.formCountOfObjects.AutoSize = true;
            this.formCountOfObjects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.formCountOfObjects.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formCountOfObjects.Location = new System.Drawing.Point(776, 498);
            this.formCountOfObjects.Name = "formCountOfObjects";
            this.formCountOfObjects.Size = new System.Drawing.Size(34, 39);
            this.formCountOfObjects.TabIndex = 6;
            this.formCountOfObjects.Text = "0";
            this.formCountOfObjects.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDontClick
            // 
            this.buttonDontClick.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDontClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDontClick.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDontClick.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDontClick.Location = new System.Drawing.Point(816, 498);
            this.buttonDontClick.Name = "buttonDontClick";
            this.buttonDontClick.Size = new System.Drawing.Size(79, 41);
            this.buttonDontClick.TabIndex = 0;
            this.buttonDontClick.Text = "НЕ НАЖИМАТЬ";
            this.buttonDontClick.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDontClick.UseVisualStyleBackColor = false;
            this.buttonDontClick.Click += new System.EventHandler(this.button_DontClick_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 661);
            this.Controls.Add(this.formCountOfObjects);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formListInfoObject);
            this.Controls.Add(this.formObjectsList);
            this.Controls.Add(this.buttonCreateObjectOneParametr);
            this.Controls.Add(this.buttonShowRating);
            this.Controls.Add(this.buttonShowCountOfBooks);
            this.Controls.Add(this.buttonShowCountOfSeats);
            this.Controls.Add(this.buttonDontClick);
            this.Controls.Add(this.button_ChangeFields);
            this.Controls.Add(this.buttonShowNumberOfPhone);
            this.Controls.Add(this.buttonShowAddres);
            this.Controls.Add(this.buttonShowAllParametrs);
            this.Controls.Add(this.buttonDeleteObject);
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
        private System.Windows.Forms.ListBox formObjectsList;
        private System.Windows.Forms.Button buttonDeleteObject;
        private System.Windows.Forms.ListBox formListInfoObject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonShowAllParametrs;
        private System.Windows.Forms.Button buttonShowAddres;
        private System.Windows.Forms.Button buttonShowNumberOfPhone;
        private System.Windows.Forms.Button buttonShowCountOfSeats;
        private System.Windows.Forms.Button buttonShowCountOfBooks;
        private System.Windows.Forms.Button buttonShowRating;
        private Button buttonChangeFields;
        private Button button_ChangeFields;
        private Label label3;
        private Label formCountOfObjects;
        private Button buttonDontClick;
    }
}