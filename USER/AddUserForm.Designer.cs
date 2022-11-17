
namespace WindowsFormsApp1
{
    partial class AddUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.txb_PassWord = new System.Windows.Forms.TextBox();
            this.txb_UserName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_SignIn = new System.Windows.Forms.Button();
            this.bt_Cancel_SignIn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_UserID = new System.Windows.Forms.TextBox();
            this.bt_ConfirmCode = new System.Windows.Forms.Button();
            this.txb_ConfirmCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_SendConfirm = new System.Windows.Forms.Button();
            this.txb_gmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_UserID = new System.Windows.Forms.Label();
            this.lb_UserName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(94, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User\'s Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(118, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(49, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password: ";
            // 
            // txb_ConfirmPassword
            // 
            this.txb_ConfirmPassword.Location = new System.Drawing.Point(239, 263);
            this.txb_ConfirmPassword.Name = "txb_ConfirmPassword";
            this.txb_ConfirmPassword.Size = new System.Drawing.Size(167, 22);
            this.txb_ConfirmPassword.TabIndex = 3;
            // 
            // txb_PassWord
            // 
            this.txb_PassWord.Location = new System.Drawing.Point(239, 221);
            this.txb_PassWord.Name = "txb_PassWord";
            this.txb_PassWord.Size = new System.Drawing.Size(167, 22);
            this.txb_PassWord.TabIndex = 2;
            // 
            // txb_UserName
            // 
            this.txb_UserName.Location = new System.Drawing.Point(239, 178);
            this.txb_UserName.Name = "txb_UserName";
            this.txb_UserName.Size = new System.Drawing.Size(167, 22);
            this.txb_UserName.TabIndex = 1;
            this.txb_UserName.Leave += new System.EventHandler(this.txb_UserName_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.IT;
            this.pictureBox1.Location = new System.Drawing.Point(582, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 189);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(75, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(663, 80);
            this.label4.TabIndex = 10;
            this.label4.Text = "Welcome To TopDev";
            // 
            // bt_SignIn
            // 
            this.bt_SignIn.BackColor = System.Drawing.Color.Lime;
            this.bt_SignIn.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SignIn.ForeColor = System.Drawing.Color.Black;
            this.bt_SignIn.Location = new System.Drawing.Point(356, 418);
            this.bt_SignIn.Name = "bt_SignIn";
            this.bt_SignIn.Size = new System.Drawing.Size(130, 56);
            this.bt_SignIn.TabIndex = 8;
            this.bt_SignIn.Text = "Sign Me In";
            this.bt_SignIn.UseVisualStyleBackColor = false;
            this.bt_SignIn.Click += new System.EventHandler(this.bt_SignIn_Click);
            // 
            // bt_Cancel_SignIn
            // 
            this.bt_Cancel_SignIn.BackColor = System.Drawing.Color.Red;
            this.bt_Cancel_SignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cancel_SignIn.ForeColor = System.Drawing.Color.Black;
            this.bt_Cancel_SignIn.Location = new System.Drawing.Point(122, 418);
            this.bt_Cancel_SignIn.Name = "bt_Cancel_SignIn";
            this.bt_Cancel_SignIn.Size = new System.Drawing.Size(130, 56);
            this.bt_Cancel_SignIn.TabIndex = 9;
            this.bt_Cancel_SignIn.Text = "I Don\'t Want To Get Trĩ";
            this.bt_Cancel_SignIn.UseVisualStyleBackColor = false;
            this.bt_Cancel_SignIn.Click += new System.EventHandler(this.bt_Cancel_SignIn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(121, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "User\'s ID:";
            // 
            // txb_UserID
            // 
            this.txb_UserID.Location = new System.Drawing.Point(239, 144);
            this.txb_UserID.Name = "txb_UserID";
            this.txb_UserID.Size = new System.Drawing.Size(167, 22);
            this.txb_UserID.TabIndex = 0;
            this.txb_UserID.TextChanged += new System.EventHandler(this.txb_UserID_TextChanged);
            // 
            // bt_ConfirmCode
            // 
            this.bt_ConfirmCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_ConfirmCode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_ConfirmCode.Location = new System.Drawing.Point(436, 349);
            this.bt_ConfirmCode.Name = "bt_ConfirmCode";
            this.bt_ConfirmCode.Size = new System.Drawing.Size(140, 36);
            this.bt_ConfirmCode.TabIndex = 7;
            this.bt_ConfirmCode.Text = "Verify";
            this.bt_ConfirmCode.UseVisualStyleBackColor = false;
            this.bt_ConfirmCode.Click += new System.EventHandler(this.bt_ConfirmCode_Click);
            // 
            // txb_ConfirmCode
            // 
            this.txb_ConfirmCode.Location = new System.Drawing.Point(239, 354);
            this.txb_ConfirmCode.Name = "txb_ConfirmCode";
            this.txb_ConfirmCode.Size = new System.Drawing.Size(167, 22);
            this.txb_ConfirmCode.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(53, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Confirmation Code:";
            // 
            // bt_SendConfirm
            // 
            this.bt_SendConfirm.BackColor = System.Drawing.Color.Blue;
            this.bt_SendConfirm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_SendConfirm.Location = new System.Drawing.Point(436, 304);
            this.bt_SendConfirm.Name = "bt_SendConfirm";
            this.bt_SendConfirm.Size = new System.Drawing.Size(140, 36);
            this.bt_SendConfirm.TabIndex = 5;
            this.bt_SendConfirm.Text = "Send Confimation";
            this.bt_SendConfirm.UseVisualStyleBackColor = false;
            this.bt_SendConfirm.Click += new System.EventHandler(this.bt_SendConfirm_Click);
            // 
            // txb_gmail
            // 
            this.txb_gmail.Location = new System.Drawing.Point(239, 311);
            this.txb_gmail.Name = "txb_gmail";
            this.txb_gmail.Size = new System.Drawing.Size(167, 22);
            this.txb_gmail.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(148, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Gmail:";
            // 
            // lb_UserID
            // 
            this.lb_UserID.AutoSize = true;
            this.lb_UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_UserID.Location = new System.Drawing.Point(455, 147);
            this.lb_UserID.Name = "lb_UserID";
            this.lb_UserID.Size = new System.Drawing.Size(0, 17);
            this.lb_UserID.TabIndex = 35;
            // 
            // lb_UserName
            // 
            this.lb_UserName.AutoSize = true;
            this.lb_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_UserName.Location = new System.Drawing.Point(455, 183);
            this.lb_UserName.Name = "lb_UserName";
            this.lb_UserName.Size = new System.Drawing.Size(0, 17);
            this.lb_UserName.TabIndex = 36;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(846, 511);
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
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txb_UserName);
            this.Controls.Add(this.txb_PassWord);
            this.Controls.Add(this.txb_ConfirmPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Snow;
            this.Name = "AddUserForm";
            this.Text = "AddUserForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_ConfirmPassword;
        private System.Windows.Forms.TextBox txb_PassWord;
        private System.Windows.Forms.TextBox txb_UserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_SignIn;
        private System.Windows.Forms.Button bt_Cancel_SignIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_UserID;
        private System.Windows.Forms.Button bt_ConfirmCode;
        private System.Windows.Forms.TextBox txb_ConfirmCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_SendConfirm;
        private System.Windows.Forms.TextBox txb_gmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_UserID;
        private System.Windows.Forms.Label lb_UserName;
    }
}