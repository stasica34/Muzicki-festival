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
    public partial class FormaAkreditacija : Form
    {
        private Form parentForm;

        public FormaAkreditacija(Form caller)
        {
            InitializeComponent();
            parentForm = caller;

        }

        private void FormaAkreditacija_Load(object sender, EventArgs e)
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

        private void cmd_Ucitavanje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                using (var session = DataLayer.GetSession())
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        var listaAkreditacija = session.QueryOver<Akreditacija>().List();
                        if (listaAkreditacija.Count == 0)
                        {
                            MessageBox.Show("Nema akreditacija u bazi.");
                            return;
                        }
                        StringBuilder sb = new StringBuilder();
                        foreach (var a in listaAkreditacija)
                        {
                            sb.AppendLine($"ID: {a.ID_ULAZNICE}");
                            sb.AppendLine($"Spoznor: {a.SPONZOR}");
                            sb.AppendLine($"Press: {a.PRESS}");
                            sb.AppendLine($"Parner: {a.PARTNER}");
                            sb.AppendLine(new string('-', 40));
                        }
                        MessageBox.Show(sb.ToString(), $"Lista akreditacija: {listaAkreditacija.Count}");
                        transaction.Commit();
                    }
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
    }
}
