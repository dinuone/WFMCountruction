using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace WFMcontruction
{
    class connection
    {

        public MySqlConnection con;

        public connection()
        {
            string host = "localhost";
            string db = "wfm";
            string port = "3306";
            string user = "root";
            string pass = "";

            string constring = "datasource="+host+"; database="+db+"; port="+port+"; username="+user+"; password="+pass+"; SslMode=none";
            con = new MySqlConnection(constring);
        }
    }

   
}
 