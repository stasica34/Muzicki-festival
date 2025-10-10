namespace Muzicki_festival.FormeDodatne
{
    partial class FormaPosetilacDodaj
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
            this.lableIme = new System.Windows.Forms.Label();
            this.labelDrzava = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lableIme
            // 
            this.lableIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lableIme.AutoSize = true;
            this.lableIme.Location = new System.Drawing.Point(171, 74);
            this.lableIme.Name = "lableIme";
            this.lableIme.Size = new System.Drawing.Size(40, 20);
            this.lableIme.TabIndex = 0;
            this.lableIme.Text = "Ime:";
            // 
            // labelDrzava
            // 
            this.labelDrzava.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDrzava.AutoSize = true;
            this.labelDrzava.Location = new System.Drawing.Point(156, 243);
            this.labelDrzava.Name = "labelDrzava";
            this.labelDrzava.Size = new System.Drawing.Size(70, 20);
            this.labelDrzava.TabIndex = 1;
            this.labelDrzava.Text = "Prezime:";
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(165, 413);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(52, 20);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.58366F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.41634F));
            this.tableLayoutPanel2.Controls.Add(this.btnOtkazi, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSacuvaj, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 509);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(917, 104);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOtkazi.Location = new System.Drawing.Point(604, 20);
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
            this.btnSacuvaj.Location = new System.Drawing.Point(145, 20);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(172, 64);
            this.btnSacuvaj.TabIndex = 0;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.17647F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel1.Controls.Add(this.txtPrezime, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lableIme, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelDrzava, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelEmail, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtIme, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(917, 509);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrezime.Location = new System.Drawing.Point(524, 240);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(250, 26);
            this.txtPrezime.TabIndex = 15;
            // 
            // txtIme
            // 
            this.txtIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIme.Location = new System.Drawing.Point(524, 71);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(250, 26);
            this.txtIme.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(524, 410);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 26);
            this.txtEmail.TabIndex = 8;
            // 
            // FormaPosetilacDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 613);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormaPosetilacDodaj";
            this.Text = "FormaPosetilacDodaj";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lableIme;
        private System.Windows.Forms.Label labelDrzava;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtEmail;
    }
}