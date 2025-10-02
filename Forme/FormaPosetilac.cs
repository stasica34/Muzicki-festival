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
                    using (var transaction = session.BeginTransaction())
                    {
                        var listaPosetilaca = session.QueryOver<Posetilac>().List();
                        if (listaPosetilaca.Count == 0)
                        {
                            MessageBox.Show("Nema posetilaca u bazi.");
                            return;
                        }
                        StringBuilder sb = new StringBuilder();
                        foreach (var ao in listaPosetilaca)
                        {
                            sb.AppendLine($"ID: {ao.ID}");
                            sb.AppendLine($"Ime:: {ao.IME}");
                            sb.AppendLine($"Prezime: {ao.PREZIME}");
                            sb.AppendLine($"Email: {ao.EMAIL}");
                            sb.AppendLine(new string('-', 40));
                        }
                        MessageBox.Show(sb.ToString(), $"Lista posetilaca: {listaPosetilaca.Count}");
                        transaction.Commit();
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

        private void FormaPosetilac_Load(object sender, EventArgs e)
        {
            try
            {
                using (var session = DataLayer.GetSession())
                {
                    MessageBox.Show("Forma uspešno otvorena!");
                }
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
                Entiteti.Posetilac p = new Entiteti.Posetilac();
                p = s.Load<Entiteti.Posetilac>(4);
                p.IME = "Nikolina";
                s.Save(p);
                s.Flush();
                MessageBox.Show(
                   $"Uspesno je izvresno dodavanje podataka.\n\n" +
                   $"Ime: {p.IME}\n",
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
