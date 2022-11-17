using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void bt_AddStudent_Click(object sender, EventArgs e)
        {
            if(verif())
            {
                int id = Convert.ToInt32(txb_ID.Text);
                string fname = txb_Fname.Text;
                string lname = txb_Lname.Text;
                DateTime bdate = dateTimePicker1.Value;
                string phone = txb_Phone.Text;
                string adrs = txb_Address.Text;
                string gender = "Male";
                if (RadioButtonFemale.Checked)
                {
                    gender = "Female";
                }
                MemoryStream pic = new MemoryStream();
                int born_year = dateTimePicker1.Value.Year;
                int this_year = DateTime.Now.Year;
                if (student.CheckStudentID(Convert.ToInt32(txb_ID.Text)))
                {
                    if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
                    {
                        MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (verif())
                    {
                        PicBox_StudentImage.Image.Save(pic, PicBox_StudentImage.Image.RawFormat);
                        if (student.insertStudent(id, fname, lname, bdate, gender, phone, adrs, pic))
                        {
                            MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("ID Existed!", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }    
            else
            {
                MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }    
        }
        private void bt_UploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*gif)|*.jpg;*.pngl*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PicBox_StudentImage.Image = Image.FromFile(opf.FileName);
            }
        }
        bool verif()
        {
            if ((txb_Fname.Text.Trim() == "")
                || (txb_Lname.Text.Trim() == "")
                || (txb_ID.Text.Trim() == "")
                || (txb_Address.Text.Trim() == "")
                || (txb_Phone.Text.Trim() == "")
                || (PicBox_StudentImage.Image == null))
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
