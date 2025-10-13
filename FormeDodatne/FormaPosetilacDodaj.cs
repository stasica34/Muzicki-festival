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
using Muzicki_festival.DTOs;
namespace Muzicki_festival.FormeDodatne
{
    public partial class FormaPosetilacDodaj : Form
    {
        private Form parentForm;
        private readonly DogadjajView Dogadjaj;
        private UlaznicaBasic ulaznica = null;

        public FormaPosetilacDodaj(Form parentForm, DogadjajView dogadjaj)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            Dogadjaj = dogadjaj;
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
            if (ulaznica == null)
            {
                MessageBox.Show("Dodajte ulaznicu za korisnika!");
                return;
            }

            PosetilacBasic pb = new PosetilacBasic(0, txtIme.Text, txtPrezime.Text, txtEmail.Text, txtTelefon.Text, ulaznica);
            
            if (DTOManager.DodajPosetioca(pb) != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.No;
                this.Close();
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void DugmeDodajUlaznicu_Click(object sender, EventArgs e)
        {
            DogadjajBasic db = new DogadjajBasic(Dogadjaj.Id, Dogadjaj.Naziv, Dogadjaj.Tip, Dogadjaj.Opis, Dogadjaj.DatumPocetka, Dogadjaj.DatumKraja, null, null);

            FormaUlazniceDodaj forma = new FormaUlazniceDodaj(this, db);
            DialogResult dr = forma.ShowDialog();

            if (dr == DialogResult.OK)
            {
                ulaznica = forma.UlaznicaBasicIzlaz;
            }
            else if (dr == DialogResult.No)
            {
                MessageBox.Show("Greska");
            }
        }
    }
}
