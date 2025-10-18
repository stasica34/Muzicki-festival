using Muzicki_festival.DTOs;
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
using System.Text.RegularExpressions;

namespace Muzicki_festival.FormeDodatne
{
    public partial class FormaUlaznicePregled : Form
    {
        private int selektovanRedVisednevnaDani = -1;
        private int selektovanRedPogodnosti = -1;
        private int selektovanaUlaznicaId = -1;

        private IList<UlaznicaBasic> ulaznice;
        private Form parentform;

        public FormaUlaznicePregled(Form parentform)
        {
            InitializeComponent();

            InitTabeluDani();
            InitTabeluPogodnosti();
            InitTabeluUlaznice();

            ulaznice = DTOManager.VratiSveUlaznice();
            PopuniTabeluUlaznice();

            cmbPlacanje.Items.AddRange(new string[]
            {
                "Gotovina",
                "Kartica",
                "Online"
            });
            this.parentform = parentform;
        }

        private void InitTabeluDani()
        {
            TabelaDaniVisednevna.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            TabelaDaniVisednevna.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TabelaDaniVisednevna.ReadOnly = true;
            TabelaDaniVisednevna.AllowUserToAddRows = false;
            TabelaDaniVisednevna.RowHeadersVisible = false;
            TabelaDaniVisednevna.BorderStyle = BorderStyle.None;
            TabelaDaniVisednevna.BackgroundColor = Color.WhiteSmoke;
            TabelaDaniVisednevna.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            TabelaDaniVisednevna.GridColor = Color.LightGray;

            TabelaDaniVisednevna.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

            TabelaDaniVisednevna.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            TabelaDaniVisednevna.DefaultCellStyle.SelectionForeColor = Color.White;
            TabelaDaniVisednevna.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            TabelaDaniVisednevna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            TabelaDaniVisednevna.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            TabelaDaniVisednevna.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 90, 150);
            TabelaDaniVisednevna.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            TabelaDaniVisednevna.EnableHeadersVisualStyles = false;

            TabelaDaniVisednevna.Columns.Add("DAN", "DAN");
        }

        private void InitTabeluUlaznice()
        {
            TabelaUlaznice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            TabelaUlaznice.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TabelaUlaznice.ReadOnly = true;
            TabelaUlaznice.AllowUserToAddRows = false;
            TabelaUlaznice.RowHeadersVisible = false;
            TabelaUlaznice.BorderStyle = BorderStyle.None;
            TabelaUlaznice.BackgroundColor = Color.WhiteSmoke;
            TabelaUlaznice.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            TabelaUlaznice.GridColor = Color.LightGray;

            TabelaUlaznice.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

            TabelaUlaznice.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            TabelaUlaznice.DefaultCellStyle.SelectionForeColor = Color.White;
            TabelaUlaznice.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            TabelaUlaznice.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            TabelaUlaznice.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            TabelaUlaznice.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 90, 150);
            TabelaUlaznice.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            TabelaUlaznice.EnableHeadersVisualStyles = false;

