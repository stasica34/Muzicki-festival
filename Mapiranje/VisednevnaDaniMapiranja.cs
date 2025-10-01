using FluentNHibernate.Mapping;
using Muzicki_festival.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Mapiranje
{
    public class VisednevnaDaniMapiranja:ClassMap<Muzicki_festival.Entiteti.VisednevnaDani>
    {
        public VisednevnaDaniMapiranja()
        {
            Table("VISEDNEVNA_DANI");
            CompositeId<VisednevnaDaniID>(x => x.ID)
                .KeyProperty(x => x.ID_ULAZNICE, "ID_ULAZNICE")
                .KeyProperty(x => x.DAN_VAZENJA, "DAN_VAZENJA");

            // FK ka Visednevna
            References(x => x.Visednevna)
                .Column("ID_ULAZNICE")
                .Not.Insert()
                .Not.Update();
        }
    }
}
