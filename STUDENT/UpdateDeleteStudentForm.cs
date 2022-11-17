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
using System.IO;

namespace WindowsFormsApp1
{
    public partial class UpdateDeleteStudentForm : Form
    {
        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        private void bt_Find_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txb_ID.Text);
            SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate, gender, phone, address, picture FROM std WHERE id = " + id);
            DataTable table = student.getStudents(command);
            if(table.Rows.Count > 0)
            {
                txb_FName.Text = table.Rows[0]["fname"].ToString();
                txb_LName.Text = table.Rows[0]["lname"].ToString();
                dateTimePicker1.Value = (DateTime)table.Rows[0]["bdate"];

                //Gender
                if( table.Rows[0]["gender"].ToString() == "Female")
                {
                    rbt_Female.Checked = true;
                }    
                else
                {
                    rbt_Male.Checked = true;
                }

                txb_Phone.Text = table.Rows[0]["phone"].ToString();
                txb_Address.Text = table.Rows[0]["address"].ToString();

                //Picture
                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBox1.Image = Image.FromStream(picture);
                
            }    
            else
            {
                MessageBox.Show("not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }    
        }

        private void bt_Remove_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txb_ID.Text);
            SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate, gender, phone, address, picture FROM std WHERE id = " + id);
            DataTable table = student.getStudents(command);
            if (table.Rows.Count > 0)
            {
                if (!(txb_FName.Text.Trim() == ""))
                {
                    if (student.deleteStudent(id))
                    {
                        MessageBox.Show("Student Removed", "Removed Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Removed Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Field", "Removed Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("ID not found", "Removed Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

       
        private void bt_Edit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txb_ID.Text);
            SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate, gender, phone, address, picture FROM std WHERE id = " + id);
            DataTable table = student.getStudents(command);
            if (table.Rows.Count > 0)
            {
                STUDENT student = new STUDENT();
                string fname = txb_FName.Text;
                string lname = txb_LName.Text;
                DateTime bdate = dateTimePicker1.Value;
                string phone = txb_Phone.Text;
                string adrs = txb_Address.Text;
                string gender = "Male";

                if (rbt_Female.Checked)
                {
                    gender = "Female";
                }

                MemoryStream pic = new MemoryStream();
                int born_year = dateTimePicker1.Value.Year;
                int this_year = DateTime.Now.Year;
                // student form 10-100, may change
                if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
                {
                    MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verif())
                {
                    pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                    if (student.updateStudent(id, fname, lname, bdate, gender, phone, adrs, pic))
                    {
                        MessageBox.Show("Student Updated", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            else
            {
                MessageBox.Show("ID not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            bool verif()
            {
                if ((txb_FName.Text.Trim() == "")
                    || (txb_LName.Text.Trim() == "")
                    || (txb_Address.Text.Trim() == "")
                    || (txb_Phone.Text.Trim() == "")
                    || (pictureBox1.Image == null))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

       
    }
}
