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
    public partial class FormaGrupaIzmeni : Form
    {
        private Grupa grupazaIzmenu;
        private Form parentform;
        public FormaGrupaIzmeni(Form caller, Grupa grupa)
        {
            InitializeComponent();
            parentform = caller;
            this.grupazaIzmenu = grupa;
        }

        private void FormaGrupaIzmeni_Load(object sender, EventArgs e)
        {
            txtNaziv.Text = grupazaIzmenu.NAZIV;
            if (grupazaIzmenu.AgencijaID.NAZIV != null)
            {
                txtAgencijaOrganizator.Text = grupazaIzmenu.AgencijaID.NAZIV;
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            parentform.Show();
            this.Close();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text) || string.IsNullOrWhiteSpace(txtAgencijaOrganizator.Text))
            {
                MessageBox.Show("Molimo popunite sva polja ispravno.");
                return;
            }

            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Grupa grupa = s.Get<Grupa>(grupazaIzmenu.ID_GRUPE);

                    grupa.NAZIV = txtNaziv.Text.Trim();
                    if (grupazaIzmenu.AgencijaID.NAZIV != null)
                    {
                        txtAgencijaOrganizator.Text = grupazaIzmenu.AgencijaID.NAZIV;
                    }

                    s.Update(grupa);
                    s.Flush();
                }

                MessageBox.Show("Događaj uspešno izmenjen.");
                parentform.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }
    }
}
