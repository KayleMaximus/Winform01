
namespace WindowsFormsApp1
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_Login = new System.Windows.Forms.Button();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_ForgotPass = new System.Windows.Forms.Label();
            this.lb_Register = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbt_HM = new System.Windows.Forms.RadioButton();
            this.rdb_student = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(39, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username / Gmail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(91, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.BackColor = System.Drawing.Color.Red;
            this.bt_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Cancel.CausesValidation = false;
            this.bt_Cancel.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cancel.ForeColor = System.Drawing.Color.Black;
            this.bt_Cancel.Location = new System.Drawing.Point(359, 364);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(100, 42);
            this.bt_Cancel.TabIndex = 4;
            this.bt_Cancel.Text = "Cancel";
            this.bt_Cancel.UseVisualStyleBackColor = false;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // bt_Login
            // 
            this.bt_Login.BackColor = System.Drawing.Color.Aqua;
            this.bt_Login.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Login.Location = new System.Drawing.Point(200, 363);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(100, 40);
            this.bt_Login.TabIndex = 3;
            this.bt_Login.Text = "Login";
            this.bt_Login.UseVisualStyleBackColor = false;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Location = new System.Drawing.Point(216, 189);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(226, 22);
            this.TextBoxUsername.TabIndex = 1;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(216, 256);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = 'k';
            this.TextBoxPassword.Size = new System.Drawing.Size(226, 22);
            this.TextBoxPassword.TabIndex = 2;
            this.TextBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxPassword_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.CadetBlue;
            this.label4.Location = new System.Drawing.Point(509, 527);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Trần Minh Khải 20110372";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.magic;
            this.pictureBox1.Location = new System.Drawing.Point(-10, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1354, 107);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb_ForgotPass
            // 
            this.lb_ForgotPass.AutoEllipsis = true;
            this.lb_ForgotPass.AutoSize = true;
            this.lb_ForgotPass.BackColor = System.Drawing.Color.Aqua;
            this.lb_ForgotPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_ForgotPass.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lb_ForgotPass.ForeColor = System.Drawing.Color.Blue;
            this.lb_ForgotPass.Location = new System.Drawing.Point(75, 491);
            this.lb_ForgotPass.Name = "lb_ForgotPass";
            this.lb_ForgotPass.Size = new System.Drawing.Size(122, 17);
            this.lb_ForgotPass.TabIndex = 5;
            this.lb_ForgotPass.Text = "Forgot Password?";
            this.lb_ForgotPass.UseMnemonic = false;
            this.lb_ForgotPass.Click += new System.EventHandler(this.lb_ForgotPass_Click);
            // 
            // lb_Register
            // 
            this.lb_Register.AutoSize = true;
            this.lb_Register.BackColor = System.Drawing.Color.Yellow;
            this.lb_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_Register.ForeColor = System.Drawing.Color.Red;
            this.lb_Register.Location = new System.Drawing.Point(323, 491);
            this.lb_Register.Name = "lb_Register";
            this.lb_Register.Size = new System.Drawing.Size(122, 17);
            this.lb_Register.TabIndex = 6;
            this.lb_Register.Text = "New To Top Dev?";
            this.lb_Register.Click += new System.EventHandler(this.lb_Register_Click);
            // 
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(528, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(646, 278);
            this.label5.TabIndex = 10;
            // 
            // rbt_HM
            // 
            this.rbt_HM.AutoSize = true;
            this.rbt_HM.Location = new System.Drawing.Point(174, 3);
            this.rbt_HM.Name = "rbt_HM";
            this.rbt_HM.Size = new System.Drawing.Size(139, 21);
            this.rbt_HM.TabIndex = 11;
            this.rbt_HM.TabStop = true;
            this.rbt_HM.Text = "Human Resource";
            this.rbt_HM.UseVisualStyleBackColor = true;
            // 
            // rdb_student
            // 
            this.rdb_student.AutoSize = true;
            this.rdb_student.Location = new System.Drawing.Point(54, 3);
            this.rdb_student.Name = "rdb_student";
            this.rdb_student.Size = new System.Drawing.Size(78, 21);
            this.rdb_student.TabIndex = 12;
            this.rdb_student.TabStop = true;
            this.rdb_student.Text = "Student";
            this.rdb_student.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.rbt_HM);
            this.panel1.Controls.Add(this.rdb_student);
            this.panel1.Location = new System.Drawing.Point(146, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 34);
            this.panel1.TabIndex = 13;
            // 
            // Login_Form
            // 
            this.AcceptButton = this.bt_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.bt_Cancel;
            this.ClientSize = new System.Drawing.Size(1186, 591);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_Register);
            this.Controls.Add(this.lb_ForgotPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.bt_Login);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HelpButton = true;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_ForgotPass;
        private System.Windows.Forms.Label lb_Register;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbt_HM;
        private System.Windows.Forms.RadioButton rdb_student;
        private System.Windows.Forms.Panel panel1;
    }
}

