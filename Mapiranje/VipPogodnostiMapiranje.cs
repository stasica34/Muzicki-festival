using FluentNHibernate.Mapping;
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

            CompositeId()
                .KeyReference(x => x.Vip, "ID_ULAZNICE")
                .KeyProperty(x => x.POGODNOST, "POGODNOST");
        }
    }
}
