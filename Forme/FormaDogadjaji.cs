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
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.Dogadjaj d = new Entiteti.Dogadjaj();
                //postavljaju se vrednost propetijao
                //prva iteracija
                //d.NAZIV = "Dj takmicenja";
                //d.TIP = "Radionica";
                //format - godina, mesec, dan, sat, minut, sekunde
                //d.DATUM_VREME_POCETKA = new DateTime(2025, 8, 5, 18, 30, 0);
                //d.DATUM_VREME_KRAJA = new DateTime(2025, 8, 15, 11, 0, 0);
                //d.GPS_KOORDINATNE = "44.8176N,20.4569E";
                //d.LOKACIJA_NAZIV = "Arena Beograd";
                //alternativa kao kroz save:
                //kada hocemo nesto da dodamo/ ili izmenimo ono sto nemamo, samo pozivamo to sto hocemo da menjamo
                //drugi iteracija
                d = s.Load<Entiteti.Dogadjaj>(22);
                d.OPIS = "Borba ritmova pod svetlima bine";
                s.Save(d);
                //s.SaveOrUpdate() // ukoliko postoji pk!=0 onda se radi azuriranje tog objekta (npr id !=0)
                //ali save ili saveorupdate na istu foru funkcionisu, nije bitno sta koristimo
                //kada pozivamo flush, da sve modifikacije koje su se desile u sesije, da se prosledi u bazi
                //da se vidi da li su sve modifikacije u bazi okej, bolje koristiti flush
                //id kljucevi imaju podrazumevanu vrednost 0, i to je znak da se radi o novom objektu
                s.Flush();
                //prva iteracija
                //MessageBox.Show(
                //          $"Novi dogadjaj uspešno kreiran!\n\n" +
                //          $"Naziv: {d.NAZIV}\n" +
                //          $"Tip: {d.TIP}\n" +
                //          $"Datum početka: {d.DATUM_VREME_POCETKA}\n" +
                //          $"Datum kraja: {d.DATUM_VREME_KRAJA}\n" +
                //          $"GPS: {d.GPS_KOORDINATNE}\n" +
                //          $"Lokacija: {d.LOKACIJA_NAZIV}",
                //          "Uspeh",
                //          MessageBoxButtons.OK,
                //          MessageBoxIcon.Information
                //      );
                //druga iteracija
                MessageBox.Show(
                    $"Uspesno je izvresno dodavanje podataka.\n\n" +
                    $"Opis: {d.OPIS}\n",
                    "Uspeh",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUcitavanjeDogadjaja_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //nhibarnate je na osnovu mapiranja napisao upit, mi nismo morlai da pisemo upit upise, i sve se prosledjuje kao parametar
                //potrebno uocavati podatke koji su zaista potrebni
                //ovde radi kada trazimo po odredjenom id-u
                //Muzicki_festival.Entiteti.Dogadjaj d = s.Load<Muzicki_festival.Entiteti.Dogadjaj>(21);
                //MessageBox.Show(d.NAZIV);
                //ovo je nacin da se ucitaju svi dogadjaji
                using (var session = DataLayer.GetSession())
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        var listaDogadjaja = session.QueryOver<Dogadjaj>().List();

                        if (listaDogadjaja.Count == 0)
                        {
                            MessageBox.Show("Nema dogadjaja u bazi.");
                            return;
                        }

                        // Spajanje svih događaja u jedan string
                        StringBuilder sb = new StringBuilder();
                        foreach (var d in listaDogadjaja)
                        {
                            sb.AppendLine($"ID: {d.ID}");
                            sb.AppendLine($"Naziv: {d.NAZIV}");
                            sb.AppendLine($"Tip: {d.TIP}");
                            sb.AppendLine($"Opis: {d.OPIS}");
                            sb.AppendLine($"Datum početka: {d.DATUM_VREME_POCETKA}");
                            sb.AppendLine($"Datum kraja: {d.DATUM_VREME_KRAJA}");
                            sb.AppendLine($"GPS: {d.GPS_KOORDINATNE}");
                            sb.AppendLine($"Lokacija: {d.LOKACIJA_NAZIV}");
                            sb.AppendLine(new string('-', 40)); // separator
                        }

                        MessageBox.Show(sb.ToString(), $"Ukupno dogadjaja: {listaDogadjaja.Count}");

                        transaction.Commit();
                    }
                }
                s.Close();
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

        private void cmd_Nazad_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }
    }
}
