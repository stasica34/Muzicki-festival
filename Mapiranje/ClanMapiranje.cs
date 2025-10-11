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
            Id(x => x.Id).Column("CLAN_ID").GeneratedBy.Identity();
            Map(x => x.IME, "IME");
            Map(x => x.INSTRUMENT, "INSTRUMENT");

            References(x => x.BEND_ID, "BEND_ID").LazyLoad().Cascade.All();
            //visevrednosni atribut
            HasMany(x => x.Uloge)
                .Table("CLAN_ULOGA")
                .KeyColumn("CLAN_ID")
                .Element("ULOGA")
                .Cascade.All();
        }
    }
}
