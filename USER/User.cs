using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace WindowsFormsApp1
{
    class User
    {
        MY_DB mydb = new MY_DB();

        #region Student
        public bool insertUser(int id, string username, string password, String email)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Login (id, username, password, gmail)" +
                " VALUES (@id ,@un, @pw, @gm)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pw", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@gm", SqlDbType.VarChar).Value = email;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public string getPassword(string username)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Login WHERE gmail LIKE '%" + username + "%'", mydb.getConnection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            
            string userpass = table.Rows[0]["password"].ToString();

            return userpass;
        }
        public string getUserName(string gmail)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Login WHERE gmail LIKE '%" + gmail + "%'", mydb.getConnection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            string username = table.Rows[0]["username"].ToString();

            return username;
        }
        public bool updatePassword(string gmail, string password)
        {
            SqlCommand command = new SqlCommand("UPDATE Login SET password = @pass  WHERE gmail LIKE '%" + gmail + "%'", mydb.getConnection);
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;

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
        public bool CheckID(int UserID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM login where id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = UserID;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }
        }
        public bool CheckUserName(string username)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM login where username = @un", mydb.getConnection);
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }
        }
        #endregion

        #region Human Resource
        public bool insertHumanResource(int id, string fname, string lname, string username, string password,  MemoryStream picture, string email)
        {
            SqlCommand command = new SqlCommand("INSERT INTO HumanResource (id, f_name, l_name, uname, pwd, fig, gmail)" +
                " VALUES (@id ,@fn, @ln, @un, @pw, @pic, @gm)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pw", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@gm", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool updateHumanResource(int id, string fname, string lname, string username, string password, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE HumanResource SET f_name = @fn, l_name = @ln, uname = @un , pwd = @pass, fig = @pic WHERE id = @uid" , mydb.getConnection);
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@uid", SqlDbType.Int).Value = id;

            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool CheckHRID(int UserID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM HumanResource where id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = UserID;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }
        }
        public bool CheckHRUserName(string username)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM HumanResource where uname = @un", mydb.getConnection);
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }
        }
        public bool CheckHRUserNameForEdit(string username)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM HumanResource where uname = @un", mydb.getConnection);
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 1)
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }
        }
        public DataTable GetHR(int Global_ID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM HumanResource Where id = @HRID", mydb.getConnection);
            command.Parameters.Add("@HRID", SqlDbType.Int).Value = Global_ID;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        #endregion
    }
}
