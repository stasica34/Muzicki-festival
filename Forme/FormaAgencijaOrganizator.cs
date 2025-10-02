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
    public partial class FormaAgencijaOrganizator : Form
    {
        private Form parentForm;
        public FormaAgencijaOrganizator(Form caller)
        {
            InitializeComponent();
            parentForm = caller;
        }

        private void cmd_Ucitavanje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                using(var session = DataLayer.GetSession())
                {
                    using(var transaction = session.BeginTransaction())
                    {
                        var listaAgencijaOrganizatora = session.QueryOver<AgencijaOrganizator>().List();
                        if(listaAgencijaOrganizatora.Count==0)
                        {
                            MessageBox.Show("Nema agencija organizatora u bazi.");
                            return;
                        }

                        DataTable dt = new DataTable();
                        dt.Columns.Add("ID");
                        dt.Columns.Add("Naziv");
                        dt.Columns.Add("Adresa");

                        foreach (var ao in listaAgencijaOrganizatora)
                        {
                            dt.Rows.Add(ao.ID, ao.NAZIV, ao.ADRESA);
                        }
                        dataGridView1.DataSource = dt;
                        //StringBuilder sb = new StringBuilder();
                        //foreach(var ao in listaAgencijaOrganizatora)
                        //{
                        //    sb.AppendLine($"ID: {ao.ID}");
                        //    sb.AppendLine($"Naziv: {ao.NAZIV}");
                        //    sb.AppendLine($"Adresa: {ao.ADRESA}");
                        //    sb.AppendLine(new string('-', 40));
                        //}
                        //MessageBox.Show(sb.ToString(), $"Lista agencija organizatora: {listaAgencijaOrganizatora.Count}");
                        //transaction.Commit();
                    }
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

        private void FormaAgencijaOrganizator_Load(object sender, EventArgs e)
        {
            try
            {
                using (var session = DataLayer.GetSession())
                {
                    MessageBox.Show("Forma uspešno otvorena!");
                }
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void cmdDodavanje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.AgencijaOrganizator ag = new Entiteti.AgencijaOrganizator();
                ag = s.Load<Entiteti.AgencijaOrganizator>(4);
                ag.NAZIV = "Niski festival";
                s.Save(ag);
                s.Flush();
                MessageBox.Show(
                   $"Uspesno je izvresno dodavanje podataka.\n\n" +
                   $"Naziv: {ag.NAZIV}\n",
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
    }
}
