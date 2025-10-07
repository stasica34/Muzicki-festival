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
    public partial class FormaJeClan : Form
    {
        private Form parentForm;

        public FormaJeClan(Form caller)
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
                        var listaJeCLan = session.QueryOver<JeClan>().List();
                        if (listaJeCLan.Count == 0)
                        {
                            MessageBox.Show("Nema agencija organizatora u bazi.");
                            return;
                        }
                        StringBuilder sb = new StringBuilder();
                        foreach (var ao in listaJeCLan)
                        {
                            sb.AppendLine($"ID_Grupe: {ao.ID.Grupa.ID_GRUPE}");
                            sb.AppendLine($"ID Posetilac: {ao.ID.Posetilac.ID}");
                            sb.AppendLine($"Datum od: {ao.Datum_do}");
                            sb.AppendLine($"Datum do: {ao.Datum_do}");
                            sb.AppendLine($"Status: {ao.Status}");
                            sb.AppendLine(new string('-', 40));
                        }
                        MessageBox.Show(sb.ToString(), $"Lista agencija organizatora: {listaJeCLan.Count}");
                        transaction.Commit();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormaJeClan_Load(object sender, EventArgs e)
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

        private void cmdDodavanje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Grupa g = s.Load<Grupa>(11);
                Entiteti.Posetilac p = s.Load<Entiteti.Posetilac>(18);
                JeClan jeClan = new JeClan();
                jeClan.ID.Grupa = g;
                jeClan.ID.Posetilac = p;
                jeClan.Datum_od = DateTime.Now;
                s.Save(jeClan);
                s.Flush();
                MessageBox.Show("Uspesno je sve dodato u bazi");
                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
