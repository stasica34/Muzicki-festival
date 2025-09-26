using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Mapiranje
{
    public class ZatvorenaLokacijaMapiranje:ClassMap<Muzicki_festival.Entiteti.ZatvorenaLokacija>
    {
        public ZatvorenaLokacijaMapiranje()
        {
            Table("ZATVORENA_LOKACIJA");
            Id(x => x.GPS_KOORDINATE, "GPS_KOORDINATE").GeneratedBy.TriggerIdentity();
            Map(x => x.NAZIV, "NAZIV").Not.Nullable();
            Map(x => x.TIP_PROSTORA, "TIP_PROSTORA").Not.Nullable();
            Map(x => x.KLIMA, "KLIMA").Not.Nullable();
            Map(x => x.DOSTUPNOST_SEDENJA, "DOSTUPNOST_SEDENJA").Not.Nullable();
        }
    }
}
