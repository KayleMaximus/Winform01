
namespace WindowsFormsApp1
{
    partial class FindPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindPasswordForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_Email = new System.Windows.Forms.TextBox();
            this.txb_ConfirmCode = new System.Windows.Forms.TextBox();
            this.bt_SendConfirm = new System.Windows.Forms.Button();
            this.bt_ConfirmCode = new System.Windows.Forms.Button();
            this.lb_CheckMailExist = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Code:";
            // 
            // txb_Email
            // 
            this.txb_Email.Location = new System.Drawing.Point(195, 189);
            this.txb_Email.Multiline = true;
            this.txb_Email.Name = "txb_Email";
            this.txb_Email.Size = new System.Drawing.Size(231, 28);
            this.txb_Email.TabIndex = 4;
            this.txb_Email.TextChanged += new System.EventHandler(this.txb_Email_TextChanged);
            // 
            // txb_ConfirmCode
            // 
            this.txb_ConfirmCode.Location = new System.Drawing.Point(195, 247);
            this.txb_ConfirmCode.Name = "txb_ConfirmCode";
            this.txb_ConfirmCode.Size = new System.Drawing.Size(231, 22);
            this.txb_ConfirmCode.TabIndex = 5;
            // 
            // bt_SendConfirm
            // 
            this.bt_SendConfirm.BackColor = System.Drawing.Color.Blue;
            this.bt_SendConfirm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_SendConfirm.Location = new System.Drawing.Point(649, 185);
            this.bt_SendConfirm.Name = "bt_SendConfirm";
            this.bt_SendConfirm.Size = new System.Drawing.Size(140, 46);
            this.bt_SendConfirm.TabIndex = 6;
            this.bt_SendConfirm.Text = "Send Confimation";
            this.bt_SendConfirm.UseVisualStyleBackColor = false;
            this.bt_SendConfirm.Click += new System.EventHandler(this.bt_SendConfirm_Click);
            // 
            // bt_ConfirmCode
            // 
            this.bt_ConfirmCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_ConfirmCode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_ConfirmCode.Location = new System.Drawing.Point(649, 244);
            this.bt_ConfirmCode.Name = "bt_ConfirmCode";
            this.bt_ConfirmCode.Size = new System.Drawing.Size(140, 40);
            this.bt_ConfirmCode.TabIndex = 7;
            this.bt_ConfirmCode.Text = "Verify";
            this.bt_ConfirmCode.UseVisualStyleBackColor = false;
            this.bt_ConfirmCode.Click += new System.EventHandler(this.bt_ConfirmCode_Click);
            // 
            // lb_CheckMailExist
            // 
            this.lb_CheckMailExist.AutoSize = true;
            this.lb_CheckMailExist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CheckMailExist.ForeColor = System.Drawing.Color.Red;
            this.lb_CheckMailExist.Location = new System.Drawing.Point(432, 197);
            this.lb_CheckMailExist.Name = "lb_CheckMailExist";
            this.lb_CheckMailExist.Size = new System.Drawing.Size(0, 20);
            this.lb_CheckMailExist.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(826, -24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(498, 864);
            this.label4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(76, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(525, 503);
            this.label5.TabIndex = 10;
            // 
            // FindPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1300, 849);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_CheckMailExist);
            this.Controls.Add(this.bt_ConfirmCode);
            this.Controls.Add(this.bt_SendConfirm);
            this.Controls.Add(this.txb_ConfirmCode);
            this.Controls.Add(this.txb_Email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FindPasswordForm";
            this.Text = "FindPasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_Email;
        private System.Windows.Forms.TextBox txb_ConfirmCode;
        private System.Windows.Forms.Button bt_SendConfirm;
        private System.Windows.Forms.Button bt_ConfirmCode;
        private System.Windows.Forms.Label lb_CheckMailExist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}