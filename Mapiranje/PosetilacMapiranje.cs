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
            Id(x => x.ID, "ID").GeneratedBy.Sequence("POSETILAC_PK");
            Map(x => x.IME, "IME").Not.Nullable();
            Map(x => x.PREZIME, "PREZIME").Not.Nullable();
            Map(x => x.EMAIL, "EMAIL").Not.Nullable();
            HasMany(x => x.Ulaznice)
                .KeyColumn("KUPAC_ID")// FK kolona u tabeli ULAZNICA
                .Inverse()
                .Cascade.All();
            //inverse znaci da suprotna strana mora da vodi racuna
            //o stranom kljucu tj o vrednosti stranog kljuca
            //mogu da budu i veze kao:
            //HasMany(x => x.Ulaznice)
            //lista odeljenja i strani kljuc
            //   .KeyColumn("KUPAC_ID"); 
            //HasMany(x => x.Ulaznice)
            //   .KeyColumn("KUPAC_ID")
            //   .Cascade.All();

            //mapiramo smer
            HasManyToMany(x => x.Grupa)
                .Table("JE_CLAN")
                .ParentKeyColumn("POSETILAC_ID")
                .ChildKeyColumn("ID_GRUPE")
                .Cascade.All()
                .Inverse();

            //inverzija moze da bude na obe strane
            //ali biramo tamo inverziju gde nam vise odgovara

        }
    }
}
