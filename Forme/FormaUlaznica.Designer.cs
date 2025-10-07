namespace Muzicki_festival.Forme
{
    partial class FormaUlaznica
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
            this.cmd_Dodavanje = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdIzmeni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmd_Nazad
            // 
            this.cmd_Nazad.Location = new System.Drawing.Point(1009, 12);
            this.cmd_Nazad.Name = "cmd_Nazad";
            this.cmd_Nazad.Size = new System.Drawing.Size(169, 57);
            this.cmd_Nazad.TabIndex = 4;
            this.cmd_Nazad.Text = "Nazad";
            this.cmd_Nazad.UseVisualStyleBackColor = true;
            this.cmd_Nazad.Click += new System.EventHandler(this.cmd_Nazad_Click);
            // 
            // cmd_Dodavanje
            // 
            this.cmd_Dodavanje.Location = new System.Drawing.Point(23, 12);
            this.cmd_Dodavanje.Name = "cmd_Dodavanje";
            this.cmd_Dodavanje.Size = new System.Drawing.Size(169, 57);
            this.cmd_Dodavanje.TabIndex = 5;
            this.cmd_Dodavanje.Text = "Dodavanje";
            this.cmd_Dodavanje.UseVisualStyleBackColor = true;
            this.cmd_Dodavanje.Click += new System.EventHandler(this.cmd_Dodavanje_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1199, 526);
            this.dataGridView1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdIzmeni);
            this.panel1.Controls.Add(this.cmd_Nazad);
            this.panel1.Controls.Add(this.cmd_Dodavanje);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1199, 83);
            this.panel1.TabIndex = 8;
            // 
            // cmdIzmeni
            // 
            this.cmdIzmeni.Location = new System.Drawing.Point(217, 12);
            this.cmdIzmeni.Name = "cmdIzmeni";
            this.cmdIzmeni.Size = new System.Drawing.Size(169, 57);
            this.cmdIzmeni.TabIndex = 9;
            this.cmdIzmeni.Text = "Izmeni";
            this.cmdIzmeni.UseVisualStyleBackColor = true;
            this.cmdIzmeni.Click += new System.EventHandler(this.cmdIzmeni_Click);
            // 
            // FormaUlaznica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 608);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FormaUlaznica";
            this.Text = "FormaUlaznica";
            this.Load += new System.EventHandler(this.FormaUlaznica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_Nazad;
        private System.Windows.Forms.Button cmd_Dodavanje;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdIzmeni;
    }
}