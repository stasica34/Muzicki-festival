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
using Muzicki_festival.DTOs;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Muzicki_festival.Forme
{
    public partial class FormaDogadjajDodaj : Form
    {
        private Dogadjaj dogadjajzaDodavanje;
        public DogadjajView novDogadjaj = null;

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

            if (dtpKraj.Value < dtpPocetak.Value)
            {
                MessageBox.Show("Datum kraja mora biti posle datuma početka.");
                return;
            }
            if (cmbLokacija.SelectedItem == null)
            {
                MessageBox.Show("Odaberite lokaciju.");
                return;
            }

            LokacijaView lv = cmbLokacija.SelectedItem as LokacijaView;
            LokacijaBasic lb = null;
            switch (lv.TipLokacije)
            {
                case TipLokacije.ZATVORENA:
                    ZatvorenaLokacijaView zv = lv as ZatvorenaLokacijaView;
                    lb = new ZatvorenaLokacijaBasic(zv.Id, zv.Opis, zv.Naziv, zv.Gps_koordinate, zv.Kapacitet, zv.Tip_prostora, zv.Klima, zv.Dostupnost_sedenja);
                    break;
                case TipLokacije.OTVORENA:
                    OtvorenaLokacijaView ov = lv as OtvorenaLokacijaView;
                    lb = new OtvorenaLokacijaBasic(ov.Id, ov.Opis, ov.Naziv, ov.Gps_koordinate, ov.Kapacitet);
                    break;
                case TipLokacije.KOMBINOVANA:
                    KombinovanaLokacijaView kv = lv as KombinovanaLokacijaView;
                    lb = new KombinovanaLokacijaBasic(kv.Id, kv.Opis, kv.Naziv, kv.Gps_koordinate, kv.Kapacitet, kv.Tip_prostora, kv.Klima, kv.Dostupnost_sedenja);
                    break;
                default:
                    MessageBox.Show("Greska sa lokacijom!");
                    return;
            }

            DogadjajBasic db = new DogadjajBasic(0, txtNaziv.Text, (string)cmbTip.SelectedItem, txtOpis.Text, dtpPocetak.Value, dtpKraj.Value, lb, null);

            DogadjajView novi = DTOManager.DodajDogadjaj(db);

            if (novi != null)
            {
                MessageBox.Show("Uspešno dodat događaj.");
                this.DialogResult = DialogResult.OK;
                novDogadjaj = novi;
                this.Close();
            }
            else
            {
                MessageBox.Show("Greška pri dodavanju događaja. Pokušajte ponovo.");
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnDodajLokacija_Click(object sender, EventArgs e)
        {
            FormaLokacijaDodaj forma = new FormaLokacijaDodaj(this);
            this.Hide();
            forma.ShowDialog();
            this.Show();
            UcitajLokacije();
        }
        private void UcitajLokacije()
        {
            cmbLokacija.Items.Clear();

            IList<LokacijaView> lokacijeViews = DTOManager.VratiSveLokacije();
            foreach(var l in lokacijeViews)
            {
                cmbLokacija.Items.Add(l);
            }
        }

    }
}
