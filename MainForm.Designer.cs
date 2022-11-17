
namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDNEWSTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTUDENTLISTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTATICSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANAGEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRINTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOURSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sCOREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.rESULTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aVGToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.staticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITREMOVEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTUDENTToolStripMenuItem,
            this.cOURSEToolStripMenuItem,
            this.sCOREToolStripMenuItem,
            this.rESULTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(901, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sTUDENTToolStripMenuItem
            // 
            this.sTUDENTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDNEWSTUDENTToolStripMenuItem,
            this.sTUDENTLISTToolStripMenuItem,
            this.sTATICSToolStripMenuItem,
            this.mANAGEToolStripMenuItem,
            this.pRINTToolStripMenuItem,
            this.eDITREMOVEToolStripMenuItem});
            this.sTUDENTToolStripMenuItem.Name = "sTUDENTToolStripMenuItem";
            this.sTUDENTToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.sTUDENTToolStripMenuItem.Text = "STUDENT";
            // 
            // aDDNEWSTUDENTToolStripMenuItem
            // 
            this.aDDNEWSTUDENTToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.aDDNEWSTUDENTToolStripMenuItem.Name = "aDDNEWSTUDENTToolStripMenuItem";
            this.aDDNEWSTUDENTToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aDDNEWSTUDENTToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.aDDNEWSTUDENTToolStripMenuItem.Text = "ADD NEW STUDENT";
            this.aDDNEWSTUDENTToolStripMenuItem.Click += new System.EventHandler(this.aDDNEWSTUDENTToolStripMenuItem_Click);
            // 
            // sTUDENTLISTToolStripMenuItem
            // 
            this.sTUDENTLISTToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.sTUDENTLISTToolStripMenuItem.Name = "sTUDENTLISTToolStripMenuItem";
            this.sTUDENTLISTToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.sTUDENTLISTToolStripMenuItem.Text = "STUDENT LIST";
            this.sTUDENTLISTToolStripMenuItem.Click += new System.EventHandler(this.sTUDENTLISTToolStripMenuItem_Click);
            // 
            // sTATICSToolStripMenuItem
            // 
            this.sTATICSToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.sTATICSToolStripMenuItem.Name = "sTATICSToolStripMenuItem";
            this.sTATICSToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.sTATICSToolStripMenuItem.Text = "STATISTICS";
            this.sTATICSToolStripMenuItem.Click += new System.EventHandler(this.sTATICSToolStripMenuItem_Click);
            // 
            // mANAGEToolStripMenuItem
            // 
            this.mANAGEToolStripMenuItem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mANAGEToolStripMenuItem.Name = "mANAGEToolStripMenuItem";
            this.mANAGEToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.mANAGEToolStripMenuItem.Text = "MANAGE STUDENT FORM";
            this.mANAGEToolStripMenuItem.Click += new System.EventHandler(this.mANAGEToolStripMenuItem_Click);
            // 
            // pRINTToolStripMenuItem
            // 
            this.pRINTToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pRINTToolStripMenuItem.Name = "pRINTToolStripMenuItem";
            this.pRINTToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.pRINTToolStripMenuItem.Text = "PRINT";
            this.pRINTToolStripMenuItem.Click += new System.EventHandler(this.pRINTToolStripMenuItem_Click);
            // 
            // cOURSEToolStripMenuItem
            // 
            this.cOURSEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseToolStripMenuItem,
            this.editCouseToolStripMenuItem,
            this.removeCourseToolStripMenuItem,
            this.manageCouseToolStripMenuItem,
            this.printToolStripMenuItem1});
            this.cOURSEToolStripMenuItem.Name = "cOURSEToolStripMenuItem";
            this.cOURSEToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.cOURSEToolStripMenuItem.Text = "COURSE";
            // 
            // addCourseToolStripMenuItem
            // 
            this.addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            this.addCourseToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.addCourseToolStripMenuItem.Text = "Add Course";
            this.addCourseToolStripMenuItem.Click += new System.EventHandler(this.addCourseToolStripMenuItem_Click);
            // 
            // editCouseToolStripMenuItem
            // 
            this.editCouseToolStripMenuItem.Name = "editCouseToolStripMenuItem";
            this.editCouseToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.editCouseToolStripMenuItem.Text = "Remove Course";
            this.editCouseToolStripMenuItem.Click += new System.EventHandler(this.editCouseToolStripMenuItem_Click);
            // 
            // removeCourseToolStripMenuItem
            // 
            this.removeCourseToolStripMenuItem.Name = "removeCourseToolStripMenuItem";
            this.removeCourseToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.removeCourseToolStripMenuItem.Text = "Edit Course";
            this.removeCourseToolStripMenuItem.Click += new System.EventHandler(this.removeCourseToolStripMenuItem_Click);
            // 
            // manageCouseToolStripMenuItem
            // 
            this.manageCouseToolStripMenuItem.Name = "manageCouseToolStripMenuItem";
            this.manageCouseToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.manageCouseToolStripMenuItem.Text = "Manage Couse";
            this.manageCouseToolStripMenuItem.Click += new System.EventHandler(this.manageCouseToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem1
            // 
            this.printToolStripMenuItem1.Name = "printToolStripMenuItem1";
            this.printToolStripMenuItem1.Size = new System.Drawing.Size(195, 26);
            this.printToolStripMenuItem1.Text = "Print";
            this.printToolStripMenuItem1.Click += new System.EventHandler(this.printToolStripMenuItem1_Click);
            // 
            // sCOREToolStripMenuItem
            // 
            this.sCOREToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addScoreToolStripMenuItem,
            this.removeScoreToolStripMenuItem,
            this.manageScoreToolStripMenuItem,
            this.avgToolStripMenuItem,
            this.printToolStripMenuItem2});
            this.sCOREToolStripMenuItem.Name = "sCOREToolStripMenuItem";
            this.sCOREToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.sCOREToolStripMenuItem.Text = "SCORE";
            // 
            // addScoreToolStripMenuItem
            // 
            this.addScoreToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.addScoreToolStripMenuItem.Name = "addScoreToolStripMenuItem";
            this.addScoreToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.addScoreToolStripMenuItem.Text = "Add Score";
            this.addScoreToolStripMenuItem.Click += new System.EventHandler(this.addScoreToolStripMenuItem_Click);
            // 
            // removeScoreToolStripMenuItem
            // 
            this.removeScoreToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.removeScoreToolStripMenuItem.Name = "removeScoreToolStripMenuItem";
            this.removeScoreToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.removeScoreToolStripMenuItem.Text = "Remove Score";
            this.removeScoreToolStripMenuItem.Click += new System.EventHandler(this.removeScoreToolStripMenuItem_Click);
            // 
            // manageScoreToolStripMenuItem
            // 
            this.manageScoreToolStripMenuItem.Name = "manageScoreToolStripMenuItem";
            this.manageScoreToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.manageScoreToolStripMenuItem.Text = "Manage Score";
            this.manageScoreToolStripMenuItem.Click += new System.EventHandler(this.manageScoreToolStripMenuItem_Click);
            // 
            // avgToolStripMenuItem
            // 
            this.avgToolStripMenuItem.Name = "avgToolStripMenuItem";
            this.avgToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.avgToolStripMenuItem.Text = "Avg Score By Course";
            this.avgToolStripMenuItem.Click += new System.EventHandler(this.avgToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem2
            // 
            this.printToolStripMenuItem2.Name = "printToolStripMenuItem2";
            this.printToolStripMenuItem2.Size = new System.Drawing.Size(228, 26);
            this.printToolStripMenuItem2.Text = "Print";
            this.printToolStripMenuItem2.Click += new System.EventHandler(this.printToolStripMenuItem2_Click);
            // 
            // rESULTToolStripMenuItem
            // 
            this.rESULTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aVGToolStripMenuItem1,
            this.staticToolStripMenuItem});
            this.rESULTToolStripMenuItem.Name = "rESULTToolStripMenuItem";
            this.rESULTToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.rESULTToolStripMenuItem.Text = "RESULT";
            // 
            // aVGToolStripMenuItem1
            // 
            this.aVGToolStripMenuItem1.Name = "aVGToolStripMenuItem1";
            this.aVGToolStripMenuItem1.Size = new System.Drawing.Size(225, 26);
            this.aVGToolStripMenuItem1.Text = "AVG Result By Score";
            this.aVGToolStripMenuItem1.Click += new System.EventHandler(this.aVGToolStripMenuItem1_Click);
            // 
            // staticToolStripMenuItem
            // 
            this.staticToolStripMenuItem.Name = "staticToolStripMenuItem";
            this.staticToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.staticToolStripMenuItem.Text = "Statistics Result";
            this.staticToolStripMenuItem.Click += new System.EventHandler(this.staticToolStripMenuItem_Click);
            // 
            // eDITREMOVEToolStripMenuItem
            // 
            this.eDITREMOVEToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.eDITREMOVEToolStripMenuItem.Name = "eDITREMOVEToolStripMenuItem";
            this.eDITREMOVEToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.eDITREMOVEToolStripMenuItem.Text = "EDIT/REMOVE";
            this.eDITREMOVEToolStripMenuItem.Click += new System.EventHandler(this.eDITREMOVEToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sTUDENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDNEWSTUDENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTUDENTLISTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTATICSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mANAGEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRINTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOURSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sCOREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rESULTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aVGToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem staticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITREMOVEToolStripMenuItem;
    }
}