namespace WindowsFormsApp3
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
            this.textLable = new System.Windows.Forms.Label();
            this.times = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textLable
            // 
            this.textLable.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textLable.Location = new System.Drawing.Point(19, 93);
            this.textLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textLable.Name = "textLable";
            this.textLable.Size = new System.Drawing.Size(83, 26);
            this.textLable.TabIndex = 0;
            // 
            // times
            // 
            this.times.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.times.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.times.Location = new System.Drawing.Point(20, 128);
            this.times.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(76, 26);
            this.times.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.saffafa;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.times);
            this.Controls.Add(this.textLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label textLable;
        private System.Windows.Forms.Label times;
    }
}

