namespace Muzicki_festival.Forme
{
    partial class FormaGrupa
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.cmdIzmeni = new System.Windows.Forms.Button();
            this.cmd_Dodavanje = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmd_Nazad
            // 
            this.cmd_Nazad.Location = new System.Drawing.Point(712, 12);
            this.cmd_Nazad.Name = "cmd_Nazad";
            this.cmd_Nazad.Size = new System.Drawing.Size(169, 57);
            this.cmd_Nazad.TabIndex = 5;
            this.cmd_Nazad.Text = "Nazad";
            this.cmd_Nazad.UseVisualStyleBackColor = true;
            this.cmd_Nazad.Click += new System.EventHandler(this.cmd_Nazad_Click);
            // 
            // cmd_Ucitavanje
            // 
            this.cmd_Ucitavanje.Location = new System.Drawing.Point(12, 12);
            this.cmd_Ucitavanje.Name = "cmd_Ucitavanje";
            this.cmd_Ucitavanje.Size = new System.Drawing.Size(169, 57);
            this.cmd_Ucitavanje.TabIndex = 4;
            this.cmd_Ucitavanje.Text = "Ucitavanje";
            this.cmd_Ucitavanje.UseVisualStyleBackColor = true;
            this.cmd_Ucitavanje.Click += new System.EventHandler(this.cmd_Ucitavanje_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.cmd_Ucitavanje);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 590);
            this.panel1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(900, 507);
            this.dataGridView1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmd_Dodavanje);
            this.panel2.Controls.Add(this.btnObrisi);
            this.panel2.Controls.Add(this.cmdIzmeni);
            this.panel2.Controls.Add(this.cmd_Nazad);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 83);
            this.panel2.TabIndex = 11;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(537, 12);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(169, 57);
            this.btnObrisi.TabIndex = 10;
            this.btnObrisi.Text = "Obrisi\r\n";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // cmdIzmeni
            // 
            this.cmdIzmeni.Location = new System.Drawing.Point(362, 12);
            this.cmdIzmeni.Name = "cmdIzmeni";
            this.cmdIzmeni.Size = new System.Drawing.Size(169, 57);
            this.cmdIzmeni.TabIndex = 9;
            this.cmdIzmeni.Text = "Izmeni";
            this.cmdIzmeni.UseVisualStyleBackColor = true;
            this.cmdIzmeni.Click += new System.EventHandler(this.cmdIzmeni_Click);
            // 
            // cmd_Dodavanje
            // 
            this.cmd_Dodavanje.Location = new System.Drawing.Point(187, 12);
            this.cmd_Dodavanje.Name = "cmd_Dodavanje";
            this.cmd_Dodavanje.Size = new System.Drawing.Size(169, 57);
            this.cmd_Dodavanje.TabIndex = 11;
            this.cmd_Dodavanje.Text = "Dodavanje";
            this.cmd_Dodavanje.UseVisualStyleBackColor = true;
            this.cmd_Dodavanje.Click += new System.EventHandler(this.cmd_Dodavanje_Click);
            // 
            // FormaGrupa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 482);
            this.Controls.Add(this.panel1);
            this.Name = "FormaGrupa";
            this.Text = "FormaGrupa";
            this.Load += new System.EventHandler(this.FormaGrupa_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_Nazad;
        private System.Windows.Forms.Button cmd_Ucitavanje;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button cmdIzmeni;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cmd_Dodavanje;
    }
}