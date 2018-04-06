namespace SchoolMascotThomasA
{
    partial class frmSchoolMascot
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
            this.grbSchool = new System.Windows.Forms.GroupBox();
            this.lblSchoolName = new System.Windows.Forms.Label();
            this.lblSchoolMascot = new System.Windows.Forms.Label();
            this.mnuSchools = new System.Windows.Forms.MenuStrip();
            this.mniSchools = new System.Windows.Forms.ToolStripMenuItem();
            this.mniImmaculata = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAdrian = new System.Windows.Forms.ToolStripMenuItem();
            this.mniBellevueWest = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCloverPark = new System.Windows.Forms.ToolStripMenuItem();
            this.grbSchool.SuspendLayout();
            this.mnuSchools.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSchool
            // 
            this.grbSchool.Controls.Add(this.lblSchoolMascot);
            this.grbSchool.Controls.Add(this.lblSchoolName);
            this.grbSchool.Location = new System.Drawing.Point(122, 83);
            this.grbSchool.Name = "grbSchool";
            this.grbSchool.Size = new System.Drawing.Size(368, 178);
            this.grbSchool.TabIndex = 0;
            this.grbSchool.TabStop = false;
            // 
            // lblSchoolName
            // 
            this.lblSchoolName.AutoSize = true;
            this.lblSchoolName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolName.Location = new System.Drawing.Point(41, 49);
            this.lblSchoolName.Name = "lblSchoolName";
            this.lblSchoolName.Size = new System.Drawing.Size(272, 29);
            this.lblSchoolName.TabIndex = 0;
            this.lblSchoolName.Text = "Immaculata High School";
            // 
            // lblSchoolMascot
            // 
            this.lblSchoolMascot.AutoSize = true;
            this.lblSchoolMascot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolMascot.Location = new System.Drawing.Point(41, 92);
            this.lblSchoolMascot.Name = "lblSchoolMascot";
            this.lblSchoolMascot.Size = new System.Drawing.Size(85, 29);
            this.lblSchoolMascot.TabIndex = 1;
            this.lblSchoolMascot.Text = "Saints";
            // 
            // mnuSchools
            // 
            this.mnuSchools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniSchools});
            this.mnuSchools.Location = new System.Drawing.Point(0, 0);
            this.mnuSchools.Name = "mnuSchools";
            this.mnuSchools.Size = new System.Drawing.Size(648, 24);
            this.mnuSchools.TabIndex = 1;
            // 
            // mniSchools
            // 
            this.mniSchools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniImmaculata,
            this.mniAdrian,
            this.mniBellevueWest,
            this.mniCloverPark});
            this.mniSchools.Name = "mniSchools";
            this.mniSchools.Size = new System.Drawing.Size(60, 20);
            this.mniSchools.Text = "Schools";
            // 
            // mniImmaculata
            // 
            this.mniImmaculata.Name = "mniImmaculata";
            this.mniImmaculata.Size = new System.Drawing.Size(152, 22);
            this.mniImmaculata.Text = "Immaculata";
            this.mniImmaculata.Click += new System.EventHandler(this.mniImmaculata_Click);
            // 
            // mniAdrian
            // 
            this.mniAdrian.Name = "mniAdrian";
            this.mniAdrian.Size = new System.Drawing.Size(152, 22);
            this.mniAdrian.Text = "Adrian";
            this.mniAdrian.Click += new System.EventHandler(this.mniAdrian_Click);
            // 
            // mniBellevueWest
            // 
            this.mniBellevueWest.Name = "mniBellevueWest";
            this.mniBellevueWest.Size = new System.Drawing.Size(152, 22);
            this.mniBellevueWest.Text = "Bellevue West";
            this.mniBellevueWest.Click += new System.EventHandler(this.mniBellevueWest_Click);
            // 
            // mniCloverPark
            // 
            this.mniCloverPark.Name = "mniCloverPark";
            this.mniCloverPark.Size = new System.Drawing.Size(152, 22);
            this.mniCloverPark.Text = "Clover Park";
            this.mniCloverPark.Click += new System.EventHandler(this.mniCloverPark_Click);
            // 
            // frmSchoolMascot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 321);
            this.Controls.Add(this.grbSchool);
            this.Controls.Add(this.mnuSchools);
            this.Name = "frmSchoolMascot";
            this.Text = "School Mascot By Thomas Aubin";
            this.grbSchool.ResumeLayout(false);
            this.grbSchool.PerformLayout();
            this.mnuSchools.ResumeLayout(false);
            this.mnuSchools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSchool;
        private System.Windows.Forms.Label lblSchoolMascot;
        private System.Windows.Forms.Label lblSchoolName;
        private System.Windows.Forms.MenuStrip mnuSchools;
        private System.Windows.Forms.ToolStripMenuItem mniSchools;
        private System.Windows.Forms.ToolStripMenuItem mniImmaculata;
        private System.Windows.Forms.ToolStripMenuItem mniAdrian;
        private System.Windows.Forms.ToolStripMenuItem mniBellevueWest;
        private System.Windows.Forms.ToolStripMenuItem mniCloverPark;
    }
}

