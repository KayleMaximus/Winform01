using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;
using Document = iTextSharp.text.Document;
using Font = Xceed.Document.NET.Font;
using Paragraph = Xceed.Document.NET.Paragraph;

namespace WindowsFormsApp1
{
    public partial class PrintScoreForm : Form
    {
        public PrintScoreForm()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        private void PrintScoreForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = score.getStudentScore();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
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
        private void bt_TextFile_Click(object sender, EventArgs e)
        {
            String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\course_list.txt";

            using (var writer = new StreamWriter(path))
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (j == dataGridView1.Columns.Count - 2)
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
                                string Course_ID = row.Cells[3].Value.ToString();
                                pdfTable.AddCell(Course_ID);
                                string label = row.Cells[4].Value.ToString();
                                pdfTable.AddCell(label);
                                string student_score = row.Cells[5].Value.ToString();
                                pdfTable.AddCell(student_score);
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

        private void bt_WordPrint_Click(object sender, EventArgs e)
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
            titleFormat.FontColor = Color.DarkCyan;
            titleFormat.UnderlineColor = Color.AliceBlue;
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
            //Paragraph paragraphTitle = doc.InsertParagraph(title, false, titleFormat);
            string title1 = "DAI HOC SU PHAM KY THUAT TPHCM " + Environment.NewLine + " KHOA DAO TAO CHAT LUONG CAO " + Environment.NewLine + "SCORE LIST";
            Paragraph paragraphTitle = doc.InsertParagraph(title1, false, titleFormat);
            paragraphTitle.Alignment = Alignment.center;
            //Insert text  
            //doc.InsertParagraph(textParagraph, false, textParagraphFormat);
            #endregion            
            dataGridView1.AllowUserToAddRows = false;
            #region four
            doc.InsertParagraph();
            //Create Table
            //var listPlayer = CreateInitData();
            int tempq = dataGridView1.ColumnCount;
            int temp = dataGridView1.RowCount;
            Table t = doc.AddTable(temp + 1, tempq);
            t.Alignment = Alignment.center;
            t.Design = TableDesign.ColorfulList;
            // Fill cells by adding text.  
            // First row
            t.Rows[0].Cells[0].Paragraphs.First().Append("ID");
            t.Rows[0].Cells[1].Paragraphs.First().Append("First Name");
            t.Rows[0].Cells[2].Paragraphs.First().Append("Last Name");
            t.Rows[0].Cells[3].Paragraphs.First().Append("Course ID");
            t.Rows[0].Cells[4].Paragraphs.First().Append("Course Name");
            t.Rows[0].Cells[5].Paragraphs.First().Append("Score");

            temp = dataGridView1.RowCount;


            for (int i = 0; i < temp; i++)
            {
                for (int kt = 0; kt < tempq; kt++)
                {
                    t.Rows[i + 1].Cells[kt].Paragraphs.First().Append(dataGridView1.Rows[i].Cells[kt].Value.ToString());
                }
            }
            doc.InsertTable(t);
            #endregion
            #region part of one
            doc.Save();
            Process.Start("WINWORD.EXE", fileName);
            #endregion
            Console.Read();
        }
    }
}
