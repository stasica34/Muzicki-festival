using FluentNHibernate.Mapping;
using Muzicki_festival.Entiteti;

public class MenadzerskaAgencijaMapiranje : ClassMap<MenadzerskaAgencija>
{
    public MenadzerskaAgencijaMapiranje()
    {
        Table("MENADZERSKA_AGENCIJA");

        Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

        Map(x => x.NAZIV, "NAZIV").Not.Nullable();
        Map(x => x.ADRESA, "ADRESA").Not.Nullable();
        Map(x => x.KONTAKT_OSOBA, "KONTAKT_OSOBA").Not.Nullable();

        HasMany(x => x.Izvodjaci)
            .KeyColumn("MENADZERSKA_AGENCIJA_ID")
            .Inverse()
            .Cascade.All();
        HasMany(x => x.KONTAKTPODACI)
            .Table("KONTAKT_PODACI")
            .KeyColumn("MENADZERSKA_AGENCIJA_ID")
            .Component(x =>
            {
                x.Map(y => y.EMAIL).Column("EMAIL");
                x.Map(y => y.TELEFON).Column("TELEFON");
            })
            .Cascade.All();
    }
}
