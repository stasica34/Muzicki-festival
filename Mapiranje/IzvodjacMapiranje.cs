using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using Muzicki_festival.Entiteti;
using FluentNHibernate.Mapping;

namespace Muzicki_festival.Mapiranje
{
    public class IzvodjacMapiranje:ClassMap<Muzicki_festival.Entiteti.Izvodjac>
    {
        public IzvodjacMapiranje()
        {
            Table("IZVODJAC");
            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();
            Map(x => x.IME, "IME").Not.Nullable();
            Map(x => x.DRZAVA_POREKLA, "DRZAVA_POREKLA").Not.Nullable();
            Map(x => x.EMAIL, "EMAIL").Not.Nullable();
            Map(x => x.KONTAKT_OSOBA, "KONTAKT_OSOBA").Nullable();
            //mapiranje 1:n sa menadzerskom agencijom
            References(x => x.MenadzerskaAgencija).Column("MENADZERSKA_AGENCIJA_ID").LazyLoad().Cascade.None();
            //mapiranje n:m
            HasManyToMany(x => x.Dogadjaji)
              .Table("NASTUPA")
              .ParentKeyColumn("IZVODJAC_ID")
              .ChildKeyColumn("DOGADJAJ_ID")
              .Cascade.All();
            //svuda gde mi je nasladjivanje da uradim i sa discriminator sa tipom
            //visevrednosni atribut
            HasMany(x => x.Telefoni)
                .Table("TELEFON_IZVODJAC")
                .KeyColumn(("IZVODJAC_ID"))
                .Element("TELEFON")
                .Cascade.All();
            HasMany(x => x.Zanrovi)
               .Table("IZVODJAC_ZANR")
               .KeyColumn(("ID_IZVODJAC"))
               .Element("NAZIV")
               .Cascade.All();
            HasMany(x => x.Lista_tehnickih_zahteva)
               .Table("IZVODJAC_TEHNICKI_ZAHTEVI")
               .KeyColumn(("IZVODJAC_ID"))
               .Element("ZAHTEV")
               .Cascade.All();

        }
    }
}
