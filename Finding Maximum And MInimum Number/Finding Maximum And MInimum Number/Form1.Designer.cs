namespace Finding_Maximum_And_MInimum_Number
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
            this.button1 = new System.Windows.Forms.Button();
            this.firstNumTextBox = new System.Windows.Forms.TextBox();
            this.secondNumTextBox = new System.Windows.Forms.TextBox();
            this.thirdNumTextBox = new System.Windows.Forms.TextBox();
            this.fourthNumTextBox = new System.Windows.Forms.TextBox();
            this.fifthNumTextBox = new System.Windows.Forms.TextBox();
            this.minNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maxNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show Max";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // firstNumTextBox
            // 
            this.firstNumTextBox.Location = new System.Drawing.Point(102, 82);
            this.firstNumTextBox.Name = "firstNumTextBox";
            this.firstNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNumTextBox.TabIndex = 1;
            // 
            // secondNumTextBox
            // 
            this.secondNumTextBox.Location = new System.Drawing.Point(102, 108);
            this.secondNumTextBox.Name = "secondNumTextBox";
            this.secondNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.secondNumTextBox.TabIndex = 1;
            // 
            // thirdNumTextBox
            // 
            this.thirdNumTextBox.Location = new System.Drawing.Point(102, 134);
            this.thirdNumTextBox.Name = "thirdNumTextBox";
            this.thirdNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.thirdNumTextBox.TabIndex = 1;
            // 
            // fourthNumTextBox
            // 
            this.fourthNumTextBox.Location = new System.Drawing.Point(102, 160);
            this.fourthNumTextBox.Name = "fourthNumTextBox";
            this.fourthNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.fourthNumTextBox.TabIndex = 1;
            // 
            // fifthNumTextBox
            // 
            this.fifthNumTextBox.Location = new System.Drawing.Point(102, 186);
            this.fifthNumTextBox.Name = "fifthNumTextBox";
            this.fifthNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.fifthNumTextBox.TabIndex = 1;
            // 
            // minNumberTextBox
            // 
            this.minNumberTextBox.Location = new System.Drawing.Point(121, 299);
            this.minNumberTextBox.Name = "minNumberTextBox";
            this.minNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.minNumberTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Maximum Number";
            // 
            // maxNumberTextBox
            // 
            this.maxNumberTextBox.Location = new System.Drawing.Point(121, 264);
            this.maxNumberTextBox.Name = "maxNumberTextBox";
            this.maxNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxNumberTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Minimum Number";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(237, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 27);
            this.button2.TabIndex = 0;
            this.button2.Text = "Show Min";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Input 5 numbers in Text Box";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 353);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maxNumberTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minNumberTextBox);
            this.Controls.Add(this.fifthNumTextBox);
            this.Controls.Add(this.fourthNumTextBox);
            this.Controls.Add(this.thirdNumTextBox);
            this.Controls.Add(this.secondNumTextBox);
            this.Controls.Add(this.firstNumTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Finding Maximum and Minimum Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox firstNumTextBox;
        private System.Windows.Forms.TextBox secondNumTextBox;
        private System.Windows.Forms.TextBox thirdNumTextBox;
        private System.Windows.Forms.TextBox fourthNumTextBox;
        private System.Windows.Forms.TextBox fifthNumTextBox;
        private System.Windows.Forms.TextBox minNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maxNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
    }
}

