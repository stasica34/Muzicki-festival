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
    public partial class FormaPosetilacIzmeni : Form
    {
        private Posetilac posetilacZaIzmenu;
        private Form parentform;
        public FormaPosetilacIzmeni(Form caller, Posetilac posetilac)
        {
            InitializeComponent();
            parentform = caller;
            this.posetilacZaIzmenu = posetilac;
        }

        private void FormaPosetilacIzmeni_Load(object sender, EventArgs e)
        {
            try
            {
                txtIme.Text = posetilacZaIzmenu.IME;
                txtPrezime.Text = posetilacZaIzmenu.PREZIME;
                txtEmail.Text = posetilacZaIzmenu.EMAIL;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom učitavanja forme za izmenu: " + ex.Message);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text) || string.IsNullOrWhiteSpace(txtPrezime.Text) ||
               string.IsNullOrWhiteSpace(txtEmail.Text)
               )
            {
                MessageBox.Show("Molimo popunite sva polja ispravno.");
                return;
            }

            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Posetilac p = s.Get<Posetilac>(posetilacZaIzmenu.ID);

                    p.IME = txtIme.Text.Trim();
                    p.PREZIME = txtPrezime.Text.Trim();
                    p.EMAIL = txtEmail.Text.Trim();
                    s.Update(p);
                    s.Flush();
                }
                MessageBox.Show("Posetilac je uspešno izmenjen.");
                parentform.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            parentform.Show();
            this.Close();
        }
    }
}
