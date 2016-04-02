namespace Predicate_Task
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnEvens = new System.Windows.Forms.Button();
            this.btnUnderTen = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(12, 12);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(218, 52);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate Random Numbers";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 79);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(218, 407);
            this.listBox1.TabIndex = 1;
            // 
            // btnEvens
            // 
            this.btnEvens.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvens.Location = new System.Drawing.Point(247, 12);
            this.btnEvens.Name = "btnEvens";
            this.btnEvens.Size = new System.Drawing.Size(101, 52);
            this.btnEvens.TabIndex = 2;
            this.btnEvens.Text = "Even Numbers";
            this.btnEvens.UseVisualStyleBackColor = true;
            this.btnEvens.Click += new System.EventHandler(this.btnEvens_Click);
            // 
            // btnUnderTen
            // 
            this.btnUnderTen.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnderTen.Location = new System.Drawing.Point(354, 12);
            this.btnUnderTen.Name = "btnUnderTen";
            this.btnUnderTen.Size = new System.Drawing.Size(108, 52);
            this.btnUnderTen.TabIndex = 3;
            this.btnUnderTen.Text = "Numbers < 10";
            this.btnUnderTen.UseVisualStyleBackColor = true;
            this.btnUnderTen.Click += new System.EventHandler(this.btnUnderTen_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(246, 79);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(218, 407);
            this.listBox2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 499);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnUnderTen);
            this.Controls.Add(this.btnEvens);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnEvens;
        private System.Windows.Forms.Button btnUnderTen;
        private System.Windows.Forms.ListBox listBox2;
    }
}

