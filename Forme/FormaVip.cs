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
                using (var session = DataLayer.GetSession())
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        var listavVip = session.QueryOver<Vip>()
                            .Fetch(SelectMode.Fetch, x => x.Pogodnosti)
                            .List();

                        if (listavVip.Count == 0)
                        {
                            MessageBox.Show("Nema Vip ulaznica u bazi.");
                            return;
                        }

                        StringBuilder sb = new StringBuilder();

                        // Grupisanje po ID ulaznice
                        var grupisanoPoId = listavVip
                            .GroupBy(x => x.ID_ULAZNICE);

                        foreach (var grupa in grupisanoPoId)
                        {
                            sb.AppendLine($"ID ulaznice: {grupa.Key}");
                            sb.AppendLine("Pogodnosti:");

                            // Spajanje svih pogodnosti iz grupe i uklanjanje duplikata
                            var svePogodnosti = grupa
                                .SelectMany(x => x.Pogodnosti)
                                .Select(p => p.POGODNOST)
                                .Distinct();

                            foreach (var pogodnost in svePogodnosti)
                            {
                                sb.AppendLine($" - {pogodnost}");
                            }

                            sb.AppendLine(new string('-', 40));
                        }

                        MessageBox.Show(sb.ToString(), $"Lista Vip ulaznica: {grupisanoPoId.Count()}");
                        transaction.Commit();
                    }
                }
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
