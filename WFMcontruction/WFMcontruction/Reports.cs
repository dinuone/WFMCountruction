using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace WFMcontruction
{
    class Reports:connection
    {
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        public DataTable dt2 = new DataTable();
        private DataSet ds2 = new DataSet();

        public DataTable dt3 = new DataTable();
        private DataSet ds3 = new DataSet();

        public List<string> datafill = new List<string>();
        public string combobox_project_text;
        public string comboboc_job_text;
        public Int32 profit;
        public Int32 cost;

        string query = "select * from project";
        
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


        
        public string search_month_start;
        public string search_month_end;

        #region DATA GRID LEAVE
        public void data_grid_leave()
        {
            dt.Clear();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from empleave", con);
            da.Fill(ds2);
            dt2 = ds2.Tables[0];

        }
        #endregion

        #region DATA GRID VIEW
        public void data_grid_show()
        {
            dt.Clear();
            MySqlDataAdapter da = new MySqlDataAdapter("select EmpID,FirstName,LastName,jobPos,Gender,WorkExp,project from employee", con);
            da.Fill(ds);
            dt = ds.Tables[0];
        }
        #endregion

        #region DATA FILTER
        public void filter_data()
        {
            dt.Clear();
            string query = "select EmpID,FirstName,LastName,jobPos,Gender,WorkExp,project from employee where project='" + combobox_project_text + "' ";
            MySqlDataAdapter da = new MySqlDataAdapter(query,con);
            da.Fill(ds);
            dt = ds.Tables[0];
        }

        public void filter_job()
        {
            dt.Clear();
            string query = "select EmpID,FirstName,LastName,jobPos,Gender,WorkExp,project from employee where jobPos='" + comboboc_job_text+ "' and project ='"+combobox_project_text+"'";
            MySqlDataAdapter da = new MySqlDataAdapter(query, con);
            da.Fill(ds);
            dt = ds.Tables[0];
        }

        public void filter_by_month()
        {
            dt2.Clear();
            string query = "select * from empleave where LeaveDate between '"+search_month_start+"' and '"+search_month_end+"'";
            MySqlDataAdapter da = new MySqlDataAdapter(query, con);
            da.Fill(ds2);
            dt2 = ds2.Tables[0];
        }

        public void filter_by_emr_Reg()
        {
            dt3.Clear();
            string query = "select * from employee where DateNow between '" + search_month_start + "' and '" + search_month_end + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(query, con);
            da.Fill(ds3);
            dt3 = ds3.Tables[0];
        }
        #endregion

        #region Total Profit
        public void total_profit()
        {
            con.Open();
            MySqlDataReader dr;

            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "Select sum(profit) as totalprofit from project";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    profit = dr.GetInt32("totalprofit");
                }
                con.Close();
            }
          
        }
        #endregion

        #region Total cost for all projects 
        public void total_Cost()
        {
            con.Open();
            MySqlDataReader dr;

            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "Select sum(cost) as totalcost from project";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    cost = dr.GetInt32("totalcost");
                }
                con.Close();
            }

        }
        #endregion
    }
}
