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
    public partial class Login : Form
    {
        public static User user = new User();

        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            String username = tb_log_user.Text;
            String pass = tb_log_pass.Text;
            
           
            String query = "Select * from users where user_name= '" + username + "' and user_pass='" + pass + "'; ";

            using (SQLiteConnection con = new SQLiteConnection("Data Source=C:\\users\\danny\\desktop\\test.db;Version=3;"))
            {
                try
                {
                    con.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, con))
                    {
                        SQLiteDataReader result = command.ExecuteReader();
                        
                        if (result.HasRows)
                        {
                            user.username = username;
                            result.Close();
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Wrong username or password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tb_log_user.Clear();
                            tb_log_pass.Clear();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
