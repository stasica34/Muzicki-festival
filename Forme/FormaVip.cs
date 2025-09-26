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
    public partial class FormaVip : Form
    {
        private Form parentForm;

        public FormaVip(Form caller)
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
                        var listavVip = session.QueryOver<Vip>().List();
                        if (listavVip.Count == 0)
                        {
                            MessageBox.Show("Nema Vip ulaznica u bazi.");
                            return;
                        }
                        StringBuilder sb = new StringBuilder();
                        foreach (var b in listavVip)
                        {
                            sb.AppendLine($"ID ulaznice: {b.ID_ULAZNICE}");
                            sb.AppendLine(new string('-', 40));
                        }
                        MessageBox.Show(sb.ToString(), $"Lista Vip ulaznica: {listavVip.Count}");
                        transaction.Commit();
                    }
                }
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormaVip_Load(object sender, EventArgs e)
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
