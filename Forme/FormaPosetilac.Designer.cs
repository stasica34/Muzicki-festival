namespace Muzicki_festival.Forme
{
    partial class FormaPosetilac
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
            this.cmd_Nazad = new System.Windows.Forms.Button();
            this.cmd_Ucitavanje = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.cmdIzmeni = new System.Windows.Forms.Button();
            this.cmdDodaj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_Nazad
            // 
            this.cmd_Nazad.Location = new System.Drawing.Point(712, 13);
            this.cmd_Nazad.Name = "cmd_Nazad";
            this.cmd_Nazad.Size = new System.Drawing.Size(169, 57);
            this.cmd_Nazad.TabIndex = 4;
            this.cmd_Nazad.Text = "Nazad";
            this.cmd_Nazad.UseVisualStyleBackColor = true;
            this.cmd_Nazad.Click += new System.EventHandler(this.cmd_Nazad_Click);
            // 
            // cmd_Ucitavanje
            // 
            this.cmd_Ucitavanje.Location = new System.Drawing.Point(12, 15);
            this.cmd_Ucitavanje.Name = "cmd_Ucitavanje";
            this.cmd_Ucitavanje.Size = new System.Drawing.Size(169, 55);
            this.cmd_Ucitavanje.TabIndex = 3;
            this.cmd_Ucitavanje.Text = "Ucitavanje";
            this.cmd_Ucitavanje.UseVisualStyleBackColor = true;
            this.cmd_Ucitavanje.Click += new System.EventHandler(this.cmd_Ucitavanje_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnObrisi);
            this.panel1.Controls.Add(this.cmdIzmeni);
            this.panel1.Controls.Add(this.cmd_Ucitavanje);
            this.panel1.Controls.Add(this.cmd_Nazad);
            this.panel1.Controls.Add(this.cmdDodaj);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 83);
            this.panel1.TabIndex = 10;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(537, 15);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(169, 57);
            this.btnObrisi.TabIndex = 10;
            this.btnObrisi.Text = "Obrisi\r\n";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // cmdIzmeni
            // 
            this.cmdIzmeni.Location = new System.Drawing.Point(362, 14);
            this.cmdIzmeni.Name = "cmdIzmeni";
            this.cmdIzmeni.Size = new System.Drawing.Size(169, 57);
            this.cmdIzmeni.TabIndex = 9;
            this.cmdIzmeni.Text = "Izmeni";
            this.cmdIzmeni.UseVisualStyleBackColor = true;
            this.cmdIzmeni.Click += new System.EventHandler(this.cmdIzmeni_Click);
            // 
            // cmdDodaj
            // 
            this.cmdDodaj.Location = new System.Drawing.Point(187, 14);
            this.cmdDodaj.Name = "cmdDodaj";
            this.cmdDodaj.Size = new System.Drawing.Size(169, 57);
            this.cmdDodaj.TabIndex = 8;
            this.cmdDodaj.Text = "Dodavanje";
            this.cmdDodaj.UseVisualStyleBackColor = true;
            this.cmdDodaj.Click += new System.EventHandler(this.cmdDodaj_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(884, 396);
            this.dataGridView1.TabIndex = 11;
            // 
            // FormaPosetilac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 479);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FormaPosetilac";
            this.Text = "FormaPosetilac";
            this.Load += new System.EventHandler(this.FormaPosetilac_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_Nazad;
        private System.Windows.Forms.Button cmd_Ucitavanje;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button cmdIzmeni;
        private System.Windows.Forms.Button cmdDodaj;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}