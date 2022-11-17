using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ResetPassword : Form
    {
        static string UserName;
        User user = new User();
        public ResetPassword()
        {
            InitializeComponent();
        }

        public ResetPassword(string username)
        {
            InitializeComponent();
            UserName = username;
        }

        bool verif()
        {
            if (txb_ConfirmPass.Text.Trim() == "" || txb_NewPass.Text.Trim() == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        #region Control Buttons Function
        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void bt_Confim_Click(object sender, EventArgs e)
        {
            if (rbt_Yes.Checked == true)
            {
                string password = txb_NewPass.Text;
                string ConfirmPass = txb_ConfirmPass.Text;

                if (verif())
                {
                    if (String.Compare(password, ConfirmPass) != 0)
                    {
                        MessageBox.Show("Password Not Match!", "Invalid Password Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (user.updatePassword(UserName, password))
                        {
                            MessageBox.Show("Password Updated", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Password Not Updated!", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Password Was Not Changed!", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
        #endregion

        private void ResetPassword_Load(object sender, EventArgs e)
        {
            //Nếu dùng cách tạo biến static thì uncomment dòng dưới
            //string userName = FindPasswordForm.to;

            //Nếu dùng cách tạo constructor truyền biến string thì uncomment dòng dưới
            string ForgotUsername = UserName;

            lb_password.Text = user.getPassword(ForgotUsername);
            lb_username.Text = user.getUserName(ForgotUsername);
        }


        private void rbt_Yes_Click(object sender, EventArgs e)
        {
            txb_ConfirmPass.Enabled = true;
            txb_NewPass.Enabled = true;
        }

        private void rbt_No_Click(object sender, EventArgs e)
        {
            txb_ConfirmPass.Enabled = false;
            txb_NewPass.Enabled = false;
        }
    }
}
