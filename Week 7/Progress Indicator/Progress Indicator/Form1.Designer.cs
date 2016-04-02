namespace Progress_Indicator
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoSpinBox = new System.Windows.Forms.RadioButton();
            this.rdoProgressBar = new System.Windows.Forms.RadioButton();
            this.rdoTrackBar = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(259, 212);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(408, 45);
            this.trackBar1.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(259, 144);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(408, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(259, 74);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(22, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoTrackBar);
            this.groupBox1.Controls.Add(this.rdoProgressBar);
            this.groupBox1.Controls.Add(this.rdoSpinBox);
            this.groupBox1.Location = new System.Drawing.Point(22, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 192);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // rdoSpinBox
            // 
            this.rdoSpinBox.AutoSize = true;
            this.rdoSpinBox.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSpinBox.Location = new System.Drawing.Point(7, 40);
            this.rdoSpinBox.Name = "rdoSpinBox";
            this.rdoSpinBox.Size = new System.Drawing.Size(114, 25);
            this.rdoSpinBox.TabIndex = 0;
            this.rdoSpinBox.TabStop = true;
            this.rdoSpinBox.Text = "Spin Box";
            this.rdoSpinBox.UseVisualStyleBackColor = true;
            // 
            // rdoProgressBar
            // 
            this.rdoProgressBar.AutoSize = true;
            this.rdoProgressBar.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoProgressBar.Location = new System.Drawing.Point(7, 88);
            this.rdoProgressBar.Name = "rdoProgressBar";
            this.rdoProgressBar.Size = new System.Drawing.Size(146, 25);
            this.rdoProgressBar.TabIndex = 1;
            this.rdoProgressBar.TabStop = true;
            this.rdoProgressBar.Text = "Progress Bar";
            this.rdoProgressBar.UseVisualStyleBackColor = true;
            // 
            // rdoTrackBar
            // 
            this.rdoTrackBar.AutoSize = true;
            this.rdoTrackBar.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTrackBar.Location = new System.Drawing.Point(6, 138);
            this.rdoTrackBar.Name = "rdoTrackBar";
            this.rdoTrackBar.Size = new System.Drawing.Size(120, 25);
            this.rdoTrackBar.TabIndex = 2;
            this.rdoTrackBar.TabStop = true;
            this.rdoTrackBar.Text = "Track Bar";
            this.rdoTrackBar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 291);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.trackBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoTrackBar;
        private System.Windows.Forms.RadioButton rdoProgressBar;
        private System.Windows.Forms.RadioButton rdoSpinBox;
    }
}

