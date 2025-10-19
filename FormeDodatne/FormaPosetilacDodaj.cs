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
using System.ServiceModel.Configuration;
namespace Muzicki_festival.FormeDodatne
{
    public partial class FormaPosetilacDodaj : Form
    {
        private Form parentForm;
        private readonly DogadjajView Dogadjaj;
        private IList<GrupaView> grupaViews;
        private UlaznicaBasic ulaznica = null;
        private int selektovanaID = -1;
        private bool UclanioSe = false;

        public FormaPosetilacDodaj(Form parentForm, DogadjajView dogadjaj)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            Dogadjaj = dogadjaj;
            grupaViews = DTOManager.VratiSveGrupe();

            InitTabeluGrupe();
            PopuniTabeluGrupe();

            InitTabeluClanovi();
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
            var grupa = grupaViews.Where(g => g.Id == selektovanaID).FirstOrDefault();
            if (grupa != null)
            {
                var imena = grupa.Clanovi;
                foreach (var i in imena)
                {
                    TabelaClanovi.Rows.Add(i);
                }
            }
        }
        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text.Trim();
            string prezime = txtPrezime.Text.Trim();
            string email = txtEmail.Text.Trim();
            string telefon = txtTelefon.Text.Trim();

            if (string.IsNullOrWhiteSpace(ime))
            {
                MessageBox.Show("Unesite ime posetioca.");
                return;
            }
            if (string.IsNullOrWhiteSpace(prezime))
            {
                MessageBox.Show("Unesite prezime posetioca.");
                return;
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Unesite email posetioca.");
                return;
            }
            if (ulaznica == null)
            {
                MessageBox.Show("Dodajte ulaznicu za korisnika!");
                return;
            }

            GrupaBasic gb = null;
            if (UclanioSe)
            {
                GrupaView gr = grupaViews.Where(g => g.Id == selektovanaID).FirstOrDefault();
                if (gr!=null)
                {
                    gb = new GrupaBasic(gr.Id, gr.Naziv, null, null);
                }
            }
            PosetilacBasic pb = new PosetilacBasic(0, ime, prezime, email, telefon, ulaznica, gb);
            try
            {
                var rezultat = DTOManager.DodajPosetioca(pb);

                if (rezultat != null)
                {
                    MessageBox.Show("Posetilac uspešno dodat!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void DugmeDodajUlaznicu_Click(object sender, EventArgs e)
        {
            DogadjajBasic db = new DogadjajBasic(Dogadjaj.Id, Dogadjaj.Naziv, Dogadjaj.Tip, Dogadjaj.Opis, Dogadjaj.DatumPocetka, Dogadjaj.DatumKraja, null, null);

            FormaUlazniceDodaj forma = new FormaUlazniceDodaj(this, db);
            DialogResult dr = forma.ShowDialog();

            if (dr == DialogResult.OK)
            {
                ulaznica = forma.UlaznicaBasicIzlaz;
                labelaUlaznica.Text = ulaznica.TipUlaznice.ToString();
            }
            else if (dr == DialogResult.No)
            {
                MessageBox.Show("Greska");
            }
        }

        private void TabelaGrupe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < TabelaGrupe.Rows.Count)
            {
                var row = TabelaGrupe.Rows[e.RowIndex];
                int id = (int)row.Cells["ID"].Value;
                selektovanaID = id;
                PopuniTabeluClanovi();
            }
        }

        private void DugmeDodajGrupu_Click(object sender, EventArgs e)
        {
            FormaDodajGrupu formaDodajGrupu = new FormaDodajGrupu(this);
            this.Hide();
            formaDodajGrupu.ShowDialog();
            grupaViews = DTOManager.VratiSveGrupe();
            PopuniTabeluGrupe();
            this.Show();
        }

        private void DugmeUclani_Click(object sender, EventArgs e)
        {
            if (selektovanaID == -1)
            {
                MessageBox.Show("Izaberite grupu!");
                return;
            }

            UclanioSe = true;
            DugmeUclani.Enabled = true;
            TabelaClanovi.Enabled = false;
            TabelaGrupe.Enabled = false;
            DugmeNapustiGrupu.Enabled = true;
        }

        private void DugmeNapustiGrupu_Click(object sender, EventArgs e)
        {
            UclanioSe = false;
            DugmeUclani.Enabled = false;
            TabelaGrupe.Enabled = true;
            TabelaGrupe.Enabled = true;
            DugmeNapustiGrupu.Enabled = true;
        }
    }
}
