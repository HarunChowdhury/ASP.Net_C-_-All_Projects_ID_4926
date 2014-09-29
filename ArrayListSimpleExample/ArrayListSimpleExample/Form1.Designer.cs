namespace ArrayListSimpleExample
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
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputDataTextBox = new System.Windows.Forms.TextBox();
            this.showDataListBox = new System.Windows.Forms.ListBox();
            this.showAllDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(269, 45);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(55, 35);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Data";
            // 
            // inputDataTextBox
            // 
            this.inputDataTextBox.Location = new System.Drawing.Point(141, 60);
            this.inputDataTextBox.Name = "inputDataTextBox";
            this.inputDataTextBox.Size = new System.Drawing.Size(100, 20);
            this.inputDataTextBox.TabIndex = 2;
            // 
            // showDataListBox
            // 
            this.showDataListBox.FormattingEnabled = true;
            this.showDataListBox.Location = new System.Drawing.Point(103, 168);
            this.showDataListBox.Name = "showDataListBox";
            this.showDataListBox.Size = new System.Drawing.Size(120, 95);
            this.showDataListBox.TabIndex = 3;
            // 
            // showAllDataButton
            // 
            this.showAllDataButton.Location = new System.Drawing.Point(249, 168);
            this.showAllDataButton.Name = "showAllDataButton";
            this.showAllDataButton.Size = new System.Drawing.Size(75, 44);
            this.showAllDataButton.TabIndex = 4;
            this.showAllDataButton.Text = "Show All Data";
            this.showAllDataButton.UseVisualStyleBackColor = true;
            this.showAllDataButton.Click += new System.EventHandler(this.showAllDataButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 333);
            this.Controls.Add(this.showAllDataButton);
            this.Controls.Add(this.showDataListBox);
            this.Controls.Add(this.inputDataTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Array List Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputDataTextBox;
        private System.Windows.Forms.ListBox showDataListBox;
        private System.Windows.Forms.Button showAllDataButton;
    }
}

