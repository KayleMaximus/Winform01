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
using System.Xml;
using Xceed.Words.NET;
using Xceed.Document.NET;
using Font = Xceed.Document.NET.Font;
using Formatting = Xceed.Document.NET.Formatting;
using System.Diagnostics;
using Paragraph = Xceed.Document.NET.Paragraph;

namespace WindowsFormsApp1
{
    public partial class AVGResultByScoreForm : Form
    {
        public AVGResultByScoreForm()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        CourseCopy course = new CourseCopy();
        STUDENT student = new STUDENT();
        MY_DB mydb = new MY_DB();

        //DataTable FillGrid()
        //{
        //    SqlCommand command = new SqlCommand("SELECT id , Fname , Lname  FROM std", mydb.getConnection);
        //    SqlDataAdapter adapter = new SqlDataAdapter(command);
        //    DataTable table = new DataTable();
        //    adapter.Fill(table);

        //    DataTable tableCourse = new DataTable();
        //    tableCourse = course.getAllCourses();

        //    //lấy khóa học theo chiều ngang
        //    for (int i = 0; i < tableCourse.Rows.Count; i++)
        //    {
        //        DataColumn CourseNamecolumn = new DataColumn();
        //        CourseNamecolumn.ColumnName = tableCourse.Rows[i]["label"].ToString();
        //        table.Columns.Add(CourseNamecolumn);
        //    }
        //    //lấy điểm của từng khóa học dựa theo id của học sinh
        //    DataTable tableScore = new DataTable();
        //    tableScore = score.getStudentScore();

        //    for (int i = 0; i < table.Rows.Count; i++)
        //    {
        //        for (int c = 0; c < tableScore.Rows.Count; c++)
        //        {
        //            if (table.Rows[i]["id"].ToString() == tableScore.Rows[c]["student_id"].ToString())
        //            {
        //                for (int k = 3; k < table.Columns.Count; k++)
        //                {
        //                    if (table.Columns[k].ColumnName == tableScore.Rows[c]["label"].ToString())
        //                    {
        //                        //string coursename = table.Columns[k].ColumnName;
        //                        //table.Rows[i][coursename] = tableScore.Rows[c]["student_score"].ToString();
        //                        table.Rows[i][k] = tableScore.Rows[c]["student_score"].ToString();
        //                        break;
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    table.Columns.Add("AVG_Score", typeof(float));
        //    table.Columns.Add("Result", typeof(string));
        //    for (int i = 0; i < table.Rows.Count; i++)
        //    {
        //        int count = 0;
        //        float sum = 0;
        //        for (int j = 3; j < table.Columns.Count - 2; j++)
        //        {
        //            float temp;
        //            string coursename = table.Columns[j].ColumnName;
        //            if (float.TryParse(table.Rows[i][coursename].ToString(), out temp))
        //            {
        //                sum += temp;
        //                count++;
        //            }
        //        }

        //        float avg = sum / count;
        //        Math.Round(avg, 2);
        //        table.Rows[i]["AVG_Score"] = Math.Round(avg, 2);

        //        if (avg < 5)                    table.Rows[i]["Result"] = "Fail";
        //        if (avg >= 5 && avg <= 6.5)     table.Rows[i]["Result"] = "Average";
        //        if (avg > 6.5 && avg <= 7.9)    table.Rows[i]["Result"] = "Good";
        //        if (avg >= 8)                   table.Rows[i]["Result"] = "Excellent";
        //        if (count == 0)                 table.Rows[i]["Result"] = "Drop Out Of University!";
        //        if (avg.ToString() == "NaN")    table.Rows[i]["AVG_Score"] = 0;
        //    }

