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
    public partial class ContactClassForm : Form
    {
        public int ContactID;
        public ContactClassForm()
        {
            InitializeComponent();
        }
        MY_DB mydb = new MY_DB();
        public ContactClassForm(int contactID)
        {
            this.ContactID = contactID;
        }
        private void ContactClassForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select contact.fname as FirstName, contact.lname as LastName, Course.id as CourseID, course.label as CourseName from contact inner join Classes on contact.id = Classes.contactID inner join course on course.id = classes.courseid WHERE contact.id = @cid", mydb.getConnection);
            command.Parameters.Add("@cid", SqlDbType.Int).Value = ContactID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ClassStudentListForm CSLF = new ClassStudentListForm();
            CSLF.ContactID = ContactID;
            CSLF.ClassName = dataGridView1.CurrentRow.Cells["CourseName"].Value.ToString();
            CSLF.Show(this);
        }
    }
}
