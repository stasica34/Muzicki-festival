using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Entiteti
{
    public class OmogucavaUlazNaID
    {
        public virtual int ID_ULAZNICE { get; set; }
        public virtual int DOGADJAJ_ID { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as OmogucavaUlazNaID;
            if (other == null)
                return false;

            return ID_ULAZNICE == other.ID_ULAZNICE && DOGADJAJ_ID == other.DOGADJAJ_ID;
        }

        public override int GetHashCode()
        {
            unchecked // Overflow je OK
            {
                int hash = 17;
                hash = hash * 23 + ID_ULAZNICE.GetHashCode();
                hash = hash * 23 + DOGADJAJ_ID.GetHashCode();
                return hash;
            }
        }
    }
}
