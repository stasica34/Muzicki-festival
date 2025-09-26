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
    public partial class FormaTelefonIzvodjac : Form
    {
        private Form parentForm;

        public FormaTelefonIzvodjac(Form caller)
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
                        var listaTelefonIzvodjac = session.QueryOver<TelefonIzvodjac>().List();
                        if (listaTelefonIzvodjac.Count == 0)
                        {
                            MessageBox.Show("Nema telefon izvojdac u bazi.");
                            return;
                        }
                        StringBuilder sb = new StringBuilder();
                        foreach (var ao in listaTelefonIzvodjac)
                        {
                            sb.AppendLine($"IZVODJAC_ID: {ao.IZVODJAC_ID}");
                            sb.AppendLine($"Broj telefona:: {ao.TELEFON}");
                            sb.AppendLine(new string('-', 40));
                        }
                        MessageBox.Show(sb.ToString(), $"Lista telefon izvojdac: {listaTelefonIzvodjac.Count}");
                        transaction.Commit();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormaTelefonIzvodjac_Load(object sender, EventArgs e)
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

            }
        }
    }
}
