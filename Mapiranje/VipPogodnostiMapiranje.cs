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
            Id(x => x.ID_ULAZNICE, "ID_ULAZNICE").GeneratedBy.TriggerIdentity();
            Map(x => x.POGODNOST, "POGODNOST").Not.Nullable();
        }
    }
}
