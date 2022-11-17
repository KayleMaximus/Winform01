
namespace WindowsFormsApp1
{
    partial class AVGResultByScoreForm
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
            this.txb_Id = new System.Windows.Forms.TextBox();
            this.txb_Fname = new System.Windows.Forms.TextBox();
            this.txb_Lname = new System.Windows.Forms.TextBox();
            this.txb_Search = new System.Windows.Forms.TextBox();
            this.lb_FirstName = new System.Windows.Forms.Label();
            this.lb_LastName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_StudentID = new System.Windows.Forms.Label();
            this.bt_Search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Print = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_PrintOfNhan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_Id
            // 
            this.txb_Id.Location = new System.Drawing.Point(199, 172);
            this.txb_Id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_Id.Name = "txb_Id";
            this.txb_Id.Size = new System.Drawing.Size(268, 22);
            this.txb_Id.TabIndex = 33;
            // 
            // txb_Fname
            // 
            this.txb_Fname.Location = new System.Drawing.Point(199, 224);
            this.txb_Fname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_Fname.Name = "txb_Fname";
            this.txb_Fname.Size = new System.Drawing.Size(268, 22);
            this.txb_Fname.TabIndex = 32;
            // 
            // txb_Lname
            // 
            this.txb_Lname.Location = new System.Drawing.Point(199, 288);
            this.txb_Lname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_Lname.Name = "txb_Lname";
            this.txb_Lname.Size = new System.Drawing.Size(268, 22);
            this.txb_Lname.TabIndex = 31;
            // 
            // txb_Search
            // 
            this.txb_Search.Location = new System.Drawing.Point(199, 395);
            this.txb_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_Search.Name = "txb_Search";
            this.txb_Search.Size = new System.Drawing.Size(268, 22);
            this.txb_Search.TabIndex = 30;
            // 
            // lb_FirstName
            // 
            this.lb_FirstName.AutoSize = true;
            this.lb_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FirstName.Location = new System.Drawing.Point(25, 224);
            this.lb_FirstName.Name = "lb_FirstName";
            this.lb_FirstName.Size = new System.Drawing.Size(148, 29);
            this.lb_FirstName.TabIndex = 29;
            this.lb_FirstName.Text = "First Name:";
            // 
            // lb_LastName
            // 
            this.lb_LastName.AutoSize = true;
            this.lb_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LastName.Location = new System.Drawing.Point(29, 280);
            this.lb_LastName.Name = "lb_LastName";
            this.lb_LastName.Size = new System.Drawing.Size(144, 29);
            this.lb_LastName.TabIndex = 28;
            this.lb_LastName.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Search By Student ID, First Name:";
            // 
            // lb_StudentID
            // 
            this.lb_StudentID.AutoSize = true;
            this.lb_StudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_StudentID.Location = new System.Drawing.Point(61, 170);
            this.lb_StudentID.Name = "lb_StudentID";
            this.lb_StudentID.Size = new System.Drawing.Size(112, 24);
            this.lb_StudentID.TabIndex = 26;
            this.lb_StudentID.Text = "Student ID:";
            // 
            // bt_Search
            // 
            this.bt_Search.BackColor = System.Drawing.Color.White;
            this.bt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Search.ForeColor = System.Drawing.Color.Black;
            this.bt_Search.Location = new System.Drawing.Point(59, 390);
            this.bt_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(101, 30);
            this.bt_Search.TabIndex = 25;
            this.bt_Search.Text = "Search";
            this.bt_Search.UseVisualStyleBackColor = false;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(558, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 57);
            this.label2.TabIndex = 34;
            this.label2.Text = "Student Result: ";
            // 
            // bt_Print
            // 
            this.bt_Print.BackColor = System.Drawing.Color.Tomato;
            this.bt_Print.Enabled = false;
            this.bt_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Print.Location = new System.Drawing.Point(136, 521);
            this.bt_Print.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Print.Name = "bt_Print";
            this.bt_Print.Size = new System.Drawing.Size(184, 49);
            this.bt_Print.TabIndex = 36;
            this.bt_Print.Text = "Print";
            this.bt_Print.UseVisualStyleBackColor = false;
            this.bt_Print.Visible = false;
            this.bt_Print.Click += new System.EventHandler(this.bt_Print_Click);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.BackColor = System.Drawing.Color.Tomato;
            this.bt_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cancel.Location = new System.Drawing.Point(1087, 705);
            this.bt_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(184, 49);
            this.bt_Cancel.TabIndex = 35;
            this.bt_Cancel.Text = "Cancel";
            this.bt_Cancel.UseVisualStyleBackColor = false;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(504, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1139, 507);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bt_PrintOfNhan
            // 
            this.bt_PrintOfNhan.BackColor = System.Drawing.Color.Tomato;
            this.bt_PrintOfNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_PrintOfNhan.Location = new System.Drawing.Point(687, 705);
            this.bt_PrintOfNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_PrintOfNhan.Name = "bt_PrintOfNhan";
            this.bt_PrintOfNhan.Size = new System.Drawing.Size(184, 49);
            this.bt_PrintOfNhan.TabIndex = 38;
            this.bt_PrintOfNhan.Text = "Print";
            this.bt_PrintOfNhan.UseVisualStyleBackColor = false;
            this.bt_PrintOfNhan.Click += new System.EventHandler(this.bt_PrintOfNhan_Click);
            // 
            // AVGResultByScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1655, 814);
            this.Controls.Add(this.bt_PrintOfNhan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_Print);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_Id);
            this.Controls.Add(this.txb_Fname);
            this.Controls.Add(this.txb_Lname);
            this.Controls.Add(this.txb_Search);
            this.Controls.Add(this.lb_FirstName);
            this.Controls.Add(this.lb_LastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_StudentID);
            this.Controls.Add(this.bt_Search);
            this.Name = "AVGResultByScoreForm";
            this.Text = "AVGResultByScoreForm";
            this.Load += new System.EventHandler(this.AVGResultByScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_Id;
        private System.Windows.Forms.TextBox txb_Fname;
        private System.Windows.Forms.TextBox txb_Lname;
        private System.Windows.Forms.TextBox txb_Search;
        private System.Windows.Forms.Label lb_FirstName;
        private System.Windows.Forms.Label lb_LastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_StudentID;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Print;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_PrintOfNhan;
    }
}