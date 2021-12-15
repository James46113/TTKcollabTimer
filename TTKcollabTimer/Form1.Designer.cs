namespace TTKcollabTimer
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
            this.components = new System.ComponentModel.Container();
            this.Reset = new System.Windows.Forms.Button();
            this.add30 = new System.Windows.Forms.Button();
            this.add2 = new System.Windows.Forms.Button();
            this.add5 = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.volumeUp = new System.Windows.Forms.Button();
            this.volumeDown = new System.Windows.Forms.Button();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.muteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Reset
            // 
            this.Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reset.Location = new System.Drawing.Point(13, 233);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(220, 24);
            this.Reset.TabIndex = 21;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            this.Reset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeBox_KeyPress);
            // 
            // add30
            // 
            this.add30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add30.Location = new System.Drawing.Point(14, 95);
            this.add30.Name = "add30";
            this.add30.Size = new System.Drawing.Size(221, 23);
            this.add30.TabIndex = 18;
            this.add30.Text = "+ 30 Seconds";
            this.add30.UseVisualStyleBackColor = true;
            this.add30.Click += new System.EventHandler(this.add30_Click);
            this.add30.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeBox_KeyPress);
            // 
            // add2
            // 
            this.add2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add2.Location = new System.Drawing.Point(14, 124);
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(221, 23);
            this.add2.TabIndex = 17;
            this.add2.Text = "+ 2 Minutes";
            this.add2.UseVisualStyleBackColor = true;
            this.add2.Click += new System.EventHandler(this.add2_Click);
            this.add2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeBox_KeyPress);
            // 
            // add5
            // 
            this.add5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add5.Location = new System.Drawing.Point(14, 153);
            this.add5.Name = "add5";
            this.add5.Size = new System.Drawing.Size(221, 23);
            this.add5.TabIndex = 16;
            this.add5.Text = "+ 5 Minutes";
            this.add5.UseVisualStyleBackColor = true;
            this.add5.Click += new System.EventHandler(this.add5_Click);
            this.add5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeBox_KeyPress);
            // 
            // startButton
            // 
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.Location = new System.Drawing.Point(13, 182);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(221, 45);
            this.startButton.TabIndex = 15;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            this.startButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeBox_KeyPress);
            // 
            // timeBox
            // 
            this.timeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeBox.Location = new System.Drawing.Point(15, 9);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(220, 73);
            this.timeBox.TabIndex = 22;
            this.timeBox.Text = "0:00";
            this.timeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeBox.Enter += new System.EventHandler(this.timeBox_Enter);
            this.timeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeBox_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 23;
            // 
            // volumeUp
            // 
            this.volumeUp.Location = new System.Drawing.Point(107, 263);
            this.volumeUp.Name = "volumeUp";
            this.volumeUp.Size = new System.Drawing.Size(39, 25);
            this.volumeUp.TabIndex = 24;
            this.volumeUp.Text = "+";
            this.volumeUp.UseVisualStyleBackColor = true;
            this.volumeUp.Click += new System.EventHandler(this.volumeUp_Click);
            // 
            // volumeDown
            // 
            this.volumeDown.Location = new System.Drawing.Point(195, 263);
            this.volumeDown.Name = "volumeDown";
            this.volumeDown.Size = new System.Drawing.Size(39, 25);
            this.volumeDown.TabIndex = 25;
            this.volumeDown.Text = "–";
            this.volumeDown.UseVisualStyleBackColor = true;
            this.volumeDown.Click += new System.EventHandler(this.volumeDown_Click);
            // 
            // volumeLabel
            // 
            this.volumeLabel.Location = new System.Drawing.Point(152, 269);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(37, 13);
            this.volumeLabel.TabIndex = 26;
            this.volumeLabel.Text = "100 🔊";
            this.volumeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // muteButton
            // 
            this.muteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muteButton.Location = new System.Drawing.Point(15, 262);
            this.muteButton.Name = "muteButton";
            this.muteButton.Size = new System.Drawing.Size(86, 25);
            this.muteButton.TabIndex = 27;
            this.muteButton.Text = "🔊";
            this.muteButton.UseVisualStyleBackColor = true;
            this.muteButton.Click += new System.EventHandler(this.muteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 294);
            this.Controls.Add(this.muteButton);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.volumeDown);
            this.Controls.Add(this.volumeUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.add30);
            this.Controls.Add(this.add2);
            this.Controls.Add(this.add5);
            this.Controls.Add(this.startButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeBox_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button add30;
        private System.Windows.Forms.Button add2;
        private System.Windows.Forms.Button add5;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button volumeUp;
        private System.Windows.Forms.Button volumeDown;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.Button muteButton;
    }
}

