using Muzicki_festival.DTOs;
using Muzicki_festival.Entiteti;
using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
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
        private Form parentform;
        private readonly int idIzvodjac;
        private IzvodjacView izvodjacView;
        private MenadzerskaAgencijaView menadzerska;
        private int selektovanClanId = -1;
        public IList<ClanBendaView> clanoviBenda;
        bool otklonjenaAgencija = false;

        ComboBox agencijeCbox;
        Label AgencijaLabela;

        public FormaIzvodjacIzmeni(Form caller, int idIzvodjac)
        {
            InitializeComponent();
            parentform = caller;
            this.idIzvodjac = idIzvodjac;

            agencijeCbox = new ComboBox();
            agencijeCbox.Anchor = AnchorStyles.None;
            AgencijaLabela = new Label();
            AgencijaLabela.Anchor = AnchorStyles.None;

            InitTabeluClanovi();

            izvodjacView = DTOManager.VratiIzvodjaca(idIzvodjac);
            PopuniPodatke();
        }

        private void InitTabeluClanovi()
        {
            TabelaClanovi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            TabelaClanovi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TabelaClanovi.ReadOnly = true;
            TabelaClanovi.AllowUserToAddRows = false;
            TabelaClanovi.RowHeadersVisible = false;
            TabelaClanovi.BorderStyle = BorderStyle.None;
            TabelaClanovi.BackgroundColor = Color.WhiteSmoke;
            TabelaClanovi.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            TabelaClanovi.GridColor = Color.LightGray;

            TabelaClanovi.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

            TabelaClanovi.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            TabelaClanovi.DefaultCellStyle.SelectionForeColor = Color.White;
            TabelaClanovi.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            TabelaClanovi.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            TabelaClanovi.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            TabelaClanovi.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 90, 150);
            TabelaClanovi.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            TabelaClanovi.EnableHeadersVisualStyles = false;


            TabelaClanovi.Columns.Add("ID", "ID");
            TabelaClanovi.Columns["ID"].Visible = false;
            TabelaClanovi.Columns.Add("IME", "IME");
            TabelaClanovi.Columns.Add("INSTRUMENT", "INSTRUMENT");
        }

        private void PopuniTabeluClanovi()
        {
            TabelaClanovi.Rows.Clear();
            foreach(var c in clanoviBenda)
            {
                TabelaClanovi.Rows.Add(c.Id, c.Ime, c.Instrument);
            }
        }

        private void PopuniPodatke()
        {
            txtIme.Text = izvodjacView.Ime;
            txtDrzavaPorekla.Text = izvodjacView.Drzava_porekla;
            txtEmail.Text = izvodjacView.Email;
            txtKontaktOsoba.Text = izvodjacView.Kontakt_osoba;
            txtTelefon.Text = izvodjacView.Telefon;

            menadzerska = DTOManager.VratiMenadzerskuIzvodjaca(idIzvodjac);

            if (menadzerska == null)
            {
                IList<MenadzerskaAgencijaView> agencije = DTOManager.VratiSveMenadzerskeAgencije();
                agencijeCbox.Enabled = true;
                foreach (var a in agencije)
                    agencijeCbox.Items.Add(a);
                OtkloniAgenciju.Enabled = false;
                TableAgencija.Controls.Add(agencijeCbox, 0, 0);
                otklonjenaAgencija = true;
            }
            else
            {
                AgencijaLabela.Text = menadzerska.Naziv;
                AgencijaLabela.Enabled = true;
                TableAgencija.Controls.Add(AgencijaLabela, 0, 0);
            }

            if (izvodjacView.tipIzvodajaca == IzvodjacTip.SOLO_UMETNIK)
            {
                PanelBend.Hide();

                Solo_umetnikView sv = izvodjacView as Solo_umetnikView;
                if (sv.Svira_instrument == "DA")
                {
                    instrumentCheckbox.Checked = true;
                    instrumentTxt.Text = sv.Tip_instrumenta;
                }
            }
            else
            {
                PanelSoloUmetnik.Hide();

                clanoviBenda = DTOManager.VratiClanoveBenda(idIzvodjac);
                PopuniTabeluClanovi();
            }
        }

        private void FormaIzvodjacIzmeni_Load(object sender, EventArgs e)
        {

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIme.Text) || string.IsNullOrEmpty(txtEmail.Text)
                || string.IsNullOrEmpty(txtDrzavaPorekla.Text) || string.IsNullOrEmpty(txtKontaktOsoba.Text)
                || string.IsNullOrEmpty(txtTelefon.Text))
            {
                MessageBox.Show("Molim vas unesite sve podatke!");
            }

            MenadzerskaAgencijaBasic mb;
            if (!otklonjenaAgencija)
            {
                mb = new MenadzerskaAgencijaBasic(menadzerska.ID, menadzerska.Naziv, menadzerska.Adresa, menadzerska.KontaktOsoba, null);
            }
            else
            {
                if (agencijeCbox.SelectedItem == null)
                {
                    MessageBox.Show("Izaberite agenciju!");
                    return;
                }

                MenadzerskaAgencijaView mv = (MenadzerskaAgencijaView)agencijeCbox.SelectedItem;
                mb = new MenadzerskaAgencijaBasic(mv.ID, mv.Naziv, mv.Adresa, mv.KontaktOsoba, null);
            }

            if (izvodjacView.tipIzvodajaca == IzvodjacTip.SOLO_UMETNIK)
            {
                Solo_umetnikView sv = izvodjacView as Solo_umetnikView;

                if (instrumentCheckbox.Checked && string.IsNullOrEmpty(instrumentTxt.Text))
                {
                    MessageBox.Show("Unesite instrument za umetnika!");
                    return;
                }

                string svira = instrumentCheckbox.Checked ? "DA" : "NE";
                string instrument = instrumentCheckbox.Checked ? instrumentTxt.Text : "";

                Solo_UmetnikBasic sb = new Solo_UmetnikBasic(izvodjacView.Id, txtIme.Text, txtDrzavaPorekla.Text, txtEmail.Text, txtKontaktOsoba.Text, txtTelefon.Text, mb, svira, instrument);

                if (DTOManager.IzmeniIzvodjaca(sb))
                {
                    MessageBox.Show("Uspesno izmenjen izvodjac!");
                    parentform.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Greska pri izmeni!");
                }
            }
            else
            {
                BendBasic bend = new BendBasic(izvodjacView.Id, txtIme.Text, txtDrzavaPorekla.Text, txtEmail.Text, txtKontaktOsoba.Text, txtTelefon.Text, mb);

                if (DTOManager.IzmeniIzvodjaca(bend))
                {
                    MessageBox.Show("Uspesno izmenjen izvodjac!");
                    parentform.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Greska pri izmeni!");
                }
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            parentform.Show();
            this.Close();
        }

        private void rdbBend_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbSolo_CheckedChanged(object sender, EventArgs e)
        {

            
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DugmeDodajClana_Click(object sender, EventArgs e)
        {
            BendView bv = izvodjacView as BendView;

            BendBasic b = new BendBasic(bv.Id, bv.Ime, bv.Drzava_porekla, bv.Email, bv.Kontakt_osoba, bv.Telefon, null);
            ClanBendaBasic cb = new ClanBendaBasic(0, ImeClana.Text, InstrumentClanaBenda.Text, b);

            ClanBendaView novi = DTOManager.DodajClanaBendu(cb);

            if (novi != null)
            {
                MessageBox.Show("Uspesno dodat clan!");
                clanoviBenda.Add(novi);
                PopuniTabeluClanovi();

                return;
            }

            MessageBox.Show("Greska pri dodavanju clana!");
        }

        private void ObrisiClana_Click(object sender, EventArgs e)
        {
            if (selektovanClanId == -1)
            {
                MessageBox.Show("Izaberite clana za brisanje");
                return;
            }

            ClanBendaView cv = clanoviBenda.Where(c => c.Id == selektovanClanId).FirstOrDefault(); 
            
            if (cv == null) 
            {
                return;
            }

            BendView bv = izvodjacView as BendView;

            BendBasic b = new BendBasic(bv.Id, bv.Ime, bv.Drzava_porekla, bv.Email, bv.Kontakt_osoba, bv.Telefon, null);
            ClanBendaBasic cb = new ClanBendaBasic(cv.Id, cv.Ime, cv.Instrument, b);

            if (DTOManager.ObrisiClana(cb))
            {
                clanoviBenda.Remove(cv);
                MessageBox.Show("Izbrisan clan!");
                PopuniTabeluClanovi();
            }
            else
            {
                MessageBox.Show("Greska pri brisanju clana");
            }

            
        }

        private void instrumentCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < TabelaClanovi.Rows.Count)
            {
                var row = TabelaClanovi.Rows[e.RowIndex];
                selektovanClanId = (int)row.Cells["ID"].Value;
            }
        }

        private void OtkloniAgenciju_Click(object sender, EventArgs e)
        {

            TableAgencija.Controls.Remove(AgencijaLabela);
            OtkloniAgenciju.Enabled = false;

            IList<MenadzerskaAgencijaView> agencije = DTOManager.VratiSveMenadzerskeAgencije();
            agencijeCbox.Enabled = true;
            foreach (var a in agencije)
                agencijeCbox.Items.Add(a);
            TableAgencija.Controls.Add(agencijeCbox, 0, 0);
            otklonjenaAgencija = true;
        }

        private void AgencijaCbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