        //    return table;
        //}
        private void AVGResultByScoreForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = score.getAllCourseScoreAndResult();
            dataGridView1.AutoSize = true;
            dataGridView1.Columns[0].HeaderText = "Student ID";
            dataGridView1.Columns[1].HeaderText = "First Name";
            dataGridView1.Columns[2].HeaderText = "Last Name";
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txb_Id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txb_Lname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txb_Fname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
        private void bt_Print_Click(object sender, EventArgs e)
        {
            #region one
            string fileName = "Export_Student.docx";
            var doc = DocX.Create(fileName);
            #endregion

            #region two
            string title = "REPORT RESULT";

            Formatting titleFormat = new Formatting();
            titleFormat.FontFamily = new Font("Tahoma");
            titleFormat.Size = 20D;
            titleFormat.Position = 40;
            titleFormat.FontColor = Color.BlueViolet;
            titleFormat.UnderlineColor = Color.Gray;
            titleFormat.Italic = true;

            //Formatting Text Paragraph  
            Formatting textParagraphFormat = new Formatting();
            //font family  
            textParagraphFormat.FontFamily = new Font("Tahoma");
            //font size  
            textParagraphFormat.Size = 12D;
            //Spaces between characters  
            textParagraphFormat.Spacing = 1;
            //Insert title  
            Paragraph paragraphTitle = doc.InsertParagraph(title, false, titleFormat);
            paragraphTitle.Alignment = Alignment.center;
            //Insert text  
            //doc.InsertParagraph(textParagraph, false, textParagraphFormat);
            #endregion            
            dataGridView1.AllowUserToAddRows = false;
            int temp = dataGridView1.RowCount;
            #region four
            doc.InsertParagraph();
            //Create Table
            //var listPlayer = CreateInitData();
            int tempq = dataGridView1.ColumnCount;
            Table t = doc.AddTable(temp + 2, tempq);
            t.Alignment = Alignment.center;
            t.Design = TableDesign.ColorfulList;
            // Fill cells by adding text.  
            // First row
            t.Rows[0].Cells[0].Paragraphs.First().Append("ID");
            t.Rows[0].Cells[1].Paragraphs.First().Append("First Name");
            t.Rows[0].Cells[2].Paragraphs.First().Append("Last Name");
            temp = dataGridView1.RowCount;

            DataTable tableCourse = new DataTable();
            tableCourse = course.getAllCourses();
            for (int i = 0; i < tableCourse.Rows.Count; i++)
            {
                t.Rows[0].Cells[i + 3].Paragraphs.First().Append(tableCourse.Rows[i]["label"].ToString());
            }

            //for (int i = 3; i < tempq - 2; i++)
            //{
            //    t.Rows[0].Cells[i].Paragraphs.First().Append(dataGridView1.Rows[0].Cells[i].Value.ToString());
            //    //dem2++;
            //}

            t.Rows[0].Cells[tempq - 2].Paragraphs.First().Append("Average Course");
            t.Rows[0].Cells[tempq - 1].Paragraphs.First().Append("Result");
            int k = 0;

            for (int i = 1; i <= temp; i++)
            {
                for (int kt = 0; kt < tempq; kt++)
                {
                    t.Rows[i].Cells[kt].Paragraphs.First().Append(dataGridView1.Rows[k].Cells[kt].Value.ToString());
                }
                k++;
            }
            doc.InsertTable(t);
            #endregion
            #region part of one
            doc.Save();
            Process.Start("WINWORD.EXE", fileName);
            #endregion
            Console.Read();
        }
        private void bt_Search_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT id, Lname, Fname FROM std WHERE CONCAT(fname, ID) LIKE '%" + txb_Search.Text + "%' ", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            DataTable tableCourse = new DataTable();
            tableCourse = course.getAllCourses();

