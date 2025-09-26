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

            //mapiranje sa ulaznicom:   
            References(x => x.Ulaznica)
                .Column("ID_ULAZNICE")
                .Not.Insert()
                .Not.Update();
            //mapiranje sa visednevna dani:
            HasMany(x => x.Dani)
                .KeyColumn("ID_ULAZNICE")
                .Inverse()
                .Cascade.All();
        }
    }
}