            TabelaUlaznice.Columns.Add("ID", "ID");
            TabelaUlaznice.Columns["ID"].Visible = false;
            TabelaUlaznice.Columns.Add("DATUM_KUPOVINE", "DATUM_KUPOVINE");
            TabelaUlaznice.Columns.Add("CENA", "CENA");
            TabelaUlaznice.Columns.Add("NACIN_PLACANJA", "NACIN_PLACANJA");
            TabelaUlaznice.Columns.Add("TIP", "TIP");
        }

        private void InitTabeluPogodnosti()
        {
            TabelaPogodnosti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            TabelaPogodnosti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TabelaPogodnosti.ReadOnly = true;
            TabelaPogodnosti.AllowUserToAddRows = false;
            TabelaPogodnosti.RowHeadersVisible = false;
            TabelaPogodnosti.BorderStyle = BorderStyle.None;
            TabelaPogodnosti.BackgroundColor = Color.WhiteSmoke;
            TabelaPogodnosti.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            TabelaPogodnosti.GridColor = Color.LightGray;

            TabelaPogodnosti.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

            TabelaPogodnosti.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            TabelaPogodnosti.DefaultCellStyle.SelectionForeColor = Color.White;
            TabelaPogodnosti.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            TabelaPogodnosti.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            TabelaPogodnosti.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            TabelaPogodnosti.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 90, 150);
            TabelaPogodnosti.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            TabelaPogodnosti.EnableHeadersVisualStyles = false;

            TabelaPogodnosti.Columns.Add("POGODNOST", "POGODNOST");
        }

        private void PopuniTabeluUlaznice()
        {
            TabelaUlaznice.Rows.Clear();
            foreach (var u in ulaznice)
            {
                TabelaUlaznice.Rows.Add(u.Id, u.DatumKupovine, u.OsnovnaCena, u.NacinPlacanja, u.TipUlaznice.ToString());
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TabelaDaniVisednevna_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < TabelaDaniVisednevna.Rows.Count)
            {
                selektovanRedVisednevnaDani = e.RowIndex;
            }
        }
        private void TabelaPogodnosti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < TabelaPogodnosti.Rows.Count)
            {
                selektovanRedPogodnosti = e.RowIndex;
            }
        }

        private void DugmeDodajDanVisednevna_Click(object sender, EventArgs e)
        {
            TabelaDaniVisednevna.Rows.Add(DanVisednevna.Value);
        }

        private void DugmeObrisiDanVisednevna_Click(object sender, EventArgs e)
        {
            if (selektovanRedVisednevnaDani == -1)
            {
                MessageBox.Show("Izaberite dan za brisanje!");
                return;
            }

            TabelaDaniVisednevna.Rows.RemoveAt(selektovanRedVisednevnaDani);
            TabelaDaniVisednevna.Refresh();
            selektovanRedVisednevnaDani = -1;
        }

        private void DugmeDodajPogodnost_Click(object sender, EventArgs e)
        {
            string pogodnost = txtPogodnost.Text.Trim();
            if (string.IsNullOrWhiteSpace(pogodnost))
            {
                MessageBox.Show("Unesite pogodnost u tekst polje!");
                return;
            }
            Regex regex = new Regex(@"^[A-Za-zŠšĐđČčĆćŽž ]+$");
            if (!regex.IsMatch(pogodnost))
            {
                MessageBox.Show("Naziv VIP pogodnosti sme sadržati samo slova.",
                                "Neispravan unos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            TabelaPogodnosti.Rows.Add(txtPogodnost.Text);
            txtPogodnost.Text = "";
        }

        private void DugmeObrisiPogodnost_Click(object sender, EventArgs e)
        {
            if (selektovanRedPogodnosti == -1)
            {
                MessageBox.Show("Izaberite dan za brisanje!");
                return;
            }

            TabelaPogodnosti.Rows.RemoveAt(selektovanRedPogodnosti);
            TabelaPogodnosti.Refresh();
            selektovanRedPogodnosti = -1;
        }


        private void TabelaUlaznice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < TabelaUlaznice.Rows.Count)
            {
                var row = TabelaUlaznice.Rows[e.RowIndex];
                int id = (int)row.Cells["ID"].Value;
                selektovanaUlaznicaId = id;

                Prilagodi();
            }
        }

        private void Prilagodi()
        {
            var u = ulaznice.Where(ul => ul.Id == selektovanaUlaznicaId).FirstOrDefault();

            if (u == null)
                return;

            switch (u.TipUlaznice)
            {
                case TipUlaznice.JEDNODNEVNA:
                    InputJednodnevna.Visible = true;
                    InputVisednevna.Visible = false;
                    InputVIP.Visible = false;
                    InputAkreditacija.Visible = false;

                    JednodnevnaBasic jb = u as JednodnevnaBasic;
                    DatumJednodnevna.Value = jb.DatumVazenja;

                    break;
                case TipUlaznice.VISEDNEVNA:
                    InputJednodnevna.Visible = false;
                    InputVisednevna.Visible = true;
                    InputVIP.Visible = false;
                    InputAkreditacija.Visible = false;

                    ViseDnevnaBasic vd = u as ViseDnevnaBasic;
                    TabelaDaniVisednevna.Rows.Clear();
                    foreach (var d in vd.DatumiVazenja)
                        TabelaDaniVisednevna.Rows.Add(d);

                    break;
                case TipUlaznice.VIP:
                    InputJednodnevna.Visible = false;
                    InputVisednevna.Visible = false;
                    InputVIP.Visible = true;
                    InputAkreditacija.Visible = false;

                    VIPBasic vp = u as VIPBasic;
                    TabelaPogodnosti.Rows.Clear();
                    foreach (var p in vp.Pogodnosti)
                        TabelaPogodnosti.Rows.Add(p);
                    break;
                case TipUlaznice.AKREDITACIJA:
                    InputJednodnevna.Visible = false;
                    InputVisednevna.Visible = false;
                    InputVIP.Visible = false;
                    InputAkreditacija.Visible = true;

                    AkreditacijaBasic ab = u as AkreditacijaBasic;
                    if (ab.Tip == TipAkreditacije.SPONZOR)
                        radioSponzor.Checked = true;
                    else if (ab.Tip == TipAkreditacije.PRESS)
                        radioPress.Checked = true;
                    else
                        radioParter.Checked = true;

                        break;
                default:
                    throw new Exception("Nepravilna ulaznica!");
            }
        }

        private void FormaUlaznicePregled_Load(object sender, EventArgs e)
        {

        }

        private void DugmeObrisi_Click(object sender, EventArgs e)
        {
            if (selektovanaUlaznicaId == -1)
            {
                MessageBox.Show("Izberite ulaznicu!");
                return;
            }

            if (DTOManager.ObrisiUlaznicu(selektovanaUlaznicaId))
            {
                MessageBox.Show("Ulaznica je obrisana");

                txtCena.Value = 0;
                cmbPlacanje.SelectedIndex = -1;
                TipLabela.Text = "";

                DugmeOtkaziIzmene.Enabled = false;
                DugmePotvrdiIzmene.Enabled = false;

                GrupaPodaci.Enabled = false;
                GrupaUlaznice.Enabled = true;

                ulaznice = DTOManager.VratiSveUlaznice();
                PopuniTabeluUlaznice();
                selektovanaUlaznicaId = -1;

                TabelaPogodnosti.Rows.Clear();
                TabelaDaniVisednevna.Rows.Clear();
            }
        }

        private void DugmeIzmeni_Click(object sender, EventArgs e)
        {
            if (selektovanaUlaznicaId == -1)
            {
                MessageBox.Show("Izaberite ulaznicu!");
                return;
            }

            GrupaUlaznice.Enabled = false;
            GrupaPodaci.Enabled = true;

            DugmeOtkaziIzmene.Enabled = true;
            DugmePotvrdiIzmene.Enabled = true;

            var u = ulaznice.Where(ul => ul.Id == selektovanaUlaznicaId).FirstOrDefault();
            dtpDatum.Value = u.DatumKupovine;
            txtCena.Value = (decimal)u.OsnovnaCena;
            switch (u.NacinPlacanja)
            {
                case "Gotovina":
                    cmbPlacanje.SelectedIndex = 0;
                    break;
                case "Kartica":
                    cmbPlacanje.SelectedIndex = 1;
                    break;
                case "Online":
                    cmbPlacanje.SelectedIndex = 2;
                    break;
            }
            TipLabela.Text = u.TipUlaznice.ToString();
        }

        private void TabelaUlaznice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DugmePotvrdiIzmene_Click(object sender, EventArgs e)
        {
            if (cmbPlacanje.SelectedIndex == -1)
            {
                MessageBox.Show("Odaberite nacin placanja.");
                return;
            }
            if (txtCena.Value <= 0)
            {
                MessageBox.Show("Unesite validnu cenu ulaznice.");
                return;
            }
            if (dtpDatum.Value > DateTime.Now)
            {
                MessageBox.Show("Datum kupovine ne može biti u budućnosti.");
                return;
            }

            string placanje = cmbPlacanje.SelectedItem as string;

            var u = ulaznice.Where(ul => ul.Id == selektovanaUlaznicaId).FirstOrDefault();

            UlaznicaBasic izmena = null;
            switch (u.TipUlaznice)
            {
                case TipUlaznice.JEDNODNEVNA:

                    izmena = new JednodnevnaBasic(u.Id, (float)txtCena.Value, placanje, dtpDatum.Value, null, DatumJednodnevna.Value);
                    break;
                case TipUlaznice.VISEDNEVNA:
                    if (TabelaDaniVisednevna.Rows.Count < 2)
                    {
                        MessageBox.Show("Dodajte bar 2 dana za visednevnu ulaznicu!");
                        return;
                    }

                    List<DateTime> list = new List<DateTime>();
                    for (int i = 0; i < TabelaDaniVisednevna.Rows.Count; i++)
                    {
                        if (TabelaDaniVisednevna.Rows[i].Cells["DAN"].Value != null)
                        {
                            DateTime r = Convert.ToDateTime(TabelaDaniVisednevna.Rows[i].Cells["DAN"].Value);
                            list.Add(r);
                        }
                    }

                    izmena = new ViseDnevnaBasic(u.Id, (float)txtCena.Value, placanje, dtpDatum.Value, null, list);
                    break;
                case TipUlaznice.AKREDITACIJA:

                    TipAkreditacije tipAkreditacije;
                    if (radioParter.Checked)
                        tipAkreditacije = TipAkreditacije.PARTNER;
                    else if (radioPress.Checked)
                        tipAkreditacije = TipAkreditacije.PRESS;
                    else
                        tipAkreditacije = TipAkreditacije.SPONZOR;

                    izmena = new AkreditacijaBasic(u.Id, (float)txtCena.Value, placanje, dtpDatum.Value, null, tipAkreditacije);
                    break;
                case TipUlaznice.VIP:

                    if (TabelaPogodnosti.Rows.Count <= 0)
                    {
                        MessageBox.Show("Dodajte bar jednu pogodnost!");
                        return;
                    }

                    List<string> pogodnosti = new List<string>();
                    foreach (DataGridViewRow r in TabelaPogodnosti.Rows)
                    {
                        pogodnosti.Add(r.Cells["POGODNOST"].Value.ToString());
                    }

                    izmena = new VIPBasic(u.Id, (float)txtCena.Value, placanje, dtpDatum.Value, null, pogodnosti);
                    break;
            }

            if (DTOManager.IzmeniUlaznicu(izmena))
            {
                MessageBox.Show("Uspesna izmena!");

                txtCena.Value = 0;
                cmbPlacanje.SelectedIndex = -1;
                TipLabela.Text = "";

                DugmeOtkaziIzmene.Enabled = false;
                DugmePotvrdiIzmene.Enabled = false;

                GrupaPodaci.Enabled = false;
                GrupaUlaznice.Enabled = true;

                ulaznice = DTOManager.VratiSveUlaznice();
                PopuniTabeluUlaznice();
                selektovanaUlaznicaId = -1;
                
                TabelaPogodnosti.Rows.Clear();
                TabelaDaniVisednevna.Rows.Clear();

                return;
            }
            else
            {
                MessageBox.Show("Greska gerrnie");
            }
        }

        private void DugmeOtkaziIzmene_Click(object sender, EventArgs e)
        {
            txtCena.Value = 0;
            cmbPlacanje.SelectedIndex = -1;
            TipLabela.Text = "";

            DugmeOtkaziIzmene.Enabled = false;
            DugmePotvrdiIzmene.Enabled = false;

            GrupaPodaci.Enabled = false;
            GrupaUlaznice.Enabled = true;
        }
    }
}
