using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace WFMcontruction
{
    class AddProject : connection
    {
        public string projname { get; set; }
        public string clientname { get; set; }
        public string startdate { get; set; }
        public string duration { get; set; }
        public int cost { get; set; }
        public string status { get; set; }
        public int id { get; set; }

        public int profit { get; set; }

        public DataTable dt = new DataTable();

        private DataSet ds = new DataSet();

        #region READ DATABASE TABLE
        public void Read_Proj()//read database table
        {
            dt.Clear();
            string query = "Select * from project";
            MySqlDataAdapter mda = new MySqlDataAdapter(query, con); //retrive data from data base 
            mda.Fill(ds); // fill that data into dataset
            dt = ds.Tables[0];


        }
        #endregion

        #region READ ONGOINF PROJECTS
        public void Read_Ongoing_Proj()
        {
            dt.Clear();
            string query = "Select * from project where Status = 'Ongoing'";
            MySqlDataAdapter mda = new MySqlDataAdapter(query, con);
            mda.Fill(ds);
            dt = ds.Tables[0];

        }
        #endregion

        string date = DateTime.Now.ToLongDateString();
        //add project
        #region ADD PROJECT
        public void add_project()
        {

            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "insert into project(prjID,ProjectName,ClientName,StartDate,Duration,Cost) value(null,@Pname,@Cname,@StartDate,@Duration,@cost)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@Pname", MySqlDbType.VarChar).Value = projname;
                cmd.Parameters.Add("@Cname", MySqlDbType.VarChar).Value = clientname;
                cmd.Parameters.Add("@StartDate", MySqlDbType.VarChar).Value = startdate;
                cmd.Parameters.Add("@Duration", MySqlDbType.VarChar).Value = duration;
                cmd.Parameters.Add("@cost", MySqlDbType.VarChar).Value = cost;

                cmd.ExecuteNonQuery();
                con.Close();

            }
        }
        #endregion

        //update project details 
        #region UPDATE PROJECT
        public void update_Project()//update employee details
        {

            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "update project set ProjectName=@Pname,ClientName=@Cname,StartDate=@startDate,Duration=@duration,Cost=@cost,Status=@status where prjID=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@Pname", MySqlDbType.VarChar).Value = projname;
                cmd.Parameters.Add("@Cname", MySqlDbType.VarChar).Value = clientname;
                cmd.Parameters.Add("@startDate", MySqlDbType.VarChar).Value = startdate;
                cmd.Parameters.Add("@duration", MySqlDbType.VarChar).Value = duration;
                cmd.Parameters.Add("@cost", MySqlDbType.VarChar).Value = cost;
                cmd.Parameters.Add("@status", MySqlDbType.VarChar).Value = status;


                cmd.ExecuteNonQuery();
                con.Close();

            }
        }
        #endregion

        //delete PROJECT detials
        #region DELETE PROJECT
        public void delete_prj()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "delete from project where prjID=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }
        #endregion

        #region COUNT TOTAL EMPLOYEES
        public string countEmp() //total count of employees 
        {
            con.Open();
            using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM employee", con))
            {
                int returnval = Convert.ToInt32(cmd.ExecuteScalar());
                string count = Convert.ToString(returnval);
                con.Close();
                return count;

            }

        }
        #endregion

        #region COUNT Ongoing Projects
        public string countprj_Ongoing() //total count of employees 
        {
            con.Open();
            using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM project where Status='Ongoing'", con))
            {
                int returnval = Convert.ToInt32(cmd.ExecuteScalar());
                string count = Convert.ToString(returnval);
                con.Close();
                return count;

            }

        }
        #endregion

        #region ADD PROFIT
        public void add_profit()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "update project set profit=@Profit  where prjID=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@Profit", MySqlDbType.VarChar).Value = profit;


                cmd.ExecuteNonQuery();
                con.Close();

            }


        }
        #endregion

        #region COUNT Complete Projects
        public string countprj_comlpete() //total count of employees 
        {
            con.Open();
            using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM project where Status='Complete'", con))
            {
                int returnval = Convert.ToInt32(cmd.ExecuteScalar());
                string count = Convert.ToString(returnval);
                con.Close();
                return count;

            }

        }
        #endregion

        #region COUNT Newly Add Projects
        public string countprj_NewlyAdd() //total count of employees 
        {
            con.Open();
            using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM project where Status='Newly Added'", con))
            {
                int returnval = Convert.ToInt32(cmd.ExecuteScalar());
                string count = Convert.ToString(returnval);
                con.Close();
                return count;

            }

        }
        #endregion
        public List<string> datafill = new List<string>();

        public string combobox_text;


        string query = "select * from project where Status='Ongoing'";

        #region SHOW PROJECTS NAMES
        public void show_project()
        {
            datafill.Clear();
            MySqlDataReader rd;

            using (var cmd = new MySqlCommand())
            {
                con.Open();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                datafill.Add("--Select Project--");

                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    datafill.Add(rd[1].ToString());

                }
                con.Close();
            }
        }
        #endregion

        #region COUNT Total Projects
        public string count_prj() //total count of employees 
        {
            con.Open();
            using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM project", con))
            {
                int returnval = Convert.ToInt32(cmd.ExecuteScalar());
                string count = Convert.ToString(returnval);
                con.Close();
                return count;

            }

        }
        #endregion

        #region Search project
        public void search_prj(string search_text)
        {
            dt.Clear();
            string query = "SELECT * FROM project WHERE CONCAT(`ProjectName`,`ClientName`) like '%" + search_text + "%'";
            MySqlDataAdapter mda = new MySqlDataAdapter(query, con);
            mda.Fill(ds);
            dt = ds.Tables[0];
        }
        #endregion
    }
}
