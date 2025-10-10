namespace Muzicki_festival.FormeDodatne
{
    partial class FormaAgencijaOrganizatorDodaj
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
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.LabelNaziv = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.17647F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel1.Controls.Add(this.txtAdresa, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LabelNaziv, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAdresa, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNaziv, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(965, 509);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdresa.Location = new System.Drawing.Point(558, 368);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(250, 26);
            this.txtAdresa.TabIndex = 15;
            // 
            // LabelNaziv
            // 
            this.LabelNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelNaziv.AutoSize = true;
            this.LabelNaziv.Location = new System.Drawing.Point(181, 117);
            this.LabelNaziv.Name = "LabelNaziv";
            this.LabelNaziv.Size = new System.Drawing.Size(40, 20);
            this.LabelNaziv.TabIndex = 0;
            this.LabelNaziv.Text = "Ime:";
            // 
            // lblAdresa
            // 
            this.lblAdresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(169, 371);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(64, 20);
            this.lblAdresa.TabIndex = 1;
            this.lblAdresa.Text = "Adresa:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNaziv.Location = new System.Drawing.Point(558, 114);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(250, 26);
            this.txtNaziv.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.58366F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.41634F));
            this.tableLayoutPanel2.Controls.Add(this.btnOtkazi, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSacuvaj, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 512);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(965, 104);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOtkazi.Location = new System.Drawing.Point(640, 20);
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
            this.btnSacuvaj.Location = new System.Drawing.Point(158, 20);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(172, 64);
            this.btnSacuvaj.TabIndex = 0;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // FormaAgencijaOrganizatorDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 616);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "FormaAgencijaOrganizatorDodaj";
            this.Text = "FormaAgencijaOrganizatorDodaj";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label LabelNaziv;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnSacuvaj;
    }
}