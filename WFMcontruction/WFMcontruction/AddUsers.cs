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
    public partial class AddUsers : UserControl
    {
        public AddUsers()
        {
            InitializeComponent();
        }

        ManageUsrAcc users = new ManageUsrAcc(); //make object in manageusrAcc class
        private void AddUsers_Load(object sender, EventArgs e)
        {

            READ();
        }

        public void READ()
        {
            dgv_user.DataSource = null;
            users.Read_usr();
            dgv_user.DataSource = users.dt;
        }

        private void btn_add_user_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_FName.Text == ""|| txt_Lname.Text =="" || txt_NIC.Text =="" || txt_psw.Text =="" || txt_usrName.Text == "")
                {
                    MessageBox.Show("Please fill All Fileds!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Add_user_account();
                    MessageBox.Show("Successfully Created User Account!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    READ();
                    CLEAR();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Add_user_account()
        {
            users.Firstname = txt_FName.Text;
            users.Lastname = txt_Lname.Text;
            users.cont = txt_contact.Text;
            users.nic = txt_NIC.Text;
            users.usrname = txt_usrName.Text;
            users.psw = txt_psw.Text;

            if(cmb_user_type.Text == "Admin")
            {
                users.utype = "1";
            }
            else if(cmb_user_type.Text == "Manager")
            {
                users.utype = "2";
            }

            users.add_user();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_FName.Text == "" || txt_Lname.Text == "" || txt_NIC.Text == "" || txt_psw.Text == "" || txt_usrName.Text == "")
                {
                    MessageBox.Show("Please Select record!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    UPDATE_usrAcc();
                    MessageBox.Show("Successfully Updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    CLEAR();
                    READ();
                }
              
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UPDATE_usrAcc()
        {
            users.id = Convert.ToInt32(txt_userID.Text);
            users.Firstname = txt_FName.Text;
            users.Lastname = txt_Lname.Text;
            users.cont = txt_contact.Text;
            users.nic = txt_NIC.Text;
            users.usrname = txt_usrName.Text;
            users.psw = txt_psw.Text;

            if (cmb_user_type.Text == "Admin")
            {
                users.utype = "1";
            }
            else if (cmb_user_type.Text == "Manager")
            {
                users.utype = "2";
            }
         
            users.update_usr_acc();
        }

        private void dgv_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_userID.Text = (dgv_user.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_usrName.Text = (dgv_user.Rows[e.RowIndex].Cells[1].Value.ToString());
            txt_psw.Text = (dgv_user.Rows[e.RowIndex].Cells[2].Value.ToString());
            cmb_user_type.Text = (dgv_user.Rows[e.RowIndex].Cells[3].Value.ToString());
            txt_FName.Text = (dgv_user.Rows[e.RowIndex].Cells[4].Value.ToString());
            txt_Lname.Text = (dgv_user.Rows[e.RowIndex].Cells[5].Value.ToString());
            txt_contact.Text = (dgv_user.Rows[e.RowIndex].Cells[6].Value.ToString());
            txt_NIC.Text = (dgv_user.Rows[e.RowIndex].Cells[7].Value.ToString());

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_FName.Text == "" || txt_Lname.Text == "" || txt_NIC.Text == "" || txt_psw.Text == "" || txt_usrName.Text == "")
                {
                    MessageBox.Show("Please Select record!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult dialogresult = MessageBox.Show("Do you want to Delete this Record?", "Warning!", MessageBoxButtons.YesNo);
                    if (dialogresult == DialogResult.Yes)
                    {
                        DELETE();
                        READ();
                        MessageBox.Show("Record Delete Successfull!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        CLEAR();
                    }
                    else if (dialogresult == DialogResult.No)
                    {
                        READ();
                    }
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void DELETE()
        {
            users.id = Convert.ToInt32(txt_userID.Text);
            users.delete_usr_acc();
            READ();
            CLEAR();
        }

        public void CLEAR()
        {
            txt_userID.Text = "";
            txt_usrName.Text = "";
            txt_psw.Text = "";
            txt_FName.Text = "";
            txt_Lname.Text = "";
            txt_contact.Text = "";
            txt_NIC.Text = "";
            cmb_user_type.Text = "";
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string valuesearch = txt_search.Text.ToString();
            users.search_user(valuesearch); // send text value to searchemp method
            dgv_user.DataSource = users.dt;
        }
    }
}
