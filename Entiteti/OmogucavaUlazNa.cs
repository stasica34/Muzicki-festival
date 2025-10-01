using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Entiteti
{
    public class OmogucavaUlazNa
    {
        public virtual OmogucavaUlazNaID ID { get; set; }

        public virtual int ID_ULAZNICE
        {
            get => ID.ID_ULAZNICE;
            set => ID.ID_ULAZNICE = value;
        }

        public virtual int DOGADJAJ_ID
        {
            get => ID.DOGADJAJ_ID;
            set => ID.DOGADJAJ_ID = value;
        }

        public OmogucavaUlazNa()
        {
            ID = new OmogucavaUlazNaID();
        }
    }
}
