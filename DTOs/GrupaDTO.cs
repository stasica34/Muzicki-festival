using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.DTOs
{
    public class GrupaView
    {
        public int Id;
        public string Naziv;
        public string NazivAgencije;
        public List<string> Clanovi;

        public GrupaView(int id, string naziv, string nazivAgencije, List<string> clanovi)
        {
            Id = id;
            Naziv = naziv;
            NazivAgencije = nazivAgencije;
            Clanovi = clanovi;
        }
    }

    public class GrupaBasic
    {
        public int Id;
        public string Naziv;
        public AgencijaOrganizatorBasic Agencija;
        public List<PosetilacBasic> Clanovi;

        public GrupaBasic(int id, string naziv, AgencijaOrganizatorBasic agencija, List<PosetilacBasic> clanovi)
        {
            Id = id;
            Naziv = naziv;
            Agencija = agencija;
            Clanovi = clanovi;
        }
    }
}
