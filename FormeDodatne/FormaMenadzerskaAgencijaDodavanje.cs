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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using NHibernate;
using Muzicki_festival.Forme;
using Muzicki_festival.DTOs;
namespace Muzicki_festival.FormeDodatne
{
    public partial class FormaMenadzerskaAgencijaDodavanje : Form
    {
        private Form parentForm;
        private IList<MenadzerskaAgencijaView> agencije;
        private IList<IzvodjacView> izvodjaci;
        private IList<MenadzerskaAgencijaKontaktView> kontaktPodaci;
        private int idSelektovan = -1;

        public FormaMenadzerskaAgencijaDodavanje(Form caller)
        {
            InitializeComponent();
            parentForm = caller;

            agencije = DTOManager.VratiSveMenadzerskeAgencije();
            InitTabeluAgencije();
            PopuniTabeluAgencije();

            InitTabeluIzvodjaci();
            InitTabeluKontaktPodaci();
        }

        private void InitTabeluAgencije()
        {
            AgencijeTabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            AgencijeTabela.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AgencijeTabela.ReadOnly = true;
            AgencijeTabela.AllowUserToAddRows = false;
            AgencijeTabela.RowHeadersVisible = false;
            AgencijeTabela.BorderStyle = BorderStyle.None;
            AgencijeTabela.BackgroundColor = Color.WhiteSmoke;
            AgencijeTabela.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            AgencijeTabela.GridColor = Color.LightGray;

            AgencijeTabela.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

            AgencijeTabela.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            AgencijeTabela.DefaultCellStyle.SelectionForeColor = Color.White;
            AgencijeTabela.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            AgencijeTabela.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            AgencijeTabela.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            AgencijeTabela.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 90, 150);
            AgencijeTabela.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            AgencijeTabela.EnableHeadersVisualStyles = false;


            AgencijeTabela.Columns.Add("ID", "ID");
            AgencijeTabela.Columns.Add("Naziv", "Naziv");
            AgencijeTabela.Columns.Add("Adresa", "Adresa");
            AgencijeTabela.Columns.Add("KontaktOsoba", "Kontakt Osoba");

            AgencijeTabela.Columns["ID"].Visible = false;
        }
        
        private void PopuniTabeluAgencije()
        {
            AgencijeTabela.Rows.Clear();
            foreach (var agencija in agencije)
            {
                AgencijeTabela.Rows.Add(agencija.ID, agencija.Naziv, agencija.Adresa, agencija.KontaktOsoba);
            }
        }

        private void InitTabeluIzvodjaci()
        {
            IzvodjaciTabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            IzvodjaciTabela.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            IzvodjaciTabela.ReadOnly = true;
            IzvodjaciTabela.AllowUserToAddRows = false;
            IzvodjaciTabela.RowHeadersVisible = false;
            IzvodjaciTabela.BorderStyle = BorderStyle.None;
            IzvodjaciTabela.BackgroundColor = Color.WhiteSmoke;
            IzvodjaciTabela.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            IzvodjaciTabela.GridColor = Color.LightGray;
            IzvodjaciTabela.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
            IzvodjaciTabela.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            IzvodjaciTabela.DefaultCellStyle.SelectionForeColor = Color.White;
            IzvodjaciTabela.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            IzvodjaciTabela.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            IzvodjaciTabela.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            IzvodjaciTabela.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 90, 150);
            IzvodjaciTabela.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            IzvodjaciTabela.EnableHeadersVisualStyles = false;

