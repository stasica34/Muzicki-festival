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

namespace Muzicki_festival.Forme
{
    public partial class FormaUlaznica : Form
    {
        private Form parentForm;
        public FormaUlaznica(Form caller)
        {
            InitializeComponent();
            parentForm = caller;
        }

        private void FormaUlaznica_Load(object sender, EventArgs e)
        {
            try
            {
                using (var session = DataLayer.GetSession())
                {
                    MessageBox.Show("Forma uspešno otvorena!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void cmd_Ucitavanje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                using (var session = DataLayer.GetSession())
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        var listaUlaznica = session.QueryOver<Ulaznica>().List();
                        if (listaUlaznica.Count == 0)
                        {
                            MessageBox.Show("Nema ulaznica organizatora u bazi.");
                            return;
                        }
                        StringBuilder sb = new StringBuilder();
                        foreach (var ao in listaUlaznica)
                        {
                            sb.AppendLine($"ID ulaznice: {ao.ID_ULAZNICE}");
                            sb.AppendLine($"DATUM KUPOVINE: {ao.DATUM_KUPOVINE}");
                            sb.AppendLine($"OSNOVNA_CENA: {ao.OSNOVNA_CENA}");
                            sb.AppendLine($"KUPAC_ID: {ao.KUPAC_ID.IME} | {ao.KUPAC_ID.PREZIME} | {ao.KUPAC_ID.EMAIL}");
                            sb.AppendLine($"NAČIN PLAĆANJA: {ao.NACIN_PLACANJA}");
                            sb.AppendLine($"NAZIV: {ao.NAZIV}");
                            sb.AppendLine(new string('-', 40));
                        }
                        MessageBox.Show(sb.ToString(), $"Lista agencija organizatora: {listaUlaznica.Count}");
                        transaction.Commit();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            try
            {
                ISession s = DataLayer.GetSession();
                Posetilac p = new Posetilac
                {
                    IME = "Dimitrije",
                    PREZIME = "Jovic",
                    EMAIL = "dimitrije.jovic@example.com"
                };

                Ulaznica u = new Ulaznica
                {
                    DATUM_KUPOVINE = DateTime.Now,
                    OSNOVNA_CENA = 3400,
                    KUPAC_ID = p, // veza ka novom posetiocu
                    NACIN_PLACANJA = "Gotovina",
                    NAZIV = "Jednodnevna"
                };
                s.Save(p);
                //dodavanje preko ulaznice
                u.KUPAC_ID = p;
                s.Save(u);
                p.Ulaznice.Add(u);
                s.Save(u); //ovo je cisto po potrebi
                s.Flush(); 
                MessageBox.Show("Uspešno dodat posetilac i njegova ulaznica.");

                s.Close();
            }
            catch (
            Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
