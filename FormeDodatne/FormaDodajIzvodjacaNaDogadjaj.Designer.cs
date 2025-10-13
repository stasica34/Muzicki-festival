namespace Muzicki_festival.FormeDodatne
{
    partial class FormaDodajIzvodjacaNaDogadjaj
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
            this.TabelaIzvodjaci = new System.Windows.Forms.DataGridView();
            this.GrupaDodatnaTabela = new System.Windows.Forms.GroupBox();
            this.TabelaVokalneSposobnosti = new System.Windows.Forms.DataGridView();
            this.TabelaClanovi = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TabelaZahtevi = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DugmeDodajIzvodjaca = new System.Windows.Forms.Button();
            this.RadSaIzvodjacimaDugme = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelaNazivDogadjaj = new System.Windows.Forms.Label();
            this.DugmeOtkazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaIzvodjaci)).BeginInit();
            this.GrupaDodatnaTabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaVokalneSposobnosti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaClanovi)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaZahtevi)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabelaIzvodjaci
            // 
            this.TabelaIzvodjaci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TabelaIzvodjaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.TabelaIzvodjaci, 4);
            this.TabelaIzvodjaci.Location = new System.Drawing.Point(3, 5);
            this.TabelaIzvodjaci.Name = "TabelaIzvodjaci";
            this.TabelaIzvodjaci.Size = new System.Drawing.Size(713, 144);
            this.TabelaIzvodjaci.TabIndex = 5;
            this.TabelaIzvodjaci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelaIzvodjaci_CellClick);
            // 
            // GrupaDodatnaTabela
            // 
            this.GrupaDodatnaTabela.Controls.Add(this.TabelaVokalneSposobnosti);
            this.GrupaDodatnaTabela.Controls.Add(this.TabelaClanovi);
            this.GrupaDodatnaTabela.Location = new System.Drawing.Point(361, 157);
            this.GrupaDodatnaTabela.Name = "GrupaDodatnaTabela";
            this.GrupaDodatnaTabela.Size = new System.Drawing.Size(171, 141);
            this.GrupaDodatnaTabela.TabIndex = 6;
            this.GrupaDodatnaTabela.TabStop = false;
            this.GrupaDodatnaTabela.Text = "Clanovi benda";
            // 
            // TabelaVokalneSposobnosti
            // 
            this.TabelaVokalneSposobnosti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaVokalneSposobnosti.Location = new System.Drawing.Point(13, 22);
            this.TabelaVokalneSposobnosti.Name = "TabelaVokalneSposobnosti";
            this.TabelaVokalneSposobnosti.Size = new System.Drawing.Size(152, 103);
            this.TabelaVokalneSposobnosti.TabIndex = 7;
            // 
            // TabelaClanovi
            // 
            this.TabelaClanovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaClanovi.Location = new System.Drawing.Point(13, 22);
            this.TabelaClanovi.Name = "TabelaClanovi";
            this.TabelaClanovi.Size = new System.Drawing.Size(152, 103);
            this.TabelaClanovi.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TabelaZahtevi);
            this.groupBox1.Location = new System.Drawing.Point(182, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 141);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tehnicki zahtevi";
            // 
            // TabelaZahtevi
            // 
            this.TabelaZahtevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaZahtevi.Location = new System.Drawing.Point(6, 22);
            this.TabelaZahtevi.Name = "TabelaZahtevi";
            this.TabelaZahtevi.Size = new System.Drawing.Size(158, 103);
            this.TabelaZahtevi.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.GrupaDodatnaTabela, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.TabelaIzvodjaci, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DugmeDodajIzvodjaca, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.RadSaIzvodjacimaDugme, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 109);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(719, 308);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // DugmeDodajIzvodjaca
            // 
            this.DugmeDodajIzvodjaca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DugmeDodajIzvodjaca.Location = new System.Drawing.Point(32, 211);
            this.DugmeDodajIzvodjaca.Name = "DugmeDodajIzvodjaca";
            this.DugmeDodajIzvodjaca.Size = new System.Drawing.Size(115, 40);
            this.DugmeDodajIzvodjaca.TabIndex = 8;
            this.DugmeDodajIzvodjaca.Text = "Dodaj na dogadjaj";
            this.DugmeDodajIzvodjaca.UseVisualStyleBackColor = true;
            this.DugmeDodajIzvodjaca.Click += new System.EventHandler(this.DugmeDodajIzvodjaca_Click);
            // 
            // RadSaIzvodjacimaDugme
            // 
            this.RadSaIzvodjacimaDugme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RadSaIzvodjacimaDugme.Location = new System.Drawing.Point(570, 211);
            this.RadSaIzvodjacimaDugme.Name = "RadSaIzvodjacimaDugme";
            this.RadSaIzvodjacimaDugme.Size = new System.Drawing.Size(115, 40);
            this.RadSaIzvodjacimaDugme.TabIndex = 9;
            this.RadSaIzvodjacimaDugme.Text = "Dodaj novog izvodjaca";
            this.RadSaIzvodjacimaDugme.UseVisualStyleBackColor = true;
            this.RadSaIzvodjacimaDugme.Click += new System.EventHandler(this.RadSaIzvodjacimaDugme_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.LabelaNazivDogadjaj, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 38);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 33);
            this.tableLayoutPanel2.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dogadjaj";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelaNazivDogadjaj
            // 
            this.LabelaNazivDogadjaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelaNazivDogadjaj.AutoSize = true;
            this.LabelaNazivDogadjaj.Location = new System.Drawing.Point(132, 10);
            this.LabelaNazivDogadjaj.Name = "LabelaNazivDogadjaj";
            this.LabelaNazivDogadjaj.Size = new System.Drawing.Size(35, 13);
            this.LabelaNazivDogadjaj.TabIndex = 1;
            this.LabelaNazivDogadjaj.Text = "label2";
            // 
            // DugmeOtkazi
            // 
            this.DugmeOtkazi.Location = new System.Drawing.Point(609, 38);
            this.DugmeOtkazi.Name = "DugmeOtkazi";
            this.DugmeOtkazi.Size = new System.Drawing.Size(119, 43);
            this.DugmeOtkazi.TabIndex = 8;
            this.DugmeOtkazi.Text = "Otkazi";
            this.DugmeOtkazi.UseVisualStyleBackColor = true;
            // 
            // FormaDodajIzvodjacaNaDogadjaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 429);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.DugmeOtkazi);
            this.Name = "FormaDodajIzvodjacaNaDogadjaj";
            this.Text = "FormaDodajIzvodjacaNaDogadjaj";
            ((System.ComponentModel.ISupportInitialize)(this.TabelaIzvodjaci)).EndInit();
            this.GrupaDodatnaTabela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaVokalneSposobnosti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaClanovi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaZahtevi)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView TabelaIzvodjaci;
        private System.Windows.Forms.GroupBox GrupaDodatnaTabela;
        private System.Windows.Forms.DataGridView TabelaVokalneSposobnosti;
        private System.Windows.Forms.DataGridView TabelaClanovi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView TabelaZahtevi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DugmeDodajIzvodjaca;
        private System.Windows.Forms.Button RadSaIzvodjacimaDugme;
        private System.Windows.Forms.Label LabelaNazivDogadjaj;
        private System.Windows.Forms.Button DugmeOtkazi;
    }
}