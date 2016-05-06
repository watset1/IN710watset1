namespace LightningMonitor
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
            this.btnAverageIntensity = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnThreeFires = new System.Windows.Forms.Button();
            this.btnPictureStrike = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAverageIntensity
            // 
            this.btnAverageIntensity.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAverageIntensity.Location = new System.Drawing.Point(18, 18);
            this.btnAverageIntensity.Name = "btnAverageIntensity";
            this.btnAverageIntensity.Size = new System.Drawing.Size(248, 37);
            this.btnAverageIntensity.TabIndex = 1;
            this.btnAverageIntensity.Text = "Average Lightning Strike Intensity";
            this.btnAverageIntensity.UseVisualStyleBackColor = true;
            this.btnAverageIntensity.Click += new System.EventHandler(this.btnAverageIntensity_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(286, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(576, 184);
            this.listBox1.TabIndex = 2;
            // 
            // btnThreeFires
            // 
            this.btnThreeFires.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThreeFires.Location = new System.Drawing.Point(18, 67);
            this.btnThreeFires.Name = "btnThreeFires";
            this.btnThreeFires.Size = new System.Drawing.Size(248, 37);
            this.btnThreeFires.TabIndex = 3;
            this.btnThreeFires.Text = "Largest Three Fires";
            this.btnThreeFires.UseVisualStyleBackColor = true;
            this.btnThreeFires.Click += new System.EventHandler(this.btnThreeFires_Click);
            // 
            // btnPictureStrike
            // 
            this.btnPictureStrike.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPictureStrike.Location = new System.Drawing.Point(18, 116);
            this.btnPictureStrike.Name = "btnPictureStrike";
            this.btnPictureStrike.Size = new System.Drawing.Size(248, 37);
            this.btnPictureStrike.TabIndex = 4;
            this.btnPictureStrike.Text = "Picture Strike Info";
            this.btnPictureStrike.UseVisualStyleBackColor = true;
            this.btnPictureStrike.Click += new System.EventHandler(this.btnPictureStrike_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(18, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "All Fires Caused By Lightning ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 222);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPictureStrike);
            this.Controls.Add(this.btnThreeFires);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAverageIntensity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAverageIntensity;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnThreeFires;
        private System.Windows.Forms.Button btnPictureStrike;
        private System.Windows.Forms.Button button1;
    }
}

