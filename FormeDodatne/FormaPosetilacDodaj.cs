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
namespace Muzicki_festival.FormeDodatne
{
    public partial class FormaPosetilacDodaj : Form
    {
        private Form parentForm;
        public FormaPosetilacDodaj(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                MessageBox.Show("Unesite ime posetioca.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                MessageBox.Show("Unesite prezime posetioca.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Unesite email posetioca.");
                return;
            }
            ISession s = DataLayer.GetSession();
            Posetilac posetilac = new Posetilac
            {
                IME = txtIme.Text,
                PREZIME = txtPrezime.Text,
                EMAIL = txtEmail.Text
            };
            s.Save(posetilac);
            s.Flush();
            s.Close();
            MessageBox.Show("Posetilac je uspešno dodat.");
            parentForm.Show();
            this.Close();

        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }
    }
}
