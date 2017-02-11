namespace Timer_digital
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
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hours = new System.Windows.Forms.Label();
            this.notneeded1 = new System.Windows.Forms.Label();
            this.seconds = new System.Windows.Forms.Label();
            this.minutes = new System.Windows.Forms.Label();
            this.hour_textbox = new System.Windows.Forms.TextBox();
            this.notneeded2 = new System.Windows.Forms.Label();
            this.minutes_textbox = new System.Windows.Forms.TextBox();
            this.seconds_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Green;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.Color.White;
            this.start.Location = new System.Drawing.Point(158, 606);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(369, 115);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.Red;
            this.stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop.ForeColor = System.Drawing.Color.White;
            this.stop.Location = new System.Drawing.Point(736, 606);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(371, 115);
            this.stop.TabIndex = 1;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hours
            // 
            this.hours.AutoSize = true;
            this.hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 200.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours.Location = new System.Drawing.Point(52, 205);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(275, 302);
            this.hours.TabIndex = 2;
            this.hours.Text = "0";
            // 
            // notneeded1
            // 
            this.notneeded1.AutoSize = true;
            this.notneeded1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notneeded1.Location = new System.Drawing.Point(413, 299);
            this.notneeded1.Name = "notneeded1";
            this.notneeded1.Size = new System.Drawing.Size(72, 108);
            this.notneeded1.TabIndex = 3;
            this.notneeded1.Text = ":";
            // 
            // seconds
            // 
            this.seconds.AutoSize = true;
            this.seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 200.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seconds.Location = new System.Drawing.Point(994, 205);
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(275, 302);
            this.seconds.TabIndex = 4;
            this.seconds.Text = "0";
            // 
            // minutes
            // 
            this.minutes.AutoSize = true;
            this.minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 200.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutes.Location = new System.Drawing.Point(556, 205);
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(275, 302);
            this.minutes.TabIndex = 6;
            this.minutes.Text = "0";
            // 
            // hour_textbox
            // 
            this.hour_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hour_textbox.Location = new System.Drawing.Point(103, 90);
            this.hour_textbox.Name = "hour_textbox";
            this.hour_textbox.Size = new System.Drawing.Size(123, 62);
            this.hour_textbox.TabIndex = 9;
            // 
            // notneeded2
            // 
            this.notneeded2.AutoSize = true;
            this.notneeded2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notneeded2.Location = new System.Drawing.Point(916, 299);
            this.notneeded2.Name = "notneeded2";
            this.notneeded2.Size = new System.Drawing.Size(72, 108);
            this.notneeded2.TabIndex = 10;
            this.notneeded2.Text = ":";
            // 
            // minutes_textbox
            // 
            this.minutes_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutes_textbox.Location = new System.Drawing.Point(607, 90);
            this.minutes_textbox.Name = "minutes_textbox";
            this.minutes_textbox.Size = new System.Drawing.Size(123, 62);
            this.minutes_textbox.TabIndex = 11;
            // 
            // seconds_textbox
            // 
            this.seconds_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seconds_textbox.Location = new System.Drawing.Point(1054, 90);
            this.seconds_textbox.Name = "seconds_textbox";
            this.seconds_textbox.Size = new System.Drawing.Size(123, 62);
            this.seconds_textbox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1217, 733);
            this.Controls.Add(this.seconds_textbox);
            this.Controls.Add(this.minutes_textbox);
            this.Controls.Add(this.notneeded2);
            this.Controls.Add(this.hour_textbox);
            this.Controls.Add(this.minutes);
            this.Controls.Add(this.seconds);
            this.Controls.Add(this.notneeded1);
            this.Controls.Add(this.hours);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label hours;
        private System.Windows.Forms.Label notneeded1;
        private System.Windows.Forms.Label seconds;
        private System.Windows.Forms.Label minutes;
        private System.Windows.Forms.TextBox hour_textbox;
        private System.Windows.Forms.Label notneeded2;
        private System.Windows.Forms.TextBox minutes_textbox;
        private System.Windows.Forms.TextBox seconds_textbox;
    }
}

