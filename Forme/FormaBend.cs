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
namespace Muzicki_festival.Forme
{
    public partial class FormaBend : Form
    {
        private Form parentForm;
        public FormaBend(Form caller)
        {
            InitializeComponent();
            parentForm = caller;
        }

        private void cmd_Ucitavanje_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    ISession s = DataLayer.GetSession();
            //    using(var session = DataLayer.GetSession())
            //    {
            //        using(var transaction = session.BeginTransaction())
            //        {
            //            var listaBendova = session.QueryOver<Bend>().List();
            //            if(listaBendova.Count==0)
            //            {
            //                MessageBox.Show("Nema bendova u bazi.");
            //                return;
            //            }
            //            StringBuilder sb = new StringBuilder();
            //            foreach(var b in listaBendova)
            //            {
            //                sb.AppendLine($"ID: {b.ID}");
            //                sb.AppendLine($"Broj clanova: {b.BROJ_CLANOVA}");
            //                sb.AppendLine(new string('-', 40));
            //            }
            //            MessageBox.Show(sb.ToString(), $"Lista bendova: {listaBendova.Count}");
            //            transaction.Commit();
            //        }
            //    }
            //    s.Close();
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            try
            {
                ISession s = DataLayer.GetSession();
                using (var session = DataLayer.GetSession())
                {
                    var listaBedndova = session.QueryOver<Bend>().List();
                    if (listaBedndova.Count == 0)
                    {
                        MessageBox.Show("Nema benda u bazi.");
                        return;
                    }
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID");
                    dt.Columns.Add("IME");
                    dt.Columns.Add("DRZAVA_POREKLA");
                    dt.Columns.Add("EMAIL");
                    dt.Columns.Add("BROJ_CLANOVA");

                    foreach (var d in listaBedndova)
                    {
                        dt.Rows.Add(d.ID, d.IME, d.DRZAVA_POREKLA, d.EMAIL,
                            d.BROJ_CLANOVA);
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

        private void FormaBend_Load(object sender, EventArgs e)
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
        private void cmdDodavanje_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    ISession s = DataLayer.GetSession();
            //    Entiteti.Bend b = new Entiteti.Bend();
            //    b = s.Load<Entiteti.Bend>(9);
            //    b.BROJ_CLANOVA = 4;
            //    s.Save(b);
            //    s.Flush();
            //    MessageBox.Show(
            //       $"Uspesno je izvresno dodavanje podataka.\n\n" +
            //       $"Broj clanova: {b.BROJ_CLANOVA}\n",
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
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite bend koji zelite da obrisete!");
                return;
            }
            int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
            object idObj = dataGridView1.Rows[selectedRowIndex].Cells["ID"].Value;

            if (idObj == null || !int.TryParse(idObj.ToString(), out int izvodjacId))
            {
                MessageBox.Show("Greška prilikom čitanja ID-ja izvodjaca.");
                return;
            }
            DialogResult result = MessageBox.Show("Da li ste sigurni da želite da obrišete izabri bend?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (ISession s = DataLayer.GetSession())
                    {
                        Bend bend = s.Get<Bend>(izvodjacId);
                        if (bend == null)
                        {
                            MessageBox.Show("Bend ne postoji u bazi.");
                            return;
                        }

                        s.Delete(bend);
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

        private void cmd_Nazad_Click_1(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Hide();
        }
    }
}
