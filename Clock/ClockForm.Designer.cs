namespace Clock
{
    partial class ClockForm
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
            this.TimeLabel = new System.Windows.Forms.Label();
            this.SecondsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(3, 1);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(154, 56);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "00:00";
            // 
            // SecondsLabel
            // 
            this.SecondsLabel.AutoSize = true;
            this.SecondsLabel.BackColor = System.Drawing.Color.Transparent;
            this.SecondsLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondsLabel.Location = new System.Drawing.Point(145, 29);
            this.SecondsLabel.Name = "SecondsLabel";
            this.SecondsLabel.Size = new System.Drawing.Size(40, 22);
            this.SecondsLabel.TabIndex = 1;
            this.SecondsLabel.Text = ":00";
            // 
            // ClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 54);
            this.Controls.Add(this.SecondsLabel);
            this.Controls.Add(this.TimeLabel);
            this.Name = "ClockForm";
            this.Text = "Clock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label SecondsLabel;
    }
}

