using Muzicki_festival.Entiteti;
using Muzicki_festival.Forme;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using NHibernate;

namespace Muzicki_festival.FormeDodatne
{
    public partial class FormaGrupaDodaj : Form
    {
        private Form parentForm;
        private Grupa grupaDodavanje;
        public FormaGrupaDodaj(Form parentForm, Grupa grupa)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            grupaDodavanje = grupa;
        }

        private void FormaGrupaDodaj_Load(object sender, EventArgs e)
        {
            UcitajAgencije();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
        private void UcitajAgencije()
        {
            try
            {
                using (var session = DataLayer.GetSession())
                {
                    var listaAgencija = session.QueryOver<AgencijaOrganizator>().List();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID");
                    dt.Columns.Add("NAZIV");
                    dt.Columns.Add("ADRESA");
                    foreach (var grupa in listaAgencija)
                    {
                        dt.Rows.Add(grupa.ID, grupa.NAZIV, grupa.ADRESA);
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

        private void btnAgencijaOrganizator_Click(object sender, EventArgs e)
        {
           FormaAgencijaOrganizator formaAgencijaOrganizator = new FormaAgencijaOrganizator(this);
            formaAgencijaOrganizator.ShowDialog();
            UcitajAgencije();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                MessageBox.Show("Unesite ime grupe.");
                return;
            }
            ISession s = DataLayer.GetSession();
            int agencijaId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            var agencija = s.Get<AgencijaOrganizator>(agencijaId);

            Grupa grupa = new Grupa
            {
                NAZIV = txtNaziv.Text.Trim(),
                AgencijaID = agencija
            };
            s.Save(grupa);
            s.Flush();
            MessageBox.Show("Grupa je uspešno sačuvana.");
            parentForm.Show();
            this.Close();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }
    }
}
