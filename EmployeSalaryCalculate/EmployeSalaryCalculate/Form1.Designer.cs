namespace EmployeSalaryCalculate
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
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.calculateSalaryButton = new System.Windows.Forms.Button();
            this.resultSalaryTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(118, 46);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 1;
            // 
            // calculateSalaryButton
            // 
            this.calculateSalaryButton.Location = new System.Drawing.Point(129, 114);
            this.calculateSalaryButton.Name = "calculateSalaryButton";
            this.calculateSalaryButton.Size = new System.Drawing.Size(89, 41);
            this.calculateSalaryButton.TabIndex = 2;
            this.calculateSalaryButton.Text = "Calculate Salary";
            this.calculateSalaryButton.UseVisualStyleBackColor = true;
            this.calculateSalaryButton.Click += new System.EventHandler(this.calculateSalaryButton_Click);
            // 
            // resultSalaryTextBox
            // 
            this.resultSalaryTextBox.Location = new System.Drawing.Point(118, 192);
            this.resultSalaryTextBox.Name = "resultSalaryTextBox";
            this.resultSalaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.resultSalaryTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employee Salary";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 363);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultSalaryTextBox);
            this.Controls.Add(this.calculateSalaryButton);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Employee Salary Calculate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button calculateSalaryButton;
        private System.Windows.Forms.TextBox resultSalaryTextBox;
        private System.Windows.Forms.Label label2;
    }
}

