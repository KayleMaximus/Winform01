﻿
namespace WindowsFormsApp1
{
    partial class SelectContactForm
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
            this.txb_Email = new System.Windows.Forms.TextBox();
            this.txb_Phone = new System.Windows.Forms.TextBox();
            this.txb_Address = new System.Windows.Forms.TextBox();
            this.txb_Lname = new System.Windows.Forms.TextBox();
            this.txb_Fname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_Group = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.txb_ID = new System.Windows.Forms.TextBox();
            this.PicBox_ContactImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_ContactImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_Email
            // 
            this.txb_Email.Enabled = false;
            this.txb_Email.Location = new System.Drawing.Point(243, 260);
            this.txb_Email.Multiline = true;
            this.txb_Email.Name = "txb_Email";
            this.txb_Email.Size = new System.Drawing.Size(277, 27);
            this.txb_Email.TabIndex = 4;
            // 
            // txb_Phone
            // 
            this.txb_Phone.Enabled = false;
            this.txb_Phone.Location = new System.Drawing.Point(243, 212);
            this.txb_Phone.Multiline = true;
            this.txb_Phone.Name = "txb_Phone";
            this.txb_Phone.Size = new System.Drawing.Size(277, 26);
            this.txb_Phone.TabIndex = 3;
            // 
            // txb_Address
            // 
            this.txb_Address.Enabled = false;
            this.txb_Address.Location = new System.Drawing.Point(243, 321);
            this.txb_Address.Multiline = true;
            this.txb_Address.Name = "txb_Address";
            this.txb_Address.Size = new System.Drawing.Size(277, 68);
            this.txb_Address.TabIndex = 5;
            // 
            // txb_Lname
            // 
            this.txb_Lname.Enabled = false;
            this.txb_Lname.Location = new System.Drawing.Point(243, 118);
            this.txb_Lname.Multiline = true;
            this.txb_Lname.Name = "txb_Lname";
            this.txb_Lname.Size = new System.Drawing.Size(277, 24);
            this.txb_Lname.TabIndex = 1;
            // 
            // txb_Fname
            // 
            this.txb_Fname.Enabled = false;
            this.txb_Fname.Location = new System.Drawing.Point(243, 73);
            this.txb_Fname.Multiline = true;
            this.txb_Fname.Name = "txb_Fname";
            this.txb_Fname.Size = new System.Drawing.Size(277, 24);
            this.txb_Fname.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(76, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 35);
            this.label7.TabIndex = 38;
            this.label7.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(91, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 35);
            this.label6.TabIndex = 35;
            this.label6.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(96, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 35);
            this.label4.TabIndex = 29;
            this.label4.Text = "Group:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(45, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 35);
            this.label3.TabIndex = 26;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(41, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 35);
            this.label2.TabIndex = 23;
            this.label2.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(105, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 35);
            this.label1.TabIndex = 21;
            this.label1.Text = "Email:";
            // 
            // cbb_Group
            // 
            this.cbb_Group.Enabled = false;
            this.cbb_Group.FormattingEnabled = true;
            this.cbb_Group.Location = new System.Drawing.Point(243, 166);
            this.cbb_Group.Name = "cbb_Group";
            this.cbb_Group.Size = new System.Drawing.Size(277, 24);
            this.cbb_Group.TabIndex = 2;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label.Location = new System.Drawing.Point(139, 29);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(46, 35);
            this.label.TabIndex = 42;
            this.label.Text = "ID:";
            // 
            // txb_ID
            // 
            this.txb_ID.Enabled = false;
            this.txb_ID.Location = new System.Drawing.Point(243, 29);
            this.txb_ID.Name = "txb_ID";
            this.txb_ID.Size = new System.Drawing.Size(277, 22);
            this.txb_ID.TabIndex = 7;
            // 
            // PicBox_ContactImage
            // 
            this.PicBox_ContactImage.BackColor = System.Drawing.Color.White;
            this.PicBox_ContactImage.Location = new System.Drawing.Point(624, 32);
            this.PicBox_ContactImage.Name = "PicBox_ContactImage";
            this.PicBox_ContactImage.Size = new System.Drawing.Size(225, 169);
            this.PicBox_ContactImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBox_ContactImage.TabIndex = 40;
            this.PicBox_ContactImage.TabStop = false;
            // 
            // SelectContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(920, 461);
            this.Controls.Add(this.txb_ID);
            this.Controls.Add(this.label);
            this.Controls.Add(this.cbb_Group);
            this.Controls.Add(this.PicBox_ContactImage);
            this.Controls.Add(this.txb_Email);
            this.Controls.Add(this.txb_Phone);
            this.Controls.Add(this.txb_Address);
            this.Controls.Add(this.txb_Lname);
            this.Controls.Add(this.txb_Fname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SelectContactForm";
            this.Text = "AddContactForm";
            this.Load += new System.EventHandler(this.SelectContactForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_ContactImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txb_Email;
        private System.Windows.Forms.TextBox txb_Phone;
        private System.Windows.Forms.TextBox txb_Address;
        private System.Windows.Forms.TextBox txb_Lname;
        private System.Windows.Forms.TextBox txb_Fname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PicBox_ContactImage;
        private System.Windows.Forms.ComboBox cbb_Group;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txb_ID;
    }
}