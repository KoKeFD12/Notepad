namespace Notepad
{
    partial class FontForm
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
            this.fontLabel = new System.Windows.Forms.Label();
            this.fontStyleLabel = new System.Windows.Forms.Label();
            this.fontSizeLabel = new System.Windows.Forms.Label();
            this.fontListBox = new System.Windows.Forms.ListBox();
            this.fontTextBox = new System.Windows.Forms.TextBox();
            this.fontStyleTextBox = new System.Windows.Forms.TextBox();
            this.fontStyleListBox = new System.Windows.Forms.ListBox();
            this.fontSizeTextBox = new System.Windows.Forms.TextBox();
            this.fontSizeListBox = new System.Windows.Forms.ListBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.sampleGroupBox = new System.Windows.Forms.GroupBox();
            this.sampleTextBox = new System.Windows.Forms.TextBox();
            this.fontColorButton = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.sampleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fontLabel
            // 
            this.fontLabel.AutoSize = true;
            this.fontLabel.Location = new System.Drawing.Point(17, 15);
            this.fontLabel.Name = "fontLabel";
            this.fontLabel.Size = new System.Drawing.Size(31, 13);
            this.fontLabel.TabIndex = 0;
            this.fontLabel.Text = "Font:";
            // 
            // fontStyleLabel
            // 
            this.fontStyleLabel.AutoSize = true;
            this.fontStyleLabel.Location = new System.Drawing.Point(186, 15);
            this.fontStyleLabel.Name = "fontStyleLabel";
            this.fontStyleLabel.Size = new System.Drawing.Size(55, 13);
            this.fontStyleLabel.TabIndex = 1;
            this.fontStyleLabel.Text = "Font style:";
            // 
            // fontSizeLabel
            // 
            this.fontSizeLabel.AutoSize = true;
            this.fontSizeLabel.Location = new System.Drawing.Point(319, 15);
            this.fontSizeLabel.Name = "fontSizeLabel";
            this.fontSizeLabel.Size = new System.Drawing.Size(30, 13);
            this.fontSizeLabel.TabIndex = 2;
            this.fontSizeLabel.Text = "Size:";
            // 
            // fontListBox
            // 
            this.fontListBox.FormattingEnabled = true;
            this.fontListBox.Location = new System.Drawing.Point(20, 57);
            this.fontListBox.Name = "fontListBox";
            this.fontListBox.Size = new System.Drawing.Size(157, 95);
            this.fontListBox.TabIndex = 3;
            this.fontListBox.SelectedIndexChanged += new System.EventHandler(this.updateFontTextBox);
            // 
            // fontTextBox
            // 
            this.fontTextBox.Location = new System.Drawing.Point(20, 31);
            this.fontTextBox.Name = "fontTextBox";
            this.fontTextBox.Size = new System.Drawing.Size(157, 20);
            this.fontTextBox.TabIndex = 4;
            this.fontTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.updateSampleFontKeyPress);
            // 
            // fontStyleTextBox
            // 
            this.fontStyleTextBox.Location = new System.Drawing.Point(189, 31);
            this.fontStyleTextBox.Name = "fontStyleTextBox";
            this.fontStyleTextBox.Size = new System.Drawing.Size(120, 20);
            this.fontStyleTextBox.TabIndex = 6;
            this.fontStyleTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.updateSampleFontKeyPress);
            // 
            // fontStyleListBox
            // 
            this.fontStyleListBox.FormattingEnabled = true;
            this.fontStyleListBox.Items.AddRange(new object[] {
            "Regular",
            "Italic",
            "Bold",
            "Bold Italic"});
            this.fontStyleListBox.Location = new System.Drawing.Point(189, 57);
            this.fontStyleListBox.Name = "fontStyleListBox";
            this.fontStyleListBox.Size = new System.Drawing.Size(120, 95);
            this.fontStyleListBox.TabIndex = 5;
            this.fontStyleListBox.SelectedIndexChanged += new System.EventHandler(this.updateFontStyleTextBox);
            // 
            // fontSizeTextBox
            // 
            this.fontSizeTextBox.Location = new System.Drawing.Point(322, 31);
            this.fontSizeTextBox.Name = "fontSizeTextBox";
            this.fontSizeTextBox.Size = new System.Drawing.Size(58, 20);
            this.fontSizeTextBox.TabIndex = 8;
            this.fontSizeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.updateSampleFontKeyPress);
            // 
            // fontSizeListBox
            // 
            this.fontSizeListBox.FormattingEnabled = true;
            this.fontSizeListBox.Location = new System.Drawing.Point(322, 57);
            this.fontSizeListBox.Name = "fontSizeListBox";
            this.fontSizeListBox.Size = new System.Drawing.Size(58, 95);
            this.fontSizeListBox.TabIndex = 7;
            this.fontSizeListBox.SelectedIndexChanged += new System.EventHandler(this.updateFontSizeTextBox);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(391, 30);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 9;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(391, 59);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.exit);
            // 
            // sampleGroupBox
            // 
            this.sampleGroupBox.AutoSize = true;
            this.sampleGroupBox.Controls.Add(this.sampleTextBox);
            this.sampleGroupBox.Location = new System.Drawing.Point(189, 163);
            this.sampleGroupBox.Name = "sampleGroupBox";
            this.sampleGroupBox.Size = new System.Drawing.Size(178, 80);
            this.sampleGroupBox.TabIndex = 11;
            this.sampleGroupBox.TabStop = false;
            this.sampleGroupBox.Text = "Sample";
            // 
            // sampleTextBox
            // 
            this.sampleTextBox.Enabled = false;
            this.sampleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sampleTextBox.Location = new System.Drawing.Point(37, 32);
            this.sampleTextBox.MaximumSize = new System.Drawing.Size(100, 40);
            this.sampleTextBox.MaxLength = 8;
            this.sampleTextBox.MinimumSize = new System.Drawing.Size(100, 30);
            this.sampleTextBox.Name = "sampleTextBox";
            this.sampleTextBox.Size = new System.Drawing.Size(100, 21);
            this.sampleTextBox.TabIndex = 0;
            this.sampleTextBox.Text = "AaBbYyZz";
            this.sampleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fontColorButton
            // 
            this.fontColorButton.Location = new System.Drawing.Point(42, 190);
            this.fontColorButton.Name = "fontColorButton";
            this.fontColorButton.Size = new System.Drawing.Size(118, 32);
            this.fontColorButton.TabIndex = 12;
            this.fontColorButton.Text = "Font color";
            this.fontColorButton.UseVisualStyleBackColor = true;
            this.fontColorButton.Click += new System.EventHandler(this.colorPicker);
            // 
            // FontForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 278);
            this.Controls.Add(this.fontColorButton);
            this.Controls.Add(this.sampleGroupBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.fontSizeTextBox);
            this.Controls.Add(this.fontSizeListBox);
            this.Controls.Add(this.fontStyleTextBox);
            this.Controls.Add(this.fontStyleListBox);
            this.Controls.Add(this.fontTextBox);
            this.Controls.Add(this.fontListBox);
            this.Controls.Add(this.fontSizeLabel);
            this.Controls.Add(this.fontStyleLabel);
            this.Controls.Add(this.fontLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FontForm";
            this.Text = "Font";
            this.sampleGroupBox.ResumeLayout(false);
            this.sampleGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fontLabel;
        private System.Windows.Forms.Label fontStyleLabel;
        private System.Windows.Forms.Label fontSizeLabel;
        private System.Windows.Forms.ListBox fontListBox;
        private System.Windows.Forms.TextBox fontTextBox;
        private System.Windows.Forms.TextBox fontStyleTextBox;
        private System.Windows.Forms.ListBox fontStyleListBox;
        private System.Windows.Forms.TextBox fontSizeTextBox;
        private System.Windows.Forms.ListBox fontSizeListBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox sampleGroupBox;
        private System.Windows.Forms.TextBox sampleTextBox;
        private System.Windows.Forms.Button fontColorButton;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}