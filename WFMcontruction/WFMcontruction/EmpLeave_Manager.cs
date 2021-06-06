using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFMcontruction
{
    public partial class EmpLeave_Manager : UserControl
    {
        public EmpLeave_Manager()
        {
            InitializeComponent();
        }
        crud crd = new crud();
        EmpLeave empLv = new EmpLeave();
        private void EmpLeave_Manager_Load(object sender, EventArgs e)
        {
            Read();
            lbl_today_leave.Text = empLv.countToday_Leave();
            
        }
        public void Read() //read employee table 
        {
            empLv.dt.Clear();
            dgv_leave.DataSource = null;
            crd.Read_EMP();

            dgv_leave.DataSource = crd.dt;

        }
        public void Read_todayLeaves() //read employee table 
        {
            empLv.dt.Clear();
            dgv_leave.DataSource = null;
            empLv.Read_Today_Leaves();

            dgv_leave.DataSource = empLv.dt;

        }

        public void ReadLeave()
        {
            empLv.dt.Clear();
            dgv_leave.DataSource = null;
            empLv.Read_Leave();
            dgv_leave.DataSource = empLv.dt;
        }

        private void rd_today_CheckedChanged(object sender, EventArgs e)
        {
            Read_todayLeaves();
        }

        private void rd_leave_CheckedChanged(object sender, EventArgs e)
        {
            ReadLeave();
        }

        private void rd_emplist_CheckedChanged(object sender, EventArgs e)
        {
            Read();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string valuesearch = txt_search.Text.ToString();
            crd.search_emp(valuesearch); // send text value to searchemp method
            dgv_leave.DataSource = crd.dt;
        }
    }
}
