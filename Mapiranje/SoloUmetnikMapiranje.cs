using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping;
using Muzicki_festival.Entiteti;
using FluentNHibernate.Mapping;

namespace Muzicki_festival.Mapiranje
{
    public class SoloUmetnikMapiranje: ClassMap<Muzicki_festival.Entiteti.Solo_Umetnik>
    {
        public SoloUmetnikMapiranje()
        {
            Table("SOLO_UMETNIK");
            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();
            Map(x => x.SVIRA_INSTRUMENT, "SVIRA_INSTRUMENT").Not.Nullable();
            Map(x => x.TIP_INSTRUMENTA, "TIP_INSTRUMENTA").Not.Nullable();
        }
    }
}
