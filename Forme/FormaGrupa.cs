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
    public partial class FormaGrupa : Form
    {
        private Form parentForm;

        public FormaGrupa(Form caller)
        {
            InitializeComponent();
            parentForm = caller;
        }

        private void FormaGrupa_Load(object sender, EventArgs e)
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
                        var listaGrupa = session.QueryOver<Grupa>().List();
                        if (listaGrupa.Count == 0)
                        {
                            MessageBox.Show("Nema grupe u bazi.");
                            return;
                        }
                        StringBuilder sb = new StringBuilder();
                        foreach (var a in listaGrupa)
                        {
                            sb.AppendLine($"ID grupe: {a.ID_GRUPE}");
                            sb.AppendLine($"Naziv: {a.NAZIV}");
                            sb.AppendLine($"Agencije organizatori: {a.AgencijaID}");
                            sb.AppendLine(new string('-', 40));
                        }
                        MessageBox.Show(sb.ToString(), $"Lista grupa: {listaGrupa.Count}");
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
