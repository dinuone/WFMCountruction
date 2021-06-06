namespace WFMcontruction
{
    partial class login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_login = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_clear = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_eye = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_hide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(245)))));
            this.label1.Location = new System.Drawing.Point(769, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 106);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(245)))));
            this.panel2.Location = new System.Drawing.Point(673, 407);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 4);
            this.panel2.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(245)))));
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Nirmala UI", 15.2F, System.Drawing.FontStyle.Bold);
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(771, 493);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(254, 56);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(245)))));
            this.panel1.Location = new System.Drawing.Point(673, 319);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 4);
            this.panel1.TabIndex = 3;
            // 
            // txt_clear
            // 
            this.txt_clear.AutoSize = true;
            this.txt_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_clear.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(245)))));
            this.txt_clear.Location = new System.Drawing.Point(1003, 432);
            this.txt_clear.Name = "txt_clear";
            this.txt_clear.Size = new System.Drawing.Size(140, 23);
            this.txt_clear.TabIndex = 5;
            this.txt_clear.Text = "Clear Text Fields";
            this.txt_clear.Click += new System.EventHandler(this.txt_clear_Click);
            this.txt_clear.MouseHover += new System.EventHandler(this.txt_clear_MouseHover);
            // 
            // txt_username
            // 
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(245)))));
            this.txt_username.Location = new System.Drawing.Point(721, 276);
            this.txt_username.Multiline = true;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(390, 43);
            this.txt_username.TabIndex = 6;
            // 
            // txt_password
            // 
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(245)))));
            this.txt_password.Location = new System.Drawing.Point(721, 363);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(390, 43);
            this.txt_password.TabIndex = 6;
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = global::WFMcontruction.Properties.Resources.icons8_close_window_48;
            this.btn_close.Location = new System.Drawing.Point(1101, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(52, 47);
            this.btn_close.TabIndex = 8;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_eye
            // 
            this.btn_eye.BackColor = System.Drawing.Color.White;
            this.btn_eye.FlatAppearance.BorderSize = 0;
            this.btn_eye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eye.Image = global::WFMcontruction.Properties.Resources.icons8_eye_24;
            this.btn_eye.Location = new System.Drawing.Point(1098, 363);
            this.btn_eye.Name = "btn_eye";
            this.btn_eye.Size = new System.Drawing.Size(36, 37);
            this.btn_eye.TabIndex = 7;
            this.btn_eye.UseVisualStyleBackColor = false;
            this.btn_eye.Click += new System.EventHandler(this.btn_eye_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WFMcontruction.Properties.Resources._lock;
            this.pictureBox3.Location = new System.Drawing.Point(671, 358);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WFMcontruction.Properties.Resources.profile_user;
            this.pictureBox2.Location = new System.Drawing.Point(671, 270);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::WFMcontruction.Properties.Resources.Untitled_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(635, 699);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_hide
            // 
            this.btn_hide.FlatAppearance.BorderSize = 0;
            this.btn_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hide.ForeColor = System.Drawing.Color.Black;
            this.btn_hide.Image = global::WFMcontruction.Properties.Resources.icons8_hide_24;
            this.btn_hide.Location = new System.Drawing.Point(1098, 363);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(36, 37);
            this.btn_hide.TabIndex = 9;
            this.btn_hide.UseVisualStyleBackColor = true;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1163, 699);
            this.Controls.Add(this.btn_hide);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_eye);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_clear);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txt_clear;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_eye;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_hide;
    }
}