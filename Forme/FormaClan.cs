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
    public partial class FormaClan : Form
    {
        private Form parentForm;
        public FormaClan(Form caller)
        {
            InitializeComponent();
            parentForm = caller;

        }

        private void FormaClan_Load(object sender, EventArgs e)
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
                        var listaClanova = session.QueryOver<Clan>().List();
                        if (listaClanova.Count == 0)
                        {
                            MessageBox.Show("Nema clanova u bazi.");
                            return;
                        }
                        StringBuilder sb = new StringBuilder();
                        foreach (var a in listaClanova)
                        {
                            sb.AppendLine($"ID: {a.IME}");
                            sb.AppendLine($"INstrument: {a.INSTRUMENT}");
                            sb.AppendLine($"Bend_ID: {a.BEND_ID.ID}");
                            sb.AppendLine(new string('-', 40));
                        }
                        MessageBox.Show(sb.ToString(), $"Lista akreditacija: {listaClanova.Count}");
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
