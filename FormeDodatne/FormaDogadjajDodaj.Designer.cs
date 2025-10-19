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
            this.labelNaziv = new System.Windows.Forms.Label();
            this.labelTip = new System.Windows.Forms.Label();
            this.labelOpis = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.lblLokacijaNaziv = new System.Windows.Forms.Label();
            this.labelDatumiVreme2 = new System.Windows.Forms.Label();
            this.labelDatumiVreme1 = new System.Windows.Forms.Label();
            this.dtpKraj = new System.Windows.Forms.DateTimePicker();
            this.dtpPocetak = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGps = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbLokacija = new System.Windows.Forms.ComboBox();
            this.btnDodajLokacija = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.labelNaziv, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelTip, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelOpis, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNaziv, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtOpis, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbTip, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblLokacijaNaziv, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelDatumiVreme2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelDatumiVreme1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtpKraj, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.dtpPocetak, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtGps, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(689, 363);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // labelNaziv
            // 
            this.labelNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(84, 19);
            this.labelNaziv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(37, 13);
            this.labelNaziv.TabIndex = 0;
            this.labelNaziv.Text = "Naziv:";
            // 
            // labelTip
            // 
            this.labelTip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTip.AutoSize = true;
            this.labelTip.Location = new System.Drawing.Point(90, 70);
            this.labelTip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(25, 13);
            this.labelTip.TabIndex = 1;
            this.labelTip.Text = "Tip:";
            // 
            // labelOpis
            // 
            this.labelOpis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOpis.AutoSize = true;
            this.labelOpis.Location = new System.Drawing.Point(87, 121);
            this.labelOpis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOpis.Name = "labelOpis";
            this.labelOpis.Size = new System.Drawing.Size(31, 13);
            this.labelOpis.TabIndex = 2;
            this.labelOpis.Text = "Opis:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNaziv.Location = new System.Drawing.Point(363, 15);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(2);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(168, 20);
            this.txtNaziv.TabIndex = 7;
            // 
            // txtOpis
            // 
            this.txtOpis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOpis.Location = new System.Drawing.Point(363, 117);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(2);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(168, 20);
            this.txtOpis.TabIndex = 8;
            // 
            // cmbTip
            // 
            this.cmbTip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Location = new System.Drawing.Point(361, 66);
            this.cmbTip.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(173, 21);
            this.cmbTip.TabIndex = 13;
            // 
            // lblLokacijaNaziv
            // 
            this.lblLokacijaNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLokacijaNaziv.AutoSize = true;
            this.lblLokacijaNaziv.Location = new System.Drawing.Point(78, 328);
            this.lblLokacijaNaziv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLokacijaNaziv.Name = "lblLokacijaNaziv";
            this.lblLokacijaNaziv.Size = new System.Drawing.Size(50, 13);
            this.lblLokacijaNaziv.TabIndex = 5;
            this.lblLokacijaNaziv.Text = "Lokacija:";
            // 
            // labelDatumiVreme2
            // 
            this.labelDatumiVreme2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDatumiVreme2.AutoSize = true;
            this.labelDatumiVreme2.Location = new System.Drawing.Point(51, 274);
            this.labelDatumiVreme2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDatumiVreme2.Name = "labelDatumiVreme2";
            this.labelDatumiVreme2.Size = new System.Drawing.Size(104, 13);
            this.labelDatumiVreme2.TabIndex = 4;
            this.labelDatumiVreme2.Text = "Datum i vreme kraja:";
            // 
            // labelDatumiVreme1
            // 
            this.labelDatumiVreme1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDatumiVreme1.AutoSize = true;
            this.labelDatumiVreme1.Location = new System.Drawing.Point(43, 223);
            this.labelDatumiVreme1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDatumiVreme1.Name = "labelDatumiVreme1";
            this.labelDatumiVreme1.Size = new System.Drawing.Size(120, 13);
            this.labelDatumiVreme1.TabIndex = 3;
            this.labelDatumiVreme1.Text = "Datum i vreme pocetka:";
            // 
            // dtpKraj
            // 
            this.dtpKraj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpKraj.Location = new System.Drawing.Point(348, 270);
            this.dtpKraj.Margin = new System.Windows.Forms.Padding(2);
            this.dtpKraj.Name = "dtpKraj";
            this.dtpKraj.Size = new System.Drawing.Size(198, 20);
            this.dtpKraj.TabIndex = 12;
            // 
            // dtpPocetak
            // 
            this.dtpPocetak.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpPocetak.Location = new System.Drawing.Point(348, 219);
            this.dtpPocetak.Margin = new System.Windows.Forms.Padding(2);
            this.dtpPocetak.Name = "dtpPocetak";
            this.dtpPocetak.Size = new System.Drawing.Size(198, 20);
            this.dtpPocetak.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "GPS:";
            // 
            // txtGps
            // 
            this.txtGps.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGps.Location = new System.Drawing.Point(363, 168);
            this.txtGps.Name = "txtGps";
            this.txtGps.Size = new System.Drawing.Size(168, 20);
            this.txtGps.TabIndex = 16;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.cmbLokacija, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnDodajLokacija, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(209, 309);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(477, 51);
            this.tableLayoutPanel3.TabIndex = 17;
            // 
            // cmbLokacija
            // 
            this.cmbLokacija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbLokacija.FormattingEnabled = true;
            this.cmbLokacija.Location = new System.Drawing.Point(29, 15);
            this.cmbLokacija.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLokacija.Name = "cmbLokacija";
            this.cmbLokacija.Size = new System.Drawing.Size(179, 21);
            this.cmbLokacija.TabIndex = 14;
            // 
            // btnDodajLokacija
            // 
            this.btnDodajLokacija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodajLokacija.Location = new System.Drawing.Point(300, 4);
            this.btnDodajLokacija.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajLokacija.Name = "btnDodajLokacija";
            this.btnDodajLokacija.Size = new System.Drawing.Size(115, 42);
            this.btnDodajLokacija.TabIndex = 2;
            this.btnDodajLokacija.Text = "Dodaj Lokaciju";
            this.btnDodajLokacija.UseVisualStyleBackColor = true;
            this.btnDodajLokacija.Click += new System.EventHandler(this.btnDodajLokacija_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnOtkazi, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSacuvaj, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 365);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(689, 68);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOtkazi.Location = new System.Drawing.Point(459, 13);
            this.btnOtkazi.Margin = new System.Windows.Forms.Padding(2);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(115, 42);
            this.btnOtkazi.TabIndex = 1;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvaj.Location = new System.Drawing.Point(114, 13);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(115, 42);
            this.btnSacuvaj.TabIndex = 0;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // FormaDogadjajDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 432);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormaDogadjajDodaj";
            this.Text = "FormaDogadjajDodaj";
            this.Load += new System.EventHandler(this.FormaDogadjajDodaj_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGps;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}