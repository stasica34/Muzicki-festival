using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Muzicki_festival.Entiteti;
using FluentNHibernate.Mapping;

namespace Muzicki_festival.Mapiranje
{
    public class PosetilacMapiranje: ClassMap<Muzicki_festival.Entiteti.Posetilac>
    {
        public PosetilacMapiranje()
        {
            Table("POSETILAC");
            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();
            Map(x => x.IME, "IME").Not.Nullable();
            Map(x => x.PREZIME, "PREZIME").Not.Nullable();
            Map(x => x.EMAIL, "EMAIL").Not.Nullable();
            HasMany(x => x.Ulaznice)
                .KeyColumn("KUPAC_ID")        // FK kolona u tabeli ULAZNICA
                .Inverse()
                .Cascade.AllDeleteOrphan();
        }
    }
}
