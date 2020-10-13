using System;

namespace OOP2Tutorial_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.CatalogueListBox = new System.Windows.Forms.ListBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.RenameButton = new System.Windows.Forms.Button();
            this.RepriceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CatalogueListBox
            // 
            this.CatalogueListBox.FormattingEnabled = true;
            this.CatalogueListBox.Location = new System.Drawing.Point(66, 33);
            this.CatalogueListBox.Name = "CatalogueListBox";
            this.CatalogueListBox.Size = new System.Drawing.Size(188, 160);
            this.CatalogueListBox.TabIndex = 0;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(66, 212);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(89, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(165, 212);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(89, 20);
            this.PriceTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(66, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(165, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(66, 252);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(89, 23);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(165, 252);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(89, 23);
            this.RemoveButton.TabIndex = 6;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // RenameButton
            // 
            this.RenameButton.Location = new System.Drawing.Point(66, 281);
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Size = new System.Drawing.Size(89, 23);
            this.RenameButton.TabIndex = 7;
            this.RenameButton.Text = "Rename";
            this.RenameButton.UseVisualStyleBackColor = true;
            this.RenameButton.Click += new System.EventHandler(this.RenameButton_Click);
            // 
            // RepriceButton
            // 
            this.RepriceButton.Location = new System.Drawing.Point(165, 281);
            this.RepriceButton.Name = "RepriceButton";
            this.RepriceButton.Size = new System.Drawing.Size(89, 23);
            this.RepriceButton.TabIndex = 8;
            this.RepriceButton.Text = "Reprice";
            this.RepriceButton.UseVisualStyleBackColor = true;
            this.RepriceButton.Click += new System.EventHandler(this.RepriceButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 399);
            this.Controls.Add(this.RepriceButton);
            this.Controls.Add(this.RenameButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.CatalogueListBox);
            this.Name = "Form1";
            this.Text = "Tutorial 4";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button RenameButton;
        private System.Windows.Forms.Button RepriceButton;

        private System.Windows.Forms.Button RemoveButton;

        private System.Windows.Forms.Button AddButton;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.ListBox CatalogueListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;

        #endregion
    }
}