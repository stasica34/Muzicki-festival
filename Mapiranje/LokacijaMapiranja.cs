using FluentNHibernate.Mapping;
using Muzicki_festival.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Mapiranje
{
    public class LokacijaMapiranja:ClassMap<Muzicki_festival.Entiteti.Lokacija>
    {
        public LokacijaMapiranja()
        {
            Table("LOKACIJA");
            CompositeId<LokacijaID>(x=>x.Lokacija_ID)
                .KeyProperty(x => x.GPS_KOORDINATE, "GPS_KOORDINATE")
                .KeyProperty(x => x.NAZIV, "NAZIV");
            Map(x => x.OPIS, "OPIS").Not.Nullable();
            Map(x => x.MAX_KAPACITET, "MAX_KAPACITET").Nullable();
            HasMany(x => x.Dogadjaji)
                .KeyColumns.Add("GPS_KOORDINATE", "LOKACIJA_NAZIV")
                .Inverse()
                .Cascade.All();

        }
    }
}
