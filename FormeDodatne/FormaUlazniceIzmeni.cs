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
    public partial class FormaUlazniceIzmeni : Form
    {
        private Ulaznica ulaznicaIzmeni;
        private Form parentform;
        public FormaUlazniceIzmeni(Form caller, Ulaznica ulaznica)
        {
            InitializeComponent();
            parentform = caller;
            this.ulaznicaIzmeni = ulaznica;
        }
        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            parentform.Show();
            this.Close();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text) || cmbKupac.SelectedItem == null ||
                cmbPlacanje.SelectedItem == null ||nudCena.Value <= 0 ||
                dtpDatum.Value > DateTime.Now)
            {
                MessageBox.Show("Molimo popunite sva polja ispravno.");
                return;
            }


            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Ulaznica u = s.Load<Ulaznica>(ulaznicaIzmeni.ID_ULAZNICE);

                    u.DATUM_KUPOVINE  = dtpDatum.Value;
                    u.KUPAC_ID = (Posetilac)cmbKupac.SelectedItem;
                    u.NACIN_PLACANJA = cmbPlacanje.SelectedItem.ToString();
                    u.NAZIV = txtNaziv.Text.Trim();
                    u.OSNOVNA_CENA = (float)nudCena.Value;
                    u.KUPAC_ID = (Posetilac)cmbKupac.SelectedItem;


                    s.Update(u);
                    s.Flush();
                }

                MessageBox.Show("Ulaznica uspešno izmenjena.");
                parentform.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void FormaUlazniceIzmeni_Load(object sender, EventArgs e)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var sviposetioci = s.QueryOver<Posetilac>().List();
                    foreach (var posetilac in sviposetioci)
                    {
                        cmbKupac.Items.Add(posetilac);
                    }
                }
                cmbPlacanje.Items.AddRange(new string[]
                {
                    "Gotovina",
                    "Kartica",
                    "Online"
                });
                cmbTip.Items.AddRange(new string[]
                {
                    "Jednodnevna",
                    "Visednevna",
                    "Akreditacija",
                    "VIP"
                });
                cmbTip.DropDownStyle = ComboBoxStyle.DropDownList;
                if (ulaznicaIzmeni is Jednodnevna)
                    cmbTip.SelectedItem = "Jednodnevna";
                else if (ulaznicaIzmeni is Visednevna)
                    cmbTip.SelectedItem = "Visednevna";
                else if (ulaznicaIzmeni is Akreditacija)
                    cmbTip.SelectedItem = "Akreditacija";
                else if (ulaznicaIzmeni is Vip)
                    cmbTip.SelectedItem = "VIP";
                cmbKupac.DropDownStyle = ComboBoxStyle.DropDownList;
                txtNaziv.Text = ulaznicaIzmeni.NAZIV;
                cmbPlacanje.SelectedItem = ulaznicaIzmeni.NACIN_PLACANJA;
                nudCena.Maximum = Math.Max(nudCena.Maximum, (decimal)ulaznicaIzmeni.OSNOVNA_CENA);
                nudCena.Value = (decimal)ulaznicaIzmeni.OSNOVNA_CENA;
                dtpDatum.Value = ulaznicaIzmeni.DATUM_KUPOVINE;

                foreach (Posetilac posetilac in cmbKupac.Items)
                {
                    if (posetilac.ID.Equals(ulaznicaIzmeni.KUPAC_ID.ID))
                    {
                        cmbKupac.SelectedItem = posetilac;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom učitavanja forme za izmenu: " + ex.Message);
            }
        }
    }
}
