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

namespace Muzicki_festival.Forme
{
    public partial class FormaUlaznica : Form
    {
        private Form parentForm;
        private Dogadjaj dogadjaj;
        public FormaUlaznica(Form caller, Dogadjaj dogadjaj)
        {
            InitializeComponent();
            parentForm = caller;
            this.dogadjaj = dogadjaj;
        }

        private void FormaUlaznica_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = $"Ulaznice za događaj: {dogadjaj.NAZIV}";
                UcitajUlaznice();
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
                MessageBox.Show("Greška prilikom učitavanja forme: " + ex.Message);
            }
        }

        private void cmd_Nazad_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }

        private void cmd_Dodavanje_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    ISession s = DataLayer.GetSession();
            //    //ubacujemo i novog posetioca i novu ulaznicu za tog posetioca
            //    Posetilac p = new Posetilac
            //    {
            //        IME = "Stasa",
            //        PREZIME = "Kostic",
            //        EMAIL = "stasa.kostic@example.com"
            //    };
            //    s.Save(p);
            //    s.Flush();
            //    Ulaznica u = new Ulaznica
            //    {
            //        DATUM_KUPOVINE = DateTime.Now,
            //        OSNOVNA_CENA = 2000,
            //        KUPAC_ID = p, // veza ka novom posetiocu
            //        NACIN_PLACANJA = "Kartica",
            //        NAZIV = "Jednodnevna"
            //    };

            //    //ove varijente indu kada nije ukljuceno cascade all i inverse
            //    //u.KUPAC_ID = p; // radi i bez ovog
            //    // s.Save(u);
            //    //s.Flush(); 
            //    dodavanje preko posetioca
            //    p.Ulaznice.Add(u); // dodajemo ulaznicu u kolekciju posetioca
            //    s.Save(u); // cuvamo posetioca, sto ce automatski sacuvati i ulaznicu zbog kaskadnog cuvanja
            //    s.Flush(); // forsiramo sinhronizaciju sa bazom, preporuka da se koristi
            //    MessageBox.Show("Uspešno dodat posetilac i njegova ulaznica.");

            //    s.Close();
            //}
            //catch (
            //Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //drugi nacin:
            //try
            //{
            //    ISession s = DataLayer.GetSession();
            //    Posetilac p = new Posetilac
            //    {
            //        IME = "Dimitrije",
            //        PREZIME = "Jovic",
            //        EMAIL = "dimitrije.jovic@example.com"
            //    };

            //    Ulaznica u = new Ulaznica
            //    {
            //        DATUM_KUPOVINE = DateTime.Now,
            //        OSNOVNA_CENA = 3400,
            //        KUPAC_ID = p, // veza ka novom posetiocu
            //        NACIN_PLACANJA = "Gotovina",
            //        NAZIV = "Jednodnevna"
            //    };
            //    s.Save(p);
            //    //dodavanje preko ulaznice
            //    u.KUPAC_ID = p;
            //    s.Save(u);
            //    p.Ulaznice.Add(u);
            //    s.Save(u); //ovo je cisto po potrebi
            //    s.Flush(); 
            //    MessageBox.Show("Uspešno dodat posetilac i njegova ulaznica.");

            //    s.Close();
            //}
            //catch (
            //Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
           // FormaUlazniceDodaj formaDodaj = new FormaUlazniceDodaj(this, dogadjaj);
            //this.Hide();
            //formaDodaj.ShowDialog();
            //this.Show();
             //UcitajUlaznice();

        }
        private void UcitajUlaznice()
        {

        }

        private void cmdIzmeni_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite ulaznicu za izmenu.");
                return;
            }

            int ulaznicaId;
            if (!int.TryParse(dataGridView1.SelectedRows[0].Cells["ID_ULAZNICE"].Value.ToString(), out ulaznicaId))
            {
                MessageBox.Show("Greška pri čitanju ID-a ulaznice.");
                return;
            }

            using (ISession s = DataLayer.GetSession())
            {
                Ulaznica u = s.Get<Ulaznica>(ulaznicaId);

                if (u != null)
                {
                    FormaUlazniceIzmeni forma = new FormaUlazniceIzmeni(this, u);
                    this.Hide();
                    forma.ShowDialog();
                    this.Show();
                    UcitajUlaznice();
                }
                else
                {
                    MessageBox.Show("Greška: Ulaznica nije pronađena.");
                }
            }
        }
    }
}
