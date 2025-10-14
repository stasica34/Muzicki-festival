using Muzicki_festival.FormeDodatne;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muzicki_festival.Forme
{
    public partial class GlavnaStranica : Form
    {
        public GlavnaStranica()
        {
            InitializeComponent();
        }

        private void cmd_Izvodjac_Click(object sender, EventArgs e)
        {
            FormaIzvodjacDodaj forma = new FormaIzvodjacDodaj();
            this.Hide();
            forma.ShowDialog();
            this.Show();
        }

        private void cmd_Dogadjaji_Click(object sender, EventArgs e)
        {
            FormaDogadjaji forma = new FormaDogadjaji(this);
            this.Hide();
            forma.ShowDialog();
            this.Show();
        }

        private void DugmeLokacije_Click(object sender, EventArgs e)
        {
            FormaLokacijaDodaj forma = new FormaLokacijaDodaj();
            this.Hide();
            forma.ShowDialog();
            this.Show();
        }

        private void Posetilac_Click(object sender, EventArgs e)
        {
            FormaPosetioci forma = new FormaPosetioci();
            this.Hide();
            forma.ShowDialog();
            this.Show();
        }

        private void AgencijeOrganizatori_Click(object sender, EventArgs e)
        {
            FormaDodajAgencijuOrganizator forma = new FormaDodajAgencijuOrganizator();
            this.Hide();
            forma.ShowDialog();
            this.Show();
        }

        private void MenadzerkseAgencije_Click(object sender, EventArgs e)
        {
            FormaMenadzerskaAgencijaDodavanje forma = new FormaMenadzerskaAgencijaDodavanje();
            this.Hide();
            forma.ShowDialog();
            this.Show();
        }

        private void Grupe_Click(object sender, EventArgs e)
        {
            FormaDodajGrupu forma = new FormaDodajGrupu();
            this.Hide();
            forma.ShowDialog();
            this.Show();
        }

        private void Ulaznice_Click(object sender, EventArgs e)
        {
            FormaUlaznicePregled forma = new FormaUlaznicePregled();
            this.Hide(); 
            forma.ShowDialog(); 
            this.Show();
        }
    }
}
