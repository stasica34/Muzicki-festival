namespace Muzicki_festival.Forme
{
    partial class FormaIzvodjac
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnIzvodjaci = new System.Windows.Forms.Button();
            this.btnMenadzerskaAgencija = new System.Windows.Forms.Button();
            this.btnBend = new System.Windows.Forms.Button();
            this.btnSolo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnIzvodjaci);
            this.splitContainer1.Panel1.Controls.Add(this.btnMenadzerskaAgencija);
            this.splitContainer1.Panel1.Controls.Add(this.btnBend);
            this.splitContainer1.Panel1.Controls.Add(this.btnSolo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(897, 536);
            this.splitContainer1.SplitterDistance = 299;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnIzvodjaci
            // 
            this.btnIzvodjaci.Location = new System.Drawing.Point(55, 60);
            this.btnIzvodjaci.Name = "btnIzvodjaci";
            this.btnIzvodjaci.Size = new System.Drawing.Size(195, 51);
            this.btnIzvodjaci.TabIndex = 3;
            this.btnIzvodjaci.Text = "Svi izvodjaci:";
            this.btnIzvodjaci.UseVisualStyleBackColor = true;
            this.btnIzvodjaci.Click += new System.EventHandler(this.btnIzvodjaci_Click);
            // 
            // btnMenadzerskaAgencija
            // 
            this.btnMenadzerskaAgencija.Location = new System.Drawing.Point(55, 344);
            this.btnMenadzerskaAgencija.Name = "btnMenadzerskaAgencija";
            this.btnMenadzerskaAgencija.Size = new System.Drawing.Size(195, 51);
            this.btnMenadzerskaAgencija.TabIndex = 2;
            this.btnMenadzerskaAgencija.Text = "Menadzerska agencija";
            this.btnMenadzerskaAgencija.UseVisualStyleBackColor = true;
            this.btnMenadzerskaAgencija.Click += new System.EventHandler(this.btnMenadzerskaAgencija_Click);
            // 
            // btnBend
            // 
            this.btnBend.Location = new System.Drawing.Point(55, 246);
            this.btnBend.Name = "btnBend";
            this.btnBend.Size = new System.Drawing.Size(195, 51);
            this.btnBend.TabIndex = 1;
            this.btnBend.Text = "Svi bendovi";
            this.btnBend.UseVisualStyleBackColor = true;
            this.btnBend.Click += new System.EventHandler(this.btnBend_Click);
            // 
            // btnSolo
            // 
            this.btnSolo.Location = new System.Drawing.Point(55, 150);
            this.btnSolo.Name = "btnSolo";
            this.btnSolo.Size = new System.Drawing.Size(195, 51);
            this.btnSolo.TabIndex = 0;
            this.btnSolo.Text = "Svi solo umetnici";
            this.btnSolo.UseVisualStyleBackColor = true;
            this.btnSolo.Click += new System.EventHandler(this.btnSolo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(594, 536);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FormaIzvodjac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 536);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormaIzvodjac";
            this.Text = "FormaIzvodjac";
            this.Load += new System.EventHandler(this.FormaIzvodjac_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSolo;
        private System.Windows.Forms.Button btnMenadzerskaAgencija;
        private System.Windows.Forms.Button btnBend;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnIzvodjaci;
    }
}