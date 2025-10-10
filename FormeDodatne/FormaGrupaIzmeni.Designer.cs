namespace Muzicki_festival.FormeDodatne
{
    partial class FormaGrupaIzmeni
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
            this.labelDrzava = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.txtAgencijaOrganizator = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.17647F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel1.Controls.Add(this.txtAgencijaOrganizator, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelNaziv, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelDrzava, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNaziv, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1001, 509);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // labelNaziv
            // 
            this.labelNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(183, 117);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(51, 20);
            this.labelNaziv.TabIndex = 0;
            this.labelNaziv.Text = "Naziv:";
            // 
            // labelDrzava
            // 
            this.labelDrzava.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDrzava.AutoSize = true;
            this.labelDrzava.Location = new System.Drawing.Point(129, 371);
            this.labelDrzava.Name = "labelDrzava";
            this.labelDrzava.Size = new System.Drawing.Size(158, 20);
            this.labelDrzava.TabIndex = 1;
            this.labelDrzava.Text = "Agencija organizator:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNaziv.Location = new System.Drawing.Point(584, 114);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(250, 26);
            this.txtNaziv.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnSacuvaj, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnOtkazi, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 507);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1001, 104);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvaj.Location = new System.Drawing.Point(164, 20);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(172, 64);
            this.btnSacuvaj.TabIndex = 0;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOtkazi.Location = new System.Drawing.Point(664, 20);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(172, 64);
            this.btnOtkazi.TabIndex = 1;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // txtAgencijaOrganizator
            // 
            this.txtAgencijaOrganizator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAgencijaOrganizator.Location = new System.Drawing.Point(584, 368);
            this.txtAgencijaOrganizator.Name = "txtAgencijaOrganizator";
            this.txtAgencijaOrganizator.Size = new System.Drawing.Size(250, 26);
            this.txtAgencijaOrganizator.TabIndex = 8;
            // 
            // FormaGrupaIzmeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 611);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "FormaGrupaIzmeni";
            this.Text = "FormaGrupaIzmeni";
            this.Load += new System.EventHandler(this.FormaGrupaIzmeni_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.Label labelDrzava;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.TextBox txtAgencijaOrganizator;
    }
}