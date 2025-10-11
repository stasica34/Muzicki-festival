using Muzicki_festival.DTOs;
using Muzicki_festival.Entiteti;
using Muzicki_festival.Forme;
using NHibernate;
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
    public partial class FormaIzvodjacDodaj : Form
    {
        private Form parentform;
        private IList<IzvodjacView> izvodjacViews;
        private IList<MenadzerskaAgencijaView> menadzerskaAgencijaViews;
        private IList<ClanBendaView> clanBendaViews;
        private int idSelektovan = -1;

        public FormaIzvodjacDodaj(Form caller)
        {
            InitializeComponent();
            parentform = caller;
            izvodjacViews = DTOManager.VratiSveIzvodjace();
            menadzerskaAgencijaViews = DTOManager.VratiSveMenadzerskeAgencije();
            clanBendaViews = new List<ClanBendaView>();

            InitTabeluIzvodjaci();
            PopuniTabeluIzvodjaci();

            InitTabeluClanovi();

            PopuniIzborMenadzerske();
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
        }

        private void PopuniTabeluIzvodjaci()
        {
            TabelaIzvodjaci.Rows.Clear();
            foreach (var i in izvodjacViews)
            {
                TabelaIzvodjaci.Rows.Add(i.Id, i.Ime, i.Drzava_porekla, i.Email, i.Telefon, i.Kontakt_osoba, i.tipIzvodajaca);
            }
        }

        private void PopuniIzborMenadzerske()
        {
            foreach (var m in menadzerskaAgencijaViews)
            {
                izborMenadzerske.Items.Add(m);
            }
        }

        private void PopuniTabeluClanovi()
        {
            TabelaClanovi.Rows.Clear();
            foreach (var c in clanBendaViews)
            {
                TabelaClanovi.Rows.Add(c.Id, c.Ime, c.Instrument);
            }
        }

        private void FormaIzvodjacDodaj_Load(object sender, EventArgs e)
        {
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                MessageBox.Show("Unesite ime izvodjaca.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDrzavaPorekla.Text))
            {
                MessageBox.Show("Unesite drzavu porekla izvodjaca.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Unesite email izvodjaca.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtKontaktOsoba.Text))
            {
                MessageBox.Show("Unesite kontakt osobu izvodjaca.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                MessageBox.Show("Unesite telefon izvodjaca.");
                return;
            }

            if (izborMenadzerske.SelectedItem == null)
            {
                MessageBox.Show("Izaberite menadzersku agenciju.");
                return;
            }

            MenadzerskaAgencijaView ma = (MenadzerskaAgencijaView)izborMenadzerske.SelectedItem;
            MenadzerskaAgencijaBasic mb = new MenadzerskaAgencijaBasic(ma.ID, ma.Naziv, ma.Adresa, ma.KontaktOsoba, null);

            if (BendRadio.Checked)
            {
                BendBasic novi = new BendBasic(0, txtIme.Text, txtDrzavaPorekla.Text, txtEmail.Text, txtKontaktOsoba.Text, txtTelefon.Text, mb);

                IzvodjacView dodat = DTOManager.DodajIzvodjaca(novi);

                if (dodat != null)
                {
                    MessageBox.Show($"Uspesno dodato {dodat.Id} {dodat.Ime}");
                    izvodjacViews.Add(dodat);
                    PopuniTabeluIzvodjaci();
                }
            }
            else if (SoloUmetnikRadio.Checked)
            {
                string svira = sviraCheckBox.Checked ? "DA" : "NE";

                if (sviraCheckBox.Checked && string.IsNullOrEmpty(instrumentTxt.Text))
                {
                    MessageBox.Show("Unesite instrument");
                    return;
                }

                Solo_UmetnikBasic su = new Solo_UmetnikBasic(0, txtIme.Text, txtDrzavaPorekla.Text, txtEmail.Text, txtKontaktOsoba.Text, txtTelefon.Text, mb, svira, instrumentTxt.Text);

                IzvodjacView dodat = DTOManager.DodajIzvodjaca(su);

                if (dodat != null)
                {
                    MessageBox.Show($"Uspesno dodato {dodat.Id} {dodat.Ime}");
                    izvodjacViews.Add(dodat);
                    PopuniTabeluIzvodjaci();
                }
            }
        }
        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            parentform.Show();
            this.Close();
        }

        private void btnDodajMenadzersku_Click(object sender, EventArgs e)
        {
            FormaMenaderskaAgencija forma = new FormaMenaderskaAgencija(this);
            this.Hide();
            forma.ShowDialog();
            this.Show();
            UcitajMenadzerske();
        }
        private void UcitajMenadzerske()
        {
            
        }

        private void cmdIzmeni_Click(object sender, EventArgs e)
        {

        }

        private void SoloUmetnikRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (BendRadio.Checked)
            {
                DodatniPodaciGrupa.Enabled = false;
            }
            else if (SoloUmetnikRadio.Checked)
            {
                DodatniPodaciGrupa.Enabled = true;
            }
        }

        private void BendRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (BendRadio.Checked)
            {
                DodatniPodaciGrupa.Enabled = false;
            }
            else if (SoloUmetnikRadio.Checked)
            {
                DodatniPodaciGrupa.Enabled = true;
            }
        }

        private void sviraCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sviraCheckBox.Checked)
                instrumentTxt.Enabled = true;
            else
            {
                instrumentTxt.Enabled = false;
                instrumentTxt.Text = "";
            }
        }

        private void izborMenadzerske_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Izmeni_Click(object sender, EventArgs e)
        {
            if (idSelektovan == -1)
            {
                MessageBox.Show("Izaberite izvodjaca");
                return;
            }

            FormaIzvodjacIzmeni formaIzmeni = new FormaIzvodjacIzmeni(this, idSelektovan);
            formaIzmeni.Show();
            this.Hide();
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
                    clanBendaViews = DTOManager.VratiClanoveBenda(iz.Id);
                }
                else
                {
                    clanBendaViews.Clear();
                }
                PopuniTabeluClanovi();
            }
        }

        private void FormaIzvodjacDodaj_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                izvodjacViews = DTOManager.VratiSveIzvodjace();
                PopuniTabeluIzvodjaci();

                if (clanBendaViews != null)
                {
                    clanBendaViews.Clear();
                    PopuniTabeluClanovi();
                }
            }
        }
    }
}
