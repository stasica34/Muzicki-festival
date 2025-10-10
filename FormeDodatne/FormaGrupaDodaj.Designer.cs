namespace Muzicki_festival.FormeDodatne
{
    partial class FormaGrupaDodaj
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.labelDrzava = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnAgencijaOrganizator = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.17647F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 1);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(917, 509);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(385, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(529, 249);
            this.dataGridView1.TabIndex = 12;
            // 
            // labelNaziv
            // 
            this.labelNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(165, 117);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(51, 20);
            this.labelNaziv.TabIndex = 0;
            this.labelNaziv.Text = "Naziv:";
            // 
            // labelDrzava
            // 
            this.labelDrzava.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDrzava.AutoSize = true;
            this.labelDrzava.Location = new System.Drawing.Point(112, 371);
            this.labelDrzava.Name = "labelDrzava";
            this.labelDrzava.Size = new System.Drawing.Size(158, 20);
            this.labelDrzava.TabIndex = 1;
            this.labelDrzava.Text = "Agencija organizator:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNaziv.Location = new System.Drawing.Point(524, 114);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(250, 26);
            this.txtNaziv.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnSacuvaj, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnOtkazi, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAgencijaOrganizator, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 509);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(917, 104);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvaj.Location = new System.Drawing.Point(66, 20);
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
            this.btnOtkazi.Location = new System.Drawing.Point(677, 20);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(172, 64);
            this.btnOtkazi.TabIndex = 1;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // btnAgencijaOrganizator
            // 
            this.btnAgencijaOrganizator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgencijaOrganizator.Location = new System.Drawing.Point(371, 20);
            this.btnAgencijaOrganizator.Name = "btnAgencijaOrganizator";
            this.btnAgencijaOrganizator.Size = new System.Drawing.Size(172, 64);
            this.btnAgencijaOrganizator.TabIndex = 10;
            this.btnAgencijaOrganizator.Text = "Dodaj agenciju";
            this.btnAgencijaOrganizator.UseVisualStyleBackColor = true;
            this.btnAgencijaOrganizator.Click += new System.EventHandler(this.btnAgencijaOrganizator_Click);
            // 
            // FormaGrupaDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 613);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormaGrupaDodaj";
            this.Text = "FormaGrupaDodaj";
            this.Load += new System.EventHandler(this.FormaGrupaDodaj_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button btnAgencijaOrganizator;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}