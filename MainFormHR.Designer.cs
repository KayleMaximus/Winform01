
namespace WindowsFormsApp1
{
    partial class MainFormHR
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
            this.bt_ShowContact = new System.Windows.Forms.Button();
            this.txb_EnterContactID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_RemoveContact = new System.Windows.Forms.Button();
            this.bt_SelectContact = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_AddContact = new System.Windows.Forms.Button();
            this.bt_EditContact = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_LogOut = new System.Windows.Forms.Label();
            this.lb_Edit = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lb_FnameLname = new System.Windows.Forms.Label();
            this.lb_Welcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bt_RemoveGroup = new System.Windows.Forms.Button();
            this.cbb_DeleteGroup = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbb_EditGroup = new System.Windows.Forms.ComboBox();
            this.bt_EditGroup = new System.Windows.Forms.Button();
            this.txb_EditGroupName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_GroupName = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.bt_AddGroup = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_GroupID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_ShowContact
            // 
            this.bt_ShowContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ShowContact.Location = new System.Drawing.Point(0, 21);
            this.bt_ShowContact.Name = "bt_ShowContact";
            this.bt_ShowContact.Size = new System.Drawing.Size(325, 37);
            this.bt_ShowContact.TabIndex = 0;
            this.bt_ShowContact.Text = "Show Full Contacts";
            this.bt_ShowContact.UseVisualStyleBackColor = true;
            this.bt_ShowContact.Click += new System.EventHandler(this.bt_ShowContact_Click);
            // 
            // txb_EnterContactID
            // 
            this.txb_EnterContactID.Location = new System.Drawing.Point(15, 74);
            this.txb_EnterContactID.Name = "txb_EnterContactID";
            this.txb_EnterContactID.Size = new System.Drawing.Size(147, 22);
            this.txb_EnterContactID.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Enter Contact ID:";
            // 
            // bt_RemoveContact
            // 
            this.bt_RemoveContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_RemoveContact.Location = new System.Drawing.Point(180, 66);
            this.bt_RemoveContact.Name = "bt_RemoveContact";
            this.bt_RemoveContact.Size = new System.Drawing.Size(145, 38);
            this.bt_RemoveContact.TabIndex = 3;
            this.bt_RemoveContact.Text = "Remove Contact";
            this.bt_RemoveContact.UseVisualStyleBackColor = true;
            this.bt_RemoveContact.Click += new System.EventHandler(this.bt_RemoveContact_Click);
            // 
            // bt_SelectContact
            // 
            this.bt_SelectContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SelectContact.Location = new System.Drawing.Point(0, 33);
            this.bt_SelectContact.Name = "bt_SelectContact";
            this.bt_SelectContact.Size = new System.Drawing.Size(325, 27);
            this.bt_SelectContact.TabIndex = 2;
            this.bt_SelectContact.Text = "Select Contact";
            this.bt_SelectContact.UseVisualStyleBackColor = true;
            this.bt_SelectContact.Click += new System.EventHandler(this.bt_SelectContact_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.bt_ShowContact);
            this.panel3.Location = new System.Drawing.Point(52, 357);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 75);
            this.panel3.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.txb_EnterContactID);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.bt_RemoveContact);
            this.panel2.Controls.Add(this.bt_SelectContact);
            this.panel2.Location = new System.Drawing.Point(52, 226);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 125);
            this.panel2.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.bt_AddContact);
            this.panel1.Controls.Add(this.bt_EditContact);
            this.panel1.Location = new System.Drawing.Point(52, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 61);
            this.panel1.TabIndex = 20;
            // 
            // bt_AddContact
            // 
            this.bt_AddContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AddContact.Location = new System.Drawing.Point(20, 17);
            this.bt_AddContact.Name = "bt_AddContact";
            this.bt_AddContact.Size = new System.Drawing.Size(119, 27);
            this.bt_AddContact.TabIndex = 0;
            this.bt_AddContact.Text = "Add Contact";
            this.bt_AddContact.UseVisualStyleBackColor = true;
            this.bt_AddContact.Click += new System.EventHandler(this.bt_AddContact_Click);
            // 
            // bt_EditContact
            // 
            this.bt_EditContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_EditContact.Location = new System.Drawing.Point(164, 17);
            this.bt_EditContact.Name = "bt_EditContact";
            this.bt_EditContact.Size = new System.Drawing.Size(131, 27);
            this.bt_EditContact.TabIndex = 1;
            this.bt_EditContact.Text = "Edit Contact";
            this.bt_EditContact.UseVisualStyleBackColor = true;
            this.bt_EditContact.Click += new System.EventHandler(this.bt_EditContact_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Contact";
            // 
            // lb_LogOut
            // 
            this.lb_LogOut.AutoSize = true;
            this.lb_LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LogOut.Location = new System.Drawing.Point(563, 84);
            this.lb_LogOut.Name = "lb_LogOut";
            this.lb_LogOut.Size = new System.Drawing.Size(59, 17);
            this.lb_LogOut.TabIndex = 15;
            this.lb_LogOut.Text = "Log Out";
            this.lb_LogOut.Click += new System.EventHandler(this.lb_LogOut_Click);
            this.lb_LogOut.MouseEnter += new System.EventHandler(this.lb_LogOut_MouseEnter);
            this.lb_LogOut.MouseLeave += new System.EventHandler(this.lb_LogOut_MouseLeave);
            // 
            // lb_Edit
            // 
            this.lb_Edit.AutoSize = true;
            this.lb_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Edit.Location = new System.Drawing.Point(457, 84);
            this.lb_Edit.Name = "lb_Edit";
            this.lb_Edit.Size = new System.Drawing.Size(81, 17);
            this.lb_Edit.TabIndex = 13;
            this.lb_Edit.Text = "Edit My Info";
            this.lb_Edit.Click += new System.EventHandler(this.lb_Edit_Click);
            this.lb_Edit.MouseEnter += new System.EventHandler(this.lb_Edit_MouseEnter);
            this.lb_Edit.MouseLeave += new System.EventHandler(this.lb_Edit_MouseLeave);
            // 
            // pictureBox
            // 
            this.pictureBox.ErrorImage = global::WindowsFormsApp1.Properties.Resources.cry_cry;
            this.pictureBox.Location = new System.Drawing.Point(697, 6);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(105, 107);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 18;
            this.pictureBox.TabStop = false;
            // 
            // lb_FnameLname
            // 
            this.lb_FnameLname.AutoSize = true;
            this.lb_FnameLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FnameLname.Location = new System.Drawing.Point(488, 55);
            this.lb_FnameLname.Name = "lb_FnameLname";
            this.lb_FnameLname.Size = new System.Drawing.Size(235, 20);
            this.lb_FnameLname.TabIndex = 17;
            this.lb_FnameLname.Text = "First Name and Last Name";
            // 
            // lb_Welcome
            // 
            this.lb_Welcome.AutoSize = true;
            this.lb_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Welcome.Location = new System.Drawing.Point(456, 26);
            this.lb_Welcome.Name = "lb_Welcome";
            this.lb_Welcome.Size = new System.Drawing.Size(86, 20);
            this.lb_Welcome.TabIndex = 16;
            this.lb_Welcome.Text = "Welcome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "HUMAN RESOURCE";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(this.bt_RemoveGroup);
            this.panel4.Controls.Add(this.cbb_DeleteGroup);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(460, 357);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(406, 75);
            this.panel4.TabIndex = 26;
            // 
            // bt_RemoveGroup
            // 
            this.bt_RemoveGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_RemoveGroup.Location = new System.Drawing.Point(310, 21);
            this.bt_RemoveGroup.Name = "bt_RemoveGroup";
            this.bt_RemoveGroup.Size = new System.Drawing.Size(97, 24);
            this.bt_RemoveGroup.TabIndex = 18;
            this.bt_RemoveGroup.Text = "Remove";
            this.bt_RemoveGroup.UseVisualStyleBackColor = true;
            this.bt_RemoveGroup.Click += new System.EventHandler(this.bt_RemoveGroup_Click);
            // 
            // cbb_DeleteGroup
            // 
            this.cbb_DeleteGroup.FormattingEnabled = true;
            this.cbb_DeleteGroup.Location = new System.Drawing.Point(157, 21);
            this.cbb_DeleteGroup.Name = "cbb_DeleteGroup";
            this.cbb_DeleteGroup.Size = new System.Drawing.Size(147, 24);
            this.cbb_DeleteGroup.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Select Group:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Controls.Add(this.cbb_EditGroup);
            this.panel5.Controls.Add(this.bt_EditGroup);
            this.panel5.Controls.Add(this.txb_EditGroupName);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(460, 239);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(406, 112);
            this.panel5.TabIndex = 25;
            // 
            // cbb_EditGroup
            // 
            this.cbb_EditGroup.FormattingEnabled = true;
            this.cbb_EditGroup.Location = new System.Drawing.Point(157, 10);
            this.cbb_EditGroup.Name = "cbb_EditGroup";
            this.cbb_EditGroup.Size = new System.Drawing.Size(147, 24);
            this.cbb_EditGroup.TabIndex = 15;
            // 
            // bt_EditGroup
            // 
            this.bt_EditGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_EditGroup.Location = new System.Drawing.Point(310, 47);
            this.bt_EditGroup.Name = "bt_EditGroup";
            this.bt_EditGroup.Size = new System.Drawing.Size(97, 24);
            this.bt_EditGroup.TabIndex = 14;
            this.bt_EditGroup.Text = "Edit";
            this.bt_EditGroup.UseVisualStyleBackColor = true;
            this.bt_EditGroup.Click += new System.EventHandler(this.bt_EditGroup_Click);
            // 
            // txb_EditGroupName
            // 
            this.txb_EditGroupName.Location = new System.Drawing.Point(157, 49);
            this.txb_EditGroupName.Name = "txb_EditGroupName";
            this.txb_EditGroupName.Size = new System.Drawing.Size(147, 22);
            this.txb_EditGroupName.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Enter New Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select Group:";
            // 
            // txb_GroupName
            // 
            this.txb_GroupName.Location = new System.Drawing.Point(157, 3);
            this.txb_GroupName.Name = "txb_GroupName";
            this.txb_GroupName.Size = new System.Drawing.Size(147, 22);
            this.txb_GroupName.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel6.Controls.Add(this.bt_AddGroup);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.txb_GroupID);
            this.panel6.Controls.Add(this.txb_GroupName);
            this.panel6.Location = new System.Drawing.Point(460, 149);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(406, 81);
            this.panel6.TabIndex = 24;
            // 
            // bt_AddGroup
            // 
            this.bt_AddGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AddGroup.Location = new System.Drawing.Point(309, 42);
            this.bt_AddGroup.Name = "bt_AddGroup";
            this.bt_AddGroup.Size = new System.Drawing.Size(97, 24);
            this.bt_AddGroup.TabIndex = 1;
            this.bt_AddGroup.Text = "Add";
            this.bt_AddGroup.UseVisualStyleBackColor = true;
            this.bt_AddGroup.Click += new System.EventHandler(this.bt_AddGroup_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "ID Group:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Enter Group Name:";
            // 
            // txb_GroupID
            // 
            this.txb_GroupID.Location = new System.Drawing.Point(157, 44);
            this.txb_GroupID.Name = "txb_GroupID";
            this.txb_GroupID.Size = new System.Drawing.Size(147, 22);
            this.txb_GroupID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Group";
            // 
            // MainFormHR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(922, 474);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_LogOut);
            this.Controls.Add(this.lb_Edit);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lb_FnameLname);
            this.Controls.Add(this.lb_Welcome);
            this.Controls.Add(this.label1);
            this.Name = "MainFormHR";
            this.Text = "Human Resource";
            this.Load += new System.EventHandler(this.MainFormHR_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_ShowContact;
        private System.Windows.Forms.TextBox txb_EnterContactID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_RemoveContact;
        private System.Windows.Forms.Button bt_SelectContact;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_AddContact;
        private System.Windows.Forms.Button bt_EditContact;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_LogOut;
        private System.Windows.Forms.Label lb_Edit;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lb_FnameLname;
        private System.Windows.Forms.Label lb_Welcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txb_GroupName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button bt_AddGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_GroupID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_RemoveGroup;
        private System.Windows.Forms.ComboBox cbb_DeleteGroup;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbb_EditGroup;
        private System.Windows.Forms.Button bt_EditGroup;
        private System.Windows.Forms.TextBox txb_EditGroupName;
        private System.Windows.Forms.Label label8;
    }
}