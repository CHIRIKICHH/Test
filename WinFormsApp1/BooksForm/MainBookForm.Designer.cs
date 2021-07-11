﻿
namespace WinFormsApp1
{
    partial class MainBookForm
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
            this.fillButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeBox = new System.Windows.Forms.TextBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fillButton
            // 
            this.fillButton.Location = new System.Drawing.Point(12, 426);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(75, 23);
            this.fillButton.TabIndex = 39;
            this.fillButton.Text = "Добавить";
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.Click += new System.EventHandler(this.fillButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(270, 428);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(62, 23);
            this.removeButton.TabIndex = 38;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(193, 428);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(71, 23);
            this.changeButton.TabIndex = 36;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeBox
            // 
            this.changeBox.Location = new System.Drawing.Point(151, 428);
            this.changeBox.Name = "changeBox";
            this.changeBox.Size = new System.Drawing.Size(36, 23);
            this.changeBox.TabIndex = 35;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(547, 426);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(241, 23);
            this.searchBox.TabIndex = 2;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 383);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(246, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 30);
            this.label2.TabIndex = 40;
            this.label2.Text = "Список книг библиотеки";
            // 
            // MainBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.fillButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.changeBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Name = "MainBookForm";
            this.Text = "Книги";
            this.Load += new System.EventHandler(this.MainBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fillButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.TextBox changeBox;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
    }
}