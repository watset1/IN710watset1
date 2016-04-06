namespace Fire_Alarm
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
            this.btnFireAlarm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoMinor = new System.Windows.Forms.RadioButton();
            this.rdoSerious = new System.Windows.Forms.RadioButton();
            this.rdoInferno = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFireAlarm
            // 
            this.btnFireAlarm.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFireAlarm.Location = new System.Drawing.Point(13, 13);
            this.btnFireAlarm.Name = "btnFireAlarm";
            this.btnFireAlarm.Size = new System.Drawing.Size(225, 55);
            this.btnFireAlarm.TabIndex = 0;
            this.btnFireAlarm.Text = "Fire Alarm";
            this.btnFireAlarm.UseVisualStyleBackColor = true;
            this.btnFireAlarm.Click += new System.EventHandler(this.btnFireAlarm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoInferno);
            this.groupBox1.Controls.Add(this.rdoSerious);
            this.groupBox1.Controls.Add(this.rdoMinor);
            this.groupBox1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 204);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fire Category";
            // 
            // rdoMinor
            // 
            this.rdoMinor.AutoSize = true;
            this.rdoMinor.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMinor.Location = new System.Drawing.Point(6, 41);
            this.rdoMinor.Name = "rdoMinor";
            this.rdoMinor.Size = new System.Drawing.Size(78, 23);
            this.rdoMinor.TabIndex = 0;
            this.rdoMinor.TabStop = true;
            this.rdoMinor.Text = "Minor";
            this.rdoMinor.UseVisualStyleBackColor = true;
            // 
            // rdoSerious
            // 
            this.rdoSerious.AutoSize = true;
            this.rdoSerious.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSerious.Location = new System.Drawing.Point(6, 88);
            this.rdoSerious.Name = "rdoSerious";
            this.rdoSerious.Size = new System.Drawing.Size(89, 23);
            this.rdoSerious.TabIndex = 1;
            this.rdoSerious.TabStop = true;
            this.rdoSerious.Text = "Serious";
            this.rdoSerious.UseVisualStyleBackColor = true;
            // 
            // rdoInferno
            // 
            this.rdoInferno.AutoSize = true;
            this.rdoInferno.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoInferno.Location = new System.Drawing.Point(6, 135);
            this.rdoInferno.Name = "rdoInferno";
            this.rdoInferno.Size = new System.Drawing.Size(87, 23);
            this.rdoInferno.TabIndex = 2;
            this.rdoInferno.TabStop = true;
            this.rdoInferno.Text = "Inferno";
            this.rdoInferno.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 308);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFireAlarm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFireAlarm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoInferno;
        private System.Windows.Forms.RadioButton rdoSerious;
        private System.Windows.Forms.RadioButton rdoMinor;
    }
}

