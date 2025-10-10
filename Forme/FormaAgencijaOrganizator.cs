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
using Muzicki_festival.Entiteti;
using Muzicki_festival.FormeDodatne;

namespace Muzicki_festival.Forme
{
    public partial class FormaAgencijaOrganizator : Form
    {
        private Form parentForm;
        public FormaAgencijaOrganizator(Form caller)
        {
            InitializeComponent();
            parentForm = caller;
        }
        private void cmd_Nazad_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }

        private void FormaAgencijaOrganizator_Load(object sender, EventArgs e)
        {
            try
            {
                btnUcitavanje_Click(null, null);
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
        private void cmdDodavanje_Click_1(object sender, EventArgs e)
        {
            //try
            //{
            //    ISession s = DataLayer.GetSession();
            //    Entiteti.AgencijaOrganizator ag = new Entiteti.AgencijaOrganizator();
            //    ag = s.Load<Entiteti.AgencijaOrganizator>(4);
            //    ag.NAZIV = "Niski festival";
            //    s.Save(ag);
            //    s.Flush();
            //    MessageBox.Show(
            //       $"Uspesno je izvresno dodavanje podataka.\n\n" +
            //       $"Naziv: {ag.NAZIV}\n",
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
            FormaAgencijaOrganizatorDodaj formaAgencijaOrganizator = new FormaAgencijaOrganizatorDodaj(this);
            this.Hide();
            formaAgencijaOrganizator.ShowDialog();
            this.Show();
        }

        private void cmdIzmeni_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite agneciju organizator za izmenu.");
                return;
            }

            int agencijaId;
            if (!int.TryParse(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString(), out agencijaId))
            {
                MessageBox.Show("Greška pri čitanju ID-a posetioca.");
                return;
            }

            using (ISession s = DataLayer.GetSession())
            {
                AgencijaOrganizator agencija = s.Get<AgencijaOrganizator>(agencijaId);

                if (agencija != null)
                {
                    FormaAgencijaOrganizatorIzmeni forma = new FormaAgencijaOrganizatorIzmeni(this, agencija);
                    this.Hide();
                    forma.ShowDialog();
                    this.Show();
                    btnUcitavanje_Click(null, null);
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
                MessageBox.Show("Izaberite agenciju koju zelite da obrisete!");
                return;
            }
            int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
            object idObj = dataGridView1.Rows[selectedRowIndex].Cells["ID"].Value;

            if (idObj == null || !int.TryParse(idObj.ToString(), out int agencijaID))
            {
                MessageBox.Show("Greška prilikom čitanja ID-ja agencije.");
                return;
            }
            DialogResult result = MessageBox.Show("Da li ste sigurni da želite da obrišete izabru agenciju?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (ISession s = DataLayer.GetSession())
                    {
                        AgencijaOrganizator agencija = s.Get<AgencijaOrganizator>(agencijaID);
                        if (agencija == null)
                        {
                            MessageBox.Show("Agencija ne postoji u bazi.");
                            return;
                        }

                        s.Delete(agencija);
                        s.Flush();
                    }

                    MessageBox.Show("Agencija uspešno obrisana.");
                    btnUcitavanje_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška prilikom brisanja: " + ex.Message);
                }
            }
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }

        private void btnUcitavanje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                using (var session = DataLayer.GetSession())
                {
                    var listaAgencijaOrganizatora = session.QueryOver<AgencijaOrganizator>().List();
                    if (listaAgencijaOrganizatora.Count == 0)
                    {
                        MessageBox.Show("Nema agencija organizatora u bazi.");
                        return;
                    }
                    //StringBuilder sb = new StringBuilder();
                    //foreach(var ao in listaAgencijaOrganizatora)
                    //{
                    //    sb.AppendLine($"ID: {ao.ID}");
                    //    sb.AppendLine($"Naziv: {ao.NAZIV}");
                    //    sb.AppendLine($"Adresa: {ao.ADRESA}");
                    //    sb.AppendLine(new string('-', 40));
                    //}
                    //MessageBox.Show(sb.ToString(), $"Lista agencija organizatora: {listaAgencijaOrganizatora.Count}");
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID");
                    dt.Columns.Add("Naziv");
                    dt.Columns.Add("Adresa");

                    foreach (var ao in listaAgencijaOrganizatora)
                    {
                        dt.Rows.Add(ao.ID, ao.NAZIV, ao.ADRESA);
                    }
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["ID"].Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
