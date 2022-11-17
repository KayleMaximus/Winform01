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
    public partial class ManageCourseForm : Form
    {
        public ManageCourseForm()
        {
            InitializeComponent();
        }

        CourseCopy course = new CourseCopy();
        //use this variable for navigation purpose
        int pos;
        #region sub-functions
        //thao tác listbox với coursename và id (có thể thay thế cho datagridview)
        void reloadListBoxData()
        {
            listBox1.DataSource = course.getAllCourses();
            listBox1.ValueMember = "Id";
            listBox1.DisplayMember = "label";
            listBox1.SelectedItem = null;
            lb_Total.Text = ("Total Course: " + course.totalCourse());
        }
        //lấy data theo chỉ mục index, dùng datarow để lấy dữ liệu hàng của table (có thể thay thế cho datagridview)
        void showData(int index)
        {
            DataRow dr = course.getAllCourses().Rows[index];
            listBox1.SelectedIndex = index;
            txb_ID.Text = dr.ItemArray[0].ToString();
            txb_Label.Text = dr.ItemArray[1].ToString();
            numericUpDown1.Value = int.Parse(dr.ItemArray[2].ToString());
            txb_Description.Text = dr.ItemArray[3].ToString();

        }
        #endregion
        #region Control Buttons's Events
        //form load thì cũng load dữ liệu lên
        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            reloadListBoxData();
        }
        //dùng thử datarowview xem từng dòng
        private void listBox1_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)listBox1.SelectedItem;
            pos = listBox1.SelectedIndex;
            showData(pos);
        }
        private void bt_Add_Click(object sender, EventArgs e)
        {
            //Check if the name is not empty 
            //Check if this course already exists
            //The courses hours number must be > 10, we can do it from the numericDropDown Tool, or by using the if condition
            //The Description is optional
            if (verif())
            {
                int num = -1;
                if (txb_Label.Text.Trim() == "")
                {
                    MessageBox.Show("Add a Course Name", "Add Course ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (!Int32.TryParse(txb_ID.Text, out num))
                {
                    MessageBox.Show("Please Add An InterGer For Course's ID", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (course.checkCourseName(txb_Label.Text))
                {
                    int id = Convert.ToInt32(txb_ID.Text);
                    string nameCourse = txb_Label.Text;
                    int hourse = (int)numericUpDown1.Value;
                    string description = txb_Description.Text;
                    if (hourse < 10)
                    {
                        MessageBox.Show("Period Require At Least 10 ", "Add Course ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (course.checkCourseID(id))
                        {
                            if (course.insertCourse(id, nameCourse, hourse, description))
                            {
                                MessageBox.Show("New Course Insert", "Add Course ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Course Not Insert", "Add Course ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("ID Existed!", "Add Course ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("This Course Name Already Exists", "Add Course ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if (txb_ID.Text.Trim() == "" || txb_Label.Text.Trim() == "")
                return false;
            else
                return true;

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
                    int id = int.Parse(txb_ID.Text);

                    //Lấy lại phần kiểm tra tên course
                    if (!course.checkCourseName(name, id))
                    {
                        MessageBox.Show("This Course Name Already Exist", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (course.updateCourse(id, name, hrs, descr))
                    {
                        MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reloadListBoxData();
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
            

            pos = 0;
        }
        private void bt_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                int CourseID = Convert.ToInt32(txb_ID.Text);
                if ((MessageBox.Show("Are you sure you want to delete this course", "Remove Course", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
                {
                    if (course.deleteCourse(CourseID))
                    {
                        MessageBox.Show("Course Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Clear Fields
                        txb_ID.Text = "";
                        txb_Label.Text = "";
                        numericUpDown1.Value = 10;
                        txb_Description.Text = "";

                        reloadListBoxData();
                    }
                    else
                    {
                        MessageBox.Show("Course Not Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Enter A Valid Numeric ID", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            pos = 0;
        }
        #endregion
        #region navigate buttons
        //có code tham khảo tại: https://stackoverflow.com/questions/25950482/using-next-and-previous-buttons-to-navigate-buttons-to-navigate-through-a-list
        //button first
        private void bt_First_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData(pos);
        }
        //button next
        private void bt_Next_Click(object sender, EventArgs e)
        {
            if(pos < (course.getAllCourses().Rows.Count - 1 ))
            {
                pos = pos + 1;
                showData(pos);
            }    
        }
        //Button Previous
        private void bt_Previous_Click(object sender, EventArgs e)
        {
            if(pos > 0 )
            {
                pos = pos - 1;
                showData(pos);
            }    
        }
        //Button last
        private void bt_Last_Click(object sender, EventArgs e)
        {
            pos = course.getAllCourses().Rows.Count - 1;
            showData(pos);
        }
        #endregion
    }
}
