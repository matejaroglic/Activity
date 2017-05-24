namespace Activity
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaIgraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DodajDatotekoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izberiDatotekoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preimenujEkipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.časUgibanjasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cas_30 = new System.Windows.Forms.ToolStripMenuItem();
            this.cas_60 = new System.Windows.Forms.ToolStripMenuItem();
            this.cas_90 = new System.Windows.Forms.ToolStripMenuItem();
            this.izhodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navodilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.izpis_nacin_ugibanja = new System.Windows.Forms.Label();
            this.izpis_beseda = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tocke_ekipa4 = new System.Windows.Forms.Label();
            this.tocke_ekipa3 = new System.Windows.Forms.Label();
            this.tocke_ekipa2 = new System.Windows.Forms.Label();
            this.label_tocke = new System.Windows.Forms.Label();
            this.label_ekipe = new System.Windows.Forms.Label();
            this.izberi_ekipa1 = new System.Windows.Forms.CheckBox();
            this.izberi_ekipa2 = new System.Windows.Forms.CheckBox();
            this.izberi_ekipa3 = new System.Windows.Forms.CheckBox();
            this.izberi_ekipa4 = new System.Windows.Forms.CheckBox();
            this.tocke_ekipa1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tocke_150 = new System.Windows.Forms.RadioButton();
            this.tocke_100 = new System.Windows.Forms.RadioButton();
            this.tocke_50 = new System.Windows.Forms.RadioButton();
            this.info = new System.Windows.Forms.Label();
            this.gumb_zacni = new System.Windows.Forms.Button();
            this.gumb_uganil = new System.Windows.Forms.Button();
            this.gumb_prekini = new System.Windows.Forms.Button();
            this.odstevanje = new System.Windows.Forms.Timer(this.components);
            this.zacetek_navodila = new System.Windows.Forms.Label();
            this.dejavnost_slike = new System.Windows.Forms.ImageList(this.components);
            this.gumb_ok = new System.Windows.Forms.Button();
            this.stej_cas = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tezavnost_3 = new System.Windows.Forms.RadioButton();
            this.tezavnost_4 = new System.Windows.Forms.RadioButton();
            this.tezavnost_5 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(769, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaIgraToolStripMenuItem,
            this.DodajDatotekoToolStripMenuItem,
            this.izberiDatotekoToolStripMenuItem,
            this.preimenujEkipeToolStripMenuItem,
            this.časUgibanjasToolStripMenuItem,
            this.izhodToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // novaIgraToolStripMenuItem
            // 
            this.novaIgraToolStripMenuItem.Name = "novaIgraToolStripMenuItem";
            this.novaIgraToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.novaIgraToolStripMenuItem.Text = "Nova igra";
            this.novaIgraToolStripMenuItem.Click += new System.EventHandler(this.novaIgraToolStripMenuItem_Click);
            // 
            // DodajDatotekoToolStripMenuItem
            // 
            this.DodajDatotekoToolStripMenuItem.Name = "DodajDatotekoToolStripMenuItem";
            this.DodajDatotekoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.DodajDatotekoToolStripMenuItem.Text = "Dodaj datoteko";
            this.DodajDatotekoToolStripMenuItem.Click += new System.EventHandler(this.DodajDatotekoToolStripMenuItem_Click);
            // 
            // izberiDatotekoToolStripMenuItem
            // 
            this.izberiDatotekoToolStripMenuItem.Name = "izberiDatotekoToolStripMenuItem";
            this.izberiDatotekoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.izberiDatotekoToolStripMenuItem.Text = "Izberi datoteko";
            this.izberiDatotekoToolStripMenuItem.Click += new System.EventHandler(this.izberiDatotekoToolStripMenuItem_Click);
            // 
            // preimenujEkipeToolStripMenuItem
            // 
            this.preimenujEkipeToolStripMenuItem.Name = "preimenujEkipeToolStripMenuItem";
            this.preimenujEkipeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.preimenujEkipeToolStripMenuItem.Text = "Preimenuj ekipe";
            this.preimenujEkipeToolStripMenuItem.Click += new System.EventHandler(this.preimenujEkipeToolStripMenuItem_Click);
            // 
            // časUgibanjasToolStripMenuItem
            // 
            this.časUgibanjasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cas_30,
            this.cas_60,
            this.cas_90});
            this.časUgibanjasToolStripMenuItem.Name = "časUgibanjasToolStripMenuItem";
            this.časUgibanjasToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.časUgibanjasToolStripMenuItem.Text = "Čas ugibanja (s)";
            // 
            // cas_30
            // 
            this.cas_30.Name = "cas_30";
            this.cas_30.Size = new System.Drawing.Size(86, 22);
            this.cas_30.Text = "30";
            this.cas_30.Click += new System.EventHandler(this.cas_30_Click);
            // 
            // cas_60
            // 
            this.cas_60.Name = "cas_60";
            this.cas_60.Size = new System.Drawing.Size(86, 22);
            this.cas_60.Text = "60";
            this.cas_60.Click += new System.EventHandler(this.cas_60_Click);
            // 
            // cas_90
            // 
            this.cas_90.Name = "cas_90";
            this.cas_90.Size = new System.Drawing.Size(86, 22);
            this.cas_90.Text = "90";
            this.cas_90.Click += new System.EventHandler(this.cas_90_Click);
            // 
            // izhodToolStripMenuItem
            // 
            this.izhodToolStripMenuItem.Name = "izhodToolStripMenuItem";
            this.izhodToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.izhodToolStripMenuItem.Text = "Izhod";
            this.izhodToolStripMenuItem.Click += new System.EventHandler(this.izhodToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navodilaToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // navodilaToolStripMenuItem
            // 
            this.navodilaToolStripMenuItem.Name = "navodilaToolStripMenuItem";
            this.navodilaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.navodilaToolStripMenuItem.Text = "Navodila";
            this.navodilaToolStripMenuItem.Click += new System.EventHandler(this.navodilaToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.izpis_nacin_ugibanja, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.izpis_beseda, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(769, 40);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // izpis_nacin_ugibanja
            // 
            this.izpis_nacin_ugibanja.AutoSize = true;
            this.izpis_nacin_ugibanja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.izpis_nacin_ugibanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izpis_nacin_ugibanja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.izpis_nacin_ugibanja.Location = new System.Drawing.Point(5, 2);
            this.izpis_nacin_ugibanja.Name = "izpis_nacin_ugibanja";
            this.izpis_nacin_ugibanja.Size = new System.Drawing.Size(375, 36);
            this.izpis_nacin_ugibanja.TabIndex = 0;
            this.izpis_nacin_ugibanja.Text = "NAČIN UGIBANJA: ";
            this.izpis_nacin_ugibanja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // izpis_beseda
            // 
            this.izpis_beseda.AutoSize = true;
            this.izpis_beseda.BackColor = System.Drawing.Color.Transparent;
            this.izpis_beseda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.izpis_beseda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izpis_beseda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.izpis_beseda.Location = new System.Drawing.Point(388, 2);
            this.izpis_beseda.Name = "izpis_beseda";
            this.izpis_beseda.Size = new System.Drawing.Size(376, 36);
            this.izpis_beseda.TabIndex = 1;
            this.izpis_beseda.Text = "BESEDA:";
            this.izpis_beseda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 295);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 219F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(769, 219);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tocke_ekipa4, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.tocke_ekipa3, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.tocke_ekipa2, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label_tocke, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label_ekipe, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.izberi_ekipa1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.izberi_ekipa2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.izberi_ekipa3, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.izberi_ekipa4, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.tocke_ekipa1, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(455, 213);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tocke_ekipa4
            // 
            this.tocke_ekipa4.AutoSize = true;
            this.tocke_ekipa4.BackColor = System.Drawing.Color.CadetBlue;
            this.tocke_ekipa4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tocke_ekipa4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.tocke_ekipa4.Location = new System.Drawing.Point(232, 171);
            this.tocke_ekipa4.Name = "tocke_ekipa4";
            this.tocke_ekipa4.Size = new System.Drawing.Size(217, 39);
            this.tocke_ekipa4.TabIndex = 9;
            this.tocke_ekipa4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tocke_ekipa3
            // 
            this.tocke_ekipa3.AutoSize = true;
            this.tocke_ekipa3.BackColor = System.Drawing.Color.CadetBlue;
            this.tocke_ekipa3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tocke_ekipa3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tocke_ekipa3.Location = new System.Drawing.Point(232, 129);
            this.tocke_ekipa3.Name = "tocke_ekipa3";
            this.tocke_ekipa3.Size = new System.Drawing.Size(217, 39);
            this.tocke_ekipa3.TabIndex = 8;
            this.tocke_ekipa3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tocke_ekipa2
            // 
            this.tocke_ekipa2.AutoSize = true;
            this.tocke_ekipa2.BackColor = System.Drawing.Color.CadetBlue;
            this.tocke_ekipa2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tocke_ekipa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.tocke_ekipa2.Location = new System.Drawing.Point(232, 87);
            this.tocke_ekipa2.Name = "tocke_ekipa2";
            this.tocke_ekipa2.Size = new System.Drawing.Size(217, 39);
            this.tocke_ekipa2.TabIndex = 7;
            this.tocke_ekipa2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_tocke
            // 
            this.label_tocke.AutoSize = true;
            this.label_tocke.BackColor = System.Drawing.Color.MediumPurple;
            this.label_tocke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_tocke.Font = new System.Drawing.Font("Buxton Sketch", 21.75F, System.Drawing.FontStyle.Bold);
            this.label_tocke.Location = new System.Drawing.Point(232, 3);
            this.label_tocke.Name = "label_tocke";
            this.label_tocke.Size = new System.Drawing.Size(217, 39);
            this.label_tocke.TabIndex = 1;
            this.label_tocke.Text = "TOČKE";
            this.label_tocke.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ekipe
            // 
            this.label_ekipe.AutoSize = true;
            this.label_ekipe.BackColor = System.Drawing.Color.MediumPurple;
            this.label_ekipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_ekipe.Font = new System.Drawing.Font("Buxton Sketch", 21.75F, System.Drawing.FontStyle.Bold);
            this.label_ekipe.Location = new System.Drawing.Point(6, 3);
            this.label_ekipe.Name = "label_ekipe";
            this.label_ekipe.Size = new System.Drawing.Size(217, 39);
            this.label_ekipe.TabIndex = 0;
            this.label_ekipe.Text = "EKIPE";
            this.label_ekipe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // izberi_ekipa1
            // 
            this.izberi_ekipa1.Appearance = System.Windows.Forms.Appearance.Button;
            this.izberi_ekipa1.AutoSize = true;
            this.izberi_ekipa1.BackColor = System.Drawing.Color.LightGray;
            this.izberi_ekipa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.izberi_ekipa1.FlatAppearance.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.izberi_ekipa1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.izberi_ekipa1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izberi_ekipa1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izberi_ekipa1.Location = new System.Drawing.Point(6, 48);
            this.izberi_ekipa1.Name = "izberi_ekipa1";
            this.izberi_ekipa1.Size = new System.Drawing.Size(217, 33);
            this.izberi_ekipa1.TabIndex = 2;
            this.izberi_ekipa1.Text = "Ekipa 1";
            this.izberi_ekipa1.UseVisualStyleBackColor = false;
            // 
            // izberi_ekipa2
            // 
            this.izberi_ekipa2.Appearance = System.Windows.Forms.Appearance.Button;
            this.izberi_ekipa2.AutoSize = true;
            this.izberi_ekipa2.BackColor = System.Drawing.Color.LightGray;
            this.izberi_ekipa2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.izberi_ekipa2.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.izberi_ekipa2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.izberi_ekipa2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izberi_ekipa2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izberi_ekipa2.Location = new System.Drawing.Point(6, 90);
            this.izberi_ekipa2.Name = "izberi_ekipa2";
            this.izberi_ekipa2.Size = new System.Drawing.Size(217, 33);
            this.izberi_ekipa2.TabIndex = 3;
            this.izberi_ekipa2.Text = "Ekipa 2";
            this.izberi_ekipa2.UseVisualStyleBackColor = false;
            // 
            // izberi_ekipa3
            // 
            this.izberi_ekipa3.Appearance = System.Windows.Forms.Appearance.Button;
            this.izberi_ekipa3.AutoSize = true;
            this.izberi_ekipa3.BackColor = System.Drawing.Color.LightGray;
            this.izberi_ekipa3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.izberi_ekipa3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gold;
            this.izberi_ekipa3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.izberi_ekipa3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izberi_ekipa3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izberi_ekipa3.Location = new System.Drawing.Point(6, 132);
            this.izberi_ekipa3.Name = "izberi_ekipa3";
            this.izberi_ekipa3.Size = new System.Drawing.Size(217, 33);
            this.izberi_ekipa3.TabIndex = 4;
            this.izberi_ekipa3.Text = "Ekipa 3";
            this.izberi_ekipa3.UseVisualStyleBackColor = false;
            // 
            // izberi_ekipa4
            // 
            this.izberi_ekipa4.Appearance = System.Windows.Forms.Appearance.Button;
            this.izberi_ekipa4.AutoSize = true;
            this.izberi_ekipa4.BackColor = System.Drawing.Color.LightGray;
            this.izberi_ekipa4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.izberi_ekipa4.FlatAppearance.CheckedBackColor = System.Drawing.Color.ForestGreen;
            this.izberi_ekipa4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.izberi_ekipa4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izberi_ekipa4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izberi_ekipa4.Location = new System.Drawing.Point(6, 174);
            this.izberi_ekipa4.Name = "izberi_ekipa4";
            this.izberi_ekipa4.Size = new System.Drawing.Size(217, 33);
            this.izberi_ekipa4.TabIndex = 5;
            this.izberi_ekipa4.Text = "Ekipa 4";
            this.izberi_ekipa4.UseVisualStyleBackColor = false;
            // 
            // tocke_ekipa1
            // 
            this.tocke_ekipa1.AutoSize = true;
            this.tocke_ekipa1.BackColor = System.Drawing.Color.CadetBlue;
            this.tocke_ekipa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tocke_ekipa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.tocke_ekipa1.Location = new System.Drawing.Point(232, 45);
            this.tocke_ekipa1.Name = "tocke_ekipa1";
            this.tocke_ekipa1.Size = new System.Drawing.Size(217, 39);
            this.tocke_ekipa1.TabIndex = 6;
            this.tocke_ekipa1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.info, 0, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(464, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(302, 213);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumPurple;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Buxton Sketch", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOČKE ZA ZMAGO:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Controls.Add(this.tocke_150, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.tocke_100, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.tocke_50, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 45);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(296, 79);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // tocke_150
            // 
            this.tocke_150.Appearance = System.Windows.Forms.Appearance.Button;
            this.tocke_150.AutoSize = true;
            this.tocke_150.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tocke_150.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tocke_150.FlatAppearance.CheckedBackColor = System.Drawing.Color.Firebrick;
            this.tocke_150.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.tocke_150.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tocke_150.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tocke_150.Location = new System.Drawing.Point(199, 3);
            this.tocke_150.Name = "tocke_150";
            this.tocke_150.Size = new System.Drawing.Size(94, 73);
            this.tocke_150.TabIndex = 2;
            this.tocke_150.Text = "150";
            this.tocke_150.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tocke_150.UseVisualStyleBackColor = false;
            // 
            // tocke_100
            // 
            this.tocke_100.Appearance = System.Windows.Forms.Appearance.Button;
            this.tocke_100.AutoSize = true;
            this.tocke_100.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tocke_100.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tocke_100.FlatAppearance.CheckedBackColor = System.Drawing.Color.Firebrick;
            this.tocke_100.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.tocke_100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tocke_100.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tocke_100.Location = new System.Drawing.Point(101, 3);
            this.tocke_100.Name = "tocke_100";
            this.tocke_100.Size = new System.Drawing.Size(92, 73);
            this.tocke_100.TabIndex = 1;
            this.tocke_100.Text = "100";
            this.tocke_100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tocke_100.UseVisualStyleBackColor = false;
            // 
            // tocke_50
            // 
            this.tocke_50.Appearance = System.Windows.Forms.Appearance.Button;
            this.tocke_50.AutoSize = true;
            this.tocke_50.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tocke_50.Checked = true;
            this.tocke_50.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tocke_50.FlatAppearance.CheckedBackColor = System.Drawing.Color.Firebrick;
            this.tocke_50.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.tocke_50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tocke_50.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tocke_50.Location = new System.Drawing.Point(3, 3);
            this.tocke_50.Name = "tocke_50";
            this.tocke_50.Size = new System.Drawing.Size(92, 73);
            this.tocke_50.TabIndex = 0;
            this.tocke_50.TabStop = true;
            this.tocke_50.Text = "50";
            this.tocke_50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tocke_50.UseVisualStyleBackColor = false;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.info.Font = new System.Drawing.Font("Buxton Sketch", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.info.Location = new System.Drawing.Point(3, 127);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(296, 86);
            this.info.TabIndex = 2;
            this.info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gumb_zacni
            // 
            this.gumb_zacni.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gumb_zacni.BackColor = System.Drawing.Color.DarkOrange;
            this.gumb_zacni.Enabled = false;
            this.gumb_zacni.FlatAppearance.BorderSize = 2;
            this.gumb_zacni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gumb_zacni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gumb_zacni.Font = new System.Drawing.Font("Buxton Sketch", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gumb_zacni.Location = new System.Drawing.Point(6, 222);
            this.gumb_zacni.Name = "gumb_zacni";
            this.gumb_zacni.Size = new System.Drawing.Size(185, 44);
            this.gumb_zacni.TabIndex = 11;
            this.gumb_zacni.Text = "ZAČNI";
            this.gumb_zacni.UseVisualStyleBackColor = false;
            this.gumb_zacni.Click += new System.EventHandler(this.gumb_zacni_Click);
            // 
            // gumb_uganil
            // 
            this.gumb_uganil.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gumb_uganil.AutoSize = true;
            this.gumb_uganil.BackColor = System.Drawing.Color.LimeGreen;
            this.gumb_uganil.Enabled = false;
            this.gumb_uganil.FlatAppearance.BorderSize = 2;
            this.gumb_uganil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.gumb_uganil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gumb_uganil.Font = new System.Drawing.Font("Buxton Sketch", 21.75F, System.Drawing.FontStyle.Bold);
            this.gumb_uganil.Location = new System.Drawing.Point(630, 150);
            this.gumb_uganil.Name = "gumb_uganil";
            this.gumb_uganil.Size = new System.Drawing.Size(123, 51);
            this.gumb_uganil.TabIndex = 12;
            this.gumb_uganil.Text = "UGANIL";
            this.gumb_uganil.UseVisualStyleBackColor = false;
            this.gumb_uganil.Click += new System.EventHandler(this.gumb_uganil_Click);
            // 
            // gumb_prekini
            // 
            this.gumb_prekini.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gumb_prekini.AutoSize = true;
            this.gumb_prekini.BackColor = System.Drawing.Color.Crimson;
            this.gumb_prekini.Enabled = false;
            this.gumb_prekini.FlatAppearance.BorderSize = 2;
            this.gumb_prekini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.gumb_prekini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gumb_prekini.Font = new System.Drawing.Font("Buxton Sketch", 21.75F, System.Drawing.FontStyle.Bold);
            this.gumb_prekini.Location = new System.Drawing.Point(630, 207);
            this.gumb_prekini.Name = "gumb_prekini";
            this.gumb_prekini.Size = new System.Drawing.Size(123, 51);
            this.gumb_prekini.TabIndex = 13;
            this.gumb_prekini.Text = "PREKINI";
            this.gumb_prekini.UseVisualStyleBackColor = false;
            this.gumb_prekini.Click += new System.EventHandler(this.gumb_prekini_Click);
            // 
            // odstevanje
            // 
            this.odstevanje.Interval = 1000;
            this.odstevanje.Tick += new System.EventHandler(this.odstevanje_Tick);
            // 
            // zacetek_navodila
            // 
            this.zacetek_navodila.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.zacetek_navodila.BackColor = System.Drawing.Color.Transparent;
            this.zacetek_navodila.Font = new System.Drawing.Font("Buxton Sketch", 21.75F, System.Drawing.FontStyle.Bold);
            this.zacetek_navodila.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zacetek_navodila.ImageList = this.dejavnost_slike;
            this.zacetek_navodila.Location = new System.Drawing.Point(286, 73);
            this.zacetek_navodila.Name = "zacetek_navodila";
            this.zacetek_navodila.Size = new System.Drawing.Size(200, 200);
            this.zacetek_navodila.TabIndex = 14;
            this.zacetek_navodila.Text = "Izberi vsaj dve ekipi in število točk potrebnih za zmago ter klikni OK.";
            this.zacetek_navodila.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dejavnost_slike
            // 
            this.dejavnost_slike.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("dejavnost_slike.ImageStream")));
            this.dejavnost_slike.TransparentColor = System.Drawing.Color.Transparent;
            this.dejavnost_slike.Images.SetKeyName(0, "narisi.png");
            this.dejavnost_slike.Images.SetKeyName(1, "razlozi.png");
            this.dejavnost_slike.Images.SetKeyName(2, "pantomima.png");
            // 
            // gumb_ok
            // 
            this.gumb_ok.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gumb_ok.BackColor = System.Drawing.Color.Olive;
            this.gumb_ok.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.gumb_ok.FlatAppearance.BorderSize = 2;
            this.gumb_ok.Font = new System.Drawing.Font("Buxton Sketch", 21.75F, System.Drawing.FontStyle.Bold);
            this.gumb_ok.Location = new System.Drawing.Point(490, 234);
            this.gumb_ok.Name = "gumb_ok";
            this.gumb_ok.Size = new System.Drawing.Size(75, 39);
            this.gumb_ok.TabIndex = 15;
            this.gumb_ok.Text = "OK";
            this.gumb_ok.UseVisualStyleBackColor = false;
            this.gumb_ok.Click += new System.EventHandler(this.gumb_ok_Click);
            // 
            // stej_cas
            // 
            this.stej_cas.BackColor = System.Drawing.Color.Transparent;
            this.stej_cas.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stej_cas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stej_cas.Location = new System.Drawing.Point(60, 0);
            this.stej_cas.Name = "stej_cas";
            this.stej_cas.Size = new System.Drawing.Size(72, 56);
            this.stej_cas.TabIndex = 1;
            this.stej_cas.Text = "60";
            this.stej_cas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Activity.Properties.Resources._1485486382_resolutions_03__1_;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tezavnost_3
            // 
            this.tezavnost_3.Appearance = System.Windows.Forms.Appearance.Button;
            this.tezavnost_3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tezavnost_3.Checked = true;
            this.tezavnost_3.FlatAppearance.CheckedBackColor = System.Drawing.Color.LimeGreen;
            this.tezavnost_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.tezavnost_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tezavnost_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tezavnost_3.Location = new System.Drawing.Point(12, 126);
            this.tezavnost_3.Name = "tezavnost_3";
            this.tezavnost_3.Size = new System.Drawing.Size(62, 47);
            this.tezavnost_3.TabIndex = 5;
            this.tezavnost_3.TabStop = true;
            this.tezavnost_3.Text = "3";
            this.tezavnost_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tezavnost_3.UseVisualStyleBackColor = false;
            // 
            // tezavnost_4
            // 
            this.tezavnost_4.Appearance = System.Windows.Forms.Appearance.Button;
            this.tezavnost_4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tezavnost_4.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange;
            this.tezavnost_4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.tezavnost_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tezavnost_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tezavnost_4.Location = new System.Drawing.Point(92, 126);
            this.tezavnost_4.Name = "tezavnost_4";
            this.tezavnost_4.Size = new System.Drawing.Size(62, 47);
            this.tezavnost_4.TabIndex = 6;
            this.tezavnost_4.Text = "4";
            this.tezavnost_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tezavnost_4.UseVisualStyleBackColor = false;
            // 
            // tezavnost_5
            // 
            this.tezavnost_5.Appearance = System.Windows.Forms.Appearance.Button;
            this.tezavnost_5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tezavnost_5.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tezavnost_5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.tezavnost_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tezavnost_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tezavnost_5.Location = new System.Drawing.Point(174, 126);
            this.tezavnost_5.Name = "tezavnost_5";
            this.tezavnost_5.Size = new System.Drawing.Size(64, 47);
            this.tezavnost_5.TabIndex = 7;
            this.tezavnost_5.Text = "5";
            this.tezavnost_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tezavnost_5.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Buxton Sketch", 21.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "IZBERI TEŽAVNOST:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.28814F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.71186F));
            this.tableLayoutPanel4.Controls.Add(this.stej_cas, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(604, 70);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(153, 56);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Activity.Properties.Resources.black_1072366_640;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(769, 514);
            this.Controls.Add(this.tezavnost_3);
            this.Controls.Add(this.tezavnost_4);
            this.Controls.Add(this.tezavnost_5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gumb_ok);
            this.Controls.Add(this.zacetek_navodila);
            this.Controls.Add(this.gumb_prekini);
            this.Controls.Add(this.gumb_uganil);
            this.Controls.Add(this.gumb_zacni);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimumSize = new System.Drawing.Size(670, 553);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activity";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaIgraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izhodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navodilaToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label izpis_nacin_ugibanja;
        private System.Windows.Forms.Label izpis_beseda;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label tocke_ekipa4;
        private System.Windows.Forms.Label tocke_ekipa3;
        private System.Windows.Forms.Label tocke_ekipa2;
        private System.Windows.Forms.Label label_tocke;
        private System.Windows.Forms.Label label_ekipe;
        private System.Windows.Forms.CheckBox izberi_ekipa1;
        private System.Windows.Forms.CheckBox izberi_ekipa2;
        private System.Windows.Forms.CheckBox izberi_ekipa3;
        private System.Windows.Forms.CheckBox izberi_ekipa4;
        private System.Windows.Forms.Label tocke_ekipa1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.RadioButton tocke_150;
        private System.Windows.Forms.RadioButton tocke_100;
        private System.Windows.Forms.RadioButton tocke_50;
        private System.Windows.Forms.Button gumb_zacni;
        private System.Windows.Forms.Button gumb_uganil;
        private System.Windows.Forms.Button gumb_prekini;
        private System.Windows.Forms.Timer odstevanje;
        private System.Windows.Forms.Label zacetek_navodila;
        private System.Windows.Forms.Button gumb_ok;
        private System.Windows.Forms.ToolStripMenuItem DodajDatotekoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izberiDatotekoToolStripMenuItem;
        private System.Windows.Forms.ImageList dejavnost_slike;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.ToolStripMenuItem preimenujEkipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem časUgibanjasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cas_30;
        private System.Windows.Forms.ToolStripMenuItem cas_60;
        private System.Windows.Forms.ToolStripMenuItem cas_90;
        private System.Windows.Forms.Label stej_cas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton tezavnost_3;
        private System.Windows.Forms.RadioButton tezavnost_4;
        private System.Windows.Forms.RadioButton tezavnost_5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    }
}

