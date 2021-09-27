using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17621834_Daniela_3b
{
    public partial class menu : UserControl
    {
        public menu()
        {
            InitializeComponent();
        }
        
        private void btn_movies_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            movie.Show();
        }

        private void btn_shows_Click(object sender, EventArgs e)
        {
            Show show = new Show();
            show.Show();
        }
    }
}
