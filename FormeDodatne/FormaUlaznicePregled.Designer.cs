namespace Muzicki_festival.FormeDodatne
{
    partial class FormaUlaznicePregled
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelaCena = new System.Windows.Forms.Label();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.NumericUpDown();
            this.cmbPlacanje = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.InputJednodnevna = new System.Windows.Forms.TableLayoutPanel();
            this.DatumJednodnevna = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.InputVisednevna = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.DanVisednevna = new System.Windows.Forms.DateTimePicker();
            this.DugmeDodajDanVisednevna = new System.Windows.Forms.Button();
            this.DugmeObrisiDanVisednevna = new System.Windows.Forms.Button();
            this.TabelaDaniVisednevna = new System.Windows.Forms.DataGridView();
            this.InputAkreditacija = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.radioSponzor = new System.Windows.Forms.RadioButton();
            this.radioParter = new System.Windows.Forms.RadioButton();
            this.radioPress = new System.Windows.Forms.RadioButton();
            this.InputVIP = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPogodnost = new System.Windows.Forms.TextBox();
            this.DugmeDodajPogodnost = new System.Windows.Forms.Button();
            this.DugmeObrisiPogodnost = new System.Windows.Forms.Button();
            this.TabelaPogodnosti = new System.Windows.Forms.DataGridView();
            this.TipLabela = new System.Windows.Forms.Label();
            this.TabelaUlaznice = new System.Windows.Forms.DataGridView();
            this.GrupaPodaci = new System.Windows.Forms.GroupBox();
            this.DugmeIzmeni = new System.Windows.Forms.Button();
            this.DugmeObrisi = new System.Windows.Forms.Button();
            this.DugmePotvrdiIzmene = new System.Windows.Forms.Button();
            this.DugmeOtkaziIzmene = new System.Windows.Forms.Button();
            this.GrupaUlaznice = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCena)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.InputJednodnevna.SuspendLayout();
            this.InputVisednevna.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaDaniVisednevna)).BeginInit();
            this.InputAkreditacija.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.InputVIP.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaPogodnosti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaUlaznice)).BeginInit();
            this.GrupaPodaci.SuspendLayout();
            this.GrupaUlaznice.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.labelaCena, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelNaziv, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpDatum, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCena, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbPlacanje, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TipLabela, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 18);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(768, 182);
            this.tableLayoutPanel1.TabIndex = 5;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // labelaCena
            // 
            this.labelaCena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelaCena.AutoSize = true;
            this.labelaCena.Location = new System.Drawing.Point(97, 61);
            this.labelaCena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelaCena.Name = "labelaCena";
            this.labelaCena.Size = new System.Drawing.Size(35, 13);
            this.labelaCena.TabIndex = 12;
            this.labelaCena.Text = "Cena:";
            // 
            // labelNaziv
            // 
            this.labelNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(71, 16);
            this.labelNaziv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(88, 13);
            this.labelNaziv.TabIndex = 0;
            this.labelNaziv.Text = "Datum kupovine:";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDatum.Location = new System.Drawing.Point(400, 12);
            this.dtpDatum.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(198, 20);
            this.dtpDatum.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nacin placanja:";
            // 
            // txtCena
            // 
            this.txtCena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCena.Location = new System.Drawing.Point(450, 57);
            this.txtCena.Margin = new System.Windows.Forms.Padding(2);
            this.txtCena.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(97, 20);
            this.txtCena.TabIndex = 16;
            // 
            // cmbPlacanje
            // 
            this.cmbPlacanje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPlacanje.FormattingEnabled = true;
            this.cmbPlacanje.Location = new System.Drawing.Point(414, 102);
            this.cmbPlacanje.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPlacanje.Name = "cmbPlacanje";
            this.cmbPlacanje.Size = new System.Drawing.Size(169, 21);
            this.cmbPlacanje.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tip:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.InputJednodnevna);
            this.flowLayoutPanel1.Controls.Add(this.InputVisednevna);
            this.flowLayoutPanel1.Controls.Add(this.InputVIP);
            this.flowLayoutPanel1.Controls.Add(this.InputAkreditacija);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 215);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(767, 122);
            this.flowLayoutPanel1.TabIndex = 24;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // InputJednodnevna
            // 
            this.InputJednodnevna.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InputJednodnevna.ColumnCount = 2;
            this.InputJednodnevna.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.InputJednodnevna.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.InputJednodnevna.Controls.Add(this.DatumJednodnevna, 1, 0);
            this.InputJednodnevna.Controls.Add(this.label2, 0, 0);
            this.InputJednodnevna.Location = new System.Drawing.Point(3, 3);
            this.InputJednodnevna.Name = "InputJednodnevna";
            this.InputJednodnevna.RowCount = 1;
            this.InputJednodnevna.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InputJednodnevna.Size = new System.Drawing.Size(344, 114);
            this.InputJednodnevna.TabIndex = 1;
            this.InputJednodnevna.Visible = false;
            // 
            // DatumJednodnevna
            // 
            this.DatumJednodnevna.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DatumJednodnevna.Location = new System.Drawing.Point(94, 47);
            this.DatumJednodnevna.Name = "DatumJednodnevna";
            this.DatumJednodnevna.Size = new System.Drawing.Size(224, 20);
            this.DatumJednodnevna.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dan:";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // InputVisednevna
            // 
            this.InputVisednevna.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InputVisednevna.ColumnCount = 2;
            this.InputVisednevna.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.InputVisednevna.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.InputVisednevna.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.InputVisednevna.Controls.Add(this.TabelaDaniVisednevna, 1, 0);
            this.InputVisednevna.Location = new System.Drawing.Point(353, 3);
            this.InputVisednevna.Name = "InputVisednevna";
            this.InputVisednevna.RowCount = 1;
            this.InputVisednevna.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InputVisednevna.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.InputVisednevna.Size = new System.Drawing.Size(403, 114);
            this.InputVisednevna.TabIndex = 2;
            this.InputVisednevna.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.DanVisednevna, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.DugmeDodajDanVisednevna, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.DugmeObrisiDanVisednevna, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(195, 108);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // DanVisednevna
            // 
            this.DanVisednevna.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DanVisednevna.Location = new System.Drawing.Point(3, 8);
            this.DanVisednevna.Name = "DanVisednevna";
            this.DanVisednevna.Size = new System.Drawing.Size(189, 20);
            this.DanVisednevna.TabIndex = 0;
            // 
            // DugmeDodajDanVisednevna
            // 
            this.DugmeDodajDanVisednevna.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DugmeDodajDanVisednevna.Location = new System.Drawing.Point(60, 42);
            this.DugmeDodajDanVisednevna.Name = "DugmeDodajDanVisednevna";
            this.DugmeDodajDanVisednevna.Size = new System.Drawing.Size(75, 23);
            this.DugmeDodajDanVisednevna.TabIndex = 1;
            this.DugmeDodajDanVisednevna.Text = "Dodaj";
            this.DugmeDodajDanVisednevna.UseVisualStyleBackColor = true;
            this.DugmeDodajDanVisednevna.Click += new System.EventHandler(this.DugmeDodajDanVisednevna_Click);
            // 
            // DugmeObrisiDanVisednevna
            // 
            this.DugmeObrisiDanVisednevna.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DugmeObrisiDanVisednevna.Location = new System.Drawing.Point(60, 78);
            this.DugmeObrisiDanVisednevna.Name = "DugmeObrisiDanVisednevna";
            this.DugmeObrisiDanVisednevna.Size = new System.Drawing.Size(75, 23);
            this.DugmeObrisiDanVisednevna.TabIndex = 2;
            this.DugmeObrisiDanVisednevna.Text = "Obrisi";
            this.DugmeObrisiDanVisednevna.UseVisualStyleBackColor = true;
            this.DugmeObrisiDanVisednevna.Click += new System.EventHandler(this.DugmeObrisiDanVisednevna_Click);
            // 
            // TabelaDaniVisednevna
            // 
            this.TabelaDaniVisednevna.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TabelaDaniVisednevna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaDaniVisednevna.Location = new System.Drawing.Point(216, 8);
            this.TabelaDaniVisednevna.Name = "TabelaDaniVisednevna";
            this.TabelaDaniVisednevna.Size = new System.Drawing.Size(171, 97);
            this.TabelaDaniVisednevna.TabIndex = 1;
            this.TabelaDaniVisednevna.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelaDaniVisednevna_CellClick);
            // 
            // InputAkreditacija
            // 
            this.InputAkreditacija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InputAkreditacija.Controls.Add(this.tableLayoutPanel4);
            this.InputAkreditacija.Location = new System.Drawing.Point(1220, 15);
            this.InputAkreditacija.Name = "InputAkreditacija";
            this.InputAkreditacija.Size = new System.Drawing.Size(113, 89);
            this.InputAkreditacija.TabIndex = 3;
            this.InputAkreditacija.TabStop = false;
            this.InputAkreditacija.Text = "Tip akreditacije";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.radioSponzor, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.radioParter, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.radioPress, 0, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(104, 67);
            this.tableLayoutPanel4.TabIndex = 0;
            this.tableLayoutPanel4.Visible = false;
            // 
            // radioSponzor
            // 
            this.radioSponzor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioSponzor.AutoSize = true;
            this.radioSponzor.Location = new System.Drawing.Point(20, 3);
            this.radioSponzor.Name = "radioSponzor";
            this.radioSponzor.Size = new System.Drawing.Size(64, 16);
            this.radioSponzor.TabIndex = 0;
            this.radioSponzor.TabStop = true;
            this.radioSponzor.Text = "Sponzor";
            this.radioSponzor.UseVisualStyleBackColor = true;
            // 
            // radioParter
            // 
            this.radioParter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioParter.AutoSize = true;
            this.radioParter.Location = new System.Drawing.Point(25, 25);
            this.radioParter.Name = "radioParter";
            this.radioParter.Size = new System.Drawing.Size(53, 16);
            this.radioParter.TabIndex = 1;
            this.radioParter.TabStop = true;
            this.radioParter.Text = "Parter";
            this.radioParter.UseVisualStyleBackColor = true;
            // 
            // radioPress
            // 
            this.radioPress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioPress.AutoSize = true;
            this.radioPress.Location = new System.Drawing.Point(26, 47);
            this.radioPress.Name = "radioPress";
            this.radioPress.Size = new System.Drawing.Size(51, 17);
            this.radioPress.TabIndex = 2;
            this.radioPress.TabStop = true;
            this.radioPress.Text = "Press";
            this.radioPress.UseVisualStyleBackColor = true;
            // 
            // InputVIP
            // 
            this.InputVIP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InputVIP.ColumnCount = 2;
            this.InputVIP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.InputVIP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.InputVIP.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.InputVIP.Controls.Add(this.TabelaPogodnosti, 1, 0);
            this.InputVIP.Location = new System.Drawing.Point(762, 10);
            this.InputVIP.Name = "InputVIP";
            this.InputVIP.RowCount = 1;
            this.InputVIP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InputVIP.Size = new System.Drawing.Size(452, 100);
            this.InputVIP.TabIndex = 4;
            this.InputVIP.Visible = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtPogodnost, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.DugmeDodajPogodnost, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.DugmeObrisiPogodnost, 0, 2);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(287, 94);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pogodnost";
            // 
            // txtPogodnost
            // 
            this.txtPogodnost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPogodnost.Location = new System.Drawing.Point(154, 5);
            this.txtPogodnost.Name = "txtPogodnost";
            this.txtPogodnost.Size = new System.Drawing.Size(122, 20);
            this.txtPogodnost.TabIndex = 1;
            // 
            // DugmeDodajPogodnost
            // 
            this.DugmeDodajPogodnost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel5.SetColumnSpan(this.DugmeDodajPogodnost, 2);
            this.DugmeDodajPogodnost.Location = new System.Drawing.Point(106, 35);
            this.DugmeDodajPogodnost.Name = "DugmeDodajPogodnost";
            this.DugmeDodajPogodnost.Size = new System.Drawing.Size(75, 23);
            this.DugmeDodajPogodnost.TabIndex = 2;
            this.DugmeDodajPogodnost.Text = "Dodaj";
            this.DugmeDodajPogodnost.UseVisualStyleBackColor = true;
            this.DugmeDodajPogodnost.Click += new System.EventHandler(this.DugmeDodajPogodnost_Click);
            // 
            // DugmeObrisiPogodnost
            // 
            this.DugmeObrisiPogodnost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel5.SetColumnSpan(this.DugmeObrisiPogodnost, 2);
            this.DugmeObrisiPogodnost.Location = new System.Drawing.Point(106, 66);
            this.DugmeObrisiPogodnost.Name = "DugmeObrisiPogodnost";
            this.DugmeObrisiPogodnost.Size = new System.Drawing.Size(75, 23);
            this.DugmeObrisiPogodnost.TabIndex = 3;
            this.DugmeObrisiPogodnost.Text = "Obrisi";
            this.DugmeObrisiPogodnost.UseVisualStyleBackColor = true;
            this.DugmeObrisiPogodnost.Click += new System.EventHandler(this.DugmeObrisiPogodnost_Click);
            // 
            // TabelaPogodnosti
            // 
            this.TabelaPogodnosti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaPogodnosti.Location = new System.Drawing.Point(296, 3);
            this.TabelaPogodnosti.Name = "TabelaPogodnosti";
            this.TabelaPogodnosti.Size = new System.Drawing.Size(153, 94);
            this.TabelaPogodnosti.TabIndex = 1;
            this.TabelaPogodnosti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelaPogodnosti_CellClick);
            // 
            // TipLabela
            // 
            this.TipLabela.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TipLabela.AutoSize = true;
            this.TipLabela.Location = new System.Drawing.Point(499, 152);
            this.TipLabela.Name = "TipLabela";
            this.TipLabela.Size = new System.Drawing.Size(0, 13);
            this.TipLabela.TabIndex = 22;
            // 
            // TabelaUlaznice
            // 
            this.TabelaUlaznice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TabelaUlaznice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaUlaznice.Location = new System.Drawing.Point(12, 19);
            this.TabelaUlaznice.Name = "TabelaUlaznice";
            this.TabelaUlaznice.Size = new System.Drawing.Size(775, 180);
            this.TabelaUlaznice.TabIndex = 25;
            this.TabelaUlaznice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelaUlaznice_CellClick);
            this.TabelaUlaznice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelaUlaznice_CellContentClick);
            // 
            // GrupaPodaci
            // 
            this.GrupaPodaci.Controls.Add(this.DugmeOtkaziIzmene);
            this.GrupaPodaci.Controls.Add(this.DugmePotvrdiIzmene);
            this.GrupaPodaci.Controls.Add(this.tableLayoutPanel1);
            this.GrupaPodaci.Controls.Add(this.flowLayoutPanel1);
            this.GrupaPodaci.Enabled = false;
            this.GrupaPodaci.Location = new System.Drawing.Point(17, 262);
            this.GrupaPodaci.Name = "GrupaPodaci";
            this.GrupaPodaci.Size = new System.Drawing.Size(805, 440);
            this.GrupaPodaci.TabIndex = 26;
            this.GrupaPodaci.TabStop = false;
            this.GrupaPodaci.Text = "Podaci";
            // 
            // DugmeIzmeni
            // 
            this.DugmeIzmeni.Location = new System.Drawing.Point(721, 233);
            this.DugmeIzmeni.Name = "DugmeIzmeni";
            this.DugmeIzmeni.Size = new System.Drawing.Size(83, 23);
            this.DugmeIzmeni.TabIndex = 27;
            this.DugmeIzmeni.Text = "Izmeni";
            this.DugmeIzmeni.UseVisualStyleBackColor = true;
            this.DugmeIzmeni.Click += new System.EventHandler(this.DugmeIzmeni_Click);
            // 
            // DugmeObrisi
            // 
            this.DugmeObrisi.Location = new System.Drawing.Point(632, 233);
            this.DugmeObrisi.Name = "DugmeObrisi";
            this.DugmeObrisi.Size = new System.Drawing.Size(83, 23);
            this.DugmeObrisi.TabIndex = 28;
            this.DugmeObrisi.Text = "Obrisi";
            this.DugmeObrisi.UseVisualStyleBackColor = true;
            this.DugmeObrisi.Click += new System.EventHandler(this.DugmeObrisi_Click);
            // 
            // DugmePotvrdiIzmene
            // 
            this.DugmePotvrdiIzmene.Enabled = false;
            this.DugmePotvrdiIzmene.Location = new System.Drawing.Point(704, 381);
            this.DugmePotvrdiIzmene.Name = "DugmePotvrdiIzmene";
            this.DugmePotvrdiIzmene.Size = new System.Drawing.Size(83, 23);
            this.DugmePotvrdiIzmene.TabIndex = 29;
            this.DugmePotvrdiIzmene.Text = "Potvrdi";
            this.DugmePotvrdiIzmene.UseVisualStyleBackColor = true;
            this.DugmePotvrdiIzmene.Click += new System.EventHandler(this.DugmePotvrdiIzmene_Click);
            // 
            // DugmeOtkaziIzmene
            // 
            this.DugmeOtkaziIzmene.Enabled = false;
            this.DugmeOtkaziIzmene.Location = new System.Drawing.Point(614, 381);
            this.DugmeOtkaziIzmene.Name = "DugmeOtkaziIzmene";
            this.DugmeOtkaziIzmene.Size = new System.Drawing.Size(83, 23);
            this.DugmeOtkaziIzmene.TabIndex = 30;
            this.DugmeOtkaziIzmene.Text = "Otkazi";
            this.DugmeOtkaziIzmene.UseVisualStyleBackColor = true;
            this.DugmeOtkaziIzmene.Click += new System.EventHandler(this.DugmeOtkaziIzmene_Click);
            // 
            // GrupaUlaznice
            // 
            this.GrupaUlaznice.Controls.Add(this.TabelaUlaznice);
            this.GrupaUlaznice.Location = new System.Drawing.Point(17, 12);
            this.GrupaUlaznice.Name = "GrupaUlaznice";
            this.GrupaUlaznice.Size = new System.Drawing.Size(805, 215);
            this.GrupaUlaznice.TabIndex = 29;
            this.GrupaUlaznice.TabStop = false;
            this.GrupaUlaznice.Text = "Ulaznice";
            // 
            // FormaUlaznicePregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 714);
            this.Controls.Add(this.GrupaUlaznice);
            this.Controls.Add(this.DugmeObrisi);
            this.Controls.Add(this.DugmeIzmeni);
            this.Controls.Add(this.GrupaPodaci);
            this.Name = "FormaUlaznicePregled";
            this.Text = "FormaUlaznicePregled";
            this.Load += new System.EventHandler(this.FormaUlaznicePregled_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCena)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.InputJednodnevna.ResumeLayout(false);
            this.InputJednodnevna.PerformLayout();
            this.InputVisednevna.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaDaniVisednevna)).EndInit();
            this.InputAkreditacija.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.InputVIP.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaPogodnosti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaUlaznice)).EndInit();
            this.GrupaPodaci.ResumeLayout(false);
            this.GrupaUlaznice.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelaCena;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtCena;
        private System.Windows.Forms.ComboBox cmbPlacanje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TipLabela;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel InputJednodnevna;
        private System.Windows.Forms.DateTimePicker DatumJednodnevna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel InputVisednevna;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DateTimePicker DanVisednevna;
        private System.Windows.Forms.Button DugmeDodajDanVisednevna;
        private System.Windows.Forms.Button DugmeObrisiDanVisednevna;
        private System.Windows.Forms.DataGridView TabelaDaniVisednevna;
        private System.Windows.Forms.GroupBox InputAkreditacija;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.RadioButton radioSponzor;
        private System.Windows.Forms.RadioButton radioParter;
        private System.Windows.Forms.RadioButton radioPress;
        private System.Windows.Forms.TableLayoutPanel InputVIP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPogodnost;
        private System.Windows.Forms.Button DugmeDodajPogodnost;
        private System.Windows.Forms.Button DugmeObrisiPogodnost;
        private System.Windows.Forms.DataGridView TabelaPogodnosti;
        private System.Windows.Forms.DataGridView TabelaUlaznice;
        private System.Windows.Forms.GroupBox GrupaPodaci;
        private System.Windows.Forms.Button DugmeIzmeni;
        private System.Windows.Forms.Button DugmeObrisi;
        private System.Windows.Forms.Button DugmeOtkaziIzmene;
        private System.Windows.Forms.Button DugmePotvrdiIzmene;
        private System.Windows.Forms.GroupBox GrupaUlaznice;
    }
}