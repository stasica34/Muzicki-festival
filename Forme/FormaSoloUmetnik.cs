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
    public partial class FormaSoloUmetnik : Form
    {
        private Form parentForm;
        public FormaSoloUmetnik(Form caller)
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
                        var listaSoloUmetnika = session.QueryOver<Solo_Umetnik>().List();
                        if(listaSoloUmetnika.Count==0)
                        {
                            MessageBox.Show("Nema solo umetnika u bazi.");
                            return;
                        }
                        StringBuilder sb = new StringBuilder();
                        foreach(var su in listaSoloUmetnika)
                        {
                            sb.AppendLine($"ID: {su.ID}");
                            sb.AppendLine($"Svira instrument: {su.SVIRA_INSTRUMENT}");
                            sb.AppendLine($"Tip instrumenta: {su.TIP_INSTRUMENTA}");
                            sb.AppendLine(new string('-', 40));
                        }
                        MessageBox.Show(sb.ToString(), $"Lista solo umetnika: {listaSoloUmetnika.Count}");
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

        private void FormaSoloUmetnik_Load(object sender, EventArgs e)
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
                MessageBox.Show(ex.Message);
            }
        }
    }
}
