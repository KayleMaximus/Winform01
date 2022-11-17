using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class CourseCopy
    {
        MY_DB mydb = new MY_DB();

        #region CRUD Functions
        //Insert Function 
        public bool insertCourse(int id, string courseName, int hoursNumber, string Description)
        {
            SqlCommand command = new SqlCommand("INSERT INTO course (id,label,period, description) VALUES (@id, @name, @hrs, @descr)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@hrs", SqlDbType.Int).Value = hoursNumber;
            command.Parameters.Add("@descr", SqlDbType.VarChar).Value = Description;

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Update Function
        public bool updateCourse(int courseID, string courseName, int hoursNumber, string Description)
        {
            SqlCommand command = new SqlCommand("UPDATE course SET label = @name ,period = @hrs, description = @descr WHERE id = " + courseID, mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = courseID;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@hrs", SqlDbType.Int).Value = hoursNumber;
            command.Parameters.Add("@descr", SqlDbType.VarChar).Value = Description;

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Delete Function
        public bool deleteCourse(int courseID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM course WHERE id = @cid", mydb.getConnection);
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
            mydb.openConnection();
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Data Purify Functions
        //Check Course's existence
        public bool checkCourseName(string courseName, int courseID = 0 )
        {
            //Id <> @cID để phân biệt sự tồn tại của khóa học trong database và 1 khóa có khả năng trùng
            SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE label =@cName And id <> @cID", mydb.getConnection);
            command.Parameters.Add("@cName", SqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@cID", SqlDbType.Int).Value = courseID;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                //phát hiện có 1 DÒNG tồn tại trùng tên
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool checkCourseID(int CourseID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE  id = @cID", mydb.getConnection);
            command.Parameters.Add("@cID", SqlDbType.Int).Value = CourseID;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                //phát hiện có 1 DÒNG tồn tại trùng ID
                return false;
            }
            else
            {
                return true;
            }
        }
        //Get All Courses From Database
        public DataTable getAllCourses()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course ", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //Lấy số lượng học sinh gia mỗi môn học
        public DataTable getCoursesAndStudentAttend()
        {
            SqlCommand command = new SqlCommand("SELECT label,count(student_id) as total FROM course inner join score on course.id = score.course_id GROUP BY label", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        //Get Course By ID
        public DataTable getCourseById(int courseID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE id = @cid", mydb.getConnection);
            //command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
            command.Parameters.Add("@cid", SqlDbType.VarChar).Value = courseID;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
        string execCount(string querry)
        {
            SqlCommand command = new SqlCommand(querry, mydb.getConnection);
            mydb.openConnection();
            string count = command.ExecuteScalar().ToString();
            //string count = command.ExecuteNonQuery().ToString();
            mydb.closeConnection();
            return count;
        }
        public string totalCourse()
        {
            return execCount("SELECT COUNT(*) FROM course");
        }
        //Tất cả các môn học mà 1 sinh viên học
        public DataTable getCourseByStudent(int studentID)
        {
            SqlCommand command = new SqlCommand("select course.id, course.label, course.period from score inner join course on score.course_id = course.id where score.student_id = @sid order by score.student_id", mydb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        #endregion
    }
}
