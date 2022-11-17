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
using System.IO;

namespace WindowsFormsApp1
{
    public partial class studentListForm : Form
    {
        public studentListForm()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();
        private void studentListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet.std' table. You can move, or remove it, as needed.
            //this.stdTableAdapter.Fill(this.myDBDataSet.std);
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            dataGridView1.DataSource = student.getStudents(command);

            dataGridView1.ReadOnly = true;
            //Xu ly hinh anh, code tham khao msdn
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 120;
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            //dataGridView1.AllowUserToAddRows = false;
        }

        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            dataGridView1.ReadOnly = true;
            //Xu ly hinh anh, code tham khao msdn
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
            UpdateDeleteStudentForm updateDeletStdF = new UpdateDeleteStudentForm();
            //Thứ Tự các cột: id - fname - lname - bd - gdr - phn - adrs - pic
            updateDeletStdF.txb_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateDeletStdF.txb_FName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateDeletStdF.txb_LName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateDeletStdF.dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;

            // Gender
            if((dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Female"))
            {
                updateDeletStdF.rbt_Female.Checked = true;
            }    
            else
            {
                updateDeletStdF.rbt_Male.Checked = true;
            }

            updateDeletStdF.txb_Phone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            updateDeletStdF.txb_Address.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            //Code xử lý hình ảnh (chưa tối ưu)
            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateDeletStdF.pictureBox1.Image = Image.FromStream(picture);
            updateDeletStdF.Show();
        }


    }
}
