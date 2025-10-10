namespace Muzicki_festival.Forme
{
    partial class FormaAgencijaOrganizator
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
            this.btnUcitavanje = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.cmdIzmeni = new System.Windows.Forms.Button();
            this.cmdDodavanje = new System.Windows.Forms.Button();
            this.cmd_Nazad = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUcitavanje
            // 
            this.btnUcitavanje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUcitavanje.Location = new System.Drawing.Point(12, 17);
            this.btnUcitavanje.Name = "btnUcitavanje";
            this.btnUcitavanje.Size = new System.Drawing.Size(169, 53);
            this.btnUcitavanje.TabIndex = 1;
            this.btnUcitavanje.Text = "Ucitavanje";
            this.btnUcitavanje.UseVisualStyleBackColor = true;
            this.btnUcitavanje.Click += new System.EventHandler(this.btnUcitavanje_Click);
            // 
            // btnNazad
            // 
            this.btnNazad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNazad.Location = new System.Drawing.Point(712, 17);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(169, 53);
            this.btnNazad.TabIndex = 2;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnObrisi);
            this.panel1.Controls.Add(this.cmdIzmeni);
            this.panel1.Controls.Add(this.btnNazad);
            this.panel1.Controls.Add(this.btnUcitavanje);
            this.panel1.Controls.Add(this.cmdDodavanje);
            this.panel1.Controls.Add(this.cmd_Nazad);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 83);
            this.panel1.TabIndex = 8;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(537, 15);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(169, 57);
            this.btnObrisi.TabIndex = 11;
            this.btnObrisi.Text = "Obrisi\r\n";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // cmdIzmeni
            // 
            this.cmdIzmeni.Location = new System.Drawing.Point(362, 14);
            this.cmdIzmeni.Name = "cmdIzmeni";
            this.cmdIzmeni.Size = new System.Drawing.Size(169, 57);
            this.cmdIzmeni.TabIndex = 10;
            this.cmdIzmeni.Text = "Izmeni";
            this.cmdIzmeni.UseVisualStyleBackColor = true;
            this.cmdIzmeni.Click += new System.EventHandler(this.cmdIzmeni_Click);
            // 
            // cmdDodavanje
            // 
            this.cmdDodavanje.Location = new System.Drawing.Point(187, 15);
            this.cmdDodavanje.Name = "cmdDodavanje";
            this.cmdDodavanje.Size = new System.Drawing.Size(169, 55);
            this.cmdDodavanje.TabIndex = 3;
            this.cmdDodavanje.Text = "Dodavanje";
            this.cmdDodavanje.UseVisualStyleBackColor = true;
            this.cmdDodavanje.Click += new System.EventHandler(this.cmdDodavanje_Click_1);
            // 
            // cmd_Nazad
            // 
            this.cmd_Nazad.Location = new System.Drawing.Point(1062, 12);
            this.cmd_Nazad.Name = "cmd_Nazad";
            this.cmd_Nazad.Size = new System.Drawing.Size(169, 57);
            this.cmd_Nazad.TabIndex = 4;
            this.cmd_Nazad.Text = "Nazad";
            this.cmd_Nazad.UseVisualStyleBackColor = true;
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
            this.dataGridView1.TabIndex = 12;
            // 
            // FormaAgencijaOrganizator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 479);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FormaAgencijaOrganizator";
            this.Text = "FormaAgencijaOrganizator";
            this.Load += new System.EventHandler(this.FormaAgencijaOrganizator_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUcitavanje;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmd_Nazad;
        private System.Windows.Forms.Button cmdDodavanje;
        private System.Windows.Forms.Button cmdIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}