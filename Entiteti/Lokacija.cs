using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Entiteti
{
    public class Lokacija
    {
        public virtual string GPS_KOORDINATE { get; set; }
        public virtual string NAZIV { get; set; }
        public virtual string OPIS { get; set; }
        public virtual int? MAX_KAPACITET { get; set; } 

        public Lokacija() { }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Lokacija))
                return false;

            Lokacija other = obj as Lokacija;
            return GPS_KOORDINATE == other.GPS_KOORDINATE && NAZIV == other.NAZIV;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (GPS_KOORDINATE != null ? GPS_KOORDINATE.GetHashCode() : 0);
                hash = hash * 23 + (NAZIV != null ? NAZIV.GetHashCode() : 0);
                return hash;
            }
        }
    }

}
