using System;
using System.Collections.Generic;
using System.Linq;

namespace TP2.classes
{
    public class Event
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public DateTime Duree { get; set; }
        public string Adresse { get; set; }
        public string Image { get; set; }
        public List<string> Categories { get; set; }
        public int Public { get; set; }
        public List<int> Going { get; set; }

        public int nbrGoing { get { return Going.Count(); } }
        public List<int> Intrested { get; set; }
        public int nbrIntrested { get { return Intrested.Count(); } }

        //TODO : fonction qui crée un post special friend a crée lorsque que la classe post est uploader





    }
}
