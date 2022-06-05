namespace Final_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_Name = new System.Windows.Forms.Label();
            this.llbl_Password = new System.Windows.Forms.Label();
            this.txt_NameLogin = new System.Windows.Forms.TextBox();
            this.txt_PasswordLogin = new System.Windows.Forms.TextBox();
            this.pnl_login = new System.Windows.Forms.Panel();
            this.lbl_img = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_enter = new System.Windows.Forms.Button();
            this.pnl_signup = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_passwordSignup = new System.Windows.Forms.TextBox();
            this.txt_NameSignup = new System.Windows.Forms.TextBox();
            this.lbl_passwordSignup = new System.Windows.Forms.Label();
            this.lbl_nameSIGN = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Signup = new System.Windows.Forms.Label();
            this.btn_title = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_signup = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_home = new System.Windows.Forms.Panel();
            this.pnl_login.SuspendLayout();
            this.pnl_signup.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(222)))), ((int)(((byte)(145)))));
            this.lbl_Name.Location = new System.Drawing.Point(20, 83);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(68, 28);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name";
            // 
            // llbl_Password
            // 
            this.llbl_Password.AutoSize = true;
            this.llbl_Password.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.llbl_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(222)))), ((int)(((byte)(145)))));
            this.llbl_Password.Location = new System.Drawing.Point(20, 119);
            this.llbl_Password.Name = "llbl_Password";
            this.llbl_Password.Size = new System.Drawing.Size(101, 28);
            this.llbl_Password.TabIndex = 1;
            this.llbl_Password.Text = "Password";
            // 
            // txt_NameLogin
            // 
            this.txt_NameLogin.Location = new System.Drawing.Point(133, 83);
            this.txt_NameLogin.Name = "txt_NameLogin";
            this.txt_NameLogin.Size = new System.Drawing.Size(100, 23);
            this.txt_NameLogin.TabIndex = 2;
            // 
            // txt_PasswordLogin
            // 
            this.txt_PasswordLogin.Location = new System.Drawing.Point(133, 119);
            this.txt_PasswordLogin.Name = "txt_PasswordLogin";
            this.txt_PasswordLogin.PasswordChar = '●';
            this.txt_PasswordLogin.Size = new System.Drawing.Size(100, 23);
            this.txt_PasswordLogin.TabIndex = 3;
            // 
            // pnl_login
            // 
            this.pnl_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnl_login.Controls.Add(this.lbl_img);
            this.pnl_login.Controls.Add(this.label1);
            this.pnl_login.Controls.Add(this.btn_enter);
            this.pnl_login.Controls.Add(this.txt_NameLogin);
            this.pnl_login.Controls.Add(this.lbl_Name);
            this.pnl_login.Controls.Add(this.txt_PasswordLogin);
            this.pnl_login.Controls.Add(this.llbl_Password);
            this.pnl_login.Location = new System.Drawing.Point(203, 425);
            this.pnl_login.Name = "pnl_login";
            this.pnl_login.Size = new System.Drawing.Size(267, 236);
            this.pnl_login.TabIndex = 5;
            this.pnl_login.Visible = false;
            // 
            // lbl_img
            // 
            this.lbl_img.AutoSize = true;
            this.lbl_img.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_img.Image = global::Final_Project.Properties.Resources.medical_staff__1_;
            this.lbl_img.Location = new System.Drawing.Point(153, 9);
            this.lbl_img.Name = "lbl_img";
            this.lbl_img.Size = new System.Drawing.Size(100, 54);
            this.lbl_img.TabIndex = 6;
            this.lbl_img.Text = "       ";
            this.lbl_img.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_img.Click += new System.EventHandler(this.lbl_img_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Aharoni", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(222)))), ((int)(((byte)(145)))));
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Log In";
            // 
            // btn_enter
            // 
            this.btn_enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enter.Font = new System.Drawing.Font("Aharoni", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_enter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(222)))), ((int)(((byte)(145)))));
            this.btn_enter.Location = new System.Drawing.Point(70, 179);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(163, 45);
            this.btn_enter.TabIndex = 4;
            this.btn_enter.Text = "ENTER";
            this.btn_enter.UseVisualStyleBackColor = false;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // pnl_signup
            // 
            this.pnl_signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnl_signup.Controls.Add(this.label8);
            this.pnl_signup.Controls.Add(this.label7);
            this.pnl_signup.Controls.Add(this.txt_ID);
            this.pnl_signup.Controls.Add(this.label3);
            this.pnl_signup.Controls.Add(this.button1);
            this.pnl_signup.Controls.Add(this.txt_passwordSignup);
            this.pnl_signup.Controls.Add(this.txt_NameSignup);
            this.pnl_signup.Controls.Add(this.lbl_passwordSignup);
            this.pnl_signup.Controls.Add(this.lbl_nameSIGN);
            this.pnl_signup.Controls.Add(this.label2);
            this.pnl_signup.Controls.Add(this.lbl_Signup);
            this.pnl_signup.Location = new System.Drawing.Point(638, 86);
            this.pnl_signup.Name = "pnl_signup";
            this.pnl_signup.Size = new System.Drawing.Size(390, 302);
            this.pnl_signup.TabIndex = 6;
            this.pnl_signup.Visible = false;
            this.pnl_signup.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(220, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 45);
            this.label8.TabIndex = 10;
            this.label8.Text = "            8-10 chars\r\n       most to consider\r\nlatter ,digit and spaical char";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(226, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 45);
            this.label7.TabIndex = 9;
            this.label7.Text = "        8-6 chars\r\n    all most 2 digits\r\nall the rest are letters";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(120, 206);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 23);
            this.txt_ID.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(2, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID Number";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Aharoni", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Location = new System.Drawing.Point(101, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "ENTER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_passwordSignup
            // 
            this.txt_passwordSignup.Location = new System.Drawing.Point(120, 147);
            this.txt_passwordSignup.Name = "txt_passwordSignup";
            this.txt_passwordSignup.Size = new System.Drawing.Size(100, 23);
            this.txt_passwordSignup.TabIndex = 5;
            // 
            // txt_NameSignup
            // 
            this.txt_NameSignup.Location = new System.Drawing.Point(120, 78);
            this.txt_NameSignup.Name = "txt_NameSignup";
            this.txt_NameSignup.Size = new System.Drawing.Size(100, 23);
            this.txt_NameSignup.TabIndex = 4;
            // 
            // lbl_passwordSignup
            // 
            this.lbl_passwordSignup.AutoSize = true;
            this.lbl_passwordSignup.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_passwordSignup.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_passwordSignup.Location = new System.Drawing.Point(6, 141);
            this.lbl_passwordSignup.Name = "lbl_passwordSignup";
            this.lbl_passwordSignup.Size = new System.Drawing.Size(101, 28);
            this.lbl_passwordSignup.TabIndex = 3;
            this.lbl_passwordSignup.Text = "Password";
            // 
            // lbl_nameSIGN
            // 
            this.lbl_nameSIGN.AutoSize = true;
            this.lbl_nameSIGN.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_nameSIGN.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_nameSIGN.Location = new System.Drawing.Point(1, 73);
            this.lbl_nameSIGN.Name = "lbl_nameSIGN";
            this.lbl_nameSIGN.Size = new System.Drawing.Size(116, 28);
            this.lbl_nameSIGN.TabIndex = 2;
            this.lbl_nameSIGN.Text = "User Name";
            this.lbl_nameSIGN.Click += new System.EventHandler(this.lbl_nameSIGN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Image = global::Final_Project.Properties.Resources.medical_staff__1_1;
            this.label2.Location = new System.Drawing.Point(270, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "  ";
            // 
            // lbl_Signup
            // 
            this.lbl_Signup.AutoEllipsis = true;
            this.lbl_Signup.AutoSize = true;
            this.lbl_Signup.Font = new System.Drawing.Font("Aharoni", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Signup.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_Signup.Location = new System.Drawing.Point(100, 17);
            this.lbl_Signup.Name = "lbl_Signup";
            this.lbl_Signup.Size = new System.Drawing.Size(164, 39);
            this.lbl_Signup.TabIndex = 0;
            this.lbl_Signup.Text = "Sign Up";
            // 
            // btn_title
            // 
            this.btn_title.FlatAppearance.BorderSize = 0;
            this.btn_title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_title.Font = new System.Drawing.Font("Aharoni", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_title.ForeColor = System.Drawing.Color.White;
            this.btn_title.Location = new System.Drawing.Point(-37, 1);
            this.btn_title.Name = "btn_title";
            this.btn_title.Size = new System.Drawing.Size(361, 86);
            this.btn_title.TabIndex = 6;
            this.btn_title.Text = "Hospital";
            this.btn_title.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_title.UseVisualStyleBackColor = true;
            this.btn_title.Click += new System.EventHandler(this.btn_title_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btn_signup);
            this.panel1.Controls.Add(this.btn_Login);
            this.panel1.Controls.Add(this.btn_title);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 81);
            this.panel1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Image = global::Final_Project.Properties.Resources.medical_symbol__1_;
            this.label6.Location = new System.Drawing.Point(271, -6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 89);
            this.label6.TabIndex = 8;
            this.label6.Text = "  ";
            // 
            // btn_signup
            // 
            this.btn_signup.FlatAppearance.BorderSize = 0;
            this.btn_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signup.Font = new System.Drawing.Font("Aharoni", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_signup.ForeColor = System.Drawing.Color.White;
            this.btn_signup.Image = global::Final_Project.Properties.Resources.add_user__1___1_;
            this.btn_signup.Location = new System.Drawing.Point(518, 13);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(142, 63);
            this.btn_signup.TabIndex = 6;
            this.btn_signup.Text = "Sign Up";
            this.btn_signup.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click_1);
            // 
            // btn_Login
            // 
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Aharoni", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Image = global::Final_Project.Properties.Resources.user__1___1_1;
            this.btn_Login.Location = new System.Drawing.Point(672, 13);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(126, 61);
            this.btn_Login.TabIndex = 7;
            this.btn_Login.Text = "Log In";
            this.btn_Login.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 7;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pnl_home
            // 
            this.pnl_home.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_home.BackgroundImage")));
            this.pnl_home.Location = new System.Drawing.Point(0, 123);
            this.pnl_home.Name = "pnl_home";
            this.pnl_home.Size = new System.Drawing.Size(801, 296);
            this.pnl_home.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.pnl_login);
            this.Controls.Add(this.pnl_home);
            this.Controls.Add(this.pnl_signup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_login.ResumeLayout(false);
            this.pnl_login.PerformLayout();
            this.pnl_signup.ResumeLayout(false);
            this.pnl_signup.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Name;
        private Label llbl_Password;
        private TextBox txt_NameLogin;
        private TextBox txt_PasswordLogin;
        private Panel pnl_login;
        private Button btn_enter;
        private Label label1;
        private Label lbl_img;
        private Button btn_title;
        private Panel panel1;
        private Button btn_Login;
        private Button btn_signup;
        private Panel pnl_signup;
        private Label lbl_Signup;
        private Label label2;
        private Label lbl_nameSIGN;
        private Label lbl_passwordSignup;
        private Button button1;
        private TextBox txt_passwordSignup;
        private TextBox txt_NameSignup;
        private TextBox txt_ID;
        private Label label3;
        private Label label4;
        private Panel pnl_home;
        private Label label6;
        private Label label8;
        private Label label7;
    }
}