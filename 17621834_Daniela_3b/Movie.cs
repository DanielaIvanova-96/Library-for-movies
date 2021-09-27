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
    public partial class Movie : Form
    {
        public Movie()
        {
            InitializeComponent();
        }

        public static long return_user_id()
        {
            long user_id = 0;
            String query = "Select user_id from users where user_name = '" + Login.user.username + "'; ";
            using (SQLiteConnection con = new SQLiteConnection("Data Source=C:\\users\\danny\\desktop\\test.db;Version=3;"))
            {
                con.Open();
                
                SQLiteCommand command = new SQLiteCommand(query, con);
                SQLiteDataReader res = command.ExecuteReader();
                while (res.Read())
                {
                    user_id = (long)res["user_id"];
                }
                res.Close();
            }
            
            return user_id;
        }

        public static int return_movie_id(String movie)
        {
            int movie_id = 0;
            String query = "Select movie_id from movie where movie_name = '" + movie + "';";

            using (SQLiteConnection con = new SQLiteConnection("Data Source=C:\\users\\danny\\desktop\\test.db;Version=3;"))
            {
                con.Open();

                SQLiteCommand command = new SQLiteCommand(query, con);
                SQLiteDataReader res = command.ExecuteReader();
                while (res.Read())
                {
                    movie_id = (int)res["movie_id"];
                }
                res.Close();
            }
            return movie_id;
        }

        private void btn_mv_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btn_note_Click(object sender, EventArgs e)
        {
            bool exist = false;

            String title = lb_note.Text;

            long user_id = return_user_id();
            int movie_id = return_movie_id(title);

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

        private void btn_rm_not_Click(object sender, EventArgs e)
        {
            Notebook notebook = new Notebook();
            notebook.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GreenBook gb = new GreenBook();
            gb.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HarryPotter hp = new HarryPotter();
            hp.Show();
        }

        private void btn_gb_Click(object sender, EventArgs e)
        {
            bool exist = false;

            String title = lb_gb.Text;

            long user_id = return_user_id();
            int movie_id = return_movie_id(title);

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

        private void btn_hp_Click(object sender, EventArgs e)
        {
            bool exist = false;

            String title = lb_hp.Text;

            long user_id = return_user_id();
            int movie_id = return_movie_id(title);

            String qu = "Select * from favorite where user_id = " + user_id +" and movie_id = " + movie_id +";";

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
