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
    public partial class FormaAgencijaOrganizatorIzmeni : Form
    {
        private Form parentForm;
        private AgencijaOrganizator agenzijaZaizmenu;
        public FormaAgencijaOrganizatorIzmeni(Form parentForm, AgencijaOrganizator agencija)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.agenzijaZaizmenu = agencija;
        }

        private void FormaAgencijaOrganizatorIzmeni_Load(object sender, EventArgs e)
        {
            txtNaziv.Text = agenzijaZaizmenu.NAZIV;
            txtAdresa.Text = agenzijaZaizmenu.ADRESA;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNaziv.Text) || string.IsNullOrWhiteSpace(txtAdresa.Text))
            {
                MessageBox.Show("Molimo popunite sva polja ispravno.");
                return;
            }

            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    AgencijaOrganizator agencijaOrganizator = s.Get<AgencijaOrganizator>(agenzijaZaizmenu.ID);

                    agencijaOrganizator.NAZIV = txtNaziv.Text.Trim();
                    agencijaOrganizator.ADRESA = txtAdresa.Text.Trim();
                    s.Update(agencijaOrganizator);
                    s.Flush();
                }

                MessageBox.Show("Događaj uspešno izmenjen.");
                parentForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }
    }
}
