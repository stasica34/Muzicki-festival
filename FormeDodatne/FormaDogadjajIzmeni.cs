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
using Muzicki_festival.Elementi;

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
                // 1. Učitaj sve lokacije iz baze
                using (ISession s = DataLayer.GetSession())
                {
                    var sveLokacije = s.QueryOver<Lokacija>().List();

                    foreach (var lokacija in sveLokacije)
                    {
                        ComboBoxItem item = new ComboBoxItem
                        {
                            Text = $"{lokacija.Lokacija_ID.NAZIV} ({lokacija.Lokacija_ID.GPS_KOORDINATE})",
                            Value = lokacija
                        };
                        cmbLokacija.Items.Add(item);
                    }
                }

                // 2. Postavi vrednosti iz dogadjaja
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

                // 3. Selektuj trenutnu lokaciju
                foreach (ComboBoxItem item in cmbLokacija.Items)
                {
                    Lokacija lok = item.Value as Lokacija;
                    if (lok != null && lok.Lokacija_ID.Equals(dogadjajzaIzmenu.Lokacija.Lokacija_ID))
                    {
                        cmbLokacija.SelectedItem = item;
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
            if (string.IsNullOrWhiteSpace(txtNaziv.Text) || cmbTip.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtOpis.Text) || cmbLokacija.SelectedItem == null ||
                dtpKraj.Value <= dtpPocetak.Value)
            {
                MessageBox.Show("Molimo popunite sva polja ispravno.");
                return;
            }

            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Dogadjaj d = s.Get<Dogadjaj>(dogadjajzaIzmenu.ID);

                    d.NAZIV = txtNaziv.Text.Trim();
                    d.TIP = cmbTip.SelectedItem.ToString();
                    d.OPIS = txtOpis.Text.Trim();
                    d.DATUM_VREME_POCETKA = dtpPocetak.Value;
                    d.DATUM_VREME_KRAJA = dtpKraj.Value;
                    d.Lokacija = ((ComboBoxItem)cmbLokacija.SelectedItem).Value as Lokacija;

                    s.Update(d);
                    s.Flush();
                }

                MessageBox.Show("Događaj uspešno izmenjen.");
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
    }
}
