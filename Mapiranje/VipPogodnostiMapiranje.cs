using FluentNHibernate.Mapping;
using Muzicki_festival.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Mapiranje
{
    public class VipPogodnostiMapiranje:ClassMap<Muzicki_festival.Entiteti.VIpPogodnosti>
    {
        public VipPogodnostiMapiranje()
        {
            Table("VIP_POGODNOSTI");
            CompositeId<VipPogodnostiID>(x => x.ID)
               .KeyProperty(x => x.ID_ULAZNICE, "ID_ULAZNICE")
                .KeyProperty(x => x.POGODNOST, "POGODNOST");
            References(x => x.Vip)
                .Column("ID_ULAZNICE")
                .Not.Insert()
                .Not.Update();
        }
    }
}
