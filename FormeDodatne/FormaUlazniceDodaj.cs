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
using Muzicki_festival.Forme;
namespace Muzicki_festival.FormeDodatne
{
    public partial class FormaUlazniceDodaj : Form
    {
        private Form parentform;
        public FormaUlazniceDodaj(Form caller)
        {
            InitializeComponent();
            parentform = caller;
        }

        private void FormaUlazniceDodaj_Load(object sender, EventArgs e)
        {
            cmbPlacanje.Items.AddRange(new string[]
            {
                "Gotovina",
                "Kartica",
                "Online"
            });
            cmbPlacanje.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTip.Items.AddRange(new string[]
            {
                "Jednodnevna",
                "Visednevna",
                "Akreditacija",
                "VIP"
            });

            cmbTip.SelectedValue = cmbTip.Items[0];

            InputJednodnevna.Visible = true;
            InputVisednevna.Visible = false;
            InputVIP.Visible = false;
            InputAkreditacija.Visible = false;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (cmbPlacanje.SelectedIndex == -1)
            {
                MessageBox.Show("Odaberite nacin placanja.");
                return;
            }
            if (nudCena.Value <= 0)
            {
                MessageBox.Show("Unesite validnu cenu ulaznice.");
                return;
            }
            if (dtpDatum.Value > DateTime.Now)
            {
                MessageBox.Show("Datum kupovine ne može biti u budućnosti.");
                return;
            }
            try
            {
               
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

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FormaPosetilac formaPosetilac = new FormaPosetilac(this);
            formaPosetilac.Show();
            this.Show();
            UcitajPosetioce();
        }
        private void UcitajPosetioce()
        {
           
        }

        private void cmbTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTip.SelectedItem)
            {
                case "Jednodnevna":
                    InputJednodnevna.Visible = true;
                    InputVisednevna.Visible = false;
                    InputVIP.Visible = false;
                    InputAkreditacija.Visible = false;
                    break;
                case "Visednevna":
                    InputJednodnevna.Visible = false;
                    InputVisednevna.Visible = true;
                    InputVIP.Visible = false;
                    InputAkreditacija.Visible = false;
                    break;
                case "VIP":
                    InputJednodnevna.Visible = false;
                    InputVisednevna.Visible = false;
                    InputVIP.Visible = true;
                    InputAkreditacija.Visible = false;
                    break;
                case "Akreditacija":
                    InputJednodnevna.Visible = false;
                    InputVisednevna.Visible = false;
                    InputVIP.Visible = false;
                    InputAkreditacija.Visible = true;
                    break;
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DugmeDodajDanVisednevna_Click(object sender, EventArgs e)
        {

        }

        private void DugmeObrisiDanVisednevna_Click(object sender, EventArgs e)
        {

        }

        private void DugmeDodajPogodnost_Click(object sender, EventArgs e)
        {

        }

        private void DugmeObrisiPogodnost_Click(object sender, EventArgs e)
        {

        }

        private void TabelaDaniVisednevna_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TabelaPogodnosti_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
