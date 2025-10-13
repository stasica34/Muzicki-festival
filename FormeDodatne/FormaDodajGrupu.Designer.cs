namespace Muzicki_festival.FormeDodatne
{
    partial class FormaDodajGrupu
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
            this.cmbAgencije = new System.Windows.Forms.ComboBox();
            this.DugmeDodaj = new System.Windows.Forms.Button();
            this.DugmeOtkazi = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DugmeDodajAgenciju = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.DugmeDodaj, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.DugmeOtkazi, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(424, 171);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Agencija organizator";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNaziv.Location = new System.Drawing.Point(253, 11);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(129, 20);
            this.txtNaziv.TabIndex = 2;
            // 
            // cmbAgencije
            // 
            this.cmbAgencije.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbAgencije.FormattingEnabled = true;
            this.cmbAgencije.Location = new System.Drawing.Point(9, 29);
            this.cmbAgencije.Name = "cmbAgencije";
            this.cmbAgencije.Size = new System.Drawing.Size(125, 21);
            this.cmbAgencije.TabIndex = 3;
            // 
            // DugmeDodaj
            // 
            this.DugmeDodaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DugmeDodaj.Location = new System.Drawing.Point(68, 137);
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
            this.DugmeOtkazi.Location = new System.Drawing.Point(280, 137);
            this.DugmeOtkazi.Name = "DugmeOtkazi";
            this.DugmeOtkazi.Size = new System.Drawing.Size(75, 23);
            this.DugmeOtkazi.TabIndex = 5;
            this.DugmeOtkazi.Text = "Otkaži";
            this.DugmeOtkazi.UseVisualStyleBackColor = true;
            this.DugmeOtkazi.Click += new System.EventHandler(this.DugmeOtkazi_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.cmbAgencije, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.DugmeDodajAgenciju, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(215, 45);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(206, 79);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // DugmeDodajAgenciju
            // 
            this.DugmeDodajAgenciju.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DugmeDodajAgenciju.Location = new System.Drawing.Point(147, 10);
            this.DugmeDodajAgenciju.Name = "DugmeDodajAgenciju";
            this.DugmeDodajAgenciju.Size = new System.Drawing.Size(56, 58);
            this.DugmeDodajAgenciju.TabIndex = 4;
            this.DugmeDodajAgenciju.Text = "Dodaj novu agenciju";
            this.DugmeDodajAgenciju.UseVisualStyleBackColor = true;
            this.DugmeDodajAgenciju.Click += new System.EventHandler(this.DugmeDodajAgenciju_Click);
            // 
            // FormaDodajGrupu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 195);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormaDodajGrupu";
            this.Text = "FormaDodajGrupu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.ComboBox cmbAgencije;
        private System.Windows.Forms.Button DugmeDodaj;
        private System.Windows.Forms.Button DugmeOtkazi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button DugmeDodajAgenciju;
    }
}