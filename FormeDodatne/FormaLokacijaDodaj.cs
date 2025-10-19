using Muzicki_festival.DTOs;
using Muzicki_festival.FormeDodatne;
using NHibernate.Mapping.ByCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muzicki_festival.Forme
{
    public partial class FormaLokacijaDodaj : Form
    {
        private IList<LokacijaView> lokacije;
        private IList<DostupnaOpremaView> oprema;
        private int idSelektovan = -1;
        private Form parentform;

        public FormaLokacijaDodaj(Form parentform)
        {
            InitializeComponent();

            lokacije = DTOManager.VratiSveLokacije();

            InitTabeluLokacije();
            PopuniTabeluLokacije();

            InitTabeluOprema();
            this.parentform = parentform;
        }

        private void InitTabeluLokacije()
        {
            dataGridView1.Columns.Add("IDKolona", "ID");
            dataGridView1.Columns.Add("OpisKolona", "Opis");
            dataGridView1.Columns.Add("NazivKolona", "Naziv");
            dataGridView1.Columns.Add("GPSKolona", "GPS Koordinate");
            dataGridView1.Columns.Add("KapacitetKolona", "Maksimalni Kapacitet");
            dataGridView1.Columns.Add("TipKolona", "Tip Lokacije");
            dataGridView1.Columns.Add("TipProstoraKolona", "Tip Prostora");
            dataGridView1.Columns.Add("KlimaKolona", "Klima");
            dataGridView1.Columns.Add("DostupnostSedenjaKolona", "Dostupnost Sedenja");
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.Columns["IDKolona"].Visible = false;
        }

        private void InitTabeluOprema()
        {
            dataGridView2.Columns.Add("IDKolona", "ID");
            dataGridView2.Columns.Add("NazivKolona", "Naziv");

            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AllowUserToAddRows = false;

            dataGridView2.Columns["IDKolona"].Visible = false;
        }

        private void PopuniTabeluOprema()
        {
            dataGridView2.Rows.Clear();
            if (oprema != null) 
            {
                foreach (var o in oprema)
                {
                    dataGridView2.Rows.Add(o.Id, o.Naziv);
                }
            }
            dataGridView2.Refresh();
        }

        private void PopuniTabeluLokacije()
        {
            dataGridView1.Rows.Clear();

            foreach (var l in lokacije)
            {
                switch (l.TipLokacije)
                {
                    case Entiteti.TipLokacije.OTVORENA:
                        OtvorenaLokacijaView o = (OtvorenaLokacijaView)l;
                        dataGridView1.Rows.Add(o.Id, o.Opis, o.Naziv, o.Gps_koordinate, o.Kapacitet, "Otvorena", "-", "-", "-");
                        break;
                    case Entiteti.TipLokacije.ZATVORENA:
                        ZatvorenaLokacijaView z = (ZatvorenaLokacijaView)l;
                        dataGridView1.Rows.Add(z.Id, z.Opis, z.Naziv, z.Gps_koordinate, z.Kapacitet, "Zatvorena", z.Tip_prostora, z.Klima, z.Dostupnost_sedenja);
                        break;
                    case Entiteti.TipLokacije.KOMBINOVANA:
                        KombinovanaLokacijaView k = (KombinovanaLokacijaView)l;
                        dataGridView1.Rows.Add(k.Id, k.Opis, k.Naziv, k.Gps_koordinate, k.Kapacitet, "Kombinovana", k.Tip_prostora, k.Klima, k.Dostupnost_sedenja);
                        break;
                }
            }
            dataGridView1.Refresh();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioOtvorena_CheckedChanged(object sender, EventArgs e)
        {
            PromenjenTip();
        }

        private void radioZatvorena_CheckedChanged(object sender, EventArgs e)
        {
            PromenjenTip();
        }

        private void radioKombinovana_CheckedChanged(object sender, EventArgs e)
        {
            PromenjenTip();
        }

        private void PromenjenTip()
        {
            if (radioOtvorena.Checked)
            {
                DodatniPodaci.Hide();
            }
            else
            {
                DodatniPodaci.Show();
            }
        }

        private void DodajDugme_Click(object sender, EventArgs e)
        {
            string naziv = Naziv.Text.Trim();
            string gps = GPS.Text.Trim();
            string opis = Opis.Text.Trim(); 
            int kapacitet = (int)MaxKapacitet.Value;

            if (string.IsNullOrEmpty(naziv) || string.IsNullOrEmpty(gps))
            {
                MessageBox.Show("Popunite sve obavezne podatke (Naziv, GPS).");
                return;
            }

            LokacijaView l = null;

            if (radioOtvorena.Checked)
            {
                OtvorenaLokacijaBasic o = new OtvorenaLokacijaBasic(0, opis, naziv, gps, kapacitet);

                l = DTOManager.DodajLokaciju(o);
                if (l != null)
                {
                    lokacije.Add(l);
                    PopuniTabeluLokacije();
                    MessageBox.Show("Uspesno dodata lokacija.");
                    OcistiPolja();
                }
            }
            else if (radioZatvorena.Checked)
            {
                string tipProstora = TipProstora.Text.Trim();
                string klima = Klima.Text.Trim();
                string dostupnostSedenja = DostupnostSedenja.Text.Trim();

                if (string.IsNullOrEmpty(tipProstora) || string.IsNullOrEmpty(klima) || string.IsNullOrEmpty(dostupnostSedenja))
                {
                    MessageBox.Show("Popunite sve obavezne podatke za Zatvorenu lokaciju (Tip Prostora, Klima, Dostupnost Sedenja).");
                    return;
                }

                ZatvorenaLokacijaBasic z = new ZatvorenaLokacijaBasic(0, opis, naziv, gps, kapacitet, tipProstora, klima, dostupnostSedenja);
                l = DTOManager.DodajLokaciju(z);
                if (l != null)
                {
                    lokacije.Add(l);
                    PopuniTabeluLokacije();
                    MessageBox.Show("Uspesno dodata lokacija.");
                    OcistiPolja();
                }
            }
            else if (radioKombinovana.Checked)
            {
                string tipProstora = TipProstora.Text.Trim();
                string klima = Klima.Text.Trim();
                string dostupnostSedenja = DostupnostSedenja.Text.Trim();

                if (string.IsNullOrEmpty(tipProstora) || string.IsNullOrEmpty(klima) || string.IsNullOrEmpty(dostupnostSedenja))
                {
                    MessageBox.Show("Popunite sve obavezne podatke za Kombinovanu lokaciju (Tip Prostora, Klima, Dostupnost Sedenja).");
                    return;
                }

                KombinovanaLokacijaBasic k = new KombinovanaLokacijaBasic(0, opis, naziv, gps, kapacitet, tipProstora, klima, dostupnostSedenja);

                l = DTOManager.DodajLokaciju(k);
                if (l != null)
                {
                    lokacije.Add(l);
                    PopuniTabeluLokacije();
                    MessageBox.Show("Uspesno dodata lokacija.");
                    OcistiPolja();
                }
            }
            else
            {
                MessageBox.Show("Izaberite tip lokacije.");
                return;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                var value = (int)row.Cells["IDKolona"].Value;
                idSelektovan = value;

                LokacijaView l = lokacije.Where(x => x.Id == value).FirstOrDefault();
                switch (l.TipLokacije)
                {
                    case Entiteti.TipLokacije.OTVORENA:
                    case Entiteti.TipLokacije.KOMBINOVANA:
                        oprema = DTOManager.VratiSvuDostupnuOpremu(l.Id);
                        DodatnaOpremaGroup.Enabled = true;
                        dataGridView2.Enabled = true;
                        PopuniTabeluOprema();
                        break;
                    default:
                        DodatnaOpremaGroup.Enabled = false;
                        dataGridView2.Enabled = false;
                        dataGridView2.Rows.Clear();
                        return;
                }

                IzmeniLokaciju.Enabled = true;
                DugmeObrisi.Enabled = true;
            }
        }

        private void IzmeniLokaciju_Click(object sender, EventArgs e)
        {
            if (idSelektovan == -1)
            {
                MessageBox.Show("Izaberite lokaciju za izmenu.");
                return;
            }

            IzmenaLokacije izmena = new IzmenaLokacije(idSelektovan,this);
            this.Hide();
            izmena.ShowDialog();
            this.Show();

            lokacije = DTOManager.VratiSveLokacije();
            PopuniTabeluLokacije();
            if (oprema != null) oprema.Clear(); 
            PopuniTabeluOprema();
            idSelektovan = -1;
            DugmeObrisi.Enabled = false;
            IzmeniLokaciju.Enabled = false;
        }

        private void DugmeObrisi_Click(object sender, EventArgs e)
        {
            if (idSelektovan == -1)
            {
                MessageBox.Show("Izaberite lokaciju za brisanje.");
                return;
            }

            if (MessageBox.Show(
                "Da li ste sigurni da želite da obrišete lokaciju, ovo je nepovratna radnja!",
                "Potvrda",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            if (DTOManager.ObrisiLokaciju(idSelektovan))
            {
                MessageBox.Show("Uspesno obrisana lokacija");
                LokacijaView obrisana = lokacije.Where(l => l.Id == idSelektovan).FirstOrDefault();
                lokacije.Remove(obrisana);
                PopuniTabeluLokacije();
                if (oprema != null) oprema.Clear(); 
                PopuniTabeluOprema();
                idSelektovan = -1;
                DugmeObrisi.Enabled = false;
                IzmeniLokaciju.Enabled = false;
            }
        }
        private void OcistiPolja()
        {
            Opis.Text = string.Empty;
            Naziv.Text = string.Empty;
            GPS.Text = string.Empty;
            MaxKapacitet.Value = 0;
            TipProstora.Text = string.Empty;
            Klima.Text = string.Empty;
            DostupnostSedenja.Text = string.Empty;
            radioOtvorena.Checked = true;
            idSelektovan = -1;
            DugmeObrisi.Enabled = false;
            IzmeniLokaciju.Enabled = false;
            if (oprema != null) oprema.Clear();
            PopuniTabeluOprema();
            Naziv.Focus();
        }

    }
}