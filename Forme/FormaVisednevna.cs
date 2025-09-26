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
    public partial class FormaVisednevna : Form
    {
        private Form parentForm;
        public FormaVisednevna(Form caller)
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
                        // Učitaj visednevne ulaznice zajedno sa danima
                        var visednevna = session.QueryOver<Visednevna>()
                           .Fetch(SelectMode.Fetch, x => x.Dani)
                           .List();

                        if (visednevna.Count == 0)
                        {
                            MessageBox.Show("Nema visednevnih karata u bazi.");
                            return;
                        }

                        StringBuilder sb = new StringBuilder();
                        var grupisanoPoId = visednevna
                           .GroupBy(x => x.ID_ULAZNICE);
                        foreach (var ulaznica in grupisanoPoId)
                        {
                            sb.AppendLine($"ID ulaznice: {ulaznica.Key}");
                            sb.AppendLine("Broj dana: " + ulaznica.First().BROJ_DANA);
                            sb.AppendLine("Dani:");

                            var sviDani = ulaznica
                            .SelectMany(x => x.Dani)
                            .Select(p => p.DAN_VAZENJA)
                            .Distinct();

                            foreach (var dani in sviDani)
                            {
                                sb.AppendLine($" - {dani}");
                            }

                            sb.AppendLine(new string('-', 40));
                        }

                        MessageBox.Show(sb.ToString(), $"Lista visednevnih karata: {visednevna.Count}");

                        transaction.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }



        private void FormaVisednevna_Load(object sender, EventArgs e)
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
