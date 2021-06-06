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
    public partial class usrIncome : UserControl
    {
        public usrIncome()
        {
            InitializeComponent();
           
        }
        AddProject prj = new AddProject();
        crud crd = new crud();
        Reports rpts = new Reports();
      
        private void usrIncome_Load(object sender, EventArgs e)
        {
            txt_empcount.Text = crd.countEmp();
            READ();
            lbl_prj.Text = prj.countprj_Ongoing();
            rpts.total_Cost();
            rpts.total_profit();
            lbl_cost.Text = Convert.ToString(rpts.cost);
            lbl_profit.Text = Convert.ToString(rpts.profit);
        }

        public void Show_count_Proj()
        {
            lbl_prj.Text = prj.countprj_Ongoing();
        }

        public void READ()
        {
            dgv_prj.DataSource = null;
            prj.Read_Ongoing_Proj();

            dgv_prj.DataSource = prj.dt;
        }

        private void dgv_prj_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            try
            {
                if (dgv_prj.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    txt_prjID.Text = (dgv_prj.Rows[e.RowIndex].Cells[0].Value.ToString());
                    txt_prjName.Text = (dgv_prj.Rows[e.RowIndex].Cells[1].Value.ToString());
                    txt_clientName.Text = (dgv_prj.Rows[e.RowIndex].Cells[2].Value.ToString());
                    txt_cost.Text = (dgv_prj.Rows[e.RowIndex].Cells[5].Value.ToString());
                    txt_profit.Text = (dgv_prj.Rows[e.RowIndex].Cells[7].Value.ToString());


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            if (txt_prjID.Text == "")
            {
                MessageBox.Show("Please Select Project!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cal();
            }
           
            
        }

        public void cal()
        {
            int cost = Convert.ToInt32(txt_cost.Text);
            int empcount = Convert.ToInt32(txt_empcount.Text);
            int empSalary = Convert.ToInt32(txt_emp_salary.Text);
            int profit;
            int totsalary;

            totsalary = empcount * empSalary;
            profit = cost - totsalary;

            txt_profit.Text = Convert.ToString(profit);

        }

        public void UPDATE_PROFIT()
        {
            prj.profit = Convert.ToInt32(txt_profit.Text);
            prj.id = Convert.ToInt32(txt_prjID.Text);
            prj.add_profit();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                
                if(txt_profit.Text == "")
                {
                    MessageBox.Show("Please calculate Profit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    UPDATE_PROFIT();
                    MessageBox.Show("Profit Updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    CLEAR();
                    READ();
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void CLEAR()
        {
            txt_prjID.Text = "";
            txt_prjName.Text = "";
            txt_clientName.Text = "";
            txt_cost.Text = "";
            txt_profit.Text = "";
        }

      
    }

     
    
}
