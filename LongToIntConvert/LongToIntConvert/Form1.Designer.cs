﻿namespace LongToIntConvert
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.longTextBox = new System.Windows.Forms.TextBox();
            this.showTextBox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Integer";
            // 
            // longTextBox
            // 
            this.longTextBox.Location = new System.Drawing.Point(131, 49);
            this.longTextBox.Name = "longTextBox";
            this.longTextBox.Size = new System.Drawing.Size(100, 20);
            this.longTextBox.TabIndex = 1;
            // 
            // showTextBox
            // 
            this.showTextBox.Location = new System.Drawing.Point(112, 140);
            this.showTextBox.Name = "showTextBox";
            this.showTextBox.Size = new System.Drawing.Size(100, 20);
            this.showTextBox.TabIndex = 1;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(30, 133);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 33);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 294);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.showTextBox);
            this.Controls.Add(this.longTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Long To Integer Convert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox longTextBox;
        private System.Windows.Forms.TextBox showTextBox;
        private System.Windows.Forms.Button showButton;
    }
}

