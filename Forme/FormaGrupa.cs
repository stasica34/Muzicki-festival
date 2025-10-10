using Muzicki_festival.Entiteti;
using NHibernate;
using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Muzicki_festival.FormeDodatne;
using System.Linq;

namespace Muzicki_festival.Forme
{
    public partial class FormaGrupa : Form
    {
        private Form parentForm;

        public FormaGrupa(Form caller)
        {
            InitializeComponent();
            parentForm = caller;
        }

        private void FormaGrupa_Load(object sender, EventArgs e)
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

        private void cmd_Ucitavanje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                using (var session = DataLayer.GetSession())
                {
                    var listaGrupa = session.QueryOver<Grupa>().List();
                    if (listaGrupa.Count == 0)
                    {
                        MessageBox.Show("Nema grupe u bazi.");
                        return;
                    }
                    //StringBuilder sb = new StringBuilder();
                    //foreach (var a in listaGrupa)
                    //{
                    //    sb.AppendLine($"ID grupe: {a.ID_GRUPE}");
                    //    sb.AppendLine($"Naziv: {a.NAZIV}");
                    //    sb.AppendLine($"Agencije organizatori: {a.AgencijaID.NAZIV}");
                    //    sb.AppendLine(new string('-', 40));
                    //}
                    //MessageBox.Show(sb.ToString(), $"Lista grupa: {listaGrupa.Count}");
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID_GRUPE");
                    dt.Columns.Add("NAZIV");
                    dt.Columns.Add("AGENCIJA ORGANIZATORI");
                    foreach (var d in listaGrupa)
                    {
                        dt.Rows.Add(d.ID_GRUPE, d.NAZIV, d.AgencijaID.NAZIV);
                    }
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["ID_GRUPE"].Visible = false;

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
        private void cmdIzmeni_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite grupu za izmenu.");
                return;
            }

            int grupaId;
            if (!int.TryParse(dataGridView1.SelectedRows[0].Cells["ID_GRUPE"].Value.ToString(), out grupaId))
            {
                MessageBox.Show("Greška pri čitanju ID-a grupe.");
                return;
            }

            using (ISession s = DataLayer.GetSession())
            {
                Grupa grupa = s.Get<Grupa>(grupaId);

                if (grupa != null)
                {
                    FormaGrupaIzmeni forma = new FormaGrupaIzmeni(this, grupa);
                    this.Hide();
                    forma.ShowDialog();
                    this.Show();
                    cmd_Ucitavanje_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Greška: Događaj nije pronađen.");
                }
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite grupu koju zelite da obrisete!");
                return;
            }
            int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
            object idObj = dataGridView1.Rows[selectedRowIndex].Cells["ID_GRUPE"].Value;

            if (idObj == null || !int.TryParse(idObj.ToString(), out int grupaID))
            {
                MessageBox.Show("Greška prilikom čitanja ID-ja grupe.");
                return;
            }
            DialogResult result = MessageBox.Show("Da li ste sigurni da želite da obrišete izabru grupu?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (ISession s = DataLayer.GetSession())
                    {
                        Grupa grupa = s.Get<Grupa>(grupaID);
                        if (grupa == null)
                        {
                            MessageBox.Show("Grypa ne postoji u bazi.");
                        }
                        var jeclan = grupa.JeClan.ToList();
                        foreach(var clan in grupa.JeClan)
                        {
                            s.Delete(clan);
                        }
                        grupa.JeClan.Clear();
                        s.Delete(grupa);
                        s.Flush();
                    }

                    MessageBox.Show("Grupa uspešno obrisan.");
                    cmd_Ucitavanje_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška prilikom brisanja: " + ex.Message);
                }
            }
        }

        private void cmd_Dodavanje_Click(object sender, EventArgs e)
        {
            FormaGrupaDodaj formaGrupaDodaj = new FormaGrupaDodaj(this, null);
            formaGrupaDodaj.Show();
            this.Hide();
            cmd_Ucitavanje_Click(null, null);
             //try
            //{
            //    ISession s = DataLayer.GetSession();
            //    Entiteti.Grupa g = new Entiteti.Grupa();
            //    g = s.Load<Entiteti.Grupa>(4);
            //    g.NAZIV = "Niski jazzveri";
            //    s.Save(g);
            //    s.Flush();
            //    MessageBox.Show(
            //       $"Uspesno je izvresno dodavanje podataka.\n\n" +
            //       $"Naziv: {g.NAZIV}\n",
            //       "Uspeh",
            //       MessageBoxButtons.OK,
            //       MessageBoxIcon.Information
            //       );

            //    s.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
