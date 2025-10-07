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
using Muzicki_festival.Forme;
namespace Muzicki_festival.FormeDodatne
{
    public partial class FormaUlazniceDodaj : Form
    {
        private Dogadjaj dogadjaj;

        private Form parentform;
        public FormaUlazniceDodaj(Form caller, Dogadjaj dogadjaj)
        {
            InitializeComponent();
            parentform = caller;
            this.dogadjaj = dogadjaj;
        }

        private void FormaUlazniceDodaj_Load(object sender, EventArgs e)
        {
            cmbPlacanje.Items.AddRange(new string[]
            {
                "Gotovina",
                "Kartica",
                "Online"
            });
            cmbPlacanje.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTip.Items.AddRange(new string[]
            {
                "Jednodnevna",
                "Visednevna",
                "Akreditacija",
                "VIP"
            });
            cmbTip.DropDownStyle = ComboBoxStyle.DropDownList;
            UcitajPosetioce();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                MessageBox.Show("Unesite naziv ulaznice.");
                return;
            }

            if (cmbPlacanje.SelectedIndex == -1)
            {
                MessageBox.Show("Odaberite nacin placanja.");
                return;
            }
            if (cmbKupac.SelectedIndex == -1)
            {
                MessageBox.Show("Odaberite kupca.");
                return;
            }
            if (nudCena.Value <= 0)
            {
                MessageBox.Show("Unesite validnu cenu ulaznice.");
                return;
            }
            if (dtpDatum.Value > DateTime.Now)
            {
                MessageBox.Show("Datum kupovine ne može biti u budućnosti.");
                return;
            }
            try
            {
                ISession s = DataLayer.GetSession();
                if (cmbPlacanje.SelectedItem == null)
                {
                    MessageBox.Show("Niste odabrali nacin placanja.");
                    s.Close();
                    return;
                }

                Posetilac posetilac = cmbKupac.SelectedItem as Posetilac;
                if (posetilac == null)
                {
                    MessageBox.Show("Posetilac ne postoji u bazi. Dodajte Vase podatke.");
                    s.Close();
                    return;
                }
                Ulaznica novaulaznica;
                string Tip = cmbTip.SelectedItem.ToString();
                switch (Tip)
                {
                    case "Jednodnevna":
                        novaulaznica = new Jednodnevna();
                        break;
                    case "Visednevna":
                        novaulaznica = new Visednevna();
                        break;
                    case "Akreditacija":
                        novaulaznica = new Akreditacija();
                        break;
                    case "VIP":
                        novaulaznica = new Vip();
                        break;
                    default:
                        MessageBox.Show("Nepoznat tip ulaznice.");
                        return;
                }
                novaulaznica.NAZIV = txtNaziv.Text.Trim();
                novaulaznica.DATUM_KUPOVINE = dtpDatum.Value;
                novaulaznica.OSNOVNA_CENA = (float)nudCena.Value;
                novaulaznica.NACIN_PLACANJA = cmbPlacanje.SelectedItem.ToString();
                novaulaznica.KUPAC_ID = posetilac;
                Dogadjaj dogadjaj = s.Load<Dogadjaj>(this.dogadjaj.ID); 
                novaulaznica.Dogadjaji.Add(dogadjaj);
                dogadjaj.Ulaznica.Add(novaulaznica);
                s.Save(novaulaznica);
                s.Flush();
                s.Close();

                MessageBox.Show("Ulaznica je uspešno dodata.");
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

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FormaPosetilac formaPosetilac = new FormaPosetilac(this);
            formaPosetilac.Show();
            this.Show();
            UcitajPosetioce();
        }
        private void UcitajPosetioce()
        {
            cmbKupac.Items.Clear();

            try
            {
                ISession s = DataLayer.GetSession();
                var posetilc = s.Query<Posetilac>().ToList();

                foreach (var p in posetilc)
                {
                    cmbKupac.Items.Add(p);
                }

                if (cmbKupac.Items.Count > 0)
                    cmbKupac.SelectedIndex = 0;

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju lokacija: " + ex.Message);
            }
        }
    }
}
