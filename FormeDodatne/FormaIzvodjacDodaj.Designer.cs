namespace Muzicki_festival.FormeDodatne
{
    partial class FormaIzvodjacDodaj
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
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnDodajMenadzersku = new System.Windows.Forms.Button();
            this.lableIme = new System.Windows.Forms.Label();
            this.labelDrzava = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.lblKontakt = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblMenadzerska = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtKontaktOsoba = new System.Windows.Forms.TextBox();
            this.txtDrzavaPorekla = new System.Windows.Forms.TextBox();
            this.cmdMenadzerska = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvaj.Location = new System.Drawing.Point(173, 20);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(172, 64);
            this.btnSacuvaj.TabIndex = 0;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnDodajMenadzersku
            // 
            this.btnDodajMenadzersku.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodajMenadzersku.Location = new System.Drawing.Point(642, 517);
            this.btnDodajMenadzersku.Name = "btnDodajMenadzersku";
            this.btnDodajMenadzersku.Size = new System.Drawing.Size(172, 64);
            this.btnDodajMenadzersku.TabIndex = 2;
            this.btnDodajMenadzersku.Text = "Dodaj Menadzersku:";
            this.btnDodajMenadzersku.UseVisualStyleBackColor = true;
            this.btnDodajMenadzersku.Click += new System.EventHandler(this.btnDodajMenadzersku_Click);
            // 
            // lableIme
            // 
            this.lableIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lableIme.AutoSize = true;
            this.lableIme.Location = new System.Drawing.Point(194, 32);
            this.lableIme.Name = "lableIme";
            this.lableIme.Size = new System.Drawing.Size(40, 20);
            this.lableIme.TabIndex = 0;
            this.lableIme.Text = "Ime:";
            // 
            // labelDrzava
            // 
            this.labelDrzava.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDrzava.AutoSize = true;
            this.labelDrzava.Location = new System.Drawing.Point(154, 116);
            this.labelDrzava.Name = "labelDrzava";
            this.labelDrzava.Size = new System.Drawing.Size(119, 20);
            this.labelDrzava.TabIndex = 1;
            this.labelDrzava.Text = "Drzava porekla:";
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(188, 200);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(52, 20);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email:";
            // 
            // lblKontakt
            // 
            this.lblKontakt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKontakt.AutoSize = true;
            this.lblKontakt.Location = new System.Drawing.Point(156, 284);
            this.lblKontakt.Name = "lblKontakt";
            this.lblKontakt.Size = new System.Drawing.Size(116, 20);
            this.lblKontakt.TabIndex = 3;
            this.lblKontakt.Text = "Kontakt osoba:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(181, 368);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(66, 20);
            this.lblTelefon.TabIndex = 4;
            this.lblTelefon.Text = "Telefon:";
            // 
            // lblMenadzerska
            // 
            this.lblMenadzerska.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMenadzerska.AutoSize = true;
            this.lblMenadzerska.Location = new System.Drawing.Point(128, 452);
            this.lblMenadzerska.Name = "lblMenadzerska";
            this.lblMenadzerska.Size = new System.Drawing.Size(172, 20);
            this.lblMenadzerska.TabIndex = 5;
            this.lblMenadzerska.Text = "Menadzerska agencija:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.58366F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.41634F));
            this.tableLayoutPanel2.Controls.Add(this.btnOtkazi, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSacuvaj, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 593);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1026, 104);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOtkazi.Location = new System.Drawing.Point(686, 20);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(172, 64);
            this.btnOtkazi.TabIndex = 1;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // txtIme
            // 
            this.txtIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIme.Location = new System.Drawing.Point(603, 29);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(250, 26);
            this.txtIme.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(603, 197);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 26);
            this.txtEmail.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.17647F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel1.Controls.Add(this.txtTelefon, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtKontaktOsoba, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtDrzavaPorekla, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lableIme, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelDrzava, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelEmail, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblKontakt, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtIme, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTelefon, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblMenadzerska, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmdMenadzerska, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnDodajMenadzersku, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1028, 594);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefon.Location = new System.Drawing.Point(603, 365);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(250, 26);
            this.txtTelefon.TabIndex = 17;
            // 
            // txtKontaktOsoba
            // 
            this.txtKontaktOsoba.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKontaktOsoba.Location = new System.Drawing.Point(603, 281);
            this.txtKontaktOsoba.Name = "txtKontaktOsoba";
            this.txtKontaktOsoba.Size = new System.Drawing.Size(250, 26);
            this.txtKontaktOsoba.TabIndex = 16;
            // 
            // txtDrzavaPorekla
            // 
            this.txtDrzavaPorekla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDrzavaPorekla.Location = new System.Drawing.Point(603, 113);
            this.txtDrzavaPorekla.Name = "txtDrzavaPorekla";
            this.txtDrzavaPorekla.Size = new System.Drawing.Size(250, 26);
            this.txtDrzavaPorekla.TabIndex = 15;
            // 
            // cmdMenadzerska
            // 
            this.cmdMenadzerska.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdMenadzerska.FormattingEnabled = true;
            this.cmdMenadzerska.Location = new System.Drawing.Point(594, 448);
            this.cmdMenadzerska.Name = "cmdMenadzerska";
            this.cmdMenadzerska.Size = new System.Drawing.Size(267, 28);
            this.cmdMenadzerska.TabIndex = 14;
            // 
            // FormaIzvodjacDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 697);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormaIzvodjacDodaj";
            this.Text = "FormaIzvodjacDodaj";
            this.Load += new System.EventHandler(this.FormaIzvodjacDodaj_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnDodajMenadzersku;
        private System.Windows.Forms.Label lableIme;
        private System.Windows.Forms.Label labelDrzava;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label lblKontakt;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblMenadzerska;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtKontaktOsoba;
        private System.Windows.Forms.TextBox txtDrzavaPorekla;
        private System.Windows.Forms.ComboBox cmdMenadzerska;
    }
}