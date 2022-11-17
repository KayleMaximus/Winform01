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
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }
        CourseCopy course = new CourseCopy();
        //Button Add New Course
        private void bt_Add_Click(object sender, EventArgs e)
        {
            //Check if the name is not empty 
            //Check if this course already exists
            //The courses hours number must be > 10, we can do it from the numericDropDown Tool, or by using the if condition
            //The Description is optional
            try
            {
                if (verif())
                {
                    int num = -1;
                    if (txb_Label.Text.Trim() == "")
                    {
                        MessageBox.Show("Add a Course Name", "Add Course ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else if (!Int32.TryParse(txb_CourseID.Text, out num))
                    {
                        MessageBox.Show("Please Add An InterGer For Course's ID", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (course.checkCourseName(txb_Label.Text))
                    {
                        int id = Convert.ToInt32(txb_CourseID.Text);
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
                    
        }
        bool verif()
        {
            if (txb_CourseID.Text.Trim() == "" || txb_Label.Text.Trim() == "" )
                return false;
            else
                return true;
                    
        }

        private void AddCourseForm_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = 5;
        }
    }
}
