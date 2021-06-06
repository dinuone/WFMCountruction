using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WFMcontruction
{
    public partial class mangerDashboard : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
         (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
              int nHeightEllipse

          );

        crud crd = new crud();
        AddProject prj = new AddProject();
        userlogin lg = new userlogin();
        EmpLeave leave = new EmpLeave();
        Reports rpts = new Reports();
        public mangerDashboard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
       
        private void mangerDashboard_Load(object sender, EventArgs e)
        {
            
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            lbl_date.Text = DateTime.Now.ToLongDateString();
            lbl_empcount.Text = crd.countEmp();

            lbl_user_name.Text = login.username_text;
            lbl_usr_type.Text = login.user_type_label_text;
            lbl_usrname.Text = login.username_text;
            lbl_prj_count.Text = prj.count_prj();
            lbl_today_leave.Text = leave.countToday_Leave();
            lbl_prj_count.Text = prj.count_prj();
            lbl_ongoing_prj.Text = prj.countprj_Ongoing();
            lbl_complete_prj.Text = prj.countprj_comlpete();
            lbl_new_add_prj.Text = prj.countprj_NewlyAdd();

            empLeave_Manager1.Visible = false;
            usrManageProject1.Visible = false;
            usrIncome1.Visible = false;
            usrReports1.Visible = false;

            pnl_nav_item.Visible = false;
            rpts.total_profit();
            lbl_profit.Text = Convert.ToString(rpts.profit);
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_EmpLeaves_Click(object sender, EventArgs e)
        {
            
            pnl_nav_item.Visible = true;
            pnl_nav_item.Height = btn_EmpLeaves.Height;
            pnl_nav_item.Top = btn_EmpLeaves.Top;
            pnl_nav_item.Left = btn_EmpLeaves.Left;
            btn_EmpLeaves.BackColor = Color.FromArgb(46, 51, 73);

            empLeave_Manager1.Visible = true;
            usrManageProject1.Visible = false;
            usrIncome1.Visible = false;
            usrReports1.Visible = false;
        }

        private void timer_manager_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            timer_manager.Start();
        }

        private void btn_dash_Click(object sender, EventArgs e)
        {
            empLeave_Manager1.Visible = false;
            usrManageProject1.Visible = false;
            usrIncome1.Visible = false;
            usrReports1.Visible = false;

            pnl_nav_item.Visible = true;
            pnl_nav_item.Height = btn_dash.Height;
            pnl_nav_item.Top = btn_dash.Top;
            pnl_nav_item.Left = btn_dash.Left;
            btn_dash.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btn_dash_Leave(object sender, EventArgs e)
        {
            btn_dash.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_EmpLeaves_Leave(object sender, EventArgs e)
        {
            btn_EmpLeaves.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_ProjDetail_Click(object sender, EventArgs e)
        {
            
            pnl_nav_item.Height = btn_ProjDetail.Height;
            pnl_nav_item.Top = btn_ProjDetail.Top;
            pnl_nav_item.Left = btn_ProjDetail.Left;
            btn_ProjDetail.BackColor = Color.FromArgb(46, 51, 73);

            empLeave_Manager1.Visible = false;
            usrManageProject1.Visible = true;
            usrIncome1.Visible = false;
            usrReports1.Visible = false;
        }

        private void btn_comp_income_Click(object sender, EventArgs e)
        {
            pnl_nav_item.Height = btn_comp_income.Height;
            pnl_nav_item.Top = btn_comp_income.Top;
            pnl_nav_item.Left = btn_comp_income.Left;
            btn_comp_income.BackColor = Color.FromArgb(46, 51, 73);

            empLeave_Manager1.Visible = false;
            usrManageProject1.Visible = false;
            usrIncome1.Visible = true;
            usrReports1.Visible = false;
        }

        private void btn_Month_report_Click(object sender, EventArgs e)
        {
            pnl_nav_item.Height = btn_Month_report.Height;
            pnl_nav_item.Top = btn_Month_report.Top;
            pnl_nav_item.Left = btn_Month_report.Left;
            btn_Month_report.BackColor = Color.FromArgb(46, 51, 73);

            usrManageProject1.Visible = false;
            empLeave_Manager1.Visible = false;
            usrIncome1.Visible = false;
            usrReports1.Visible = true;
        }

        private void btn_ProjDetail_Leave(object sender, EventArgs e)
        {
            btn_ProjDetail.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_comp_income_Leave(object sender, EventArgs e)
        {
            btn_comp_income.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_Month_report_Leave(object sender, EventArgs e)
        {
            btn_Month_report.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.Show();
        }
    }
}
