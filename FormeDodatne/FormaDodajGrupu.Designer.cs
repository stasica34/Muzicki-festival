namespace Muzicki_festival.FormeDodatne
{
    partial class FormaDodajGrupu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.DugmeDodaj = new System.Windows.Forms.Button();
            this.DugmeOtkazi = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbAgencije = new System.Windows.Forms.ComboBox();
            this.DugmeDodajAgenciju = new System.Windows.Forms.Button();
            this.Tabele = new System.Windows.Forms.TableLayoutPanel();
            this.IzmeniDugme = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TabelaClanovi = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TabelaGrupe = new System.Windows.Forms.DataGridView();
            this.DugmeObrisi = new System.Windows.Forms.Button();
            this.GrupaIzmena = new System.Windows.Forms.GroupBox();
            this.TableLayoutIzmena = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNazivIzmena = new System.Windows.Forms.TextBox();
            this.PotvrdiIzmeneDugme = new System.Windows.Forms.Button();
            this.OtkaziIzmene = new System.Windows.Forms.Button();
            this.TableLayoutAgencija = new System.Windows.Forms.TableLayoutPanel();
            this.DugmePromeniAgenciju = new System.Windows.Forms.Button();
            this.GrupaNova = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.Tabele.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaClanovi)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaGrupe)).BeginInit();
            this.GrupaIzmena.SuspendLayout();
            this.TableLayoutIzmena.SuspendLayout();
            this.TableLayoutAgencija.SuspendLayout();
            this.GrupaNova.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNaziv, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DugmeDodaj, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.DugmeOtkazi, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(406, 149);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Agencija organizator";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNaziv.Location = new System.Drawing.Point(240, 8);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(129, 20);
            this.txtNaziv.TabIndex = 2;
            // 
            // DugmeDodaj
            // 
            this.DugmeDodaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DugmeDodaj.Location = new System.Drawing.Point(64, 118);
            this.DugmeDodaj.Name = "DugmeDodaj";
            this.DugmeDodaj.Size = new System.Drawing.Size(75, 23);
            this.DugmeDodaj.TabIndex = 4;
            this.DugmeDodaj.Text = "Dodaj";
            this.DugmeDodaj.UseVisualStyleBackColor = true;
            this.DugmeDodaj.Click += new System.EventHandler(this.DugmeDodaj_Click);
            // 
            // DugmeOtkazi
            // 
            this.DugmeOtkazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DugmeOtkazi.Location = new System.Drawing.Point(267, 118);
            this.DugmeOtkazi.Name = "DugmeOtkazi";
            this.DugmeOtkazi.Size = new System.Drawing.Size(75, 23);
            this.DugmeOtkazi.TabIndex = 5;
            this.DugmeOtkazi.Text = "Otkaži";
            this.DugmeOtkazi.UseVisualStyleBackColor = true;
            this.DugmeOtkazi.Click += new System.EventHandler(this.DugmeOtkazi_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.cmbAgencije, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.DugmeDodajAgenciju, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(206, 40);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(197, 68);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // cmbAgencije
            // 
            this.cmbAgencije.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbAgencije.FormattingEnabled = true;
            this.cmbAgencije.Location = new System.Drawing.Point(6, 23);
            this.cmbAgencije.Name = "cmbAgencije";
            this.cmbAgencije.Size = new System.Drawing.Size(125, 21);
            this.cmbAgencije.TabIndex = 3;
            // 
            // DugmeDodajAgenciju
            // 
            this.DugmeDodajAgenciju.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DugmeDodajAgenciju.Location = new System.Drawing.Point(140, 5);
            this.DugmeDodajAgenciju.Name = "DugmeDodajAgenciju";
            this.DugmeDodajAgenciju.Size = new System.Drawing.Size(54, 58);
            this.DugmeDodajAgenciju.TabIndex = 4;
            this.DugmeDodajAgenciju.Text = "Dodaj novu agenciju";
            this.DugmeDodajAgenciju.UseVisualStyleBackColor = true;
            this.DugmeDodajAgenciju.Click += new System.EventHandler(this.DugmeDodajAgenciju_Click);
            // 
            // Tabele
            // 
            this.Tabele.ColumnCount = 2;
            this.Tabele.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tabele.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tabele.Controls.Add(this.IzmeniDugme, 1, 1);
            this.Tabele.Controls.Add(this.groupBox2, 1, 0);
            this.Tabele.Controls.Add(this.groupBox1, 0, 0);
            this.Tabele.Controls.Add(this.DugmeObrisi, 0, 1);
            this.Tabele.Location = new System.Drawing.Point(12, 189);
            this.Tabele.Name = "Tabele";
            this.Tabele.RowCount = 2;
            this.Tabele.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.Tabele.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Tabele.Size = new System.Drawing.Size(424, 177);
            this.Tabele.TabIndex = 1;
            // 
            // IzmeniDugme
            // 
            this.IzmeniDugme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IzmeniDugme.Enabled = false;
            this.IzmeniDugme.Location = new System.Drawing.Point(280, 144);
            this.IzmeniDugme.Name = "IzmeniDugme";
            this.IzmeniDugme.Size = new System.Drawing.Size(75, 30);
            this.IzmeniDugme.TabIndex = 5;
            this.IzmeniDugme.Text = "Izmeni";
            this.IzmeniDugme.UseVisualStyleBackColor = true;
            this.IzmeniDugme.Click += new System.EventHandler(this.IzmeniDugme_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TabelaClanovi);
            this.groupBox2.Location = new System.Drawing.Point(215, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 135);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clanovi";
            // 
            // TabelaClanovi
            // 
            this.TabelaClanovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaClanovi.Location = new System.Drawing.Point(9, 19);
            this.TabelaClanovi.Name = "TabelaClanovi";
            this.TabelaClanovi.Size = new System.Drawing.Size(185, 110);
            this.TabelaClanovi.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TabelaGrupe);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 135);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grupe";
            // 
            // TabelaGrupe
            // 
            this.TabelaGrupe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaGrupe.Location = new System.Drawing.Point(6, 19);
            this.TabelaGrupe.Name = "TabelaGrupe";
            this.TabelaGrupe.Size = new System.Drawing.Size(188, 110);
            this.TabelaGrupe.TabIndex = 1;
            this.TabelaGrupe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelaGrupe_CellClick);
            // 
            // DugmeObrisi
            // 
            this.DugmeObrisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DugmeObrisi.Enabled = false;
            this.DugmeObrisi.Location = new System.Drawing.Point(68, 144);
            this.DugmeObrisi.Name = "DugmeObrisi";
            this.DugmeObrisi.Size = new System.Drawing.Size(75, 30);
            this.DugmeObrisi.TabIndex = 4;
            this.DugmeObrisi.Text = "Obrisi";
            this.DugmeObrisi.UseVisualStyleBackColor = true;
            this.DugmeObrisi.Click += new System.EventHandler(this.DugmeObrisi_Click);
            // 
            // GrupaIzmena
            // 
            this.GrupaIzmena.Controls.Add(this.TableLayoutIzmena);
            this.GrupaIzmena.Enabled = false;
            this.GrupaIzmena.Location = new System.Drawing.Point(21, 379);
            this.GrupaIzmena.Name = "GrupaIzmena";
            this.GrupaIzmena.Size = new System.Drawing.Size(415, 174);
            this.GrupaIzmena.TabIndex = 2;
            this.GrupaIzmena.TabStop = false;
            this.GrupaIzmena.Text = "Izmena";
            // 
            // TableLayoutIzmena
            // 
            this.TableLayoutIzmena.ColumnCount = 2;
            this.TableLayoutIzmena.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutIzmena.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutIzmena.Controls.Add(this.label3, 0, 0);
            this.TableLayoutIzmena.Controls.Add(this.label4, 0, 1);
            this.TableLayoutIzmena.Controls.Add(this.txtNazivIzmena, 1, 0);
            this.TableLayoutIzmena.Controls.Add(this.PotvrdiIzmeneDugme, 0, 2);
            this.TableLayoutIzmena.Controls.Add(this.OtkaziIzmene, 1, 2);
            this.TableLayoutIzmena.Controls.Add(this.TableLayoutAgencija, 1, 1);
            this.TableLayoutIzmena.Location = new System.Drawing.Point(6, 19);
            this.TableLayoutIzmena.Name = "TableLayoutIzmena";
            this.TableLayoutIzmena.RowCount = 3;
            this.TableLayoutIzmena.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutIzmena.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutIzmena.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutIzmena.Size = new System.Drawing.Size(403, 143);
            this.TableLayoutIzmena.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Naziv:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Agencija organizator";
            // 
            // txtNazivIzmena
            // 
            this.txtNazivIzmena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNazivIzmena.Location = new System.Drawing.Point(237, 7);
            this.txtNazivIzmena.Name = "txtNazivIzmena";
            this.txtNazivIzmena.Size = new System.Drawing.Size(129, 20);
            this.txtNazivIzmena.TabIndex = 2;
            // 
            // PotvrdiIzmeneDugme
            // 
            this.PotvrdiIzmeneDugme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PotvrdiIzmeneDugme.Location = new System.Drawing.Point(63, 113);
            this.PotvrdiIzmeneDugme.Name = "PotvrdiIzmeneDugme";
            this.PotvrdiIzmeneDugme.Size = new System.Drawing.Size(75, 23);
            this.PotvrdiIzmeneDugme.TabIndex = 4;
            this.PotvrdiIzmeneDugme.Text = "Potvrdi";
            this.PotvrdiIzmeneDugme.UseVisualStyleBackColor = true;
            this.PotvrdiIzmeneDugme.Click += new System.EventHandler(this.PotvrdiIzmeneDugme_Click);
            // 
            // OtkaziIzmene
            // 
            this.OtkaziIzmene.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OtkaziIzmene.Location = new System.Drawing.Point(264, 113);
            this.OtkaziIzmene.Name = "OtkaziIzmene";
            this.OtkaziIzmene.Size = new System.Drawing.Size(75, 23);
            this.OtkaziIzmene.TabIndex = 5;
            this.OtkaziIzmene.Text = "Otkaži";
            this.OtkaziIzmene.UseVisualStyleBackColor = true;
            this.OtkaziIzmene.Click += new System.EventHandler(this.OtkaziIzmene_Click);
            // 
            // TableLayoutAgencija
            // 
            this.TableLayoutAgencija.ColumnCount = 2;
            this.TableLayoutAgencija.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TableLayoutAgencija.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TableLayoutAgencija.Controls.Add(this.DugmePromeniAgenciju, 1, 0);
            this.TableLayoutAgencija.Location = new System.Drawing.Point(204, 38);
            this.TableLayoutAgencija.Name = "TableLayoutAgencija";
            this.TableLayoutAgencija.RowCount = 1;
            this.TableLayoutAgencija.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutAgencija.Size = new System.Drawing.Size(196, 65);
            this.TableLayoutAgencija.TabIndex = 6;
            // 
            // DugmePromeniAgenciju
            // 
            this.DugmePromeniAgenciju.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DugmePromeniAgenciju.Location = new System.Drawing.Point(140, 3);
            this.DugmePromeniAgenciju.Name = "DugmePromeniAgenciju";
            this.DugmePromeniAgenciju.Size = new System.Drawing.Size(53, 58);
            this.DugmePromeniAgenciju.TabIndex = 4;
            this.DugmePromeniAgenciju.Text = "Promeni";
            this.DugmePromeniAgenciju.UseVisualStyleBackColor = true;
            this.DugmePromeniAgenciju.Click += new System.EventHandler(this.DugmePromeniAgenciju_Click);
            // 
            // GrupaNova
            // 
            this.GrupaNova.Controls.Add(this.tableLayoutPanel1);
            this.GrupaNova.Location = new System.Drawing.Point(12, 12);
            this.GrupaNova.Name = "GrupaNova";
            this.GrupaNova.Size = new System.Drawing.Size(424, 174);
            this.GrupaNova.TabIndex = 3;
            this.GrupaNova.TabStop = false;
            this.GrupaNova.Text = "Nova agencija";
            // 
            // FormaDodajGrupu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 564);
            this.Controls.Add(this.GrupaNova);
            this.Controls.Add(this.GrupaIzmena);
            this.Controls.Add(this.Tabele);
            this.Name = "FormaDodajGrupu";
            this.Text = "FormaDodajGrupu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.Tabele.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaClanovi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaGrupe)).EndInit();
            this.GrupaIzmena.ResumeLayout(false);
            this.TableLayoutIzmena.ResumeLayout(false);
            this.TableLayoutIzmena.PerformLayout();
            this.TableLayoutAgencija.ResumeLayout(false);
            this.GrupaNova.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.ComboBox cmbAgencije;
        private System.Windows.Forms.Button DugmeDodaj;
        private System.Windows.Forms.Button DugmeOtkazi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button DugmeDodajAgenciju;
        private System.Windows.Forms.TableLayoutPanel Tabele;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView TabelaGrupe;
        private System.Windows.Forms.DataGridView TabelaClanovi;
        private System.Windows.Forms.Button DugmeObrisi;
        private System.Windows.Forms.Button IzmeniDugme;
        private System.Windows.Forms.GroupBox GrupaIzmena;
        private System.Windows.Forms.TableLayoutPanel TableLayoutIzmena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNazivIzmena;
        private System.Windows.Forms.Button PotvrdiIzmeneDugme;
        private System.Windows.Forms.Button OtkaziIzmene;
        private System.Windows.Forms.TableLayoutPanel TableLayoutAgencija;
        private System.Windows.Forms.Button DugmePromeniAgenciju;
        private System.Windows.Forms.GroupBox GrupaNova;
    }
}