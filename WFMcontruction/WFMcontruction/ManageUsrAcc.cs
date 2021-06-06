using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace WFMcontruction

{
    class ManageUsrAcc:connection
    {
        public int id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string cont { get; set; }
        public string nic { get; set; }
        public string usrname { get; set; }
        public string psw { get; set; }
        public string utype { get; set; }

        public DataTable dt = new DataTable();

        private DataSet ds = new DataSet();

        #region Add new User
        public void add_user()
        {

            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "insert into user(uID,Username,Password,userType,FirstName,LastName,Contact,NIC) value(null,@usrname,@psw,@utype,@fname,@lname,@cont,@nic)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@usrname", MySqlDbType.VarChar).Value = usrname;
                cmd.Parameters.Add("@psw", MySqlDbType.VarChar).Value = psw;
                cmd.Parameters.Add("@utype", MySqlDbType.VarChar).Value = utype;
                cmd.Parameters.Add("@fname", MySqlDbType.VarChar).Value = Firstname;
                cmd.Parameters.Add("@lname", MySqlDbType.VarChar).Value = Lastname;
                cmd.Parameters.Add("@cont", MySqlDbType.VarChar).Value = cont;
                cmd.Parameters.Add("@nic", MySqlDbType.VarChar).Value = nic;

                cmd.ExecuteNonQuery();
                con.Close();

            }
        }
        #endregion

        #region UPDATE User Account
        public void update_usr_acc()//update employee details
        {

            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "update user set Username=@uname,Password=@psw,userType=@utype,FirstName=@fname,LastName=@lname,Contact=@cont,NIC=@nic where uID=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@uname", MySqlDbType.VarChar).Value = usrname;
                cmd.Parameters.Add("@psw", MySqlDbType.VarChar).Value = psw;
                cmd.Parameters.Add("@utype", MySqlDbType.VarChar).Value = utype;
                cmd.Parameters.Add("@fname", MySqlDbType.VarChar).Value = Firstname;
                cmd.Parameters.Add("@lname", MySqlDbType.VarChar).Value = Lastname;
                cmd.Parameters.Add("@cont", MySqlDbType.VarChar).Value = cont;
                cmd.Parameters.Add("@nic", MySqlDbType.VarChar).Value = nic;
                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

                cmd.ExecuteNonQuery();
                con.Close();

            }
        }
        #endregion

        #region DELETE PROJECT
        public void delete_usr_acc()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "delete from user where uID=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }
        #endregion

        #region READ DATABASE TABLE
        public void Read_usr()//read database table
        {
            dt.Clear();
            string query = "Select * from user";
            MySqlDataAdapter mda = new MySqlDataAdapter(query, con); //retrive data from data base 
            mda.Fill(ds); // fill that data into dataset
            dt = ds.Tables[0];


        }
        #endregion

        #region Search User Accounts
        public void search_user(string search_text)
        {
            dt.Clear();
            string query = "SELECT * FROM user WHERE CONCAT(`Username`,`LastName`,`NIC`,`FirstName`) like '%" + search_text + "%'";
            MySqlDataAdapter mda = new MySqlDataAdapter(query, con);
            mda.Fill(ds);
            dt = ds.Tables[0];
        }
        #endregion
    }
}
