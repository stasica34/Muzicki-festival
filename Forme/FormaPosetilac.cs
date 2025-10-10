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
    public partial class FormaPosetilac : Form
    {
        private Form parentForm;

        public FormaPosetilac(Form caller)
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
                    var listaPosetilaca = session.QueryOver<Posetilac>().List();
                    if (listaPosetilaca.Count == 0)
                    {
                        MessageBox.Show("Nema posetilaca u bazi.");
                        return;
                    }
                    //StringBuilder sb = new StringBuilder();
                    //foreach (var ao in listaPosetilaca)
                    //{
                    //    sb.AppendLine($"ID: {ao.ID}");
                    //    sb.AppendLine($"Ime:: {ao.IME}");
                    //    sb.AppendLine($"Prezime: {ao.PREZIME}");
                    //    sb.AppendLine($"Email: {ao.EMAIL}");
                    //    sb.AppendLine(new string('-', 40));
                    //}
                    //MessageBox.Show(sb.ToString(), $"Lista posetilaca: {listaPosetilaca.Count}");
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID");
                    dt.Columns.Add("IME");
                    dt.Columns.Add("PREZIME");
                    dt.Columns.Add("EMAIL");

                    foreach (var d in listaPosetilaca)
                    {
                        dt.Rows.Add(d.ID, d.IME, d.PREZIME, d.EMAIL);
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

        private void cmd_Nazad_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }

        private void FormaPosetilac_Load(object sender, EventArgs e)
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
        private void cmdIzmeni_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite posetioca za izmenu.");
                return;
            }

            int posetiocaId;
            if (!int.TryParse(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString(), out posetiocaId))
            {
                MessageBox.Show("Greška pri čitanju ID-a posetioca.");
                return;
            }

            using (ISession s = DataLayer.GetSession())
            {
                Posetilac posetioc = s.Get<Posetilac>(posetiocaId);

                if (posetioc != null)
                {
                    FormaPosetilacIzmeni forma = new FormaPosetilacIzmeni(this, posetioc);
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
                MessageBox.Show("Izaberite izvodjaca kog zelite da obrisete!");
                return;
            }
            int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
            object idObj = dataGridView1.Rows[selectedRowIndex].Cells["ID"].Value;

            if (idObj == null || !int.TryParse(idObj.ToString(), out int posetilacID))
            {
                MessageBox.Show("Greška prilikom čitanja ID-ja posetioca.");
                return;
            }
            DialogResult result = MessageBox.Show("Da li ste sigurni da želite da obrišete izabrog posetioca?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (ISession s = DataLayer.GetSession())
                    {
                        Posetilac posetilac = s.Get<Posetilac>(posetilacID);
                        if (posetilac == null)
                        {
                            MessageBox.Show("Posetilac ne postoji u bazi.");
                            return;
                        }

                        s.Delete(posetilac);
                        s.Flush();
                    }

                    MessageBox.Show("Posetilac uspešno obrisan.");
                    cmd_Ucitavanje_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška prilikom brisanja: " + ex.Message);
                }
            }
        }

        private void cmdDodaj_Click(object sender, EventArgs e)
        {
            FormaPosetilacDodaj formaDodaj = new FormaPosetilacDodaj(this);
            this.Hide();
            formaDodaj.ShowDialog();
            this.Show();
            cmd_Ucitavanje_Click(null, null);
            //try
            //{
            //    ISession s = DataLayer.GetSession();
            //    Entiteti.Posetilac p = new Entiteti.Posetilac();
            //    p = s.Load<Entiteti.Posetilac>(4);
            //    p.IME = "Nikolina";
            //    s.Save(p);
            //    s.Flush();
            //    MessageBox.Show(
            //       $"Uspesno je izvresno dodavanje podataka.\n\n" +
            //       $"Ime: {p.IME}\n",
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
