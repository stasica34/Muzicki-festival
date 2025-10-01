using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Entiteti
{
    public class ClanID
    {
        public virtual string IME { get; set; }
        public virtual string INSTRUMENT { get; set; }
        public virtual Bend BEND_ID { get; set; }
        public override bool Equals(object obj)
        {
            var other = obj as ClanID;
            if (other == null) return false;
            return IME == other.IME && INSTRUMENT == other.INSTRUMENT && Equals(BEND_ID, other.BEND_ID);
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + (IME != null ? IME.GetHashCode() : 0);
            hash = hash * 23 + (INSTRUMENT != null ? INSTRUMENT.GetHashCode() : 0);
            hash = hash * 23 + (BEND_ID != null ? BEND_ID.ID.GetHashCode() : 0);
            return hash;
        }
    }
}
