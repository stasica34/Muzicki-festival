using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.DTOs
{
    public class DogadjajView
    {
        public int Id;
        public string Naziv;
        public string Tip;
        public string Opis;

        public DateTime DatumPocetka;
        public DateTime DatumKraja;

        public DogadjajView(int id, string naziv, string tip, string opis, DateTime datumPocetka, DateTime datumKraja)
        {
            Id = id;
            Naziv = naziv;
            Tip = tip;
            Opis = opis;
            DatumPocetka = datumPocetka;
            DatumKraja = datumKraja;
        }
    }

    public class DogadjajBasic
    {
        public int Id;
        public string Naziv;
        public string Tip;
        public string Opis;

        public DateTime DatumPocetka;
        public DateTime DatumKraja;

        public LokacijaBasic Lokacija;
        public IList<IzvodjacBasic> Izvodjaci;

        public DogadjajBasic(int id, string naziv, string tip, string opis, DateTime datumPocetka, DateTime datumKraja, LokacijaBasic lokacija, IList<IzvodjacBasic> izvodjaci)
        {
            Id = id;
            Naziv = naziv;
            Tip = tip;
            Opis = opis;
            DatumPocetka = datumPocetka;
            DatumKraja = datumKraja;
            Lokacija = lokacija;
            Izvodjaci = izvodjaci;
        }
    }

}
