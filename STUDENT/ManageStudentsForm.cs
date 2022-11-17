using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ManageStudentsForm : Form
    {
        public ManageStudentsForm()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();

        //Copy code bên StudentListForm (DataGridView) để nạp data vào Gridview
        public void fillGrid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;

            //Xu ly hinh anh, code tham khao msdn
            dataGridView1.DataSource = student.getStudents(command);
            dataGridView1.RowTemplate.Height = 80;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.AllowUserToAddRows = false;

            //Đếm sinh viên
            LabelTotalStudent.Text = ("Total Students: " + dataGridView1.Rows.Count);
        }
        //Search
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std WHERE CONCAT(fname, lname, address) LIKE '%" + txb_Search.Text + "%'");
            fillGrid(command);
        }
        //Copy Code bên AddStudentForm để Upload Picture 
        private void bt_Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*gif)|*.jpg;*.pngl*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }
        //Xóa các field
        private void bt_Reset_Click(object sender, EventArgs e)
        {
            txb_ID.Text = "";
            txb_FName.Text = "";
            txb_LName.Text = "";
            txb_Address.Text = "";
            txb_Phone.Text = "";
            pictureBox1.Image = null;
            rbt_Male.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
        }
        //Download Picture
        private void bt_Download_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("Student_" + txb_ID.Text);
            if ((pictureBox1.Image == null))
            {
                MessageBox.Show("No Image In The PictureBox");
            }    
            else if ((svf.ShowDialog() ==  DialogResult.OK))
            {
                pictureBox1.Image.Save((svf.FileName + ("." + ImageFormat.Jpeg.ToString())));
            }    
        }
        //Button Insert (Copy code nút add bên AddStudentForm)
        private void bt_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (verif())
                {
                    int id = Convert.ToInt32(txb_ID.Text);
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
                    if (student.CheckStudentID(Convert.ToInt32(txb_ID.Text)))
                    {
                        if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
                        {
                            MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (verif())
                        {
                            pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

        }
        //Edit Thông Tin (Copy Code từ sự kiện doubleClickCell của Studenlistform: UpdateDeleteStudentForm)
        private void bt_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
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
                    try
                    {
                        id = int.Parse(txb_ID.Text);
                        pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                        if (student.updateStudent(id, fname, lname, bdate, gender, phone, adrs, pic))
                        {
                            MessageBox.Show("Student Edited", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fillGrid(new SqlCommand("SELECT * FROM std"));
                        }
                        else
                        {
                            MessageBox.Show("Can not Update Contact With Non-Exists ID", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
        //COPy code bên updatedelete studentform
        private void bt_Remove_Click(object sender, EventArgs e)
        {

            try
            {
                int id = int.Parse(txb_ID.Text);

                if ((MessageBox.Show("Are you sure want to delete this student?", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (student.deleteStudent(id))
                    {

                        MessageBox.Show("Student Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGrid(new SqlCommand("SELECT * FROM STD"));
                        txb_ID.Text = "";
                        txb_FName.Text = "";
                        txb_LName.Text = "";
                        txb_Address.Text = "";
                        txb_Phone.Text = "";
                        pictureBox1.Image = null;
                        rbt_Male.Checked = true;
                        dateTimePicker1.Value = DateTime.Now;
                    }
                    else
                    {
                        MessageBox.Show("Student Not Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            
        }
        private void ManageStudentsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet.std' table. You can move, or remove it, as needed.
            this.stdTableAdapter.Fill(this.myDBDataSet.std);
            string command1 = "SELECT * FROM STD ";
            SqlCommand sqlcomma = new SqlCommand(command1);
            fillGrid(sqlcomma);
        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Thứ Tự các cột: id - fname - lname - bd - gdr - phn - adrs - pic
            txb_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txb_FName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txb_LName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;

            // Gender
            if ((dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Female"))
            {
                rbt_Female.Checked = true;
                rbt_Male.Checked = false;
            }
            else
            {
                rbt_Male.Checked = true;
                rbt_Female.Checked = false;
            }

            txb_Phone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txb_Address.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            //Code xử lý hình ảnh (chưa tối ưu)
            //byte[] pic;
            //pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            //MemoryStream picture = new MemoryStream(pic);
            //pictureBox1.Image = Image.FromStream(picture);
            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            Image x = (Bitmap)((new ImageConverter()).ConvertFrom(pic));
            pictureBox1.Image = x;
            Show();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Thứ Tự các cột: id - fname - lname - bd - gdr - phn - adrs - pic
            txb_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txb_FName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txb_LName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;

            // Gender
            if ((dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Female"))
            {
                rbt_Female.Checked = true;
                rbt_Male.Checked = false;
            }
            else
            {
                rbt_Male.Checked = true;
                rbt_Female.Checked = false;
            }

            txb_Phone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txb_Address.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            //Code xử lý hình ảnh (chưa tối ưu)
            //byte[] pic;
            //pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            //MemoryStream picture = new MemoryStream(pic);
            //pictureBox1.Image = Image.FromStream(picture);
            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            Image x = (Bitmap)((new ImageConverter()).ConvertFrom(pic));
            pictureBox1.Image = x;
            //Show();
        }
        bool verif()
        {
            if ((txb_FName.Text.Trim() == "")
                || (txb_LName.Text.Trim() == "")
                || (txb_Address.Text.Trim() == "")
                || (txb_Phone.Text.Trim() == "")
                || (txb_ID.Text.Trim() == "")
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
