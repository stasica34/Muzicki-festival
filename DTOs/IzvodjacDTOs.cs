using Muzicki_festival.Entiteti;
using NHibernate.Mapping.ByCode.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Muzicki_festival.DTOs
{
    public abstract class IzvodjacView
    {
        public int Id;
        public string Ime;
        public string Drzava_porekla;
        public string Email;
        public string Kontakt_osoba;
        public string Telefon;
        public IzvodjacTip tipIzvodajaca;

        public IzvodjacView(int id, string ime, string drzava_porekla, string email, string kontakt_osoba, string telefon, IzvodjacTip tipIzvodajaca)
        {
            Id = id;
            Ime = ime;
            Drzava_porekla = drzava_porekla;
            Email = email;
            Kontakt_osoba = kontakt_osoba;
            Telefon = telefon;
            this.tipIzvodajaca = tipIzvodajaca;
        }
    }

    public class BendView : IzvodjacView
    {
        public int Broj_clanova;
        public BendView(int id, string ime, string drzava_porekla, string email, string kontakt_osoba, string telefon, int broj_clanova)
            : base(id, ime, drzava_porekla, email, kontakt_osoba, telefon, IzvodjacTip.BEND)
        {
            Broj_clanova = broj_clanova;
        }
    }

    public class Solo_umetnikView : IzvodjacView
    {
        public string Svira_instrument;
        public string Tip_instrumenta;
        public Solo_umetnikView(int id, string ime, string drzava_porekla, string email, string kontakt_osoba, string telefon, string svira_instrument, string tip_instrumenta)
            : base(id, ime, drzava_porekla, email, kontakt_osoba, telefon, IzvodjacTip.SOLO_UMETNIK)
        {
            Svira_instrument = svira_instrument;
            Tip_instrumenta = tip_instrumenta;
        }
    }

    public abstract class IzvodjacBasic
    {
        public int Id;
        public string Ime;
        public string Drzava_porekla;
        public string Email;
        public string Kontakt_osoba;
        public string Telefon;
        public IzvodjacTip TipIzvodajaca;

        public MenadzerskaAgencijaBasic MenadzerskaAgencija;

        public IzvodjacBasic(int id, string ime,string drzava_poreka, string email,string kontakt_osoba, string telefon, IzvodjacTip tipIzvodjaca, MenadzerskaAgencijaBasic menadzerskaAgencija)
        {
            Id = id;
            Ime = ime;
            Drzava_porekla = drzava_poreka;
            Email = email;
            Kontakt_osoba = kontakt_osoba;
            Telefon = telefon;
            TipIzvodajaca = tipIzvodjaca;
            MenadzerskaAgencija = menadzerskaAgencija;
        }
    }

    public class Solo_UmetnikBasic : IzvodjacBasic
    {
        public string Svira_instrument;
        public string Tip_instrumenta;

        public Solo_UmetnikBasic(int id, string ime, string drzava_poreka, string email, string kontakt_osoba, string telefon, MenadzerskaAgencijaBasic menadzerskaAgencija, string svira_instrument, string tip_instrumenta)
            :base(id, ime, drzava_poreka, email, kontakt_osoba, telefon, IzvodjacTip.SOLO_UMETNIK, menadzerskaAgencija)
        {
            Svira_instrument = svira_instrument;
            Tip_instrumenta = tip_instrumenta;
        }
    }

    public class BendBasic : IzvodjacBasic
    {
        public BendBasic(int id, string ime, string drzava_poreka, string email, string kontakt_osoba, string telefon, MenadzerskaAgencijaBasic menadzerskaAgencija)
            : base(id, ime, drzava_poreka, email, kontakt_osoba, telefon, IzvodjacTip.BEND, menadzerskaAgencija)
        {

        }

    }

    public class ClanBendaView
    {
        public int Id;
        public string Ime;
        public string Instrument;

        public ClanBendaView(int id, string ime, string instrument)
        {
            Id = id;
            Ime = ime;
            Instrument = instrument;
        }
    }

    public class ClanBendaBasic
    {
        public int Id;
        public string Ime;
        public string Instrument;
        public BendBasic Bend;

        public ClanBendaBasic(int id, string ime, string instrument, BendBasic bend)
        {
            Id = id;
            Ime = ime;
            Instrument = instrument;
            Bend = bend;
        }
    }
}
