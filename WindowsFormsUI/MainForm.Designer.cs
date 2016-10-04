namespace WindowsFormsUI
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
            this.DividendNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.AddRuleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AddRuleTextBox = new System.Windows.Forms.TextBox();
            this.AddRuleButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DividendNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddRuleNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // DividendNumericUpDown
            // 
            this.DividendNumericUpDown.Location = new System.Drawing.Point(12, 12);
            this.DividendNumericUpDown.Name = "DividendNumericUpDown";
            this.DividendNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.DividendNumericUpDown.TabIndex = 0;
            this.DividendNumericUpDown.ValueChanged += new System.EventHandler(this.DividendNumericUpDown_ValueChanged);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.Location = new System.Drawing.Point(12, 35);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(0, 20);
            this.MessageLabel.TabIndex = 2;
            // 
            // AddRuleNumericUpDown
            // 
            this.AddRuleNumericUpDown.Location = new System.Drawing.Point(12, 121);
            this.AddRuleNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AddRuleNumericUpDown.Name = "AddRuleNumericUpDown";
            this.AddRuleNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.AddRuleNumericUpDown.TabIndex = 3;
            this.AddRuleNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddRuleTextBox
            // 
            this.AddRuleTextBox.Location = new System.Drawing.Point(12, 148);
            this.AddRuleTextBox.Name = "AddRuleTextBox";
            this.AddRuleTextBox.Size = new System.Drawing.Size(120, 20);
            this.AddRuleTextBox.TabIndex = 4;
            // 
            // AddRuleButton
            // 
            this.AddRuleButton.Location = new System.Drawing.Point(12, 175);
            this.AddRuleButton.Name = "AddRuleButton";
            this.AddRuleButton.Size = new System.Drawing.Size(75, 23);
            this.AddRuleButton.TabIndex = 5;
            this.AddRuleButton.Text = "Add Rule";
            this.AddRuleButton.UseVisualStyleBackColor = true;
            this.AddRuleButton.Click += new System.EventHandler(this.AddRuleButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.AddRuleButton);
            this.Controls.Add(this.AddRuleTextBox);
            this.Controls.Add(this.AddRuleNumericUpDown);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.DividendNumericUpDown);
            this.Name = "MainForm";
            this.Text = "FizzBuzz";
            ((System.ComponentModel.ISupportInitialize)(this.DividendNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddRuleNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown DividendNumericUpDown;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.NumericUpDown AddRuleNumericUpDown;
        private System.Windows.Forms.TextBox AddRuleTextBox;
        private System.Windows.Forms.Button AddRuleButton;
    }
}

