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
using Muzicki_festival.Entiteti;

namespace Muzicki_festival.Forme
{
    public partial class FormaIzvodjac : Form
    {
        private Form parentForm;

        public FormaIzvodjac(Form caller)
        {
            InitializeComponent();
            parentForm = caller;
        }

        private void FormaIzvodjac_Load(object sender, EventArgs e)
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
                        var listaIzvodjaca = session.QueryOver<Izvodjac>().List();
                        if (listaIzvodjaca.Count == 0)
                        {
                            MessageBox.Show("Nema izvodjaca u bazi.");
                            return;
                        }
                        StringBuilder sb = new StringBuilder();
                        foreach (var a in listaIzvodjaca)
                        {
                            sb.AppendLine($"ID: {a.ID}");
                            sb.AppendLine($"IME: {a.IME}");
                            sb.AppendLine($"DRZAVA_POREKLA: {a.DRZAVA_POREKLA}");
                            sb.AppendLine($"EMAIL: {a.EMAIL}");
                            sb.AppendLine($"MENADZERSKA_AGENCIJA_ID: {a.MenadzerskaAgencija.ID}");
                            sb.AppendLine($"KONTAKT_OSOBA: {a.KONTAKT_OSOBA}");
                            sb.AppendLine($"TELEFON: {a.TELEFON}");
                            sb.AppendLine(new string('-', 40));
                        }
                        MessageBox.Show(sb.ToString(), $"Lista izvodjaca: {listaIzvodjaca.Count}");
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
