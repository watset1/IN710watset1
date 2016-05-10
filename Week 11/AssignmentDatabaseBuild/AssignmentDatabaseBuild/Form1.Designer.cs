namespace AssignmentDatabaseBuild
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
            this.btnCreateTables = new System.Windows.Forms.Button();
            this.btnSeedData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateTables
            // 
            this.btnCreateTables.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTables.Location = new System.Drawing.Point(12, 12);
            this.btnCreateTables.Name = "btnCreateTables";
            this.btnCreateTables.Size = new System.Drawing.Size(260, 41);
            this.btnCreateTables.TabIndex = 0;
            this.btnCreateTables.Text = "Create Tables";
            this.btnCreateTables.UseVisualStyleBackColor = true;
            this.btnCreateTables.Click += new System.EventHandler(this.btnCreateTables_Click);
            // 
            // btnSeedData
            // 
            this.btnSeedData.Enabled = false;
            this.btnSeedData.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeedData.Location = new System.Drawing.Point(12, 59);
            this.btnSeedData.Name = "btnSeedData";
            this.btnSeedData.Size = new System.Drawing.Size(260, 41);
            this.btnSeedData.TabIndex = 1;
            this.btnSeedData.Text = "Seed Data";
            this.btnSeedData.UseVisualStyleBackColor = true;
            this.btnSeedData.Click += new System.EventHandler(this.btnSeedData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 113);
            this.Controls.Add(this.btnSeedData);
            this.Controls.Add(this.btnCreateTables);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTables;
        private System.Windows.Forms.Button btnSeedData;
    }
}

