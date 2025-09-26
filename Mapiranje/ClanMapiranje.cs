using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Mapiranje
{
    public class ClanMapiranje:ClassMap<Muzicki_festival.Entiteti.Clan>
    {
        public ClanMapiranje()
        {
            Table("CLAN");
            Id(x => x.IME, "IME").GeneratedBy.TriggerIdentity();
            Map(x => x.INSTRUMENT, "INSTRUMENT").Not.Nullable();
        }
    }
}
