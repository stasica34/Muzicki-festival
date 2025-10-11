namespace Muzicki_festival.FormeDodatne
{
    partial class FormaMenadzerskaAgencijaIzmeni
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.labelaAdresa = new System.Windows.Forms.Label();
            this.labelBrojClanova = new System.Windows.Forms.Label();
            this.txtKontaktOsoba = new System.Windows.Forms.TextBox();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.TabelaKontakti = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.TipKontakt = new System.Windows.Forms.ComboBox();
            this.DodajKontakt = new System.Windows.Forms.Button();
            this.ObrisiKontakt = new System.Windows.Forms.Button();
            this.VrednostKontakt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaKontakti)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.txtNaziv, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtAdresa, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelNaziv, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelaAdresa, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelBrojClanova, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtKontaktOsoba, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(533, 180);
            this.tableLayoutPanel1.TabIndex = 10;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNaziv.Location = new System.Drawing.Point(257, 19);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(2);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(152, 20);
            this.txtNaziv.TabIndex = 7;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdresa.Location = new System.Drawing.Point(257, 79);
            this.txtAdresa.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(152, 20);
            this.txtAdresa.TabIndex = 6;
            // 
            // labelNaziv
            // 
            this.labelNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(48, 23);
            this.labelNaziv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(37, 13);
            this.labelNaziv.TabIndex = 1;
            this.labelNaziv.Text = "Naziv:";
            // 
            // labelaAdresa
            // 
            this.labelaAdresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelaAdresa.AutoSize = true;
            this.labelaAdresa.Location = new System.Drawing.Point(45, 82);
            this.labelaAdresa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelaAdresa.Name = "labelaAdresa";
            this.labelaAdresa.Size = new System.Drawing.Size(43, 13);
            this.labelaAdresa.TabIndex = 2;
            this.labelaAdresa.Text = "Adresa:";
            // 
            // labelBrojClanova
            // 
            this.labelBrojClanova.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBrojClanova.AutoSize = true;
            this.labelBrojClanova.Location = new System.Drawing.Point(27, 143);
            this.labelBrojClanova.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBrojClanova.Name = "labelBrojClanova";
            this.labelBrojClanova.Size = new System.Drawing.Size(79, 13);
            this.labelBrojClanova.TabIndex = 3;
            this.labelBrojClanova.Text = "Kontakt osoba:";
            // 
            // txtKontaktOsoba
            // 
            this.txtKontaktOsoba.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKontaktOsoba.Location = new System.Drawing.Point(257, 139);
            this.txtKontaktOsoba.Margin = new System.Windows.Forms.Padding(2);
            this.txtKontaktOsoba.Name = "txtKontaktOsoba";
            this.txtKontaktOsoba.Size = new System.Drawing.Size(152, 20);
            this.txtKontaktOsoba.TabIndex = 4;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOtkazi.Location = new System.Drawing.Point(342, 9);
            this.btnOtkazi.Margin = new System.Windows.Forms.Padding(2);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(115, 42);
            this.btnOtkazi.TabIndex = 1;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnSacuvaj, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnOtkazi, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 345);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(533, 60);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvaj.Location = new System.Drawing.Point(75, 9);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(115, 42);
            this.btnSacuvaj.TabIndex = 0;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Location = new System.Drawing.Point(12, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 155);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KontaktPodaci";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.Controls.Add(this.TabelaKontakti, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(500, 133);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // TabelaKontakti
            // 
            this.TabelaKontakti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaKontakti.Location = new System.Drawing.Point(128, 3);
            this.TabelaKontakti.Name = "TabelaKontakti";
            this.TabelaKontakti.Size = new System.Drawing.Size(369, 127);
            this.TabelaKontakti.TabIndex = 0;
            this.TabelaKontakti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelaKontakti_CellClick);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.TipKontakt, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.DodajKontakt, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.ObrisiKontakt, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.VrednostKontakt, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(119, 125);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // TipKontakt
            // 
            this.TipKontakt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TipKontakt.FormattingEnabled = true;
            this.TipKontakt.Location = new System.Drawing.Point(3, 5);
            this.TipKontakt.Name = "TipKontakt";
            this.TipKontakt.Size = new System.Drawing.Size(113, 21);
            this.TipKontakt.TabIndex = 0;
            this.TipKontakt.SelectedIndexChanged += new System.EventHandler(this.TipKontakt_SelectedIndexChanged);
            // 
            // DodajKontakt
            // 
            this.DodajKontakt.Location = new System.Drawing.Point(3, 65);
            this.DodajKontakt.Name = "DodajKontakt";
            this.DodajKontakt.Size = new System.Drawing.Size(113, 25);
            this.DodajKontakt.TabIndex = 2;
            this.DodajKontakt.Text = "Dodaj";
            this.DodajKontakt.UseVisualStyleBackColor = true;
            this.DodajKontakt.Click += new System.EventHandler(this.DodajKontakt_Click);
            // 
            // ObrisiKontakt
            // 
            this.ObrisiKontakt.Enabled = false;
            this.ObrisiKontakt.Location = new System.Drawing.Point(3, 96);
            this.ObrisiKontakt.Name = "ObrisiKontakt";
            this.ObrisiKontakt.Size = new System.Drawing.Size(113, 26);
            this.ObrisiKontakt.TabIndex = 3;
            this.ObrisiKontakt.Text = "Obrisi";
            this.ObrisiKontakt.UseVisualStyleBackColor = true;
            this.ObrisiKontakt.Click += new System.EventHandler(this.ObrisiKontakt_Click);
            // 
            // VrednostKontakt
            // 
            this.VrednostKontakt.Location = new System.Drawing.Point(3, 34);
            this.VrednostKontakt.Name = "VrednostKontakt";
            this.VrednostKontakt.Size = new System.Drawing.Size(113, 20);
            this.VrednostKontakt.TabIndex = 1;
            // 
            // FormaMenadzerskaAgencijaIzmeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 405);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormaMenadzerskaAgencijaIzmeni";
            this.Text = "FormaMenadzerskaAgencijaIzmeni";
            this.Load += new System.EventHandler(this.FormaMenadzerskaAgencijaIzmeni_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaKontakti)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.Label labelaAdresa;
        private System.Windows.Forms.Label labelBrojClanova;
        private System.Windows.Forms.TextBox txtKontaktOsoba;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView TabelaKontakti;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox TipKontakt;
        private System.Windows.Forms.TextBox VrednostKontakt;
        private System.Windows.Forms.Button DodajKontakt;
        private System.Windows.Forms.Button ObrisiKontakt;
    }
}