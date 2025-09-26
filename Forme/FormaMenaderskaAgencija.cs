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
            try
            {
                ISession s = DataLayer.GetSession();
                using (var session = DataLayer.GetSession())
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        var listaMenadzerskaAgenciaj = session.QueryOver<MenadzerskaAgencija>().List();
                        if (listaMenadzerskaAgenciaj.Count == 0)
                        {
                            MessageBox.Show("Nema mendaz.agencija  u bazi.");
                            return;
                        }
                        StringBuilder sb = new StringBuilder();
                        foreach (var ao in listaMenadzerskaAgenciaj)
                        {
                            sb.AppendLine($"ID: {ao.ID}");
                            sb.AppendLine($"Naziv: {ao.NAZIV}");
                            sb.AppendLine($"Adresa: {ao.ADRESA}");
                            sb.AppendLine($"Kontakt osoba: {ao.KONTAKT_OSOBA}");
                            sb.AppendLine(new string('-', 40));
                        }
                        MessageBox.Show(sb.ToString(), $"Lista mendaz.agencija : {listaMenadzerskaAgenciaj.Count}");
                        transaction.Commit();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormaMenaderskaAgencija_Load(object sender, EventArgs e)
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
