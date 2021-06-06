namespace WFMcontruction
{
    partial class usrReports
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_emp_proj_assign = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_prj = new System.Windows.Forms.ComboBox();
            this.cmb_job = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_project = new System.Windows.Forms.Panel();
            this.btn_export03 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_emp_leave_view = new System.Windows.Forms.Panel();
            this.btn_export02 = new System.Windows.Forms.Button();
            this.month_start_leave = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_leave = new System.Windows.Forms.DataGridView();
            this.month_end_leave = new System.Windows.Forms.DateTimePicker();
            this.pnl_emp_reg = new System.Windows.Forms.Panel();
            this.btn_export01 = new System.Windows.Forms.Button();
            this.month_start_empReg = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_emp_reg = new System.Windows.Forms.DataGridView();
            this.month_end_empReg = new System.Windows.Forms.DateTimePicker();
            this.btn_leave_month = new System.Windows.Forms.Button();
            this.btn_project = new System.Windows.Forms.Button();
            this.btn_employee = new System.Windows.Forms.Button();
            this.timer_emp_reg = new System.Windows.Forms.Timer(this.components);
            this.pnl_loadbar_01 = new System.Windows.Forms.Panel();
            this.pnl_load = new System.Windows.Forms.Panel();
            this.pnl_loadbar02 = new System.Windows.Forms.Panel();
            this.pnl_load02 = new System.Windows.Forms.Panel();
            this.timer_emp_leave_month = new System.Windows.Forms.Timer(this.components);
            this.timer_emp_assign = new System.Windows.Forms.Timer(this.components);
            this.pnl_loadbar03 = new System.Windows.Forms.Panel();
            this.pnl_load03 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emp_proj_assign)).BeginInit();
            this.pnl_project.SuspendLayout();
            this.pnl_emp_leave_view.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_leave)).BeginInit();
            this.pnl_emp_reg.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emp_reg)).BeginInit();
            this.pnl_loadbar_01.SuspendLayout();
            this.pnl_loadbar02.SuspendLayout();
            this.pnl_loadbar03.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.dgv_emp_proj_assign);
            this.panel1.Location = new System.Drawing.Point(25, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 696);
            this.panel1.TabIndex = 34;
            // 
            // dgv_emp_proj_assign
            // 
            this.dgv_emp_proj_assign.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.dgv_emp_proj_assign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_emp_proj_assign.Location = new System.Drawing.Point(13, 16);
            this.dgv_emp_proj_assign.Name = "dgv_emp_proj_assign";
            this.dgv_emp_proj_assign.ReadOnly = true;
            this.dgv_emp_proj_assign.RowTemplate.Height = 24;
            this.dgv_emp_proj_assign.Size = new System.Drawing.Size(976, 662);
            this.dgv_emp_proj_assign.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(2, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 51);
            this.label3.TabIndex = 35;
            this.label3.Text = "Reports";
            // 
            // cmb_prj
            // 
            this.cmb_prj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.cmb_prj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_prj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_prj.ForeColor = System.Drawing.Color.White;
            this.cmb_prj.FormattingEnabled = true;
            this.cmb_prj.Location = new System.Drawing.Point(133, 78);
            this.cmb_prj.Name = "cmb_prj";
            this.cmb_prj.Size = new System.Drawing.Size(279, 28);
            this.cmb_prj.TabIndex = 36;
            this.cmb_prj.SelectedIndexChanged += new System.EventHandler(this.cmb_prj_SelectedIndexChanged);
            // 
            // cmb_job
            // 
            this.cmb_job.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.cmb_job.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_job.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_job.ForeColor = System.Drawing.Color.White;
            this.cmb_job.FormattingEnabled = true;
            this.cmb_job.Items.AddRange(new object[] {
            "Qc",
            "Supervisor",
            "Labour",
            "Driver"});
            this.cmb_job.Location = new System.Drawing.Point(615, 78);
            this.cmb_job.Name = "cmb_job";
            this.cmb_job.Size = new System.Drawing.Size(279, 28);
            this.cmb_job.TabIndex = 36;
            this.cmb_job.SelectedIndexChanged += new System.EventHandler(this.cmb_job_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 10.8F);
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(28, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 25);
            this.label12.TabIndex = 13;
            this.label12.Text = "Projects";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.8F);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(473, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Job Category";
            // 
            // pnl_project
            // 
            this.pnl_project.Controls.Add(this.pnl_loadbar03);
            this.pnl_project.Controls.Add(this.btn_export03);
            this.pnl_project.Controls.Add(this.panel1);
            this.pnl_project.Controls.Add(this.label1);
            this.pnl_project.Controls.Add(this.label4);
            this.pnl_project.Controls.Add(this.cmb_prj);
            this.pnl_project.Controls.Add(this.label12);
            this.pnl_project.Controls.Add(this.cmb_job);
            this.pnl_project.Location = new System.Drawing.Point(23, 88);
            this.pnl_project.Name = "pnl_project";
            this.pnl_project.Size = new System.Drawing.Size(1058, 895);
            this.pnl_project.TabIndex = 37;
            // 
            // btn_export03
            // 
            this.btn_export03.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(32)))), ((int)(((byte)(203)))));
            this.btn_export03.FlatAppearance.BorderSize = 0;
            this.btn_export03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export03.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export03.ForeColor = System.Drawing.Color.White;
            this.btn_export03.Location = new System.Drawing.Point(25, 835);
            this.btn_export03.Name = "btn_export03";
            this.btn_export03.Size = new System.Drawing.Size(172, 44);
            this.btn_export03.TabIndex = 37;
            this.btn_export03.Text = "Export";
            this.btn_export03.UseVisualStyleBackColor = false;
            this.btn_export03.Click += new System.EventHandler(this.btn_export03_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label4.Location = new System.Drawing.Point(3, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(360, 35);
            this.label4.TabIndex = 35;
            this.label4.Text = "View Employee Assign projects";
            // 
            // pnl_emp_leave_view
            // 
            this.pnl_emp_leave_view.Controls.Add(this.pnl_loadbar02);
            this.pnl_emp_leave_view.Controls.Add(this.btn_export02);
            this.pnl_emp_leave_view.Controls.Add(this.month_start_leave);
            this.pnl_emp_leave_view.Controls.Add(this.label2);
            this.pnl_emp_leave_view.Controls.Add(this.label5);
            this.pnl_emp_leave_view.Controls.Add(this.panel3);
            this.pnl_emp_leave_view.Controls.Add(this.month_end_leave);
            this.pnl_emp_leave_view.Location = new System.Drawing.Point(22, 88);
            this.pnl_emp_leave_view.Name = "pnl_emp_leave_view";
            this.pnl_emp_leave_view.Size = new System.Drawing.Size(1058, 895);
            this.pnl_emp_leave_view.TabIndex = 38;
            // 
            // btn_export02
            // 
            this.btn_export02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(32)))), ((int)(((byte)(203)))));
            this.btn_export02.FlatAppearance.BorderSize = 0;
            this.btn_export02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export02.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export02.ForeColor = System.Drawing.Color.White;
            this.btn_export02.Location = new System.Drawing.Point(25, 836);
            this.btn_export02.Name = "btn_export02";
            this.btn_export02.Size = new System.Drawing.Size(172, 44);
            this.btn_export02.TabIndex = 43;
            this.btn_export02.Text = "Export";
            this.btn_export02.UseVisualStyleBackColor = false;
            this.btn_export02.Click += new System.EventHandler(this.btn_export02_Click);
            // 
            // month_start_leave
            // 
            this.month_start_leave.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.month_start_leave.CalendarMonthBackground = System.Drawing.Color.White;
            this.month_start_leave.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.month_start_leave.CustomFormat = "yyyy-MM-dd";
            this.month_start_leave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month_start_leave.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.month_start_leave.Location = new System.Drawing.Point(133, 78);
            this.month_start_leave.Name = "month_start_leave";
            this.month_start_leave.Size = new System.Drawing.Size(389, 27);
            this.month_start_leave.TabIndex = 41;
            this.month_start_leave.ValueChanged += new System.EventHandler(this.month_start_leave_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.8F);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(28, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Months";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label5.Location = new System.Drawing.Point(3, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(363, 35);
            this.label5.TabIndex = 35;
            this.label5.Text = "View Employee Leaves Motnhly";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.dgv_leave);
            this.panel3.Location = new System.Drawing.Point(25, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1004, 696);
            this.panel3.TabIndex = 40;
            // 
            // dgv_leave
            // 
            this.dgv_leave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.dgv_leave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_leave.Location = new System.Drawing.Point(13, 16);
            this.dgv_leave.Name = "dgv_leave";
            this.dgv_leave.ReadOnly = true;
            this.dgv_leave.RowTemplate.Height = 24;
            this.dgv_leave.Size = new System.Drawing.Size(976, 662);
            this.dgv_leave.TabIndex = 1;
            // 
            // month_end_leave
            // 
            this.month_end_leave.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.month_end_leave.CalendarMonthBackground = System.Drawing.Color.White;
            this.month_end_leave.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.month_end_leave.CustomFormat = "yyyy-MM-dd";
            this.month_end_leave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month_end_leave.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.month_end_leave.Location = new System.Drawing.Point(585, 78);
            this.month_end_leave.Name = "month_end_leave";
            this.month_end_leave.Size = new System.Drawing.Size(389, 27);
            this.month_end_leave.TabIndex = 42;
            this.month_end_leave.ValueChanged += new System.EventHandler(this.month_end_leave_ValueChanged);
            // 
            // pnl_emp_reg
            // 
            this.pnl_emp_reg.Controls.Add(this.pnl_loadbar_01);
            this.pnl_emp_reg.Controls.Add(this.btn_export01);
            this.pnl_emp_reg.Controls.Add(this.month_start_empReg);
            this.pnl_emp_reg.Controls.Add(this.label6);
            this.pnl_emp_reg.Controls.Add(this.label7);
            this.pnl_emp_reg.Controls.Add(this.panel4);
            this.pnl_emp_reg.Controls.Add(this.month_end_empReg);
            this.pnl_emp_reg.Location = new System.Drawing.Point(22, 88);
            this.pnl_emp_reg.Name = "pnl_emp_reg";
            this.pnl_emp_reg.Size = new System.Drawing.Size(1058, 895);
            this.pnl_emp_reg.TabIndex = 38;
            // 
            // btn_export01
            // 
            this.btn_export01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(32)))), ((int)(((byte)(203)))));
            this.btn_export01.FlatAppearance.BorderSize = 0;
            this.btn_export01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export01.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export01.ForeColor = System.Drawing.Color.White;
            this.btn_export01.Location = new System.Drawing.Point(25, 836);
            this.btn_export01.Name = "btn_export01";
            this.btn_export01.Size = new System.Drawing.Size(172, 44);
            this.btn_export01.TabIndex = 43;
            this.btn_export01.Text = "Export";
            this.btn_export01.UseVisualStyleBackColor = false;
            this.btn_export01.Click += new System.EventHandler(this.btn_export01_Click);
            // 
            // month_start_empReg
            // 
            this.month_start_empReg.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.month_start_empReg.CalendarMonthBackground = System.Drawing.Color.White;
            this.month_start_empReg.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.month_start_empReg.CustomFormat = "yyyy-MM-dd";
            this.month_start_empReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month_start_empReg.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.month_start_empReg.Location = new System.Drawing.Point(133, 78);
            this.month_start_empReg.Name = "month_start_empReg";
            this.month_start_empReg.Size = new System.Drawing.Size(389, 27);
            this.month_start_empReg.TabIndex = 41;
            this.month_start_empReg.ValueChanged += new System.EventHandler(this.month_start_empReg_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 10.8F);
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(28, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 25);
            this.label6.TabIndex = 39;
            this.label6.Text = "Months";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label7.Location = new System.Drawing.Point(3, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(407, 35);
            this.label7.TabIndex = 35;
            this.label7.Text = "View Employee Montly Registration";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.dgv_emp_reg);
            this.panel4.Location = new System.Drawing.Point(25, 120);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1004, 696);
            this.panel4.TabIndex = 40;
            // 
            // dgv_emp_reg
            // 
            this.dgv_emp_reg.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.dgv_emp_reg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_emp_reg.Location = new System.Drawing.Point(13, 16);
            this.dgv_emp_reg.Name = "dgv_emp_reg";
            this.dgv_emp_reg.ReadOnly = true;
            this.dgv_emp_reg.RowTemplate.Height = 24;
            this.dgv_emp_reg.Size = new System.Drawing.Size(976, 662);
            this.dgv_emp_reg.TabIndex = 1;
            // 
            // month_end_empReg
            // 
            this.month_end_empReg.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.month_end_empReg.CalendarMonthBackground = System.Drawing.Color.White;
            this.month_end_empReg.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.month_end_empReg.CustomFormat = "yyyy-MM-dd";
            this.month_end_empReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month_end_empReg.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.month_end_empReg.Location = new System.Drawing.Point(585, 78);
            this.month_end_empReg.Name = "month_end_empReg";
            this.month_end_empReg.Size = new System.Drawing.Size(389, 27);
            this.month_end_empReg.TabIndex = 42;
            this.month_end_empReg.ValueChanged += new System.EventHandler(this.month_end_empReg_ValueChanged);
            // 
            // btn_leave_month
            // 
            this.btn_leave_month.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.btn_leave_month.FlatAppearance.BorderSize = 0;
            this.btn_leave_month.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_leave_month.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.btn_leave_month.ForeColor = System.Drawing.Color.White;
            this.btn_leave_month.Location = new System.Drawing.Point(1146, 224);
            this.btn_leave_month.Name = "btn_leave_month";
            this.btn_leave_month.Size = new System.Drawing.Size(454, 86);
            this.btn_leave_month.TabIndex = 39;
            this.btn_leave_month.Text = "Leaves";
            this.btn_leave_month.UseVisualStyleBackColor = false;
            this.btn_leave_month.Click += new System.EventHandler(this.btn_leave_month_Click);
            this.btn_leave_month.Leave += new System.EventHandler(this.btn_leave_month_Leave);
            // 
            // btn_project
            // 
            this.btn_project.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.btn_project.FlatAppearance.BorderSize = 0;
            this.btn_project.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_project.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.btn_project.ForeColor = System.Drawing.Color.White;
            this.btn_project.Location = new System.Drawing.Point(1146, 329);
            this.btn_project.Name = "btn_project";
            this.btn_project.Size = new System.Drawing.Size(454, 86);
            this.btn_project.TabIndex = 39;
            this.btn_project.Text = "Projects";
            this.btn_project.UseVisualStyleBackColor = false;
            this.btn_project.Click += new System.EventHandler(this.btn_project_Click);
            this.btn_project.Leave += new System.EventHandler(this.btn_project_Leave);
            // 
            // btn_employee
            // 
            this.btn_employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.btn_employee.FlatAppearance.BorderSize = 0;
            this.btn_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_employee.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.btn_employee.ForeColor = System.Drawing.Color.White;
            this.btn_employee.Location = new System.Drawing.Point(1146, 433);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Size = new System.Drawing.Size(454, 86);
            this.btn_employee.TabIndex = 39;
            this.btn_employee.Text = "Employee ";
            this.btn_employee.UseVisualStyleBackColor = false;
            this.btn_employee.Click += new System.EventHandler(this.btn_employee_Click);
            this.btn_employee.Leave += new System.EventHandler(this.btn_employee_Leave);
            // 
            // timer_emp_reg
            // 
            this.timer_emp_reg.Tick += new System.EventHandler(this.timer_emp_reg_Tick);
            // 
            // pnl_loadbar_01
            // 
            this.pnl_loadbar_01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnl_loadbar_01.Controls.Add(this.pnl_load);
            this.pnl_loadbar_01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.pnl_loadbar_01.Location = new System.Drawing.Point(216, 844);
            this.pnl_loadbar_01.Name = "pnl_loadbar_01";
            this.pnl_loadbar_01.Size = new System.Drawing.Size(813, 22);
            this.pnl_loadbar_01.TabIndex = 45;
            // 
            // pnl_load
            // 
            this.pnl_load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(205)))), ((int)(((byte)(46)))));
            this.pnl_load.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.pnl_load.Location = new System.Drawing.Point(1, 1);
            this.pnl_load.Name = "pnl_load";
            this.pnl_load.Size = new System.Drawing.Size(52, 21);
            this.pnl_load.TabIndex = 1;
            // 
            // pnl_loadbar02
            // 
            this.pnl_loadbar02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnl_loadbar02.Controls.Add(this.pnl_load02);
            this.pnl_loadbar02.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.pnl_loadbar02.Location = new System.Drawing.Point(216, 844);
            this.pnl_loadbar02.Name = "pnl_loadbar02";
            this.pnl_loadbar02.Size = new System.Drawing.Size(813, 22);
            this.pnl_loadbar02.TabIndex = 46;
            // 
            // pnl_load02
            // 
            this.pnl_load02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(205)))), ((int)(((byte)(46)))));
            this.pnl_load02.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.pnl_load02.Location = new System.Drawing.Point(1, 1);
            this.pnl_load02.Name = "pnl_load02";
            this.pnl_load02.Size = new System.Drawing.Size(52, 21);
            this.pnl_load02.TabIndex = 1;
            // 
            // timer_emp_leave_month
            // 
            this.timer_emp_leave_month.Tick += new System.EventHandler(this.timer_emp_leave_month_Tick);
            // 
            // timer_emp_assign
            // 
            this.timer_emp_assign.Tick += new System.EventHandler(this.timer_emp_assign_Tick);
            // 
            // pnl_loadbar03
            // 
            this.pnl_loadbar03.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnl_loadbar03.Controls.Add(this.pnl_load03);
            this.pnl_loadbar03.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.pnl_loadbar03.Location = new System.Drawing.Point(216, 844);
            this.pnl_loadbar03.Name = "pnl_loadbar03";
            this.pnl_loadbar03.Size = new System.Drawing.Size(813, 22);
            this.pnl_loadbar03.TabIndex = 46;
            // 
            // pnl_load03
            // 
            this.pnl_load03.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(205)))), ((int)(((byte)(46)))));
            this.pnl_load03.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.pnl_load03.Location = new System.Drawing.Point(1, 1);
            this.pnl_load03.Name = "pnl_load03";
            this.pnl_load03.Size = new System.Drawing.Size(52, 21);
            this.pnl_load03.TabIndex = 1;
            // 
            // usrReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.btn_employee);
            this.Controls.Add(this.pnl_emp_reg);
            this.Controls.Add(this.pnl_emp_leave_view);
            this.Controls.Add(this.btn_project);
            this.Controls.Add(this.btn_leave_month);
            this.Controls.Add(this.pnl_project);
            this.Controls.Add(this.label3);
            this.Name = "usrReports";
            this.Size = new System.Drawing.Size(1641, 1000);
            this.Load += new System.EventHandler(this.usrReports_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emp_proj_assign)).EndInit();
            this.pnl_project.ResumeLayout(false);
            this.pnl_project.PerformLayout();
            this.pnl_emp_leave_view.ResumeLayout(false);
            this.pnl_emp_leave_view.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_leave)).EndInit();
            this.pnl_emp_reg.ResumeLayout(false);
            this.pnl_emp_reg.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emp_reg)).EndInit();
            this.pnl_loadbar_01.ResumeLayout(false);
            this.pnl_loadbar02.ResumeLayout(false);
            this.pnl_loadbar03.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_prj;
        private System.Windows.Forms.ComboBox cmb_job;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_emp_proj_assign;
        private System.Windows.Forms.Panel pnl_project;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnl_emp_leave_view;
        private System.Windows.Forms.DateTimePicker month_start_leave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_leave;
        private System.Windows.Forms.DateTimePicker month_end_leave;
        private System.Windows.Forms.Panel pnl_emp_reg;
        private System.Windows.Forms.DateTimePicker month_start_empReg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgv_emp_reg;
        private System.Windows.Forms.DateTimePicker month_end_empReg;
        private System.Windows.Forms.Button btn_leave_month;
        private System.Windows.Forms.Button btn_project;
        private System.Windows.Forms.Button btn_employee;
        private System.Windows.Forms.Button btn_export03;
        private System.Windows.Forms.Button btn_export02;
        private System.Windows.Forms.Button btn_export01;
        private System.Windows.Forms.Timer timer_emp_reg;
        private System.Windows.Forms.Panel pnl_loadbar_01;
        private System.Windows.Forms.Panel pnl_load;
        private System.Windows.Forms.Panel pnl_loadbar02;
        private System.Windows.Forms.Panel pnl_load02;
        private System.Windows.Forms.Timer timer_emp_leave_month;
        private System.Windows.Forms.Timer timer_emp_assign;
        private System.Windows.Forms.Panel pnl_loadbar03;
        private System.Windows.Forms.Panel pnl_load03;
    }
}
