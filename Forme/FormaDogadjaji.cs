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
using Muzicki_festival.Forme;
using NHibernate;
using Muzicki_festival.FormeDodatne;
using Muzicki_festival.DTOs;
namespace Muzicki_festival.Forme
{
    public partial class FormaDogadjaji : Form
    {
        private Form parentForm;
        private IList<DogadjajView> dogadjajViews;
        private FormaDogadjajDodaj FormaDogadjajDodaj;
        private int selektovanDogadjaj = -1;

        private IList<IzvodjacView> izvodjacViews;
        private IList<PosetilacView> posetilacViews;

        public FormaDogadjaji(Form caller)
        {
            InitializeComponent();
            parentForm = caller;

            dogadjajViews = DTOManager.VratiSveDogadjaje();
            
            InitTabeluDogadjaja();
            PopuniTabeluDogadjaj();

            InitTabeluIzvodjaci();
            InitTabeluPosetioci();
        }

        private void InitTabeluDogadjaja()
        {
            TabelaDogadjaj.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            TabelaDogadjaj.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TabelaDogadjaj.ReadOnly = true;
            TabelaDogadjaj.AllowUserToAddRows = false;
            TabelaDogadjaj.RowHeadersVisible = false;
            TabelaDogadjaj.BorderStyle = BorderStyle.None;
            TabelaDogadjaj.BackgroundColor = Color.WhiteSmoke;
            TabelaDogadjaj.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            TabelaDogadjaj.GridColor = Color.LightGray;

            TabelaDogadjaj.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

            TabelaDogadjaj.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            TabelaDogadjaj.DefaultCellStyle.SelectionForeColor = Color.White;
            TabelaDogadjaj.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            TabelaDogadjaj.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            TabelaDogadjaj.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            TabelaDogadjaj.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 90, 150);
            TabelaDogadjaj.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            TabelaDogadjaj.EnableHeadersVisualStyles = false;

            TabelaDogadjaj.Columns.Add("ID", "ID");
            TabelaDogadjaj.Columns["ID"].Visible = false;
            TabelaDogadjaj.Columns.Add("NAZIV", "NAZIV");
            TabelaDogadjaj.Columns.Add("TIP", "TIP");
            TabelaDogadjaj.Columns.Add("OPIS", "OPIS");
            TabelaDogadjaj.Columns.Add("DATUM I VREME POCETKA", "DATUM I VREME POCETKA");
            TabelaDogadjaj.Columns.Add("DATUM I VREME KRAJA", "DATUM I VREME KRAJA");
            TabelaDogadjaj.Columns.Add("LOKACIJA-NAZIV", "LOKACIJA-NAZIV");
        }

        private void InitTabeluIzvodjaci()
        {
            TabelaIzvodjaci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            TabelaIzvodjaci.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TabelaIzvodjaci.ReadOnly = true;
            TabelaIzvodjaci.AllowUserToAddRows = false;
            TabelaIzvodjaci.RowHeadersVisible = false;
            TabelaIzvodjaci.BorderStyle = BorderStyle.None;
            TabelaIzvodjaci.BackgroundColor = Color.WhiteSmoke;
            TabelaIzvodjaci.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            TabelaIzvodjaci.GridColor = Color.LightGray;

            TabelaIzvodjaci.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

            TabelaIzvodjaci.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            TabelaIzvodjaci.DefaultCellStyle.SelectionForeColor = Color.White;
            TabelaIzvodjaci.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            TabelaIzvodjaci.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            TabelaIzvodjaci.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            TabelaIzvodjaci.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 90, 150);
            TabelaIzvodjaci.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            TabelaIzvodjaci.EnableHeadersVisualStyles = false;

