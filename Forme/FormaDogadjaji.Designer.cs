namespace Muzicki_festival.Forme
{
    partial class FormaDogadjaji
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
            this.cmdDodavanje = new System.Windows.Forms.Button();
            this.cmd_Nazad = new System.Windows.Forms.Button();
            this.cmdDodavanje2 = new System.Windows.Forms.Button();
            this.TabelaDogadjaj = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIzvodjac = new System.Windows.Forms.Button();
            this.cmdIzmeni = new System.Windows.Forms.Button();
            this.cmdUcitavanjeDogadjaja = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaDogadjaj)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdDodavanje
            // 
            this.cmdDodavanje.Location = new System.Drawing.Point(131, 8);
            this.cmdDodavanje.Margin = new System.Windows.Forms.Padding(2);
            this.cmdDodavanje.Name = "cmdDodavanje";
            this.cmdDodavanje.Size = new System.Drawing.Size(119, 37);
            this.cmdDodavanje.TabIndex = 3;
            this.cmdDodavanje.Text = "Dodavanje";
            this.cmdDodavanje.UseVisualStyleBackColor = true;
            this.cmdDodavanje.Click += new System.EventHandler(this.cmdDodavanje_Click);
            // 
            // cmd_Nazad
            // 
            this.cmd_Nazad.Location = new System.Drawing.Point(708, 8);
            this.cmd_Nazad.Margin = new System.Windows.Forms.Padding(2);
            this.cmd_Nazad.Name = "cmd_Nazad";
            this.cmd_Nazad.Size = new System.Drawing.Size(113, 37);
            this.cmd_Nazad.TabIndex = 4;
            this.cmd_Nazad.Text = "Nazad";
            this.cmd_Nazad.UseVisualStyleBackColor = true;
            this.cmd_Nazad.Click += new System.EventHandler(this.cmd_Nazad_Click);
            // 
            // cmdDodavanje2
            // 
            this.cmdDodavanje2.Location = new System.Drawing.Point(591, 8);
            this.cmdDodavanje2.Margin = new System.Windows.Forms.Padding(2);
            this.cmdDodavanje2.Name = "cmdDodavanje2";
            this.cmdDodavanje2.Size = new System.Drawing.Size(113, 37);
            this.cmdDodavanje2.TabIndex = 5;
            this.cmdDodavanje2.Text = "Kupi ulaznicu";
            this.cmdDodavanje2.UseVisualStyleBackColor = true;
            this.cmdDodavanje2.Click += new System.EventHandler(this.cmdDodavanje2_Click);
            // 
            // TabelaDogadjaj
            // 
            this.TabelaDogadjaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaDogadjaj.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TabelaDogadjaj.Location = new System.Drawing.Point(0, 76);
            this.TabelaDogadjaj.Margin = new System.Windows.Forms.Padding(2);
            this.TabelaDogadjaj.Name = "TabelaDogadjaj";
            this.TabelaDogadjaj.RowHeadersWidth = 62;
            this.TabelaDogadjaj.RowTemplate.Height = 28;
            this.TabelaDogadjaj.Size = new System.Drawing.Size(831, 359);
            this.TabelaDogadjaj.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnIzvodjac);
            this.panel1.Controls.Add(this.cmdDodavanje);
            this.panel1.Controls.Add(this.cmdIzmeni);
            this.panel1.Controls.Add(this.cmdUcitavanjeDogadjaja);
            this.panel1.Controls.Add(this.btnObrisi);
            this.panel1.Controls.Add(this.cmd_Nazad);
            this.panel1.Controls.Add(this.cmdDodavanje2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 72);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnIzvodjac
            // 
            this.btnIzvodjac.Location = new System.Drawing.Point(475, 8);
            this.btnIzvodjac.Margin = new System.Windows.Forms.Padding(2);
            this.btnIzvodjac.Name = "btnIzvodjac";
            this.btnIzvodjac.Size = new System.Drawing.Size(113, 37);
            this.btnIzvodjac.TabIndex = 9;
            this.btnIzvodjac.Text = "Dodaj Izvodjaca";
            this.btnIzvodjac.UseVisualStyleBackColor = true;
            this.btnIzvodjac.Click += new System.EventHandler(this.btnIzvodjac_Click_1);
            // 
            // cmdIzmeni
            // 
            this.cmdIzmeni.Location = new System.Drawing.Point(254, 8);
            this.cmdIzmeni.Margin = new System.Windows.Forms.Padding(2);
            this.cmdIzmeni.Name = "cmdIzmeni";
            this.cmdIzmeni.Size = new System.Drawing.Size(100, 37);
            this.cmdIzmeni.TabIndex = 8;
            this.cmdIzmeni.Text = "Izmeni Dogadjaj";
            this.cmdIzmeni.UseVisualStyleBackColor = true;
            this.cmdIzmeni.Click += new System.EventHandler(this.cmdIzmeni_Click);
            // 
            // cmdUcitavanjeDogadjaja
            // 
            this.cmdUcitavanjeDogadjaja.Location = new System.Drawing.Point(8, 8);
            this.cmdUcitavanjeDogadjaja.Margin = new System.Windows.Forms.Padding(2);
            this.cmdUcitavanjeDogadjaja.Name = "cmdUcitavanjeDogadjaja";
            this.cmdUcitavanjeDogadjaja.Size = new System.Drawing.Size(119, 37);
            this.cmdUcitavanjeDogadjaja.TabIndex = 2;
            this.cmdUcitavanjeDogadjaja.Text = "Ucitavanje";
            this.cmdUcitavanjeDogadjaja.UseVisualStyleBackColor = true;
            this.cmdUcitavanjeDogadjaja.Click += new System.EventHandler(this.cmdUcitavanjeDogadjaja_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(358, 8);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(2);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(113, 37);
            this.btnObrisi.TabIndex = 8;
            this.btnObrisi.Text = "Obrisi\r\n Dogadjaj";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // FormaDogadjaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(831, 435);
            this.Controls.Add(this.TabelaDogadjaj);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormaDogadjaji";
            this.Text = "FormaDogadjaji";
            this.Load += new System.EventHandler(this.FormaDogadjaji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaDogadjaj)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdDodavanje;
        private System.Windows.Forms.Button cmd_Nazad;
        private System.Windows.Forms.Button cmdDodavanje2;
        private System.Windows.Forms.DataGridView TabelaDogadjaj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button cmdIzmeni;
        private System.Windows.Forms.Button cmdUcitavanjeDogadjaja;
        private System.Windows.Forms.Button btnIzvodjac;
    }
}