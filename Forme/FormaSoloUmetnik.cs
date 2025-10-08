using Muzicki_festival.Entiteti;
using Muzicki_festival.FormeDodatne;
using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muzicki_festival.Forme
{
    public partial class FormaSoloUmetnik : Form
    {
        private Form parentForm;
        public FormaSoloUmetnik(Form caller)
        {
            InitializeComponent();
            parentForm = caller;
        }
        private void cmd_Ucitavanje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                using (var session = DataLayer.GetSession())
                {
                    var listaSoloUmetnika = session.QueryOver<Solo_Umetnik>().List();
                    if (listaSoloUmetnika.Count == 0)
                    {
                        MessageBox.Show("Nema solo umetnika u bazi.");
                        return;
                    }
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID");
                    dt.Columns.Add("IME");
                    dt.Columns.Add("DRZAVA_POREKLA");
                    dt.Columns.Add("EMAIL");
                    dt.Columns.Add("SVIRA_INSTRUMENT");
                    dt.Columns.Add("TIP_INSTRUMENTA");

                    foreach (var d in listaSoloUmetnika)
                    {
                        dt.Rows.Add(d.ID, d.IME, d.DRZAVA_POREKLA, d.EMAIL,
                            d.SVIRA_INSTRUMENT, d.TIP_INSTRUMENTA);
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

        private void cmd_Nazad_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }

        private void FormaSoloUmetnik_Load(object sender, EventArgs e)
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

        private void cmd_Dodavanje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.Solo_Umetnik su = new Entiteti.Solo_Umetnik();
                su = s.Load<Entiteti.Solo_Umetnik>(4);
                su.SVIRA_INSTRUMENT = "NE";
                s.Save(su);
                s.Flush();
                MessageBox.Show(
                   $"Uspesno je izvresno dodavanje podataka.\n\n" +
                   $"Svira instrument: {su.SVIRA_INSTRUMENT}\n",
                   "Uspeh",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
                   );

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite solo izvodjaca kog zelite da obrisete!");
                return;
            }
            int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
            object idObj = dataGridView1.Rows[selectedRowIndex].Cells["ID"].Value;

            if (idObj == null || !int.TryParse(idObj.ToString(), out int izvodjacId))
            {
                MessageBox.Show("Greška prilikom čitanja ID-ja izvodjaca.");
                return;
            }
            DialogResult result = MessageBox.Show("Da li ste sigurni da želite da obrišete izabrog izvodjaca?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (ISession s = DataLayer.GetSession())
                    {
                        Solo_Umetnik u = s.Get<Solo_Umetnik>(izvodjacId);
                        if (u == null)
                        {
                            MessageBox.Show("Izvodjac ne postoji u bazi.");
                            return;
                        }

                        s.Delete(u);
                        s.Flush();
                    }

                    MessageBox.Show("Izvodjac uspešno obrisan.");
                   cmd_Ucitavanje_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška prilikom brisanja: " + ex.Message);
                }
            }
        }
    }
}
