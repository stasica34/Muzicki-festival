namespace Muzicki_festival.Forme
{
    partial class FormaJeClan
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
            this.cmdDodavanje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd_Nazad
            // 
            this.cmd_Nazad.Location = new System.Drawing.Point(36, 178);
            this.cmd_Nazad.Name = "cmd_Nazad";
            this.cmd_Nazad.Size = new System.Drawing.Size(149, 64);
            this.cmd_Nazad.TabIndex = 4;
            this.cmd_Nazad.Text = "Nazad";
            this.cmd_Nazad.UseVisualStyleBackColor = true;
            this.cmd_Nazad.Click += new System.EventHandler(this.cmd_Nazad_Click);
            // 
            // cmd_Ucitavanje
            // 
            this.cmd_Ucitavanje.Location = new System.Drawing.Point(36, 12);
            this.cmd_Ucitavanje.Name = "cmd_Ucitavanje";
            this.cmd_Ucitavanje.Size = new System.Drawing.Size(149, 64);
            this.cmd_Ucitavanje.TabIndex = 3;
            this.cmd_Ucitavanje.Text = "Ucitavanje";
            this.cmd_Ucitavanje.UseVisualStyleBackColor = true;
            this.cmd_Ucitavanje.Click += new System.EventHandler(this.cmd_Ucitavanje_Click);
            // 
            // cmdDodavanje
            // 
            this.cmdDodavanje.Location = new System.Drawing.Point(36, 98);
            this.cmdDodavanje.Name = "cmdDodavanje";
            this.cmdDodavanje.Size = new System.Drawing.Size(169, 57);
            this.cmdDodavanje.TabIndex = 5;
            this.cmdDodavanje.Text = "Dodavanje";
            this.cmdDodavanje.UseVisualStyleBackColor = true;
            this.cmdDodavanje.Click += new System.EventHandler(this.cmdDodavanje_Click);
            // 
            // FormaJeClan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdDodavanje);
            this.Controls.Add(this.cmd_Nazad);
            this.Controls.Add(this.cmd_Ucitavanje);
            this.Name = "FormaJeClan";
            this.Text = "FormaJeClan";
            this.Load += new System.EventHandler(this.FormaJeClan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_Nazad;
        private System.Windows.Forms.Button cmd_Ucitavanje;
        private System.Windows.Forms.Button cmdDodavanje;
    }
}