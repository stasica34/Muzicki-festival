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
    public partial class FormaZatvorenaLokacija : Form
    {
        private Form parentForm;

        public FormaZatvorenaLokacija(Form caller)
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
                    using (var transaction = session.BeginTransaction())
                    {
                        var zatvorenaLokacija = session.QueryOver<ZatvorenaLokacija>().List();
                        if (zatvorenaLokacija.Count == 0)
                        {
                            MessageBox.Show("Nema zatvorenih lokacija u bazi.");
                            return;
                        }
                        StringBuilder sb = new StringBuilder();
                        foreach (var a in zatvorenaLokacija)
                        {
                            sb.AppendLine($"GPS_KOORDINATE: {a.GPS_KOORDINATE}");
                            sb.AppendLine($"NAZIV: {a.NAZIV}");
                            sb.AppendLine($"TIP_PROSTORA: {a.TIP_PROSTORA}");
                            sb.AppendLine($"KLIMA: {a.KLIMA}");
                            sb.AppendLine($"DOSTUPNOST_SEDENJA: {a.DOSTUPNOST_SEDENJA}");
                            sb.AppendLine(new string('-', 40));
                        }
                        MessageBox.Show(sb.ToString(), $"Lista zatvorenih: {zatvorenaLokacija.Count}");
                        transaction.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void FormaZatvorenaLokacija_Load(object sender, EventArgs e)
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

