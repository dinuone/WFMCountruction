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
    public partial class usercntrlManageEMP : UserControl
    {
        crud crd = new crud();
        AddProject prj = new AddProject();
        public usercntrlManageEMP()
        {
            InitializeComponent();
            Read();
        }

        private void dgv_emp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            try
            {
                if(dgv_emp.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    txt_EmpID.Text = (dgv_emp.Rows[e.RowIndex].Cells[0].Value.ToString());
                    txt_FName.Text = (dgv_emp.Rows[e.RowIndex].Cells[1].Value.ToString());
                    txt_Lname.Text = (dgv_emp.Rows[e.RowIndex].Cells[2].Value.ToString());
                    txt_contact.Text = (dgv_emp.Rows[e.RowIndex].Cells[3].Value.ToString());
                    txt_adres.Text = (dgv_emp.Rows[e.RowIndex].Cells[4].Value.ToString());
                    txt_NIC.Text = (dgv_emp.Rows[e.RowIndex].Cells[6].Value.ToString());
                    cmb_job_role.Text = (dgv_emp.Rows[e.RowIndex].Cells[7].Value.ToString());
                    txt_workexp.Text = (dgv_emp.Rows[e.RowIndex].Cells[10].Value.ToString());
                    cmb_project.Text = (dgv_emp.Rows[e.RowIndex].Cells[12].Value.ToString());
                    

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Read() //read employee table 
        {
            dgv_emp.DataSource = null;
            crd.Read_EMP();

            dgv_emp.DataSource = crd.dt;

        }

        private void usercntrlManageEMP_Load(object sender, EventArgs e)
        {
            Read();
            prj.show_project();
            cmb_project.DataSource = prj.datafill;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_FName.Text == "" || txt_Lname.Text == "" || txt_NIC.Text == "" || txt_contact.Text == "" || txt_adres.Text == "" || txt_workexp.Text == "")
                {
                    MessageBox.Show("Please Select Record!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    UPDATE();
                    MessageBox.Show("Employee Details Updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Read();
                    CLEAR();
                }
                    

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UPDATE()
        {
            crd.id = Convert.ToInt32(txt_EmpID.Text);
            crd.fname = txt_FName.Text;
            crd.lname = txt_Lname.Text;
            crd.contact = txt_contact.Text;
            crd.addres = txt_adres.Text;
            crd.nic = txt_NIC.Text;
            crd.job = cmb_job_role.Text;
            crd.workexp = Convert.ToInt32(txt_workexp.Text);
            crd.assignproject = cmb_project.Text;
            crd.update_employee();
        }

        public void DELETE()
        {
            crd.id = Convert.ToInt32(txt_EmpID.Text);
            crd.delete_emp();
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
            txt_EmpID.Text = "";
            cmb_project.Text = "";
           

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string valuesearch = txt_search.Text.ToString();
            crd.search_emp(valuesearch); // send text value to searchemp method
            dgv_emp.DataSource = crd.dt;
           
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_FName.Text == "" || txt_Lname.Text == "" || txt_NIC.Text == "" || txt_contact.Text == "" || txt_adres.Text == "" || txt_workexp.Text == "")
                {
                    MessageBox.Show("Please Select Record!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult dialogresult = MessageBox.Show("Do you want to Delete this Record?", "Warning!", MessageBoxButtons.YesNo);
                    if (dialogresult == DialogResult.Yes)
                    {
                        DELETE();
                        Read();
                        MessageBox.Show("Record Delete Successfull!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else if (dialogresult == DialogResult.No)
                    {
                        Read();
                    }
                }
              
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
