
namespace WindowsFormsApp1
{
    partial class AddScoreForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_StudentID = new System.Windows.Forms.TextBox();
            this.txb_Score = new System.Windows.Forms.TextBox();
            this.txb_Description = new System.Windows.Forms.TextBox();
            this.bt_AddScore = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbb_Course = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Course:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Score:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description:";
            // 
            // txb_StudentID
            // 
            this.txb_StudentID.Location = new System.Drawing.Point(160, 63);
            this.txb_StudentID.Name = "txb_StudentID";
            this.txb_StudentID.ReadOnly = true;
            this.txb_StudentID.Size = new System.Drawing.Size(100, 22);
            this.txb_StudentID.TabIndex = 1;
            // 
            // txb_Score
            // 
            this.txb_Score.Location = new System.Drawing.Point(160, 168);
            this.txb_Score.Name = "txb_Score";
            this.txb_Score.Size = new System.Drawing.Size(100, 22);
            this.txb_Score.TabIndex = 3;
            // 
            // txb_Description
            // 
            this.txb_Description.Location = new System.Drawing.Point(159, 211);
            this.txb_Description.Multiline = true;
            this.txb_Description.Name = "txb_Description";
            this.txb_Description.Size = new System.Drawing.Size(203, 131);
            this.txb_Description.TabIndex = 4;
            // 
            // bt_AddScore
            // 
            this.bt_AddScore.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt_AddScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AddScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_AddScore.Location = new System.Drawing.Point(159, 371);
            this.bt_AddScore.Name = "bt_AddScore";
            this.bt_AddScore.Size = new System.Drawing.Size(157, 46);
            this.bt_AddScore.TabIndex = 5;
            this.bt_AddScore.Text = "Add Score";
            this.bt_AddScore.UseVisualStyleBackColor = false;
            this.bt_AddScore.Click += new System.EventHandler(this.bt_AddScore_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(417, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(488, 372);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // cbb_Course
            // 
            this.cbb_Course.FormattingEnabled = true;
            this.cbb_Course.Location = new System.Drawing.Point(160, 121);
            this.cbb_Course.Name = "cbb_Course";
            this.cbb_Course.Size = new System.Drawing.Size(202, 24);
            this.cbb_Course.TabIndex = 10;
            this.cbb_Course.Tag = "2";
            // 
            // AddScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(917, 453);
            this.Controls.Add(this.cbb_Course);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_AddScore);
            this.Controls.Add(this.txb_Description);
            this.Controls.Add(this.txb_Score);
            this.Controls.Add(this.txb_StudentID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddScoreForm";
            this.Text = "AddScoreForm";
            this.Load += new System.EventHandler(this.AddScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_StudentID;
        private System.Windows.Forms.TextBox txb_Score;
        private System.Windows.Forms.TextBox txb_Description;
        private System.Windows.Forms.Button bt_AddScore;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbb_Course;
    }
}