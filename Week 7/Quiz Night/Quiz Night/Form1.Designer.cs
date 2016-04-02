namespace Quiz_Night
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoChild = new System.Windows.Forms.RadioButton();
            this.rdoAdult = new System.Windows.Forms.RadioButton();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.txtCorrectInput = new System.Windows.Forms.TextBox();
            this.txtIncorrectInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblComputedScore = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoChild);
            this.groupBox1.Controls.Add(this.rdoAdult);
            this.groupBox1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Team type";
            // 
            // rdoChild
            // 
            this.rdoChild.AutoSize = true;
            this.rdoChild.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChild.Location = new System.Drawing.Point(6, 69);
            this.rdoChild.Name = "rdoChild";
            this.rdoChild.Size = new System.Drawing.Size(80, 26);
            this.rdoChild.TabIndex = 1;
            this.rdoChild.TabStop = true;
            this.rdoChild.Text = "Child";
            this.rdoChild.UseVisualStyleBackColor = true;
            // 
            // rdoAdult
            // 
            this.rdoAdult.AutoSize = true;
            this.rdoAdult.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAdult.Location = new System.Drawing.Point(7, 27);
            this.rdoAdult.Name = "rdoAdult";
            this.rdoAdult.Size = new System.Drawing.Size(81, 26);
            this.rdoAdult.TabIndex = 0;
            this.rdoAdult.TabStop = true;
            this.rdoAdult.Text = "Adult";
            this.rdoAdult.UseVisualStyleBackColor = true;
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.Location = new System.Drawing.Point(231, 39);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(120, 19);
            this.lblCorrect.TabIndex = 1;
            this.lblCorrect.Text = "Correct Scores";
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrect.Location = new System.Drawing.Point(231, 75);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(132, 19);
            this.lblIncorrect.TabIndex = 2;
            this.lblIncorrect.Text = "Incorrect Scores";
            // 
            // txtCorrectInput
            // 
            this.txtCorrectInput.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorrectInput.Location = new System.Drawing.Point(382, 39);
            this.txtCorrectInput.Name = "txtCorrectInput";
            this.txtCorrectInput.Size = new System.Drawing.Size(153, 26);
            this.txtCorrectInput.TabIndex = 3;
            this.txtCorrectInput.Text = "10";
            // 
            // txtIncorrectInput
            // 
            this.txtIncorrectInput.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncorrectInput.Location = new System.Drawing.Point(382, 75);
            this.txtIncorrectInput.Name = "txtIncorrectInput";
            this.txtIncorrectInput.Size = new System.Drawing.Size(153, 26);
            this.txtIncorrectInput.TabIndex = 4;
            this.txtIncorrectInput.Text = "5";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(219, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Compute Score";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblComputedScore
            // 
            this.lblComputedScore.AutoSize = true;
            this.lblComputedScore.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputedScore.Location = new System.Drawing.Point(3, 3);
            this.lblComputedScore.Name = "lblComputedScore";
            this.lblComputedScore.Size = new System.Drawing.Size(0, 19);
            this.lblComputedScore.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblComputedScore);
            this.panel1.Location = new System.Drawing.Point(382, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 26);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 189);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIncorrectInput);
            this.Controls.Add(this.txtCorrectInput);
            this.Controls.Add(this.lblIncorrect);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Quiz Scorer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoChild;
        private System.Windows.Forms.RadioButton rdoAdult;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblIncorrect;
        private System.Windows.Forms.TextBox txtCorrectInput;
        private System.Windows.Forms.TextBox txtIncorrectInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblComputedScore;
        private System.Windows.Forms.Panel panel1;
    }
}

