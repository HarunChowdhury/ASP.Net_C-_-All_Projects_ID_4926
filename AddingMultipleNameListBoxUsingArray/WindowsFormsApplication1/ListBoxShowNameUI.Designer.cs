namespace WindowsFormsApplication1
{
    partial class ListBoxShowNameUI
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
            this.nameAddButton = new System.Windows.Forms.Button();
            this.showAllButton = new System.Windows.Forms.Button();
            this.nameResetButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addCountLabel = new System.Windows.Forms.Label();
            this.nameListBox = new System.Windows.Forms.ListBox();
            this.setCountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.setCountButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameAddButton
            // 
            this.nameAddButton.Location = new System.Drawing.Point(157, 84);
            this.nameAddButton.Name = "nameAddButton";
            this.nameAddButton.Size = new System.Drawing.Size(75, 35);
            this.nameAddButton.TabIndex = 0;
            this.nameAddButton.Text = "+ADD";
            this.nameAddButton.UseVisualStyleBackColor = true;
            this.nameAddButton.Click += new System.EventHandler(this.nameAddButton_Click);
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(275, 223);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(89, 41);
            this.showAllButton.TabIndex = 1;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // nameResetButton
            // 
            this.nameResetButton.Location = new System.Drawing.Point(238, 84);
            this.nameResetButton.Name = "nameResetButton";
            this.nameResetButton.Size = new System.Drawing.Size(75, 35);
            this.nameResetButton.TabIndex = 2;
            this.nameResetButton.Text = "RESET";
            this.nameResetButton.UseVisualStyleBackColor = true;
            this.nameResetButton.Click += new System.EventHandler(this.nameResetButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.addCountLabel);
            this.groupBox1.Controls.Add(this.nameAddButton);
            this.groupBox1.Controls.Add(this.nameResetButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 143);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(99, 34);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(151, 30);
            this.nameTextBox.TabIndex = 4;
            // 
            // addCountLabel
            // 
            this.addCountLabel.AutoSize = true;
            this.addCountLabel.Location = new System.Drawing.Point(69, 128);
            this.addCountLabel.Name = "addCountLabel";
            this.addCountLabel.Size = new System.Drawing.Size(66, 13);
            this.addCountLabel.TabIndex = 3;
            this.addCountLabel.Text = "Add Count : ";
            // 
            // nameListBox
            // 
            this.nameListBox.FormattingEnabled = true;
            this.nameListBox.Location = new System.Drawing.Point(12, 279);
            this.nameListBox.Name = "nameListBox";
            this.nameListBox.Size = new System.Drawing.Size(352, 134);
            this.nameListBox.TabIndex = 4;
            // 
            // setCountTextBox
            // 
            this.setCountTextBox.Location = new System.Drawing.Point(111, 36);
            this.setCountTextBox.Name = "setCountTextBox";
            this.setCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.setCountTextBox.TabIndex = 5;
            this.setCountTextBox.TextChanged += new System.EventHandler(this.setCountTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Count";
            // 
            // setCountButton
            // 
            this.setCountButton.Location = new System.Drawing.Point(235, 29);
            this.setCountButton.Name = "setCountButton";
            this.setCountButton.Size = new System.Drawing.Size(75, 32);
            this.setCountButton.TabIndex = 7;
            this.setCountButton.Text = "Set";
            this.setCountButton.UseVisualStyleBackColor = true;
            this.setCountButton.Click += new System.EventHandler(this.setCountButton_Click);
            // 
            // ListBoxShowNameUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 442);
            this.Controls.Add(this.setCountButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setCountTextBox);
            this.Controls.Add(this.nameListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.showAllButton);
            this.Name = "ListBoxShowNameUI";
            this.Text = "ListBoxShowNameUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nameAddButton;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.Button nameResetButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label addCountLabel;
        private System.Windows.Forms.ListBox nameListBox;
        private System.Windows.Forms.TextBox setCountTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button setCountButton;
    }
}

