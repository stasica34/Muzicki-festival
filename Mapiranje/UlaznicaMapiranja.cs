using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Muzicki_festival.Entiteti;

namespace Muzicki_festival.Mapiranje
{
    public class UlaznicaMapiranjaL:ClassMap<Muzicki_festival.Entiteti.Ulaznica>
    {
        public UlaznicaMapiranjaL()
        {
            Table("ULAZNICA");
            Id(x => x.ID_ULAZNICE, "ID_ULAZNICE").GeneratedBy.TriggerIdentity();
            Map(x => x.OSNOVNA_CENA, "OSNOVNA_CENA").Not.Nullable();
            Map(x => x.NACIN_PLACANJA, "NACIN_PLACANJA").Not.Nullable();
            Map(x => x.NAZIV, "NAZIV").Not.Nullable();
            Map(x => x.DATUM_KUPOVINE, "DATUM_KUPOVINE").Not.Nullable();

            //mapiranje reference 1:N veze Ulaznica-Posetilac

            //lazyload znaci da se ucitava samo id vrednost iz tabele posetilac
            //po defautu je lazyload ukljucen
            //kada radimo sa referencama i vezama da radimo sa lazyloadom

            References(x => x.KUPAC_ID, "KUPAC_ID").LazyLoad().Cascade.All();

            //n:m veza sa dogadjejm
            HasManyToMany(x => x.Dogadjaji)
              .Table("OMOGUCAVA_ULAZ_NA")
              .ParentKeyColumn("ID_ULAZNICE")
              .ChildKeyColumn("DOGADJAJ_ID")
              .Cascade.All()
              .Inverse();
        }
    }
}
