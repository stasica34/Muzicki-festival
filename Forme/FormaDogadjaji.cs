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
namespace Muzicki_festival.Forme
{
    public partial class FormaDogadjaji : Form
    {
        private Form parentForm;

        public FormaDogadjaji(Form caller)
        {
            InitializeComponent();
            parentForm = caller;

        }

        private void cmdDodavanje_Click(object sender, EventArgs e)
        {
            FormaDogadjajDodaj formaDodaj = new FormaDogadjajDodaj(this, null);
            this.Hide();
            formaDodaj.ShowDialog();
            this.Show();
            cmdUcitavanjeDogadjaja_Click(null, null);
        }

        private void cmdUcitavanjeDogadjaja_Click(object sender, EventArgs e)
        {

            try
            {
                ISession s = DataLayer.GetSession();
                using (var session = DataLayer.GetSession())
                {
                    var listadogajdaja = session.QueryOver<Dogadjaj>().List();
                    if (listadogajdaja.Count == 0)
                    {
                        MessageBox.Show("Nema agencija organizatora u bazi.");
                        return;
                    }

                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID");
                    dt.Columns.Add("NAZIV");
                    dt.Columns.Add("TIP");
                    dt.Columns.Add("OPIS");
                    dt.Columns.Add("DATUM I VREME POCETKA");
                    dt.Columns.Add("DATUM I VREME KRAJA");
                    dt.Columns.Add("GPS_KOORDINATE");
                    dt.Columns.Add("LOKACIJA-NAZIV");

                    foreach (var d in listadogajdaja)
                    {
                        dt.Rows.Add(d.ID, d.NAZIV, d.TIP, d.OPIS, d.DATUM_VREME_POCETKA, d.DATUM_VREME_KRAJA, d.Lokacija.GPS_KOORDINATE, d.Lokacija.NAZIV);
                    }
                    TabelaDogadjaj.DataSource = dt;
                    TabelaDogadjaj.Columns["ID"].Visible = false;


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormaDogadjaji_Load(object sender, EventArgs e)
        {
            try
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


            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void cmd_Nazad_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }

        private void cmdDodavanje2_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    ISession s = DataLayer.GetSession();
            //    Lokacija lokacija = s.QueryOver<Lokacija>()
            //    .Where(x => x.Lokacija_ID.NAZIV == "Kalemegdan")
            //    .And(x => x.Lokacija_ID.GPS_KOORDINATE == "43.340,21.915")
            //    .SingleOrDefault();
            //    if (lokacija == null)
            //    {
            //        MessageBox.Show("Greška: Nema zadate lokacije u bazi. Dodaj lokaciju pre unosa događaja.");
            //        return;
            //    }
            //    Dogadjaj d = new Dogadjaj()
            //    {
            //        NAZIV = "Nesto novo pt2",
            //        TIP = "Radionica",
            //        OPIS = "Proba nova",
            //        DATUM_VREME_POCETKA = DateTime.Now,
            //        DATUM_VREME_KRAJA = new DateTime(2025, 10, 5),
            //        Lokacija = lokacija
            //    };
            //    s.Save(d);
            //    s.Flush();
            //    MessageBox.Show("Uspesno je dodato");
            //    Posetilac posetilac = s.Get<Posetilac>(5);
            //    if (posetilac == null)
            //    {
            //        MessageBox.Show("Posetilac sa ID = 5 ne postoji.");
            //        return;
            //    }
            //    Ulaznica u = new Ulaznica()
            //    {
            //        DATUM_KUPOVINE = DateTime.Now,
            //        OSNOVNA_CENA = 3500,
            //        KUPAC_ID = posetilac,
            //        NACIN_PLACANJA = "Kartica",
            //        NAZIV = "VIP"
            //    };
            //    s.Save(u);
            //    d.Ulaznica.Add(u);
            //    s.Flush();
            //    MessageBox.Show("Uspesno je dodato");
            //    s.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            if (TabelaDogadjaj.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite događaj za koji želite da kupite ulaznicu.");
                return;
            }
            int dogadjajId = Convert.ToInt32(TabelaDogadjaj.SelectedRows[0].Cells["ID"].Value);

            using (ISession s = DataLayer.GetSession())
            {
                Dogadjaj d = s.Get<Dogadjaj>(dogadjajId);
                if (d == null)
                {
                    MessageBox.Show("Greška: događaj nije pronađen.");
                    return;
                }

                FormaUlaznica forma = new FormaUlaznica(this, d);
                this.Hide();
                forma.ShowDialog();
                this.Show();
            }
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
            if (TabelaDogadjaj.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite događaj za koji želite da dodate izvodjaca.");
                return;
            }
            int dogadjajId = Convert.ToInt32(TabelaDogadjaj.SelectedRows[0].Cells["ID"].Value);

            using (ISession s = DataLayer.GetSession())
            {
                Dogadjaj d = s.Get<Dogadjaj>(dogadjajId);
                if (d == null)
                {
                    MessageBox.Show("Greška: događaj nije pronađen.");
                    return;
                }

                FormaIzvodjacDogadjaj formaIzvodjacdogadaj = new FormaIzvodjacDogadjaj(this, d);
                this.Hide();
                formaIzvodjacdogadaj.ShowDialog();
                this.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
