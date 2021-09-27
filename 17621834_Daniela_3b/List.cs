using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace _17621834_Daniela_3b
{
    public partial class List : UserControl
    {
        public List()
        {
            InitializeComponent();
        }

       
        public void show() {
            show_list.Rows.Clear();

            String query = "Select movie.movie_id, movie_name, genre_name from favorite " +
                "join movie on movie.movie_id = favorite.movie_id " +
                "join genre on genre.genre_id = movie.genre_id " +
                "join users on users.user_id = favorite.user_id " +
                "where user_name ='" + Login.user.username + "'; ";

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
                            while (result.Read())
                            {
                                string[] list = {
                                result["movie_id"].ToString(),
                                result["movie_name"].ToString(),
                                result["genre_name"].ToString()
                            };
                                show_list.Rows.Add(list);
                            }
                        }
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message.ToString() + "\n" + exp.StackTrace.ToString());
                }
            }
        }
        

        private void delete_row_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.show_list.SelectedRows)
            {
                using (SQLiteConnection con = new SQLiteConnection("Data Source=C:\\users\\danny\\desktop\\test.db;Version=3;"))
                {
                    int id = Convert.ToInt32(show_list.SelectedRows[0].Cells[0].Value);

                    String query = "Delete from favorite where movie_id='" + id + "'";

                    SQLiteCommand command = new SQLiteCommand(query, con);
                    
                    show_list.Rows.RemoveAt(this.show_list.SelectedRows[0].Index);
                    con.Open();
                    int result = command.ExecuteNonQuery();

                    if(result > 0)
                    {
                        MessageBox.Show("You delete it from your favorites!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

            }
        }
    }
}
