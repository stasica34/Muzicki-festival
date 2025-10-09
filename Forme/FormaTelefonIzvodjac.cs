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
    public partial class FormaTelefonIzvodjac : Form
    {
        private Form parentForm;

        public FormaTelefonIzvodjac(Form caller)
        {
            InitializeComponent();
            parentForm = caller;
        }

        private void cmd_Nazad_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }
        private void FormaTelefonIzvodjac_Load(object sender, EventArgs e)
        {
            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void cmd_Ucitavanje_Click_1(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                using (var session = DataLayer.GetSession())
                {
                    var listaTelefonIzvodjac = session.QueryOver<TelefonIzvodjac>().List();
                    if (listaTelefonIzvodjac.Count == 0)
                    {
                        MessageBox.Show("Nema telefon izvojdac u bazi.");
                        return;
                    }
                    //StringBuilder sb = new StringBuilder();
                    //foreach (var ao in listaTelefonIzvodjac)
                    //{
                    //    sb.AppendLine($"IZVODJAC_ID: {ao.IZVODJAC_ID}");
                    //    sb.AppendLine($"Broj telefona:: {ao.TELEFON}");
                    //    sb.AppendLine(new string('-', 40));
                    //}
                    //MessageBox.Show(sb.ToString(), $"Lista telefon izvojdac: {listaTelefonIzvodjac.Count}");
                    DataTable dt = new DataTable();
                    dt.Columns.Add("IZVODJAC_ID");
                    dt.Columns.Add("Ime");
                    dt.Columns.Add("Broj telefona");
                    foreach (var d in listaTelefonIzvodjac)
                    {
                        var posetilac = session.Get<Posetilac>(d.IZVODJAC_ID);
                        dt.Rows.Add(d.IZVODJAC_ID, posetilac?.IME ?? "Nema ime", d.TELEFON);

                    }
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["IZVODJAC_ID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
