using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Mapiranje
{
    public class VipMapiranja:ClassMap<Muzicki_festival.Entiteti.Vip>
    {
        public VipMapiranja()
        {
            Table("VIP");
            Id(x => x.ID_ULAZNICE, "ID_ULAZNICE").GeneratedBy.TriggerIdentity();


            //mapiranje sa ulaznicom:
            References(x => x.Ulaznica)
            .Column("ID_ULAZNICE")
            .Not.Insert()
            .Not.Update();

            //mapiranje sa vip pogodnostima:
            HasMany(x => x.Pogodnosti)
                .KeyColumn("ID_ULAZNICE")
                .Cascade.AllDeleteOrphan()
                .Inverse()
                .Table("VIP_POGODNOSTI");
        }
    }
}
