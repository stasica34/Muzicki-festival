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
using NHibernate.Linq;
using Muzicki_festival.Forme;
using Muzicki_festival.FormeDodatne;
namespace Muzicki_festival
{
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
        private void cmdBend_Click(object sender, EventArgs e)
        {
            FormaBend formaBend = new FormaBend(this);
            formaBend.Show();
            this.Hide();

        }

        private void cmd_SoloUmetnik_Click(object sender, EventArgs e)
        {
            FormaSoloUmetnik formasoloUmetnik = new FormaSoloUmetnik(this);
            formasoloUmetnik.Show();
            this.Hide();
        }

        private void cmd_AgencijaOrganizator_Click(object sender, EventArgs e)
        {
            FormaAgencijaOrganizator formaAgencijaOrganizator = new FormaAgencijaOrganizator(this);
            formaAgencijaOrganizator.Show();
            this.Hide();
        }

        private void cmd_Akreditacija_Click(object sender, EventArgs e)
        {
            FormaAkreditacija formaAkreditacija = new FormaAkreditacija(this);
            formaAkreditacija.Show();
            this.Hide();
        }

        private void cmd_Posetilac_Click(object sender, EventArgs e)
        {
            FormaPosetilac formaPosetilac = new FormaPosetilac(this);
            formaPosetilac.Show();
            this.Hide();
        }

        private void cmd_Grupa_Click(object sender, EventArgs e)
        {
            FormaGrupa formaGrupa = new FormaGrupa(this);
            formaGrupa.Show();
            this.Hide();
        }
        private void cmd_JeClan_Click(object sender, EventArgs e)
        {
            FormaJeClan formaJeClan = new FormaJeClan(this);
            formaJeClan.Show();
            this.Hide();
        }

        private void cmd_Clan_Click(object sender, EventArgs e)
        {
            FormaClan formaClan = new FormaClan(this);
            formaClan.Show();
            this.Hide();
        }

        private void cnd_Jednodnevna_Click(object sender, EventArgs e)
        {
            FormaJednodnevna formaJednodnevna = new FormaJednodnevna(this);
            formaJednodnevna.Show();
            this.Hide();
        }

        private void cmd_Kobinovana_Click(object sender, EventArgs e)
        {
            FormaKombinovanaLokacija fomrakombinovanaLokacija = new FormaKombinovanaLokacija(this);
            fomrakombinovanaLokacija.Show();
            this.Hide();
        }

        private void cmd_Lokacija_Click(object sender, EventArgs e)
        {
            FormaLokacija formaLokacija = new FormaLokacija(this);
            formaLokacija.Show();
            this.Hide();
        }

        private void cmd_MenadzerskaAgencija_Click(object sender, EventArgs e)
        {
            FormaMenaderskaAgencija formaMenaderskaAgencija = new FormaMenaderskaAgencija(this);
            formaMenaderskaAgencija.Show();
            this.Hide();
        }
        private void cmd_OtvorenaLokacija_Click(object sender, EventArgs e)
        {
            FormaOtvorenaLokacija formaotvorenaLokacija = new FormaOtvorenaLokacija(this);
            formaotvorenaLokacija.Show();
            this.Hide();
        }
        private void cmd_Vip_Click(object sender, EventArgs e)
        {
            FormaVip formaVip = new FormaVip(this);
            formaVip.Show();
            this.Hide();
        }
        private void cmd_Visednevna_Click(object sender, EventArgs e)
        {
            FormaVisednevna formaVisednevna = new FormaVisednevna(this);
            formaVisednevna.Show();
            this.Hide();
        }

        private void cmd_ZatvorenaLokacija_Click(object sender, EventArgs e)
        {
            FormaZatvorenaLokacija formaZatvorenaLokacija = new FormaZatvorenaLokacija(this);
            formaZatvorenaLokacija.Show();
            this.Hide();
        }

        private void cmd_Dogadjaji_Click(object sender, EventArgs e)
        {
            FormaDogadjaji formaDogadjaji = new FormaDogadjaji(this);
            formaDogadjaji.Show();
            this.Hide();

        }
        private void cmd_JedanNaVise_Click_1(object sender, EventArgs e)
        {

        }
        //rezultat treba da ide, bez obzira da li se ide 1:n ili n:1

