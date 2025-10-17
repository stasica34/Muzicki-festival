using Muzicki_festival.DTOs;
using Oracle.OciServicesSdk;
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
    public partial class FormaDodajAgencijuOrganizator : Form
    {
        public IList<AgencijaOrganizatorView> agencijaOrganizatorViews;
        private int IdSelektovane = -1;

        public FormaDodajAgencijuOrganizator()
        {
            InitializeComponent();

            agencijaOrganizatorViews = DTOManager.VratiSveAgencije();

            InitTabeluAgencije();
            PopuniTabeluAgencije();
        }


        private void InitTabeluAgencije()
        {
            TabelaAgencije.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            TabelaAgencije.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TabelaAgencije.ReadOnly = true;
            TabelaAgencije.AllowUserToAddRows = false;
            TabelaAgencije.RowHeadersVisible = false;
            TabelaAgencije.BorderStyle = BorderStyle.None;
            TabelaAgencije.BackgroundColor = Color.WhiteSmoke;
            TabelaAgencije.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            TabelaAgencije.GridColor = Color.LightGray;

            TabelaAgencije.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

            TabelaAgencije.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            TabelaAgencije.DefaultCellStyle.SelectionForeColor = Color.White;
            TabelaAgencije.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            TabelaAgencije.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            TabelaAgencije.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            TabelaAgencije.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 90, 150);
            TabelaAgencije.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            TabelaAgencije.EnableHeadersVisualStyles = false;


            TabelaAgencije.Columns.Add("ID", "ID");
            TabelaAgencije.Columns["ID"].Visible = false;
            TabelaAgencije.Columns.Add("NAZIV", "NAZIV");
            TabelaAgencije.Columns.Add("ADRESA", "ADRESA");
        }
        private void PopuniTabeluAgencije()
        {
            TabelaAgencije.Rows.Clear();
            var sortirane = agencijaOrganizatorViews.OrderBy(a => a.Id).ToList();
            foreach (var a in sortirane)
            {
                TabelaAgencije.Rows.Add(a.Id, a.Naziv, a.Adresa);
            }
        }

        private void TabelaAgencije_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= TabelaAgencije.Rows.Count)
                return;

            var row = TabelaAgencije.Rows[e.RowIndex];
            IdSelektovane = (int)row.Cells["ID"].Value;

            try
            {
                TabelaAgencije.ClearSelection();
                TabelaAgencije.Rows[e.RowIndex].Selected = true;
                TabelaAgencije.FirstDisplayedScrollingRowIndex = e.RowIndex;
            }
            catch { }
        }

        private void DugmeDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                string naziv = txtNaziv.Text.Trim();
                string adresa = txtAdresa.Text.Trim();
                if (string.IsNullOrWhiteSpace(naziv) || string.IsNullOrWhiteSpace(adresa))
                {
                    MessageBox.Show("Molim vas unesite naziv i adresu agencije!");
                    return;
                }

                var ab = new AgencijaOrganizatorBasic(0, naziv, adresa, null);
                var nova = DTOManager.DodajAgenciju(ab);

                if (nova != null)
                {
                    MessageBox.Show("Uspešno dodata agencija!");
                    agencijaOrganizatorViews.Add(nova);
                    PopuniTabeluAgencije();
                    ResetujFormu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DugmeOtkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ObrisiDugme_Click(object sender, EventArgs e)
        {
            if (IdSelektovane == -1)
            {
                MessageBox.Show("Izaberite agenciju za brisanje.");
                return;
            }

            var potvrda = MessageBox.Show(
                "Da li ste sigurni da želite da obrišete agenciju? Ova radnja je nepovratna.",
                "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (potvrda == DialogResult.Yes)
            {
                if (DTOManager.ObrisiAgenciju(IdSelektovane))
                {
                    MessageBox.Show("Uspešno obrisana agencija!");
                    var obrisana = agencijaOrganizatorViews.FirstOrDefault(a => a.Id == IdSelektovane);
                    if (obrisana != null)
                        agencijaOrganizatorViews.Remove(obrisana);

                    PopuniTabeluAgencije();
                    IdSelektovane = -1;
                    TabelaAgencije.ClearSelection();
                }
            }
        }

        private void IzmeniDugme_Click(object sender, EventArgs e)
        {
            if (IdSelektovane == -1)
            {
                MessageBox.Show("Prvo izaberite agenciju za izmenu");
                return;
            }

            GrupaNova.Enabled = false;
            GrupaIzmena.Enabled = true;

            AgencijaOrganizatorView selektovana = agencijaOrganizatorViews.Where(a => a.Id == IdSelektovane).FirstOrDefault();
            txtIzmenaAdresa.Text = selektovana.Adresa;
            txtIzmenaNaziv.Text = selektovana.Naziv;
        }

        private void PotvrdiIzmenu_Click(object sender, EventArgs e)
        {
            string nazivIzmena = txtIzmenaNaziv.Text.Trim();
            string adresaIzmena = txtIzmenaAdresa.Text.Trim();

            if (string.IsNullOrWhiteSpace(nazivIzmena) || string.IsNullOrWhiteSpace(adresaIzmena))
            {
                MessageBox.Show("Unesite sve podatke!");
                return;
            }

            var ab = new AgencijaOrganizatorBasic(IdSelektovane, nazivIzmena, adresaIzmena, null);

            try
            {
                if (DTOManager.IzmeniAgencijuOrganizator(ab))
                {
                    MessageBox.Show("Uspešno izmenjena agencija.");
                    var selektovana = agencijaOrganizatorViews.FirstOrDefault(a => a.Id == IdSelektovane);
                    if (selektovana != null)
                    {
                        selektovana.Naziv = ab.Naziv;
                        selektovana.Adresa = ab.Adresa;
                    }
                    agencijaOrganizatorViews = DTOManager.VratiSveAgencije();
                    PopuniTabeluAgencije();
                    TabelaAgencije.ClearSelection();
                    IdSelektovane = -1;

                    txtIzmenaNaziv.Clear();
                    txtIzmenaAdresa.Clear();

                    GrupaIzmena.Enabled = false;
                    GrupaNova.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri izmeni: " + ex.Message);
            }
        }

        private void OtkaziIzmenu_Click(object sender, EventArgs e)
        {
            txtIzmenaAdresa.Text = "";
            txtIzmenaNaziv.Text = "";
            GrupaIzmena.Enabled = false;
            GrupaNova.Enabled = true;
        }
        private void ResetujFormu()
        {
            txtNaziv.Clear();
            txtAdresa.Clear();
            txtIzmenaNaziv.Clear();
            txtIzmenaAdresa.Clear();
            IdSelektovane = -1;
            TabelaAgencije.ClearSelection();
        }

    }
}
