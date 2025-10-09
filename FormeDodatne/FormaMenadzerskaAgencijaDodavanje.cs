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
namespace Muzicki_festival.FormeDodatne
{
    public partial class FormaMenadzerskaAgencijaDodavanje : Form
    {
        private Form parentForm;
        private MenadzerskaAgencija agencijaDodavanje;
        public FormaMenadzerskaAgencijaDodavanje(Form caller, MenadzerskaAgencija agenicija)
        {
            InitializeComponent();
            parentForm = caller;
            this.agencijaDodavanje = agenicija;
        }

        private void FormaMenadzerskaAgencijaDodavanje_Load(object sender, EventArgs e)
        {
            UcitajKontaktPodatke();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.GridColor = Color.LightGray;

            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 90, 150);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                MessageBox.Show("Unesite naziv agencije.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAdresa.Text))
            {
                MessageBox.Show("Unesite adresu agencije.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtKontaktOsoba.Text))
            {
                MessageBox.Show("Unesite kontakt osobu izvodjaca.");
                return;
            }

            agencijaDodavanje.NAZIV = txtNaziv.Text.Trim();
            agencijaDodavanje.ADRESA = txtAdresa.Text.Trim();
            agencijaDodavanje.KONTAKT_OSOBA = txtKontaktOsoba.Text.Trim();

            using (ISession s = DataLayer.GetSession())
            {
                s.SaveOrUpdate(agencijaDodavanje);
                s.Flush();
            }

            MessageBox.Show("Agencija je uspešno sačuvana.");
            parentForm.Show();
            this.Close();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }

        private void btnDodajKontaktPodatke_Click(object sender, EventArgs e)
        {
            using (FormaKontaktPodaci formaKontaktPodaci = new FormaKontaktPodaci(this))
            {
                this.Hide();
                var result = formaKontaktPodaci.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var noviKontakt = formaKontaktPodaci.NoviKontakt;

                    if (agencijaDodavanje.KONTAKTPODACI == null)
                        agencijaDodavanje.KONTAKTPODACI = new List<KontaktPodaciMenadzerskaAgencija>();

                    noviKontakt.AGENCIJA = agencijaDodavanje; 

                    agencijaDodavanje.KONTAKTPODACI.Add(noviKontakt);

                    UcitajKontaktPodatke();
                }

                this.Show();
            }
        }

        private void UcitajKontaktPodatke()
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    //var listaMenadzerskihAgencija = s.QueryOver<MenadzerskaAgencija>()
                    //                                 .Fetch(x => x.KONTAKTPODACI).Eager
                    //                                 .List();
                    var listaMenadzerskihAgencija = s.QueryOver<MenadzerskaAgencija>().List();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Agencija", typeof(string));
                    dt.Columns.Add("Email", typeof(string));
                    dt.Columns.Add("Telefon", typeof(string));

                    foreach (var agencija in listaMenadzerskihAgencija)
                    {
                        if (agencija.KONTAKTPODACI != null)
                        {
                            foreach (var kontakt in agencija.KONTAKTPODACI)
                            {
                                dt.Rows.Add(agencija.NAZIV, kontakt.EMAIL, kontakt.TELEFON);
                            }
                        }
                    }

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom učitavanja kontakt podataka: " + ex.Message);
            }
        }

    }
}
