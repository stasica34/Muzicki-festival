namespace Muzicki_festival.Forme
{
    partial class FormaDogadjaji
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
            this.cmdDodavanje = new System.Windows.Forms.Button();
            this.cmdUcitavanjeDogadjaja = new System.Windows.Forms.Button();
            this.cmd_Nazad = new System.Windows.Forms.Button();
            this.cmdDodavanje2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdDodavanje
            // 
            this.cmdDodavanje.Location = new System.Drawing.Point(227, 12);
            this.cmdDodavanje.Name = "cmdDodavanje";
            this.cmdDodavanje.Size = new System.Drawing.Size(169, 57);
            this.cmdDodavanje.TabIndex = 3;
            this.cmdDodavanje.Text = "Dodavanje";
            this.cmdDodavanje.UseVisualStyleBackColor = true;
            this.cmdDodavanje.Click += new System.EventHandler(this.cmdDodavanje_Click);
            // 
            // cmdUcitavanjeDogadjaja
            // 
            this.cmdUcitavanjeDogadjaja.Location = new System.Drawing.Point(28, 12);
            this.cmdUcitavanjeDogadjaja.Name = "cmdUcitavanjeDogadjaja";
            this.cmdUcitavanjeDogadjaja.Size = new System.Drawing.Size(169, 57);
            this.cmdUcitavanjeDogadjaja.TabIndex = 2;
            this.cmdUcitavanjeDogadjaja.Text = "Ucitavanje";
            this.cmdUcitavanjeDogadjaja.UseVisualStyleBackColor = true;
            this.cmdUcitavanjeDogadjaja.Click += new System.EventHandler(this.cmdUcitavanjeDogadjaja_Click);
            // 
            // cmd_Nazad
            // 
            this.cmd_Nazad.Location = new System.Drawing.Point(1074, 12);
            this.cmd_Nazad.Name = "cmd_Nazad";
            this.cmd_Nazad.Size = new System.Drawing.Size(169, 57);
            this.cmd_Nazad.TabIndex = 4;
            this.cmd_Nazad.Text = "Nazad";
            this.cmd_Nazad.UseVisualStyleBackColor = true;
            this.cmd_Nazad.Click += new System.EventHandler(this.cmd_Nazad_Click);
            // 
            // cmdDodavanje2
            // 
            this.cmdDodavanje2.Location = new System.Drawing.Point(881, 12);
            this.cmdDodavanje2.Name = "cmdDodavanje2";
            this.cmdDodavanje2.Size = new System.Drawing.Size(169, 57);
            this.cmdDodavanje2.TabIndex = 5;
            this.cmdDodavanje2.Text = "Dodavanje ulaznice";
            this.cmdDodavanje2.UseVisualStyleBackColor = true;
            this.cmdDodavanje2.Click += new System.EventHandler(this.cmdDodavanje2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1296, 556);
            this.dataGridView1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnObrisi);
            this.panel1.Controls.Add(this.cmd_Nazad);
            this.panel1.Controls.Add(this.cmdDodavanje2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1296, 83);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(417, 12);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(169, 57);
            this.btnObrisi.TabIndex = 8;
            this.btnObrisi.Text = "Obrisi\r\n";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // FormaDogadjaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 639);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdDodavanje);
            this.Controls.Add(this.cmdUcitavanjeDogadjaja);
            this.Controls.Add(this.panel1);
            this.Name = "FormaDogadjaji";
            this.Text = "FormaDogadjaji";
            this.Load += new System.EventHandler(this.FormaDogadjaji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdDodavanje;
        private System.Windows.Forms.Button cmdUcitavanjeDogadjaja;
        private System.Windows.Forms.Button cmd_Nazad;
        private System.Windows.Forms.Button cmdDodavanje2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnObrisi;
    }
}