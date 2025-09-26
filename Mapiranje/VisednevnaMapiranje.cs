using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Mapiranje
{
    public class VisednevnaMapiranje:ClassMap<Muzicki_festival.Entiteti.Visednevna>
    {
        public VisednevnaMapiranje()
        {
            Table("VISEDNEVNA");
            Id(x => x.ID_ULAZNICE, "ID_ULAZNICE").GeneratedBy.TriggerIdentity();
            Map(x => x.BROJ_DANA, "BROJ_DANA");
        }
    }
}
