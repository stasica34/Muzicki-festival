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
    public partial class FormaUlaznica : Form
    {
        private Form parentForm;
        public FormaUlaznica(Form caller)
        {
            InitializeComponent();
            parentForm = caller;
        }

        private void FormaUlaznica_Load(object sender, EventArgs e)
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
                        var listaUlaznica = session.QueryOver<Ulaznica>().List();
                        if (listaUlaznica.Count == 0)
                        {
                            MessageBox.Show("Nema ulaznica organizatora u bazi.");
                            return;
                        }
                        StringBuilder sb = new StringBuilder();
                        foreach (var ao in listaUlaznica)
                        {
                            sb.AppendLine($"ID ulaznice: {ao.ID_ULAZNICE}");
                            sb.AppendLine($"DATUM KUPOVINE: {ao.DATUM_KUPOVINE}");
                            sb.AppendLine($"OSNOVNA_CENA: {ao.OSNOVNA_CENA}");
                            sb.AppendLine($"KUPAC_ID: {ao.KUPAC_ID.IME} | {ao.KUPAC_ID.PREZIME} | {ao.KUPAC_ID.EMAIL}");
                            sb.AppendLine($"NAČIN PLAĆANJA: {ao.NACIN_PLACANJA}");
                            sb.AppendLine($"NAZIV: {ao.NAZIV}");
                            sb.AppendLine(new string('-', 40));
                        }
                        MessageBox.Show(sb.ToString(), $"Lista agencija organizatora: {listaUlaznica.Count}");
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
    }
}
