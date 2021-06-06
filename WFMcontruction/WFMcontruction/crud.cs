using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace WFMcontruction
{
    class crud:connection
    {
        
            public string fname { set; get; }
            public string lname { get; set; }
            public string contact { get; set; }
            public string addres { get; set; }
            public string dob { get; set; }
            public string nic { get; set; }
            public string job { get; set; }
            public string gender { get; set; }
            public int workexp { get; set; }
            public int id { get; set; }
            public string assignproject { get; set; }
            
            
        // create datatable and data set objects 
            public DataTable dt = new DataTable();

            private DataSet ds = new DataSet();

          

        //create employee method
        #region ADD EMPLOYEE
        public void add_employee()
            {
            
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "insert into employee(EmpID,FirstName,LastName,Contact,Address,DOB,NIC,jobPos,Gender,WorkExp,project) value(null,@FName,@Lname,@Cont,@adres,@DOB,@NIC,@job,@gender,@work,@prj)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;

                    cmd.Parameters.Add("@FName", MySqlDbType.VarChar).Value = fname;
                    cmd.Parameters.Add("@LName", MySqlDbType.VarChar).Value = lname;
                    cmd.Parameters.Add("@Cont", MySqlDbType.VarChar).Value = contact;
                    cmd.Parameters.Add("@adres", MySqlDbType.VarChar).Value = addres;
                    cmd.Parameters.Add("@DOB", MySqlDbType.VarChar).Value = dob;
                    cmd.Parameters.Add("@NIC", MySqlDbType.VarChar).Value = nic;
                    cmd.Parameters.Add("@job", MySqlDbType.VarChar).Value = job;
                    cmd.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender;
                    cmd.Parameters.Add("@Work", MySqlDbType.VarChar).Value = workexp;
                    cmd.Parameters.Add("@prj", MySqlDbType.VarChar).Value = assignproject;

                    cmd.ExecuteNonQuery();
                    con.Close();

                }
            }
        #endregion

        //count total emp method
        #region COUNT TOTAL EMPLOYEES
        public string countEmp() //total count of employees 
          {
            con.Open();
            using(var cmd = new MySqlCommand("SELECT COUNT(*) FROM employee", con))
            {
                int returnval = Convert.ToInt32(cmd.ExecuteScalar());
                string count = Convert.ToString(returnval);
                con.Close();
                return count;
                
            }
           
          }
        #endregion

        //count today emp method
        #region COUNT TODAY ADD EMPLOYEE
        public string countTodayEmp()//count today employees
        {
            string date = DateTime.Now.ToLongDateString(); // today date 

            con.Open();
            using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM employee WHERE DateNow = '"+date+"'", con))
            {
                int returncount = Convert.ToInt32(cmd.ExecuteScalar());
                string count = Convert.ToString(returncount);
                con.Close();
                return count;
            }
        }
        #endregion

        //read employee table
        #region READ DATABASE TABLE
        public void Read_EMP()//read database table
        {
            dt.Clear();
            string query = "Select * from employee";
            MySqlDataAdapter mda = new MySqlDataAdapter(query,con); //retrive data from data base 
            mda.Fill(ds); // fill that data into dataset
            dt = ds.Tables[0];


        }
        #endregion

        //search emp details 
        #region SEARCH EMP
        public void search_emp(string search_text)
        {
            dt.Clear();
            string query = "SELECT * FROM employee WHERE CONCAT(`FirstName`,`LastName`,`NIC`) like '%" + search_text + "%'";
            MySqlDataAdapter mda = new MySqlDataAdapter(query, con);
            mda.Fill(ds);
            dt = ds.Tables[0];
        }
        #endregion

        //update emp details 
        #region UPDATE EMPLOYEE
        public void update_employee()//update employee details
        {

            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "update employee set FirstName=@FName,LastName=@Lname,Contact=@Cont,Address=@adres,NIC=@NIC,jobPos=@job,WorkExp=@work, project=@prj where EmpID=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@FName", MySqlDbType.VarChar).Value = fname;
                cmd.Parameters.Add("@LName", MySqlDbType.VarChar).Value = lname;
                cmd.Parameters.Add("@Cont", MySqlDbType.VarChar).Value = contact;
                cmd.Parameters.Add("@adres", MySqlDbType.VarChar).Value = addres;
                cmd.Parameters.Add("@NIC", MySqlDbType.VarChar).Value = nic;
                cmd.Parameters.Add("@job", MySqlDbType.VarChar).Value = job;
                cmd.Parameters.Add("@Work", MySqlDbType.VarChar).Value = workexp;
                cmd.Parameters.Add("@prj", MySqlDbType.VarChar).Value = assignproject;

                cmd.ExecuteNonQuery();
                con.Close();

            }
        }
        #endregion

        //delete emp detials 
        #region DELETE EMPLOYEE
        public void delete_emp()
        {
            con.Open();
            using(MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "delete from employee where EmpID=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            
        }
        #endregion
    }

}
