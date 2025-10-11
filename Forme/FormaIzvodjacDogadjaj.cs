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
using Muzicki_festival.FormeDodatne;
using NHibernate.Linq;
namespace Muzicki_festival.Forme
{
    public partial class FormaIzvodjacDogadjaj : Form
    {
        private Form parentForm;
        private Dogadjaj dogadjajizvodjac;
        public FormaIzvodjacDogadjaj(Form caller,Dogadjaj dogadjaj)
        {
            InitializeComponent();
            parentForm = caller;
            this.dogadjajizvodjac = dogadjaj;
        }

        private void FormaIzvodjac_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = $"Izvodjaci za događaj: {dogadjajizvodjac.NAZIV}";
                UcitajIzvodjace();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void cmdDodavanje_Click(object sender, EventArgs e)
        {
            FormaMenadzerskaAgencijaDodavanje formaDodaj = new FormaMenadzerskaAgencijaDodavanje(this, null);
            this.Hide();
            formaDodaj.ShowDialog();
            this.Show();
            UcitajIzvodjace();
            //ovakva pristup se koristi kada kod n:m veze nemamo nijedan atribut
            //try
            //{
            //    ISession s = DataLayer.GetSession();

            //    Lokacija lokacija = s.QueryOver<Lokacija>()
            //     .Where(x => x.Lokacija_ID.NAZIV == "Trg Republike")
            //     .And(x => x.Lokacija_ID.GPS_KOORDINATE == "43.335,21.910")
            //     .SingleOrDefault();
            //    if (lokacija == null)
            //    {
            //        MessageBox.Show("Greška: Nema zadate lokacije u bazi. Dodaj lokaciju pre unosa događaja.");
            //        return;
            //    }
            //    Dogadjaj d = new Dogadjaj()
            //    {
            //        NAZIV = "Nesto novo",
            //        TIP = "Radionica",
            //        OPIS = "Fenomene u muzickom takmicenju",
            //        DATUM_VREME_POCETKA = DateTime.Now,
            //        DATUM_VREME_KRAJA = new DateTime(2025, 10, 5),
            //        Lokacija = lokacija
            //    };
            //    s.Save(d);
            //    s.Flush();
            //    MessageBox.Show("Uspesno je dodato");
            //    MenadzerskaAgencija agencija = s.Get<MenadzerskaAgencija>(1);
            //    if (agencija == null)
            //    {
            //        MessageBox.Show("Menadžerska agencija sa ID = 1 ne postoji.");
            //        return;
            //    }
            //    var postoji = s.QueryOver<Izvodjac>()
            //         .Where(x => x.IME == "Ed" || x.EMAIL == "ed@example.com")
            //         .SingleOrDefault();

            //    if (postoji != null)
            //    {
            //        MessageBox.Show("Izvođač sa istim imenom ili email-om već postoji.");
            //        return;
            //    }
            //    Entiteti.Izvodjac i = new Entiteti.Izvodjac()
            //    {
            //        IME = "Ed",
            //        DRZAVA_POREKLA = "Amerika",
            //        EMAIL = "ed@example.com",
            //        KONTAKT_OSOBA = "Micheal Kelly",
            //        TELEFON = "+384659012345",
            //        MenadzerskaAgencija = agencija
            //    };
            //    s.Save(i);
            //    //veza n/m
            //    d.Izvodjaci.Add(i);
            //    s.Flush();
            //    MessageBox.Show("Uspesno je dodato");
            //    s.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void cmdIzmeni_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite izvodajca za izmenu.");
                return;
            }

            int izvdoajcId;
            if (!int.TryParse(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString(), out izvdoajcId))
            {
                MessageBox.Show("Greška pri čitanju ID-a događaja.");
                return;
            }

            using (ISession s = DataLayer.GetSession())
            {
                Izvodjac i = s.Get<Izvodjac>(izvdoajcId);

                if (i != null)
                {
                    FormaIzvodjacIzmeni forma = new FormaIzvodjacIzmeni(this, i);
                    this.Hide();
                    forma.ShowDialog();
                    this.Show();
                    UcitajIzvodjace();
                }
                else
                {
                    MessageBox.Show("Greška: Događaj nije pronađen.");
                }
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite izvodjaca kog zelite da obrisete!");
                return;
            }
            int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
            object idObj = dataGridView1.Rows[selectedRowIndex].Cells["ID"].Value;

            if (idObj == null || !int.TryParse(idObj.ToString(), out int izvodjacId))
            {
                MessageBox.Show("Greška prilikom čitanja ID-ja izvodjaca.");
                return;
            }
            DialogResult result = MessageBox.Show("Da li ste sigurni da želite da obrišete izabrog izvodjaca?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (ISession s = DataLayer.GetSession())
                    {
                        Izvodjac i = s.Get<Izvodjac>(izvodjacId);
                        if (i == null)
                        {
                            MessageBox.Show("Izvodjac ne postoji u bazi.");
                            return;
                        }

                        s.Delete(i);
                        s.Flush();
                    }

                    MessageBox.Show("Izvodjac uspešno obrisan.");
                    UcitajIzvodjace();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška prilikom brisanja: " + ex.Message);
                }
            }
        }
        private void UcitajIzvodjace()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                using (var session = DataLayer.GetSession())
                {
                    var listaIzvodjaca = session.Query<Izvodjac>()
                        .Where(x => x.Dogadjaji.Any(d => d.ID == dogadjajizvodjac.ID))
                        .ToList();

                    if (listaIzvodjaca.Count == 0)
                    {
                        MessageBox.Show("Trenutno nema izvodjaca za ovaj događaj.");
                        FormaIzvodjacDodaj formaDogadjaji = new FormaIzvodjacDodaj(parentForm, dogadjajizvodjac);
                        this.Hide();
                        formaDogadjaji.ShowDialog();
                        this.Close();
                    }
                    //StringBuilder sb = new StringBuilder();
                    //foreach (var a in listaIzvodjaca)
                    //{
                    //    sb.AppendLine($"ID: {a.ID}");
                    //    sb.AppendLine($"IME: {a.IME}");
                    //    sb.AppendLine($"DRZAVA_POREKLA: {a.DRZAVA_POREKLA}");
                    //    sb.AppendLine($"EMAIL: {a.EMAIL}");
                    //    sb.AppendLine($"MENADZERSKA_AGENCIJA_ID: {a.MenadzerskaAgencija.ID}");
                    //    sb.AppendLine($"KONTAKT_OSOBA: {a.KONTAKT_OSOBA}");
                    //    sb.AppendLine($"TELEFON: {a.TELEFON}");
                    //    sb.AppendLine(new string('-', 40));
                    //}
                    //MessageBox.Show(sb.ToString(), $"Lista izvodjaca: {listaIzvodjaca.Count}");
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ID");
                    dt.Columns.Add("IME");
                    dt.Columns.Add("DRZAVA_POREKLA");
                    dt.Columns.Add("EMAIL");
                    dt.Columns.Add("MENADZERSKA_AGENCIJA_ID");
                    dt.Columns.Add("KONTAKT_OSOBA");
                    dt.Columns.Add("TELEFON");

                    foreach (var d in listaIzvodjaca)
                    {
                        dt.Rows.Add(d.ID, d.IME, d.DRZAVA_POREKLA, d.EMAIL, d.MenadzerskaAgencija.NAZIV, d.KONTAKT_OSOBA, d.Telefoni);
                    }
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["ID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
