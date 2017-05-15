using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace TestMiniProject
{
    class Program
    {
        public static Boek Boek = new Boek(0, "George Orwell", "1984");
        public static Klant Klant = new Klant("Anne", "Vries", 0, "poep@poep.nl");
        public static Reservering Reservering = new Reservering(Klant, Boek, 0);
        static void Main(string[] args)
        {
            Console.WriteLine(Boek.Tostring());
            Console.WriteLine(Klant.Tostring());
            Console.WriteLine(Reservering.Tostring());
            Console.ReadKey();
        }
        
    }
}
