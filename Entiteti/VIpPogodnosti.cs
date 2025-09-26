using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Entiteti
{
    public class VIpPogodnosti
    {
        public virtual int ID_ULAZNICE { get;protected set; }
        public virtual string POGODNOST { get; set; }
        //fk ka VIP
        public virtual Vip Vip { get; set; }
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is VIpPogodnosti))
                return false;

            var other = (VIpPogodnosti)obj;
            return ID_ULAZNICE == other.ID_ULAZNICE &&
                   POGODNOST == other.POGODNOST;
        }

        public override int GetHashCode()
        {
            unchecked // da izbegnemo overflow
            {
                int hash = 17;
                hash = hash * 23 + ID_ULAZNICE.GetHashCode();
                hash = hash * 23 + (POGODNOST != null ? POGODNOST.GetHashCode() : 0);
                return hash;
            }
        }
    }
}
