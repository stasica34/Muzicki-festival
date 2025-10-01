using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Entiteti
{
    public class Izvodjac
    {
        public virtual int ID { get; protected set; }
        public virtual string IME { get; set; }
        public virtual string DRZAVA_POREKLA { get; set; }

        public virtual string EMAIL { get; set; }

        public virtual string KONTAKT_OSOBA { get; set; }

        public virtual string TELEFON { get; set; }
        public virtual MenadzerskaAgencija MenadzerskaAgencija { get; set; }

        public Izvodjac() { }
    }
}
