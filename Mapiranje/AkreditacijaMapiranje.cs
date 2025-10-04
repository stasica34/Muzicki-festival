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
    public class AkreditacijaMapiranje:SubclassMap<Muzicki_festival.Entiteti.Akreditacija>
    {
        public AkreditacijaMapiranje()
        {
            Table("AKREDITACIJA");
            KeyColumn("ID_ULAZNICE");

            Map(x => x.SPONZOR, "SPONZOR");
            Map(x=>x.PRESS, "PRESS");
            Map(x=>x.PARTNER, "PARTNER");
        }
    }
}
