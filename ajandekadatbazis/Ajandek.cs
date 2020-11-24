using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajandekadatbazis
{
    class Ajandek
    {
        private int id;
        private string nev;
        private string uzlet;

        public Ajandek(int id, string nev, string uzlet)
        {
            this.Id = id;
            this.Nev = nev;
            this.Uzlet = uzlet;
        }

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Uzlet { get => uzlet; set => uzlet = value; }

        public override string ToString()
        {
            return String.Format("{0}",this.nev);
        }
    }
}
