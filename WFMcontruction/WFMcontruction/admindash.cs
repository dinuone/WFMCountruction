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
    public partial class admindash : Form
    {

        crud crd = new crud();
        AddProject prj = new AddProject();
        userlogin lg = new userlogin();
        Reports rpts = new Reports();

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
    
        public admindash()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
           
        }

        private void pnl_nav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void admindash_Load(object sender, EventArgs e)
        {
            pnl_nav_item.Visible = false;
         
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            lbl_date.Text = DateTime.Now.ToLongDateString();
            lbl_empcount.Text = crd.countEmp();

            //panel visible
            usercntrlAddemp1.Visible = false;
            usercntrlManageEMP1.Visible = false;
            usrAddLeaves1.Visible = false;
            usrManageProject1.Visible = false;
            usrIncome1.Visible = false;
            usrReports1.Visible = false;
            addUsers1.Visible = false;

            lbl_usr_type.Text = login.user_type_label_text;
            lbl_usrname.Text = login.username_text;
            lbl_prj_count.Text = prj.count_prj();

            rpts.total_profit();
            lbl_profit.Text = Convert.ToString(rpts.profit);
        }

        private void btn_dash_Click(object sender, EventArgs e)
        {
            pnl_nav_item.Visible = true;
            pnl_nav_item.Height = btn_dash.Height;
            pnl_nav_item.Top = btn_dash.Top;
            pnl_nav_item.Left = btn_dash.Left;
            btn_dash.BackColor = Color.FromArgb(46, 51, 73);

            //panel visible
            usercntrlAddemp1.Visible = false;
            usercntrlManageEMP1.Visible = false;
            usrAddLeaves1.Visible = false;
            usrManageProject1.Visible = false;
            usrIncome1.Visible = false;
            usrReports1.Visible = false;
            addUsers1.Visible = false;
        }

        private void btn_addemp_Click(object sender, EventArgs e)
        {
            pnl_nav_item.Height = btn_addemp.Height;
            pnl_nav_item.Left = btn_addemp.Left;
            pnl_nav_item.Top = btn_addemp.Top;
            btn_addemp.BackColor = Color.FromArgb(46, 51, 73);

            //panel visible
            usercntrlAddemp1.Visible = true;
            usercntrlManageEMP1.Visible = false;
            usrAddLeaves1.Visible = false;
            usrManageProject1.Visible = false;
            usrIncome1.Visible = false;
            usrReports1.Visible = false;
            addUsers1.Visible = false;

        }

        private void btn_manageEmp_Click(object sender, EventArgs e)
        {
            pnl_nav_item.Height = btn_manageEmp.Height;
            pnl_nav_item.Top = btn_manageEmp.Top;
            pnl_nav_item.Left = btn_manageEmp.Left;
            btn_manageEmp.BackColor = Color.FromArgb(46, 51, 73);

            //panel visible
            usercntrlAddemp1.Visible = false;
            usercntrlManageEMP1.Visible = true;
            usrAddLeaves1.Visible = false;
            usrManageProject1.Visible = false;
            usrIncome1.Visible = false;
            usrReports1.Visible = false;
            addUsers1.Visible = false;

            usercntrlManageEMP1.Read();
        }

        private void btn_EmpLeaves_Click(object sender, EventArgs e)
        {
            pnl_nav_item.Height = btn_EmpLeaves.Height;
            pnl_nav_item.Top = btn_EmpLeaves.Top;
            pnl_nav_item.Left = btn_EmpLeaves.Left;
            btn_EmpLeaves.BackColor = Color.FromArgb(46, 51, 73);
            
            //panel visible 
            usercntrlAddemp1.Visible = false;
            usercntrlManageEMP1.Visible = false;
            usrAddLeaves1.Visible = true;
            usrManageProject1.Visible = false;
            usrIncome1.Visible = false;
            usrReports1.Visible = false;
            addUsers1.Visible = false;

        }

        private void btn_ProjDetail_Click(object sender, EventArgs e)
        {
            pnl_nav_item.Height = btn_ProjDetail.Height;
            pnl_nav_item.Top = btn_ProjDetail.Top;
            pnl_nav_item.Left = btn_ProjDetail.Left;
            btn_ProjDetail.BackColor = Color.FromArgb(46, 51, 73);

            //panel visible 
            usercntrlAddemp1.Visible = false;
            usercntrlManageEMP1.Visible = false;
            usrAddLeaves1.Visible =false;
            usrManageProject1.Visible = true;
            usrIncome1.Visible = false;
            usrReports1.Visible = false;
            addUsers1.Visible = false;
        }


        private void btn_comp_income_Click(object sender, EventArgs e)
        {
            pnl_nav_item.Height = btn_comp_income.Height;
            pnl_nav_item.Top = btn_comp_income.Top;
            pnl_nav_item.Left = btn_comp_income.Left;
            btn_comp_income.BackColor = Color.FromArgb(46, 51, 73);


            usrIncome1.Visible = true;
            usercntrlAddemp1.Visible = false;
            usercntrlManageEMP1.Visible = false;
            usrAddLeaves1.Visible = false;
            usrManageProject1.Visible = false;
            usrReports1.Visible = false;
            addUsers1.Visible = false;

            //load ongoin project count
            usrIncome1.Show_count_Proj();
            usrIncome1.READ();
        }


        private void btn_Month_report_Click(object sender, EventArgs e)
        {
            pnl_nav_item.Height = btn_Month_report.Height;
            pnl_nav_item.Top = btn_Month_report.Top;
            pnl_nav_item.Left = btn_Month_report.Left;
            btn_Month_report.BackColor = Color.FromArgb(46, 51, 73);


            usrIncome1.Visible = false;
            usercntrlAddemp1.Visible = false;
            usercntrlManageEMP1.Visible = false;
            usrAddLeaves1.Visible = false;
            usrManageProject1.Visible = false;
            usrReports1.Visible = true;
            addUsers1.Visible = false;
        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {
            
            pnl_nav_item.Height = btn_addUser.Height;
            pnl_nav_item.Top = btn_addUser.Top;
            pnl_nav_item.Left = btn_addUser.Left;
            btn_addUser.BackColor = Color.FromArgb(46, 51, 73);

            usrIncome1.Visible = false;
            usercntrlAddemp1.Visible = false;
            usercntrlManageEMP1.Visible = false;
            usrAddLeaves1.Visible = false;
            usrManageProject1.Visible = false;
            usrReports1.Visible = false;
            addUsers1.Visible = true;
        }

        private void btn_dash_Leave(object sender, EventArgs e)
        {
            btn_dash.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_addemp_Leave(object sender, EventArgs e)
        {
            btn_addemp.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void btn_manageEmp_Leave(object sender, EventArgs e)
        {
            btn_manageEmp.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_EmpLeaves_Leave(object sender, EventArgs e)
        {
            btn_EmpLeaves.BackColor = Color.FromArgb(24, 30, 54);
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

        private void btn_addUser_Leave(object sender, EventArgs e)
        {
            btn_addUser.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            timer2.Start();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_income_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_income_Leave(object sender, EventArgs e)
        {
           
        }

        private void btn_reports_Leave(object sender, EventArgs e)
        {
            
        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.Show();
        }

       
    }
}
