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
            this.cmd_Ucitavanje = new System.Windows.Forms.Button();
            this.cmd_Nazad = new System.Windows.Forms.Button();
            this.cmdDodavanje = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmd_Ucitavanje
            // 
            this.cmd_Ucitavanje.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmd_Ucitavanje.Location = new System.Drawing.Point(0, 121);
            this.cmd_Ucitavanje.Name = "cmd_Ucitavanje";
            this.cmd_Ucitavanje.Size = new System.Drawing.Size(266, 64);
            this.cmd_Ucitavanje.TabIndex = 1;
            this.cmd_Ucitavanje.Text = "Ucitavanje";
            this.cmd_Ucitavanje.UseVisualStyleBackColor = true;
            this.cmd_Ucitavanje.Click += new System.EventHandler(this.cmd_Ucitavanje_Click);
            // 
            // cmd_Nazad
            // 
            this.cmd_Nazad.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmd_Nazad.Location = new System.Drawing.Point(0, 57);
            this.cmd_Nazad.Name = "cmd_Nazad";
            this.cmd_Nazad.Size = new System.Drawing.Size(266, 64);
            this.cmd_Nazad.TabIndex = 2;
            this.cmd_Nazad.Text = "Nazad";
            this.cmd_Nazad.UseVisualStyleBackColor = true;
            this.cmd_Nazad.Click += new System.EventHandler(this.cmd_Nazad_Click);
            // 
            // cmdDodavanje
            // 
            this.cmdDodavanje.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdDodavanje.Location = new System.Drawing.Point(0, 0);
            this.cmdDodavanje.Name = "cmdDodavanje";
            this.cmdDodavanje.Size = new System.Drawing.Size(266, 57);
            this.cmdDodavanje.TabIndex = 4;
            this.cmdDodavanje.Text = "Dodavanje";
            this.cmdDodavanje.UseVisualStyleBackColor = true;
            this.cmdDodavanje.Click += new System.EventHandler(this.cmdDodavanje_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(530, 450);
            this.dataGridView1.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cmd_Ucitavanje);
            this.splitContainer1.Panel1.Controls.Add(this.cmd_Nazad);
            this.splitContainer1.Panel1.Controls.Add(this.cmdDodavanje);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 6;
            // 
            // FormaAgencijaOrganizator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormaAgencijaOrganizator";
            this.Text = "FormaAgencijaOrganizator";
            this.Load += new System.EventHandler(this.FormaAgencijaOrganizator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_Ucitavanje;
        private System.Windows.Forms.Button cmd_Nazad;
        private System.Windows.Forms.Button cmdDodavanje;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}