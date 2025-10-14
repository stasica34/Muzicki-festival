namespace Muzicki_festival.FormeDodatne
{
    partial class FormaMenadzerskaAgencijaDodavanje
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.IzvodjaciTabela = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.KontaktTabela = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AgencijeTabela = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.DugmeIzmeni = new System.Windows.Forms.Button();
            this.DugmeIzadji = new System.Windows.Forms.Button();
            this.DugmeDodaj = new System.Windows.Forms.Button();
            this.ObrisiDugme = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IzvodjaciTabela)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KontaktTabela)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgencijeTabela)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.txtNaziv, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtAdresa, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelNaziv, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelaAdresa, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelBrojClanova, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtKontaktOsoba, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(59, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(616, 146);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNaziv.Location = new System.Drawing.Point(309, 14);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(2);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(152, 20);
            this.txtNaziv.TabIndex = 7;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdresa.Location = new System.Drawing.Point(309, 62);
            this.txtAdresa.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(152, 20);
            this.txtAdresa.TabIndex = 6;
            // 
            // labelNaziv
            // 
            this.labelNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(58, 17);
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
            this.labelaAdresa.Location = new System.Drawing.Point(55, 65);
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
            this.labelBrojClanova.Location = new System.Drawing.Point(37, 114);
            this.labelBrojClanova.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBrojClanova.Name = "labelBrojClanova";
            this.labelBrojClanova.Size = new System.Drawing.Size(79, 13);
            this.labelBrojClanova.TabIndex = 3;
            this.labelBrojClanova.Text = "Kontakt osoba:";
            // 
            // txtKontaktOsoba
            // 
            this.txtKontaktOsoba.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKontaktOsoba.Location = new System.Drawing.Point(309, 111);
            this.txtKontaktOsoba.Margin = new System.Windows.Forms.Padding(2);
            this.txtKontaktOsoba.Name = "txtKontaktOsoba";
            this.txtKontaktOsoba.Size = new System.Drawing.Size(152, 20);
            this.txtKontaktOsoba.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 225);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(711, 159);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.IzvodjaciTabela);
            this.groupBox3.Location = new System.Drawing.Point(535, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(173, 148);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Izvodjaci";
            // 
            // IzvodjaciTabela
            // 
            this.IzvodjaciTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IzvodjaciTabela.Location = new System.Drawing.Point(3, 16);
            this.IzvodjaciTabela.Name = "IzvodjaciTabela";
            this.IzvodjaciTabela.Size = new System.Drawing.Size(164, 126);
            this.IzvodjaciTabela.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.KontaktTabela);
            this.groupBox2.Location = new System.Drawing.Point(322, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 148);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kontakt podaci";
            // 
            // KontaktTabela
            // 
            this.KontaktTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KontaktTabela.Location = new System.Drawing.Point(6, 19);
            this.KontaktTabela.Name = "KontaktTabela";
            this.KontaktTabela.Size = new System.Drawing.Size(195, 123);
            this.KontaktTabela.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AgencijeTabela);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 151);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menadzerske agencije";
            // 
            // AgencijeTabela
            // 
            this.AgencijeTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AgencijeTabela.Location = new System.Drawing.Point(6, 19);
            this.AgencijeTabela.Name = "AgencijeTabela";
            this.AgencijeTabela.Size = new System.Drawing.Size(301, 126);
            this.AgencijeTabela.TabIndex = 9;
            this.AgencijeTabela.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AgencijeTabela_CellClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel3.Controls.Add(this.DugmeDodaj, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.DugmeIzadji, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.DugmeIzmeni, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.ObrisiDugme, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(59, 151);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(616, 68);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // DugmeIzmeni
            // 
            this.DugmeIzmeni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DugmeIzmeni.Enabled = false;
            this.DugmeIzmeni.Location = new System.Drawing.Point(194, 20);
            this.DugmeIzmeni.Margin = new System.Windows.Forms.Padding(40, 20, 40, 20);
            this.DugmeIzmeni.Name = "DugmeIzmeni";
            this.DugmeIzmeni.Size = new System.Drawing.Size(74, 28);
            this.DugmeIzmeni.TabIndex = 1;
            this.DugmeIzmeni.Text = "Izmeni";
            this.DugmeIzmeni.UseVisualStyleBackColor = true;
            this.DugmeIzmeni.Click += new System.EventHandler(this.DugmeIzmeni_Click);
            // 
            // DugmeIzadji
            // 
            this.DugmeIzadji.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DugmeIzadji.Location = new System.Drawing.Point(502, 20);
            this.DugmeIzadji.Margin = new System.Windows.Forms.Padding(40, 20, 40, 20);
            this.DugmeIzadji.Name = "DugmeIzadji";
            this.DugmeIzadji.Size = new System.Drawing.Size(74, 28);
            this.DugmeIzadji.TabIndex = 2;
            this.DugmeIzadji.Text = "Izadji";
            this.DugmeIzadji.UseVisualStyleBackColor = true;
            this.DugmeIzadji.Click += new System.EventHandler(this.DugmeIzadji_Click);
            // 
            // DugmeDodaj
            // 
            this.DugmeDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DugmeDodaj.Location = new System.Drawing.Point(40, 20);
            this.DugmeDodaj.Margin = new System.Windows.Forms.Padding(40, 20, 40, 20);
            this.DugmeDodaj.Name = "DugmeDodaj";
            this.DugmeDodaj.Size = new System.Drawing.Size(74, 28);
            this.DugmeDodaj.TabIndex = 0;
            this.DugmeDodaj.Text = "Dodaj";
            this.DugmeDodaj.UseVisualStyleBackColor = true;
            this.DugmeDodaj.Click += new System.EventHandler(this.DugmeDodaj_Click);
            // 
            // ObrisiDugme
            // 
            this.ObrisiDugme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ObrisiDugme.Enabled = false;
            this.ObrisiDugme.Location = new System.Drawing.Point(348, 20);
            this.ObrisiDugme.Name = "ObrisiDugme";
            this.ObrisiDugme.Size = new System.Drawing.Size(74, 28);
            this.ObrisiDugme.TabIndex = 3;
            this.ObrisiDugme.Text = "Obrisi";
            this.ObrisiDugme.UseVisualStyleBackColor = true;
            this.ObrisiDugme.Click += new System.EventHandler(this.ObrisiDugme_Click);
            // 
            // FormaMenadzerskaAgencijaDodavanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 396);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormaMenadzerskaAgencijaDodavanje";
            this.Text = "FormaMenadzerskaAgencijaDodavanje";
            this.Load += new System.EventHandler(this.FormaMenadzerskaAgencijaDodavanje_Load);
            this.VisibleChanged += new System.EventHandler(this.FormaMenadzerskaAgencijaDodavanje_VisibleChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IzvodjaciTabela)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KontaktTabela)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AgencijeTabela)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.Label labelaAdresa;
        private System.Windows.Forms.Label labelBrojClanova;
        private System.Windows.Forms.TextBox txtKontaktOsoba;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView IzvodjaciTabela;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView KontaktTabela;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView AgencijeTabela;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button DugmeIzmeni;
        private System.Windows.Forms.Button DugmeIzadji;
        private System.Windows.Forms.Button DugmeDodaj;
        private System.Windows.Forms.Button ObrisiDugme;
    }
}