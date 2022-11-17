
namespace WindowsFormsApp1
{
    partial class ResetPassword
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
            this.rbt_Yes = new System.Windows.Forms.RadioButton();
            this.rbt_No = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_ConfirmPass = new System.Windows.Forms.TextBox();
            this.txb_NewPass = new System.Windows.Forms.TextBox();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_Confim = new System.Windows.Forms.Button();
            this.lb_username = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbt_Yes
            // 
            this.rbt_Yes.AutoSize = true;
            this.rbt_Yes.Location = new System.Drawing.Point(482, 120);
            this.rbt_Yes.Name = "rbt_Yes";
            this.rbt_Yes.Size = new System.Drawing.Size(97, 21);
            this.rbt_Yes.TabIndex = 1;
            this.rbt_Yes.TabStop = true;
            this.rbt_Yes.Text = "Hella Yesh";
            this.rbt_Yes.UseVisualStyleBackColor = true;
            this.rbt_Yes.Click += new System.EventHandler(this.rbt_Yes_Click);
            // 
            // rbt_No
            // 
            this.rbt_No.AutoSize = true;
            this.rbt_No.Location = new System.Drawing.Point(635, 116);
            this.rbt_No.Name = "rbt_No";
            this.rbt_No.Size = new System.Drawing.Size(98, 21);
            this.rbt_No.TabIndex = 2;
            this.rbt_No.TabStop = true;
            this.rbt_No.Text = "Helluya No";
            this.rbt_No.UseVisualStyleBackColor = true;
            this.rbt_No.Click += new System.EventHandler(this.rbt_No_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your Current Passwod is: ";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(563, 78);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(69, 17);
            this.lb_password.TabIndex = 3;
            this.lb_password.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Change Password?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "New Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Confirm Password:";
            // 
            // txb_ConfirmPass
            // 
            this.txb_ConfirmPass.Location = new System.Drawing.Point(507, 225);
            this.txb_ConfirmPass.Name = "txb_ConfirmPass";
            this.txb_ConfirmPass.PasswordChar = 'k';
            this.txb_ConfirmPass.Size = new System.Drawing.Size(190, 22);
            this.txb_ConfirmPass.TabIndex = 9;
            // 
            // txb_NewPass
            // 
            this.txb_NewPass.Location = new System.Drawing.Point(507, 169);
            this.txb_NewPass.Name = "txb_NewPass";
            this.txb_NewPass.PasswordChar = 'k';
            this.txb_NewPass.Size = new System.Drawing.Size(190, 22);
            this.txb_NewPass.TabIndex = 10;
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.BackColor = System.Drawing.Color.Red;
            this.bt_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_Cancel.CausesValidation = false;
            this.bt_Cancel.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cancel.ForeColor = System.Drawing.Color.Black;
            this.bt_Cancel.Location = new System.Drawing.Point(385, 363);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(100, 46);
            this.bt_Cancel.TabIndex = 11;
            this.bt_Cancel.Text = "Cancel";
            this.bt_Cancel.UseVisualStyleBackColor = false;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // bt_Confim
            // 
            this.bt_Confim.BackColor = System.Drawing.Color.Aqua;
            this.bt_Confim.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Confim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Confim.Location = new System.Drawing.Point(583, 362);
            this.bt_Confim.Name = "bt_Confim";
            this.bt_Confim.Size = new System.Drawing.Size(100, 44);
            this.bt_Confim.TabIndex = 12;
            this.bt_Confim.Text = "Confirm";
            this.bt_Confim.UseVisualStyleBackColor = false;
            this.bt_Confim.Click += new System.EventHandler(this.bt_Confim_Click);
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(563, 26);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(69, 17);
            this.lb_username.TabIndex = 14;
            this.lb_username.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Your Current Username is: ";
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 684);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bt_Confim);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.txb_NewPass);
            this.Controls.Add(this.txb_ConfirmPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbt_No);
            this.Controls.Add(this.rbt_Yes);
            this.Name = "ResetPassword";
            this.Text = "ResetPassword";
            this.Load += new System.EventHandler(this.ResetPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbt_Yes;
        private System.Windows.Forms.RadioButton rbt_No;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_ConfirmPass;
        private System.Windows.Forms.TextBox txb_NewPass;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_Confim;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label label6;
    }
}