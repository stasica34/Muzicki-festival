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
    public partial class FormaDogadjajDodaj : Form
    {
        private Dogadjaj dogadjajzaDodavanje;

        private Form parentform;
        public FormaDogadjajDodaj(Form caller,Dogadjaj dogadjaj)
        {
            InitializeComponent();
            this.parentform = caller;
            this.dogadjajzaDodavanje = dogadjaj;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            //greska
        }

        private void FormaDogadjajDodaj_Load(object sender, EventArgs e)
        {
            cmbTip.Items.AddRange(new string[]
            {
                "Muzicki nastup",
                "Radionica",
                "Interaktivni sadrzaj",
                "Drugi"
            });
            cmbTip.DropDownStyle = ComboBoxStyle.DropDownList;
            UcitajLokacije();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            // Validacija
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                MessageBox.Show("Unesite naziv događaja.");
                return;
            }

            if (cmbTip.SelectedIndex == -1)
            {
                MessageBox.Show("Odaberite tip događaja.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtOpis.Text))
            {
                MessageBox.Show("Unesite opis događaja.");
                return;
            }

            if (dtpKraj.Value <= dtpPocetak.Value)
            {
                MessageBox.Show("Datum kraja mora biti posle datuma početka.");
                return;
            }
            if (cmbLokacija.SelectedItem == null)
            {
                MessageBox.Show("Odaberite lokaciju.");
                return;
            }
            try
            {
                ISession s = DataLayer.GetSession();
                if(cmbLokacija.SelectedItem==null)
                {
                    MessageBox.Show("Niste odabrali lokaciju.");
                    s.Close();
                    return;
                }
                Lokacija lokacija = cmbLokacija.SelectedItem as Lokacija;
                if (lokacija == null)
                {
                    MessageBox.Show("Lokacija ne postoji u bazi. Dodajte lokaciju pre unosa događaja.");
                    s.Close();
                    return;
                }

                Dogadjaj d = new Dogadjaj()
                {
                    NAZIV = txtNaziv.Text.Trim(),
                    TIP = cmbTip.SelectedItem.ToString(),
                    OPIS = txtOpis.Text.Trim(),
                    DATUM_VREME_POCETKA = dtpPocetak.Value,
                    DATUM_VREME_KRAJA = dtpKraj.Value,
                    Lokacija = lokacija
                };

                s.Save(d);
                s.Flush();
                s.Close();

                MessageBox.Show("Događaj je uspešno dodat.");
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

        private void btnDodajLokacija_Click(object sender, EventArgs e)
        {
            FormaLokacija forma = new FormaLokacija(this);
            this.Hide();
            forma.ShowDialog();
            this.Show();
            UcitajLokacije();
        }
        private void UcitajLokacije()
        {
            cmbLokacija.Items.Clear();

            try
            {
                ISession s = DataLayer.GetSession();
                var lokacije = s.Query<Lokacija>().ToList();

                foreach (var lok in lokacije)
                {
                    cmbLokacija.Items.Add(lok);
                }

                if (cmbLokacija.Items.Count > 0)
                    cmbLokacija.SelectedIndex = 0;

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju lokacija: " + ex.Message);
            }
        }

    }
}
