namespace Muzicki_festival.Forme
{
    partial class FormaLokacijaDodaj
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GPS = new System.Windows.Forms.TextBox();
            this.MaxKapacitet = new System.Windows.Forms.NumericUpDown();
            this.Naziv = new System.Windows.Forms.TextBox();
            this.Opis = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioKombinovana = new System.Windows.Forms.RadioButton();
            this.radioZatvorena = new System.Windows.Forms.RadioButton();
            this.radioOtvorena = new System.Windows.Forms.RadioButton();
            this.DodatniPodaci = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DostupnostSedenja = new System.Windows.Forms.TextBox();
            this.Klima = new System.Windows.Forms.TextBox();
            this.TipProstora = new System.Windows.Forms.TextBox();
            this.DodajDugme = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.IzmeniLokaciju = new System.Windows.Forms.Button();
            this.DodatnaOpremaGroup = new System.Windows.Forms.GroupBox();
            this.DugmeObrisi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxKapacitet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.DodatniPodaci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.DodatnaOpremaGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.GPS);
            this.groupBox1.Controls.Add(this.MaxKapacitet);
            this.groupBox1.Controls.Add(this.Naziv);
            this.groupBox1.Controls.Add(this.Opis);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(354, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnovni Podaci";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opis";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "GPS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Max Kapacitet";
            // 
            // GPS
            // 
            this.GPS.Location = new System.Drawing.Point(160, 143);
            this.GPS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GPS.Name = "GPS";
            this.GPS.Size = new System.Drawing.Size(178, 26);
            this.GPS.TabIndex = 4;
            // 
            // MaxKapacitet
            // 
            this.MaxKapacitet.Location = new System.Drawing.Point(160, 198);
            this.MaxKapacitet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaxKapacitet.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MaxKapacitet.Name = "MaxKapacitet";
            this.MaxKapacitet.Size = new System.Drawing.Size(180, 26);
            this.MaxKapacitet.TabIndex = 3;
            // 
            // Naziv
            // 
            this.Naziv.Location = new System.Drawing.Point(160, 40);
            this.Naziv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Naziv.Name = "Naziv";
            this.Naziv.Size = new System.Drawing.Size(178, 26);
            this.Naziv.TabIndex = 1;
            // 
            // Opis
            // 
            this.Opis.Location = new System.Drawing.Point(160, 89);
            this.Opis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Opis.Name = "Opis";
            this.Opis.Size = new System.Drawing.Size(178, 26);
            this.Opis.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioKombinovana);
            this.groupBox2.Controls.Add(this.radioZatvorena);
            this.groupBox2.Controls.Add(this.radioOtvorena);
            this.groupBox2.Location = new System.Drawing.Point(429, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(387, 260);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tip lokacije";
            // 
            // radioKombinovana
            // 
            this.radioKombinovana.AutoSize = true;
            this.radioKombinovana.Location = new System.Drawing.Point(129, 171);
            this.radioKombinovana.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioKombinovana.Name = "radioKombinovana";
            this.radioKombinovana.Size = new System.Drawing.Size(130, 24);
            this.radioKombinovana.TabIndex = 2;
            this.radioKombinovana.TabStop = true;
            this.radioKombinovana.Text = "Kombinovana";
            this.radioKombinovana.UseVisualStyleBackColor = true;
            this.radioKombinovana.CheckedChanged += new System.EventHandler(this.radioKombinovana_CheckedChanged);
            // 
            // radioZatvorena
            // 
            this.radioZatvorena.AutoSize = true;
            this.radioZatvorena.Location = new System.Drawing.Point(129, 114);
            this.radioZatvorena.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioZatvorena.Name = "radioZatvorena";
            this.radioZatvorena.Size = new System.Drawing.Size(106, 24);
            this.radioZatvorena.TabIndex = 1;
            this.radioZatvorena.TabStop = true;
            this.radioZatvorena.Text = "Zatvorena";
            this.radioZatvorena.UseVisualStyleBackColor = true;
            this.radioZatvorena.CheckedChanged += new System.EventHandler(this.radioZatvorena_CheckedChanged);
            // 
            // radioOtvorena
            // 
            this.radioOtvorena.AutoSize = true;
            this.radioOtvorena.Location = new System.Drawing.Point(129, 58);
            this.radioOtvorena.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioOtvorena.Name = "radioOtvorena";
            this.radioOtvorena.Size = new System.Drawing.Size(99, 24);
            this.radioOtvorena.TabIndex = 0;
            this.radioOtvorena.TabStop = true;
            this.radioOtvorena.Text = "Otvorena";
            this.radioOtvorena.UseVisualStyleBackColor = true;
            this.radioOtvorena.CheckedChanged += new System.EventHandler(this.radioOtvorena_CheckedChanged);
            // 
            // DodatniPodaci
            // 
            this.DodatniPodaci.Controls.Add(this.label7);
            this.DodatniPodaci.Controls.Add(this.label6);
            this.DodatniPodaci.Controls.Add(this.label5);
            this.DodatniPodaci.Controls.Add(this.DostupnostSedenja);
            this.DodatniPodaci.Controls.Add(this.Klima);
            this.DodatniPodaci.Controls.Add(this.TipProstora);
            this.DodatniPodaci.Location = new System.Drawing.Point(879, 18);
            this.DodatniPodaci.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DodatniPodaci.Name = "DodatniPodaci";
            this.DodatniPodaci.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DodatniPodaci.Size = new System.Drawing.Size(376, 260);
            this.DodatniPodaci.TabIndex = 1;
            this.DodatniPodaci.TabStop = false;
            this.DodatniPodaci.Text = "Dodatni Podaci";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 192);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Dostupnost sedenja";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 125);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Klima";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tip Prostora";
            // 
            // DostupnostSedenja
            // 
            this.DostupnostSedenja.Location = new System.Drawing.Point(182, 188);
            this.DostupnostSedenja.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DostupnostSedenja.Name = "DostupnostSedenja";
            this.DostupnostSedenja.Size = new System.Drawing.Size(148, 26);
            this.DostupnostSedenja.TabIndex = 2;
            // 
            // Klima
            // 
            this.Klima.Location = new System.Drawing.Point(182, 114);
            this.Klima.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Klima.Name = "Klima";
            this.Klima.Size = new System.Drawing.Size(148, 26);
            this.Klima.TabIndex = 1;
            // 
            // TipProstora
            // 
            this.TipProstora.Location = new System.Drawing.Point(182, 40);
            this.TipProstora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TipProstora.Name = "TipProstora";
            this.TipProstora.Size = new System.Drawing.Size(148, 26);
            this.TipProstora.TabIndex = 0;
            // 
            // DodajDugme
            // 
            this.DodajDugme.Location = new System.Drawing.Point(18, 305);
            this.DodajDugme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DodajDugme.Name = "DodajDugme";
            this.DodajDugme.Size = new System.Drawing.Size(152, 65);
            this.DodajDugme.TabIndex = 3;
            this.DodajDugme.Text = "Dodaj";
            this.DodajDugme.UseVisualStyleBackColor = true;
            this.DodajDugme.Click += new System.EventHandler(this.DodajDugme_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 405);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(860, 345);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(14, 34);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(396, 345);
            this.dataGridView2.TabIndex = 6;
            // 
            // IzmeniLokaciju
            // 
            this.IzmeniLokaciju.Enabled = false;
            this.IzmeniLokaciju.Location = new System.Drawing.Point(18, 777);
            this.IzmeniLokaciju.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IzmeniLokaciju.Name = "IzmeniLokaciju";
            this.IzmeniLokaciju.Size = new System.Drawing.Size(122, 51);
            this.IzmeniLokaciju.TabIndex = 7;
            this.IzmeniLokaciju.Text = "Izmeni";
            this.IzmeniLokaciju.UseVisualStyleBackColor = true;
            this.IzmeniLokaciju.Click += new System.EventHandler(this.IzmeniLokaciju_Click);
            // 
            // DodatnaOpremaGroup
            // 
            this.DodatnaOpremaGroup.Controls.Add(this.dataGridView2);
            this.DodatnaOpremaGroup.Location = new System.Drawing.Point(879, 369);
            this.DodatnaOpremaGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DodatnaOpremaGroup.Name = "DodatnaOpremaGroup";
            this.DodatnaOpremaGroup.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DodatnaOpremaGroup.Size = new System.Drawing.Size(417, 397);
            this.DodatnaOpremaGroup.TabIndex = 8;
            this.DodatnaOpremaGroup.TabStop = false;
            this.DodatnaOpremaGroup.Text = "Dodatna oprema";
            // 
            // DugmeObrisi
            // 
            this.DugmeObrisi.Enabled = false;
            this.DugmeObrisi.Location = new System.Drawing.Point(148, 777);
            this.DugmeObrisi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DugmeObrisi.Name = "DugmeObrisi";
            this.DugmeObrisi.Size = new System.Drawing.Size(122, 51);
            this.DugmeObrisi.TabIndex = 9;
            this.DugmeObrisi.Text = "Obrisi";
            this.DugmeObrisi.UseVisualStyleBackColor = true;
            this.DugmeObrisi.Click += new System.EventHandler(this.DugmeObrisi_Click);
            // 
            // FormaLokacijaDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 846);
            this.Controls.Add(this.DugmeObrisi);
            this.Controls.Add(this.DodatnaOpremaGroup);
            this.Controls.Add(this.IzmeniLokaciju);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DodajDugme);
            this.Controls.Add(this.DodatniPodaci);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormaLokacijaDodaj";
            this.Text = "LokacijeTest";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxKapacitet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.DodatniPodaci.ResumeLayout(false);
            this.DodatniPodaci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.DodatnaOpremaGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioKombinovana;
        private System.Windows.Forms.RadioButton radioZatvorena;
        private System.Windows.Forms.RadioButton radioOtvorena;
        private System.Windows.Forms.TextBox Naziv;
        private System.Windows.Forms.TextBox Opis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GPS;
        private System.Windows.Forms.NumericUpDown MaxKapacitet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox DodatniPodaci;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DostupnostSedenja;
        private System.Windows.Forms.TextBox Klima;
        private System.Windows.Forms.TextBox TipProstora;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DodajDugme;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button IzmeniLokaciju;
        private System.Windows.Forms.GroupBox DodatnaOpremaGroup;
        private System.Windows.Forms.Button DugmeObrisi;
    }
}