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
    public partial class FormaKombinovanaLokacija : Form
    {
        private Form parentForm;

        public FormaKombinovanaLokacija(Form caller)
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
            /*
            try
            {
                ISession s = DataLayer.GetSession();
                using (var session = DataLayer.GetSession())
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        var listaKombinovana = session.QueryOver<KombinovanaLokacija>().List();
                        if (listaKombinovana.Count == 0)
                        {
                            MessageBox.Show("Nema kombinovanih lokacija u bazi.");
                            return;
                        }
                        StringBuilder sb = new StringBuilder();
                        foreach (var a in listaKombinovana)
                        {
                            sb.AppendLine($"Lokacije: {a.Lokacija}");
                            sb.AppendLine(new string('-', 40));
                        }
                        MessageBox.Show(sb.ToString(), $"Lista kombinovanih lokacija: {listaKombinovana.Count}");
                        transaction.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
            */
        }

        private void FormaKombinovanaLokacija_Load(object sender, EventArgs e)
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
