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
using System.Net.Mail;
using System.Net;

namespace WindowsFormsApp1
{
    public partial class FindPasswordForm : Form
    {
        
        public FindPasswordForm()
        {
            InitializeComponent();
        }
        MY_DB mydb = new MY_DB();
        


        //Generate Random codes for verification
        string randomCode;
        //Receiver Mail Address (dùng biến tĩnh để có thể gọi biến qua TÊN form này và dùng ở ResetPasswordForm)
        //Hoặc có thể dùng Constructor bên form Reset và truyền biến String vào
        public static string to;
        private void bt_SendConfirm_Click(object sender, EventArgs e)
        {
            if (txb_Email.Text.Trim() != "")
            {
                if (lb_CheckMailExist.Text == "Valid Email")//&& txb_ConfirmCode != null)
                {
                    string from, pass, messageBody;

                    //Generate Random Code For Confirmation
                    Random rand = new Random();
                    randomCode = (rand.Next(999999)).ToString();

                    MailMessage message = new MailMessage();
                    to = (txb_Email.Text).ToString();
                    from = "khaihkttran@gmail.com";
                    pass = "vrwbsjxttjtfgmey";
                    messageBody = "Your reset code is " + randomCode;
                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Body = messageBody;
                    message.Subject = "Password Reseting Code!";
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);
                    try
                    {
                        smtp.Send(message);
                        MessageBox.Show("Code Send Successfully!", "Confirmation Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Email!", "Confirmation Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid Email!", "Confirmation Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void bt_ConfirmCode_Click(object sender, EventArgs e)
        {
            if (randomCode == (txb_ConfirmCode.Text).ToString())
            {
                //Gán tên username vào biến tĩnh để phục vụ cho việc tìm password DỰA TRÊN USERNAME ở form sau
                //to = txb_UserName.Text;
                ResetPassword rp = new ResetPassword(to); //Dùng constructor
                //ResetPassword rp = new ResetPassword(); // Dùng Biến static
                rp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Code!", "Confirmation Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txb_Email_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM Login WHERE gmail = @email ", mydb.getConnection);

            command.Parameters.Add("@email", SqlDbType.VarChar).Value = txb_Email.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                lb_CheckMailExist.ForeColor = Color.Green;
                lb_CheckMailExist.Text = "Valid Email";
            }
            else
            {
                lb_CheckMailExist.ForeColor = Color.Red;
                lb_CheckMailExist.Text = "Can't Found Email!";
            }
        }
    }
}



