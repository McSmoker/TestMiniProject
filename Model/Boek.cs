using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Boek
    {
        private int id;

        public int Id;
        public string Auteur;
        public string Titel;

        private string BoekString;

        public Boek(int id,string auteur, string titel)
        {
            Id = id;
            Auteur = auteur;
            Titel = titel;
        }

        public string Tostring()
        {
            BoekString = Auteur;
            BoekString += Titel;
            BoekString += id;
            return BoekString;
        }
    }
}
