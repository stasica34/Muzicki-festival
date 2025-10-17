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
namespace Muzicki_festival.FormeDodatne
{
    public partial class FormaMenadzerskaAgencijaIzmeni : Form
    {
        private readonly int IdAgencije;
        private MenadzerskaAgencijaView agencija;
        private IList<MenadzerskaAgencijaKontaktView> kontaktPodaci;
        private int selektovanKontaktId = -1;

        public FormaMenadzerskaAgencijaIzmeni(int idAgencije)
        {
            InitializeComponent();
            IdAgencije = idAgencije;

            agencija = DTOManager.VratiMenadzerskuAgenciju(IdAgencije);
            PopuniPodatke();

            kontaktPodaci = DTOManager.VratiSveKontaktPodatke(IdAgencije);
            InitTabeluKontakti();
            PopuniTabeluKontaki();

            TipKontakt.Items.Add("EMAIL");
            TipKontakt.Items.Add("TELEFON");
        }


        private void PopuniPodatke()
        {
            txtNaziv.Text = agencija.Naziv;
            txtAdresa.Text = agencija.Adresa;
            txtKontaktOsoba.Text = agencija.KontaktOsoba;
        }

        private void InitTabeluKontakti()
        {
            TabelaKontakti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            TabelaKontakti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TabelaKontakti.ReadOnly = true;
            TabelaKontakti.AllowUserToAddRows = false;
            TabelaKontakti.RowHeadersVisible = false;
            TabelaKontakti.BorderStyle = BorderStyle.None;
            TabelaKontakti.BackgroundColor = Color.WhiteSmoke;
            TabelaKontakti.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            TabelaKontakti.GridColor = Color.LightGray;
            TabelaKontakti.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
            TabelaKontakti.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            TabelaKontakti.DefaultCellStyle.SelectionForeColor = Color.White;
            TabelaKontakti.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            TabelaKontakti.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            TabelaKontakti.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            TabelaKontakti.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 90, 150);
            TabelaKontakti.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            TabelaKontakti.EnableHeadersVisualStyles = false;

            TabelaKontakti.Columns.Add("ID", "ID");
            TabelaKontakti.Columns["ID"].Visible = false;
            TabelaKontakti.Columns.Add("TipKontakta", "Tip Kontakta");
            TabelaKontakti.Columns.Add("Vrednost", "Vrednost");
        }

        private void PopuniTabeluKontaki()
        {
            TabelaKontakti.Rows.Clear();
            foreach (MenadzerskaAgencijaKontaktView mk in kontaktPodaci)
            {
                TabelaKontakti.Rows.Add(mk.ID, mk.TIP_KONTAKTA, mk.Vrednost);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            MenadzerskaAgencijaBasic izmena = new MenadzerskaAgencijaBasic(IdAgencije, txtNaziv.Text, txtAdresa.Text, txtKontaktOsoba.Text, null);
            if (DTOManager.IzmeniMenadzerskuAgenciju(izmena))
            {
                MessageBox.Show("Uspešno izmenjena menadžerska agencija.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Došlo je do greške prilikom izmene menadžerske agencije.");
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormaMenadzerskaAgencijaIzmeni_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TipKontakt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TabelaKontakti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < TabelaKontakti.Rows.Count)
            {
                DataGridViewRow row = TabelaKontakti.Rows[e.RowIndex];
                int id = int.Parse(row.Cells["ID"].Value.ToString());
                selektovanKontaktId = id;
                ObrisiKontakt.Enabled = true;
            }
        }

        private void DodajKontakt_Click(object sender, EventArgs e)
        {
            string vrednost = VrednostKontakt.Text.Trim();
            if (string.IsNullOrWhiteSpace(vrednost))
            {
                MessageBox.Show("Niste uneli vrednost kontakta.");
                return;
            }

            if (TipKontakt.SelectedItem == null)
            {
                MessageBox.Show("Molimo izaberite tip kontakta.");
                return;
            }
            string tipString = TipKontakt.SelectedItem.ToString();

            TipKontakta tip;
            if (tipString == "EMAIL")
                tip = TipKontakta.EMAIL;
            else
                tip = TipKontakta.TELEFON;

            MenadzerskaAgencijaBasic mb = new MenadzerskaAgencijaBasic(IdAgencije, agencija.Naziv, agencija.Adresa, agencija.KontaktOsoba, null);
            bool postoji = kontaktPodaci.Any(kp => kp.TIP_KONTAKTA == tip && kp.Vrednost.Equals(vrednost, StringComparison.OrdinalIgnoreCase));
            if (postoji)
            {
                MessageBox.Show("Kontakt sa istim tipom i vrednošću već postoji za ovu agenciju.");
                return;
            }
            MenadzerskaAgencijaKontaktBasic noviKontakt = new MenadzerskaAgencijaKontaktBasic(0, tip, vrednost, mb);
            MenadzerskaAgencijaKontaktView dodat = DTOManager.DodajKontaktMenadzerskeAgencije(noviKontakt);
            if (dodat == null)
            {
                MessageBox.Show("Greška prilikom dodavanja kontakta. Vrednost nije vraćena iz baze.");
                return;
            }
            MessageBox.Show($"Uspešno dodat kontakt {dodat.ID} {dodat.TIP_KONTAKTA} {dodat.Vrednost}");
            kontaktPodaci.Add(dodat);
            PopuniTabeluKontaki();
            VrednostKontakt.Clear();
            TipKontakt.SelectedItem = null;
        }

        private void ObrisiKontakt_Click(object sender, EventArgs e)
        {
            if (selektovanKontaktId == -1)
            {
                MessageBox.Show("Niste selektovali kontakt za brisanje.");
                return;
            }

            MenadzerskaAgencijaKontaktView view = kontaktPodaci.Where(x => x.ID == selektovanKontaktId).FirstOrDefault();
            
            if (view == null)
            {
                MessageBox.Show("Selektovani kontakt nije pronađen.");
                return;
            }

            MenadzerskaAgencijaBasic mb = new MenadzerskaAgencijaBasic(IdAgencije, agencija.Naziv, agencija.Adresa, agencija.KontaktOsoba, null);

            MenadzerskaAgencijaKontaktBasic zaBrisanje = new MenadzerskaAgencijaKontaktBasic(view.ID, view.TIP_KONTAKTA, view.Vrednost, mb);

            if (DTOManager.ObrisiKontaktMenadzerskeAgencije(zaBrisanje))
            {
                MessageBox.Show("Uspešno obrisan kontakt.");
                var obrisan = kontaktPodaci.Where(x => x.ID == selektovanKontaktId).FirstOrDefault();
                kontaktPodaci.Remove(obrisan);

                PopuniTabeluKontaki();
                selektovanKontaktId = -1;
                ObrisiKontakt.Enabled = false; 
            }
            else
            {
                MessageBox.Show("Došlo je do greške prilikom brisanja kontakta.");
            }
        }
    }
}
