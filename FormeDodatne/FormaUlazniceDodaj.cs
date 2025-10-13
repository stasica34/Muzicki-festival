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
using Muzicki_festival.DTOs;
namespace Muzicki_festival.FormeDodatne
{
    public partial class FormaUlazniceDodaj : Form
    {
        private Form parentform;
        DogadjajBasic db;
        public UlaznicaBasic UlaznicaBasicIzlaz;
        public FormaUlazniceDodaj(Form caller, DogadjajBasic db)
        {
            InitializeComponent();
            parentform = caller;
            this.db = db;
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
            if (txtCena.Value <= 0)
            {
                MessageBox.Show("Unesite validnu cenu ulaznice.");
                return;
            }
            if (dtpDatum.Value > DateTime.Now)
            {
                MessageBox.Show("Datum kupovine ne može biti u budućnosti.");
                return;
            }
            if (cmbTip.SelectedIndex == -1)
            {
                MessageBox.Show("Izaberite tip ulaznice!");
                return;
            }

            string placanje = cmbPlacanje.SelectedItem as string;

            string tip = (string)cmbTip.SelectedItem;
            switch (tip)
            {
                case "Jednodnevna":

                    UlaznicaBasicIzlaz = new JednodnevnaBasic(0, (float)txtCena.Value, placanje, dtpDatum.Value, db, DatumJednodnevna.Value);
                    break;
                case "Visednevna":
                    if (TabelaDaniVisednevna.Rows.Count < 2)
                    { 
                        MessageBox.Show("Dodajte bar 2 dana za visednevnu ulaznicu!");
                        return;
                    }

                    List<DateTime> list = new List<DateTime>();
                    foreach (var r in TabelaDaniVisednevna.Rows)
                    {
                        list.Add((DateTime)r);
                    }

                    UlaznicaBasicIzlaz = new ViseDnevnaBasic(0, (float)txtCena.Value, placanje, dtpDatum.Value, db, list);

                    break;
                case "Akreditacija":

                    TipAkreditacije tipAkreditacije;
                    if (radioParter.Checked)
                        tipAkreditacije = TipAkreditacije.PARTNER;
                    else if (radioPress.Checked)
                        tipAkreditacije = TipAkreditacije.PRESS;
                    else
                        tipAkreditacije = TipAkreditacije.SPONZOR;

                    UlaznicaBasicIzlaz = new AkreditacijaBasic(0, (float)txtCena.Value, placanje, dtpDatum.Value, db, tipAkreditacije);

                        break;
                case "VIP":

                    if (TabelaPogodnosti.Rows.Count <= 0)
                    {
                        MessageBox.Show("Dodajte bar jednu pogodnost!");
                        return;
                    }

                    List<string> pogodnosti = new List<string>();
                    foreach(var r in TabelaPogodnosti.Rows)
                    {
                        pogodnosti.Add(r as string);
                    }

                    UlaznicaBasicIzlaz = new VIPBasic(0, (float)txtCena.Value, placanje, dtpDatum.Value, db, pogodnosti);

                    break;
            }

            if (UlaznicaBasicIzlaz != null)
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
