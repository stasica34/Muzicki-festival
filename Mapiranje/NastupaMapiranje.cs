using FluentNHibernate.Mapping;
using Muzicki_festival.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Mapiranje
{
    public class NastupaMapiranje:ClassMap<Muzicki_festival.Entiteti.Nastupa>
    {
        public NastupaMapiranje()
        {
            Table("NASTUPA");
            CompositeId<NastupaID>(x => x.ID)
              .KeyProperty(x => x.DOGADJAJ_ID, "DOGADJAJ_ID")
              .KeyProperty(x => x.IZVODJAC_ID, "IZVODJAC_ID");
        }
    }
}
