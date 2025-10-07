using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Entiteti
{
    public class Lokacija
    {
        public virtual string OPIS { get; set; }
        public virtual int? MAX_KAPACITET { get; set; } 

        public virtual LokacijaID Lokacija_ID { get; set; }
        public virtual string NAZIV
        {
            get => Lokacija_ID.NAZIV;
            set => Lokacija_ID.NAZIV = value;
        }

        public virtual string GPS_KOORDINATE
        {
            get => Lokacija_ID.GPS_KOORDINATE;
            set => Lokacija_ID.GPS_KOORDINATE = value;
        }
        public virtual IList<Dogadjaj> Dogadjaji { get; set; }
        public Lokacija() 
        {
            Dogadjaji = new List<Dogadjaj>();
            Lokacija_ID = new LokacijaID();
        }
        public override string ToString()
        {
            return $"{Lokacija_ID.NAZIV} - {Lokacija_ID.GPS_KOORDINATE}";
        }
    }

}