        private void cmd_ViseNaJedan_Click(object sender, EventArgs e)
        {

        }
        private void cmdViseNaJedan2_Click(object sender, EventArgs e)
        {
            //grupa i agencijaorganizator
            try
            {
                ISession session = DataLayer.GetSession();
                Grupa g = session.Load<Grupa>(1);
                MessageBox.Show($"Grupa: {g.NAZIV},\nAgencija: {g.AgencijaID.NAZIV},\nAdresa: {g.AgencijaID.ADRESA}", "Detalji");
                session.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }
        private void cmdJedanNaVise_Click_1(object sender, EventArgs e)
        {
            //izmedju agencije i grupe
            try
            {
                ISession session = DataLayer.GetSession();
                Muzicki_festival.Entiteti.AgencijaOrganizator ag = session.Get<Muzicki_festival.Entiteti.AgencijaOrganizator>(1);
                foreach (var agencija in ag.Grupe)
                {
                    MessageBox.Show("Grupe: " + agencija.NAZIV);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void cmdVisenaJedan3_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                ISession session = DataLayer.GetSession();
                Bend bend = session.Load<Bend>(6);
                Clan clanId = new Clan
                {
                    IME = "Marko Jovanović",
                    INSTRUMENT = "Gitara",
                    BEND_ID = bend
                };

                if (clanId != null)
                {
                    MessageBox.Show($"Ime: {clanId.IME},\nBend broj clanova: {clanId.BEND_ID.BROJ_CLANOVA}", "Detalji");
                }
                else
                {
                    MessageBox.Show("Clan nije pronađen.");
                }

                session.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
            */
        }

        private void cmdJedanNaVise3_Click(object sender, EventArgs e)
        {
            //izmedju benda i clana
            try
            {
                using (ISession session = DataLayer.GetSession())
                {
                    // Učitaj bend
                    Bend bend = session.Get<Bend>(6);

                    if (bend != null)
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine($"Broj članova: {bend.BROJ_CLANOVA}");
                        sb.AppendLine("Članovi:");

                        if (bend.Clanovi != null && bend.Clanovi.Count > 0)
                        {
                            foreach (var clan in bend.Clanovi)
                            {
                                sb.AppendLine($"- {clan.IME} ({clan.INSTRUMENT})");
                            }
                        }
                        else
                        {
                            sb.AppendLine("Nema članova.");
                        }

                        MessageBox.Show(sb.ToString(), "Bend i članovi");
                    }
                    else
                    {
                        MessageBox.Show("Bend nije pronađen.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void cmdViseNaJedan4_Click(object sender, EventArgs e)
        {
            //izvodjaca i menadzerske
            try
            {
                ISession session = DataLayer.GetSession();
                Izvodjac i = session.Load<Izvodjac>(1);
                MessageBox.Show($"Izvodjac: {i.IME},\nAgencija: {i.MenadzerskaAgencija.NAZIV}", "Detalji");
                session.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void cmdJedanNaVise4_Click(object sender, EventArgs e)
        {
            // Izvodjac i njegova menadzerska agencija
            try
            {
                using (ISession session = DataLayer.GetSession())
                {
                    int izvodjacId = 1;

                    Izvodjac izvodjac = session.Get<Izvodjac>(izvodjacId);

                    if (izvodjac != null && izvodjac.MenadzerskaAgencija != null)
                    {
                        MessageBox.Show($"Izvođač: {izvodjac.IME}\n", "Detalji");
                    }
                    else
                    {
                        MessageBox.Show("Izvođač nije pronađen ili nema agenciju.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void cmdViseNaJedan5_Click(object sender, EventArgs e)
        {
            //dogadjaj i lokacija
            try
            {
                ISession session = DataLayer.GetSession();
                Dogadjaj d = session.Load<Dogadjaj>(25);
                MessageBox.Show($"Dogadjaj: {d.NAZIV},\nLokacija: {d.Lokacija.NAZIV} {d.Lokacija.GPS_KOORDINATE}", "Detalji");
                session.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void cmdViseNaVise_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Dogadjaj d = s.Get<Dogadjaj>(25);
                //foreach(Entiteti.Izvodjac i in d.Izvodjaci)
                //{
                //    MessageBox.Show("Dogadjaj: " + d.NAZIV + "\nBroj izvođača: " + d.Izvodjaci.Count);
                //}
                //Entiteti.Izvodjac i1 = s.Load<Entiteti.Izvodjac>(1);
                //foreach(Dogadjaj g1 in i1.Dogadjaji)
                //{
                //    StringBuilder sb = new StringBuilder();
                //    sb.AppendLine($"- {i1.IME} ({i1.DRZAVA_POREKLA})");
                //}
                if (d != null)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine($"Događaj: {d.NAZIV}");
                    sb.AppendLine($"Broj izvođača: {d.Izvodjaci.Count}");
                    sb.AppendLine("Izvođači:");

                    foreach (Izvodjac i in d.Izvodjaci)
                    {
                        sb.AppendLine($"- {i.IME} ({i.DRZAVA_POREKLA})");
                    }

                    MessageBox.Show(sb.ToString(), "Događaj i izvođači");
                }
                Izvodjac i1 = s.Load<Izvodjac>(1);
                if (i1 != null)
                {
                    StringBuilder sb2 = new StringBuilder();
                    sb2.AppendLine($"Izvođač: {i1.IME} ({i1.DRZAVA_POREKLA})");
                    sb2.AppendLine("Nastupa na događajima:");

                    foreach (Dogadjaj g1 in i1.Dogadjaji)
                    {
                        sb2.AppendLine($"- {g1.NAZIV}");
                    }

                    MessageBox.Show(sb2.ToString(), "Izvođač i njegovi događaji");
                }
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void cmdVisenaVise2_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Dogadjaj d = s.Get<Dogadjaj>(25);
                if (d != null)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine($"Događaj: {d.NAZIV}");
                    sb.AppendLine($"Broj izvođača: {d.Izvodjaci.Count}");
                    sb.AppendLine("Izvođači:");

                    foreach (Izvodjac i in d.Izvodjaci)
                    {
                        sb.AppendLine($"- {i.IME} ({i.DRZAVA_POREKLA})");
                    }

                    MessageBox.Show(sb.ToString(), "Događaj i izvođači");
                }
                Ulaznica u = s.Load<Ulaznica>(1);
                if (u != null)
                {
                    StringBuilder sb2 = new StringBuilder();
                    sb2.AppendLine($"Ulaznica: {u.DATUM_KUPOVINE} ({u.NACIN_PLACANJA})");

                    foreach (Dogadjaj g1 in u.Dogadjaji)
                    {
                        sb2.AppendLine($"- {g1.NAZIV}");
                    }

                    MessageBox.Show(sb2.ToString(), "Ulaznica i njegovi događaji");
                }
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void cmdJedanNaVise5_Click(object sender, EventArgs e)
        {
            try
            {
                using (ISession session = DataLayer.GetSession())
                {
                    Lokacija lokacija = session.Query<Lokacija>()
                        .Fetch(l => l.Dogadjaji)
                        .Where(l => l.GPS_KOORDINATE == "43.335,21.910" && l.NAZIV == "Trg Republike")
                        .SingleOrDefault();

                    if (lokacija != null)
                    {
                        NHibernateUtil.Initialize(lokacija.Dogadjaji);
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine($"Lokacija: {lokacija.NAZIV}");
                        sb.AppendLine($"Koordinate: {lokacija.GPS_KOORDINATE}");
                        sb.AppendLine("Događaji:");

                        if (lokacija.Dogadjaji != null && lokacija.Dogadjaji.Count > 0)
                        {
                            foreach (var dogadjaj in lokacija.Dogadjaji)
                            {
                                sb.AppendLine($"- {dogadjaj.NAZIV} ({dogadjaj.TIP})");
                            }
                        }
                        else
                        {
                            sb.AppendLine("Nema događaja na ovoj lokaciji.");
                        }

                        MessageBox.Show(sb.ToString(), "Lokacija i događaji");
                    }
                    else
                    {
                        MessageBox.Show("Lokacija nije pronađena.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlavnaStranica glavna = new GlavnaStranica(this);
            glavna.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void Izvodjac_Click(object sender, EventArgs e)
        {
            FormaIzvodjacDodaj forma = new FormaIzvodjacDodaj(this);
            this.Hide();
            forma.Show();
        }

        private void UlaznicaTest_Click(object sender, EventArgs e)
        {
            FormaUlazniceDodaj forma = new FormaUlazniceDodaj(this);
            forma.Show();
        }
    }
}
