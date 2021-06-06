using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WFMcontruction
{
    public partial class usercntrlAddemp : UserControl
    {
        crud crd = new crud();
        AddProject prj = new AddProject();
        public usercntrlAddemp()
        {
            InitializeComponent();
        }


        private void btn_addemp_Click(object sender, EventArgs e)
        {
            bool success = false; // if success == true then clear text box values
            try
            {
                if (txt_FName.Text == "" || txt_Lname.Text == "" || txt_NIC.Text == "" || txt_contact.Text == "" || txt_adres.Text == "" || txt_workexp.Text=="")
                {
                    MessageBox.Show("Please Fill All Fileds!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }else
                {
                    CREATE(); // create method
                    MessageBox.Show("Employee Added Successfull!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    success = true;
                }

              
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if(success == true)
            {
                CLEAR(); //text box clear method
                lbl_totEmpcount.Text = crd.countEmp(); // show total employees 
                lbl_todayEmp.Text = crd.countTodayEmp(); // show today added employees
                usercntrlManageEMP emp = new usercntrlManageEMP();
                emp.Read();
            }
           
        }
        public void CREATE() //get values form Ui and pass it to get set methods in crud class
        {
           
                crd.fname = txt_FName.Text;
                crd.lname = txt_Lname.Text;
                crd.contact = txt_contact.Text;
                crd.addres = txt_adres.Text;
                crd.dob = date_DOB.Text;
                crd.nic = txt_NIC.Text;
                crd.job = cmb_job_role.Text;
                crd.workexp = Convert.ToInt32(txt_workexp.Text);
                crd.assignproject = cmb_assign_project.Text;

                if (radio_male.Checked)
                {
                    crd.gender = radio_male.Text;
                }
                if (radio_female.Checked)
                {
                    crd.gender = radio_female.Text;
                }

                crd.add_employee();
            

        }

        public void CLEAR()
        {
            txt_adres.Text = "";
            txt_contact.Text = "";
            txt_FName.Text = "";
            txt_Lname.Text = "";
            txt_NIC.Text = "";
            txt_workexp.Text = "";
            cmb_job_role.Text = "";
            date_DOB.Text = "";
            
        }

        private void usercntrlAddemp_Load(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            lbl_date.Text = DateTime.Now.ToLongDateString();
            lbl_totEmpcount.Text = crd.countEmp(); // show total employees 
            lbl_todayEmp.Text = crd.countTodayEmp(); // show today added employees

            prj.show_project();
            cmb_assign_project.DataSource = prj.datafill;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void lbl_todayEmp_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_EmpID_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void cmb_assign_project_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
