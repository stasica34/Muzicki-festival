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

namespace Muzicki_festival.Forme
{
    public partial class FormaDogadjajIzmeni : Form
    {
        private Dogadjaj dogadjajzaIzmenu;
        private Form parentform;

        public FormaDogadjajIzmeni(Form caller, Dogadjaj dogadjaj)
        {
            InitializeComponent();
            this.dogadjajzaIzmenu = dogadjaj;
            this.parentform = caller;
        }

        private void FormaDogadjajIzmeni_Load(object sender, EventArgs e)
        {
            
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var svelokacije = s.QueryOver<Lokacija>().List();
                    foreach (var lokacija in svelokacije)
                    {
                        cmbLokacija.Items.Add(lokacija); 
                    }
                }
                cmbTip.Items.AddRange(new string[]
                {
                   "Muzicki nastup",
                    "Radionica",
                    "Interaktivni sadrzaj",
                    "Drugi"
                });

                cmbTip.DropDownStyle = ComboBoxStyle.DropDownList;
                txtNaziv.Text = dogadjajzaIzmenu.NAZIV;
                cmbTip.SelectedItem = dogadjajzaIzmenu.TIP;
                txtOpis.Text = dogadjajzaIzmenu.OPIS;
                dtpPocetak.Value = dogadjajzaIzmenu.DATUM_VREME_POCETKA;
                dtpKraj.Value = dogadjajzaIzmenu.DATUM_VREME_KRAJA;

                foreach (Lokacija lok in cmbLokacija.Items)
                {
                    if (lok.ID.Equals(dogadjajzaIzmenu.Lokacija.ID))
                    {
                        cmbLokacija.SelectedItem = lok;
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("greška prilikom učitavanja forme za izmenu: " + ex.Message);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            string naziv = txtNaziv.Text.Trim();
            string opis = txtOpis.Text.Trim();
            if (string.IsNullOrWhiteSpace(naziv) || cmbTip.SelectedItem == null ||
                  cmbLokacija.SelectedItem == null ||
                dtpKraj.Value <= dtpPocetak.Value)
            {
                MessageBox.Show("Molimo popunite sva polja ispravno.");
                return;
            }
            if (dtpKraj.Value <= dtpPocetak.Value)
            {
                MessageBox.Show("Datum kraja mora biti strogo posle datuma početka.", "Greška u datumima", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Dogadjaj d = s.Get<Dogadjaj>(dogadjajzaIzmenu.ID);

                    d.NAZIV = naziv;
                    d.TIP = cmbTip.SelectedItem.ToString();
                    d.OPIS = string.IsNullOrEmpty(opis) ? null : opis;
                    d.DATUM_VREME_POCETKA = dtpPocetak.Value;
                    d.DATUM_VREME_KRAJA = dtpKraj.Value;
                    d.Lokacija = cmbLokacija.SelectedItem as Lokacija;

                    s.Update(d);
                    s.Flush();
                }

                MessageBox.Show("Događaj uspešno izmenjen.");
                parentform.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Izmena događaja nije uspelo. Proverite podatke.", "Neuspeh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            parentform.Show();
            this.Close();
        }
    }
}
