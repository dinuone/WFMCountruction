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
    public partial class usrAddProject : UserControl
    {
        AddProject prj = new AddProject();
        public usrAddProject()
        {
            InitializeComponent();
        }

        private void usrAddProject_Load(object sender, EventArgs e)
        {
            cmb_status.Enabled = false;
            READ();
        }

        private void cmb_supervisor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void Read() //read project table 
        {
           

        }

        private void rd_supervisor_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void rd_qc_Click(object sender, EventArgs e)
        {
           
        }

        private void rd_driver_Click(object sender, EventArgs e)
        {
            
        }

        private void rd_labour_Click(object sender, EventArgs e)
        {
            
        }

        private void rd_trainee_Click(object sender, EventArgs e)
        {
           
        }

        private void rd_all_Click(object sender, EventArgs e)
        {
            
        }

        private void dgv_emp_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgv_emp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            DataGridView senderGrid = (DataGridView)sender;
            try
            {
                if (dgv_emp.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    txt_prjID.Text = (dgv_emp.Rows[e.RowIndex].Cells[0].Value.ToString());
                    txt_prjName.Text = (dgv_emp.Rows[e.RowIndex].Cells[1].Value.ToString());
                    txt_clientName.Text = (dgv_emp.Rows[e.RowIndex].Cells[2].Value.ToString());
                    date_start_date.Text = (dgv_emp.Rows[e.RowIndex].Cells[3].Value.ToString());
                    date_duration.Text = (dgv_emp.Rows[e.RowIndex].Cells[4].Value.ToString());
                    txt_cost.Text = (dgv_emp.Rows[e.RowIndex].Cells[5].Value.ToString());
                    cmb_status.Text = (dgv_emp.Rows[e.RowIndex].Cells[6].Value.ToString());
                    
                    if(txt_prjID.Text != null)
                    {
                        cmb_status.Enabled = true;
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_add_prj_Click(object sender, EventArgs e)
        {
            try
            {
                CREATE();
                MessageBox.Show("New Project created");
                READ();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void CREATE() // add new project
        {
            prj.projname = txt_prjName.Text;
            prj.clientname = txt_clientName.Text;
            prj.startdate = date_start_date.Text;
            prj.duration = date_duration.Text;
            prj.cost = Convert.ToInt32(txt_cost.Text);

            prj.add_project();
        }

        public void READ()
        {
            dgv_emp.DataSource = null;
            prj.Read_Proj();

            dgv_emp.DataSource = prj.dt;
        }

        public void CLEAR()
        {
            txt_prjID.Text = "";
            txt_prjName.Text = "";
            txt_clientName.Text = "";
            txt_cost.Text = "";
            date_duration.Text = "";
            date_start_date.Text = "";
           
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                UPDATE();
                MessageBox.Show("Project Details Updated");
                READ();
                CLEAR();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UPDATE()
        {
            prj.id = Convert.ToInt32(txt_prjID.Text);
            prj.projname = txt_prjName.Text;
            prj.clientname = txt_clientName.Text;
            prj.startdate = date_start_date.Text;
            prj.duration = date_duration.Text;
            prj.cost = Convert.ToInt32(txt_cost.Text);
            prj.status = cmb_status.Text;

            prj.update_Project();

        }

        public void DELETE()
        {
            prj.id = Convert.ToInt32(txt_prjID.Text);
            prj.delete_prj();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogresult = MessageBox.Show("Do you want to Delete this Record?", "Warning!", MessageBoxButtons.YesNo);
                if (dialogresult == DialogResult.Yes)
                {
                    DELETE();
                    Read();
                    MessageBox.Show("Record Delete successfull");
                }
                else if (dialogresult == DialogResult.No)
                {
                    Read();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
