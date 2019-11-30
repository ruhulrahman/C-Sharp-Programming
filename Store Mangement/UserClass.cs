using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Mangement
{
    class UserClass
    {
        private int id;
        private string name;
        private string userName;
        private string email;
        private string password;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
    }
}
