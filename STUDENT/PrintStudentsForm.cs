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
using System.Drawing.Printing;
using Word = Microsoft.Office.Interop.Word;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.Office.Interop.Word;
using Image = System.Drawing.Image;
using Document2 = Microsoft.Office.Interop.Word.Document;
using Document = iTextSharp.text.Document;

namespace WindowsFormsApp1
{
    public partial class PrintStudentsForm : Form
    {
        public PrintStudentsForm()
        {
            InitializeComponent();
            string command1 = "SELECT * FROM STD ";
            SqlCommand sqlcomma = new SqlCommand(command1);
            dataGridView1.DataSource = student.getStudents(sqlcomma);
            dataGridView1.RowTemplate.Height = 80;
        }

        private void PrintStudentsForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM STD ");
            fillGrid(command);
            //dataGridView1.DataSource = student.getStudents(command);
            //dataGridView1.RowTemplate.Height = 80;
           
            //ẩn mặc định 2 nút datetime picker cho đến khi chọn
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
           
        }

        STUDENT student = new STUDENT();

        #region control buttons
        private void rbt_Yes_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }
        private void rbt_NO_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }
        private void bt_Check_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            String query;
            if (rbt_Yes.Checked)
            {
                string date1 = dateTimePicker1.Value.ToString("M-dd-yyyy");
                string date2 = dateTimePicker2.Value.ToString("M-dd-yyyy");

                if (rbt_Male.Checked)
                {
                    query = "SELECT * FROM std WHERE gender = 'Male' AND bdate BETWEEN '" + date1 + " 'AND' " + date2 + "'";
                }
                else if (rbt_Female.Checked)
                {
                    query = "SELECT * FROM std WHERE gender = 'Female' AND bdate BETWEEN '" + date1 + " 'AND' " + date2 + "'";
                }
                else
                {
                    query = "SELECT * FROM std WHERE bdate BETWEEN '" + date1 + " 'AND' " + date2 + "'";
                }

                command = new SqlCommand(query);
                fillGrid(command);
            }
            else //neu khong can theo Date
            {
                if (rbt_Male.Checked)
                {
                    query = "SELECT * FROM std WHERE gender = 'Male'";
                }
                else if (rbt_Female.Checked)
                {
                    query = "SELECT * FROM std WHERE gender = 'Female'";
                }
                else
                {
                    query = "SELECT * FROM std"; //choose ALL
                }
            }
            command = new SqlCommand(query);
            fillGrid(command);
        }
        private void bt_ToPrinter_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;

            if (printDlg.ShowDialog() == DialogResult.OK)
                printDoc.Print();
        }
        //Lưu File vào Document
        private void bt_TextFile_Click(object sender, EventArgs e)
        {
            String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\students_list.txt";

            using (var writer = new StreamWriter(path))
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                }

                DateTime bdate;
                //sinh vien nhin vao file huong dan lam tieu de cho cac cot

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (j == 3)
                        {
                            bdate = Convert.ToDateTime(dataGridView1.Rows[i].Cells[j].Value.ToString());
                            writer.Write("\t" + bdate.ToString("yyyy-MM-dd") + "\t" + "|");
                        }
                        else if (j == dataGridView1.Columns.Count - 2)
                        {
                            writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString());
                        }
                        else
                        {
                            writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                        }
                    }
                    writer.WriteLine("");
                    writer.WriteLine("-----------------------------------------------------------------------------");

                }
            }
            MessageBox.Show("File saved", "Save to File", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void bt_WordPrint_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "DOCX files(*.docx)|*.docx";

            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                exportDataToWord(dataGridView1, savefile.FileName);
                MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void bt_PdfPrint_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf"; bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                string id = row.Cells[0].Value.ToString();
                                pdfTable.AddCell(id);
                                string Fname = row.Cells[1].Value.ToString();
                                pdfTable.AddCell(Fname);
                                string Lname = row.Cells[2].Value.ToString();
                                pdfTable.AddCell(Lname);

                                //xóa phần 12:00 am trong mặc định của row.Cells[3].Value.ToString()
                                string Bdate = row.Cells[3].Value.ToString();
                                //DateTime Birthdate = DateTime.ParseExact(row.Cells[3].Value.ToString(), "d", null);
                                DateTime Birthdate = DateTime.Parse((row.Cells[3].Value.ToString()));
                                Bdate = Birthdate.ToString("dd/MM/yyyy");
                                pdfTable.AddCell(Bdate);

                                string gender = row.Cells[4].Value.ToString();
                                pdfTable.AddCell(gender);
                                string phone = row.Cells[5].Value.ToString();
                                pdfTable.AddCell(phone);
                                string address = row.Cells[6].Value.ToString();
                                pdfTable.AddCell(address);
                                byte[] imageByte = (byte[])row.Cells[7].Value;
                                iTextSharp.text.Image Image = iTextSharp.text.Image.GetInstance(imageByte);
                                pdfTable.AddCell(Image);
                            }
                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream); pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }
        #endregion
        void fillGrid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            //Xu ly hinh anh, code co tham khao msdn
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();// doi tuong lam viec voi dang picture cua datagridview
            dataGridView1.RowTemplate.Height = 80;//dong nay tham khao tren MSDN ngay 10/03/2019,co gian de pic dep, dang tim auto size
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        public void exportDataToWord(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                Word.Application word = new Word.Application();//make a new word object
                Document2 doc = word.Documents.Add();//make a new document
                Range rng = doc.Range(0, 0);
                Table wdTable = doc.Tables.Add(rng, DGV.Rows.Count, DGV.Columns.Count);//make anew table based on our data grid view
                wdTable.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleDouble;//make a thick outer border
                wdTable.Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;
                wdTable.AllowAutoFit = true;
                wdTable.AutoFitBehavior(WdAutoFitBehavior.wdAutoFitContent);
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                doc.Application.Visible = true;
                doc.PageSetup.Orientation = WdOrientation.wdOrientLandscape;
                
                
                //dynamic oRange = oDoc.Content.Application.Selection.Range;

                Object oMissing = System.Reflection.Missing.Value;
                doc = word.ActiveDocument;
                for (int r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c < ColumnCount - 1; c++)
                    {
                        if (c == 3)
                        {
                            DateTime dt = (DateTime)DGV.Rows[r].Cells[c].Value;
                            string Bdate = dt.ToString("dd/MM/yyyy");
                            wdTable.Cell(r + 1, c + 1).Range.InsertAfter(Bdate);
                            continue;
                        }
                        wdTable.Cell(r + 1, c + 1).Range.InsertAfter(DGV.Rows[r].Cells[c].Value.ToString());
                    }
                    var oPara1 = doc.Content.Paragraphs.Add(ref oMissing);
                    byte[] imgbyte = (byte[])DGV.Rows[r].Cells[7].Value;
                    MemoryStream ms = new MemoryStream(imgbyte);
                    System.Drawing.Image sparePicture = Image.FromStream(ms);
                    Image finalPic = new Bitmap(sparePicture, new Size(90, 90));
                    Clipboard.SetDataObject(finalPic);
                    var oPara2 = doc.Content.Paragraphs.Add(ref oMissing);

                    wdTable.Cell(r + 1, 8).Range.Paste();
                }
                doc.SaveAs2(filename);
            }
        }


    }
}
