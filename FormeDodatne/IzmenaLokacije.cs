using Muzicki_festival.DTOs;
using Muzicki_festival.Entiteti;
using Muzicki_festival.Forme;
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
    public partial class IzmenaLokacije : Form
    {
        private IList<DostupnaOpremaView> oprema;
        private LokacijaView lokacija;
        private readonly int idLokacije;
        private int idSelektovanaOprema = -1;
        public IzmenaLokacije(int idLokacije)
        {
            InitializeComponent();
            this.idLokacije = idLokacije;
            lokacija = DTOManager.VratiLokaciju(idLokacije);

            Naziv.Text = lokacija.Naziv;
            Opis.Text = lokacija.Opis;
            GPS.Text = lokacija.Gps_koordinate;
            MaxKapacitet.Value = lokacija.Kapacitet;

            switch (lokacija.TipLokacije)
            {
                case TipLokacije.OTVORENA:
                    InitOtvorena();
                    break;
                case TipLokacije.ZATVORENA:
                    InitZatvorena();
                    break;
                case TipLokacije.KOMBINOVANA:
                    InitKombinovana();
                    break;
            }
        }

        private void InitOtvorena()
        {
            DodatniPodaci.Hide();
            oprema = DTOManager.VratiSvuDostupnuOpremu(idLokacije);
            InitTabeluOprema();
            PopuniTabeluOprema();
        }

        private void InitZatvorena()
        {
            DostupnostOpreme.Hide();
            PopuniDodatne();
        }

        private void InitKombinovana()
        {
            PopuniDodatne();
            oprema = DTOManager.VratiSvuDostupnuOpremu(idLokacije);
            InitTabeluOprema();
            PopuniTabeluOprema();
        }

        private void InitTabeluOprema()
        {
            dataGridView1.Columns.Add("IDKolona", "ID");
            dataGridView1.Columns.Add("NazivKolona", "Naziv");
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void PopuniTabeluOprema()
        {
            dataGridView1.Rows.Clear();
            foreach (var o in oprema)
            {
                dataGridView1.Rows.Add(o.Id, o.Naziv);
            }
        }

        private void PopuniDodatne()
        {
            if (lokacija.TipLokacije == TipLokacije.ZATVORENA)
            {
                TipProstora.Text = ((ZatvorenaLokacijaView)lokacija).Tip_prostora;
                Klima.Text = ((ZatvorenaLokacijaView)lokacija).Klima;
                DostupnostSedenja.Text = ((ZatvorenaLokacijaView)lokacija).Dostupnost_sedenja;
            }
            else
            {
                TipProstora.Text = ((KombinovanaLokacijaView)lokacija).Tip_prostora;
                Klima.Text = ((KombinovanaLokacijaView)lokacija).Klima;
                DostupnostSedenja.Text = ((KombinovanaLokacijaView)lokacija).Dostupnost_sedenja;
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void PotvrdiDugme_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Opis.Text) || string.IsNullOrEmpty(Naziv.Text) || string.IsNullOrEmpty(GPS.Text))
            {
                MessageBox.Show("Niste uneli sve obavezne podatke.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (lokacija.TipLokacije)
            {
                case TipLokacije.OTVORENA:
                    OtvorenaLokacijaBasic o = new OtvorenaLokacijaBasic(lokacija.Id, Opis.Text, Naziv.Text, GPS.Text, (int)MaxKapacitet.Value);
                    if (DTOManager.IzmeniLokaciju(o))
                    {
                        MessageBox.Show("Uspešno izmenjena lokacija.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Greška", "Doslo je do greške pri izmeni lokacije", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case TipLokacije.ZATVORENA:
                    ZatvorenaLokacijaBasic z = new ZatvorenaLokacijaBasic(lokacija.Id, Opis.Text, Naziv.Text, GPS.Text, (int)MaxKapacitet.Value, TipProstora.Text, Klima.Text, DostupnostSedenja.Text);
                    if (DTOManager.IzmeniLokaciju(z))
                    {
                        MessageBox.Show("Uspešno izmenjena lokacija.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Greška", "Doslo je do greške pri izmeni lokacije", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case TipLokacije.KOMBINOVANA:
                    KombinovanaLokacijaBasic k = new KombinovanaLokacijaBasic(lokacija.Id, Opis.Text, Naziv.Text, GPS.Text, (int)MaxKapacitet.Value, TipProstora.Text, Klima.Text, DostupnostSedenja.Text);
                    if (DTOManager.IzmeniLokaciju(k))
                    {
                        MessageBox.Show("Uspešno izmenjena lokacija.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Greška", "Doslo je do greške pri izmeni lokacije", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        private void OtkaziDugme_Click(object sender, EventArgs e)
        {
            FormaLokacijaDodaj lokacijeTest = new FormaLokacijaDodaj();
            lokacijeTest.Show();
            this.Close();
        }

        private void DodajOpremu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NazivOpreme.Text))
            {
                MessageBox.Show("Niste uneli naziv opreme.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DostupnaOpremaBasic d;
            DostupnaOpremaView dv;
            switch (lokacija.TipLokacije)
            {
                case TipLokacije.OTVORENA:
                    OtvorenaLokacijaBasic o = new OtvorenaLokacijaBasic(lokacija.Id, lokacija.Opis, lokacija.Naziv, lokacija.Gps_koordinate, lokacija.Kapacitet);
                    d = new DostupnaOpremaBasic(0, NazivOpreme.Text, o);

                    dv = DTOManager.DodajDostupnuOpremu(d);
                    oprema.Add(dv);
                    MessageBox.Show($"Dodato {dv.Id} {dv.Naziv}");
                    PopuniTabeluOprema();
                    break;
                case TipLokacije.KOMBINOVANA:
                   KombinovanaLokacijaBasic k = new KombinovanaLokacijaBasic(lokacija.Id, lokacija.Opis, lokacija.Naziv, lokacija.Gps_koordinate, lokacija.Kapacitet, ((KombinovanaLokacijaView)lokacija).Tip_prostora, ((KombinovanaLokacijaView)lokacija).Klima, ((KombinovanaLokacijaView)lokacija).Dostupnost_sedenja);
                    d = new DostupnaOpremaBasic(0, NazivOpreme.Text, k);

                    dv = DTOManager.DodajDostupnuOpremu(d);
                    oprema.Add(dv); 
                    MessageBox.Show($"Dodato {dv.Id} {dv.Naziv}");
                    PopuniTabeluOprema();
                    break;
                default:
                    return;
            }

        }

        private void ObrisiOpremu_Click(object sender, EventArgs e)
        {
            int id = idSelektovanaOprema;
            var view = oprema.Where(o => o.Id == id).FirstOrDefault();
            if (view == null)
            {
                MessageBox.Show("Niste izabrali opremu za brisanje.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DostupnaOpremaBasic d;
            switch (lokacija.TipLokacije)
            {
                case TipLokacije.OTVORENA:
                    OtvorenaLokacijaBasic o = new OtvorenaLokacijaBasic(lokacija.Id, lokacija.Opis, lokacija.Naziv, lokacija.Gps_koordinate, lokacija.Kapacitet);
                    d = new DostupnaOpremaBasic(idSelektovanaOprema, NazivOpreme.Text, o);

                    break;
                case TipLokacije.KOMBINOVANA:
                    KombinovanaLokacijaBasic k = new KombinovanaLokacijaBasic(lokacija.Id, lokacija.Opis, lokacija.Naziv, lokacija.Gps_koordinate, lokacija.Kapacitet, ((KombinovanaLokacijaView)lokacija).Tip_prostora, ((KombinovanaLokacijaView)lokacija).Klima, ((KombinovanaLokacijaView)lokacija).Dostupnost_sedenja);
                    d = new DostupnaOpremaBasic(idSelektovanaOprema, NazivOpreme.Text, k);

                    break;
                default:
                    return;
            }

            if (DTOManager.ObrisiDostupnuOpremu(d))
            {
                oprema.Remove(view);
                MessageBox.Show($"Obrisano {view.Id} {view.Naziv}");
                PopuniTabeluOprema();
            }
            else
            {
                MessageBox.Show("Greška", "Doslo je do greške pri brisanju opreme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                var value = (int)row.Cells["IDKolona"].Value;
                idSelektovanaOprema = value;
            }
        }
    }
}
