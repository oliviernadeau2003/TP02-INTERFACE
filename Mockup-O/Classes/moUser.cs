using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.Mockup_O.Classes
{
    public class moUser
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string MailAddresse { get; set; }
        public List<int> FriendsIds { get; set; }
        public List<int> GamesList { get; set; }

        public override string ToString()
        {
            return Username;
        }
    }
}
