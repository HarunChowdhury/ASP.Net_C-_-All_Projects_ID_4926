namespace Calculate_Taking_Time
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
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calculateTakTimeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.operatorComboBox = new System.Windows.Forms.ComboBox();
            this.showTalkTimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(165, 54);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(121, 20);
            this.balanceTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phone Balance";
            // 
            // calculateTakTimeButton
            // 
            this.calculateTakTimeButton.Location = new System.Drawing.Point(146, 202);
            this.calculateTakTimeButton.Name = "calculateTakTimeButton";
            this.calculateTakTimeButton.Size = new System.Drawing.Size(185, 38);
            this.calculateTakTimeButton.TabIndex = 2;
            this.calculateTakTimeButton.Text = "Calculate Talk Time";
            this.calculateTakTimeButton.UseVisualStyleBackColor = true;
            this.calculateTakTimeButton.Click += new System.EventHandler(this.calculateTakTimeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Type ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Select Operator";
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Postpaid",
            "Prepaid"});
            this.typeComboBox.Location = new System.Drawing.Point(165, 104);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 21);
            this.typeComboBox.TabIndex = 3;
            // 
            // operatorComboBox
            // 
            this.operatorComboBox.FormattingEnabled = true;
            this.operatorComboBox.Items.AddRange(new object[] {
            "BL",
            "GP",
            "Robi",
            "Airtel",
            "Citycel"});
            this.operatorComboBox.Location = new System.Drawing.Point(165, 159);
            this.operatorComboBox.Name = "operatorComboBox";
            this.operatorComboBox.Size = new System.Drawing.Size(121, 21);
            this.operatorComboBox.TabIndex = 3;
            // 
            // showTalkTimeLabel
            // 
            this.showTalkTimeLabel.AutoSize = true;
            this.showTalkTimeLabel.Location = new System.Drawing.Point(102, 306);
            this.showTalkTimeLabel.Name = "showTalkTimeLabel";
            this.showTalkTimeLabel.Size = new System.Drawing.Size(75, 13);
            this.showTalkTimeLabel.TabIndex = 1;
            this.showTalkTimeLabel.Text = "Taking Time : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 379);
            this.Controls.Add(this.operatorComboBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.calculateTakTimeButton);
            this.Controls.Add(this.showTalkTimeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.balanceTextBox);
            this.Name = "Form1";
            this.Text = "Calculate Taking Time ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculateTakTimeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.ComboBox operatorComboBox;
        private System.Windows.Forms.Label showTalkTimeLabel;
    }
}

