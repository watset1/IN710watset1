namespace Computer_Builder
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
            this.btnPrintSpec = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdGaming = new System.Windows.Forms.RadioButton();
            this.rdBusiness = new System.Windows.Forms.RadioButton();
            this.rdMultimedia = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrintSpec
            // 
            this.btnPrintSpec.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSpec.Location = new System.Drawing.Point(29, 13);
            this.btnPrintSpec.Name = "btnPrintSpec";
            this.btnPrintSpec.Size = new System.Drawing.Size(221, 49);
            this.btnPrintSpec.TabIndex = 0;
            this.btnPrintSpec.Text = "Print Spec";
            this.btnPrintSpec.UseVisualStyleBackColor = true;
            this.btnPrintSpec.Click += new System.EventHandler(this.btnPrintSpec_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(285, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(539, 316);
            this.listBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdMultimedia);
            this.groupBox1.Controls.Add(this.rdBusiness);
            this.groupBox1.Controls.Add(this.rdGaming);
            this.groupBox1.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 264);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Machine Type";
            // 
            // rdGaming
            // 
            this.rdGaming.AutoSize = true;
            this.rdGaming.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdGaming.Location = new System.Drawing.Point(7, 48);
            this.rdGaming.Name = "rdGaming";
            this.rdGaming.Size = new System.Drawing.Size(89, 24);
            this.rdGaming.TabIndex = 0;
            this.rdGaming.TabStop = true;
            this.rdGaming.Text = "Gaming";
            this.rdGaming.UseVisualStyleBackColor = true;
            // 
            // rdBusiness
            // 
            this.rdBusiness.AutoSize = true;
            this.rdBusiness.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBusiness.Location = new System.Drawing.Point(7, 91);
            this.rdBusiness.Name = "rdBusiness";
            this.rdBusiness.Size = new System.Drawing.Size(99, 24);
            this.rdBusiness.TabIndex = 1;
            this.rdBusiness.TabStop = true;
            this.rdBusiness.Text = "Business";
            this.rdBusiness.UseVisualStyleBackColor = true;
            // 
            // rdMultimedia
            // 
            this.rdMultimedia.AutoSize = true;
            this.rdMultimedia.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMultimedia.Location = new System.Drawing.Point(7, 136);
            this.rdMultimedia.Name = "rdMultimedia";
            this.rdMultimedia.Size = new System.Drawing.Size(117, 24);
            this.rdMultimedia.TabIndex = 2;
            this.rdMultimedia.TabStop = true;
            this.rdMultimedia.Text = "Multimedia";
            this.rdMultimedia.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 406);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnPrintSpec);
            this.Name = "Form1";
            this.Text = "Computer Builder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrintSpec;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdMultimedia;
        private System.Windows.Forms.RadioButton rdBusiness;
        private System.Windows.Forms.RadioButton rdGaming;
    }
}

