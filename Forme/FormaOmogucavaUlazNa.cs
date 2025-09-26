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
    public partial class FormaOmogucavaUlazNa : Form
    {
        private Form parentForm;
        public FormaOmogucavaUlazNa(Form caller)
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
                        var omogucavaUlazs = session.QueryOver<OmogucavaUlazNa>().List();
                        if (omogucavaUlazs.Count == 0)
                        {
                            MessageBox.Show("Nema podataka u bazi.");
                            return;
                        }
                        StringBuilder sb = new StringBuilder();
                        foreach (var ao in omogucavaUlazs)
                        {
                            sb.AppendLine($"Ulaznice ID: {ao.ID_ULAZNICE}");
                            sb.AppendLine($"Dogadja ID: {ao.DOGADJAJ_ID}");
                            sb.AppendLine(new string('-', 40));
                        }
                        MessageBox.Show(sb.ToString(), $"Lista: {omogucavaUlazs.Count}");
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

        private void FormaOmogucavaUlazNa_Load(object sender, EventArgs e)
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
    }
}
