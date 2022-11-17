
namespace WindowsFormsApp1
{
    partial class AddHumanReForm
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
            this.lb_UserName = new System.Windows.Forms.Label();
            this.lb_UserID = new System.Windows.Forms.Label();
            this.bt_ConfirmCode = new System.Windows.Forms.Button();
            this.txb_ConfirmCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_SendConfirm = new System.Windows.Forms.Button();
            this.txb_gmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_UserID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_Cancel_SignIn = new System.Windows.Forms.Button();
            this.bt_SignIn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_UserName = new System.Windows.Forms.TextBox();
            this.txb_PassWord = new System.Windows.Forms.TextBox();
            this.txb_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_Lname = new System.Windows.Forms.TextBox();
            this.txb_Fname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PicBox_HRImage = new System.Windows.Forms.PictureBox();
            this.bt_UploadImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_HRImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_UserName
            // 
            this.lb_UserName.AutoSize = true;
            this.lb_UserName.BackColor = System.Drawing.Color.CadetBlue;
            this.lb_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_UserName.Location = new System.Drawing.Point(586, 251);
            this.lb_UserName.Name = "lb_UserName";
            this.lb_UserName.Size = new System.Drawing.Size(0, 17);
            this.lb_UserName.TabIndex = 56;
            // 
            // lb_UserID
            // 
            this.lb_UserID.AutoSize = true;
            this.lb_UserID.BackColor = System.Drawing.Color.CadetBlue;
            this.lb_UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_UserID.Location = new System.Drawing.Point(586, 122);
            this.lb_UserID.Name = "lb_UserID";
            this.lb_UserID.Size = new System.Drawing.Size(0, 17);
            this.lb_UserID.TabIndex = 55;
            // 
            // bt_ConfirmCode
            // 
            this.bt_ConfirmCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_ConfirmCode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_ConfirmCode.Location = new System.Drawing.Point(754, 421);
            this.bt_ConfirmCode.Name = "bt_ConfirmCode";
            this.bt_ConfirmCode.Size = new System.Drawing.Size(140, 36);
            this.bt_ConfirmCode.TabIndex = 9;
            this.bt_ConfirmCode.Text = "Verify";
            this.bt_ConfirmCode.UseVisualStyleBackColor = false;
            this.bt_ConfirmCode.Click += new System.EventHandler(this.bt_ConfirmCode_Click);
            // 
            // txb_ConfirmCode
            // 
            this.txb_ConfirmCode.Location = new System.Drawing.Point(363, 419);
            this.txb_ConfirmCode.Name = "txb_ConfirmCode";
            this.txb_ConfirmCode.Size = new System.Drawing.Size(167, 22);
            this.txb_ConfirmCode.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(177, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 54;
            this.label7.Text = "Confirmation Code:";
            // 
            // bt_SendConfirm
            // 
            this.bt_SendConfirm.BackColor = System.Drawing.Color.Blue;
            this.bt_SendConfirm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_SendConfirm.Location = new System.Drawing.Point(754, 376);
            this.bt_SendConfirm.Name = "bt_SendConfirm";
            this.bt_SendConfirm.Size = new System.Drawing.Size(140, 36);
            this.bt_SendConfirm.TabIndex = 7;
            this.bt_SendConfirm.Text = "Send Confimation";
            this.bt_SendConfirm.UseVisualStyleBackColor = false;
            this.bt_SendConfirm.Click += new System.EventHandler(this.bt_SendConfirm_Click);
            // 
            // txb_gmail
            // 
            this.txb_gmail.Location = new System.Drawing.Point(363, 376);
            this.txb_gmail.Name = "txb_gmail";
            this.txb_gmail.Size = new System.Drawing.Size(167, 22);
            this.txb_gmail.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(272, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "Gmail:";
            // 
            // txb_UserID
            // 
            this.txb_UserID.Location = new System.Drawing.Point(363, 119);
            this.txb_UserID.Name = "txb_UserID";
            this.txb_UserID.Size = new System.Drawing.Size(167, 22);
            this.txb_UserID.TabIndex = 0;
            this.txb_UserID.TextChanged += new System.EventHandler(this.txb_UserID_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(242, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "User\'s ID:";
            // 
            // bt_Cancel_SignIn
            // 
            this.bt_Cancel_SignIn.BackColor = System.Drawing.Color.Red;
            this.bt_Cancel_SignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cancel_SignIn.ForeColor = System.Drawing.Color.Black;
            this.bt_Cancel_SignIn.Location = new System.Drawing.Point(246, 529);
            this.bt_Cancel_SignIn.Name = "bt_Cancel_SignIn";
            this.bt_Cancel_SignIn.Size = new System.Drawing.Size(130, 56);
            this.bt_Cancel_SignIn.TabIndex = 12;
            this.bt_Cancel_SignIn.Text = "I Don\'t Want To Get Trĩ";
            this.bt_Cancel_SignIn.UseVisualStyleBackColor = false;
            this.bt_Cancel_SignIn.Click += new System.EventHandler(this.bt_Cancel_SignIn_Click);
            // 
            // bt_SignIn
            // 
            this.bt_SignIn.BackColor = System.Drawing.Color.Lime;
            this.bt_SignIn.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SignIn.ForeColor = System.Drawing.Color.Black;
            this.bt_SignIn.Location = new System.Drawing.Point(522, 527);
            this.bt_SignIn.Name = "bt_SignIn";
            this.bt_SignIn.Size = new System.Drawing.Size(130, 56);
            this.bt_SignIn.TabIndex = 11;
            this.bt_SignIn.Text = "Sign Me In";
            this.bt_SignIn.UseVisualStyleBackColor = false;
            this.bt_SignIn.Click += new System.EventHandler(this.bt_SignIn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(199, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(663, 80);
            this.label4.TabIndex = 52;
            this.label4.Text = "Welcome To TopDev";
            // 
            // txb_UserName
            // 
            this.txb_UserName.Location = new System.Drawing.Point(363, 243);
            this.txb_UserName.Name = "txb_UserName";
            this.txb_UserName.Size = new System.Drawing.Size(167, 22);
            this.txb_UserName.TabIndex = 3;
            this.txb_UserName.Leave += new System.EventHandler(this.txb_UserName_Leave);
            // 
            // txb_PassWord
            // 
            this.txb_PassWord.Location = new System.Drawing.Point(363, 286);
            this.txb_PassWord.Name = "txb_PassWord";
            this.txb_PassWord.PasswordChar = 'K';
            this.txb_PassWord.Size = new System.Drawing.Size(167, 22);
            this.txb_PassWord.TabIndex = 4;
            // 
            // txb_ConfirmPassword
            // 
            this.txb_ConfirmPassword.Location = new System.Drawing.Point(363, 328);
            this.txb_ConfirmPassword.Name = "txb_ConfirmPassword";
            this.txb_ConfirmPassword.PasswordChar = 'K';
            this.txb_ConfirmPassword.Size = new System.Drawing.Size(167, 22);
            this.txb_ConfirmPassword.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(177, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Confirm Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(242, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(235, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "UserName:";
            // 
            // txb_Lname
            // 
            this.txb_Lname.Location = new System.Drawing.Point(363, 207);
            this.txb_Lname.Name = "txb_Lname";
            this.txb_Lname.Size = new System.Drawing.Size(167, 22);
            this.txb_Lname.TabIndex = 2;
            // 
            // txb_Fname
            // 
            this.txb_Fname.Location = new System.Drawing.Point(363, 163);
            this.txb_Fname.Name = "txb_Fname";
            this.txb_Fname.Size = new System.Drawing.Size(167, 22);
            this.txb_Fname.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(231, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 59;
            this.label8.Text = "Last Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(230, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 20);
            this.label9.TabIndex = 60;
            this.label9.Text = "First Name:";
            // 
            // PicBox_HRImage
            // 
            this.PicBox_HRImage.BackColor = System.Drawing.Color.White;
            this.PicBox_HRImage.Location = new System.Drawing.Point(754, 106);
            this.PicBox_HRImage.Name = "PicBox_HRImage";
            this.PicBox_HRImage.Size = new System.Drawing.Size(261, 200);
            this.PicBox_HRImage.TabIndex = 62;
            this.PicBox_HRImage.TabStop = false;
            // 
            // bt_UploadImage
            // 
            this.bt_UploadImage.Location = new System.Drawing.Point(754, 312);
            this.bt_UploadImage.Name = "bt_UploadImage";
            this.bt_UploadImage.Size = new System.Drawing.Size(261, 44);
            this.bt_UploadImage.TabIndex = 10;
            this.bt_UploadImage.Text = "Upload Image";
            this.bt_UploadImage.UseVisualStyleBackColor = true;
            this.bt_UploadImage.Click += new System.EventHandler(this.bt_UploadImage_Click);
            // 
            // AddHumanReForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 623);
            this.Controls.Add(this.PicBox_HRImage);
            this.Controls.Add(this.bt_UploadImage);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txb_Fname);
            this.Controls.Add(this.txb_Lname);
            this.Controls.Add(this.lb_UserName);
            this.Controls.Add(this.lb_UserID);
            this.Controls.Add(this.bt_ConfirmCode);
            this.Controls.Add(this.txb_ConfirmCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bt_SendConfirm);
            this.Controls.Add(this.txb_gmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txb_UserID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_Cancel_SignIn);
            this.Controls.Add(this.bt_SignIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_UserName);
            this.Controls.Add(this.txb_PassWord);
            this.Controls.Add(this.txb_ConfirmPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddHumanReForm";
            this.Text = "AddHumanReForm";
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_HRImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_UserName;
        private System.Windows.Forms.Label lb_UserID;
        private System.Windows.Forms.Button bt_ConfirmCode;
        private System.Windows.Forms.TextBox txb_ConfirmCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_SendConfirm;
        private System.Windows.Forms.TextBox txb_gmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_UserID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_Cancel_SignIn;
        private System.Windows.Forms.Button bt_SignIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_UserName;
        private System.Windows.Forms.TextBox txb_PassWord;
        private System.Windows.Forms.TextBox txb_ConfirmPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_Lname;
        private System.Windows.Forms.TextBox txb_Fname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox PicBox_HRImage;
        private System.Windows.Forms.Button bt_UploadImage;
    }
}