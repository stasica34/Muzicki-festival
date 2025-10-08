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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using NHibernate;

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
                        s.SaveOrUpdate(solo);
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
                    if (bend!=null)
                    {
                        bend.BROJ_CLANOVA = int.Parse(txtBroj.Text.Trim());
                        s.Update(bend);
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
