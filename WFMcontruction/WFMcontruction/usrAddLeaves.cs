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
    public partial class usrAddLeaves : UserControl
    {
        crud crd = new crud();
        EmpLeave empLv = new EmpLeave();
        public usrAddLeaves()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dgv_emp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
       
        }

        public void Read() //read employee table 
        {
            dgv_emp.DataSource = null;
            crd.Read_EMP();

            dgv_emp.DataSource = crd.dt;

        }

        private void usrAddLeaves_Load(object sender, EventArgs e)
        {
            Read();
            lbl_today_leave.Text = empLv.countToday_Leave();
            lbl_date.Text = DateTime.Now.ToLongDateString();
           
        
           
            
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string valuesearch = txt_search.Text.ToString();
            crd.search_emp(valuesearch); // send text value to searchemp method
            dgv_emp.DataSource = crd.dt;
            empLv.search_leave(valuesearch);
            dgv_emp.DataSource = empLv.dt;
       
        }

        private void btn_add_leave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_FName.Text == "" || txt_Lname.Text == "" || txt_NIC.Text == "" || txt_contact.Text == "" || leave_date.Text == ""  )
                {
                    MessageBox.Show("Please Fill All Fileds!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if(cmb_leavetype.Text == "")
                {
                    MessageBox.Show("Please select leave type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult dialogresult = MessageBox.Show("Do you confirm this leave?", "Message!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogresult == DialogResult.Yes)
                    {
                        CREATE();
                        UPDATE_LEAVE();
                        Read();
                        MessageBox.Show("Leave Added Sucessfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        lbl_today_leave.Text = empLv.countToday_Leave();
                    }
                    else if (dialogresult == DialogResult.No)
                    {
                        Read();
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CREATE() //get values form Ui and pass it to get set methods in empleave class
        {
            empLv.id = Convert.ToInt32(txt_EmpID.Text);
            empLv.fname = txt_FName.Text;
            empLv.lname = txt_Lname.Text;
            empLv.contact = txt_contact.Text;
            empLv.leavedate = leave_date.Text;
            empLv.nic = txt_NIC.Text;
            empLv.job = txt_job.Text;
            empLv.leavetype = cmb_leavetype.Text;
           
            empLv.add_leave();

        }

        public void UPDATE_LEAVE()
        {
            empLv.id = Convert.ToInt32(txt_EmpID.Text);
            empLv.update_leave_count();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            timer3.Start();
        }

        private void rd_today_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
            
        }

        public void Read_todayLeaves() //read employee table 
        {
            empLv.dt.Clear();
            dgv_emp.DataSource = null;
            empLv.Read_Today_Leaves();

            dgv_emp.DataSource = empLv.dt;

        }

        public void ReadLeave()
        {
            empLv.dt.Clear();
            dgv_emp.DataSource = null;
            empLv.Read_Leave();
            dgv_emp.DataSource = empLv.dt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPage3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void rd_today_Click_1(object sender, EventArgs e)
        {
           
            Read_todayLeaves();
        }

        private void rd_leave_Click(object sender, EventArgs e)
        {
            
            ReadLeave();
        }

        private void rd_emplist_Click(object sender, EventArgs e)
        {
            
            Read();
        }

        private void dgv_emp_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_EmpID.Text = (dgv_emp.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_FName.Text = (dgv_emp.Rows[e.RowIndex].Cells[1].Value.ToString());
            txt_Lname.Text = (dgv_emp.Rows[e.RowIndex].Cells[2].Value.ToString());
            txt_contact.Text = (dgv_emp.Rows[e.RowIndex].Cells[3].Value.ToString());
            txt_NIC.Text = (dgv_emp.Rows[e.RowIndex].Cells[6].Value.ToString());
            txt_job.Text = (dgv_emp.Rows[e.RowIndex].Cells[7].Value.ToString());
            lbl_avb_leave.Text = (dgv_emp.Rows[e.RowIndex].Cells[11].Value.ToString());
        }
    }
}
