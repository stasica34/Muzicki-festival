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
        private IList<string> zahtevi;
        private IList<string> sposobnosti;

        private int selektovanZahtevRowId = -1;
        private int selektovanaSposobnostRowId = -1;

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
            InitTabeluSposobnosti();
            InitTabeluZahtevi();

            izvodjacView = DTOManager.VratiIzvodjaca(idIzvodjac);
            zahtevi = DTOManager.VratiTehnickeZahteve(idIzvodjac);

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
            TabelaClanovi.Columns.Add("ULOGA", "ULOGA");
        }

        private void InitTabeluZahtevi()
        {
            TabelaTehnickiZahtevi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            TabelaTehnickiZahtevi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TabelaTehnickiZahtevi.ReadOnly = true;
            TabelaTehnickiZahtevi.AllowUserToAddRows = false;
            TabelaTehnickiZahtevi.RowHeadersVisible = false;
            TabelaTehnickiZahtevi.BorderStyle = BorderStyle.None;
            TabelaTehnickiZahtevi.BackgroundColor = Color.WhiteSmoke;
            TabelaTehnickiZahtevi.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            TabelaTehnickiZahtevi.GridColor = Color.LightGray;

            TabelaTehnickiZahtevi.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

            TabelaTehnickiZahtevi.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            TabelaTehnickiZahtevi.DefaultCellStyle.SelectionForeColor = Color.White;
            TabelaTehnickiZahtevi.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            TabelaTehnickiZahtevi.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            TabelaTehnickiZahtevi.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            TabelaTehnickiZahtevi.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 90, 150);
            TabelaTehnickiZahtevi.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            TabelaTehnickiZahtevi.EnableHeadersVisualStyles = false;


            TabelaTehnickiZahtevi.Columns.Add("ZAHTEV", "ZAHTEV");
        }

        private void InitTabeluSposobnosti()
        {
            TabelaVokalneSposobnosti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            TabelaVokalneSposobnosti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TabelaVokalneSposobnosti.ReadOnly = true;
            TabelaVokalneSposobnosti.AllowUserToAddRows = false;
            TabelaVokalneSposobnosti.RowHeadersVisible = false;
            TabelaVokalneSposobnosti.BorderStyle = BorderStyle.None;
            TabelaVokalneSposobnosti.BackgroundColor = Color.WhiteSmoke;
            TabelaVokalneSposobnosti.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            TabelaVokalneSposobnosti.GridColor = Color.LightGray;

            TabelaVokalneSposobnosti.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

            TabelaVokalneSposobnosti.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            TabelaVokalneSposobnosti.DefaultCellStyle.SelectionForeColor = Color.White;
            TabelaVokalneSposobnosti.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            TabelaVokalneSposobnosti.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            TabelaVokalneSposobnosti.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            TabelaVokalneSposobnosti.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 90, 150);
            TabelaVokalneSposobnosti.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            TabelaVokalneSposobnosti.EnableHeadersVisualStyles = false;

            TabelaVokalneSposobnosti.Columns.Add("SPOSOBNOST", "SPOSOBNOST");
        }

        private void PopuniTabeluZahtevi()
        {
            TabelaTehnickiZahtevi.Rows.Clear();
            foreach (var z in zahtevi)
                TabelaTehnickiZahtevi.Rows.Add(z);
        }

        private void PopuniTabeluSposobnosti()
        {
            TabelaVokalneSposobnosti.Rows.Clear();
            foreach (var s in sposobnosti)
            {
                TabelaVokalneSposobnosti.Rows.Add(s);
            }
        }

        private void PopuniTabeluClanovi()
        {
            TabelaClanovi.Rows.Clear();
            foreach(var c in clanoviBenda)
            {
                TabelaClanovi.Rows.Add(c.Id, c.Ime, c.Instrument, c.Uloga);
            }
        }

        private void PopuniPodatke()
        {
            txtIme.Text = izvodjacView.Ime;
            txtDrzavaPorekla.Text = izvodjacView.Drzava_porekla;
            txtEmail.Text = izvodjacView.Email;
            txtKontaktOsoba.Text = izvodjacView.Kontakt_osoba;
            txtTelefon.Text = izvodjacView.Telefon;
            txtZanr.Text = izvodjacView.Zanr;

            menadzerska = DTOManager.VratiMenadzerskuIzvodjaca(idIzvodjac);

            PopuniTabeluZahtevi();

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

                sposobnosti = DTOManager.VratiVokalneSposobnosti(idIzvodjac);
                PopuniTabeluSposobnosti();
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

                Solo_UmetnikBasic sb = new Solo_UmetnikBasic(izvodjacView.Id, txtIme.Text, txtDrzavaPorekla.Text, txtEmail.Text, txtKontaktOsoba.Text, txtTelefon.Text, txtZanr.Text, mb, null, svira, instrument);

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
                BendBasic bend = new BendBasic(izvodjacView.Id, txtIme.Text, txtDrzavaPorekla.Text, txtEmail.Text, txtKontaktOsoba.Text, txtZanr.Text, txtTelefon.Text, mb, null);

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
            if (string.IsNullOrWhiteSpace(ImeClana.Text) || string.IsNullOrWhiteSpace(InstrumentClanaBenda.Text) || string.IsNullOrWhiteSpace(txtUlogaClana.Text))
            {
                MessageBox.Show("Unesite sve podatke za clana!");
                return;
            }

            BendView bv = izvodjacView as BendView;

            BendBasic b = new BendBasic(bv.Id, bv.Ime, bv.Drzava_porekla, bv.Email, bv.Kontakt_osoba, bv.Telefon, txtZanr.Text, null, null);
            ClanBendaBasic cb = new ClanBendaBasic(0, ImeClana.Text, InstrumentClanaBenda.Text, txtUlogaClana.Text, b);

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

            BendBasic b = new BendBasic(bv.Id, bv.Ime, bv.Drzava_porekla, bv.Email, bv.Kontakt_osoba, bv.Telefon, txtZanr.Text, null, null);
            ClanBendaBasic cb = new ClanBendaBasic(cv.Id, cv.Ime, cv.Instrument, cv.Uloga, b);

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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void DugmeDodajZahtev_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtZahtev.Text))
            {
                MessageBox.Show("Unesite novi zahtev");
                return;
            }

            if (DTOManager.DodajTehnickiZahtev(idIzvodjac, txtZahtev.Text))
            {
                MessageBox.Show("Uspesno dodat zahtev " + txtZahtev.Text);
                zahtevi.Add(txtZahtev.Text);
                PopuniTabeluZahtevi();
            }
            else
            {
                MessageBox.Show("Greska pri dodavanju", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DugmeObrisiZahtev_Click(object sender, EventArgs e)
        {
            if (selektovanZahtevRowId == -1)
            {
                MessageBox.Show("Izaberite zahtev za brisanje");
                return;
            }

            string zahtev = (string)TabelaTehnickiZahtevi.Rows[selektovanZahtevRowId].Cells["ZAHTEV"].Value;

            if (DTOManager.ObrisiTehnickiZahtev(idIzvodjac, zahtev))
            {
                MessageBox.Show("Uspesno obrisan zahtev " + zahtev);
                zahtevi.Remove(zahtev);
                PopuniTabeluZahtevi();
            }
            else
            {
                MessageBox.Show("Greska pri brisanju", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DugmeDodajSposobnost_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSposobnost.Text))
            {
                MessageBox.Show("Unesti sposobnost!");
                return;
            }

            if (DTOManager.DodajVokalnuSposobnost(idIzvodjac, txtSposobnost.Text))
            {
                MessageBox.Show("Dodata sposobnost " +  txtSposobnost.Text);
                sposobnosti.Add(txtSposobnost.Text);
                PopuniTabeluSposobnosti();
            }
        }

        private void DugmeObrisiSposobnost_Click(object sender, EventArgs e)
        {
            if (selektovanaSposobnostRowId == -1)
            {
                MessageBox.Show("Izaberite zahtev za brisanje");
                return;
            }

            string sposobnost = (string)TabelaVokalneSposobnosti.Rows[selektovanaSposobnostRowId].Cells["SPOSOBNOST"].Value;

            if (DTOManager.ObrisiVokalnuSposobnost(idIzvodjac, sposobnost))
            {
                MessageBox.Show("Uspesno obrisana sposobnost " + sposobnost);
                sposobnosti.Remove(sposobnost);
                PopuniTabeluSposobnosti();
            }
            else
            {
                MessageBox.Show("Greska pri brisanju", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TabelaTehnickiZahtevi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < TabelaTehnickiZahtevi.Rows.Count)
            {
                selektovanZahtevRowId = e.RowIndex;
            }    
        }

        private void TabelaVokalneSposobnosti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= TabelaVokalneSposobnosti.Rows.Count)
            {
                selektovanaSposobnostRowId = e.RowIndex;
            }
        }
    }
}
