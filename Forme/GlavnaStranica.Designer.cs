namespace Muzicki_festival.Forme
{
    partial class GlavnaStranica
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
            this.cmd_Izvodjac = new System.Windows.Forms.Button();
            this.cmd_Dogadjaji = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.cmd_Dogadjaji);
            this.splitContainer1.Panel1.Controls.Add(this.cmd_Izvodjac);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // cmd_Izvodjac
            // 
            this.cmd_Izvodjac.Location = new System.Drawing.Point(27, 234);
            this.cmd_Izvodjac.Name = "cmd_Izvodjac";
            this.cmd_Izvodjac.Size = new System.Drawing.Size(216, 73);
            this.cmd_Izvodjac.TabIndex = 13;
            this.cmd_Izvodjac.Text = "Izvodjac";
            this.cmd_Izvodjac.UseVisualStyleBackColor = true;
            this.cmd_Izvodjac.Click += new System.EventHandler(this.cmd_Izvodjac_Click);
            // 
            // cmd_Dogadjaji
            // 
            this.cmd_Dogadjaji.Location = new System.Drawing.Point(27, 119);
            this.cmd_Dogadjaji.Name = "cmd_Dogadjaji";
            this.cmd_Dogadjaji.Size = new System.Drawing.Size(216, 73);
            this.cmd_Dogadjaji.TabIndex = 27;
            this.cmd_Dogadjaji.Text = "Dogadjaji";
            this.cmd_Dogadjaji.UseVisualStyleBackColor = true;
            this.cmd_Dogadjaji.Click += new System.EventHandler(this.cmd_Dogadjaji_Click);
            // 
            // GlavnaStranica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "GlavnaStranica";
            this.Text = "GlavnaStranica";
            this.Load += new System.EventHandler(this.GlavnaStranica_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button cmd_Izvodjac;
        private System.Windows.Forms.Button cmd_Dogadjaji;
    }
}