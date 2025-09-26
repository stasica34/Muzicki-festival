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
    public class AkreditacijaMapiranje:ClassMap<Muzicki_festival.Entiteti.Akreditacija>
    {
        public AkreditacijaMapiranje()
        {
            Table("AKREDITACIJA");
            Id(x => x.ID_ULAZNICE, "ID_ULAZNICE").GeneratedBy.TriggerIdentity();
            Map(x => x.TIP, "TIP");
        }
    }
}
