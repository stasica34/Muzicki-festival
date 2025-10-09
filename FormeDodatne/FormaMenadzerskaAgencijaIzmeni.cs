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
namespace Muzicki_festival.FormeDodatne
{
    public partial class FormaMenadzerskaAgencijaIzmeni : Form
    {
        private Form privateForm;
        private MenadzerskaAgencija agencijaizmena;
        public FormaMenadzerskaAgencijaIzmeni(Form caller,MenadzerskaAgencija agencija)
        {
            InitializeComponent();
            privateForm = caller;
            this.agencijaizmena = agencija;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text) || string.IsNullOrWhiteSpace(txtAdresa.Text) ||
                string.IsNullOrWhiteSpace(txtKontaktOsoba.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                MessageBox.Show("Molimo popunite sva polja ispravno.");
                return;
            }

            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    MenadzerskaAgencija agencija = s.Get<MenadzerskaAgencija>(agencijaizmena.ID);

                    agencija.NAZIV = txtNaziv.Text.Trim();
                    agencija.ADRESA = txtAdresa.Text.Trim();
                    agencija.KONTAKT_OSOBA = txtKontaktOsoba.Text.Trim();
                    if (agencija.KONTAKTPODACI != null && agencija.KONTAKTPODACI.Count > 0)
                    {
                        agencija.KONTAKTPODACI[0].EMAIL = txtEmail.Text.Trim();
                        agencija.KONTAKTPODACI[0].TELEFON = txtTelefon.Text.Trim();
                    }

                    s.Update(agencija);
                    s.Flush();
                }

                MessageBox.Show("Događaj uspešno izmenjen.");
                privateForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            privateForm.Show();
            this.Close();
        }

        private void FormaMenadzerskaAgencijaIzmeni_Load(object sender, EventArgs e)
        {
            txtNaziv.Text = agencijaizmena.NAZIV;
            txtAdresa.Text = agencijaizmena.ADRESA;
            txtKontaktOsoba.Text = agencijaizmena.KONTAKT_OSOBA;
            if (agencijaizmena.KONTAKTPODACI != null && agencijaizmena.KONTAKTPODACI.Count > 0)
            {
                txtEmail.Text = agencijaizmena.KONTAKTPODACI[0].EMAIL;
                txtTelefon.Text = agencijaizmena.KONTAKTPODACI[0].TELEFON;
            }
        }
    }
}
