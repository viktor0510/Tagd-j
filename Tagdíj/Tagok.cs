using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tagdíj
{
    class Tagok
    {
        int azonosito;
        string nev;
        int szulev;
        int irszam;
        string orszag;

        public Tagok(int azonosito, string nev, int szulev, int irszam, string orszag)
        {
            this.Azonosito = azonosito;
            this.Nev = nev;
            this.Szulev = szulev;
            this.Irszam = irszam;
            this.Orszag = orszag;
        }

        public int Azonosito { get => azonosito; set => azonosito = value; }
        public string Nev { get => nev; set => nev = value; }
        public int Szulev { get => szulev; set => szulev = value; }
        public int Irszam { get => irszam; set => irszam = value; }
        public string Orszag { get => orszag; set => orszag = value; }
    }
}
