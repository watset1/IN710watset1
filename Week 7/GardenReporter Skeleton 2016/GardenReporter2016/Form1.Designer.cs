namespace GardenReporter2016
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
            this.btnArea = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCharges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(17, 42);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(177, 62);
            this.btnArea.TabIndex = 0;
            this.btnArea.Text = "Area Report";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // btnBalance
            // 
            this.btnBalance.Location = new System.Drawing.Point(200, 42);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(177, 62);
            this.btnBalance.TabIndex = 1;
            this.btnBalance.Text = "Account Report";
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(17, 130);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(543, 422);
            this.listBox1.TabIndex = 2;
            // 
            // btnCharges
            // 
            this.btnCharges.Location = new System.Drawing.Point(383, 42);
            this.btnCharges.Name = "btnCharges";
            this.btnCharges.Size = new System.Drawing.Size(177, 62);
            this.btnCharges.TabIndex = 3;
            this.btnCharges.Text = "Charges Report";
            this.btnCharges.UseVisualStyleBackColor = true;
            this.btnCharges.Click += new System.EventHandler(this.btnCharges_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 575);
            this.Controls.Add(this.btnCharges);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnBalance);
            this.Controls.Add(this.btnArea);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Garden Reporter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCharges;


    }
}

