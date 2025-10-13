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
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaAgencije)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66833F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66833F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66833F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.995F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(455, 269);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresa:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNaziv.Location = new System.Drawing.Point(263, 12);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(155, 20);
            this.txtNaziv.TabIndex = 2;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdresa.Location = new System.Drawing.Point(263, 56);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(155, 20);
            this.txtAdresa.TabIndex = 3;
            // 
            // DugmeDodaj
            // 
            this.DugmeDodaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DugmeDodaj.Location = new System.Drawing.Point(76, 98);
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
            this.DugmeOtkazi.Location = new System.Drawing.Point(303, 98);
            this.DugmeOtkazi.Name = "DugmeOtkazi";
            this.DugmeOtkazi.Size = new System.Drawing.Size(75, 23);
            this.DugmeOtkazi.TabIndex = 5;
            this.DugmeOtkazi.Text = "Otkazi";
            this.DugmeOtkazi.UseVisualStyleBackColor = true;
            this.DugmeOtkazi.Click += new System.EventHandler(this.DugmeOtkazi_Click);
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(3, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 131);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(440, 109);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // TabelaAgencije
            // 
            this.TabelaAgencije.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TabelaAgencije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaAgencije.Location = new System.Drawing.Point(245, 8);
            this.TabelaAgencije.Name = "TabelaAgencije";
            this.tableLayoutPanel2.SetRowSpan(this.TabelaAgencije, 2);
            this.TabelaAgencije.Size = new System.Drawing.Size(170, 93);
            this.TabelaAgencije.TabIndex = 0;
            this.TabelaAgencije.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelaAgencije_CellClick);
            // 
            // ObrisiDugme
            // 
            this.ObrisiDugme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ObrisiDugme.Location = new System.Drawing.Point(58, 13);
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
            this.IzmeniDugme.Location = new System.Drawing.Point(58, 68);
            this.IzmeniDugme.Name = "IzmeniDugme";
            this.IzmeniDugme.Size = new System.Drawing.Size(104, 27);
            this.IzmeniDugme.TabIndex = 2;
            this.IzmeniDugme.Text = "Izmeni";
            this.IzmeniDugme.UseVisualStyleBackColor = true;
            this.IzmeniDugme.Click += new System.EventHandler(this.IzmeniDugme_Click);
            // 
            // FormaDodajAgencijuOrganizator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 293);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormaDodajAgencijuOrganizator";
            this.Text = "FormaDodajAgencijuOrganizator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaAgencije)).EndInit();
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
    }
}