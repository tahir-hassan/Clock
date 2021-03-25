namespace Timer
{
    partial class TimerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerForm));
            this.TimeLabel = new System.Windows.Forms.Label();
            this.SecondsLabel = new System.Windows.Forms.Label();
            this.PausePlayButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AddOneButton = new System.Windows.Forms.Button();
            this.AddFiveButton = new System.Windows.Forms.Button();
            this.AddThirtyButton = new System.Windows.Forms.Button();
            this.AddFifteenButton = new System.Windows.Forms.Button();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(4, 1);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(195, 70);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "00:00";
            // 
            // SecondsLabel
            // 
            this.SecondsLabel.AutoSize = true;
            this.SecondsLabel.BackColor = System.Drawing.Color.Transparent;
            this.SecondsLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondsLabel.Location = new System.Drawing.Point(193, 36);
            this.SecondsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SecondsLabel.Name = "SecondsLabel";
            this.SecondsLabel.Size = new System.Drawing.Size(51, 28);
            this.SecondsLabel.TabIndex = 1;
            this.SecondsLabel.Text = ":00";
            // 
            // PausePlayButton
            // 
            this.PausePlayButton.Font = new System.Drawing.Font("Webdings", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PausePlayButton.Location = new System.Drawing.Point(16, 74);
            this.PausePlayButton.Name = "PausePlayButton";
            this.PausePlayButton.Size = new System.Drawing.Size(75, 60);
            this.PausePlayButton.TabIndex = 2;
            this.PausePlayButton.Text = "|| >";
            this.PausePlayButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Webdings", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(166, 74);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 60);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "X";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // AddOneButton
            // 
            this.AddOneButton.Font = new System.Drawing.Font("Webdings", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOneButton.Location = new System.Drawing.Point(16, 160);
            this.AddOneButton.Name = "AddOneButton";
            this.AddOneButton.Size = new System.Drawing.Size(75, 60);
            this.AddOneButton.TabIndex = 4;
            this.AddOneButton.Text = "+1";
            this.AddOneButton.UseVisualStyleBackColor = true;
            // 
            // AddFiveButton
            // 
            this.AddFiveButton.Font = new System.Drawing.Font("Webdings", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFiveButton.Location = new System.Drawing.Point(166, 160);
            this.AddFiveButton.Name = "AddFiveButton";
            this.AddFiveButton.Size = new System.Drawing.Size(75, 60);
            this.AddFiveButton.TabIndex = 5;
            this.AddFiveButton.Text = "+5";
            this.AddFiveButton.UseVisualStyleBackColor = true;
            // 
            // AddThirtyButton
            // 
            this.AddThirtyButton.Font = new System.Drawing.Font("Webdings", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddThirtyButton.Location = new System.Drawing.Point(166, 249);
            this.AddThirtyButton.Name = "AddThirtyButton";
            this.AddThirtyButton.Size = new System.Drawing.Size(75, 60);
            this.AddThirtyButton.TabIndex = 7;
            this.AddThirtyButton.Text = "+30";
            this.AddThirtyButton.UseVisualStyleBackColor = true;
            // 
            // AddFifteenButton
            // 
            this.AddFifteenButton.Font = new System.Drawing.Font("Webdings", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFifteenButton.Location = new System.Drawing.Point(16, 249);
            this.AddFifteenButton.Name = "AddFifteenButton";
            this.AddFifteenButton.Size = new System.Drawing.Size(75, 60);
            this.AddFifteenButton.TabIndex = 6;
            this.AddFifteenButton.Text = "+15";
            this.AddFifteenButton.UseVisualStyleBackColor = true;
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(269, 26);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.Size = new System.Drawing.Size(320, 283);
            this.LogTextBox.TabIndex = 8;
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(612, 330);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.AddThirtyButton);
            this.Controls.Add(this.AddFifteenButton);
            this.Controls.Add(this.AddFiveButton);
            this.Controls.Add(this.AddOneButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.PausePlayButton);
            this.Controls.Add(this.SecondsLabel);
            this.Controls.Add(this.TimeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TimerForm";
            this.Text = "Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label SecondsLabel;
        private System.Windows.Forms.Button PausePlayButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button AddOneButton;
        private System.Windows.Forms.Button AddFiveButton;
        private System.Windows.Forms.Button AddThirtyButton;
        private System.Windows.Forms.Button AddFifteenButton;
        private System.Windows.Forms.TextBox LogTextBox;
    }
}

