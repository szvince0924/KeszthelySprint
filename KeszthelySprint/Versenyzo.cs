using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeszthelySprint
{
    internal class Versenyzo
    {
        public string nev { get; set; }
        public int szuletesiev { get; set; }
        public int rajtszam { get; set; }
        public string nem { get; set; }
        public string kategoria { get; set; }
        public string uszas { get; set; }

        public string depo  { get; set; }
        public string krekrkpar { get; set; }
        public string depo2 { get; set; }
        public string futas { get; set; }


        public Versenyzo(string sor)
        {
            string[] s = sor.Split(';');


            nev = s[0];
            szuletesiev =int.Parse (s[1]);
            rajtszam =int.Parse (s[2]);
            nem = s[3];
            kategoria = s[4];
            uszas = s[5];
            krekrkpar = s[6];
            depo2 = s[7];
            futas = s[8];
           

        }
    }

}
