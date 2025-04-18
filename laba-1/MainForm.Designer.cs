﻿using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonCreateObjectOneParametr = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonDeleteObject = new System.Windows.Forms.Button();
            this.formListInfoObject = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonShowAllParametrs = new System.Windows.Forms.Button();
            this.buttonChangeFields = new System.Windows.Forms.Button();
            this.button_ChangeFields = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.formCountOfObjects = new System.Windows.Forms.Label();
            this.buttonOpenLibrary = new System.Windows.Forms.Button();
            this.buttonCloseLibrary = new System.Windows.Forms.Button();
            this.formObjectsList = new System.Windows.Forms.ListBox();
            this.buttonUndoAction = new System.Windows.Forms.Button();
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
            this.buttonCreateObjectOneParametr.Click += new System.EventHandler(this.ButtonCreateObjectAllParametr_Click);
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
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
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
            this.buttonDeleteObject.Click += new System.EventHandler(this.ButtonDeleteObject_Click);
            // 
            // formListInfoObject
            // 
            this.formListInfoObject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formListInfoObject.FormattingEnabled = true;
            this.formListInfoObject.ItemHeight = 21;
            this.formListInfoObject.Location = new System.Drawing.Point(224, 33);
            this.formListInfoObject.Name = "formListInfoObject";
            this.formListInfoObject.Size = new System.Drawing.Size(325, 550);
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
            this.buttonShowAllParametrs.Click += new System.EventHandler(this.ButtonShowAllParametrs_Click);
            // 
            // buttonChangeFields
            // 
            this.buttonChangeFields.Location = new System.Drawing.Point(0, 0);
            this.buttonChangeFields.Name = "buttonChangeFields";
            this.buttonChangeFields.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeFields.TabIndex = 0;
            // 
            // button_ChangeFields
            // 
            this.button_ChangeFields.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_ChangeFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ChangeFields.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_ChangeFields.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ChangeFields.Location = new System.Drawing.Point(728, 33);
            this.button_ChangeFields.Name = "button_ChangeFields";
            this.button_ChangeFields.Size = new System.Drawing.Size(167, 67);
            this.button_ChangeFields.TabIndex = 0;
            this.button_ChangeFields.Text = "Изменить поля";
            this.button_ChangeFields.UseVisualStyleBackColor = false;
            this.button_ChangeFields.Click += new System.EventHandler(this.Button_ChangeFields_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(224, 613);
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
            this.formCountOfObjects.Location = new System.Drawing.Point(454, 600);
            this.formCountOfObjects.Name = "formCountOfObjects";
            this.formCountOfObjects.Size = new System.Drawing.Size(34, 39);
            this.formCountOfObjects.TabIndex = 6;
            this.formCountOfObjects.Text = "0";
            this.formCountOfObjects.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonOpenLibrary
            // 
            this.buttonOpenLibrary.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOpenLibrary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenLibrary.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonOpenLibrary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenLibrary.Location = new System.Drawing.Point(555, 106);
            this.buttonOpenLibrary.Name = "buttonOpenLibrary";
            this.buttonOpenLibrary.Size = new System.Drawing.Size(167, 67);
            this.buttonOpenLibrary.TabIndex = 7;
            this.buttonOpenLibrary.Text = "Открыть библиотеку";
            this.buttonOpenLibrary.UseVisualStyleBackColor = false;
            this.buttonOpenLibrary.Click += new System.EventHandler(this.ButtonOpenLibrary_Click);
            // 
            // buttonCloseLibrary
            // 
            this.buttonCloseLibrary.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCloseLibrary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCloseLibrary.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCloseLibrary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseLibrary.Location = new System.Drawing.Point(728, 106);
            this.buttonCloseLibrary.Name = "buttonCloseLibrary";
            this.buttonCloseLibrary.Size = new System.Drawing.Size(167, 67);
            this.buttonCloseLibrary.TabIndex = 8;
            this.buttonCloseLibrary.Text = "Закрыть библиотеку";
            this.buttonCloseLibrary.UseVisualStyleBackColor = false;
            this.buttonCloseLibrary.Click += new System.EventHandler(this.ButtonCloseLibrary_Click);
            // 
            // formObjectsList
            // 
            this.formObjectsList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formObjectsList.FormattingEnabled = true;
            this.formObjectsList.ItemHeight = 21;
            this.formObjectsList.Location = new System.Drawing.Point(16, 34);
            this.formObjectsList.Name = "formObjectsList";
            this.formObjectsList.Size = new System.Drawing.Size(200, 613);
            this.formObjectsList.TabIndex = 9;
            this.formObjectsList.SelectedIndexChanged += new System.EventHandler(this.formObjectsList_SelectedIndexChanged);
            // 
            // buttonUndoAction
            // 
            this.buttonUndoAction.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUndoAction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUndoAction.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonUndoAction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUndoAction.Location = new System.Drawing.Point(643, 179);
            this.buttonUndoAction.Name = "buttonUndoAction";
            this.buttonUndoAction.Size = new System.Drawing.Size(167, 67);
            this.buttonUndoAction.TabIndex = 10;
            this.buttonUndoAction.Text = "Отменить последнее действие";
            this.buttonUndoAction.UseVisualStyleBackColor = false;
            this.buttonUndoAction.Click += new System.EventHandler(this.ButtonUndoAction_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 661);
            this.Controls.Add(this.buttonUndoAction);
            this.Controls.Add(this.formObjectsList);
            this.Controls.Add(this.buttonCloseLibrary);
            this.Controls.Add(this.buttonOpenLibrary);
            this.Controls.Add(this.formCountOfObjects);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formListInfoObject);
            this.Controls.Add(this.buttonCreateObjectOneParametr);
            this.Controls.Add(this.button_ChangeFields);
            this.Controls.Add(this.buttonShowAllParametrs);
            this.Controls.Add(this.buttonDeleteObject);
            this.Controls.Add(this.buttonExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateObjectOneParametr;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonDeleteObject;
        private System.Windows.Forms.ListBox formListInfoObject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonShowAllParametrs;
        private Button buttonChangeFields;
        private Button button_ChangeFields;
        private Label label3;
        private Label formCountOfObjects;
        private Button buttonOpenLibrary;
        private Button buttonCloseLibrary;
        private ListBox formObjectsList;
        private Button buttonUndoAction;
    }
}