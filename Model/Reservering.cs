using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Reservering
    {
        private int id;

        public Klant Klant;
        public Boek Boek;
        public int Id;
        public DateTime ReserveerDatumTijd;

        private string ReserveringString;

        public Reservering(Klant klant,Boek boek,int id)
        {
            Klant = klant;
            Boek = boek;
            Id = id;
        }
        public string Tostring()
        {
            ReserveringString = Klant.Tostring();
            ReserveringString += Boek.Tostring();
            ReserveringString += Id;

            return ReserveringString;
        }
    }
}
