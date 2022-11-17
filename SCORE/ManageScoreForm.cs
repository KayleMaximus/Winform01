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
    public partial class ManageScoreForm : Form
    {
        public ManageScoreForm()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        STUDENT student = new STUDENT();
        CourseCopy course = new CourseCopy();
        string data = "score";

        private void ManageScoreForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = score.getStudentScore();
            data = "score";

            comboBox1.DataSource = course.getAllCourses();
            comboBox1.DisplayMember = "label";
            comboBox1.ValueMember = "id";
        }
        private void bt_ShowScore_Click(object sender, EventArgs e)
        {
            data = "score";
            dataGridView1.DataSource = score.getStudentScore();
        }
        private void bt_ShowStudent_Click(object sender, EventArgs e)
        {
            data = "std";
            SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate FROM std");
            dataGridView1.DataSource = student.getStudents(command);
        }
        private void bt_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxScore.Text.Trim() == "")
                {
                    MessageBox.Show("Please Add An Score", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int studentID = Convert.ToInt32(textBoxID.Text);
                    int courseID = Convert.ToInt32(comboBox1.SelectedValue);
                    float scoreValue = float.Parse(TextBoxScore.Text);
                    string description = textBoxDescription.Text;
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
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            getDataFromDatagridView();
        }
        private void bt_Remove_Click(object sender, EventArgs e)
        {
            
            if( data == "score")
            {
                int student_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                int course_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                if ((MessageBox.Show("Are you sure you want to delete this course", "Remove Course", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
                {
                    if (score.deleteScore(student_id, course_id))
                    {
                        MessageBox.Show("Score Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = score.getStudentScore();
                    }
                    else
                    {
                        MessageBox.Show("Score Not Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }  
            else
            {
                MessageBox.Show("Please Chose Score Before Delete!", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }    
            
        }
        private void bt_AVGscore_Click(object sender, EventArgs e)
        {
            avgScroreOfCoursesForm ASOC = new avgScroreOfCoursesForm();
            ASOC.Show(this); 
        }
        void getDataFromDatagridView()
        {
            if( data == "std")
            {
                textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
            else if (data == "score")
            {
                textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                comboBox1.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value;
            }
        }
    }
}
