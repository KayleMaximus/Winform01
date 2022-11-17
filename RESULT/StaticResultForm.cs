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
    public partial class StaticResultForm : Form
    {
        public StaticResultForm()
        {
            InitializeComponent();
        }
        CourseCopy course = new CourseCopy();
        SCORE score = new SCORE();
        STUDENT student = new STUDENT();
        private void StaticResultForm_Load(object sender, EventArgs e)
        {
            StaticByCourse_Load();
            StaticByResult_Load();
            BarChart_Load();
        }
        void StaticByCourse_Load()
        {
            DataTable table = new DataTable();
            table = score.getAVGScoreByCourse();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (lb_OOP.Text         == table.Rows[i]["label"].ToString()) lb_OOP.Text       = table.Rows[i]["AverageGrade"].ToString();
                if (lb_DBMS.Text        == table.Rows[i]["label"].ToString()) lb_DBMS.Text      = table.Rows[i]["AverageGrade"].ToString();
                if (lb_IntroIT.Text     == table.Rows[i]["label"].ToString()) lb_IntroIT.Text   = table.Rows[i]["AverageGrade"].ToString();
                if (lb_Progtech.Text    == table.Rows[i]["label"].ToString()) lb_Progtech.Text  = table.Rows[i]["AverageGrade"].ToString();
                if (lb_IntroProg.Text   == table.Rows[i]["label"].ToString()) lb_IntroProg.Text = table.Rows[i]["AverageGrade"].ToString();

            }
        }
        void StaticByResult_Load()
        {
            DataTable table = new DataTable();
            table = score.getAllCourseScoreAndResult();
            double totalStudent = Convert.ToDouble(student.totalStudent());
            double ExcellentStudent = 0;
            double GoodStudent = 0;
            double AverageStudent = 0;
            double FailStudent = 0;
            double OutStudent = 0;

            //trích xuất bảng để lấy dữ liệu result cho từng loại học sinh
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (table.Rows[i]["Result"].ToString() == "Excellent") ExcellentStudent++;
                if (table.Rows[i]["Result"].ToString() == "Good") GoodStudent++;
                if (table.Rows[i]["Result"].ToString() == "Average") AverageStudent++;
                if (table.Rows[i]["Result"].ToString() == "Fail") FailStudent++;
                if (table.Rows[i]["Result"].ToString() == "Drop Out Of University!") OutStudent++;
            }

            //Tính %
            double PExcellentStudent = Math.Round((ExcellentStudent/ totalStudent)*100,2);
            double PGoodStudent = Math.Round((GoodStudent / totalStudent) * 100,2); 
            double PAverageStudent = Math.Round((AverageStudent / totalStudent) * 100,2); 
            double PFailStudent = Math.Round((FailStudent / totalStudent) * 100,2);
            double POutStudent = Math.Round((OutStudent / totalStudent) * 100,2);

            //lb_excellent.Text = (PExcellentStudent.ToString() + " %");
            //lb_Good.Text = (PGoodStudent.ToString() + " %");
            //lb_Average.Text = (PAverageStudent.ToString() + " %");
            //lb_Fail.Text = (PFailStudent.ToString() + " %");
            //lb_DropOut.Text = (POutStudent.ToString() + " %");

            lb_excellent.Text = (ExcellentStudent.ToString() + " (Students)");
            lb_Good.Text = GoodStudent.ToString() + " (Students)";
            lb_Average.Text = AverageStudent.ToString() + " (Students)";
            lb_Fail.Text = FailStudent.ToString() + " (Students)";
            lb_DropOut.Text = OutStudent.ToString() + " (Students)";
            lb_Total.Text = totalStudent.ToString() + " (Students)";

            //Pie Chart
            PieChart.Series["Result"].Points.AddXY("Excellent", PExcellentStudent);
            PieChart.Series["Result"].Points[0].AxisLabel = (PExcellentStudent.ToString("0.00") + "%");
            PieChart.Series["Result"].Points[0].LegendText = "Excellent";

            PieChart.Series["Result"].Points.AddXY("Good", PGoodStudent);
            PieChart.Series["Result"].Points[1].AxisLabel = (PGoodStudent.ToString("0.00") + "%");
            PieChart.Series["Result"].Points[1].LegendText = "Good";

            PieChart.Series["Result"].Points.AddXY("Average", PAverageStudent);
            PieChart.Series["Result"].Points[2].AxisLabel = (PAverageStudent.ToString("0.00") + "%");
            PieChart.Series["Result"].Points[2].LegendText = "Average";

            PieChart.Series["Result"].Points.AddXY("Fail", PFailStudent);
            PieChart.Series["Result"].Points[3].AxisLabel = (PFailStudent.ToString("0.00") + "%");
            PieChart.Series["Result"].Points[3].LegendText = "Fail";

            PieChart.Series["Result"].Points.AddXY("Drop Out", POutStudent);
            PieChart.Series["Result"].Points[4].AxisLabel = (POutStudent.ToString("0.00") + "%");
            PieChart.Series["Result"].Points[4].LegendText = "Drop Out";
        }
        void BarChart_Load()
        {
            DataTable table = new DataTable();
            table = course.getCoursesAndStudentAttend();
            for(int i = 0; i < table.Rows.Count; i++)
            {
                BarChart.Series["Student"].Points.AddXY(table.Rows[i]["label"].ToString(), table.Rows[i]["total"].ToString());
            }
        }

    }
}
