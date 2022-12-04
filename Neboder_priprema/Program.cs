using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neboder_priprema
{
    class Neboder
    {
        private int visina;
        private int brojKatova;

        public int Visina { get => visina; set => visina = value; }
        public int BrojKatova { get => brojKatova; set => brojKatova = value; }

        public Neboder(int visina1, int brojKatova1) 
        {
            visina = visina1;
            brojKatova = brojKatova1;
        }
        public override string ToString()
        {
            return "Visina nebodera je " + (visina+10) + "m"
                + "\r\nNeboder ima " + (brojKatova+1)+ " katova" 
                + "\r\nProsjecna visina kata je "+ (visina/brojKatova) + "m";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Neboder Tower= new Neboder(200, 100);

            Console.WriteLine(Tower.ToString());

            Console.ReadKey();
        }
    }
}
