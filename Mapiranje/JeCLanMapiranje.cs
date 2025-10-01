using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Muzicki_festival.Entiteti;

namespace Muzicki_festival.Mapiranje
{
    public class JeCLanMapiranje:ClassMap<Muzicki_festival.Entiteti.JeClan>
    {
        public JeCLanMapiranje()
        {
            Table("JE_CLAN");
            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();
            References(x => x.Posetilac)
               .Column("POSETILAC_ID")
               .Not.Nullable()
               .Cascade.None();

            References(x => x.Grupa)
                .Column("ID_GRUPE")
                .Not.Nullable()
                .Cascade.None();
        }
    }
}
