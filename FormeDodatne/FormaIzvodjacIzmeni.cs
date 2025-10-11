using Muzicki_festival.Entiteti;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Muzicki_festival.FormeDodatne
{
    public partial class FormaIzvodjacIzmeni : Form
    {
        private Izvodjac izvodjacZaIzmenu;
        private Form parentform;
        public FormaIzvodjacIzmeni(Form caller, Izvodjac izvodjac)
        {
            InitializeComponent();
            parentform = caller;
            this.izvodjacZaIzmenu = izvodjac;
        }

        private void FormaIzvodjacIzmeni_Load(object sender, EventArgs e)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var svemenadzerske = s.QueryOver<MenadzerskaAgencija>().List();
                    foreach (var agencija in svemenadzerske)
                    {
                        cmdMenadzerska.Items.Add(agencija);
                    }
                }
                cmdMenadzerska.DropDownStyle = ComboBoxStyle.DropDownList;
                txtIme.Text = izvodjacZaIzmenu.IME;
                txtDrzavaPorekla.Text = izvodjacZaIzmenu.DRZAVA_POREKLA;
                txtEmail.Text = izvodjacZaIzmenu.EMAIL;
                txtKontaktOsoba.Text = izvodjacZaIzmenu.KONTAKT_OSOBA;

                foreach (MenadzerskaAgencija agencija in cmdMenadzerska.Items)
                {
                    if (agencija.ID.Equals(izvodjacZaIzmenu.MenadzerskaAgencija.ID))
                    {
                        cmdMenadzerska.SelectedItem = agencija;
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom učitavanja forme za izmenu: " + ex.Message);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text) || string.IsNullOrWhiteSpace(txtDrzavaPorekla.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtTelefon.Text) ||
                 string.IsNullOrWhiteSpace(txtKontaktOsoba.Text) || cmdMenadzerska.SelectedItem == null
                )
            {
                MessageBox.Show("Molimo popunite sva polja ispravno.");
                return;
            }

            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Izvodjac i = s.Get<Izvodjac>(izvodjacZaIzmenu.ID);

                    i.IME = txtIme.Text.Trim();
                    i.DRZAVA_POREKLA = txtDrzavaPorekla.Text.Trim();
                    i.EMAIL = txtEmail.Text.Trim();
                    i.KONTAKT_OSOBA = txtKontaktOsoba.Text.Trim();
                    i.Telefoni = new List<string> { txtTelefon.Text.Trim() };
                    i.MenadzerskaAgencija = cmdMenadzerska.SelectedItem as MenadzerskaAgencija;

                    s.Update(i);
                    s.Flush();
                }
                bool novaJeSolo = rdbSolo.Checked;
                bool staraJeSolo = izvodjacZaIzmenu is Solo_Umetnik;
                MessageBox.Show("Izvodjac uspešno izmenjen.");
                parentform.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            parentform.Show();
            this.Close();
        }

        private void rdbBend_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBend.Checked)
            {
                FormaSoloIzvodjacBendIzmeni forma = new FormaSoloIzvodjacBendIzmeni(
                  this,
                  false,
                  txtIme.Text.Trim(),
                  txtDrzavaPorekla.Text.Trim(),
                  txtEmail.Text.Trim(),
                  txtKontaktOsoba.Text.Trim(),
                  txtTelefon.Text.Trim(),
                  cmdMenadzerska.SelectedItem as MenadzerskaAgencija,
                  izvodjacZaIzmenu.ID
                );
                this.Hide();
                forma.ShowDialog();
                this.Show();
            }
        }

        private void rdbSolo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSolo.Checked)
            {
                FormaSoloIzvodjacBendIzmeni forma = new FormaSoloIzvodjacBendIzmeni(
                  this,
                  true,
                  txtIme.Text.Trim(),
                  txtDrzavaPorekla.Text.Trim(),
                  txtEmail.Text.Trim(),
                  txtKontaktOsoba.Text.Trim(),
                  txtTelefon.Text.Trim(),
                  cmdMenadzerska.SelectedItem as MenadzerskaAgencija,
                  izvodjacZaIzmenu.ID
                );
                this.Hide();
                forma.ShowDialog();
                this.Show();
            }
        }
    }
}
