using Muzicki_festival.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muzicki_festival.FormeDodatne
{
    public partial class FormaDodajGrupu : Form
    {
        private IList<AgencijaOrganizatorView> agencijaOrganizatorViews;

        public FormaDodajGrupu()
        {
            InitializeComponent();

            agencijaOrganizatorViews = DTOManager.VratiSveAgencije();
            PopuniCmbBoxAgencije();
        }

        private void PopuniCmbBoxAgencije()
        {
            cmbAgencije.Items.Clear();
            foreach (var a in agencijaOrganizatorViews)
                cmbAgencije.Items.Add(a);
        }

        private void DugmeDodajAgenciju_Click(object sender, EventArgs e)
        {
            FormaDodajAgencijuOrganizator forma = new FormaDodajAgencijuOrganizator();
            this.Hide();
            forma.ShowDialog();
            this.Show();

            agencijaOrganizatorViews = DTOManager.VratiSveAgencije();
            PopuniCmbBoxAgencije();
        }

        private void DugmeDodaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNaziv.Text))
            {
                MessageBox.Show("Unesite naziv!");
                return;
            }

            if (cmbAgencije.SelectedItem == null)
            {
                MessageBox.Show("Izaberite agenciju!");
                return;
            }

            AgencijaOrganizatorView av = cmbAgencije.SelectedItem as AgencijaOrganizatorView;
            AgencijaOrganizatorBasic ab = new AgencijaOrganizatorBasic(av.Id, av.Naziv, av.Adresa, null);
            GrupaBasic gb = new GrupaBasic(0, txtNaziv.Text, ab, null);

            GrupaView nova = DTOManager.DodajGrupu(gb);

            if (nova != null)
            {
                MessageBox.Show("Uspesno dodata grupa!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void DugmeOtkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
