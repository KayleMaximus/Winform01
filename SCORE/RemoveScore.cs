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
    public partial class RemoveScore : Form
    {
        public RemoveScore()
        {
            InitializeComponent();
        }

        SCORE score = new SCORE();
        STUDENT student = new STUDENT();
        private void RemoveScore_Load(object sender, EventArgs e)
        {
            //SqlCommand command = new SqlCommand("SELECT * FROM std");
            //dataGridView1.DataSource = student.getStudents(command);
            dataGridView1.DataSource = score.getStudentScore();
        }

        private void bt_deleteCourse_Click(object sender, EventArgs e)
        {
            int student_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int course_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            
            if ((MessageBox.Show("Are you sure you want to delete this score", "Remove score", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
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
    }
}
