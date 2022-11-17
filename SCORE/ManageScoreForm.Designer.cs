
namespace WindowsFormsApp1
{
    partial class ManageScoreForm
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
            this.bt_AVGscore = new System.Windows.Forms.Button();
            this.std2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bt_ShowScore = new System.Windows.Forms.Button();
            this.bt_ShowStudent = new System.Windows.Forms.Button();
            this.bt_Remove = new System.Windows.Forms.Button();
            this.bt_Add = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TextBoxScore = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelLname = new System.Windows.Forms.Label();
            this.labelFName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.std2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_AVGscore
            // 
            this.bt_AVGscore.BackColor = System.Drawing.Color.Gold;
            this.bt_AVGscore.Location = new System.Drawing.Point(62, 428);
            this.bt_AVGscore.Name = "bt_AVGscore";
            this.bt_AVGscore.Size = new System.Drawing.Size(323, 50);
            this.bt_AVGscore.TabIndex = 101;
            this.bt_AVGscore.Text = "AVG Score by Course";
            this.bt_AVGscore.UseVisualStyleBackColor = false;
            this.bt_AVGscore.Click += new System.EventHandler(this.bt_AVGscore_Click);
            // 
            // std2BindingSource
            // 
            this.std2BindingSource.DataMember = "std2";
            // 
            // bt_ShowScore
            // 
            this.bt_ShowScore.BackColor = System.Drawing.Color.LightSalmon;
            this.bt_ShowScore.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ShowScore.Location = new System.Drawing.Point(974, 69);
            this.bt_ShowScore.Name = "bt_ShowScore";
            this.bt_ShowScore.Size = new System.Drawing.Size(228, 56);
            this.bt_ShowScore.TabIndex = 99;
            this.bt_ShowScore.Text = "Show Score";
            this.bt_ShowScore.UseVisualStyleBackColor = false;
            this.bt_ShowScore.Click += new System.EventHandler(this.bt_ShowScore_Click);
            // 
            // bt_ShowStudent
            // 
            this.bt_ShowStudent.BackColor = System.Drawing.Color.LightSalmon;
            this.bt_ShowStudent.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ShowStudent.Location = new System.Drawing.Point(678, 69);
            this.bt_ShowStudent.Name = "bt_ShowStudent";
            this.bt_ShowStudent.Size = new System.Drawing.Size(228, 56);
            this.bt_ShowStudent.TabIndex = 98;
            this.bt_ShowStudent.Text = "Show Student";
            this.bt_ShowStudent.UseVisualStyleBackColor = false;
            this.bt_ShowStudent.Click += new System.EventHandler(this.bt_ShowStudent_Click);
            // 
            // bt_Remove
            // 
            this.bt_Remove.BackColor = System.Drawing.Color.Red;
            this.bt_Remove.Location = new System.Drawing.Point(242, 361);
            this.bt_Remove.Name = "bt_Remove";
            this.bt_Remove.Size = new System.Drawing.Size(140, 48);
            this.bt_Remove.TabIndex = 97;
            this.bt_Remove.Text = "Remove";
            this.bt_Remove.UseVisualStyleBackColor = false;
            this.bt_Remove.Click += new System.EventHandler(this.bt_Remove_Click);
            // 
            // bt_Add
            // 
            this.bt_Add.BackColor = System.Drawing.Color.ForestGreen;
            this.bt_Add.Location = new System.Drawing.Point(65, 361);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(140, 48);
            this.bt_Add.TabIndex = 96;
            this.bt_Add.Text = "Add";
            this.bt_Add.UseVisualStyleBackColor = false;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(216, 213);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(253, 98);
            this.textBoxDescription.TabIndex = 86;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(216, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 24);
            this.comboBox1.TabIndex = 85;
            // 
            // TextBoxScore
            // 
            this.TextBoxScore.Location = new System.Drawing.Point(216, 175);
            this.TextBoxScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxScore.Name = "TextBoxScore";
            this.TextBoxScore.Size = new System.Drawing.Size(166, 22);
            this.TextBoxScore.TabIndex = 84;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(216, 87);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(166, 22);
            this.textBoxID.TabIndex = 83;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(73, 213);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(100, 20);
            this.labelPhone.TabIndex = 90;
            this.labelPhone.Text = "Description:";
            // 
            // labelLname
            // 
            this.labelLname.AutoSize = true;
            this.labelLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLname.Location = new System.Drawing.Point(115, 175);
            this.labelLname.Name = "labelLname";
            this.labelLname.Size = new System.Drawing.Size(58, 20);
            this.labelLname.TabIndex = 89;
            this.labelLname.Text = "Score:";
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFName.Location = new System.Drawing.Point(53, 126);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(120, 20);
            this.labelFName.TabIndex = 88;
            this.labelFName.Text = "Select Course:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(80, 87);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(93, 20);
            this.labelID.TabIndex = 87;
            this.labelID.Text = "Student ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(531, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(819, 330);
            this.dataGridView1.TabIndex = 102;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // ManageScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1375, 694);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_AVGscore);
            this.Controls.Add(this.bt_ShowScore);
            this.Controls.Add(this.bt_ShowStudent);
            this.Controls.Add(this.bt_Remove);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TextBoxScore);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelLname);
            this.Controls.Add(this.labelFName);
            this.Controls.Add(this.labelID);
            this.Name = "ManageScoreForm";
            this.Text = "ManageScoreForm";
            this.Load += new System.EventHandler(this.ManageScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.std2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_AVGscore;
        private System.Windows.Forms.BindingSource std2BindingSource;
        private System.Windows.Forms.Button bt_ShowScore;
        private System.Windows.Forms.Button bt_ShowStudent;
        private System.Windows.Forms.Button bt_Remove;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox TextBoxScore;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelLname;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}