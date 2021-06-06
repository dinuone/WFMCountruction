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
    public partial class splashScreencs : Form
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


        public splashScreencs()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
      
        private void timer1_Tick(object sender, EventArgs e)
        {
            pnl_side.Width += 2;
            if(pnl_side.Width >= 662)
            {
                timer1.Stop();
                if(login.user_type_label_text == "Manager")
                {
                    mangerDashboard mng = new mangerDashboard();
                    mng.Show();
                    this.Hide();
                }
                else if(login.user_type_label_text == "Admin")
                {
                    admindash admin = new admindash();
                    admin.Show();
                    this.Hide();
                }
             
            }

        }
       
        private void splashScreencs_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