            //lấy khóa học theo chiều ngang
            for (int i = 0; i < tableCourse.Rows.Count; i++)
            {
                DataColumn CourseNamecolumn = new DataColumn();
                CourseNamecolumn.ColumnName = tableCourse.Rows[i]["label"].ToString();
                table.Columns.Add(CourseNamecolumn);
            }
            //lấy điểm của từng khóa học dựa theo id của học sinh
            DataTable tableScore = new DataTable();
            tableScore = score.getStudentScore();
            
            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int c = 0; c < tableScore.Rows.Count; c++)
                {
                    if (table.Rows[i]["id"].ToString() == tableScore.Rows[c]["StudentID"].ToString())
                    {
                        for (int k = 3; k < table.Columns.Count; k++)
                        {
                            if (table.Columns[k].ColumnName == tableScore.Rows[c]["label"].ToString())
                            {
                                //string coursename = table.Columns[k].ColumnName;
                                //table.Rows[i][coursename] = tableScore.Rows[c]["student_score"].ToString();
                                table.Rows[i][k] = tableScore.Rows[c]["Score"].ToString();
                                break;
                            }
                        }
                    }
                }
            }

            table.Columns.Add("AVG_Score", typeof(float));
            table.Columns.Add("Result", typeof(string));
            for (int i = 0; i < table.Rows.Count; i++)
            {
                int count = 0;
                float sum = 0;
                for (int j = 3; j < table.Columns.Count - 2; j++)
                {
                    float temp;
                    string coursename = table.Columns[j].ColumnName;
                    if (float.TryParse(table.Rows[i][coursename].ToString(), out temp))
                    {
                        sum += temp;
                        count++;
                    }
                }

                float avg = sum / count;
                Math.Round(avg, 2);
                table.Rows[i]["AVG_Score"] = Math.Round(avg, 2);

                if (avg < 5) table.Rows[i]["Result"] = "Fail";
                if (avg >= 5 && avg <= 6.5) table.Rows[i]["Result"] = "Average";
                if (avg > 6.5 && avg <= 7.9) table.Rows[i]["Result"] = "Goods";
                if (avg >= 8) table.Rows[i]["Result"] = "Excellent";
                if (count == 0) table.Rows[i]["Result"] = "Drop Out Of University!";
                if (avg.ToString() == "NaN") table.Rows[i]["AVG_Score"] = 0;
            }
            dataGridView1.DataSource = table;
        }
        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_PrintOfNhan_Click(object sender, EventArgs e)
        {
            int[] search = new int[50];
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                search[i] = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
            }
            if (dataGridView1.Rows.Count > 0)
            {
                try
                {
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "Word Documents (.docx)|.docx";
                    saveFileDialog1.FileName = ".docx";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        exportDataToWord2(search, dataGridView1.Rows.Count, saveFileDialog1.FileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Not Exported !", "Exporting File");
            }
        }

        public void exportDataToWord2(int[] search, int searchcount, string filename)
        {

            #region one
            string fileName = "Export_Student.docx";
            var doc = DocX.Create(fileName);
            #endregion

            #region two
            string title = "Study Report";

            Formatting titleFormat = new Formatting();
            titleFormat.FontFamily = new Font("Arial");
            titleFormat.Size = 20D;
            titleFormat.Position = 40;
            titleFormat.FontColor = Color.Aquamarine;
            titleFormat.UnderlineColor = Color.Beige;
            titleFormat.Italic = true;

            //Formatting Text Paragraph  
            Formatting textParagraphFormat = new Formatting();
            //font family  
            textParagraphFormat.FontFamily = new Font("Arial");
            //font size  
            textParagraphFormat.Size = 12D;
            //Spaces between characters  
            textParagraphFormat.Spacing = 1;
            //Insert title  
            string title1 = "CONG HOA XA HOI CHU NGHIA VIET NAM " + Environment.NewLine + " DOC LAP - TU DO - HANH PHUC " + Environment.NewLine + "STUDENT FINAL RESULT";
            Paragraph paragraphTitle = doc.InsertParagraph(title1, false, titleFormat);
            //Paragraph paragraphTitle = doc.InsertParagraph(title, false, titleFormat);
            paragraphTitle.Alignment = Alignment.center;
            DateTime date = DateTime.Now;
            paragraphTitle = doc.InsertParagraph(date.ToString("dd/MM/yyyy"), false, textParagraphFormat);
            //Insert text  
            //doc.InsertParagraph(textParagraph, false, textParagraphFormat);
            #endregion

            DataTable tablescore = new DataTable();
            DataTable tablecourse = new DataTable();
            SqlCommand score = new SqlCommand("SELECT * FROM Score", mydb.getConnection);
            SqlDataAdapter adap = new SqlDataAdapter(score);
            tablescore = new DataTable();
            adap.Fill(tablescore);

            #region four
            doc.InsertParagraph();
            //Create Table



            Table[] table = new Table[searchcount];

            //searchcount: đếm số hs sau khi search
            for (int i = 0; i < searchcount; i++)
            {
                // đếm số môn mỗi sinh viên tham gia
                tablecourse = course.getCourseByStudent(search[i]);           //lấy hết môn mà sinh viên đó tham gia
                int temp = tablecourse.Rows.Count;
                table[i] = doc.AddTable(temp + 2, 5);
                table[i] = createTable(table[i], tablecourse);

                //lấy tên học sinh
                Paragraph para = doc.InsertParagraph("", false, titleFormat);
                SqlCommand comStudent = new SqlCommand("SELECT * FROM std WHERE Id = " + search[i], mydb.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(comStudent);
                DataTable tablestudent = new DataTable();
                adapter.Fill(tablestudent);
                int id = Convert.ToInt32(tablestudent.Rows[0][0]);
                string name = tablestudent.Rows[0][1].ToString() + tablestudent.Rows[0][2].ToString();
                para.Append("ID: " + id.ToString());
                para.AppendLine();
                para.Append("Name: " + name);

                int m = 1;
                int total = 0;
                for (int j = 0; j < tablescore.Rows.Count; j++)
                {

                    if (id == Convert.ToInt32(tablescore.Rows[j][0]))
                    {
                        total += Convert.ToInt32(tablescore.Rows[j][2]);
                        table[i].Rows[m].Cells[3].Paragraphs.First().Append((Convert.ToDouble(tablescore.Rows[j][2])).ToString("0.00"));
                        m++;
                    }
                }
                double average = (double)total / tablecourse.Rows.Count;
                Math.Round(average, 2);
                if (table[i].Rows[m].Cells[3].ToString() == "NaN") table[i].Rows[m].Cells[4].Paragraphs.First().Append("Drop Out Of University!");
                table[i].Rows[m].Cells[3].Paragraphs.First().Append(average.ToString("0.00"));
                if (average >= 8) table[i].Rows[m].Cells[4].Paragraphs.First().Append("Exellent");
                if (average > 6.5 && average <= 7.9) table[i].Rows[m].Cells[4].Paragraphs.First().Append("Good");
                if (average >= 5 && average <= 6.5) table[i].Rows[m].Cells[4].Paragraphs.First().Append("Average");
                if (average < 5) table[i].Rows[m].Cells[4].Paragraphs.First().Append("Fail");
                if (table[i].Rows[m].Cells[3].ToString() == "NaN") table[i].Rows[m].Cells[4].Paragraphs.First().Append("");
                doc.InsertTable(table[i]);

            }
            #endregion
            #region part of one
            doc.Save();
            Process.Start("WINWORD.EXE", fileName);
            #endregion
            Console.Read();
        }

        public Table createTable(Table table1, DataTable tablecourse)
        {
            table1.Alignment = Alignment.center;
            table1.Design = TableDesign.TableGrid;

            table1.Rows[0].Cells[0].Paragraphs.First().Append("Course ID");
            table1.Rows[0].Cells[1].Paragraphs.First().Append("Course Name");
            table1.Rows[0].Cells[2].Paragraphs.First().Append("Period");
            table1.Rows[0].Cells[3].Paragraphs.First().Append("Score");
            table1.Rows[0].Cells[4].Paragraphs.First().Append("Result");

            for (int k = 0; k < tablecourse.Rows.Count; k++)
            {
                for (int j = 0; j < 3; j++)
                {
                    table1.Rows[k + 1].Cells[j].Paragraphs.First().Append(tablecourse.Rows[k][j].ToString());
                }
            }
            return table1;
        }

    }
}
