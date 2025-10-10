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
    public partial class FormaAgencijaOrganizatorDodaj : Form
    {
        private Form parentForm;
        public FormaAgencijaOrganizatorDodaj(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                MessageBox.Show("Unesite naziv agencije organizator grupe.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAdresa.Text))
            {
                MessageBox.Show("Unesite adresu agencije.");
                return;
            }
            ISession s= DataLayer.GetSession();
            AgencijaOrganizator agencijaOrganizator = new AgencijaOrganizator
            {
                NAZIV = txtNaziv.Text.Trim(),
                ADRESA = txtAdresa.Text.Trim()
            };
            s.Save(agencijaOrganizator);
            s.Flush();
            MessageBox.Show("Agencija je uspešno sačuvana.");
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
