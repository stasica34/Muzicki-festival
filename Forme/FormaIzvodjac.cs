using Muzicki_festival.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using Muzicki_festival.Entiteti;

namespace Muzicki_festival.Forme
{
    public partial class FormaIzvodjac : Form
    {
        private Form parentForm;

        public FormaIzvodjac(Form caller)
        {
            InitializeComponent();
            parentForm = caller;
        }

        private void FormaIzvodjac_Load(object sender, EventArgs e)
        {
            try
            {
                using (var session = DataLayer.GetSession())
                {
                    MessageBox.Show("Forma uspešno otvorena!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void cmd_Ucitavanje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                using (var session = DataLayer.GetSession())
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        var listaIzvodjaca = session.QueryOver<Izvodjac>().List();
                        if (listaIzvodjaca.Count == 0)
                        {
                            MessageBox.Show("Nema izvodjaca u bazi.");
                            return;
                        }
                        StringBuilder sb = new StringBuilder();
                        foreach (var a in listaIzvodjaca)
                        {
                            sb.AppendLine($"ID: {a.ID}");
                            sb.AppendLine($"IME: {a.IME}");
                            sb.AppendLine($"DRZAVA_POREKLA: {a.DRZAVA_POREKLA}");
                            sb.AppendLine($"EMAIL: {a.EMAIL}");
                            sb.AppendLine($"MENADZERSKA_AGENCIJA_ID: {a.MenadzerskaAgencija.ID}");
                            sb.AppendLine($"KONTAKT_OSOBA: {a.KONTAKT_OSOBA}");
                            sb.AppendLine($"TELEFON: {a.TELEFON}");
                            sb.AppendLine(new string('-', 40));
                        }
                        MessageBox.Show(sb.ToString(), $"Lista izvodjaca: {listaIzvodjaca.Count}");
                        transaction.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void cmd_Nazad_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }

        private void cmdDodavanje_Click(object sender, EventArgs e)
        {
            //ovakva pristup se koristi kada kod n:m veze nemamo nijedan atribut
            try
            {
                ISession s = DataLayer.GetSession();

                Lokacija lokacija = s.QueryOver<Lokacija>()
                 .Where(x => x.Lokacija_ID.NAZIV == "Trg Republike")
                 .And(x => x.Lokacija_ID.GPS_KOORDINATE == "43.335,21.910")
                 .SingleOrDefault();
                if (lokacija == null)
                {
                    MessageBox.Show("Greška: Nema zadate lokacije u bazi. Dodaj lokaciju pre unosa događaja.");
                    return;
                }
                Dogadjaj d = new Dogadjaj()
                {
                    NAZIV = "Nesto novo",
                    TIP = "Radionica",
                    OPIS = "Fenomene u muzickom takmicenju",
                    DATUM_VREME_POCETKA = DateTime.Now,
                    DATUM_VREME_KRAJA = new DateTime(2025, 10, 5),
                    Lokacija_ID = lokacija
                };
                s.Save(d);
                s.Flush();
                MessageBox.Show("Uspesno je dodato");
                MenadzerskaAgencija agencija = s.Get<MenadzerskaAgencija>(1);
                if (agencija == null)
                {
                    MessageBox.Show("Menadžerska agencija sa ID = 1 ne postoji.");
                    return;
                }
                var postoji = s.QueryOver<Izvodjac>()
                     .Where(x => x.IME == "Ed" || x.EMAIL == "ed@example.com")
                     .SingleOrDefault();

                if (postoji != null)
                {
                    MessageBox.Show("Izvođač sa istim imenom ili email-om već postoji.");
                    return;
                }
                Entiteti.Izvodjac i = new Entiteti.Izvodjac()
                {
                    IME = "Ed",
                    DRZAVA_POREKLA = "Amerika",
                    EMAIL = "ed@example.com",
                    KONTAKT_OSOBA = "Micheal Kelly",
                    TELEFON = "+384659012345",
                    MenadzerskaAgencija = agencija
                };
                s.Save(i);
                //veza n/m
                d.Izvodjaci.Add(i);
                s.Flush();
                MessageBox.Show("Uspesno je dodato");
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
