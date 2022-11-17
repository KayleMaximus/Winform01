using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            //STUDENT 
            if(rdb_student.Checked == true)
            {
                //table username and password
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                //table gmail and password
                SqlDataAdapter adapter2 = new SqlDataAdapter();
                DataTable table2 = new DataTable();

                //check username and password
                SqlCommand command = new SqlCommand("SELECT * FROM Login WHERE username = @username And password = @password", db.getConnection);
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = TextBoxUsername.Text;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBoxPassword.Text;

                //check gmail and password
                SqlCommand command2 = new SqlCommand("SELECT * FROM Login WHERE gmail = @gmail And password = @password", db.getConnection);
                command2.Parameters.Add("@gmail", SqlDbType.VarChar).Value = TextBoxUsername.Text;
                command2.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBoxPassword.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                adapter2.SelectCommand = command2;
                adapter2.Fill(table2);


                if ((table.Rows.Count > 0) || (table2.Rows.Count > 0))
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show(this);
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            //HUMAN RESOURCE
            else if(rbt_HM.Checked == true)
            {
                //table username and password
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                //table gmail and password
                SqlDataAdapter adapter2 = new SqlDataAdapter();
                DataTable table2 = new DataTable();

                //check username and password
                SqlCommand command = new SqlCommand("SELECT * FROM HumanResource WHERE uname = @username And pwd = @password", db.getConnection);
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = TextBoxUsername.Text;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBoxPassword.Text;

                //check gmail and password
                SqlCommand command2 = new SqlCommand("SELECT * FROM HumanResource WHERE gmail = @gmail And pwd = @password", db.getConnection);
                command2.Parameters.Add("@gmail", SqlDbType.VarChar).Value = TextBoxUsername.Text;
                command2.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBoxPassword.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                adapter2.SelectCommand = command2;
                adapter2.Fill(table2);


                if ((table.Rows.Count > 0) || (table2.Rows.Count > 0))
                {
                    //gán biến id của human resource cho class global để mỗi HR là mỗi trường data riêng
                    int HRID = Convert.ToInt16(table.Rows[0][0].ToString());
                    Global.SetGlobalUserId(HRID);

                    Hide();

                    MainFormHR form = new MainFormHR();
                    form.Show(this);

                    //Gán biến form cho fromHR để gọi ngược lại loginform khi sign out
                    form.loginForm = this;

                    
                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Chose User Type", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
            
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lb_Register_Click(object sender, EventArgs e)
        {
            if (rdb_student.Checked == true)
            {
                AddUserForm ASF = new AddUserForm();
                ASF.Show(this);
            }
            else if (rbt_HM.Checked == true)
            {
                AddHumanReForm AHRF = new AddHumanReForm();
                AHRF.Show(this);
            }
            else
            {
                MessageBox.Show("Please Chose User Type", "Registor Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void TextBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_Login_Click(null, null);
            }    
        }

        private void lb_ForgotPass_Click(object sender, EventArgs e)
        {
            FindPasswordForm find = new FindPasswordForm();
            find.Show(this);
        }


    }
}