            IzvodjaciTabela.Columns.Add("Ime", "Ime");
            IzvodjaciTabela.Columns.Add("Tip", "Tip izvodjaca");
        }

        private void PopuniTabeluIzvodjaci()
        {
            IzvodjaciTabela.Rows.Clear();
            foreach (var izvodjac in izvodjaci)
            {
                IzvodjaciTabela.Rows.Add(izvodjac.Ime, izvodjac.tipIzvodajaca);
            }
        }
        private void InitTabeluKontaktPodaci()
        {
            KontaktTabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            KontaktTabela.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            KontaktTabela.ReadOnly = true;
            KontaktTabela.AllowUserToAddRows = false;
            KontaktTabela.RowHeadersVisible = false;
            KontaktTabela.BorderStyle = BorderStyle.None;
            KontaktTabela.BackgroundColor = Color.WhiteSmoke;
            KontaktTabela.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            KontaktTabela.GridColor = Color.LightGray;
            KontaktTabela.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
            KontaktTabela.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            KontaktTabela.DefaultCellStyle.SelectionForeColor = Color.White;
            KontaktTabela.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            KontaktTabela.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            KontaktTabela.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            KontaktTabela.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 90, 150);
            KontaktTabela.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            KontaktTabela.EnableHeadersVisualStyles = false;

            KontaktTabela.Columns.Add("TipKontakta", "Tip Kontakta");    
            KontaktTabela.Columns.Add("Vrednost", "Vrednost");
        }
        private void PopuniTabeluKontaktPodaci()
        {
            KontaktTabela.Rows.Clear();
            foreach (var kontakt in kontaktPodaci)
            {
                KontaktTabela.Rows.Add(kontakt.TIP_KONTAKTA, kontakt.Vrednost);
            }
        }

        private void FormaMenadzerskaAgencijaDodavanje_Load(object sender, EventArgs e)
        {

        }

        private void DugmeDodaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNaziv.Text) || string.IsNullOrEmpty(txtAdresa.Text) ||
                string.IsNullOrEmpty(txtKontaktOsoba.Text))
            {
                MessageBox.Show("Molimo popunite sva polja ispravno.");
                return;
            }

            MenadzerskaAgencijaBasic novi = new MenadzerskaAgencijaBasic(-1, txtNaziv.Text, txtAdresa.Text, txtKontaktOsoba.Text, null);
            
            MenadzerskaAgencijaView dodata = DTOManager.DodajMenadzerskuAgenciju(novi);
            if (dodata != null)
            {
                agencije.Add(dodata);
                PopuniTabeluAgencije();
                MessageBox.Show("Uspešno dodata menadžerska agencija.");
            }
            else
            {
                MessageBox.Show("Greška pri dodavanju menadžerske agencije.");
            }
        }

        private void DugmeIzmeni_Click(object sender, EventArgs e)
        {
            if (idSelektovan == -1)
            {
                MessageBox.Show("Izaberite menadžersku agenciju iz tabele.");
                return;
            }
            
            FormaMenadzerskaAgencijaIzmeni formaMenadzerskaAgencijaIzmeni = new FormaMenadzerskaAgencijaIzmeni(this, idSelektovan);
            formaMenadzerskaAgencijaIzmeni.Show();
            this.Hide();
        }

        private void DugmeIzadji_Click(object sender, EventArgs e)
        {

        }

        private void AgencijeTabela_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < AgencijeTabela.Rows.Count)
            {
                DataGridViewRow row = AgencijeTabela.Rows[e.RowIndex];
                idSelektovan = Convert.ToInt32(row.Cells["ID"].Value);

                izvodjaci = DTOManager.VratiIzvodjaceMenadzerskeAgencije(idSelektovan);
                PopuniTabeluIzvodjaci();
                
                kontaktPodaci = DTOManager.VratiSveKontaktPodatke(idSelektovan);
                PopuniTabeluKontaktPodaci();
            }
        }

        private void FormaMenadzerskaAgencijaDodavanje_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                agencije = DTOManager.VratiSveMenadzerskeAgencije();
                PopuniTabeluAgencije();

                if (izvodjaci != null)
                {
                    izvodjaci.Clear();
                    PopuniTabeluIzvodjaci();
                }
                if (kontaktPodaci != null)
                {
                    kontaktPodaci.Clear();
                    PopuniTabeluKontaktPodaci();
                }
            }
        }
    }
}
