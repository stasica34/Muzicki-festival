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
                        StringBuilder sb = new StringBuilder();
                        foreach(var ao in listaAgencijaOrganizatora)
                        {
                            sb.AppendLine($"ID: {ao.ID}");
                            sb.AppendLine($"Naziv: {ao.NAZIV}");
                            sb.AppendLine($"Adresa: {ao.ADRESA}");
                            sb.AppendLine(new string('-', 40));
                        }
                        MessageBox.Show(sb.ToString(), $"Lista agencija organizatora: {listaAgencijaOrganizatora.Count}");
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

        private void FormaAgencijaOrganizator_Load(object sender, EventArgs e)
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
