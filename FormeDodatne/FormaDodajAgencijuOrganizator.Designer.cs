namespace Muzicki_festival.FormeDodatne
{
    partial class FormaDodajAgencijuOrganizator
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
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.DugmeDodaj = new System.Windows.Forms.Button();
            this.DugmeOtkazi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TabelaAgencije = new System.Windows.Forms.DataGridView();
            this.ObrisiDugme = new System.Windows.Forms.Button();
            this.IzmeniDugme = new System.Windows.Forms.Button();
            this.GrupaIzmena = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIzmenaNaziv = new System.Windows.Forms.TextBox();
            this.txtIzmenaAdresa = new System.Windows.Forms.TextBox();
            this.PotvrdiIzmenu = new System.Windows.Forms.Button();
            this.OtkaziIzmenu = new System.Windows.Forms.Button();
            this.GrupaNova = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaAgencije)).BeginInit();
            this.GrupaIzmena.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.txtAdresa, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DugmeDodaj, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.DugmeOtkazi, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(443, 102);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresa:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNaziv.Location = new System.Drawing.Point(254, 6);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(155, 20);
            this.txtNaziv.TabIndex = 2;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdresa.Location = new System.Drawing.Point(254, 39);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(155, 20);
            this.txtAdresa.TabIndex = 3;
            // 
            // DugmeDodaj
            // 
            this.DugmeDodaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DugmeDodaj.Location = new System.Drawing.Point(73, 72);
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
            this.DugmeOtkazi.Location = new System.Drawing.Point(294, 72);
            this.DugmeOtkazi.Name = "DugmeOtkazi";
            this.DugmeOtkazi.Size = new System.Drawing.Size(75, 23);
            this.DugmeOtkazi.TabIndex = 5;
            this.DugmeOtkazi.Text = "Otkazi";
            this.DugmeOtkazi.UseVisualStyleBackColor = true;
            this.DugmeOtkazi.Click += new System.EventHandler(this.DugmeOtkazi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(18, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 190);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agencije";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.TabelaAgencije, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ObrisiDugme, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.IzmeniDugme, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(440, 168);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // TabelaAgencije
            // 
            this.TabelaAgencije.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TabelaAgencije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaAgencije.Location = new System.Drawing.Point(226, 9);
            this.TabelaAgencije.Name = "TabelaAgencije";
            this.tableLayoutPanel2.SetRowSpan(this.TabelaAgencije, 2);
            this.TabelaAgencije.Size = new System.Drawing.Size(208, 150);
            this.TabelaAgencije.TabIndex = 0;
            this.TabelaAgencije.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelaAgencije_CellClick);
            // 
            // ObrisiDugme
            // 
            this.ObrisiDugme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ObrisiDugme.Location = new System.Drawing.Point(58, 28);
            this.ObrisiDugme.Name = "ObrisiDugme";
            this.ObrisiDugme.Size = new System.Drawing.Size(104, 27);
            this.ObrisiDugme.TabIndex = 1;
            this.ObrisiDugme.Text = "Obrisi";
            this.ObrisiDugme.UseVisualStyleBackColor = true;
            this.ObrisiDugme.Click += new System.EventHandler(this.ObrisiDugme_Click);
            // 
            // IzmeniDugme
            // 
            this.IzmeniDugme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IzmeniDugme.Location = new System.Drawing.Point(58, 112);
            this.IzmeniDugme.Name = "IzmeniDugme";
            this.IzmeniDugme.Size = new System.Drawing.Size(104, 27);
            this.IzmeniDugme.TabIndex = 2;
            this.IzmeniDugme.Text = "Izmeni";
            this.IzmeniDugme.UseVisualStyleBackColor = true;
            this.IzmeniDugme.Click += new System.EventHandler(this.IzmeniDugme_Click);
            // 
            // GrupaIzmena
            // 
            this.GrupaIzmena.Controls.Add(this.tableLayoutPanel3);
            this.GrupaIzmena.Enabled = false;
            this.GrupaIzmena.Location = new System.Drawing.Point(18, 341);
            this.GrupaIzmena.Name = "GrupaIzmena";
            this.GrupaIzmena.Size = new System.Drawing.Size(449, 132);
            this.GrupaIzmena.TabIndex = 1;
            this.GrupaIzmena.TabStop = false;
            this.GrupaIzmena.Text = "Izmena";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.OtkaziIzmenu, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.PotvrdiIzmenu, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtIzmenaAdresa, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtIzmenaNaziv, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(437, 110);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Naziv:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Adresa:";
            // 
            // txtIzmenaNaziv
            // 
            this.txtIzmenaNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIzmenaNaziv.Location = new System.Drawing.Point(250, 8);
            this.txtIzmenaNaziv.Name = "txtIzmenaNaziv";
            this.txtIzmenaNaziv.Size = new System.Drawing.Size(155, 20);
            this.txtIzmenaNaziv.TabIndex = 3;
            // 
            // txtIzmenaAdresa
            // 
            this.txtIzmenaAdresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIzmenaAdresa.Location = new System.Drawing.Point(250, 44);
            this.txtIzmenaAdresa.Name = "txtIzmenaAdresa";
            this.txtIzmenaAdresa.Size = new System.Drawing.Size(155, 20);
            this.txtIzmenaAdresa.TabIndex = 4;
            // 
            // PotvrdiIzmenu
            // 
            this.PotvrdiIzmenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PotvrdiIzmenu.Location = new System.Drawing.Point(71, 79);
            this.PotvrdiIzmenu.Name = "PotvrdiIzmenu";
            this.PotvrdiIzmenu.Size = new System.Drawing.Size(75, 23);
            this.PotvrdiIzmenu.TabIndex = 5;
            this.PotvrdiIzmenu.Text = "Potvrdi";
            this.PotvrdiIzmenu.UseVisualStyleBackColor = true;
            this.PotvrdiIzmenu.Click += new System.EventHandler(this.PotvrdiIzmenu_Click);
            // 
            // OtkaziIzmenu
            // 
            this.OtkaziIzmenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OtkaziIzmenu.Location = new System.Drawing.Point(290, 79);
            this.OtkaziIzmenu.Name = "OtkaziIzmenu";
            this.OtkaziIzmenu.Size = new System.Drawing.Size(75, 23);
            this.OtkaziIzmenu.TabIndex = 6;
            this.OtkaziIzmenu.Text = "Otkazi";
            this.OtkaziIzmenu.UseVisualStyleBackColor = true;
            this.OtkaziIzmenu.Click += new System.EventHandler(this.OtkaziIzmenu_Click);
            // 
            // GrupaNova
            // 
            this.GrupaNova.Controls.Add(this.tableLayoutPanel1);
            this.GrupaNova.Location = new System.Drawing.Point(18, 12);
            this.GrupaNova.Name = "GrupaNova";
            this.GrupaNova.Size = new System.Drawing.Size(455, 127);
            this.GrupaNova.TabIndex = 2;
            this.GrupaNova.TabStop = false;
            this.GrupaNova.Text = "Nova agencija";
            // 
            // FormaDodajAgencijuOrganizator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 485);
            this.Controls.Add(this.GrupaNova);
            this.Controls.Add(this.GrupaIzmena);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormaDodajAgencijuOrganizator";
            this.Text = "FormaDodajAgencijuOrganizator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaAgencije)).EndInit();
            this.GrupaIzmena.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.GrupaNova.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Button DugmeDodaj;
        private System.Windows.Forms.Button DugmeOtkazi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView TabelaAgencije;
        private System.Windows.Forms.Button ObrisiDugme;
        private System.Windows.Forms.Button IzmeniDugme;
        private System.Windows.Forms.GroupBox GrupaIzmena;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button OtkaziIzmenu;
        private System.Windows.Forms.Button PotvrdiIzmenu;
        private System.Windows.Forms.TextBox txtIzmenaAdresa;
        private System.Windows.Forms.TextBox txtIzmenaNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GrupaNova;
    }
}