
namespace WindowsFormsApp1
{
    partial class PrintCourseForm
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
            this.components = new System.ComponentModel.Container();
            this.bt_PdfPrint = new System.Windows.Forms.Button();
            this.bt_WordPrint = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_ToPrinter = new System.Windows.Forms.Button();
            this.bt_TextFile = new System.Windows.Forms.Button();
            this.myDBDataSet = new WindowsFormsApp1.myDBDataSet();
            this.myDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDBDataBase = new WindowsFormsApp1.MyDBDataBase();
            this.myDBDataBaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new WindowsFormsApp1.MyDBDataBaseTableAdapters.CourseTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataBaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_PdfPrint
            // 
            this.bt_PdfPrint.BackColor = System.Drawing.Color.Red;
            this.bt_PdfPrint.ForeColor = System.Drawing.Color.White;
            this.bt_PdfPrint.Location = new System.Drawing.Point(945, 598);
            this.bt_PdfPrint.Name = "bt_PdfPrint";
            this.bt_PdfPrint.Size = new System.Drawing.Size(131, 51);
            this.bt_PdfPrint.TabIndex = 17;
            this.bt_PdfPrint.Text = "Save To PDF";
            this.bt_PdfPrint.UseVisualStyleBackColor = false;
            this.bt_PdfPrint.Click += new System.EventHandler(this.bt_PdfPrint_Click);
            // 
            // bt_WordPrint
            // 
            this.bt_WordPrint.BackColor = System.Drawing.Color.Blue;
            this.bt_WordPrint.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_WordPrint.Location = new System.Drawing.Point(714, 598);
            this.bt_WordPrint.Name = "bt_WordPrint";
            this.bt_WordPrint.Size = new System.Drawing.Size(131, 51);
            this.bt_WordPrint.TabIndex = 15;
            this.bt_WordPrint.Text = "Save To Word";
            this.bt_WordPrint.UseVisualStyleBackColor = false;
            this.bt_WordPrint.Click += new System.EventHandler(this.bt_WordPrint_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.labelDataGridViewTextBoxColumn,
            this.periodDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.courseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(101, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1166, 475);
            this.dataGridView1.TabIndex = 16;
            // 
            // bt_ToPrinter
            // 
            this.bt_ToPrinter.Location = new System.Drawing.Point(488, 598);
            this.bt_ToPrinter.Name = "bt_ToPrinter";
            this.bt_ToPrinter.Size = new System.Drawing.Size(131, 51);
            this.bt_ToPrinter.TabIndex = 14;
            this.bt_ToPrinter.Text = "To Printer";
            this.bt_ToPrinter.UseVisualStyleBackColor = true;
            this.bt_ToPrinter.Click += new System.EventHandler(this.bt_ToPrinter_Click);
            // 
            // bt_TextFile
            // 
            this.bt_TextFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_TextFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_TextFile.Location = new System.Drawing.Point(288, 598);
            this.bt_TextFile.Name = "bt_TextFile";
            this.bt_TextFile.Size = new System.Drawing.Size(131, 51);
            this.bt_TextFile.TabIndex = 13;
            this.bt_TextFile.Text = "Save To Text File";
            this.bt_TextFile.UseVisualStyleBackColor = false;
            this.bt_TextFile.Click += new System.EventHandler(this.bt_TextFile_Click);
            // 
            // myDBDataSet
            // 
            this.myDBDataSet.DataSetName = "myDBDataSet";
            this.myDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // myDBDataSetBindingSource
            // 
            this.myDBDataSetBindingSource.DataSource = this.myDBDataSet;
            this.myDBDataSetBindingSource.Position = 0;
            // 
            // myDBDataBase
            // 
            this.myDBDataBase.DataSetName = "MyDBDataBase";
            this.myDBDataBase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // myDBDataBaseBindingSource
            // 
            this.myDBDataBaseBindingSource.DataSource = this.myDBDataBase;
            this.myDBDataBaseBindingSource.Position = 0;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.myDBDataBaseBindingSource;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Course ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // labelDataGridViewTextBoxColumn
            // 
            this.labelDataGridViewTextBoxColumn.DataPropertyName = "label";
            this.labelDataGridViewTextBoxColumn.HeaderText = "Course Name";
            this.labelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.labelDataGridViewTextBoxColumn.Name = "labelDataGridViewTextBoxColumn";
            // 
            // periodDataGridViewTextBoxColumn
            // 
            this.periodDataGridViewTextBoxColumn.DataPropertyName = "period";
            this.periodDataGridViewTextBoxColumn.HeaderText = "Period";
            this.periodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.periodDataGridViewTextBoxColumn.Name = "periodDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // PrintCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 723);
            this.Controls.Add(this.bt_PdfPrint);
            this.Controls.Add(this.bt_WordPrint);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_ToPrinter);
            this.Controls.Add(this.bt_TextFile);
            this.Name = "PrintCourseForm";
            this.Text = "PrintCourseForm";
            this.Load += new System.EventHandler(this.PrintCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataBaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_PdfPrint;
        private System.Windows.Forms.Button bt_WordPrint;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_ToPrinter;
        private System.Windows.Forms.Button bt_TextFile;
        private System.Windows.Forms.BindingSource myDBDataBaseBindingSource;
        private MyDBDataBase myDBDataBase;
        private myDBDataSet myDBDataSet;
        private System.Windows.Forms.BindingSource myDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private MyDBDataBaseTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}