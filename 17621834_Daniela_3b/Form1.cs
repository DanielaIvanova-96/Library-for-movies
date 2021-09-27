using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace _17621834_Daniela_3b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            menu2.Hide();
            list1.Hide();
            btn_logout.Hide();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            list1.Hide();
            menu2.Show();
        }
        
        private void btn_signup_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            lb_user.Text = Login.user.username;
            
            btn_login.Enabled = false;
            btn_signup.Enabled = false;
            btn_logout.Show();
        }
        
        private void btn_favorite_Click(object sender, EventArgs e)
        {

            if(Login.user.username is null)
            {
                MessageBox.Show("Please login first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                menu2.Hide();
               
                list1.show();
                list1.Show();

            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login.user = new User();
            btn_login.Enabled = true;
            btn_signup.Enabled = true;
            btn_logout.Hide();
            lb_user.Text = "";

            menu2.Hide();
            list1.Hide();
        }
    }
}
