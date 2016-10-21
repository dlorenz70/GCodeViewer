namespace gcodeparser
{
    partial class ModifyForm
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
            this.SetFeedRate = new System.Windows.Forms.Label();
            this.SetZeroLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SetFeedRate
            // 
            this.SetFeedRate.BackColor = System.Drawing.Color.GreenYellow;
            this.SetFeedRate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetFeedRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetFeedRate.ForeColor = System.Drawing.Color.DarkGreen;
            this.SetFeedRate.Location = new System.Drawing.Point(13, 251);
            this.SetFeedRate.Name = "SetFeedRate";
            this.SetFeedRate.Size = new System.Drawing.Size(259, 33);
            this.SetFeedRate.TabIndex = 5;
            this.SetFeedRate.Text = "Set Feed Rate";
            this.SetFeedRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SetZeroLabel
            // 
            this.SetZeroLabel.BackColor = System.Drawing.Color.GreenYellow;
            this.SetZeroLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetZeroLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetZeroLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.SetZeroLabel.Location = new System.Drawing.Point(13, 148);
            this.SetZeroLabel.Name = "SetZeroLabel";
            this.SetZeroLabel.Size = new System.Drawing.Size(259, 92);
            this.SetZeroLabel.TabIndex = 4;
            this.SetZeroLabel.Text = "Set current location as 0, 0, 0";
            this.SetZeroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 92);
            this.label1.TabIndex = 3;
            this.label1.Text = "Use arrow keys for X and Y axis. Press Shift for fine movement";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 303);
            this.Controls.Add(this.SetFeedRate);
            this.Controls.Add(this.SetZeroLabel);
            this.Controls.Add(this.label1);
            this.Name = "ModifyForm";
            this.ShowInTaskbar = false;
            this.Text = "ModifyForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ModifyForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SetFeedRate;
        private System.Windows.Forms.Label SetZeroLabel;
        private System.Windows.Forms.Label label1;
    }
}