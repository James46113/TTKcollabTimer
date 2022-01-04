namespace TTKcollabTimer
{
    partial class PopOutForm
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeBox
            // 
            this.timeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.timeBox.Location = new System.Drawing.Point(0, 1);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(219, 73);
            this.timeBox.TabIndex = 24;
            this.timeBox.Text = " temp = timeBox.Text.Split(\':\');";
            this.timeBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PopOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 75);
            this.Controls.Add(this.timeBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PopOutForm";
            this.Text = "PopOutForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeBox;
    }
}