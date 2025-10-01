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
using Muzicki_festival.Forme;
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
            try
            {
                using (var session = DataLayer.GetSession())
                {
                    MessageBox.Show("Sesija uspešno otvorena!");

                    using (var transaction = session.BeginTransaction())
                    {
                        var rezultat = session.CreateSQLQuery("SELECT 'NHibernate OK' AS status FROM dual")
                                              .UniqueResult();
                        MessageBox.Show("SQL test uspešan: " + rezultat.ToString());
                        transaction.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void cmdDodavanje_Click(object sender, EventArgs e)
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

        private void cmd_TelefonPosetilac_Click(object sender, EventArgs e)
        {
            FormaTelefonPosetilac formaTelefonPosetilac = new FormaTelefonPosetilac(this);
            formaTelefonPosetilac.Show();
            this.Hide();
        }

        private void cmd_JeClan_Click(object sender, EventArgs e)
        {
            FormaJeClan formaJeClan = new FormaJeClan(this);
            formaJeClan.Show();
            this.Hide();
        }

        private void cmd_Ulaznica_Click(object sender, EventArgs e)
        {
            FormaUlaznica formaUlaznica = new FormaUlaznica(this);
            formaUlaznica.Show();
            this.Hide();
        }

        private void cmd_Bend_Click(object sender, EventArgs e)
        {
            FormaClan formaClan = new FormaClan(this);
            formaClan.Show();
            this.Hide();
        }

        private void cmd_Izvodjac_Click(object sender, EventArgs e)
        {
            FormaIzvodjac formaIzvodjac = new FormaIzvodjac(this);
            formaIzvodjac.Show();
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

        private void cmd_Nastupa_Click(object sender, EventArgs e)
        {
            FormaNastupa formaNastupa = new FormaNastupa(this);
            formaNastupa.Show();
            this.Hide();
        }

        private void cmd_Omogucava_Ulaz_na_Click(object sender, EventArgs e)
        {
            FormaOmogucavaUlazNa formaomogucavaUlazNa = new FormaOmogucavaUlazNa(this);
            formaomogucavaUlazNa.Show();
            this.Hide();
        }

        private void cmd_OtvorenaLokacija_Click(object sender, EventArgs e)
        {
            FormaOtvorenaLokacija formaotvorenaLokacija = new FormaOtvorenaLokacija(this);
            formaotvorenaLokacija.Show();
            this.Hide();
        }

        private void cmd_TelefonIzvodjac_Click(object sender, EventArgs e)
        {
            FormaTelefonIzvodjac formaTelefonIzvodjac = new FormaTelefonIzvodjac(this);
            formaTelefonIzvodjac.Show();
            this.Hide();
        }

        private void cmd_Vip_Click(object sender, EventArgs e)
        {
            FormaVip formaVip = new FormaVip(this);
            formaVip.Show();
            this.Hide();
        }

        private void cmd_VipPogodnosti_Click(object sender, EventArgs e)
        {
            FormaVipPogodnosti formaVipPogodnosti = new FormaVipPogodnosti(this);
            formaVipPogodnosti.Show();
            this.Hide();
        }

        private void cmd_Visednevna_Click(object sender, EventArgs e)
        {
            FormaVisednevna formaVisednevna = new FormaVisednevna(this);
            formaVisednevna.Show();
            this.Hide();
        }

        private void cmd_VisednevnaDani_Click(object sender, EventArgs e)
        {
            FormaVisednevnaDani formaVisednevnadani = new FormaVisednevnaDani(this);
            formaVisednevnadani.Show();
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
            //izmedju posetioca i ulaznice
            try
            {
                ISession session = DataLayer.GetSession();
                Muzicki_festival.Entiteti.Posetilac p = session.Get<Muzicki_festival.Entiteti.Posetilac>(1);
                foreach (var ulaznica in p.Ulaznice)
                {
                    MessageBox.Show("Ulaznica: " + ulaznica.NAZIV);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }
        //rezultat treba da ide, bez obzira da li se ide 1:n ili n:1

        private void cmd_ViseNaJedan_Click(object sender, EventArgs e)
        {
            //ulaznica i posetilac
            try
            {
                ISession session = DataLayer.GetSession();
                Ulaznica u = session.Load<Ulaznica>(1);
                MessageBox.Show($"Ulaznica: {u.NAZIV},\nKupac: {u.KUPAC_ID.IME} {u.KUPAC_ID.PREZIME}", "Detalji");
                session.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
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
            //clan i grupa
            //ovde je komplikovano  jer je kompozitni kljuc u pitanju
            try
            {
                ISession session = DataLayer.GetSession();

                // 1. Učitaj bend koji je deo kompozitnog ključa
                Bend bend = session.Load<Bend>(6);

                // 2. Napravi ClanID (kompozitni ključ)
                ClanID clanId = new ClanID
                {
                    IME = "Marko Jovanović",            
                    INSTRUMENT = "Gitara",    
                    BEND_ID = bend
                };

                // 3. Učitaj Clan po kompozitnom ključu
                Clan clan = session.Get<Clan>(clanId);

                if (clan != null)
                {
                    MessageBox.Show($"Ime: {clan.IME},\nBend: {clan.BEND_ID.BROJ_CLANOVA}", "Detalji");
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
        }

        private void cmdJedanNaVise3_Click(object sender, EventArgs e)
        {
            //izmedju benda i clana
            try
            {
                ISession session = DataLayer.GetSession();
                Muzicki_festival.Entiteti.Bend bend = session.Get<Muzicki_festival.Entiteti.Bend>(6);
                foreach (var clan in bend.Clanovi)
                {
                    MessageBox.Show("Clanovi: " + clan.IME);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }
    }
}
