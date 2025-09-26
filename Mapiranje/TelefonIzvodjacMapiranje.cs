using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.Mapiranje
{
    public class TelefonIzvodjacMapiranje:ClassMap<Muzicki_festival.Entiteti.TelefonIzvodjac>
    {
        public TelefonIzvodjacMapiranje()
        {
            Table("TELEFON_IZVODJAC");
            Id(x => x.IZVODJAC_ID, "IZVODJAC_ID").GeneratedBy.TriggerIdentity();
            Map(x => x.TELEFON, "TELEFON").Not.Nullable();
        }
    }
}
