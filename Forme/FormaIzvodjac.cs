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

namespace Muzicki_festival.Forme
{
    public partial class FormaIzvodjac : Form
    {
        private Form parentForm;
        public FormaIzvodjac(Form caller)
        {
            InitializeComponent();
            this.parentForm = caller; 
        }

        private void btnSolo_Click(object sender, EventArgs e)
        {
            FormaSoloUmetnik formaSoloUmetnik = new FormaSoloUmetnik(this);
            this.Hide();
            formaSoloUmetnik.ShowDialog();
            this.Show();
        }

        private void btnBend_Click(object sender, EventArgs e)
        {
            FormaBend formaBend = new FormaBend(this);
            this.Hide();
            formaBend.ShowDialog();
            this.Show();
        }

        private void btnMenadzerskaAgencija_Click(object sender, EventArgs e)
        {
            FormaMenaderskaAgencija formaMenaderskaAgencija = new FormaMenaderskaAgencija(this);
            this.Hide();
            formaMenaderskaAgencija.ShowDialog();
            this.Show();
        }

        private void FormaIzvodjac_Load(object sender, EventArgs e)
        {
            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void btnIzvodjaci_Click(object sender, EventArgs e)
        {
            UcitajIzvodjace();
        }
        private void UcitajIzvodjace()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                using (var session = DataLayer.GetSession())
                {
                    var listaIzvodjaca = session.QueryOver<Izvodjac>().List();

                    if (listaIzvodjaca.Count == 0)
                    {
                        MessageBox.Show("Trenutno nema izvodjaca u bazi.");
                    }
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID");
                    dt.Columns.Add("IME");
                    dt.Columns.Add("DRZAVA_POREKLA");
                    dt.Columns.Add("EMAIL");
                    dt.Columns.Add("MENADZERSKA_AGENCIJA_ID");
                    dt.Columns.Add("KONTAKT_OSOBA");
                    dt.Columns.Add("TELEFON");

                    foreach (var d in listaIzvodjaca)
                    {
                        string nazivAgencije = d.MenadzerskaAgencija != null ? d.MenadzerskaAgencija.NAZIV : "Nema agenciju";
                        dt.Rows.Add(d.ID, d.IME, d.DRZAVA_POREKLA, d.EMAIL, nazivAgencije, d.KONTAKT_OSOBA, d.TELEFON);
                    }
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["ID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }
    }
}
