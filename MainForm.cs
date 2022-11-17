using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void aDDNEWSTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addStdF = new AddStudentForm();
            addStdF.Show(this);
        }

        private void sTUDENTLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentListForm Stdlist = new studentListForm();
            Stdlist.Show(this);
        }

        private void sTATICSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticsForm StdF = new StaticsForm();
            StdF.Show(this);
        }

        private void mANAGEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudentsForm MstdF = new ManageStudentsForm();
            MstdF.Show(this);
        }

        private void pRINTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintStudentsForm PstdF = new PrintStudentsForm();
            PstdF.Show(this);
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseForm ACF = new AddCourseForm();
            ACF.Show(this);
        }

        private void editCouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCourseForm RCF = new RemoveCourseForm();
            RCF.Show(this);
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCourseForm ECF = new EditCourseForm();
            ECF.Show(this);
        }

        private void manageCouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCourseForm MCF = new ManageCourseForm();
            MCF.Show(this);
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintCourseForm PCF = new PrintCourseForm();
            PCF.Show(this);
        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScoreForm ASF = new AddScoreForm();
            ASF.Show(this);
        }

        private void removeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveScore RMC = new RemoveScore();
            RMC.Show(this);
        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScoreForm MSF = new ManageScoreForm();
            MSF.Show(this);
        }

        private void avgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            avgScroreOfCoursesForm ASOC = new avgScroreOfCoursesForm();
            ASOC.Show(this);
        }

        private void aVGToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AVGResultByScoreForm tf = new AVGResultByScoreForm();
            tf.Show(this);
        }

        private void staticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticResultForm SRF = new StaticResultForm();
            SRF.Show(this);
        }

        private void printToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PrintScoreForm PSF = new PrintScoreForm();
            PSF.Show(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void eDITREMOVEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm UDST = new UpdateDeleteStudentForm();
            UDST.Show(this);
        }
    }
}
