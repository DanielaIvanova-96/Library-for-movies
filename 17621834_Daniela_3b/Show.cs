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
using System.Globalization;

namespace _17621834_Daniela_3b
{
    public partial class Show : Form
    {
        public Show()
        {
            InitializeComponent();
        }

        private void btn_sh_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Friends fr = new Friends();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GoT got = new GoT();
            got.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lucifer luc = new Lucifer();
            luc.Show();
        }

        private void btn_fr_Click(object sender, EventArgs e)
        {
            bool exist = false;

            String title = lb_fr.Text;

            long user_id = Movie.return_user_id();
            int movie_id = Movie.return_movie_id(title);

            String qu = "Select * from favorite where user_id = " + user_id + " and movie_id = " + movie_id + ";";

            using (SQLiteConnection con = new SQLiteConnection("Data Source=C:\\users\\danny\\desktop\\test.db;Version=3;"))
            {
                try
                {
                    con.Open();
                    using (SQLiteCommand command = new SQLiteCommand(qu, con))
                    {
                        SQLiteDataReader rd = command.ExecuteReader();

                        if (rd.HasRows)
                        {
                            exist = true;
                            MessageBox.Show("You alredy has this movie/tv show in your favorites!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            rd.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString() + "\n" + ex.StackTrace.ToString());
                }
            }

            if (exist == false)
            {
                String query = "Insert into favorite(user_id, movie_id) values(" + user_id + ", " + movie_id + ");";

                using (SQLiteConnection con = new SQLiteConnection("Data Source=C:\\users\\danny\\desktop\\test.db;Version=3;"))
                {

                    try
                    {
                        con.Open();
                        using (SQLiteCommand command = new SQLiteCommand(query, con))
                        {
                            int row = command.ExecuteNonQuery();

                            if (row < 0)
                                MessageBox.Show("Error");

                            MessageBox.Show("Successfull added!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + "\n" + ex.StackTrace.ToString());
                    }
                }
            }
        }

        private void btn_got_Click(object sender, EventArgs e)
        {
            bool exist = false;

            String title = lb_got.Text;
            
            long user_id = Movie.return_user_id();
            int movie_id = Movie.return_movie_id(title);

            String qu = "Select * from favorite where user_id = " + user_id + " and movie_id = " + movie_id + ";";

            using (SQLiteConnection con = new SQLiteConnection("Data Source=C:\\users\\danny\\desktop\\test.db;Version=3;"))
            {
                try
                {
                    con.Open();
                    using (SQLiteCommand command = new SQLiteCommand(qu, con))
                    {
                        SQLiteDataReader rd = command.ExecuteReader();

                        if (rd.HasRows)
                        {
                            exist = true;
                            MessageBox.Show("You alredy has this movie/tv show in your favorites!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            rd.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString() + "\n" + ex.StackTrace.ToString());
                }
            }

            if (exist == false)
            {
                String query = "Insert into favorite(user_id, movie_id) values(" + user_id + ", " + movie_id + ");";

                using (SQLiteConnection con = new SQLiteConnection("Data Source=C:\\users\\danny\\desktop\\test.db;Version=3;"))
                {

                    try
                    {
                        con.Open();
                        using (SQLiteCommand command = new SQLiteCommand(query, con))
                        {
                            int row = command.ExecuteNonQuery();

                            if (row < 0)
                                MessageBox.Show("Error");

                            MessageBox.Show("Successfull added!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + "\n" + ex.StackTrace.ToString());
                    }
                }
            }
        }

        private void btn_luc_Click(object sender, EventArgs e)
        {
            bool exist = false;

            String title = lb_luc.Text;
            
            long user_id = Movie.return_user_id();
            int movie_id = Movie.return_movie_id(title);

            String qu = "Select * from favorite where user_id = " + user_id + " and movie_id = " + movie_id + ";";

            using (SQLiteConnection con = new SQLiteConnection("Data Source=C:\\users\\danny\\desktop\\test.db;Version=3;"))
            {
                try
                {
                    con.Open();
                    using (SQLiteCommand command = new SQLiteCommand(qu, con))
                    {
                        SQLiteDataReader rd = command.ExecuteReader();

                        if (rd.HasRows)
                        {
                            exist = true;
                            MessageBox.Show("You alredy has this movie/tv show in your favorites!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            rd.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString() + "\n" + ex.StackTrace.ToString());
                }
            }

            if (exist == false)
            {
                String query = "Insert into favorite(user_id, movie_id) values(" + user_id + ", " + movie_id + ");";

                using (SQLiteConnection con = new SQLiteConnection("Data Source=C:\\users\\danny\\desktop\\test.db;Version=3;"))
                {

                    try
                    {
                        con.Open();
                        using (SQLiteCommand command = new SQLiteCommand(query, con))
                        {
                            int row = command.ExecuteNonQuery();

                            if (row < 0)
                                MessageBox.Show("Error");

                            MessageBox.Show("Successfull added!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + "\n" + ex.StackTrace.ToString());
                    }
                }
            }
        }
    }
}
