namespace DriveKasse
{
    partial class Warenkorb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warenkorb));
            this.btn_wk_zurkasse = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_wk_uhrzeit = new System.Windows.Forms.Label();
            this.lbl_wk_now = new System.Windows.Forms.Label();
            this.btn_wk_bestellen = new System.Windows.Forms.Button();
            this.btn_wk_abmelden = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_wk_mitarbeiter = new System.Windows.Forms.Label();
            this.lbl_wk_restaurant = new System.Windows.Forms.Label();
            this.pb_wk_logo = new System.Windows.Forms.PictureBox();
            this.flp_wk_artikeln = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_artikel01 = new System.Windows.Forms.Button();
            this.btn_artikel02 = new System.Windows.Forms.Button();
            this.btn_artikel03 = new System.Windows.Forms.Button();
            this.btn_artilkel04 = new System.Windows.Forms.Button();
            this.btn_artikel05 = new System.Windows.Forms.Button();
            this.btn_artikel06 = new System.Windows.Forms.Button();
            this.btn_artikel07 = new System.Windows.Forms.Button();
            this.btn_artikel08 = new System.Windows.Forms.Button();
            this.btn_artikel09 = new System.Windows.Forms.Button();
            this.btn_artikel10 = new System.Windows.Forms.Button();
            this.btn_artikel11 = new System.Windows.Forms.Button();
            this.btn_artikel12 = new System.Windows.Forms.Button();
            this.btn_artikel13 = new System.Windows.Forms.Button();
            this.btn_artikel14 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.wk_timer = new System.Windows.Forms.Timer(this.components);
            this.btn_wk_loeschen = new System.Windows.Forms.Button();
            this.lbl_summe = new System.Windows.Forms.Label();
            this.lbl_wk_summe2 = new System.Windows.Forms.Label();
            this.lbl_wk_euro = new System.Windows.Forms.Label();
            this.lbl_wk_verfuerbarkeit = new System.Windows.Forms.Label();
            this.artikelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artikelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mengeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artikelBezeichnungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artikelPreisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_wk_logo)).BeginInit();
            this.flp_wk_artikeln.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_wk_zurkasse
            // 
            this.btn_wk_zurkasse.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_wk_zurkasse.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_wk_zurkasse.Location = new System.Drawing.Point(1044, 538);
            this.btn_wk_zurkasse.Name = "btn_wk_zurkasse";
            this.btn_wk_zurkasse.Size = new System.Drawing.Size(151, 222);
            this.btn_wk_zurkasse.TabIndex = 0;
            this.btn_wk_zurkasse.Text = "KASSE";
            this.btn_wk_zurkasse.UseVisualStyleBackColor = false;
            this.btn_wk_zurkasse.Click += new System.EventHandler(this.btn_wk_zurkasse_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_wk_uhrzeit);
            this.panel2.Controls.Add(this.lbl_wk_now);
            this.panel2.Controls.Add(this.btn_wk_bestellen);
            this.panel2.Controls.Add(this.btn_wk_abmelden);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbl_wk_mitarbeiter);
            this.panel2.Controls.Add(this.lbl_wk_restaurant);
            this.panel2.Controls.Add(this.pb_wk_logo);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1900, 118);
            this.panel2.TabIndex = 3;
            // 
            // lbl_wk_uhrzeit
            // 
            this.lbl_wk_uhrzeit.AutoSize = true;
            this.lbl_wk_uhrzeit.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wk_uhrzeit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl_wk_uhrzeit.Location = new System.Drawing.Point(1026, 48);
            this.lbl_wk_uhrzeit.Name = "lbl_wk_uhrzeit";
            this.lbl_wk_uhrzeit.Size = new System.Drawing.Size(133, 34);
            this.lbl_wk_uhrzeit.TabIndex = 3;
            this.lbl_wk_uhrzeit.Text = "00:00:00";
            // 
            // lbl_wk_now
            // 
            this.lbl_wk_now.AutoSize = true;
            this.lbl_wk_now.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wk_now.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_wk_now.Location = new System.Drawing.Point(1027, 21);
            this.lbl_wk_now.Name = "lbl_wk_now";
            this.lbl_wk_now.Size = new System.Drawing.Size(81, 27);
            this.lbl_wk_now.TabIndex = 3;
            this.lbl_wk_now.Text = "Datum";
            // 
            // btn_wk_bestellen
            // 
            this.btn_wk_bestellen.BackColor = System.Drawing.Color.LightGreen;
            this.btn_wk_bestellen.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_wk_bestellen.Location = new System.Drawing.Point(1466, 16);
            this.btn_wk_bestellen.Name = "btn_wk_bestellen";
            this.btn_wk_bestellen.Size = new System.Drawing.Size(196, 83);
            this.btn_wk_bestellen.TabIndex = 2;
            this.btn_wk_bestellen.Text = "BESTELLEN";
            this.btn_wk_bestellen.UseVisualStyleBackColor = false;
            this.btn_wk_bestellen.Click += new System.EventHandler(this.btn_wk_bestellen_Click);
            // 
            // btn_wk_abmelden
            // 
            this.btn_wk_abmelden.BackColor = System.Drawing.Color.Coral;
            this.btn_wk_abmelden.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_wk_abmelden.Location = new System.Drawing.Point(1680, 16);
            this.btn_wk_abmelden.Name = "btn_wk_abmelden";
            this.btn_wk_abmelden.Size = new System.Drawing.Size(210, 83);
            this.btn_wk_abmelden.TabIndex = 2;
            this.btn_wk_abmelden.Text = "ABMELDEN";
            this.btn_wk_abmelden.UseVisualStyleBackColor = false;
            this.btn_wk_abmelden.Click += new System.EventHandler(this.btn_wk_abmelden_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(761, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bediener:";
            // 
            // lbl_wk_mitarbeiter
            // 
            this.lbl_wk_mitarbeiter.AutoSize = true;
            this.lbl_wk_mitarbeiter.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wk_mitarbeiter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl_wk_mitarbeiter.Location = new System.Drawing.Point(763, 39);
            this.lbl_wk_mitarbeiter.Name = "lbl_wk_mitarbeiter";
            this.lbl_wk_mitarbeiter.Size = new System.Drawing.Size(181, 34);
            this.lbl_wk_mitarbeiter.TabIndex = 1;
            this.lbl_wk_mitarbeiter.Text = "Willkommen";
            // 
            // lbl_wk_restaurant
            // 
            this.lbl_wk_restaurant.AutoSize = true;
            this.lbl_wk_restaurant.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wk_restaurant.ForeColor = System.Drawing.Color.Gold;
            this.lbl_wk_restaurant.Location = new System.Drawing.Point(137, 39);
            this.lbl_wk_restaurant.Name = "lbl_wk_restaurant";
            this.lbl_wk_restaurant.Size = new System.Drawing.Size(446, 34);
            this.lbl_wk_restaurant.TabIndex = 1;
            this.lbl_wk_restaurant.Text = "Modern AI Restaurant GmbH i.G.";
            // 
            // pb_wk_logo
            // 
            this.pb_wk_logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_wk_logo.Image")));
            this.pb_wk_logo.Location = new System.Drawing.Point(0, 3);
            this.pb_wk_logo.Name = "pb_wk_logo";
            this.pb_wk_logo.Size = new System.Drawing.Size(111, 112);
            this.pb_wk_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_wk_logo.TabIndex = 0;
            this.pb_wk_logo.TabStop = false;
            // 
            // flp_wk_artikeln
            // 
            this.flp_wk_artikeln.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_wk_artikeln.Controls.Add(this.btn_artikel01);
            this.flp_wk_artikeln.Controls.Add(this.btn_artikel02);
            this.flp_wk_artikeln.Controls.Add(this.btn_artikel03);
            this.flp_wk_artikeln.Controls.Add(this.btn_artilkel04);
            this.flp_wk_artikeln.Controls.Add(this.btn_artikel05);
            this.flp_wk_artikeln.Controls.Add(this.btn_artikel06);
            this.flp_wk_artikeln.Controls.Add(this.btn_artikel07);
            this.flp_wk_artikeln.Controls.Add(this.btn_artikel08);
            this.flp_wk_artikeln.Controls.Add(this.btn_artikel09);
            this.flp_wk_artikeln.Controls.Add(this.btn_artikel10);
            this.flp_wk_artikeln.Controls.Add(this.btn_artikel11);
            this.flp_wk_artikeln.Controls.Add(this.btn_artikel12);
            this.flp_wk_artikeln.Controls.Add(this.btn_artikel13);
            this.flp_wk_artikeln.Controls.Add(this.btn_artikel14);
            this.flp_wk_artikeln.Location = new System.Drawing.Point(1226, 136);
            this.flp_wk_artikeln.Name = "flp_wk_artikeln";
            this.flp_wk_artikeln.Size = new System.Drawing.Size(685, 943);
            this.flp_wk_artikeln.TabIndex = 6;
            this.flp_wk_artikeln.Visible = false;
            // 
            // btn_artikel01
            // 
            this.btn_artikel01.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_artikel01.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_artikel01.Location = new System.Drawing.Point(3, 3);
            this.btn_artikel01.Name = "btn_artikel01";
            this.btn_artikel01.Size = new System.Drawing.Size(205, 185);
            this.btn_artikel01.TabIndex = 0;
            this.btn_artikel01.Text = "Hamburger\r\n5,00 EUR";
            this.btn_artikel01.UseVisualStyleBackColor = false;
            this.btn_artikel01.Click += new System.EventHandler(this.btn_artikel01_Click);
            // 
            // btn_artikel02
            // 
            this.btn_artikel02.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_artikel02.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_artikel02.Location = new System.Drawing.Point(214, 3);
            this.btn_artikel02.Name = "btn_artikel02";
            this.btn_artikel02.Size = new System.Drawing.Size(205, 185);
            this.btn_artikel02.TabIndex = 0;
            this.btn_artikel02.Text = "Cheeseburger\r\n5,50 EUR";
            this.btn_artikel02.UseVisualStyleBackColor = false;
            this.btn_artikel02.Click += new System.EventHandler(this.btn_artikel02_Click);
            // 
            // btn_artikel03
            // 
            this.btn_artikel03.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_artikel03.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_artikel03.Location = new System.Drawing.Point(425, 3);
            this.btn_artikel03.Name = "btn_artikel03";
            this.btn_artikel03.Size = new System.Drawing.Size(205, 185);
            this.btn_artikel03.TabIndex = 0;
            this.btn_artikel03.Text = "Chickenburger\r\n5,50 EUR";
            this.btn_artikel03.UseVisualStyleBackColor = false;
            this.btn_artikel03.Click += new System.EventHandler(this.btn_artikel03_Click);
            // 
            // btn_artilkel04
            // 
            this.btn_artilkel04.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_artilkel04.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_artilkel04.Location = new System.Drawing.Point(3, 194);
            this.btn_artilkel04.Name = "btn_artilkel04";
            this.btn_artilkel04.Size = new System.Drawing.Size(205, 185);
            this.btn_artilkel04.TabIndex = 0;
            this.btn_artilkel04.Text = "Vegan Burger\r\n7,00 EUR";
            this.btn_artilkel04.UseVisualStyleBackColor = false;
            this.btn_artilkel04.Click += new System.EventHandler(this.btn_artilkel04_Click);
            // 
            // btn_artikel05
            // 
            this.btn_artikel05.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_artikel05.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_artikel05.Location = new System.Drawing.Point(214, 194);
            this.btn_artikel05.Name = "btn_artikel05";
            this.btn_artikel05.Size = new System.Drawing.Size(205, 185);
            this.btn_artikel05.TabIndex = 0;
            this.btn_artikel05.Text = "Low Carb Burger\r\n7,50 EUR";
            this.btn_artikel05.UseVisualStyleBackColor = false;
            this.btn_artikel05.Click += new System.EventHandler(this.btn_artikel05_Click);
            // 
            // btn_artikel06
            // 
            this.btn_artikel06.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_artikel06.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_artikel06.Location = new System.Drawing.Point(425, 194);
            this.btn_artikel06.Name = "btn_artikel06";
            this.btn_artikel06.Size = new System.Drawing.Size(205, 185);
            this.btn_artikel06.TabIndex = 0;
            this.btn_artikel06.Text = "Pommes Frites\r\n2,50 EUR";
            this.btn_artikel06.UseVisualStyleBackColor = false;
            this.btn_artikel06.Click += new System.EventHandler(this.btn_artikel06_Click);
            // 
            // btn_artikel07
            // 
            this.btn_artikel07.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_artikel07.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_artikel07.Location = new System.Drawing.Point(3, 385);
            this.btn_artikel07.Name = "btn_artikel07";
            this.btn_artikel07.Size = new System.Drawing.Size(205, 185);
            this.btn_artikel07.TabIndex = 0;
            this.btn_artikel07.Text = "Karoffelspalten\r\n3,00 EUR";
            this.btn_artikel07.UseVisualStyleBackColor = false;
            this.btn_artikel07.Click += new System.EventHandler(this.btn_artikel07_Click);
            // 
            // btn_artikel08
            // 
            this.btn_artikel08.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_artikel08.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_artikel08.Location = new System.Drawing.Point(214, 385);
            this.btn_artikel08.Name = "btn_artikel08";
            this.btn_artikel08.Size = new System.Drawing.Size(205, 185);
            this.btn_artikel08.TabIndex = 0;
            this.btn_artikel08.Text = "Wasser Still\r\n1,50 EUR";
            this.btn_artikel08.UseVisualStyleBackColor = false;
            this.btn_artikel08.Click += new System.EventHandler(this.btn_artikel08_Click);
            // 
            // btn_artikel09
            // 
            this.btn_artikel09.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_artikel09.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_artikel09.Location = new System.Drawing.Point(425, 385);
            this.btn_artikel09.Name = "btn_artikel09";
            this.btn_artikel09.Size = new System.Drawing.Size(205, 185);
            this.btn_artikel09.TabIndex = 0;
            this.btn_artikel09.Text = "Wasser Sprudel\r\n1,50 EUR";
            this.btn_artikel09.UseVisualStyleBackColor = false;
            this.btn_artikel09.Click += new System.EventHandler(this.btn_artikel09_Click);
            // 
            // btn_artikel10
            // 
            this.btn_artikel10.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_artikel10.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_artikel10.Location = new System.Drawing.Point(3, 576);
            this.btn_artikel10.Name = "btn_artikel10";
            this.btn_artikel10.Size = new System.Drawing.Size(205, 185);
            this.btn_artikel10.TabIndex = 0;
            this.btn_artikel10.Text = "Cola\r\n2,00 EUR";
            this.btn_artikel10.UseVisualStyleBackColor = false;
            this.btn_artikel10.Click += new System.EventHandler(this.btn_artikel10_Click);
            // 
            // btn_artikel11
            // 
            this.btn_artikel11.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_artikel11.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_artikel11.Location = new System.Drawing.Point(214, 576);
            this.btn_artikel11.Name = "btn_artikel11";
            this.btn_artikel11.Size = new System.Drawing.Size(205, 185);
            this.btn_artikel11.TabIndex = 0;
            this.btn_artikel11.Text = "Limo\r\n2,00 EUR";
            this.btn_artikel11.UseVisualStyleBackColor = false;
            this.btn_artikel11.Click += new System.EventHandler(this.btn_artikel11_Click);
            // 
            // btn_artikel12
            // 
            this.btn_artikel12.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_artikel12.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_artikel12.Location = new System.Drawing.Point(425, 576);
            this.btn_artikel12.Name = "btn_artikel12";
            this.btn_artikel12.Size = new System.Drawing.Size(205, 185);
            this.btn_artikel12.TabIndex = 0;
            this.btn_artikel12.Text = "Apfelschorle\r\n2,00 EUR";
            this.btn_artikel12.UseVisualStyleBackColor = false;
            this.btn_artikel12.Click += new System.EventHandler(this.btn_artikel12_Click);
            // 
            // btn_artikel13
            // 
            this.btn_artikel13.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_artikel13.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_artikel13.Location = new System.Drawing.Point(3, 767);
            this.btn_artikel13.Name = "btn_artikel13";
            this.btn_artikel13.Size = new System.Drawing.Size(205, 185);
            this.btn_artikel13.TabIndex = 0;
            this.btn_artikel13.Text = "Ketchup\r\n0,50 EUR";
            this.btn_artikel13.UseVisualStyleBackColor = false;
            this.btn_artikel13.Click += new System.EventHandler(this.btn_artikel13_Click);
            // 
            // btn_artikel14
            // 
            this.btn_artikel14.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_artikel14.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_artikel14.Location = new System.Drawing.Point(214, 767);
            this.btn_artikel14.Name = "btn_artikel14";
            this.btn_artikel14.Size = new System.Drawing.Size(205, 185);
            this.btn_artikel14.TabIndex = 0;
            this.btn_artikel14.Text = "Majo\r\n0,50 EUR";
            this.btn_artikel14.UseVisualStyleBackColor = false;
            this.btn_artikel14.Click += new System.EventHandler(this.btn_artikel14_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artikelIDDataGridViewTextBoxColumn,
            this.mengeDataGridViewTextBoxColumn,
            this.artikelBezeichnungDataGridViewTextBoxColumn,
            this.artikelPreisDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.artikelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(55, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(947, 621);
            this.dataGridView1.TabIndex = 7;
            // 
            // wk_timer
            // 
            this.wk_timer.Interval = 1000;
            this.wk_timer.Tick += new System.EventHandler(this.wk_timer_Tick);
            // 
            // btn_wk_loeschen
            // 
            this.btn_wk_loeschen.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_wk_loeschen.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_wk_loeschen.Location = new System.Drawing.Point(1044, 139);
            this.btn_wk_loeschen.Name = "btn_wk_loeschen";
            this.btn_wk_loeschen.Size = new System.Drawing.Size(151, 222);
            this.btn_wk_loeschen.TabIndex = 0;
            this.btn_wk_loeschen.Text = "CLEAR";
            this.btn_wk_loeschen.UseVisualStyleBackColor = false;
            this.btn_wk_loeschen.Click += new System.EventHandler(this.btn_wk_loeschen_Click);
            // 
            // lbl_summe
            // 
            this.lbl_summe.AutoSize = true;
            this.lbl_summe.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_summe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_summe.Location = new System.Drawing.Point(580, 783);
            this.lbl_summe.Name = "lbl_summe";
            this.lbl_summe.Size = new System.Drawing.Size(141, 38);
            this.lbl_summe.TabIndex = 9;
            this.lbl_summe.Text = "Summe:";
            // 
            // lbl_wk_summe2
            // 
            this.lbl_wk_summe2.AutoSize = true;
            this.lbl_wk_summe2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wk_summe2.ForeColor = System.Drawing.Color.Gold;
            this.lbl_wk_summe2.Location = new System.Drawing.Point(815, 783);
            this.lbl_wk_summe2.Name = "lbl_wk_summe2";
            this.lbl_wk_summe2.Size = new System.Drawing.Size(0, 38);
            this.lbl_wk_summe2.TabIndex = 9;
            this.lbl_wk_summe2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_wk_euro
            // 
            this.lbl_wk_euro.AutoSize = true;
            this.lbl_wk_euro.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wk_euro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_wk_euro.Location = new System.Drawing.Point(923, 783);
            this.lbl_wk_euro.Name = "lbl_wk_euro";
            this.lbl_wk_euro.Size = new System.Drawing.Size(79, 38);
            this.lbl_wk_euro.TabIndex = 9;
            this.lbl_wk_euro.Text = "EUR";
            // 
            // lbl_wk_verfuerbarkeit
            // 
            this.lbl_wk_verfuerbarkeit.AutoSize = true;
            this.lbl_wk_verfuerbarkeit.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wk_verfuerbarkeit.ForeColor = System.Drawing.Color.LightCoral;
            this.lbl_wk_verfuerbarkeit.Location = new System.Drawing.Point(86, 903);
            this.lbl_wk_verfuerbarkeit.Name = "lbl_wk_verfuerbarkeit";
            this.lbl_wk_verfuerbarkeit.Size = new System.Drawing.Size(0, 38);
            this.lbl_wk_verfuerbarkeit.TabIndex = 9;
            // 
            // artikelBindingSource
            // 
            this.artikelBindingSource.DataSource = typeof(DriveKasse.Artikel);
            // 
            // artikelIDDataGridViewTextBoxColumn
            // 
            this.artikelIDDataGridViewTextBoxColumn.DataPropertyName = "ArtikelID";
            this.artikelIDDataGridViewTextBoxColumn.HeaderText = "ArtikelID";
            this.artikelIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.artikelIDDataGridViewTextBoxColumn.Name = "artikelIDDataGridViewTextBoxColumn";
            this.artikelIDDataGridViewTextBoxColumn.Visible = false;
            this.artikelIDDataGridViewTextBoxColumn.Width = 106;
            // 
            // mengeDataGridViewTextBoxColumn
            // 
            this.mengeDataGridViewTextBoxColumn.DataPropertyName = "Menge";
            this.mengeDataGridViewTextBoxColumn.HeaderText = "Menge";
            this.mengeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mengeDataGridViewTextBoxColumn.Name = "mengeDataGridViewTextBoxColumn";
            this.mengeDataGridViewTextBoxColumn.Width = 94;
            // 
            // artikelBezeichnungDataGridViewTextBoxColumn
            // 
            this.artikelBezeichnungDataGridViewTextBoxColumn.DataPropertyName = "ArtikelBezeichnung";
            this.artikelBezeichnungDataGridViewTextBoxColumn.HeaderText = "ArtikelBezeichnung";
            this.artikelBezeichnungDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.artikelBezeichnungDataGridViewTextBoxColumn.Name = "artikelBezeichnungDataGridViewTextBoxColumn";
            this.artikelBezeichnungDataGridViewTextBoxColumn.Width = 182;
            // 
            // artikelPreisDataGridViewTextBoxColumn
            // 
            this.artikelPreisDataGridViewTextBoxColumn.DataPropertyName = "ArtikelPreis";
            this.artikelPreisDataGridViewTextBoxColumn.HeaderText = "ArtikelPreis";
            this.artikelPreisDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.artikelPreisDataGridViewTextBoxColumn.Name = "artikelPreisDataGridViewTextBoxColumn";
            this.artikelPreisDataGridViewTextBoxColumn.Width = 124;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.Width = 80;
            // 
            // Warenkorb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1923, 1106);
            this.Controls.Add(this.lbl_wk_summe2);
            this.Controls.Add(this.lbl_wk_euro);
            this.Controls.Add(this.lbl_wk_verfuerbarkeit);
            this.Controls.Add(this.lbl_summe);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flp_wk_artikeln);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_wk_loeschen);
            this.Controls.Add(this.btn_wk_zurkasse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Warenkorb";
            this.Text = "Warenkorb";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Warenkorb_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_wk_logo)).EndInit();
            this.flp_wk_artikeln.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artikelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_wk_zurkasse;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_wk_restaurant;
        private System.Windows.Forms.PictureBox pb_wk_logo;
        private System.Windows.Forms.Button btn_wk_abmelden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_wk_mitarbeiter;
        private System.Windows.Forms.Button btn_wk_bestellen;
        private System.Windows.Forms.FlowLayoutPanel flp_wk_artikeln;
        private System.Windows.Forms.Label lbl_wk_now;
        private System.Windows.Forms.Button btn_artikel01;
        private System.Windows.Forms.Button btn_artikel02;
        private System.Windows.Forms.Button btn_artikel03;
        private System.Windows.Forms.Button btn_artilkel04;
        private System.Windows.Forms.Button btn_artikel05;
        private System.Windows.Forms.Button btn_artikel06;
        private System.Windows.Forms.Button btn_artikel07;
        private System.Windows.Forms.Button btn_artikel08;
        private System.Windows.Forms.Button btn_artikel09;
        private System.Windows.Forms.Button btn_artikel10;
        private System.Windows.Forms.Button btn_artikel11;
        private System.Windows.Forms.Button btn_artikel12;
        private System.Windows.Forms.Button btn_artikel13;
        private System.Windows.Forms.Button btn_artikel14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer wk_timer;
        private System.Windows.Forms.BindingSource artikelBindingSource;
        private System.Windows.Forms.Button btn_wk_loeschen;
        private System.Windows.Forms.Label lbl_summe;
        private System.Windows.Forms.Label lbl_wk_summe2;
        private System.Windows.Forms.Label lbl_wk_euro;
        private System.Windows.Forms.Label lbl_wk_uhrzeit;
        private System.Windows.Forms.Label lbl_wk_verfuerbarkeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn artikelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mengeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artikelBezeichnungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artikelPreisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}