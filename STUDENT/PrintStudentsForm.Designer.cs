
namespace WindowsFormsApp1
{
    partial class PrintStudentsForm
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
            this.rbt_All = new System.Windows.Forms.RadioButton();
            this.rbt_Female = new System.Windows.Forms.RadioButton();
            this.rbt_Male = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Check = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.rbt_NO = new System.Windows.Forms.RadioButton();
            this.rbt_Yes = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_ToPrinter = new System.Windows.Forms.Button();
            this.bt_TextFile = new System.Windows.Forms.Button();
            this.myDBDataSet = new WindowsFormsApp1.myDBDataSet();
            this.myDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stdBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stdBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.stdTableAdapter2 = new WindowsFormsApp1.myDBDataSetTableAdapters.stdTableAdapter();
            this.myDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.stdBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bt_WordPrint = new System.Windows.Forms.Button();
            this.bt_PdfPrint = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // rbt_All
            // 
            this.rbt_All.AutoSize = true;
            this.rbt_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_All.Location = new System.Drawing.Point(48, 66);
            this.rbt_All.Name = "rbt_All";
            this.rbt_All.Size = new System.Drawing.Size(49, 24);
            this.rbt_All.TabIndex = 1;
            this.rbt_All.TabStop = true;
            this.rbt_All.Text = "All";
            this.rbt_All.UseVisualStyleBackColor = true;
            // 
            // rbt_Female
            // 
            this.rbt_Female.AutoSize = true;
            this.rbt_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Female.Location = new System.Drawing.Point(234, 66);
            this.rbt_Female.Name = "rbt_Female";
            this.rbt_Female.Size = new System.Drawing.Size(85, 24);
            this.rbt_Female.TabIndex = 3;
            this.rbt_Female.TabStop = true;
            this.rbt_Female.Text = "Female";
            this.rbt_Female.UseVisualStyleBackColor = true;
            // 
            // rbt_Male
            // 
            this.rbt_Male.AutoSize = true;
            this.rbt_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Male.Location = new System.Drawing.Point(135, 66);
            this.rbt_Male.Name = "rbt_Male";
            this.rbt_Male.Size = new System.Drawing.Size(66, 24);
            this.rbt_Male.TabIndex = 2;
            this.rbt_Male.TabStop = true;
            this.rbt_Male.Text = "Male";
            this.rbt_Male.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_Check);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.rbt_All);
            this.panel1.Controls.Add(this.rbt_Female);
            this.panel1.Controls.Add(this.rbt_Male);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 177);
            this.panel1.TabIndex = 3;
            // 
            // bt_Check
            // 
            this.bt_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Check.Location = new System.Drawing.Point(999, 66);
            this.bt_Check.Name = "bt_Check";
            this.bt_Check.Size = new System.Drawing.Size(123, 45);
            this.bt_Check.TabIndex = 8;
            this.bt_Check.Text = "Check";
            this.bt_Check.UseVisualStyleBackColor = true;
            this.bt_Check.Click += new System.EventHandler(this.bt_Check_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.rbt_NO);
            this.panel2.Controls.Add(this.rbt_Yes);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(379, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(585, 121);
            this.panel2.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(392, 72);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(110, 27);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(196, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 27);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "And";
            // 
            // rbt_NO
            // 
            this.rbt_NO.AutoSize = true;
            this.rbt_NO.Location = new System.Drawing.Point(311, 27);
            this.rbt_NO.Name = "rbt_NO";
            this.rbt_NO.Size = new System.Drawing.Size(55, 24);
            this.rbt_NO.TabIndex = 5;
            this.rbt_NO.TabStop = true;
            this.rbt_NO.Text = "NO";
            this.rbt_NO.UseVisualStyleBackColor = true;
            this.rbt_NO.CheckedChanged += new System.EventHandler(this.rbt_NO_CheckedChanged);
            // 
            // rbt_Yes
            // 
            this.rbt_Yes.AutoSize = true;
            this.rbt_Yes.Location = new System.Drawing.Point(196, 25);
            this.rbt_Yes.Name = "rbt_Yes";
            this.rbt_Yes.Size = new System.Drawing.Size(62, 24);
            this.rbt_Yes.TabIndex = 4;
            this.rbt_Yes.TabStop = true;
            this.rbt_Yes.Text = "YES";
            this.rbt_Yes.UseVisualStyleBackColor = true;
            this.rbt_Yes.CheckedChanged += new System.EventHandler(this.rbt_Yes_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Birthday Between: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Use Data Range:";
            // 
            // bt_ToPrinter
            // 
            this.bt_ToPrinter.Location = new System.Drawing.Point(389, 685);
            this.bt_ToPrinter.Name = "bt_ToPrinter";
            this.bt_ToPrinter.Size = new System.Drawing.Size(131, 51);
            this.bt_ToPrinter.TabIndex = 10;
            this.bt_ToPrinter.Text = "To Printer";
            this.bt_ToPrinter.UseVisualStyleBackColor = true;
            this.bt_ToPrinter.Click += new System.EventHandler(this.bt_ToPrinter_Click);
            // 
            // bt_TextFile
            // 
            this.bt_TextFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_TextFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_TextFile.Location = new System.Drawing.Point(189, 685);
            this.bt_TextFile.Name = "bt_TextFile";
            this.bt_TextFile.Size = new System.Drawing.Size(131, 51);
            this.bt_TextFile.TabIndex = 9;
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
            // stdBindingSource
            // 
            this.stdBindingSource.DataMember = "std";
            // 
            // stdBindingSource1
            // 
            this.stdBindingSource1.DataMember = "std";
            // 
            // stdBindingSource2
            // 
            this.stdBindingSource2.DataMember = "std";
            this.stdBindingSource2.DataSource = this.myDBDataSetBindingSource;
            // 
            // stdTableAdapter2
            // 
            this.stdTableAdapter2.ClearBeforeFill = true;
            // 
            // myDBDataSetBindingSource1
            // 
            this.myDBDataSetBindingSource1.DataSource = this.myDBDataSet;
            this.myDBDataSetBindingSource1.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.bdateDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.stdBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1166, 475);
            this.dataGridView1.TabIndex = 11;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Student ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.fnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            // 
            // bdateDataGridViewTextBoxColumn
            // 
            this.bdateDataGridViewTextBoxColumn.DataPropertyName = "bdate";
            this.bdateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            this.bdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bdateDataGridViewTextBoxColumn.Name = "bdateDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "picture";
            this.pictureDataGridViewImageColumn.HeaderText = "Picture";
            this.pictureDataGridViewImageColumn.MinimumWidth = 6;
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            // 
            // stdBindingSource3
            // 
            this.stdBindingSource3.DataMember = "std";
            this.stdBindingSource3.DataSource = this.myDBDataSetBindingSource;
            // 
            // bt_WordPrint
            // 
            this.bt_WordPrint.BackColor = System.Drawing.Color.Blue;
            this.bt_WordPrint.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_WordPrint.Location = new System.Drawing.Point(615, 685);
            this.bt_WordPrint.Name = "bt_WordPrint";
            this.bt_WordPrint.Size = new System.Drawing.Size(131, 51);
            this.bt_WordPrint.TabIndex = 11;
            this.bt_WordPrint.Text = "Save To Word";
            this.bt_WordPrint.UseVisualStyleBackColor = false;
            this.bt_WordPrint.Click += new System.EventHandler(this.bt_WordPrint_Click);
            // 
            // bt_PdfPrint
            // 
            this.bt_PdfPrint.BackColor = System.Drawing.Color.Red;
            this.bt_PdfPrint.ForeColor = System.Drawing.Color.White;
            this.bt_PdfPrint.Location = new System.Drawing.Point(846, 685);
            this.bt_PdfPrint.Name = "bt_PdfPrint";
            this.bt_PdfPrint.Size = new System.Drawing.Size(131, 51);
            this.bt_PdfPrint.TabIndex = 12;
            this.bt_PdfPrint.Text = "Save To PDF";
            this.bt_PdfPrint.UseVisualStyleBackColor = false;
            this.bt_PdfPrint.Click += new System.EventHandler(this.bt_PdfPrint_Click);
            // 
            // PrintStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 763);
            this.Controls.Add(this.bt_PdfPrint);
            this.Controls.Add(this.bt_WordPrint);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_ToPrinter);
            this.Controls.Add(this.bt_TextFile);
            this.Controls.Add(this.panel1);
            this.Name = "PrintStudentsForm";
            this.Text = "PrintStudentsForm";
            this.Load += new System.EventHandler(this.PrintStudentsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbt_All;
        private System.Windows.Forms.RadioButton rbt_Female;
        private System.Windows.Forms.RadioButton rbt_Male;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Check;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbt_NO;
        private System.Windows.Forms.RadioButton rbt_Yes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_ToPrinter;
        private System.Windows.Forms.Button bt_TextFile;
        private System.Windows.Forms.BindingSource myDBDataSetBindingSource;
        private myDBDataSet myDBDataSet;
        private System.Windows.Forms.BindingSource stdBindingSource;
        private System.Windows.Forms.BindingSource stdBindingSource1;
        private System.Windows.Forms.BindingSource stdBindingSource2;
        private myDBDataSetTableAdapters.stdTableAdapter stdTableAdapter2;
        private System.Windows.Forms.BindingSource myDBDataSetBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_WordPrint;
        private System.Windows.Forms.Button bt_PdfPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.BindingSource stdBindingSource3;
    }
}