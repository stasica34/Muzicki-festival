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
            Id(x => x.Lokacija_ID, "LOKACIJA_ID").GeneratedBy.Identity();
            Map(x => x.OPIS, "OPIS").Not.Nullable();
            Map(x => x.GPS_KOORDINATE, "GPS_KOORDINATE").Not.Nullable();
            Map(x => x.NAZIV, "NAZIV").Not.Nullable();
            Map(x => x.MAX_KAPACITET, "MAX_KAPACITET").Nullable();
            Map(x => x.TIP_LOKACIJE, "TIP_LOKACIJE").Not.Nullable();
            HasMany(x => x.Dogadjaji)
                .KeyColumn("LOKACIJA_ID")
                .Inverse()
                .Cascade.All()
                .LazyLoad();

        }
    }
}
