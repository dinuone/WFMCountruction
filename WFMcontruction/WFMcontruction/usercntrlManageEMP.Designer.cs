namespace WFMcontruction
{
    partial class usercntrlManageEMP
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_emp = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmb_project = new System.Windows.Forms.ComboBox();
            this.cmb_job_role = new System.Windows.Forms.ComboBox();
            this.txt_workexp = new System.Windows.Forms.TextBox();
            this.txt_NIC = new System.Windows.Forms.TextBox();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.txt_Lname = new System.Windows.Forms.TextBox();
            this.txt_FName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_EmpID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emp)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.dgv_emp);
            this.panel1.Location = new System.Drawing.Point(24, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 789);
            this.panel1.TabIndex = 0;
            // 
            // dgv_emp
            // 
            this.dgv_emp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.dgv_emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_emp.Location = new System.Drawing.Point(18, 21);
            this.dgv_emp.Name = "dgv_emp";
            this.dgv_emp.ReadOnly = true;
            this.dgv_emp.RowTemplate.Height = 24;
            this.dgv_emp.Size = new System.Drawing.Size(911, 748);
            this.dgv_emp.TabIndex = 0;
            this.dgv_emp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_emp_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(2, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 51);
            this.label3.TabIndex = 5;
            this.label3.Text = "Manage Employees";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.cmb_project);
            this.panel2.Controls.Add(this.cmb_job_role);
            this.panel2.Controls.Add(this.txt_workexp);
            this.panel2.Controls.Add(this.txt_NIC);
            this.panel2.Controls.Add(this.txt_adres);
            this.panel2.Controls.Add(this.txt_contact);
            this.panel2.Controls.Add(this.txt_Lname);
            this.panel2.Controls.Add(this.txt_FName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_EmpID);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(1018, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 631);
            this.panel2.TabIndex = 6;
            // 
            // cmb_project
            // 
            this.cmb_project.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.cmb_project.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_project.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_project.ForeColor = System.Drawing.Color.White;
            this.cmb_project.FormattingEnabled = true;
            this.cmb_project.Location = new System.Drawing.Point(167, 579);
            this.cmb_project.Name = "cmb_project";
            this.cmb_project.Size = new System.Drawing.Size(386, 28);
            this.cmb_project.TabIndex = 20;
            // 
            // cmb_job_role
            // 
            this.cmb_job_role.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.cmb_job_role.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_job_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_job_role.ForeColor = System.Drawing.Color.White;
            this.cmb_job_role.FormattingEnabled = true;
            this.cmb_job_role.Items.AddRange(new object[] {
            "Labour",
            "QC",
            "Driver",
            "Supervisser ",
            "Trainee"});
            this.cmb_job_role.Location = new System.Drawing.Point(167, 464);
            this.cmb_job_role.Name = "cmb_job_role";
            this.cmb_job_role.Size = new System.Drawing.Size(386, 28);
            this.cmb_job_role.TabIndex = 20;
            // 
            // txt_workexp
            // 
            this.txt_workexp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txt_workexp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_workexp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_workexp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_workexp.Location = new System.Drawing.Point(167, 525);
            this.txt_workexp.Name = "txt_workexp";
            this.txt_workexp.Size = new System.Drawing.Size(386, 24);
            this.txt_workexp.TabIndex = 13;
            // 
            // txt_NIC
            // 
            this.txt_NIC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txt_NIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NIC.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_NIC.Location = new System.Drawing.Point(167, 406);
            this.txt_NIC.Name = "txt_NIC";
            this.txt_NIC.Size = new System.Drawing.Size(386, 24);
            this.txt_NIC.TabIndex = 14;
            // 
            // txt_adres
            // 
            this.txt_adres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txt_adres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_adres.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_adres.Location = new System.Drawing.Point(167, 242);
            this.txt_adres.Multiline = true;
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(386, 127);
            this.txt_adres.TabIndex = 15;
            // 
            // txt_contact
            // 
            this.txt_contact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txt_contact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contact.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_contact.Location = new System.Drawing.Point(167, 191);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(386, 24);
            this.txt_contact.TabIndex = 16;
            // 
            // txt_Lname
            // 
            this.txt_Lname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txt_Lname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Lname.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Lname.Location = new System.Drawing.Point(167, 142);
            this.txt_Lname.Name = "txt_Lname";
            this.txt_Lname.Size = new System.Drawing.Size(386, 24);
            this.txt_Lname.TabIndex = 17;
            // 
            // txt_FName
            // 
            this.txt_FName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txt_FName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_FName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_FName.Location = new System.Drawing.Point(164, 89);
            this.txt_FName.Name = "txt_FName";
            this.txt_FName.Size = new System.Drawing.Size(389, 24);
            this.txt_FName.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 582);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Project Assign";
            // 
            // txt_EmpID
            // 
            this.txt_EmpID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txt_EmpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_EmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmpID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_EmpID.Location = new System.Drawing.Point(164, 41);
            this.txt_EmpID.Name = "txt_EmpID";
            this.txt_EmpID.ReadOnly = true;
            this.txt_EmpID.Size = new System.Drawing.Size(389, 24);
            this.txt_EmpID.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 10.8F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(31, 525);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 25);
            this.label11.TabIndex = 5;
            this.label11.Text = "Expereince";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 10.8F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(29, 467);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "Job Position";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 10.8F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(31, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "NIC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 10.8F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(25, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 10.8F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Contact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10.8F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 10.8F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "First Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 10.8F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(25, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Empolyee ID";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.btn_delete);
            this.panel3.Controls.Add(this.btn_update);
            this.panel3.Location = new System.Drawing.Point(1018, 748);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(596, 224);
            this.panel3.TabIndex = 7;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(28, 121);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(539, 86);
            this.btn_delete.TabIndex = 0;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(28, 19);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(539, 86);
            this.btn_update.TabIndex = 0;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.txt_search);
            this.panel4.Location = new System.Drawing.Point(24, 97);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(951, 63);
            this.panel4.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WFMcontruction.Properties.Resources.icons8_search_50;
            this.pictureBox1.Location = new System.Drawing.Point(86, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 10.8F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(13, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 25);
            this.label12.TabIndex = 12;
            this.label12.Text = "Search";
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_search.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_search.Location = new System.Drawing.Point(134, 18);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(795, 30);
            this.txt_search.TabIndex = 19;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // usercntrlManageEMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "usercntrlManageEMP";
            this.Size = new System.Drawing.Size(1641, 1000);
            this.Load += new System.EventHandler(this.usercntrlManageEMP_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emp)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_emp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmb_job_role;
        private System.Windows.Forms.TextBox txt_workexp;
        private System.Windows.Forms.TextBox txt_NIC;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.TextBox txt_Lname;
        private System.Windows.Forms.TextBox txt_FName;
        private System.Windows.Forms.TextBox txt_EmpID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmb_project;
        private System.Windows.Forms.Label label1;
    }
}
