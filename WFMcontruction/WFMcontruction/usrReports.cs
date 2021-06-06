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
    public partial class usrReports : UserControl
    {
        public usrReports()
        {
            InitializeComponent();
        }
        BackgroundWorker worker = new BackgroundWorker(); 
        Reports rpts = new Reports();
        private void usrReports_Load(object sender, EventArgs e)
        {
            rpts.show_project();
            cmb_prj.DataSource = rpts.datafill;
            cmb_job.Text = "--Select Job--";

            dgv_emp_proj_assign.DataSource = null;
            rpts.data_grid_show();
            dgv_emp_proj_assign.DataSource = rpts.dt;


            dgv_leave.DataSource = null;
            rpts.data_grid_leave();
            dgv_leave.DataSource = rpts.dt2;

            pnl_emp_leave_view.Visible = true;
            pnl_emp_reg.Visible = false;
            pnl_project.Visible = false;

            //export report loading
            pnl_loadbar_01.Visible = false;
            pnl_loadbar02.Visible = false;
            pnl_loadbar03.Visible = false;
        }

        private void cmb_prj_SelectedIndexChanged(object sender, EventArgs e)
        {
            rpts.combobox_project_text = cmb_prj.Text;

            if(cmb_prj.Text == "--Select Project--")
            {
                
                dgv_emp_proj_assign.DataSource = null;
                rpts.data_grid_show();
                dgv_emp_proj_assign.DataSource = rpts.dt;
            }else
            {

                dgv_emp_proj_assign.DataSource = null;
                rpts.filter_data();
                dgv_emp_proj_assign.DataSource = rpts.dt;
            }
        }

        private void cmb_job_SelectedIndexChanged(object sender, EventArgs e)
        {
            rpts.comboboc_job_text = cmb_job.Text;
            if (cmb_job.Text == "--Select Job--")
            {

                dgv_emp_proj_assign.DataSource = null;
                rpts.data_grid_show();
                dgv_emp_proj_assign.DataSource = rpts.dt;
            }
            else
            {

                dgv_emp_proj_assign.DataSource = null;
                rpts.filter_job();
                dgv_emp_proj_assign.DataSource = rpts.dt;
            }
        }

        private void cmb_months_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void month_start_ValueChanged(object sender, EventArgs e)
        {
            


        }

        private void month_end_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_leave_month_Click(object sender, EventArgs e)
        {
            pnl_emp_leave_view.Visible = true;
            pnl_emp_reg.Visible = false;
            pnl_project.Visible = false;
            btn_leave_month.BackColor = Color.FromArgb(50, 226, 178);
        }

        private void btn_project_Click(object sender, EventArgs e)
        {
            pnl_emp_leave_view.Visible = false;
            pnl_emp_reg.Visible = false;
            pnl_project.Visible = true;
            btn_project.BackColor = Color.FromArgb(50, 226, 178);
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            pnl_emp_leave_view.Visible = false;
            pnl_emp_reg.Visible = true;
            pnl_project.Visible = false;
            btn_employee.BackColor = Color.FromArgb(50, 226, 178);
        }

        private void month_start_empReg_ValueChanged(object sender, EventArgs e)
        {

            rpts.search_month_start = month_start_empReg.Text;
            
            dgv_emp_reg.DataSource = null;
            rpts.filter_by_emr_Reg();
            dgv_emp_reg.DataSource = rpts.dt3;
        }

        private void month_end_empReg_ValueChanged(object sender, EventArgs e)
        {
            rpts.search_month_end = month_end_empReg.Text;
           
            dgv_emp_reg.DataSource = null;
            rpts.filter_by_emr_Reg();
            dgv_emp_reg.DataSource = rpts.dt3;
        }

        private void month_start_leave_ValueChanged(object sender, EventArgs e)
        {
            rpts.search_month_start = month_start_leave.Text;

            dgv_leave.DataSource = null;
            rpts.filter_by_month();
            dgv_leave.DataSource = rpts.dt2;
        }

        private void month_end_leave_ValueChanged(object sender, EventArgs e)
        {
            rpts.search_month_end = month_end_leave.Text;
            dgv_leave.DataSource = null;
            rpts.filter_by_month();
            dgv_leave.DataSource = rpts.dt2;
        }

        private void btn_leave_month_Leave(object sender, EventArgs e)
        {
            btn_leave_month.BackColor = Color.FromArgb(0, 146, 249);
        }

        private void btn_project_Leave(object sender, EventArgs e)
        {
            btn_project.BackColor = Color.FromArgb(0, 146, 249);
        }

        private void btn_employee_Leave(object sender, EventArgs e)
        {
            btn_employee.BackColor = Color.FromArgb(0, 146, 249);
        }

        private void btn_export01_Click(object sender, EventArgs e)
        {
            timer_emp_reg.Start();
            pnl_loadbar_01.Visible = true;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void timer_emp_reg_Tick(object sender, EventArgs e)
        {
            pnl_load.Width += 20;
            if (pnl_load.Width >= 813)
            {
                exportsheet();
                timer_emp_reg.Stop();
                pnl_loadbar_01.Visible = false;
                pnl_load.Width = 0;

                MessageBox.Show("Report Generate Sucess!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
           


        }


        //export to excel employee registration method
        public void exportsheet()
        {
            dgv_emp_reg.SelectAll();
            DataObject copydata = dgv_emp_reg.GetClipboardContent();
            if (copydata != null) Clipboard.SetDataObject(copydata);
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;

            Microsoft.Office.Interop.Excel.Workbook xlwbook;
            Microsoft.Office.Interop.Excel.Worksheet xlsheet;

            object misedata = System.Reflection.Missing.Value;
            xlwbook = xlapp.Workbooks.Add(misedata);

            xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlwbook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
            xlr.Select();

            xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        //export to excel employee leave method
        public void exportsheet_empleave()
        {
            dgv_leave.SelectAll();
            DataObject copydata = dgv_leave.GetClipboardContent();
            if (copydata != null) Clipboard.SetDataObject(copydata);
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;

            Microsoft.Office.Interop.Excel.Workbook xlwbook;
            Microsoft.Office.Interop.Excel.Worksheet xlsheet;

            object misedata = System.Reflection.Missing.Value;
            xlwbook = xlapp.Workbooks.Add(misedata);

            xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlwbook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
            xlr.Select();

            xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        //export to excel employee assign project method
        public void exportsheet_empassign()
        {
            dgv_emp_proj_assign.SelectAll();
            DataObject copydata = dgv_emp_proj_assign.GetClipboardContent();
            if (copydata != null) Clipboard.SetDataObject(copydata);
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;

            Microsoft.Office.Interop.Excel.Workbook xlwbook;
            Microsoft.Office.Interop.Excel.Worksheet xlsheet;

            object misedata = System.Reflection.Missing.Value;
            xlwbook = xlapp.Workbooks.Add(misedata);

            xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlwbook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
            xlr.Select();

            xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void btn_export02_Click(object sender, EventArgs e)
        {
            timer_emp_leave_month.Start();
            pnl_loadbar02.Visible = true;
        }

        private void timer_emp_leave_month_Tick(object sender, EventArgs e)
        {
            pnl_load02.Width += 20;
            if(pnl_load02.Width >=813)
            {
                exportsheet_empleave();
                timer_emp_leave_month.Stop();
                pnl_loadbar02.Visible = false;
                pnl_load02.Width = 0;

                MessageBox.Show("Report Generate Sucess!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
           

        }

        private void btn_export03_Click(object sender, EventArgs e)
        {
            timer_emp_assign.Start();
            pnl_loadbar03.Visible = true;
        }

        private void timer_emp_assign_Tick(object sender, EventArgs e)
        {
            pnl_load03.Width += 20;
            if(pnl_load03.Width >=813)
            {
                exportsheet_empassign();
                timer_emp_assign.Stop();
                pnl_loadbar03.Visible = false;
                pnl_load03.Width = 0;

                MessageBox.Show("Report Generate Sucess!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
           
        }
    }
}
