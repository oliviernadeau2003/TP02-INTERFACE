using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Printing.IndexedProperties;
using System.Text;
using System.Threading.Tasks;

namespace TP2.classes
{
    public class Group
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public List<int> Users { get; set; }
        public List<int> Admins { get; set; }
        public List<int> Events { get; set; }


        public void Create(int userId, string name, string description, string image = "")        // Image facultative ? Default ??
        {
            Name = name;
            Description = description;
            Image = image;
            Admins = new List<int>();
            Users = new List<int>();
            Events = new List<int>();
            Users.Add(userId);
            Admins.Add(userId);
        }

        public void AddUserToGroup(int userId)
        {
            if (!Users.Any(x => x == userId))
                Users.Add(userId);
        }

        public void Promote(int userIdToPromote)      // Comment on serait sensé valider avec le user ?
        {
            if (!Admins.Any(x => x == userIdToPromote))
                Admins.Add(userIdToPromote);
            //else
            //    return "User is already admin";
            //return "User Added";
        }

        public void CreateEvent(int userId,string titre,string description,DateTime date,DateTime duree, string adresse,string image,List<string> categories,int type)
        {
            if (Admins.Any(x => x == userId))
            {
                Event newEvent = new() { Titre = titre, Description=description,Date=date,Duree=duree,Adresse=adresse,Image=image,Categories=categories,Public=type };
                Events.Add(newEvent.Id);
            }
        }

    }
}
