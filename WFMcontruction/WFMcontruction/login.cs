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
    public partial class login : Form
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
        public login()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        userlogin lg = new userlogin();

        public static string username;
        public static string usertype;
        public static string user_type_label_text;
        public static string username_text;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
            txt_username.Focus();
            btn_hide.Visible = false;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            lg.uname = txt_username.Text;
            lg.psw = txt_password.Text;

            bool check = lg.user_verify();

            if (check == true)
            {
                int usr_type = lg.usr_type;

                if(usr_type == 1)
                {
                    user_type_label_text = "Admin";
                    username_text = lg.usrname_text;

                    splashScreencs load = new splashScreencs();
                    load.Show();
                    this.Hide();
                }
                else if(usr_type == 2)
                {
                    user_type_label_text = "Manager";
                    username_text = lg.usrname_text;

                    splashScreencs load = new splashScreencs();
                    load.Show();
                    this.Hide();
                }
            
                else
                {
                    MessageBox.Show("invalid user type!","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txt_username.Clear();
                    txt_password.Clear();
                    txt_username.Focus();
                }

                
                
            }
            else if (check == false)
            {
                MessageBox.Show("invalid Username or Password!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_username.Clear();
                txt_password.Clear();
                txt_username.Focus();
            }
        }

        private void btn_eye_Click(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = true;
            btn_hide.Visible = true;
            btn_eye.Visible = false;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = false;
            btn_eye.Visible = true;
            btn_hide.Visible = false;
        }

        private void txt_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
        }

        private void txt_clear_MouseHover(object sender, EventArgs e)
        {
           
        }
    }
}
