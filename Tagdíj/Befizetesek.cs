using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tagdíj
{
    class Befizetesek
    {
        int beazonosito;
        int datum;
        string osszeg;

        public Befizetesek(int beazonosito, int datum, string osszeg)
        {
            this.Beazonosito = beazonosito;
            this.Datum = datum;
            this.Osszeg = osszeg;
        }

        public int Beazonosito { get => beazonosito; set => beazonosito = value; }
        public int Datum { get => datum; set => datum = value; }
        public string Osszeg { get => osszeg; set => osszeg = value; }
    }
}
