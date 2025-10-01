using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Entiteti
{
    public class NastupaID
    {
        public virtual int DOGADJAJ_ID { get; set; }
        public virtual int IZVODJAC_ID { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as NastupaID;
            if(other == null) return false;
            return DOGADJAJ_ID == other.DOGADJAJ_ID && IZVODJAC_ID == other.IZVODJAC_ID;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + DOGADJAJ_ID.GetHashCode();
                hash = hash * 23 + IZVODJAC_ID.GetHashCode();
                return hash;
            }
        }
    }
}
