using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Muzicki_festival.Entiteti;

namespace Muzicki_festival.Mapiranje
{
    public class TelefonPosetilacMapiranje:ClassMap<Muzicki_festival.Entiteti.TelefonPosetilac>
    {
        public TelefonPosetilacMapiranje()
        {
            Table("TELEFON_POSETILAC");
            Id(x => x.POSETILAC_ID, "POSETILAC_ID").GeneratedBy.TriggerIdentity();
            Map(x => x.TELEFON, "TELEFON").Not.Nullable();
        }
    }
}
