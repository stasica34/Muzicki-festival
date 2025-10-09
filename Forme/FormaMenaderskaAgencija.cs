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
    public partial class FormaMenaderskaAgencija : Form
    {
        private Form parentForm;
        public FormaMenaderskaAgencija(Form caller)
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
            //try
            //{
            //    ISession s = DataLayer.GetSession();
            //    using (var session = DataLayer.GetSession())
            //    {
            //        using (var transaction = session.BeginTransaction())
            //        {
            //            var listaMenadzerskaAgenciaj = session.QueryOver<MenadzerskaAgencija>().List();
            //            if (listaMenadzerskaAgenciaj.Count == 0)
            //            {
            //                MessageBox.Show("Nema mendaz.agencija  u bazi.");
            //                return;
            //            }
            //            StringBuilder sb = new StringBuilder();
            //            foreach (var ao in listaMenadzerskaAgenciaj)
            //            {
            //                sb.AppendLine($"ID: {ao.ID}");
            //                sb.AppendLine($"Naziv: {ao.NAZIV}");
            //                sb.AppendLine($"Adresa: {ao.ADRESA}");
            //                sb.AppendLine($"Kontakt osoba: {ao.KONTAKT_OSOBA}");
            //                sb.AppendLine(new string('-', 40));
            //            }
            //            MessageBox.Show(sb.ToString(), $"Lista mendaz.agencija : {listaMenadzerskaAgenciaj.Count}");
            //            transaction.Commit();
            //        }
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void FormaMenaderskaAgencija_Load(object sender, EventArgs e)
        {
            try
            {
                UcitajMenagerskeAgencije();
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

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite menadzersku agenciju koji zelite da obrisete!");
                return;
            }
            int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
            object idObj = dataGridView1.Rows[selectedRowIndex].Cells["ID"].Value;

            if (idObj == null || !int.TryParse(idObj.ToString(), out int agencijaID))
            {
                MessageBox.Show("Greška prilikom čitanja ID-ja agnecije.");
                return;
            }
            DialogResult result = MessageBox.Show("Da li ste sigurni da želite da obrišete izabri menadzersku agenciju?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (ISession s = DataLayer.GetSession())
                    {
                        MenadzerskaAgencija menadzerskaAgencija = s.Get<MenadzerskaAgencija>(agencijaID);
                        if (menadzerskaAgencija == null)
                        {
                            MessageBox.Show("Menadzerska agencija ne postoji u bazi.");
                            return;
                        }

                        s.Delete(menadzerskaAgencija);
                        s.Flush();
                    }

                    MessageBox.Show("Menadzerska agencija uspešno obrisana.");
                   UcitajMenagerskeAgencije();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška prilikom brisanja: " + ex.Message);
                }
            }
        }
        private void UcitajMenagerskeAgencije()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                using (var session = DataLayer.GetSession())
                {
                    var listaMenadzerskaAgencija = session.QueryOver<MenadzerskaAgencija>()
                                                                      .Fetch(x => x.KONTAKTPODACI).Eager
                                                                      .List();
                    if (listaMenadzerskaAgencija.Count == 0)
                    {
                        MessageBox.Show("Trenutno nema menadzerskih agencija u bazi.");
                    }
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID");
                    dt.Columns.Add("NAZIV");
                    dt.Columns.Add("ADRESA");
                    dt.Columns.Add("KONTAKT_OSOBA");
                    dt.Columns.Add("KONTAKTPODACI");
                    foreach (var d in listaMenadzerskaAgencija)
                    {
                        string kontaktPodaciString = string.Join("; ", d.KONTAKTPODACI.Select(kp => kp.ToString()));
                        dt.Rows.Add(d.ID, d.NAZIV, d.ADRESA, d.KONTAKT_OSOBA,kontaktPodaciString);
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

        private void cmdDodavanje_Click(object sender, EventArgs e)
        {
            FormaMenadzerskaAgencijaDodavanje menaderskaAgencija = new FormaMenadzerskaAgencijaDodavanje(this, null);
            this.Hide();
            menaderskaAgencija.ShowDialog();
            this.Show();
            UcitajMenagerskeAgencije();
        }

        private void cmdIzmeni_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite agenciju za izmenu.");
                return;
            }

            int agencijaID;
            if (!int.TryParse(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString(), out agencijaID))
            {
                MessageBox.Show("Greška pri čitanju ID-a događaja.");
                return;
            }

            using (ISession s = DataLayer.GetSession())
            {
                MenadzerskaAgencija menadzerskaAgencija = s.Get<MenadzerskaAgencija>(agencijaID);

                if (menadzerskaAgencija != null)
                {
                    FormaMenadzerskaAgencijaIzmeni forma = new FormaMenadzerskaAgencijaIzmeni(this, menadzerskaAgencija);
                    this.Hide();
                    forma.ShowDialog();
                    this.Show();
                    UcitajMenagerskeAgencije();
                }
                else
                {
                    MessageBox.Show("Greška: Događaj nije pronađen.");
                }
            }
        }
    }
}
