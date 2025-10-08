namespace Muzicki_festival.FormeDodatne
{
    partial class FormaSoloIzvodjacBendIzmeni
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
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.labelSvira = new System.Windows.Forms.Label();
            this.labelTip = new System.Windows.Forms.Label();
            this.labelBrojClanova = new System.Windows.Forms.Label();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.cmbSvira = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOtkazi.Location = new System.Drawing.Point(831, 20);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(172, 64);
            this.btnOtkazi.TabIndex = 1;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.58366F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.41634F));
            this.tableLayoutPanel2.Controls.Add(this.btnOtkazi, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSacuvaj, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 311);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1219, 104);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvaj.Location = new System.Drawing.Point(222, 20);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(172, 64);
            this.btnSacuvaj.TabIndex = 0;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.58366F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.41634F));
            this.tableLayoutPanel1.Controls.Add(this.cmbSvira, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTip, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelSvira, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelTip, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelBrojClanova, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBroj, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1219, 311);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // txtTip
            // 
            this.txtTip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTip.Location = new System.Drawing.Point(804, 141);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(226, 26);
            this.txtTip.TabIndex = 6;
            // 
            // labelSvira
            // 
            this.labelSvira.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSvira.AutoSize = true;
            this.labelSvira.Location = new System.Drawing.Point(244, 41);
            this.labelSvira.Name = "labelSvira";
            this.labelSvira.Size = new System.Drawing.Size(127, 20);
            this.labelSvira.TabIndex = 1;
            this.labelSvira.Text = "Svira instrumnet:";
            // 
            // labelTip
            // 
            this.labelTip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTip.AutoSize = true;
            this.labelTip.Location = new System.Drawing.Point(247, 144);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(122, 20);
            this.labelTip.TabIndex = 2;
            this.labelTip.Text = "Tip instrumenta:";
            // 
            // labelBrojClanova
            // 
            this.labelBrojClanova.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBrojClanova.AutoSize = true;
            this.labelBrojClanova.Location = new System.Drawing.Point(258, 248);
            this.labelBrojClanova.Name = "labelBrojClanova";
            this.labelBrojClanova.Size = new System.Drawing.Size(99, 20);
            this.labelBrojClanova.TabIndex = 3;
            this.labelBrojClanova.Text = "Broj clanova:";
            // 
            // txtBroj
            // 
            this.txtBroj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBroj.Location = new System.Drawing.Point(804, 245);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(226, 26);
            this.txtBroj.TabIndex = 4;
            // 
            // cmbSvira
            // 
            this.cmbSvira.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSvira.FormattingEnabled = true;
            this.cmbSvira.Location = new System.Drawing.Point(857, 37);
            this.cmbSvira.Name = "cmbSvira";
            this.cmbSvira.Size = new System.Drawing.Size(121, 28);
            this.cmbSvira.TabIndex = 8;
            // 
            // FormaSoloIzvodjacBendDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 415);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "FormaSoloIzvodjacBendDodaj";
            this.Text = "FormaSoloIzvodjacDodaj";
            this.Load += new System.EventHandler(this.FormaSoloIzvodjacBendDodaj_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelSvira;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.Label labelBrojClanova;
        private System.Windows.Forms.TextBox txtBroj;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.ComboBox cmbSvira;
    }
}