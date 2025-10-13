using Muzicki_festival.DTOs;
using Muzicki_festival.Entiteti;
using Muzicki_festival.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muzicki_festival.FormeDodatne
{
    public partial class FormaDodajIzvodjacaNaDogadjaj : Form
    {
        private DogadjajBasic dogadjajBasic;
        private Form parent;
        private IList<ClanBendaView> clanBendaViews;
        private IList<string> vokalneSposobnosti;
        private IList<string> zahtevi;
        private IList<IzvodjacView> izvodjacViews;
        private int idSelektovan = -1;

        public FormaDodajIzvodjacaNaDogadjaj(Form parent, DogadjajBasic dogadjaj)
        {
            InitializeComponent();
            this.parent = parent;
            dogadjajBasic = dogadjaj;

            clanBendaViews = new List<ClanBendaView>();
            izvodjacViews = DTOManager.VratiSveIzvodjace();

            InitTabeluIzvodjaci();
            PopuniTabeluIzvodjaci();

            InitTabeluClanovi();
            InitTabeluSposobnosti();
            InitTabeluZahtevi();

            LabelaNazivDogadjaj.Text = dogadjaj.Naziv;
        }

        private void TabelaIzvodjaci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= TabelaIzvodjaci.Rows.Count)
            {
                var row = TabelaIzvodjaci.Rows[e.RowIndex];
                idSelektovan = (int)row.Cells["ID"].Value;

                IzvodjacView iz = izvodjacViews.Where(i => i.Id == idSelektovan).FirstOrDefault();
                if (iz != null && iz.tipIzvodajaca == IzvodjacTip.BEND)
                {
                    TabelaVokalneSposobnosti.Visible = false;
                    GrupaDodatnaTabela.Text = "Clanovi benda";
                    TabelaClanovi.Visible = true;

                    clanBendaViews = DTOManager.VratiClanoveBenda(iz.Id);
                    PopuniTabeluClanovi();
                }
                else
                {
                    TabelaClanovi.Visible = false;
                    GrupaDodatnaTabela.Text = "Vokalne sposobnosti";
                    TabelaVokalneSposobnosti.Visible = true;

                    vokalneSposobnosti = DTOManager.VratiVokalneSposobnosti(iz.Id);
                    PopuniTabeluSposobnosti();
                }

                zahtevi = DTOManager.VratiTehnickeZahteve(iz.Id);
                PopuniTabeluZahtevi();
            }
        }

        private void InitTabeluIzvodjaci()
        {
            TabelaIzvodjaci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            TabelaIzvodjaci.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TabelaIzvodjaci.ReadOnly = true;
            TabelaIzvodjaci.AllowUserToAddRows = false;
            TabelaIzvodjaci.RowHeadersVisible = false;
            TabelaIzvodjaci.BorderStyle = BorderStyle.None;
            TabelaIzvodjaci.BackgroundColor = Color.WhiteSmoke;
            TabelaIzvodjaci.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            TabelaIzvodjaci.GridColor = Color.LightGray;

            TabelaIzvodjaci.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

            TabelaIzvodjaci.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            TabelaIzvodjaci.DefaultCellStyle.SelectionForeColor = Color.White;
            TabelaIzvodjaci.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            TabelaIzvodjaci.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            TabelaIzvodjaci.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            TabelaIzvodjaci.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 90, 150);
            TabelaIzvodjaci.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            TabelaIzvodjaci.EnableHeadersVisualStyles = false;


            TabelaIzvodjaci.Columns.Add("ID", "ID");
            TabelaIzvodjaci.Columns["ID"].Visible = false;
            TabelaIzvodjaci.Columns.Add("IME", "IME");
            TabelaIzvodjaci.Columns.Add("DRZAVA_POREKA", "DRZAVA_POREKLA");
            TabelaIzvodjaci.Columns.Add("EMAIL", "EMAIL");
            TabelaIzvodjaci.Columns.Add("TELEFON", "TELEFON");
            TabelaIzvodjaci.Columns.Add("KONTAKT_OSOBA", "KONTAKT_OSOBA");
            TabelaIzvodjaci.Columns.Add("ZANR", "ZANR");
            TabelaIzvodjaci.Columns.Add("TIP", "TIP");
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
            TabelaZahtevi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            TabelaZahtevi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TabelaZahtevi.ReadOnly = true;
            TabelaZahtevi.AllowUserToAddRows = false;
            TabelaZahtevi.RowHeadersVisible = false;
            TabelaZahtevi.BorderStyle = BorderStyle.None;
            TabelaZahtevi.BackgroundColor = Color.WhiteSmoke;
            TabelaZahtevi.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            TabelaZahtevi.GridColor = Color.LightGray;

            TabelaZahtevi.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

            TabelaZahtevi.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            TabelaZahtevi.DefaultCellStyle.SelectionForeColor = Color.White;
            TabelaZahtevi.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            TabelaZahtevi.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            TabelaZahtevi.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            TabelaZahtevi.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 90, 150);
            TabelaZahtevi.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            TabelaZahtevi.EnableHeadersVisualStyles = false;


            TabelaZahtevi.Columns.Add("ZAHTEV", "ZAHTEV");
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

        private void PopuniTabeluIzvodjaci()
        {
            TabelaIzvodjaci.Rows.Clear();
            foreach (var i in izvodjacViews)
            {
                TabelaIzvodjaci.Rows.Add(i.Id, i.Ime, i.Drzava_porekla, i.Email, i.Telefon, i.Kontakt_osoba, i.Zanr, i.tipIzvodajaca);
            }
        }

        private void PopuniTabeluClanovi()
        {
            TabelaClanovi.Rows.Clear();
            foreach (var c in clanBendaViews)
            {
                TabelaClanovi.Rows.Add(c.Id, c.Ime, c.Instrument, c.Uloga);
            }
        }

        private void PopuniTabeluSposobnosti()
        {
            TabelaVokalneSposobnosti.Rows.Clear();
            foreach (var s in vokalneSposobnosti)
            {
                TabelaVokalneSposobnosti.Rows.Add(s);
            }
        }

        private void PopuniTabeluZahtevi()
        {
            TabelaZahtevi.Rows.Clear();
            foreach (var z in zahtevi)
            {
                TabelaZahtevi.Rows.Add(z);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DugmeDodajIzvodjaca_Click(object sender, EventArgs e)
        {
            if (idSelektovan == -1)
            {
                MessageBox.Show("Prvo izaberite izvodjaca duplim klikom na vrstu u tabeli");
                return;
            }

            if (DTOManager.DodajIzvodjacaNaDogadjaj(dogadjajBasic.Id, idSelektovan))
            {
                MessageBox.Show("Uspesno dodat izvodjac!");
                return;
            }

            MessageBox.Show("Greska pri dodavanju izvodjaca na dogadjaj!");
        }

        private void RadSaIzvodjacimaDugme_Click(object sender, EventArgs e)
        {
            FormaIzvodjacDodaj forma = new FormaIzvodjacDodaj(this, dogadjajBasic);
            this.Hide();
            forma.ShowDialog();
            this.Show();
        }
    }
}
