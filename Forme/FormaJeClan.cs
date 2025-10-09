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
    public partial class FormaJeClan : Form
    {
        private Form parentForm;

        public FormaJeClan(Form caller)
        {
            InitializeComponent();
            parentForm = caller;
        }

        private void cmd_Nazad_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }

        private void cmd_Ucitavanje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                using (var session = DataLayer.GetSession())
                {
                    var listaJeCLan = session.QueryOver<JeClan>().List();
                    if (listaJeCLan.Count == 0)
                    {
                        MessageBox.Show("Nema nikog ko je clan u bazi.");
                        return;
                    }
                    //StringBuilder sb = new StringBuilder();
                    //foreach (var ao in listaJeCLan)
                    //{
                    //    sb.AppendLine($"ID_Grupe: {ao.ID.Grupa.ID_GRUPE}");
                    //    sb.AppendLine($"ID Posetilac: {ao.ID.Posetilac.ID}");
                    //    sb.AppendLine($"Datum od: {ao.Datum_do}");
                    //    sb.AppendLine($"Datum do: {ao.Datum_do}");
                    //    sb.AppendLine($"Status: {ao.Status}");
                    //    sb.AppendLine(new string('-', 40));
                    //}
                    //MessageBox.Show(sb.ToString(), $"Lista agencija organizatora: {listaJeCLan.Count}");
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID_Grupe");
                    dt.Columns.Add("ID Posetilac");
                    dt.Columns.Add("Datum od");
                    dt.Columns.Add("Datum do");
                    dt.Columns.Add("Status");

                    foreach (var d in listaJeCLan)
                    {
                        dt.Rows.Add(d.ID.Grupa.ID_GRUPE, d.ID.Posetilac.ID, d.Datum_do, d.Datum_od, d.Status);
                    }
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["ID_Grupe"].Visible = false;
                    dataGridView1.Columns["ID Posetilac"].Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormaJeClan_Load(object sender, EventArgs e)
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

        private void cmdDodavanje_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    ISession s = DataLayer.GetSession();
            //    Grupa g = s.Load<Grupa>(11);
            //    Entiteti.Posetilac p = s.Load<Entiteti.Posetilac>(18);
            //    JeClan jeClan = new JeClan();
            //    jeClan.ID.Grupa = g;
            //    jeClan.ID.Posetilac = p;
            //    jeClan.Datum_od = DateTime.Now;
            //    s.Save(jeClan);
            //    s.Flush();
            //    MessageBox.Show("Uspesno je sve dodato u bazi");
            //    s.Close();
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite izvodjaca kog zelite da obrisete!");
                return;
            }
            int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
            object idObj = dataGridView1.Rows[selectedRowIndex].Cells["ID_Grupe"].Value;

            if (idObj == null || !int.TryParse(idObj.ToString(), out int grupaId))
            {
                MessageBox.Show("Greška prilikom čitanja.");
                return;
            }
            DialogResult result = MessageBox.Show("Da li ste sigurni da želite da obrišete?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (ISession s = DataLayer.GetSession())
                    {
                        JeClan jeclan = s.Get<JeClan>(grupaId);
                        if (jeclan == null)
                        {
                            MessageBox.Show("Podatak ne postoji u bazi.");
                            return;
                        }

                        s.Delete(jeclan);
                        s.Flush();
                    }

                    MessageBox.Show("Podatak uspešno obrisan.");
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
