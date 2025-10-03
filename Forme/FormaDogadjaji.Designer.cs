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
            this.SuspendLayout();
            // 
            // cmdDodavanje
            // 
            this.cmdDodavanje.Location = new System.Drawing.Point(28, 85);
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
            this.cmd_Nazad.Location = new System.Drawing.Point(28, 230);
            this.cmd_Nazad.Name = "cmd_Nazad";
            this.cmd_Nazad.Size = new System.Drawing.Size(169, 57);
            this.cmd_Nazad.TabIndex = 4;
            this.cmd_Nazad.Text = "Nazad";
            this.cmd_Nazad.UseVisualStyleBackColor = true;
            this.cmd_Nazad.Click += new System.EventHandler(this.cmd_Nazad_Click);
            // 
            // cmdDodavanje2
            // 
            this.cmdDodavanje2.Location = new System.Drawing.Point(28, 167);
            this.cmdDodavanje2.Name = "cmdDodavanje2";
            this.cmdDodavanje2.Size = new System.Drawing.Size(169, 57);
            this.cmdDodavanje2.TabIndex = 5;
            this.cmdDodavanje2.Text = "Dodavanje ulaznice";
            this.cmdDodavanje2.UseVisualStyleBackColor = true;
            this.cmdDodavanje2.Click += new System.EventHandler(this.cmdDodavanje2_Click);
            // 
            // FormaDogadjaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdDodavanje2);
            this.Controls.Add(this.cmd_Nazad);
            this.Controls.Add(this.cmdDodavanje);
            this.Controls.Add(this.cmdUcitavanjeDogadjaja);
            this.Name = "FormaDogadjaji";
            this.Text = "FormaDogadjaji";
            this.Load += new System.EventHandler(this.FormaDogadjaji_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdDodavanje;
        private System.Windows.Forms.Button cmdUcitavanjeDogadjaja;
        private System.Windows.Forms.Button cmd_Nazad;
        private System.Windows.Forms.Button cmdDodavanje2;
    }
}