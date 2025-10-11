using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Entiteti
{
    public class Lokacija
    {
        public virtual int Lokacija_ID { get; set; }
        public virtual string OPIS { get; set; }
        public virtual int? MAX_KAPACITET { get; set; } 
        public virtual string NAZIV { get; set; }

        public virtual string GPS_KOORDINATE { get; set; }
        public virtual string TIP_LOKACIJE { get; set; }
        public virtual IList<Dogadjaj> Dogadjaji { get; set; }
        public Lokacija() 
        {
            Dogadjaji = new List<Dogadjaj>();
        }
        public override string ToString()
        {
            return $"{NAZIV} - {GPS_KOORDINATE}";
        }
    }

}
