using FluentNHibernate.Mapping;
using Muzicki_festival.Entiteti;
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
            CompositeId<ClanID>(x => x.Id)
             .KeyProperty(x => x.IME, "IME")
             .KeyProperty(x => x.INSTRUMENT, "INSTRUMENT")
             .KeyReference(x => x.BEND_ID, "BEND_ID");
        }
    }
}
