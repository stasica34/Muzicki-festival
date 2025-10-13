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
            foreach (var a in agencijaOrganizatorViews)
            {
                TabelaAgencije.Rows.Add(a.Id, a.Naziv, a.Adresa);
            }
        }

        private void TabelaAgencije_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < TabelaAgencije.Rows.Count)
            {
                var row = TabelaAgencije.Rows[e.RowIndex];
                int id = (int)row.Cells["ID"].Value;
                IdSelektovane = id;
            }
        }

        private void DugmeDodaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNaziv.Text) || string.IsNullOrEmpty(txtAdresa.Text))
            {
                MessageBox.Show("Molim vas prvo unesite sve podatke!");
                return;
            }

            AgencijaOrganizatorBasic ab = new AgencijaOrganizatorBasic(0, txtNaziv.Text, txtAdresa.Text, null);
            AgencijaOrganizatorView nova = DTOManager.DodajAgenciju(ab);

            if (nova != null)
            {
                MessageBox.Show("Uspesno dodata agencija!");
                agencijaOrganizatorViews.Add(nova);
                PopuniTabeluAgencije();
            }
            else
            {
                MessageBox.Show("Greska pri dodavanju", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Prvo izaberite agenciju za brisanje");
            }

            var potvrda = MessageBox.Show("Da li ste sigurni da zelite da obrisete agenciju!", "Potvrda o brisanja", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (potvrda == DialogResult.Yes)
            {
                if (DTOManager.ObrisiAgenciju(IdSelektovane))
                {
                    MessageBox.Show("Uspesno obrisana agencija!");
                }
                else 
                {
                    MessageBox.Show("Greska pri brisanju!");
                }
            }
        }

        private void IzmeniDugme_Click(object sender, EventArgs e)
        {

        }
    }
}
