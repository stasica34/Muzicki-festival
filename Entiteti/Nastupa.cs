using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Entiteti
{
    public class Nastupa
    {
        public virtual NastupaID ID { get; set; }
        public virtual int DOGADJAJ_ID
        {
            get => ID.DOGADJAJ_ID;
            set => ID.DOGADJAJ_ID = value;
        }

        public virtual int IZVODJAC_ID
        {
            get => ID.IZVODJAC_ID;
            set => ID.IZVODJAC_ID = value;
        }

        public Nastupa()
        {
            ID = new NastupaID();
        }
    }
}
