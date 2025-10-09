using Muzicki_festival.Entiteti;
using NHibernate;
using System;
using System.Windows.Forms;

namespace Muzicki_festival.FormeDodatne
{
    public partial class FormaSoloIzvodjacBendIzmeni : Form
    {
        private Form parentform;
        private bool jeSolo;
        private string ime, drzava, email, kontakt, telefon;
        private MenadzerskaAgencija menadzerska;
        private int postojediId;
        public FormaSoloIzvodjacBendIzmeni(Form caller, bool jeSolo,
            string ime, string drzava, string email, string kontakt, string telefon, MenadzerskaAgencija menadzerska, int id)
        {
            InitializeComponent();
            parentform = caller;
            this.jeSolo = jeSolo;
            this.ime = ime;
            this.drzava = drzava;
            this.email = email;
            this.kontakt = kontakt;
            this.telefon = telefon;
            this.menadzerska = menadzerska;
            this.postojediId = id;
        }

        private void FormaSoloIzvodjacBendDodaj_Load(object sender, EventArgs e)
        {
            cmbSvira.Items.Add("DA");
            cmbSvira.Items.Add("NE");
            if (jeSolo)
            {
                labelSvira.Visible = true;
                cmbSvira.Visible = true;
                labelTip.Visible = true;
                txtTip.Visible = true;
                labelBrojClanova.Visible = false;
                txtBroj.Visible = false;
            }
            else
            {   labelSvira.Visible = false;
                cmbSvira.Visible = false;
                labelTip.Visible = false;
                txtTip.Visible = false;
                labelBrojClanova.Visible = true;
                txtBroj.Visible = true;
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            using (ISession s = DataLayer.GetSession())
            using (ITransaction t = s.BeginTransaction())
            {
                Izvodjac stari = s.Get<Izvodjac>(postojediId);
                if (stari == null)
                {
                    MessageBox.Show("Ne postoji izvodjac sa zadatim ID.");
                    return;
                }

                if (jeSolo)
                {
                    if (cmbSvira.SelectedItem == null)
                    {
                        MessageBox.Show("Odaberite da li izvođač svira instrument.");
                        return;
                    }
                    if (cmbSvira.SelectedItem.ToString() == "DA" && string.IsNullOrWhiteSpace(txtTip.Text))
                    {
                        MessageBox.Show("Unesite tip instrumenta jer je označeno da izvođač svira.");
                        return;
                    }
                    Solo_Umetnik solo = s.Get<Solo_Umetnik>(postojediId);
                    if (solo!=null)
                    {
                        solo.TIP_INSTRUMENTA = txtTip.Text.Trim();
                        solo.SVIRA_INSTRUMENT = cmbSvira.SelectedItem.ToString();
                        s.Update(solo);
                        
                    }
                    else
                    {
                        solo = new Solo_Umetnik
                        {
                            IME = stari.IME,
                            DRZAVA_POREKLA = stari.DRZAVA_POREKLA,
                            EMAIL = stari.EMAIL,
                            KONTAKT_OSOBA = stari.KONTAKT_OSOBA,
                            TELEFON = stari.TELEFON,
                            MenadzerskaAgencija = stari.MenadzerskaAgencija,
                            TIP_INSTRUMENTA = txtTip.Text.Trim(),
                            SVIRA_INSTRUMENT = cmbSvira.SelectedItem.ToString()
                        };
                        s.Save(solo);
                    }
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(txtBroj.Text))
                    {
                        MessageBox.Show("Unesite broj clanova.");
                        return;
                    }
                    Bend bend = s.Get<Bend>(postojediId);
                    if (bend != null)
                    {
                        bend.BROJ_CLANOVA = int.Parse(txtBroj.Text.Trim());
                        s.Update(bend);
                    }
                    else
                    {
                        return;
                    }
                }
                s.Flush();
                t.Commit();

                MessageBox.Show(jeSolo ? "Solo umetnik uspešno izmenjen." : "Bend uspešno izmenjen.");
                parentform.Show();
                this.Close();
            }
        }



        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            parentform.Show();
            this.Close();
        }

        private void cmbSvira_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
