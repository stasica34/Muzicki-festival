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
    public partial class FormaLokacija : Form
    {
        private Form parentForm;
        public FormaLokacija(Form caller)
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
                        var listalokacija = session.QueryOver<Lokacija>().List();
                        if (listalokacija.Count == 0)
                        {
                            MessageBox.Show("Nema lokacija u bazi.");
                            return;
                        }
                        StringBuilder sb = new StringBuilder();
                        foreach (var a in listalokacija)
                        {
                            sb.AppendLine($"GPS_KOORDINATE: {a.Lokacija_ID.GPS_KOORDINATE}");
                            sb.AppendLine($"NAZIV: {a.Lokacija_ID.GPS_KOORDINATE}");
                            sb.AppendLine($"OPIS: {a.OPIS}");
                            sb.AppendLine($"MAX_KAPACITET: {a.MAX_KAPACITET}");
                            sb.AppendLine(new string('-', 40));
                        }
                        MessageBox.Show(sb.ToString(), $"Lista lokacija: {listalokacija.Count}");
                        transaction.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void FormaLokacija_Load(object sender, EventArgs e)
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
