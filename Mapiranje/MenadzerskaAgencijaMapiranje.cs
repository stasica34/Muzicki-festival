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
        //mapiranje visevrednostinog atributa
        HasMany(x => x.KONTAKTPODACI)
            .KeyColumn("MENADZERSKA_AGENCIJA_ID")
            .Inverse()
            .Cascade.All();
    }
}
