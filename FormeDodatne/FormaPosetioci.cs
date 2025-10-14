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
    public partial class FormaPosetioci : Form
    {
        private IList<PosetilacView> posetilacViews;
        private int idSelektovan = -1;
        private IList<GrupaView> grupaViews = new List<GrupaView>();
        private int selektovanaGrupaId = -1;
        private bool IzmenaUToku = false;

        public FormaPosetioci()
        {
            InitializeComponent();
            posetilacViews = DTOManager.VratiSvePosetioce();

            InitTabeluPosetioci();
            PopuniTabeluPosetioci();

            InitTabeluGrupe();
            InitTabeluClanovi();

            MessageBox.Show("Ovde je moguc pregled, izmena i brisanje posetioca. Dodavnje se vrsi preko forme za dogadjaje",
                "Napoemena", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        private void InitTabeluPosetioci()
        {
            TabelaPosetioci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            TabelaPosetioci.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TabelaPosetioci.ReadOnly = true;
            TabelaPosetioci.AllowUserToAddRows = false;
            TabelaPosetioci.RowHeadersVisible = false;
            TabelaPosetioci.BorderStyle = BorderStyle.None;
            TabelaPosetioci.BackgroundColor = Color.WhiteSmoke;
            TabelaPosetioci.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            TabelaPosetioci.GridColor = Color.LightGray;

            TabelaPosetioci.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

            TabelaPosetioci.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            TabelaPosetioci.DefaultCellStyle.SelectionForeColor = Color.White;
            TabelaPosetioci.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            TabelaPosetioci.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            TabelaPosetioci.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            TabelaPosetioci.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 90, 150);
            TabelaPosetioci.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            TabelaPosetioci.EnableHeadersVisualStyles = false;

            TabelaPosetioci.Columns.Add("ID", "ID");
            TabelaPosetioci.Columns["ID"].Visible = false;
            TabelaPosetioci.Columns.Add("IME", "IME");
            TabelaPosetioci.Columns.Add("PREZIME", "PREZIME");
            TabelaPosetioci.Columns.Add("EMAIL", "EMAIL");
            TabelaPosetioci.Columns.Add("TELEFON", "TELEFON");
        }

        private void PopuniTabeluPosetioci()
        {
            TabelaPosetioci.Rows.Clear();
            foreach(var p in posetilacViews)
            {
                TabelaPosetioci.Rows.Add(p.Id, p.Ime, p.Prezime, p.Email, p.Telefon);
            }
        }
        private void InitTabeluGrupe()
        {
            TabelaGrupe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            TabelaGrupe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TabelaGrupe.ReadOnly = true;
            TabelaGrupe.AllowUserToAddRows = false;
            TabelaGrupe.RowHeadersVisible = false;
            TabelaGrupe.BorderStyle = BorderStyle.None;
            TabelaGrupe.BackgroundColor = Color.WhiteSmoke;
            TabelaGrupe.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            TabelaGrupe.GridColor = Color.LightGray;

            TabelaGrupe.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

            TabelaGrupe.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            TabelaGrupe.DefaultCellStyle.SelectionForeColor = Color.White;
            TabelaGrupe.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            TabelaGrupe.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            TabelaGrupe.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            TabelaGrupe.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 90, 150);
            TabelaGrupe.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            TabelaGrupe.EnableHeadersVisualStyles = false;

            TabelaGrupe.Columns.Add("ID", "ID");
            TabelaGrupe.Columns["ID"].Visible = false;

            TabelaGrupe.Columns.Add("NAZIV", "NAZIV");
            TabelaGrupe.Columns.Add("AGENCIJA", "AGENCIJA");
        }
        private void PopuniTabeluGrupe()
        {
            TabelaGrupe.Rows.Clear();
            foreach (var g in grupaViews)
                TabelaGrupe.Rows.Add(g.Id, g.Naziv, g.NazivAgencije);
        }

        private void InitTabeluClanovi()
        {
            TabelaClanovi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            TabelaClanovi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TabelaClanovi.ReadOnly = true;
            TabelaClanovi.AllowUserToAddRows = false;
            TabelaClanovi.RowHeadersVisible = false;
            TabelaClanovi.BorderStyle = BorderStyle.None;
            TabelaClanovi.BackgroundColor = Color.WhiteSmoke;
            TabelaClanovi.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            TabelaClanovi.GridColor = Color.LightGray;

            TabelaClanovi.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

            TabelaClanovi.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            TabelaClanovi.DefaultCellStyle.SelectionForeColor = Color.White;
            TabelaClanovi.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            TabelaClanovi.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            TabelaClanovi.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            TabelaClanovi.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 90, 150);
            TabelaClanovi.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            TabelaClanovi.EnableHeadersVisualStyles = false;

            TabelaClanovi.Columns.Add("IME_CLANA", "IME_CLANA");
        }

        private void PopuniTabeluClanovi()
        {
            TabelaClanovi.Rows.Clear();
            var grupa = grupaViews.Where(g => g.Id == selektovanaGrupaId).FirstOrDefault();
            if (grupa != null)
            {
                var imena = grupa.Clanovi;
                foreach (var i in imena)
                {
                    TabelaClanovi.Rows.Add(i);
                }
            }
        }

        private void IzmeniDugme_Click(object sender, EventArgs e)
        {
            if (idSelektovan == -1)
            {
                MessageBox.Show("Izaberite posetioca za izmenu!");
                return;
            }

            IzmenaUToku = true;
            GrupaPodaci.Enabled = true;

            PosetilacView selektovan = posetilacViews.Where(p => p.Id == idSelektovan).FirstOrDefault();
            txtIme.Text = selektovan.Ime;
            txtPrezime.Text = selektovan.Prezime;
            txtEmail.Text = selektovan.Email;
            txtTelefon.Text = selektovan.Telefon;
            ObrisiDugme.Enabled = false;
        }

        private void PotvrdiIzmeneDugme_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIme.Text) || string.IsNullOrEmpty(txtPrezime.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Niste uneli sve neophodne podatke!");
                return;
            }

            PosetilacView view = posetilacViews.Where(p => p.Id == idSelektovan).FirstOrDefault();
            PosetilacBasic pb = new PosetilacBasic(view.Id, txtIme.Text, txtPrezime.Text, txtEmail.Text, txtTelefon.Text, null, null);

            PosetilacView izmenjen = DTOManager.IzmeniPosetioca(pb);

            if (izmenjen != null)
            {
                view.Ime = izmenjen.Ime;
                view.Prezime = izmenjen.Prezime;
                view.Email = izmenjen.Email;
                view.Telefon = izmenjen.Telefon;
                PopuniTabeluPosetioci();

                MessageBox.Show("Uspesno izmenjen posetioc!");
                idSelektovan = -1;
                GrupaPodaci.Enabled = false;
                txtIme.Text = "";
                txtPrezime.Text = "";
                txtEmail.Text = "";
                txtTelefon.Text = "";
            }
            else
            {
                MessageBox.Show("Greska pri izmeni!");
            }
        }

        private void TabelaPosetioci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < TabelaPosetioci.Rows.Count)
            {
                var row = TabelaPosetioci.Rows[e.RowIndex];
                idSelektovan = (int)row.Cells["ID"].Value;

                UlaznicaBasic u = DTOManager.VratiUlaznicuPosetioca(idSelektovan);

                if (u != null)
                {
                    LabelaCena.Text = u.OsnovnaCena.ToString();
                    LabelaDatumKupovine.Text = u.DatumKupovine.ToString();
                    LabelaNacin.Text = u.NacinPlacanja;
                    LabelaTip.Text = u.TipUlaznice.ToString();
                }
                else
                {
                    MessageBox.Show("Greska");
                }

                if (IzmenaUToku == true)
                {
                    IzmenaUToku = false;
                    txtEmail.Text = "";
                    txtIme.Text = "";
                    txtPrezime.Text = "";
                    txtTelefon.Text = "";
                    GrupaPodaci.Enabled = false;
                }

                GrupaView grupa = DTOManager.VratiGrupuPosetioca(idSelektovan);

                if (grupa != null)
                {
                    grupaViews.Clear();
                    grupaViews.Add(grupa);
                    PopuniTabeluGrupe();

                    DugmeUclani.Enabled = false;
                    DugmeNapustiGrupu.Enabled = true;
                    selektovanaGrupaId = grupa.Id;
                    PopuniTabeluClanovi();
                }
                else
                {
                    grupaViews = DTOManager.VratiSveGrupe();
                    PopuniTabeluGrupe();

                    selektovanaGrupaId = -1;
                    PopuniTabeluClanovi();
                    
                    DugmeUclani.Enabled = true;
                    DugmeNapustiGrupu.Enabled = false;
                }

                ObrisiDugme.Enabled = true;
            }
        }

        private void TabelaGrupe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < TabelaGrupe.Rows.Count)
            {
                var row = TabelaGrupe.Rows[e.RowIndex];
                int id = (int)row.Cells["ID"].Value;
                selektovanaGrupaId = id;
                PopuniTabeluClanovi();
            }
        }

        private void DugmeUclani_Click(object sender, EventArgs e)
        {
            if (selektovanaGrupaId == -1)
            {
                MessageBox.Show("Izaberite prvo grupu!");
                return;
            }


            if (DTOManager.DodajClanaGrupi(selektovanaGrupaId, idSelektovan))
            {
                MessageBox.Show("Uspesno učlanjen");

                GrupaView grupa = grupaViews.Where(g => g.Id == selektovanaGrupaId).FirstOrDefault();
                grupaViews.Clear();
                grupaViews.Add(grupa);

                PopuniTabeluGrupe();

                PosetilacView view = posetilacViews.Where(p => p.Id == idSelektovan).FirstOrDefault();

                grupa.Clanovi.Add(view.Ime);
                PopuniTabeluClanovi();

                DugmeNapustiGrupu.Enabled = true;
                DugmeNapustiGrupu.Enabled = false;
            }
            else
            {
                MessageBox.Show("Greška pri učlanivanju!");
                return;
            }
        }

        private void DugmeNapustiGrupu_Click(object sender, EventArgs e)
        {
            if (selektovanaGrupaId == -1)
            {
                MessageBox.Show("Izaberite prvo grupu!");
                return;
            }

            if (DTOManager.IzbaciIzGrupe(idSelektovan, selektovanaGrupaId))
            {
                MessageBox.Show("Uspešno napustio grupu!");

                grupaViews = DTOManager.VratiSveGrupe();
                PopuniTabeluGrupe();
                selektovanaGrupaId = -1;
                PopuniTabeluClanovi();

                DugmeNapustiGrupu.Enabled = false;
                DugmeUclani.Enabled = true;
            }
        }

        private void ObrisiDugme_Click(object sender, EventArgs e)
        {
            if (idSelektovan == -1)
            {
                MessageBox.Show("Prvo izaberite posetioca za brisanje!");
                return;
            }

            if (MessageBox.Show(
                "Da li ste sigurni da želite da obrišete posetioca, ovo je nepovratna radnja.", 
                "Potvrda", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (DTOManager.ObrisiPosetioca(idSelektovan))
            {
                MessageBox.Show("Posetioc uspešno obrisan!");

                PosetilacView obrisan = posetilacViews.Where(p => p.Id == idSelektovan).FirstOrDefault();
                posetilacViews.Remove(obrisan);
                PopuniTabeluPosetioci();

                LabelaCena.Text = "";
                LabelaDatumKupovine.Text = "";
                LabelaNacin.Text = "";
                LabelaTip.Text = "";
            }
        }
    }
}
