
namespace WindowsFormsApp1
{
    partial class PrintScoreForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_PdfPrint = new System.Windows.Forms.Button();
            this.bt_WordPrint = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_ToPrinter = new System.Windows.Forms.Button();
            this.bt_TextFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_PdfPrint
            // 
            this.bt_PdfPrint.BackColor = System.Drawing.Color.Red;
            this.bt_PdfPrint.ForeColor = System.Drawing.Color.White;
            this.bt_PdfPrint.Location = new System.Drawing.Point(980, 611);
            this.bt_PdfPrint.Name = "bt_PdfPrint";
            this.bt_PdfPrint.Size = new System.Drawing.Size(131, 51);
            this.bt_PdfPrint.TabIndex = 22;
            this.bt_PdfPrint.Text = "Save To PDF";
            this.bt_PdfPrint.UseVisualStyleBackColor = false;
            this.bt_PdfPrint.Click += new System.EventHandler(this.bt_PdfPrint_Click);
            // 
            // bt_WordPrint
            // 
            this.bt_WordPrint.BackColor = System.Drawing.Color.Blue;
            this.bt_WordPrint.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_WordPrint.Location = new System.Drawing.Point(749, 611);
            this.bt_WordPrint.Name = "bt_WordPrint";
            this.bt_WordPrint.Size = new System.Drawing.Size(131, 51);
            this.bt_WordPrint.TabIndex = 20;
            this.bt_WordPrint.Text = "Save To Word";
            this.bt_WordPrint.UseVisualStyleBackColor = false;
            this.bt_WordPrint.Click += new System.EventHandler(this.bt_WordPrint_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(136, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1166, 475);
            this.dataGridView1.TabIndex = 21;
            // 
            // bt_ToPrinter
            // 
            this.bt_ToPrinter.Location = new System.Drawing.Point(523, 611);
            this.bt_ToPrinter.Name = "bt_ToPrinter";
            this.bt_ToPrinter.Size = new System.Drawing.Size(131, 51);
            this.bt_ToPrinter.TabIndex = 19;
            this.bt_ToPrinter.Text = "To Printer";
            this.bt_ToPrinter.UseVisualStyleBackColor = true;
            this.bt_ToPrinter.Click += new System.EventHandler(this.bt_ToPrinter_Click);
            // 
            // bt_TextFile
            // 
            this.bt_TextFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_TextFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_TextFile.Location = new System.Drawing.Point(323, 611);
            this.bt_TextFile.Name = "bt_TextFile";
            this.bt_TextFile.Size = new System.Drawing.Size(131, 51);
            this.bt_TextFile.TabIndex = 18;
            this.bt_TextFile.Text = "Save To Text File";
            this.bt_TextFile.UseVisualStyleBackColor = false;
            this.bt_TextFile.Click += new System.EventHandler(this.bt_TextFile_Click);
            // 
            // PrintScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 737);
            this.Controls.Add(this.bt_PdfPrint);
            this.Controls.Add(this.bt_WordPrint);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_ToPrinter);
            this.Controls.Add(this.bt_TextFile);
            this.Name = "PrintScoreForm";
            this.Text = "PrintScoreForm";
            this.Load += new System.EventHandler(this.PrintScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_PdfPrint;
        private System.Windows.Forms.Button bt_WordPrint;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_ToPrinter;
        private System.Windows.Forms.Button bt_TextFile;
    }
}