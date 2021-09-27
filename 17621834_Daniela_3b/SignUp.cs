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
    public partial class SignUp : Form
    {

        public SignUp()
        {
            InitializeComponent();
        }
        

        private void btn_create_Click(object sender, EventArgs e)
        {
            String username = tb_username.Text;
            String pass = tb_pass.Text;
            String pass_conf = tb_pass_conf.Text;
            
            if (pass == pass_conf)
            {
                String query = "Insert into users(user_name, user_pass) VALUES (@user_name,@user_pass); ";
                using (SQLiteConnection con = new SQLiteConnection("Data Source=C:\\users\\danny\\desktop\\test.db;Version=3;"))
                {
                    try
                    {
                        con.Open();
                        using (SQLiteCommand command = new SQLiteCommand(query, con))
                        {
                            command.Parameters.AddWithValue("@user_name", username);
                            command.Parameters.AddWithValue("@user_pass", pass);

                            int result = command.ExecuteNonQuery();

                            // Check Error
                            if (result < 0)
                                MessageBox.Show("Error");

                            MessageBox.Show("New account created!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please make sure your passwords match!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_pass.Text = "";
                tb_pass_conf.Text = "";
            }
        }
    }
}
