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
    public partial class FormaBend : Form
    {
        private Form parentForm;
        public FormaBend(Form caller)
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
                        var listaBendova = session.QueryOver<Bend>().List();
                        if(listaBendova.Count==0)
                        {
                            MessageBox.Show("Nema bendova u bazi.");
                            return;
                        }
                        StringBuilder sb = new StringBuilder();
                        foreach(var b in listaBendova)
                        {
                            sb.AppendLine($"ID: {b.ID}");
                            sb.AppendLine($"Broj clanova: {b.BROJ_CLANOVA}");
                            sb.AppendLine(new string('-', 40));
                        }
                        MessageBox.Show(sb.ToString(), $"Lista bendova: {listaBendova.Count}");
                        transaction.Commit();
                    }
                }
                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormaBend_Load(object sender, EventArgs e)
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

        private void cmd_Nazad_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }
    }
}
