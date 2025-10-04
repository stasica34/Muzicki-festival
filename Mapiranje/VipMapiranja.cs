using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Mapiranje
{
    public class VipMapiranja:SubclassMap<Muzicki_festival.Entiteti.Vip>
    {
        public VipMapiranja()
        {
            Table("VIP");
            KeyColumn("ID_ULAZNICE");

            //mapiranje sa vip pogodnostima:
            HasMany(x => x.Pogodnosti)
                .KeyColumn("ID_ULAZNICE")
                .Cascade.AllDeleteOrphan()
                .Inverse()
                .Table("VIP_POGODNOSTI");
        }
    }
}
