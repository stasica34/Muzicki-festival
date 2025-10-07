namespace Muzicki_festival.FormeDodatne
{
    partial class FormaUlazniceDodaj
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
            this.labelNaziv = new System.Windows.Forms.Label();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbKupac = new System.Windows.Forms.ComboBox();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelaCena = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudCena = new System.Windows.Forms.NumericUpDown();
            this.cmbPlacanje = new System.Windows.Forms.ComboBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCena)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNaziv
            // 
            this.labelNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(65, 24);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(128, 20);
            this.labelNaziv.TabIndex = 0;
            this.labelNaziv.Text = "Datum kupovine:";
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOtkazi.Location = new System.Drawing.Point(563, 7);
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
            this.btnSacuvaj.Location = new System.Drawing.Point(130, 7);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(172, 64);
            this.btnSacuvaj.TabIndex = 0;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnOtkazi, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSacuvaj, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 478);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(866, 79);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDatum.Location = new System.Drawing.Point(415, 21);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(295, 26);
            this.dtpDatum.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.cmbKupac, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmbTip, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelaCena, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelNaziv, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpDatum, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.nudCena, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbPlacanje, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNaziv, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnDodaj, 1, 6);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(866, 477);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // cmbKupac
            // 
            this.cmbKupac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbKupac.FormattingEnabled = true;
            this.cmbKupac.Location = new System.Drawing.Point(436, 360);
            this.cmbKupac.Name = "cmbKupac";
            this.cmbKupac.Size = new System.Drawing.Size(252, 28);
            this.cmbKupac.TabIndex = 23;
            // 
            // cmbTip
            // 
            this.cmbTip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Location = new System.Drawing.Point(436, 292);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(252, 28);
            this.cmbTip.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tip:";
            // 
            // labelaCena
            // 
            this.labelaCena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelaCena.AutoSize = true;
            this.labelaCena.Location = new System.Drawing.Point(104, 92);
            this.labelaCena.Name = "labelaCena";
            this.labelaCena.Size = new System.Drawing.Size(51, 20);
            this.labelaCena.TabIndex = 12;
            this.labelaCena.Text = "Cena:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nacin placanja:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Naziv:";
            // 
            // nudCena
            // 
            this.nudCena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudCena.Location = new System.Drawing.Point(489, 89);
            this.nudCena.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudCena.Name = "nudCena";
            this.nudCena.Size = new System.Drawing.Size(146, 26);
            this.nudCena.TabIndex = 16;
            // 
            // cmbPlacanje
            // 
            this.cmbPlacanje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPlacanje.FormattingEnabled = true;
            this.cmbPlacanje.Location = new System.Drawing.Point(436, 156);
            this.cmbPlacanje.Name = "cmbPlacanje";
            this.cmbPlacanje.Size = new System.Drawing.Size(252, 28);
            this.cmbPlacanje.TabIndex = 17;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNaziv.Location = new System.Drawing.Point(421, 225);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(282, 26);
            this.txtNaziv.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Kupac:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodaj.Location = new System.Drawing.Point(476, 411);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(172, 63);
            this.btnDodaj.TabIndex = 20;
            this.btnDodaj.Text = "Novi kupac";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // FormaUlazniceDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 557);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormaUlazniceDodaj";
            this.Text = "FormaUlazniceDodaj";
            this.Load += new System.EventHandler(this.FormaUlazniceDodaj_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCena)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelaCena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudCena;
        private System.Windows.Forms.ComboBox cmbPlacanje;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbKupac;
    }
}