using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace WFMcontruction
{
    class userlogin:connection
    {
        public string uname { get; set; }
        public string psw { get; set; }
        public Int32 usr_type { get; set; }

        public string usrname_text { get; set; }

        public List<string> datafill = new List<string>();
        public bool user_verify()
        {
            con.Open();
            MySqlDataReader dr;

            bool verify = false;

            using(var cmd = new MySqlCommand())
            {
                cmd.CommandText = "select * from user where Username = @usrname and Password = @pswrd ";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@usrname", MySqlDbType.VarChar).Value = uname;
                cmd.Parameters.Add("pswrd", MySqlDbType.VarChar).Value = psw;
                dr = cmd.ExecuteReader();

                while(dr.Read())
                {
                    verify = true;
                    usr_type = dr.GetInt32("userType");
                    usrname_text = dr.GetString("Username");
                }
                con.Close();
            }
            return verify;
        }
    }
}
