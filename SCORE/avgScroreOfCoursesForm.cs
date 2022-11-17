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
    public partial class avgScroreOfCoursesForm : Form
    {
        public avgScroreOfCoursesForm()
        {
            InitializeComponent();
        }

        SCORE score = new SCORE();
        private void avgScroreOfCoursesForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = score.getAVGScoreByCourse();
            
            //Cách của Hơn
            //MY_DB mydb = new MY_DB();
            //SqlCommand command = new SqlCommand("Select label, Course_id, ROUND(AVG(student_score) , 2) as 'average' From Score Inner JOIN  course on Course_id = id Group by Course_id, label", mydb.getConnection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable table = new DataTable();
            //adapter.Fill(table);
            //dataGridView1.DataSource = table;
        }
    }
}
