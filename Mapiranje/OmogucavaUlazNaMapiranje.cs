using FluentNHibernate.Mapping;
using Muzicki_festival.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Mapiranje
{
    public class OmogucavaUlazNaMapiranje:ClassMap<Muzicki_festival.Entiteti.OmogucavaUlazNa>
    {
        public OmogucavaUlazNaMapiranje()
        {
            Table("OMOGUCAVA_ULAZ_NA");
            CompositeId<OmogucavaUlazNaID>(x => x.ID)
                .KeyProperty(x => x.ID_ULAZNICE, "ID_ULAZNICE")
                .KeyProperty(x => x.DOGADJAJ_ID, "DOGADJAJ_ID");
        }
    }
}
