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
    public partial class FormaClan : Form
    {
        private Form parentForm;
        public FormaClan(Form caller)
        {
            InitializeComponent();
            parentForm = caller;

        }

        private void FormaClan_Load(object sender, EventArgs e)
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
            /*
            try
            {
                using (var session = DataLayer.GetSession())
                {

                    var listaClanova = session.QueryOver<Clan>().List();
                    if (listaClanova.Count == 0)
                    {
                        MessageBox.Show("Nema clanova u bazi.");
                        return;
                    }
                    //StringBuilder sb = new StringBuilder();
                    //foreach (var a in listaClanova)
                    //{
                    //    sb.AppendLine($"ID: {a.IME}");
                    //    sb.AppendLine($"INstrument: {a.INSTRUMENT}");
                    //    sb.AppendLine($"Bend_ID: {a.BEND_ID.ID}");
                    //    sb.AppendLine(new string('-', 40));
                    //}
                    //MessageBox.Show(sb.ToString(), $"Lista akreditacija: {listaClanova.Count}");
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID");
                    dt.Columns.Add("IME");
                    dt.Columns.Add("INSTRUMENT");
                    dt.Columns.Add("Bend_ID");
                    dt.Columns.Add("ULOGE");
                    foreach (var d in listaClanova)
                    {
                        var uloge = d.Uloge != null && d.Uloge.Any()
                            ? string.Join(", ", d.Uloge)
                            : "Nema";
                        dt.Rows.Add(d.Id,d.IME, d.INSTRUMENT,d.BEND_ID.ID,uloge);
                    }
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["ID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
            */
        }

        private void cmd_Nazad_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite clana kog zelite da obrisete!");
                return;
            }
            int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
            object idObj = dataGridView1.Rows[selectedRowIndex].Cells["ID"].Value;

            if (idObj == null || !int.TryParse(idObj.ToString(), out int clanId))
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
                        Clan clan = s.Get<Clan>(clanId);
                        if (clan == null)
                        {
                            MessageBox.Show("Podatak ne postoji u bazi.");
                            return;
                        }

                        s.Delete(clan);
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
