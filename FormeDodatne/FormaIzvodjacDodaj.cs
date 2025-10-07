using Muzicki_festival.Entiteti;
using Muzicki_festival.Forme;
using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Muzicki_festival.FormeDodatne
{
    public partial class FormaIzvodjacDodaj : Form
    {
        private Dogadjaj dogadjaj;

        private Form parentform;

        public FormaIzvodjacDodaj(Form caller, Dogadjaj dogadjaj)
        {
            InitializeComponent();
            parentform = caller;
            this.dogadjaj = dogadjaj;
        }

        private void FormaIzvodjacDodaj_Load(object sender, EventArgs e)
        {
            UcitajMenadzerske();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                MessageBox.Show("Unesite ime izvodjaca.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDrzavaPorekla.Text))
            {
                MessageBox.Show("Unesite drzavu porekla izvodjaca.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Unesite email izvodjaca.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtKontaktOsoba.Text))
            {
                MessageBox.Show("Unesite kontakt osobu izvodjaca.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                MessageBox.Show("Unesite telefon izvodjaca.");
                return;
            }
            if (cmdMenadzerska.SelectedItem == null)
            {
                MessageBox.Show("Odaberite menadzersku agenciju.");
                return;
            }
            ISession s = DataLayer.GetSession();
            MenadzerskaAgencija menadzerskaAgencija = cmdMenadzerska.SelectedItem as MenadzerskaAgencija;
            if (menadzerskaAgencija == null)
            {
                MessageBox.Show("Menadzerska agencija ne postoji u bazi. Dodajte menadzersku agenciju pre unosa izvodjaca.");
                s.Close();
                return;
            }
            Dogadjaj dog = s.Load<Dogadjaj>(dogadjaj.ID);
            Izvodjac i = new Izvodjac()
            {
                IME = txtIme.Text.Trim(),
                DRZAVA_POREKLA = txtDrzavaPorekla.Text.Trim(),
                EMAIL = txtEmail.Text.Trim(),
                KONTAKT_OSOBA = txtKontaktOsoba.Text.Trim(),
                TELEFON = txtTelefon.Text.Trim(),
                MenadzerskaAgencija = menadzerskaAgencija
            };
            i.Dogadjaji.Add(dog);
            dog.Izvodjaci.Add(i);
            s.Save(i);
            s.Flush();
            s.Close();

            MessageBox.Show("Izvodjac je uspešno dodat.");
            parentform.Show();
            this.Close();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            parentform.Show();
            this.Close();
        }

        private void btnDodajMenadzersku_Click(object sender, EventArgs e)
        {
            FormaMenaderskaAgencija forma = new FormaMenaderskaAgencija(this);
            this.Hide();
            forma.ShowDialog();
            this.Show();
            UcitajMenadzerske();
        }
        private void UcitajMenadzerske()
        {
            cmdMenadzerska.Items.Clear();

            try
            {
                ISession s = DataLayer.GetSession();
                var magencija = s.Query<MenadzerskaAgencija>().ToList();

                foreach (var ma in magencija)
                {
                    cmdMenadzerska.Items.Add(ma);
                }

                if (cmdMenadzerska.Items.Count > 0)
                    cmdMenadzerska.SelectedIndex = 0;

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju lokacija: " + ex.Message);
            }
        }
    }
}
