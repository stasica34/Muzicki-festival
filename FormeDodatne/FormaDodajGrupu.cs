using Muzicki_festival.DTOs;
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
    public partial class FormaDodajGrupu : Form
    {
        private IList<AgencijaOrganizatorView> agencijaOrganizatorViews;
        private IList<GrupaView> grupaViews = new List<GrupaView>();
        private int selektovanaGrupaId = -1;
        private Form parentform;

        Label labelaAgencija = new Label();
        ComboBox cmbAgencijeIzmena = new ComboBox();

        public FormaDodajGrupu(Form parentform)
        {
            InitializeComponent();

            agencijaOrganizatorViews = DTOManager.VratiSveAgencije();
            PopuniCmbBoxAgencije();

            grupaViews = DTOManager.VratiSveGrupe();
            InitTabeluGrupe();
            PopuniTabeluGrupe();

            InitTabeluClanovi();
            ResetujFormu();

            labelaAgencija.Enabled = false;
            cmbAgencijeIzmena.Enabled = false;

            labelaAgencija.Anchor = AnchorStyles.None;
            cmbAgencijeIzmena.Anchor = AnchorStyles.None;
            this.parentform = parentform;
        }

        private void InitTabeluGrupe()
        {
            TabelaGrupe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            TabelaGrupe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TabelaGrupe.ReadOnly = true;
            TabelaGrupe.AllowUserToAddRows = false;
            TabelaGrupe.RowHeadersVisible = false;
            TabelaGrupe.BorderStyle = BorderStyle.None;
            TabelaGrupe.BackgroundColor = Color.WhiteSmoke;
            TabelaGrupe.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            TabelaGrupe.GridColor = Color.LightGray;

            TabelaGrupe.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

            TabelaGrupe.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            TabelaGrupe.DefaultCellStyle.SelectionForeColor = Color.White;
            TabelaGrupe.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            TabelaGrupe.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            TabelaGrupe.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            TabelaGrupe.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 90, 150);
            TabelaGrupe.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            TabelaGrupe.EnableHeadersVisualStyles = false;

            TabelaGrupe.Columns.Add("ID", "ID");
            TabelaGrupe.Columns["ID"].Visible = false;

            TabelaGrupe.Columns.Add("NAZIV", "NAZIV");
            TabelaGrupe.Columns.Add("AGENCIJA", "AGENCIJA");
        }
        private void PopuniTabeluGrupe()
        {
            TabelaGrupe.Rows.Clear();
            foreach (var g in grupaViews)
                TabelaGrupe.Rows.Add(g.Id, g.Naziv, g.NazivAgencije);
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

            TabelaClanovi.Columns.Add("IME_CLANA", "IME_CLANA");
        }

        private void PopuniTabeluClanovi()
        {
            TabelaClanovi.Rows.Clear();
            var grupa = grupaViews.Where(g => g.Id == selektovanaGrupaId).FirstOrDefault();
            if (grupa != null)
            {
                var imena = grupa.Clanovi;
                foreach (var i in imena)
                {
                    TabelaClanovi.Rows.Add(i);
                }
            }
        }

        private void PopuniCmbBoxAgencije()
        {
            cmbAgencije.Items.Clear();
            foreach (var a in agencijaOrganizatorViews)
                cmbAgencije.Items.Add(a);
        }

        private void DugmeDodajAgenciju_Click(object sender, EventArgs e)
        {
            FormaDodajAgencijuOrganizator forma = new FormaDodajAgencijuOrganizator(this);
            this.Hide();
            forma.ShowDialog();
            this.Show();

            agencijaOrganizatorViews = DTOManager.VratiSveAgencije();
            PopuniCmbBoxAgencije();
        }

        private void DugmeDodaj_Click(object sender, EventArgs e)
        {
            var naziv = txtNaziv.Text.Trim();
            if (string.IsNullOrWhiteSpace(naziv))
            {
                MessageBox.Show("Unesite naziv!");
                return;
            }

            if (cmbAgencije.SelectedItem == null)
            {
                MessageBox.Show("Izaberite agenciju!");
                return;
            }

            AgencijaOrganizatorView av = cmbAgencije.SelectedItem as AgencijaOrganizatorView;
            AgencijaOrganizatorBasic ab = new AgencijaOrganizatorBasic(av.Id, av.Naziv, av.Adresa, null);
            GrupaBasic gb = new GrupaBasic(0, naziv, ab, null);

            GrupaView nova = DTOManager.DodajGrupu(gb);

            if (nova != null)
            {
                MessageBox.Show("Uspesno dodata grupa!");
                grupaViews = DTOManager.VratiSveGrupe();
                PopuniTabeluGrupe();
                TabelaGrupe.ClearSelection();
                TabelaClanovi.Rows.Clear();
                txtNaziv.Clear();
                cmbAgencije.SelectedIndex = -1;
            }
        }

        private void DugmeOtkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void IzmeniDugme_Click(object sender, EventArgs e)
        {
            if (selektovanaGrupaId == -1)
            {
                MessageBox.Show("Izaberite grupu!");
                return;
            }

            GrupaNova.Enabled = false;
            GrupaIzmena.Enabled = true;
            Tabele.Enabled = false;
            
            GrupaView gb = grupaViews.Where(g => g.Id == selektovanaGrupaId).FirstOrDefault();

            txtNazivIzmena.Text = gb.Naziv;
            PrikaziStaruAgenciju(gb.NazivAgencije);
        }

        private void DugmeObrisi_Click(object sender, EventArgs e)
        {
            if (selektovanaGrupaId == -1)
            {
                MessageBox.Show("Prvo izaberite grupu!");
                return;
            }

            if (DTOManager.ObrisiGrupu(selektovanaGrupaId))
            {
                MessageBox.Show("Uspesno obrisana grupa!");

                var obrisana = grupaViews.Where(g => g.Id == selektovanaGrupaId).FirstOrDefault();
                grupaViews.Remove(obrisana);
                PopuniTabeluGrupe();
                ResetujFormu();

                PopuniTabeluClanovi();
                selektovanaGrupaId = -1;

                DugmeObrisi.Enabled = false;
                IzmeniDugme.Enabled = false;
            }
        }

        private void TabelaGrupe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < TabelaGrupe.Rows.Count)
            {
                var row = TabelaGrupe.Rows[e.RowIndex];
                int id = (int)row.Cells["ID"].Value;
                selektovanaGrupaId = id;
                PopuniTabeluClanovi();

                DugmeObrisi.Enabled = true;
                IzmeniDugme.Enabled = true;
                TabelaGrupe.ClearSelection();
                TabelaGrupe.Rows[e.RowIndex].Selected = true;

            }
        }

        private void DugmePromeniAgenciju_Click(object sender, EventArgs e)
        {
            DugmePromeniAgenciju.Enabled = false;
            TableLayoutAgencija.Controls.Remove(labelaAgencija);
            labelaAgencija.Enabled = false;
            OmoguciPromenuAgencije();
        }

        private void PotvrdiIzmeneDugme_Click(object sender, EventArgs e)
        {
            var naziv = txtNazivIzmena.Text.Trim();
            if (string.IsNullOrWhiteSpace(naziv))
            {
                MessageBox.Show("Unesite naziv!");
                return;
            }

            if (cmbAgencijeIzmena.Enabled && cmbAgencijeIzmena.SelectedItem == null)
            {
                MessageBox.Show("Izaberite agenciju!");
                return;
            }

            AgencijaOrganizatorBasic ab = null;
            if (cmbAgencijeIzmena.Enabled && cmbAgencijeIzmena.SelectedItem != null)
            {
                var av = cmbAgencijeIzmena.SelectedItem as AgencijaOrganizatorView;
                ab = new AgencijaOrganizatorBasic(av.Id, av.Naziv, av.Adresa, null);
            }
            else
            {
                var staraGrupa = grupaViews.FirstOrDefault(g => g.Id == selektovanaGrupaId);
                var staraAgencija = agencijaOrganizatorViews.FirstOrDefault(a => a.Naziv == staraGrupa.NazivAgencije);
                if (staraAgencija != null)
                    ab = new AgencijaOrganizatorBasic(staraAgencija.Id, staraAgencija.Naziv, staraAgencija.Adresa, null);
            }

            GrupaBasic gb = new GrupaBasic(selektovanaGrupaId, naziv, ab, null);

            if (DTOManager.IzmeniGrupu(gb))
            {
                MessageBox.Show("Uspesno izmenjena grupa!");
                var izmenjena = grupaViews.Where(g => g.Id == selektovanaGrupaId).FirstOrDefault();

                grupaViews = DTOManager.VratiSveGrupe();
                PopuniTabeluGrupe();
                PopuniTabeluClanovi();
                txtNazivIzmena.Text = "";

                TableLayoutAgencija.Controls.Remove(cmbAgencijeIzmena);
                TableLayoutAgencija.Controls.Remove(labelaAgencija);
                ResetujFormu();
            }
        }

        private void OtkaziIzmene_Click(object sender, EventArgs e)
        {

            ResetujFormu();
        }
        private void ResetujFormu()
        {
            selektovanaGrupaId = -1;
            DugmeObrisi.Enabled = false;
            IzmeniDugme.Enabled = false;
            TabelaGrupe.ClearSelection();
            TabelaClanovi.Rows.Clear();
            txtNazivIzmena.Text = "";
            TableLayoutAgencija.Controls.Clear();
            GrupaIzmena.Enabled = false;
            GrupaNova.Enabled = true;
            Tabele.Enabled = true;
        }
        private void PrikaziStaruAgenciju(string naziv)
        {
            TableLayoutAgencija.Controls.Clear();
            labelaAgencija.Text = naziv;
            labelaAgencija.Enabled = true;
            TableLayoutAgencija.Controls.Add(labelaAgencija, 0, 0);
            DugmePromeniAgenciju.Enabled = true;
        }

        private void OmoguciPromenuAgencije()
        {
            TableLayoutAgencija.Controls.Clear();
            cmbAgencijeIzmena.Items.Clear();
            foreach (var a in agencijaOrganizatorViews)
                cmbAgencijeIzmena.Items.Add(a);

            cmbAgencijeIzmena.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAgencijeIzmena.SelectedIndex = -1;
            cmbAgencijeIzmena.BackColor = Color.White;
            cmbAgencijeIzmena.Enabled = true;
            TableLayoutAgencija.Controls.Add(cmbAgencijeIzmena, 0, 0);
        }


    }
}
