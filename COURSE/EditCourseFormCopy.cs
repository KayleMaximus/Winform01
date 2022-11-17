using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EditCourseForm : Form
    {
        public EditCourseForm()
        {
            InitializeComponent();
        }
        CourseCopy course = new CourseCopy();
        private void EditCourseForm_Load(object sender, EventArgs e)
        {
            //Dùng Combobox lấy tên course 
            cbb_SelectCourse.DataSource = course.getAllCourses();
            cbb_SelectCourse.DisplayMember = "Label";
            cbb_SelectCourse.ValueMember = "id";
            cbb_SelectCourse.SelectedItem = null;
            numericUpDown1.Value = 5;

        }
        public void fillCombo(int index)
        {
            cbb_SelectCourse.DataSource = course.getAllCourses();
            cbb_SelectCourse.DisplayMember = "Label";
            cbb_SelectCourse.ValueMember = "id";
            cbb_SelectCourse.SelectedItem = index;
        }
        private void cbb_SelectCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //lấy dữ liệu
                int id = Convert.ToInt32(cbb_SelectCourse.SelectedValue);
                DataTable table = new DataTable();
                table = course.getCourseById(id);
                txb_Label.Text = table.Rows[0][1].ToString();
                numericUpDown1.Value = Int32.Parse(table.Rows[0][2].ToString());
                txb_Description.Text = table.Rows[0][3].ToString();
            }
            catch 
            {
                
            }

        }
        private void bt_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txb_Label.Text.Trim() == "")
                {
                    MessageBox.Show("Add a Course Name", "Add Course ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if ((int)numericUpDown1.Value < 10)
                {
                    MessageBox.Show("Period Require At Least 10 ", "Add Course ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string name = txb_Label.Text;
                    int hrs = (int)numericUpDown1.Value;
                    string descr = txb_Description.Text;
                    int id = (int)cbb_SelectCourse.SelectedValue;

                    //Lấy lại phần kiểm tra tên course
                    if (!course.checkCourseName(name, id))
                    {
                        MessageBox.Show("This Course Name Already Exist", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (course.updateCourse(id, name, hrs, descr))
                    {
                        MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillCombo(cbb_SelectCourse.SelectedIndex);
                    }
                    else
                    {
                        MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

    }
}
