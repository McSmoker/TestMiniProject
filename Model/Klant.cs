using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Klant
    {
        private int id;

        public string Voornaam;
        public string Achternaam;
        public int Id;
        public string Emailadres;

        private string KlantString;

        public Klant(string voornaam,string achternaam,int id, string emailadres)
        {
            Voornaam = voornaam;
            Achternaam = achternaam;
            Id = id;
            Emailadres = emailadres;
        }

        public string Tostring()
        {
            KlantString = Voornaam;
            KlantString += Achternaam;
            KlantString += Id;
            KlantString += Emailadres;

            return KlantString;
        }
    }
}
