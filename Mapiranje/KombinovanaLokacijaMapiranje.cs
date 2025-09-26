using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Mapiranje
{
    public class KombinovanaLokacijaMapiranje:ClassMap<Muzicki_festival.Entiteti.KombinovanaLokacija>
    {
        public KombinovanaLokacijaMapiranje()
        {
            Table("KOMBINOVANA_LOKACIJA");
            Id(x => x.GPS_KOORDINATE, "GPS_KOORDINATE").GeneratedBy.TriggerIdentity();
            Map(x => x.NAZIV, "NAZIV").Not.Nullable();
        }
    }
}
