using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Muzicki_festival.Entiteti;
namespace Muzicki_festival.Mapiranje
{
    public class BendMapiranja:ClassMap<Muzicki_festival.Entiteti.Bend>
    {
        public BendMapiranja()
        {
            Table("BEND");
            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();
            Map(x => x.BROJ_CLANOVA, "BROJ_CLANOVA").Not.Nullable();
        }
    }
}
