using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Muzicki_festival.Entiteti;

namespace Muzicki_festival.Mapiranje
{
    public class JednodnevnaMapiranje:ClassMap<Muzicki_festival.Entiteti.Jednodnevna>
    {
        public JednodnevnaMapiranje()
        {
            Table("JEDNODNEVNA");
            Id(x => x.ID_ULAZNICE, "ID_ULAZNICE").GeneratedBy.TriggerIdentity();
            Map(x => x.DAN_VAZENJA, "DAN_VAZENJA").Not.Nullable();
        }
    }
}
