using FluentNHibernate.Mapping;
using Muzicki_festival.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.DTOs
{
    public class MenadzerskaAgencijaView
    {
        public int ID;
        public string Naziv;
        public string Adresa;
        public string KontaktOsoba;

        public MenadzerskaAgencijaView(int id, string naziv, string adresa, string kontaktOsoba)
        {
            ID = id;
            Naziv = naziv;
            Adresa = adresa;
            KontaktOsoba = kontaktOsoba;
        }

        public override string ToString()
        {
            return Naziv;
        }
    }

    public class MenadzerskaAgencijaBasic
    {
        public int ID;
        public string Naziv;
        public string Adresa;
        public string KontaktOsoba;

        public IList<IzvodjacBasic> Izvodjaci;
        public IList<MenadzerskaAgencijaKontaktView> KontaktPodaci;

        public MenadzerskaAgencijaBasic(int id, string naziv, string adresa, string kontaktOsoba, List<IzvodjacBasic> izvodjaci)
        {
            ID = id;
            Naziv = naziv;
            Adresa = adresa;
            KontaktOsoba = kontaktOsoba;
            Izvodjaci = izvodjaci;
        }
    }

    public class MenadzerskaAgencijaKontaktView
    {
        public int ID;
        public TipKontakta TIP_KONTAKTA;
        public string Vrednost;
        
        public MenadzerskaAgencijaKontaktView(int id, TipKontakta tip, string vrednost)
        {
            ID = id;
            TIP_KONTAKTA = tip;
            Vrednost = vrednost;
        }
    }

    public class MenadzerskaAgencijaKontaktBasic
    {
        public int ID;
        public TipKontakta TIP_KONTAKTA;
        public string Vrednost;
        public MenadzerskaAgencijaBasic MenadzerkaAgencija;

        public MenadzerskaAgencijaKontaktBasic(int id, TipKontakta tip, string vrednost, MenadzerskaAgencijaBasic menadzerskaAgencija)
        {
            ID = id;
            TIP_KONTAKTA = tip;
            Vrednost = vrednost;
            MenadzerkaAgencija = menadzerskaAgencija;
        }
    }
}
