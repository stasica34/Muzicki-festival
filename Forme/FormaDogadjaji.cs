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
            //try
            //{
            //    ISession s = DataLayer.GetSession();
            //    Entiteti.Dogadjaj d = new Entiteti.Dogadjaj();
            //    //postavljaju se vrednost propetijao
            //    //prva iteracija
            //    //d.NAZIV = "Dj takmicenja";
            //    //d.TIP = "Radionica";
            //    //format - godina, mesec, dan, sat, minut, sekunde
            //    //d.DATUM_VREME_POCETKA = new DateTime(2025, 8, 5, 18, 30, 0);
            //    //d.DATUM_VREME_KRAJA = new DateTime(2025, 8, 15, 11, 0, 0);
            //    //d.GPS_KOORDINATNE = "44.8176N,20.4569EF
            //    //d.LOKACIJA_NAZIV = "Arena Beograd";
            //    //alternativa kao kroz save:
            //    //kada hocemo nesto da dodamo/ ili izmenimo ono sto nemamo, samo pozivamo to sto hocemo da menjamo
            //    //drugi iteracija
            //    d = s.Load<Entiteti.Dogadjaj>(22);
            //    d.OPIS = "Ritmovi Ritmovi";
            //    s.Save(d);
            //    //s.SaveOrUpdate() // ukoliko postoji pk!=0 onda se radi azuriranje tog objekta (npr id !=0)
            //    //ali save ili saveorupdate na istu foru funkcionisu, nije bitno sta koristimo
            //    //kada pozivamo flush, da sve modifikacije koje su se desile u sesije, da se prosledi u bazi
            //    //da se vidi da li su sve modifikacije u bazi okej, bolje koristiti flush
            //    //id kljucevi imaju podrazumevanu vrednost 0, i to je znak da se radi o novom objektu
            //    s.Flush();
            //    //prva iteracija
            //    //MessageBox.Show(
            //    //          $"Novi dogadjaj uspešno kreiran!\n\n" +
            //    //          $"Naziv: {d.NAZIV}\n" +
            //    //          $"Tip: {d.TIP}\n" +
            //    //          $"Datum početka: {d.DATUM_VREME_POCETKA}\n" +
            //    //          $"Datum kraja: {d.DATUM_VREME_KRAJA}\n" +
            //    //          $"GPS: {d.GPS_KOORDINATNE}\n" +
            //    //          $"Lokacija: {d.LOKACIJA_NAZIV}",
            //    //          "Uspeh",
            //    //          MessageBoxButtons.OK,
            //    //          MessageBoxIcon.Information
            //    //      );
            //    //druga iteracija
            //    MessageBox.Show(
            //        $"Uspesno je izvresno dodavanje podataka.\n\n" +
            //        $"Opis: {d.OPIS}\n",
            //        "Uspeh",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Information
            //        );

            //    s.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void cmdUcitavanjeDogadjaja_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    ISession s = DataLayer.GetSession();

            //    //nhibarnate je na osnovu mapiranja napisao upit, mi nismo morlai da pisemo upit upise, i sve se prosledjuje kao parametar
            //    //potrebno uocavati podatke koji su zaista potrebni
            //    //ovde radi kada trazimo po odredjenom id-u
            //    //Muzicki_festival.Entiteti.Dogadjaj d = s.Load<Muzicki_festival.Entiteti.Dogadjaj>(21);
            //    //MessageBox.Show(d.NAZIV);
            //    //ovo je nacin da se ucitaju svi dogadjaji
            //    using (var session = DataLayer.GetSession())
            //    {
            //        using (var transaction = session.BeginTransaction())
            //        {
            //            var listaDogadjaja = session.QueryOver<Dogadjaj>().List();

            //            if (listaDogadjaja.Count == 0)
            //            {
            //                MessageBox.Show("Nema dogadjaja u bazi.");
            //                return;
            //            }

            //            // Spajanje svih događaja u jedan string
            //            StringBuilder sb = new StringBuilder();
            //            foreach (var d in listaDogadjaja)
            //            {
            //                sb.AppendLine($"ID: {d.ID}");
            //                sb.AppendLine($"Naziv: {d.NAZIV}");
            //                sb.AppendLine($"Tip: {d.TIP}");
            //                sb.AppendLine($"Opis: {d.OPIS}");
            //                sb.AppendLine($"Datum početka: {d.DATUM_VREME_POCETKA}");
            //                sb.AppendLine($"Datum kraja: {d.DATUM_VREME_KRAJA}");
            //                sb.AppendLine($"GPS: {d.Lokacija.Lokacija_ID.GPS_KOORDINATE}");
            //                sb.AppendLine($"Lokacija Naziv: {d.Lokacija.Lokacija_ID.NAZIV}");
            //                sb.AppendLine(new string('-', 40)); // separator
            //            }

            //            MessageBox.Show(sb.ToString(), $"Ukupno dogadjaja: {listaDogadjaja.Count}");

            //            transaction.Commit();
            //        }
            //    }
            //    s.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);

            //}
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
                        dt.Rows.Add(d.ID, d.NAZIV, d.TIP, d.OPIS, d.DATUM_VREME_POCETKA, d.DATUM_VREME_KRAJA, d.Lokacija.Lokacija_ID.GPS_KOORDINATE, d.Lokacija.Lokacija_ID.NAZIV);
                    }
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["ID"].Visible = false;


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
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.BorderStyle = BorderStyle.None;
                dataGridView1.BackgroundColor = Color.WhiteSmoke;
                dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dataGridView1.GridColor = Color.LightGray;

                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

                dataGridView1.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
                dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
                dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 90, 150);
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridView1.EnableHeadersVisualStyles = false;


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

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite događaj za koji želite da kupite ulaznicu.");
                return;
            }
            int dogadjajId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

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
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite dogadjaj koju zelite da obrisete!");
                return;
            }
            int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
            object idObj = dataGridView1.Rows[selectedRowIndex].Cells["ID"].Value;

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
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite događaj za izmenu.");
                return;
            }

            int dogadjajId;
            if (!int.TryParse(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString(), out dogadjajId))
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
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite događaj za koji želite da dodate izvodjaca.");
                return;
            }
            int dogadjajId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

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
