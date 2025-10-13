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

        public FormaLokacijaDodaj()
        {
            InitializeComponent();

            lokacije = DTOManager.VratiSveLokacije();

            InitTabeluLokacije();
            PopuniTabeluLokacije();

            InitTabeluOprema();
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
            foreach (var o in oprema)
            {
                dataGridView2.Rows.Add(o.Id, o.Naziv);
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
            if (string.IsNullOrEmpty(Opis.Text) || string.IsNullOrEmpty(Naziv.Text) || string.IsNullOrEmpty(GPS.Text))
            {
                MessageBox.Show("Popunite sve obavezne podatke.");
                return;
            }

            if (radioOtvorena.Checked)
            {
                OtvorenaLokacijaBasic o = new OtvorenaLokacijaBasic(0, Opis.Text, Naziv.Text, GPS.Text, (int)MaxKapacitet.Value);

                LokacijaView l = DTOManager.DodajLokaciju(o);
                if (l != null)
                {
                    lokacije.Add(l);
                    PopuniTabeluLokacije();
                }
                else
                {
                    MessageBox.Show("Greska", "Doslo je do greske pri dodavanju otverene lokacije", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (radioZatvorena.Checked)
            {
                if (string.IsNullOrEmpty(TipProstora.Text) || string.IsNullOrEmpty(Klima.Text) || string.IsNullOrEmpty(DostupnostSedenja.Text))
                {
                    MessageBox.Show("Popunite sve obavezne podatke.");
                    return;
                }

                ZatvorenaLokacijaBasic z = new ZatvorenaLokacijaBasic(0, Opis.Text, Naziv.Text, GPS.Text, (int)MaxKapacitet.Value, TipProstora.Text, Klima.Text, DostupnostSedenja.Text);
                LokacijaView l = DTOManager.DodajLokaciju(z);
                if (l != null)
                {
                    lokacije.Add(l);
                    PopuniTabeluLokacije();
                }
                else
                {
                    MessageBox.Show("Greska", "Doslo je do greske pri dodavanju zatvorene lokacije", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (radioKombinovana.Checked)
            {
                if (string.IsNullOrEmpty(TipProstora.Text) || string.IsNullOrEmpty(Klima.Text) || string.IsNullOrEmpty(DostupnostSedenja.Text))
                {
                    MessageBox.Show("Popunite sve obavezne podatke.");
                    return;
                }

                KombinovanaLokacijaBasic k = new KombinovanaLokacijaBasic(0, Opis.Text, Naziv.Text, GPS.Text, (int)MaxKapacitet.Value, TipProstora.Text, Klima.Text, DostupnostSedenja.Text);

                LokacijaView l = DTOManager.DodajLokaciju(k);
                if (l != null)
                {
                    lokacije.Add(l);
                    PopuniTabeluLokacije();
                }
                else
                {
                    MessageBox.Show("Greska", "Doslo je do greske pri dodavanju kombinovane lokacije", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Izaberite tip lokacije.");
                return;
            }

            MessageBox.Show("Uspesno dodata lokacija.");
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
            }
        }

        private void IzmeniLokaciju_Click(object sender, EventArgs e)
        {
            if (idSelektovan == -1)
            {
                MessageBox.Show("Izaberite lokaciju za izmenu.");
                return;
            }

            IzmenaLokacije izmena = new IzmenaLokacije(idSelektovan);
            this.Hide();
            izmena.ShowDialog();
            this.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
