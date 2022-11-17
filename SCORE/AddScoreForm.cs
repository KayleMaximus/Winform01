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
    public partial class AddScoreForm : Form
    {
        public AddScoreForm()
        {
            InitializeComponent();
        }

        SCORE score = new SCORE();
        CourseCopy course = new CourseCopy();
        STUDENT student = new STUDENT();
        

        private void AddScoreForm_Load(object sender, EventArgs e)
        {
            //Lấy thông tin all course và display vào combobox
            cbb_Course.DataSource = course.getAllCourses();
            cbb_Course.DisplayMember = "Label";
            cbb_Course.ValueMember = "Id";

            //
            SqlCommand command = new SqlCommand("SELECT id, fname, lname FROM std");
            dataGridView1.DataSource = student.getStudents(command);
        }

        
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            //Get id of the selected student
            txb_StudentID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void bt_AddScore_Click(object sender, EventArgs e)
        {
            try
            {
                if (txb_Score.Text.Trim() == "")
                {
                    MessageBox.Show("Please Add An Score", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int studentID = Convert.ToInt32(txb_StudentID.Text);
                    int courseID = Convert.ToInt32(cbb_Course.SelectedValue);
                    float scoreValue = float.Parse(txb_Score.Text);
                    string description = txb_Description.Text;
                    if (scoreValue >= 0 && scoreValue <= 10)
                    {
                        //Check if the score is already set for student on this course
                        if (!score.studentScoreExist(studentID, courseID))
                        {
                            if (score.insertScore(studentID, courseID, scoreValue, description))
                                MessageBox.Show("Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("Score Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                            MessageBox.Show("The Score For This Course Are Already Set", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("The Score Must Between 0 And 10!", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
