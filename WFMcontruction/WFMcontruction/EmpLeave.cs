using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace WFMcontruction
{
    class EmpLeave:connection
    {
        public string fname { set; get; }
        public string lname { get; set; }
        public string contact { get; set; }
        public string leavedate { get; set; }
        public string leavetype { get; set; }
        public string nic { get; set; }
        public string job { get; set; }    
        public int id { get; set; }

        // create datatable and data set objects 
        public DataTable dt = new DataTable();

        private DataSet ds = new DataSet();

        //create employee method
        #region ADD LEAVE
        public void add_leave()
        {
            
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                
                cmd.CommandText = "insert into empleave(EmpID,FirstName,LastName,Contact,NIC,JobPos,LeaveDate,LeaveType) value(@EmpID,@FName,@Lname,@Cont,@NIC,@job,@LDate,@LType)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@EmpID", MySqlDbType.Int32).Value = id;
                cmd.Parameters.Add("@FName", MySqlDbType.VarChar).Value = fname;
                cmd.Parameters.Add("@Lname", MySqlDbType.VarChar).Value = lname;
                cmd.Parameters.Add("@Cont", MySqlDbType.VarChar).Value = contact;
                cmd.Parameters.Add("@NIC", MySqlDbType.VarChar).Value = nic;
                cmd.Parameters.Add("@job", MySqlDbType.VarChar).Value = job;
                cmd.Parameters.Add("@LDate", MySqlDbType.VarChar).Value = leavedate;
                cmd.Parameters.Add("@LType", MySqlDbType.VarChar).Value = leavetype;

                cmd.ExecuteNonQuery();
                con.Close();

            }
        }
        #endregion

        #region UPDATE LEAVE
        public void update_leave_count()
        {
            int leave = 1;
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "update employee set avbLeave=avbLeave - @Leave where EmpID=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@leave", MySqlDbType.Int32).Value = leave;
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                cmd.ExecuteNonQuery();
                con.Close();

            }
        }
        #endregion

        string date = DateTime.Now.ToLongDateString(); // today date   
        
        #region COUNT TODAY LEAVE
        public string countToday_Leave()//count today employees
        {
            

            con.Open();
            using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM empleave WHERE LeaveDate = '" + date + "'", con))
            {
                int returncount = Convert.ToInt32(cmd.ExecuteScalar());
                string count = Convert.ToString(returncount);
                con.Close();
                return count;
            }
        }
        #endregion

        #region READ Today Leaves
        public void Read_Today_Leaves()
        {
            dt.Clear();
            string query = "Select LID,EmpID,FirstName,LastName,LeaveType,Contact,NIC,jobPos,LeaveDate from empleave where LeaveDate = '"+date+"' ";
            MySqlDataAdapter mda = new MySqlDataAdapter(query, con); //retrive data from data base 
            mda.Fill(ds); // fill that data into dataset
            dt = ds.Tables[0];
        }
        #endregion

        #region READ TODAY LEAVE
        public void Read_Leave()//read database table
        {
            dt.Clear();
            string query = "Select * from empleave";
            MySqlDataAdapter mda = new MySqlDataAdapter(query, con); //retrive data from data base 
            mda.Fill(ds); // fill that data into dataset
            dt = ds.Tables[0];


        }
        #endregion

        //search emp details 
        #region SEARCH Leaves
        public void search_leave(string search_text)
        {
            dt.Clear();
            string query = "SELECT * FROM empleave WHERE CONCAT(`FirstName`,`LastName`,`NIC`) like '%" + search_text + "%'";
            MySqlDataAdapter mda = new MySqlDataAdapter(query, con);
            mda.Fill(ds);
            dt = ds.Tables[0];
        }
        #endregion
    }
}
