using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void lbl_img_Click(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void btn_Login_Click(object sender, EventArgs e)
        {

        }
        private void btn_title_Click(object sender, EventArgs e)
        {
           

        }
        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void lbl_nameSIGN_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void btn_Login_Click_1(object sender, EventArgs e)
        {
            pnl_home.Visible = false;
            pnl_signup.Visible = false;
            pnl_login.Visible = true;
            pnl_login.Location = new Point(260, 150);
        }

        private void btn_signup_Click_1(object sender, EventArgs e)
        {
            pnl_home.Visible = false;
            pnl_login.Visible=false;
            pnl_signup.Visible = true;
            pnl_signup.Location = new Point(200,120);
            

        }

        

        //to home page
        private void btn_title_Click_1(object sender, EventArgs e)
        {
            pnl_home.Visible = true;
            pnl_signup.Visible = false;
            pnl_login.Visible = false;
        }

        //Sign up botton $$
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ID.Text) || string.IsNullOrEmpty(txt_NameSignup.Text) ||  string.IsNullOrEmpty(txt_passwordSignup.Text))
            {
                MessageBox.Show("Please fill in all the details"); 
                clear_signup();
                return;
            }


            if (txt_ID.Text.All(char.IsDigit) && userNameCheck(txt_NameSignup.Text) && passwordCheck(txt_passwordSignup.Text))
                ReadWriteExcel.addDoctor(txt_NameSignup.Text, txt_ID.Text, txt_passwordSignup.Text);

            else          
                MessageBox.Show("Your details is Wrong,please try again");

            clear_signup();
        }

        //clear text box sign up
        public void clear_signup()
        {
            txt_ID.Clear();
            txt_NameSignup.Clear();
            txt_passwordSignup.Clear();
        }

        //clear text box log in
        public void clear_login()
        {
            txt_NameLogin.Clear();
            txt_PasswordLogin.Clear();
        }

        //counts the digit in string $$
        public int countDig(string word)
        {
            int digitsCount = 0;
            foreach (char c in word)
            {
                if (Char.IsDigit(c))
                    digitsCount++;
            }
            return digitsCount;
        }

        //check if user name is proper
        public Boolean userNameCheck(string word)
        {
            return (word.Length <= 8 && word.Length >= 6 && countDig(word) <= 2);
        }

        //check if password is proper $$
        public Boolean passwordCheck(string word)
        {
            if (word.Length > 10 || word.Length < 8)
                return false;

            string specialChar = "@|!#$%&/()=?»«@£§€{}.-;'<>_,";
            int digit = 0, latters = 0, speical = 0;

            foreach (char c in word)
            {
                if (Char.IsDigit(c))
                    digit++;

                if(Char.IsLetter(c))
                    latters++;

                if (specialChar.Contains(c))
                    speical++;
            }

            if (digit == 0 || latters == 0 || speical == 0)
                return false;

            return true;

        }

        //enter login botton $$
        private void btn_enter_Click(object sender, EventArgs e)
        {
            int UserName = ReadWriteExcel.searchUserName(txt_NameLogin.Text);
            //wrong user name
            if (UserName == -1)
            {
                MessageBox.Show("User name do not exist in the system");
                clear_login();
                return;
            }
            int Password = ReadWriteExcel.searchPassword(txt_PasswordLogin.Text);   

            if(UserName != Password)
            {
                MessageBox.Show("Username and password do not match");
                clear_login();
                return;
            }
            else
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();

            }


        }
    }
}