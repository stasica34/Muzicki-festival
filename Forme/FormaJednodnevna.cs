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
using NHibernate.Context;

namespace Muzicki_festival.Forme
{
    public partial class FormaJednodnevna : Form
    {
        private Form parentForm;
        public FormaJednodnevna(Form caller)
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
            //    try
            //    {
            //        ISession s = DataLayer.GetSession();
            //        using (var session = DataLayer.GetSession())
            //        {

            //            var listaJednodnevna = session.QueryOver<Jednodnevna>().List();
            //            if (listaJednodnevna.Count == 0)
            //            {
            //                MessageBox.Show("Nema jednodnevnih ulaznica  u bazi.");
            //                return;
            //            }
            //            StringBuilder sb = new StringBuilder();
            //            foreach (var ao in listaJednodnevna)
            //            {
            //                sb.AppendLine($"ID: {ao.ID_ULAZNICE}");
            //                sb.AppendLine($"Dan vazenja: {ao.DAN_VAZENJA}");
            //                sb.AppendLine(new string('-', 40));
            //            }
            //            MessageBox.Show(sb.ToString(), $"Lista jednodnevna: {listaJednodnevna.Count}");
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //drugi nacin:
            try
            {
                ISession s = DataLayer.GetSession();
                IList<Ulaznica> ulaznica = s.QueryOver<Ulaznica>()
                    .Where(x => x.ID_ULAZNICE == 10)
                    .List<Ulaznica>();
                Jednodnevna j = (Jednodnevna)ulaznica[0];
                if (ulaznica.Count == 0)
                {
                    MessageBox.Show("Nema ulaznica sa ID 10 u bazi.");
                    return;
                }
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"ID: {j.ID_ULAZNICE}");
                sb.AppendLine($"Dan važenja: {j.DAN_VAZENJA}");
                MessageBox.Show(sb.ToString(), "Detalji ulaznice");

                
                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormaJednodnevna_Load(object sender, EventArgs e)
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
                Jednodnevna j = new Jednodnevna();
                j.DAN_VAZENJA = DateTime.Now;
                s.Save(j);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }
    }
}
