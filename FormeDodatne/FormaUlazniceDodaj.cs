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
using Muzicki_festival.Forme;
using Muzicki_festival.DTOs;
namespace Muzicki_festival.FormeDodatne
{
    public partial class FormaUlazniceDodaj : Form
    {
        private Form parentform;
        DogadjajBasic db;
        public UlaznicaBasic UlaznicaBasicIzlaz;
        private int selektovanRedVisednevnaDani = -1;
        private int selektovanRedPogodnosti = -1;
        public FormaUlazniceDodaj(Form caller, DogadjajBasic db)
        {
            InitializeComponent();
            parentform = caller;
            this.db = db;

            InitTabeluDani();
            InitTabeluPogodnosti();
        }

        private void FormaUlazniceDodaj_Load(object sender, EventArgs e)
        {
            cmbPlacanje.Items.AddRange(new string[]
            {
                "Gotovina",
                "Kartica",
                "Online"
            });
            cmbPlacanje.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTip.Items.AddRange(new string[]
            {
                "Jednodnevna",
                "Visednevna",
                "Akreditacija",
                "VIP"
            });

            cmbTip.SelectedValue = cmbTip.Items[0];

            InputJednodnevna.Visible = true;
            InputVisednevna.Visible = false;
            InputVIP.Visible = false;
            InputAkreditacija.Visible = false;
            radioParter.Checked = false;
            radioPress.Checked = false;
            radioSponzor.Checked = false;

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

        private void btnSacuvaj_Click(object sender, EventArgs e)
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
            if (cmbTip.SelectedIndex == -1)
            {
                MessageBox.Show("Izaberite tip ulaznice!");
                return;
            }

            string placanje = cmbPlacanje.SelectedItem as string;

            string tip = (string)cmbTip.SelectedItem;
            switch (tip)
            {
                case "Jednodnevna":

                    UlaznicaBasicIzlaz = new JednodnevnaBasic(0, (float)txtCena.Value, placanje, dtpDatum.Value, db, DatumJednodnevna.Value);
                    break;
                case "Visednevna":
                    if (TabelaDaniVisednevna.Rows.Count < 2)
                    { 
                        MessageBox.Show("Dodajte bar 2 dana za visednevnu ulaznicu!");
                        return;
                    }

                    List<DateTime> list = new List<DateTime>();
                    for (int i = 0; i < TabelaDaniVisednevna.Rows.Count; i++)
                    {
                        DateTime r = (DateTime)TabelaDaniVisednevna.Rows[i].Cells["DAN"].Value;
                        list.Add(r);
                    }

                    UlaznicaBasicIzlaz = new ViseDnevnaBasic(0, (float)txtCena.Value, placanje, dtpDatum.Value, db, list);

                    break;
                case "Akreditacija":

                    TipAkreditacije tipAkreditacije;
                    if (radioParter.Checked)
                        tipAkreditacije = TipAkreditacije.PARTNER;
                    else if (radioPress.Checked)
                        tipAkreditacije = TipAkreditacije.PRESS;
                    else if(radioSponzor.Checked)
                        tipAkreditacije = TipAkreditacije.SPONZOR;
                    else
                    {
                        MessageBox.Show("Morate izabrati tip akreditacije (Partner, Press ili Sponzor)!");
                        return;
                    }

                    UlaznicaBasicIzlaz = new AkreditacijaBasic(0, (float)txtCena.Value, placanje, dtpDatum.Value, db, tipAkreditacije);

                        break;
                case "VIP":

                    if (TabelaPogodnosti.Rows.Count <= 0)
                    {
                        MessageBox.Show("Dodajte bar jednu pogodnost!");
                        return;
                    }

                    List<string> pogodnosti = new List<string>();
                    foreach (DataGridViewRow row in TabelaPogodnosti.Rows)
                    {
                        if (row.Cells["POGODNOST"].Value != null)
                            pogodnosti.Add(row.Cells["POGODNOST"].Value.ToString());
                    }
                    UlaznicaBasicIzlaz = new VIPBasic(0, (float)txtCena.Value, placanje, dtpDatum.Value, db, pogodnosti);

                    break;
            }

            if (UlaznicaBasicIzlaz != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.No;
                this.Close();
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            parentform.Show();
            this.Close();
        }

        private void cmbTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTip.SelectedItem)
            {
                case "Jednodnevna":
                    InputJednodnevna.Visible = true;
                    InputVisednevna.Visible = false;
                    InputVIP.Visible = false;
                    InputAkreditacija.Visible = false;
                    break;
                case "Visednevna":
                    InputJednodnevna.Visible = false;
                    InputVisednevna.Visible = true;
                    InputVIP.Visible = false;
                    InputAkreditacija.Visible = false;
                    break;
                case "VIP":
                    InputJednodnevna.Visible = false;
                    InputVisednevna.Visible = false;
                    InputVIP.Visible = true;
                    InputAkreditacija.Visible = false;
                    break;
                case "Akreditacija":
                    InputJednodnevna.Visible = false;
                    InputVisednevna.Visible = false;
                    InputVIP.Visible = false;
                    InputAkreditacija.Visible = true;
                    break;
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
            if (string.IsNullOrWhiteSpace(txtPogodnost.Text))
            {
                MessageBox.Show("Unesite pogodnost u tekst polje!");
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

    }
}
