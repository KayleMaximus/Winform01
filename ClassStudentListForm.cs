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
    public partial class ClassStudentListForm : Form
    {
        public int ContactID;
        public string ClassName;
        public ClassStudentListForm()
        {
            InitializeComponent();
        }
        MY_DB mydb = new MY_DB();
        private void ClassStudentListForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select std.id as StudentID, std.fname as FirstName, std.lname as LastName, course.label as CourseName, contact.fname as ContactName from score inner join classes on score.course_id = classes.courseid inner join std on score.student_id = std.id inner join course on course.id = classes.courseid inner join Contact on contact.id = classes.contactid where contact.id = @cid and course.label = @cname order by courseName", mydb.getConnection);
            command.Parameters.Add("@cid", SqlDbType.Int).Value = ContactID;
            command.Parameters.Add("@cname", SqlDbType.NVarChar).Value = ClassName;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            mydb.closeConnection();
        }
    }
}
