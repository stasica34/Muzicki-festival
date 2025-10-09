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
    public partial class FormaKontaktPodaci : Form
    {
        private Form parentForm;
        public KontaktPodaciMenadzerskaAgencija NoviKontakt { get; private set; }

        public FormaKontaktPodaci(Form caller)
        {
            InitializeComponent();
            parentForm = caller;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Unesite telefon.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                MessageBox.Show("Unesite email.");
                return;
            }
            ISession s = DataLayer.GetSession();
            KontaktPodaciMenadzerskaAgencija kontakt = new KontaktPodaciMenadzerskaAgencija()
            {
                EMAIL = txtEmail.Text.Trim(),
                TELEFON = txtTelefon.Text.Trim(),
            };

            s.Flush();
            s.Close();
            NoviKontakt = kontakt;
            MessageBox.Show("Kontakt podaci su uspešno dodati.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }
    }
}
