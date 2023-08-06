namespace Time_Zone
{
    partial class promptLabel
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
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.timeZoneLabel = new System.Windows.Forms.Label();
            this.cityListBox = new System.Windows.Forms.ListBox();
            this.okButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(655, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a city and I will give you the time zone.";
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(142, 404);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(179, 37);
            this.outputDescriptionLabel.TabIndex = 1;
            this.outputDescriptionLabel.Text = "Time Zone:";
            // 
            // timeZoneLabel
            // 
            this.timeZoneLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeZoneLabel.Location = new System.Drawing.Point(358, 392);
            this.timeZoneLabel.Name = "timeZoneLabel";
            this.timeZoneLabel.Size = new System.Drawing.Size(296, 60);
            this.timeZoneLabel.TabIndex = 2;
            this.timeZoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cityListBox
            // 
            this.cityListBox.FormattingEnabled = true;
            this.cityListBox.ItemHeight = 37;
            this.cityListBox.Items.AddRange(new object[] {
            "Denver",
            "Honolulu",
            "Minneapolis",
            "New York",
            "San Francisco"});
            this.cityListBox.Location = new System.Drawing.Point(211, 140);
            this.cityListBox.Name = "cityListBox";
            this.cityListBox.Size = new System.Drawing.Size(373, 226);
            this.cityListBox.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.okButton.Location = new System.Drawing.Point(149, 506);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(245, 56);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.exitButton.Location = new System.Drawing.Point(416, 505);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(224, 57);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // promptLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 627);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cityListBox);
            this.Controls.Add(this.timeZoneLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.label1);
            this.Name = "promptLabel";
            this.Text = "Time Zone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label timeZoneLabel;
        private System.Windows.Forms.ListBox cityListBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button exitButton;
    }
}