            TabelaIzvodjaci.Columns.Add("ID", "ID");
            TabelaIzvodjaci.Columns["ID"].Visible = false;
            TabelaIzvodjaci.Columns.Add("IME", "IME");
            TabelaIzvodjaci.Columns.Add("TIP", "TIP");
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
            TabelaPosetioci.Columns.Add("TIP_ULAZNICE", "TIP_ULAZNICE");
        }

        private void PopuniTabeluDogadjaj()
        {
            TabelaDogadjaj.Rows.Clear();
            foreach (var d in dogadjajViews)
            {
                TabelaDogadjaj.Rows.Add(d.Id, d.Naziv, d.Tip, d.Opis, d.DatumPocetka, d.DatumKraja, d.LokacijaNaziv);
            }
        }

        private void PopuniTabeluIzvodjaci()
        {
            TabelaIzvodjaci.Rows.Clear();
            foreach(var i in izvodjacViews)
            {
                TabelaIzvodjaci.Rows.Add(i.Id, i.Ime, i.tipIzvodajaca);
            }
        }

        private void PopuniTabeluPosetioci()
        {
            TabelaPosetioci.Rows.Clear();
            foreach (var p in posetilacViews)
            {
                TabelaPosetioci.Rows.Add(p.Id, p.Ime, p.UlaznicaTip);
            }
        }

        private void cmdDodavanje_Click(object sender, EventArgs e)
        {
            FormaDogadjajDodaj = new FormaDogadjajDodaj(this, null);
            this.Hide();
            DialogResult dr = FormaDogadjajDodaj.ShowDialog();
            this.Show();

            if (dr == DialogResult.OK)
            {
                dogadjajViews.Add(FormaDogadjajDodaj.novDogadjaj);
                MessageBox.Show("Uspesno dodat dogadjaj!");
                PopuniTabeluDogadjaj();
            }
            else if(dr == DialogResult.Cancel)
            {

            }
            else if(dr == DialogResult.No)
            {
                MessageBox.Show("Greska pri dodavanju", "Greksa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void cmdUcitavanjeDogadjaja_Click(object sender, EventArgs e)
        {

        }

        private void FormaDogadjaji_Load(object sender, EventArgs e)
        {

        }

        private void cmd_Nazad_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (TabelaDogadjaj.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite dogadjaj koju zelite da obrisete!");
                return;
            }
            int selectedRowIndex = TabelaDogadjaj.SelectedRows[0].Index;
            object idObj = TabelaDogadjaj.Rows[selectedRowIndex].Cells["ID"].Value;

            if (idObj == null || !int.TryParse(idObj.ToString(), out int dogadjajID))
            {
                MessageBox.Show("Greška prilikom čitanja ID-ja događaja.");
                return;
            }
            DialogResult result = MessageBox.Show("Da li ste sigurni da želite da obrišete izabrani događaj?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (ISession s = DataLayer.GetSession())
                    {
                        Dogadjaj d = s.Get<Dogadjaj>(dogadjajID);
                        if (d == null)
                        {
                            MessageBox.Show("Događaj ne postoji u bazi.");
                            return;
                        }

                        s.Delete(d);
                        s.Flush();
                    }

                    MessageBox.Show("Događaj uspešno obrisan.");

                    // Osvetži tabelu
                    cmdUcitavanjeDogadjaja_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška prilikom brisanja: " + ex.Message);
                }
            }

        }
        private void cmdIzmeni_Click(object sender, EventArgs e)
        {
            if (TabelaDogadjaj.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite događaj za izmenu.");
                return;
            }

            int dogadjajId;
            if (!int.TryParse(TabelaDogadjaj.SelectedRows[0].Cells["ID"].Value.ToString(), out dogadjajId))
            {
                MessageBox.Show("Greška pri čitanju ID-a događaja.");
                return;
            }

            using (ISession s = DataLayer.GetSession())
            {
                Dogadjaj d = s.Get<Dogadjaj>(dogadjajId);

                if (d != null)
                {
                    FormaDogadjajIzmeni forma = new FormaDogadjajIzmeni(this, d);
                    this.Hide();
                    forma.ShowDialog();
                    this.Show();
                    cmdUcitavanjeDogadjaja_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Greška: Događaj nije pronađen.");
                }
            }
        }
        private void btnIzvodjac_Click_1(object sender, EventArgs e)
        {
            if (selektovanDogadjaj == -1)
            {
                MessageBox.Show("Izaberite dogadjaj za koga zelite da dodate posetioca!");
                return;
            }

            int Id = (int)TabelaDogadjaj.Rows[selektovanDogadjaj].Cells["ID"].Value;
            DogadjajView dv = dogadjajViews.Where(d => d.Id == Id).FirstOrDefault();
            if (dv == null)
            {
                MessageBox.Show("Greska sa dogadjajem!");
                return;
            }

            DogadjajBasic db = new DogadjajBasic(dv.Id, dv.Naziv, dv.Tip, dv.Opis, dv.DatumPocetka, dv.DatumPocetka, null, null);
            FormaDodajIzvodjacaNaDogadjaj forma = new FormaDodajIzvodjacaNaDogadjaj(this, db);

            DialogResult dr = forma.ShowDialog();

            if (dr == DialogResult.OK)
            {
                MessageBox.Show("Uspesno dodat izvodjac");
            }
            else if (dr == DialogResult.No)
            {
                MessageBox.Show("Greska pri dodavanju izvodjaca", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DodavanjePosetioca_Click(object sender, EventArgs e)
        {
            if (selektovanDogadjaj == -1)
            {
                MessageBox.Show("Izaberite dogadjaj za koga zelite da dodate posetioca!");
                return;
            }

            int Id = (int)TabelaDogadjaj.Rows[selektovanDogadjaj].Cells["ID"].Value; 
            DogadjajView dv = dogadjajViews.Where(d => d.Id ==  Id).FirstOrDefault();
            if (dv == null)
            {
                MessageBox.Show("Greska sa dogadjajem!");
                return;
            }

            FormaPosetilacDodaj formaPosetilacDodaj = new FormaPosetilacDodaj(this, dv);
            DialogResult dr = formaPosetilacDodaj.ShowDialog();

            if (dr == DialogResult.OK)
            {
                MessageBox.Show("Uspesno dodat posetilac!");
            }
            else
            {
                MessageBox.Show("Greska!");
            }
            
        }

        private void TabelaDogadjaj_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < TabelaDogadjaj.Rows.Count)
            {
                selektovanDogadjaj = e.RowIndex;
                int Id = (int)TabelaDogadjaj.Rows[selektovanDogadjaj].Cells["ID"].Value;

                izvodjacViews = DTOManager.VratiSveIzvodjaceDogadjaja(Id);
                posetilacViews = DTOManager.VratiPosetioceDogadjaja(Id);

                PopuniTabeluIzvodjaci();
                PopuniTabeluPosetioci();

                DugmiciGrupaDogadjaj.Enabled = true;
            }
        }

        private void TabelaIzvodjaci_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TabelaPosetioci_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
