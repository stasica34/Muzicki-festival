namespace Muzicki_festival.Forme
{
    partial class FormaDogadjajDodaj
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
            this.btnDodajLokacija = new System.Windows.Forms.Button();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.labelTip = new System.Windows.Forms.Label();
            this.labelOpis = new System.Windows.Forms.Label();
            this.labelDatumiVreme1 = new System.Windows.Forms.Label();
            this.labelDatumiVreme2 = new System.Windows.Forms.Label();
            this.lblLokacijaNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.dtpPocetak = new System.Windows.Forms.DateTimePicker();
            this.dtpKraj = new System.Windows.Forms.DateTimePicker();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.cmbLokacija = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.btnDodajLokacija, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelNaziv, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelTip, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelOpis, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelDatumiVreme1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelDatumiVreme2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblLokacijaNaziv, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtNaziv, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtOpis, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtpPocetak, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtpKraj, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbTip, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbLokacija, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1033, 559);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btnDodajLokacija
            // 
            this.btnDodajLokacija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodajLokacija.Location = new System.Drawing.Point(585, 484);
            this.btnDodajLokacija.Name = "btnDodajLokacija";
            this.btnDodajLokacija.Size = new System.Drawing.Size(172, 64);
            this.btnDodajLokacija.TabIndex = 2;
            this.btnDodajLokacija.Text = "Dodaj Lokaciju";
            this.btnDodajLokacija.UseVisualStyleBackColor = true;
            this.btnDodajLokacija.Click += new System.EventHandler(this.btnDodajLokacija_Click);
            // 
            // labelNaziv
            // 
            this.labelNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(129, 29);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(51, 20);
            this.labelNaziv.TabIndex = 0;
            this.labelNaziv.Text = "Naziv:";
            // 
            // labelTip
            // 
            this.labelTip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTip.AutoSize = true;
            this.labelTip.Location = new System.Drawing.Point(137, 108);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(34, 20);
            this.labelTip.TabIndex = 1;
            this.labelTip.Text = "Tip:";
            // 
            // labelOpis
            // 
            this.labelOpis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOpis.AutoSize = true;
            this.labelOpis.Location = new System.Drawing.Point(132, 187);
            this.labelOpis.Name = "labelOpis";
            this.labelOpis.Size = new System.Drawing.Size(45, 20);
            this.labelOpis.TabIndex = 2;
            this.labelOpis.Text = "Opis:";
            // 
            // labelDatumiVreme1
            // 
            this.labelDatumiVreme1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDatumiVreme1.AutoSize = true;
            this.labelDatumiVreme1.Location = new System.Drawing.Point(66, 266);
            this.labelDatumiVreme1.Name = "labelDatumiVreme1";
            this.labelDatumiVreme1.Size = new System.Drawing.Size(176, 20);
            this.labelDatumiVreme1.TabIndex = 3;
            this.labelDatumiVreme1.Text = "Datum i vreme pocetka:";
            // 
            // labelDatumiVreme2
            // 
            this.labelDatumiVreme2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDatumiVreme2.AutoSize = true;
            this.labelDatumiVreme2.Location = new System.Drawing.Point(78, 345);
            this.labelDatumiVreme2.Name = "labelDatumiVreme2";
            this.labelDatumiVreme2.Size = new System.Drawing.Size(153, 20);
            this.labelDatumiVreme2.TabIndex = 4;
            this.labelDatumiVreme2.Text = "Datum i vreme kraja:";
            // 
            // lblLokacijaNaziv
            // 
            this.lblLokacijaNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLokacijaNaziv.AutoSize = true;
            this.lblLokacijaNaziv.Location = new System.Drawing.Point(101, 424);
            this.lblLokacijaNaziv.Name = "lblLokacijaNaziv";
            this.lblLokacijaNaziv.Size = new System.Drawing.Size(107, 20);
            this.lblLokacijaNaziv.TabIndex = 5;
            this.lblLokacijaNaziv.Text = "Lokacija naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNaziv.Location = new System.Drawing.Point(546, 26);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(250, 26);
            this.txtNaziv.TabIndex = 7;
            // 
            // txtOpis
            // 
            this.txtOpis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOpis.Location = new System.Drawing.Point(546, 184);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(250, 26);
            this.txtOpis.TabIndex = 8;
            // 
            // dtpPocetak
            // 
            this.dtpPocetak.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpPocetak.Location = new System.Drawing.Point(523, 263);
            this.dtpPocetak.Name = "dtpPocetak";
            this.dtpPocetak.Size = new System.Drawing.Size(295, 26);
            this.dtpPocetak.TabIndex = 11;
            // 
            // dtpKraj
            // 
            this.dtpKraj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpKraj.Location = new System.Drawing.Point(523, 342);
            this.dtpKraj.Name = "dtpKraj";
            this.dtpKraj.Size = new System.Drawing.Size(295, 26);
            this.dtpKraj.TabIndex = 12;
            // 
            // cmbTip
            // 
            this.cmbTip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Location = new System.Drawing.Point(537, 104);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(267, 28);
            this.cmbTip.TabIndex = 13;
            // 
            // cmbLokacija
            // 
            this.cmbLokacija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbLokacija.FormattingEnabled = true;
            this.cmbLokacija.Location = new System.Drawing.Point(537, 420);
            this.cmbLokacija.Name = "cmbLokacija";
            this.cmbLokacija.Size = new System.Drawing.Size(267, 28);
            this.cmbLokacija.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnOtkazi, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSacuvaj, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 561);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1033, 104);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOtkazi.Location = new System.Drawing.Point(688, 20);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(172, 64);
            this.btnOtkazi.TabIndex = 1;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvaj.Location = new System.Drawing.Point(172, 20);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(172, 64);
            this.btnSacuvaj.TabIndex = 0;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // FormaDogadjajDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 665);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormaDogadjajDodaj";
            this.Text = "FormaDogadjajDodaj";
            this.Load += new System.EventHandler(this.FormaDogadjajDodaj_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.Label labelOpis;
        private System.Windows.Forms.Label labelDatumiVreme1;
        private System.Windows.Forms.Label labelDatumiVreme2;
        private System.Windows.Forms.Label lblLokacijaNaziv;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.DateTimePicker dtpPocetak;
        private System.Windows.Forms.DateTimePicker dtpKraj;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.ComboBox cmbLokacija;
        private System.Windows.Forms.Button btnDodajLokacija;
    }
}