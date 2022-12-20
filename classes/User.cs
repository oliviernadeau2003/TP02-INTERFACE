using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.classes
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string MailAddress { get; set; }
        public string ProfilePicture { get; set; }

        public List<int> FriendsIds { get; set; }


        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

    }
}
