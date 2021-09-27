using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace _17621834_Daniela_3b
{
    public class User
    {
        public String id { get; set; }
        public String username { get; set; }
        public String password { get; set; }

        public User()
        {
        }

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
