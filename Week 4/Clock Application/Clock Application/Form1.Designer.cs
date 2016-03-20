namespace Clock_Application
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
            this.lblDigitalDisplay = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.analogClock1 = new AnalogClockControl.AnalogClock();
            this.btnOn = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdDigital = new System.Windows.Forms.RadioButton();
            this.rdAnalog = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDigitalDisplay
            // 
            this.lblDigitalDisplay.AutoSize = true;
            this.lblDigitalDisplay.Font = new System.Drawing.Font("Lucida Fax", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigitalDisplay.Location = new System.Drawing.Point(26, 208);
            this.lblDigitalDisplay.Name = "lblDigitalDisplay";
            this.lblDigitalDisplay.Size = new System.Drawing.Size(342, 109);
            this.lblDigitalDisplay.TabIndex = 0;
            this.lblDigitalDisplay.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // analogClock1
            // 
            this.analogClock1.Draw1MinuteTicks = true;
            this.analogClock1.Draw5MinuteTicks = true;
            this.analogClock1.HourHandColor = System.Drawing.Color.DarkMagenta;
            this.analogClock1.Location = new System.Drawing.Point(75, 97);
            this.analogClock1.MinuteHandColor = System.Drawing.Color.Green;
            this.analogClock1.Name = "analogClock1";
            this.analogClock1.SecondHandColor = System.Drawing.Color.Red;
            this.analogClock1.Size = new System.Drawing.Size(342, 342);
            this.analogClock1.TabIndex = 1;
            this.analogClock1.TicksColor = System.Drawing.Color.Black;
            this.analogClock1.Visible = false;
            // 
            // btnOn
            // 
            this.btnOn.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOn.Location = new System.Drawing.Point(12, 12);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(93, 52);
            this.btnOn.TabIndex = 2;
            this.btnOn.Text = "On";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // btnOff
            // 
            this.btnOff.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOff.Location = new System.Drawing.Point(111, 12);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(93, 52);
            this.btnOff.TabIndex = 3;
            this.btnOff.Text = "Off";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click_1);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdAnalog);
            this.groupBox1.Controls.Add(this.rdDigital);
            this.groupBox1.Location = new System.Drawing.Point(311, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // rdDigital
            // 
            this.rdDigital.AutoSize = true;
            this.rdDigital.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDigital.Location = new System.Drawing.Point(7, 20);
            this.rdDigital.Name = "rdDigital";
            this.rdDigital.Size = new System.Drawing.Size(94, 28);
            this.rdDigital.TabIndex = 0;
            this.rdDigital.TabStop = true;
            this.rdDigital.Text = "Digital";
            this.rdDigital.UseVisualStyleBackColor = true;
            // 
            // rdAnalog
            // 
            this.rdAnalog.AutoSize = true;
            this.rdAnalog.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAnalog.Location = new System.Drawing.Point(6, 54);
            this.rdAnalog.Name = "rdAnalog";
            this.rdAnalog.Size = new System.Drawing.Size(122, 28);
            this.rdAnalog.TabIndex = 1;
            this.rdAnalog.TabStop = true;
            this.rdAnalog.Text = "Analogue";
            this.rdAnalog.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 451);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.analogClock1);
            this.Controls.Add(this.lblDigitalDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDigitalDisplay;
        private System.Windows.Forms.Timer timer1;
        private AnalogClockControl.AnalogClock analogClock1;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdAnalog;
        private System.Windows.Forms.RadioButton rdDigital;

    }
}

