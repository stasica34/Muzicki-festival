using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Entiteti
{
    public class OmogucavaUlazNa
    {
        public virtual int ID_ULAZNICE { get; protected set; }
        public virtual int DOGADJAJ_ID { get; set; }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            var other = (OmogucavaUlazNa)obj;
            return ID_ULAZNICE == other.ID_ULAZNICE && DOGADJAJ_ID == other.DOGADJAJ_ID;
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine
            {
                int hash = 17;
                hash = hash * 23 + ID_ULAZNICE.GetHashCode();
                hash = hash * 23 + DOGADJAJ_ID.GetHashCode();
                return hash;
            }
        }
    }
}
