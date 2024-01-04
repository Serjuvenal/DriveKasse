namespace DriveKasse
{
    partial class Kasse
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
            this.lbl_kasse_rueckgeld = new System.Windows.Forms.Label();
            this.lbl_kasse_rabatt = new System.Windows.Forms.Label();
            this.lbl_kasse_gegeben = new System.Windows.Forms.Label();
            this.lbl_kasse_summe = new System.Windows.Forms.Label();
            this.tb_kasse_gegeben = new System.Windows.Forms.TextBox();
            this.tb_kasse_rueckgeld = new System.Windows.Forms.TextBox();
            this.tb_kasse_rabatt = new System.Windows.Forms.TextBox();
            this.tb_kasse_summe = new System.Windows.Forms.TextBox();
            this.btn_ks_clear = new System.Windows.Forms.Button();
            this.btn_ks_drei = new System.Windows.Forms.Button();
            this.btn_ks_sechs = new System.Windows.Forms.Button();
            this.btn_ks_neun = new System.Windows.Forms.Button();
            this.btn_ks_null = new System.Windows.Forms.Button();
            this.btn_ks_zwei = new System.Windows.Forms.Button();
            this.btn_ks_fuenf = new System.Windows.Forms.Button();
            this.btn_ks_acht = new System.Windows.Forms.Button();
            this.btn_ks_komma = new System.Windows.Forms.Button();
            this.btn_ks_eins = new System.Windows.Forms.Button();
            this.btn_ks_vier = new System.Windows.Forms.Button();
            this.btn_ks_sieben = new System.Windows.Forms.Button();
            this.btn_ks_zweihunderteuro = new System.Windows.Forms.Button();
            this.btn_ks_fuenfzigeuro = new System.Windows.Forms.Button();
            this.btn_ks_zehneuro = new System.Windows.Forms.Button();
            this.btn_ks_hunderteuro = new System.Windows.Forms.Button();
            this.btn_ks_zwanzigeuro = new System.Windows.Forms.Button();
            this.btn_ks_fuenfeuro = new System.Windows.Forms.Button();
            this.btn_ks_eczahlung = new System.Windows.Forms.Button();
            this.btn_ks_barzahlung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_kasse_rueckgeld
            // 
            this.lbl_kasse_rueckgeld.AutoSize = true;
            this.lbl_kasse_rueckgeld.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kasse_rueckgeld.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_kasse_rueckgeld.Location = new System.Drawing.Point(26, 293);
            this.lbl_kasse_rueckgeld.Name = "lbl_kasse_rueckgeld";
            this.lbl_kasse_rueckgeld.Size = new System.Drawing.Size(130, 43);
            this.lbl_kasse_rueckgeld.TabIndex = 1;
            this.lbl_kasse_rueckgeld.Text = "Zurück";
            this.lbl_kasse_rueckgeld.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbl_kasse_rabatt
            // 
            this.lbl_kasse_rabatt.AutoSize = true;
            this.lbl_kasse_rabatt.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kasse_rabatt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_kasse_rabatt.Location = new System.Drawing.Point(26, 219);
            this.lbl_kasse_rabatt.Name = "lbl_kasse_rabatt";
            this.lbl_kasse_rabatt.Size = new System.Drawing.Size(198, 43);
            this.lbl_kasse_rabatt.TabIndex = 1;
            this.lbl_kasse_rabatt.Text = "Rabatt in %";
            this.lbl_kasse_rabatt.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbl_kasse_gegeben
            // 
            this.lbl_kasse_gegeben.AutoSize = true;
            this.lbl_kasse_gegeben.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kasse_gegeben.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_kasse_gegeben.Location = new System.Drawing.Point(26, 146);
            this.lbl_kasse_gegeben.Name = "lbl_kasse_gegeben";
            this.lbl_kasse_gegeben.Size = new System.Drawing.Size(161, 43);
            this.lbl_kasse_gegeben.TabIndex = 1;
            this.lbl_kasse_gegeben.Text = "Gegeben";
            this.lbl_kasse_gegeben.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbl_kasse_summe
            // 
            this.lbl_kasse_summe.AutoSize = true;
            this.lbl_kasse_summe.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kasse_summe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_kasse_summe.Location = new System.Drawing.Point(26, 69);
            this.lbl_kasse_summe.Name = "lbl_kasse_summe";
            this.lbl_kasse_summe.Size = new System.Drawing.Size(143, 43);
            this.lbl_kasse_summe.TabIndex = 1;
            this.lbl_kasse_summe.Text = "Summe";
            this.lbl_kasse_summe.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tb_kasse_gegeben
            // 
            this.tb_kasse_gegeben.BackColor = System.Drawing.Color.White;
            this.tb_kasse_gegeben.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_kasse_gegeben.ForeColor = System.Drawing.Color.Black;
            this.tb_kasse_gegeben.Location = new System.Drawing.Point(245, 137);
            this.tb_kasse_gegeben.Name = "tb_kasse_gegeben";
            this.tb_kasse_gegeben.Size = new System.Drawing.Size(155, 57);
            this.tb_kasse_gegeben.TabIndex = 0;
            this.tb_kasse_gegeben.Text = "0";
            this.tb_kasse_gegeben.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_kasse_gegeben.Enter += new System.EventHandler(this.tb_kasse_gegeben_Enter);
            // 
            // tb_kasse_rueckgeld
            // 
            this.tb_kasse_rueckgeld.BackColor = System.Drawing.Color.White;
            this.tb_kasse_rueckgeld.Enabled = false;
            this.tb_kasse_rueckgeld.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_kasse_rueckgeld.ForeColor = System.Drawing.Color.Black;
            this.tb_kasse_rueckgeld.Location = new System.Drawing.Point(245, 282);
            this.tb_kasse_rueckgeld.Name = "tb_kasse_rueckgeld";
            this.tb_kasse_rueckgeld.Size = new System.Drawing.Size(155, 57);
            this.tb_kasse_rueckgeld.TabIndex = 0;
            this.tb_kasse_rueckgeld.Text = "0";
            this.tb_kasse_rueckgeld.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_kasse_rabatt
            // 
            this.tb_kasse_rabatt.BackColor = System.Drawing.Color.White;
            this.tb_kasse_rabatt.Enabled = false;
            this.tb_kasse_rabatt.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_kasse_rabatt.ForeColor = System.Drawing.Color.Black;
            this.tb_kasse_rabatt.Location = new System.Drawing.Point(245, 208);
            this.tb_kasse_rabatt.Name = "tb_kasse_rabatt";
            this.tb_kasse_rabatt.Size = new System.Drawing.Size(155, 57);
            this.tb_kasse_rabatt.TabIndex = 0;
            this.tb_kasse_rabatt.Text = "0";
            this.tb_kasse_rabatt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_kasse_summe
            // 
            this.tb_kasse_summe.BackColor = System.Drawing.Color.White;
            this.tb_kasse_summe.Enabled = false;
            this.tb_kasse_summe.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_kasse_summe.ForeColor = System.Drawing.Color.Black;
            this.tb_kasse_summe.Location = new System.Drawing.Point(245, 68);
            this.tb_kasse_summe.Name = "tb_kasse_summe";
            this.tb_kasse_summe.Size = new System.Drawing.Size(155, 57);
            this.tb_kasse_summe.TabIndex = 0;
            this.tb_kasse_summe.Text = "0";
            this.tb_kasse_summe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_ks_clear
            // 
            this.btn_ks_clear.BackColor = System.Drawing.Color.Orange;
            this.btn_ks_clear.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ks_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_ks_clear.Location = new System.Drawing.Point(671, 303);
            this.btn_ks_clear.Name = "btn_ks_clear";
            this.btn_ks_clear.Size = new System.Drawing.Size(97, 91);
            this.btn_ks_clear.TabIndex = 0;
            this.btn_ks_clear.Text = "C";
            this.btn_ks_clear.UseVisualStyleBackColor = false;
            this.btn_ks_clear.Click += new System.EventHandler(this.btn_ks_clear_Click);
            // 
            // btn_ks_drei
            // 
            this.btn_ks_drei.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_ks_drei.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ks_drei.ForeColor = System.Drawing.Color.Black;
            this.btn_ks_drei.Location = new System.Drawing.Point(671, 212);
            this.btn_ks_drei.Name = "btn_ks_drei";
            this.btn_ks_drei.Size = new System.Drawing.Size(97, 91);
            this.btn_ks_drei.TabIndex = 0;
            this.btn_ks_drei.Text = "3";
            this.btn_ks_drei.UseVisualStyleBackColor = false;
            this.btn_ks_drei.Click += new System.EventHandler(this.btn_ks_null_Click);
            // 
            // btn_ks_sechs
            // 
            this.btn_ks_sechs.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_ks_sechs.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ks_sechs.ForeColor = System.Drawing.Color.Black;
            this.btn_ks_sechs.Location = new System.Drawing.Point(671, 121);
            this.btn_ks_sechs.Name = "btn_ks_sechs";
            this.btn_ks_sechs.Size = new System.Drawing.Size(97, 91);
            this.btn_ks_sechs.TabIndex = 0;
            this.btn_ks_sechs.Text = "6";
            this.btn_ks_sechs.UseVisualStyleBackColor = false;
            this.btn_ks_sechs.Click += new System.EventHandler(this.btn_ks_null_Click);
            // 
            // btn_ks_neun
            // 
            this.btn_ks_neun.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_ks_neun.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ks_neun.ForeColor = System.Drawing.Color.Black;
            this.btn_ks_neun.Location = new System.Drawing.Point(671, 28);
            this.btn_ks_neun.Name = "btn_ks_neun";
            this.btn_ks_neun.Size = new System.Drawing.Size(97, 91);
            this.btn_ks_neun.TabIndex = 0;
            this.btn_ks_neun.Text = "9";
            this.btn_ks_neun.UseVisualStyleBackColor = false;
            this.btn_ks_neun.Click += new System.EventHandler(this.btn_ks_null_Click);
            // 
            // btn_ks_null
            // 
            this.btn_ks_null.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_ks_null.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ks_null.ForeColor = System.Drawing.Color.Black;
            this.btn_ks_null.Location = new System.Drawing.Point(568, 303);
            this.btn_ks_null.Name = "btn_ks_null";
            this.btn_ks_null.Size = new System.Drawing.Size(97, 91);
            this.btn_ks_null.TabIndex = 0;
            this.btn_ks_null.Text = "0";
            this.btn_ks_null.UseVisualStyleBackColor = false;
            this.btn_ks_null.Click += new System.EventHandler(this.btn_ks_null_Click);
            // 
            // btn_ks_zwei
            // 
            this.btn_ks_zwei.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_ks_zwei.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ks_zwei.ForeColor = System.Drawing.Color.Black;
            this.btn_ks_zwei.Location = new System.Drawing.Point(568, 212);
            this.btn_ks_zwei.Name = "btn_ks_zwei";
            this.btn_ks_zwei.Size = new System.Drawing.Size(97, 91);
            this.btn_ks_zwei.TabIndex = 0;
            this.btn_ks_zwei.Text = "2";
            this.btn_ks_zwei.UseVisualStyleBackColor = false;
            this.btn_ks_zwei.Click += new System.EventHandler(this.btn_ks_null_Click);
            // 
            // btn_ks_fuenf
            // 
            this.btn_ks_fuenf.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_ks_fuenf.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ks_fuenf.ForeColor = System.Drawing.Color.Black;
            this.btn_ks_fuenf.Location = new System.Drawing.Point(568, 121);
            this.btn_ks_fuenf.Name = "btn_ks_fuenf";
            this.btn_ks_fuenf.Size = new System.Drawing.Size(97, 91);
            this.btn_ks_fuenf.TabIndex = 0;
            this.btn_ks_fuenf.Text = "5";
            this.btn_ks_fuenf.UseVisualStyleBackColor = false;
            this.btn_ks_fuenf.Click += new System.EventHandler(this.btn_ks_null_Click);
            // 
            // btn_ks_acht
            // 
            this.btn_ks_acht.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_ks_acht.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ks_acht.ForeColor = System.Drawing.Color.Black;
            this.btn_ks_acht.Location = new System.Drawing.Point(568, 28);
            this.btn_ks_acht.Name = "btn_ks_acht";
            this.btn_ks_acht.Size = new System.Drawing.Size(97, 91);
            this.btn_ks_acht.TabIndex = 0;
            this.btn_ks_acht.Text = "8";
            this.btn_ks_acht.UseVisualStyleBackColor = false;
            this.btn_ks_acht.Click += new System.EventHandler(this.btn_ks_null_Click);
            // 
            // btn_ks_komma
            // 
            this.btn_ks_komma.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_ks_komma.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ks_komma.ForeColor = System.Drawing.Color.Black;
            this.btn_ks_komma.Location = new System.Drawing.Point(465, 303);
            this.btn_ks_komma.Name = "btn_ks_komma";
            this.btn_ks_komma.Size = new System.Drawing.Size(97, 91);
            this.btn_ks_komma.TabIndex = 0;
            this.btn_ks_komma.Text = ",";
            this.btn_ks_komma.UseVisualStyleBackColor = false;
            this.btn_ks_komma.Click += new System.EventHandler(this.btn_ks_null_Click);
            // 
            // btn_ks_eins
            // 
            this.btn_ks_eins.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_ks_eins.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ks_eins.ForeColor = System.Drawing.Color.Black;
            this.btn_ks_eins.Location = new System.Drawing.Point(465, 212);
            this.btn_ks_eins.Name = "btn_ks_eins";
            this.btn_ks_eins.Size = new System.Drawing.Size(97, 91);
            this.btn_ks_eins.TabIndex = 0;
            this.btn_ks_eins.Text = "1";
            this.btn_ks_eins.UseVisualStyleBackColor = false;
            this.btn_ks_eins.Click += new System.EventHandler(this.btn_ks_null_Click);
            // 
            // btn_ks_vier
            // 
            this.btn_ks_vier.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_ks_vier.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ks_vier.ForeColor = System.Drawing.Color.Black;
            this.btn_ks_vier.Location = new System.Drawing.Point(465, 121);
            this.btn_ks_vier.Name = "btn_ks_vier";
            this.btn_ks_vier.Size = new System.Drawing.Size(97, 91);
            this.btn_ks_vier.TabIndex = 0;
            this.btn_ks_vier.Text = "4";
            this.btn_ks_vier.UseVisualStyleBackColor = false;
            this.btn_ks_vier.Click += new System.EventHandler(this.btn_ks_null_Click);
            // 
            // btn_ks_sieben
            // 
            this.btn_ks_sieben.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_ks_sieben.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ks_sieben.ForeColor = System.Drawing.Color.Black;
            this.btn_ks_sieben.Location = new System.Drawing.Point(465, 28);
            this.btn_ks_sieben.Name = "btn_ks_sieben";
            this.btn_ks_sieben.Size = new System.Drawing.Size(97, 91);
            this.btn_ks_sieben.TabIndex = 0;
            this.btn_ks_sieben.Text = "7";
            this.btn_ks_sieben.UseVisualStyleBackColor = false;
            this.btn_ks_sieben.Click += new System.EventHandler(this.btn_ks_null_Click);
            // 
            // btn_ks_zweihunderteuro
            // 
            this.btn_ks_zweihunderteuro.BackColor = System.Drawing.Color.Peru;
            this.btn_ks_zweihunderteuro.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ks_zweihunderteuro.ForeColor = System.Drawing.Color.Black;
            this.btn_ks_zweihunderteuro.Location = new System.Drawing.Point(1056, 284);
            this.btn_ks_zweihunderteuro.Name = "btn_ks_zweihunderteuro";
            this.btn_ks_zweihunderteuro.Size = new System.Drawing.Size(233, 121);
            this.btn_ks_zweihunderteuro.TabIndex = 0;
            this.btn_ks_zweihunderteuro.TabStop = false;
            this.btn_ks_zweihunderteuro.Text = "200,00 EUR";
            this.btn_ks_zweihunderteuro.UseVisualStyleBackColor = false;
            this.btn_ks_zweihunderteuro.Click += new System.EventHandler(this.btn_ks_zweihunderteuro_Click);
            // 
            // btn_ks_fuenfzigeuro
            // 
            this.btn_ks_fuenfzigeuro.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_ks_fuenfzigeuro.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ks_fuenfzigeuro.ForeColor = System.Drawing.Color.Black;
            this.btn_ks_fuenfzigeuro.Location = new System.Drawing.Point(1056, 157);
            this.btn_ks_fuenfzigeuro.Name = "btn_ks_fuenfzigeuro";
            this.btn_ks_fuenfzigeuro.Size = new System.Drawing.Size(233, 121);
            this.btn_ks_fuenfzigeuro.TabIndex = 0;
            this.btn_ks_fuenfzigeuro.TabStop = false;
            this.btn_ks_fuenfzigeuro.Text = "50,00 EUR";
            this.btn_ks_fuenfzigeuro.UseVisualStyleBackColor = false;
            this.btn_ks_fuenfzigeuro.Click += new System.EventHandler(this.btn_ks_fuenfzigeuro_Click);
            // 
            // btn_ks_zehneuro
            // 
            this.btn_ks_zehneuro.BackColor = System.Drawing.Color.Coral;
            this.btn_ks_zehneuro.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ks_zehneuro.ForeColor = System.Drawing.Color.Black;
            this.btn_ks_zehneuro.Location = new System.Drawing.Point(1056, 30);
            this.btn_ks_zehneuro.Name = "btn_ks_zehneuro";
            this.btn_ks_zehneuro.Size = new System.Drawing.Size(233, 121);
            this.btn_ks_zehneuro.TabIndex = 0;
            this.btn_ks_zehneuro.TabStop = false;
            this.btn_ks_zehneuro.Text = "10,00 EUR";
            this.btn_ks_zehneuro.UseVisualStyleBackColor = false;
            this.btn_ks_zehneuro.Click += new System.EventHandler(this.btn_ks_zehneuro_Click);
            // 
            // btn_ks_hunderteuro
            // 
            this.btn_ks_hunderteuro.BackColor = System.Drawing.Color.Green;
            this.btn_ks_hunderteuro.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ks_hunderteuro.ForeColor = System.Drawing.Color.Black;
            this.btn_ks_hunderteuro.Location = new System.Drawing.Point(817, 284);
            this.btn_ks_hunderteuro.Name = "btn_ks_hunderteuro";
            this.btn_ks_hunderteuro.Size = new System.Drawing.Size(233, 121);
            this.btn_ks_hunderteuro.TabIndex = 0;
            this.btn_ks_hunderteuro.TabStop = false;
            this.btn_ks_hunderteuro.Text = "100,00 EUR";
            this.btn_ks_hunderteuro.UseVisualStyleBackColor = false;
            this.btn_ks_hunderteuro.Click += new System.EventHandler(this.btn_ks_hunderteuro_Click);
            // 
            // btn_ks_zwanzigeuro
            // 
            this.btn_ks_zwanzigeuro.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_ks_zwanzigeuro.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ks_zwanzigeuro.ForeColor = System.Drawing.Color.Black;
            this.btn_ks_zwanzigeuro.Location = new System.Drawing.Point(817, 157);
            this.btn_ks_zwanzigeuro.Name = "btn_ks_zwanzigeuro";
            this.btn_ks_zwanzigeuro.Size = new System.Drawing.Size(233, 121);
            this.btn_ks_zwanzigeuro.TabIndex = 0;
            this.btn_ks_zwanzigeuro.TabStop = false;
            this.btn_ks_zwanzigeuro.Text = "20,00 EUR";
            this.btn_ks_zwanzigeuro.UseVisualStyleBackColor = false;
            this.btn_ks_zwanzigeuro.Click += new System.EventHandler(this.btn_ks_zwanzigeuro_Click);
            // 
            // btn_ks_fuenfeuro
            // 
            this.btn_ks_fuenfeuro.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_ks_fuenfeuro.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ks_fuenfeuro.ForeColor = System.Drawing.Color.Black;
            this.btn_ks_fuenfeuro.Location = new System.Drawing.Point(817, 30);
            this.btn_ks_fuenfeuro.Name = "btn_ks_fuenfeuro";
            this.btn_ks_fuenfeuro.Size = new System.Drawing.Size(233, 121);
            this.btn_ks_fuenfeuro.TabIndex = 0;
            this.btn_ks_fuenfeuro.TabStop = false;
            this.btn_ks_fuenfeuro.Text = "5,00 EUR";
            this.btn_ks_fuenfeuro.UseVisualStyleBackColor = false;
            this.btn_ks_fuenfeuro.Click += new System.EventHandler(this.btn_ks_fuenfeuro_Click);
            // 
            // btn_ks_eczahlung
            // 
            this.btn_ks_eczahlung.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ks_eczahlung.Location = new System.Drawing.Point(911, 556);
            this.btn_ks_eczahlung.Name = "btn_ks_eczahlung";
            this.btn_ks_eczahlung.Size = new System.Drawing.Size(201, 119);
            this.btn_ks_eczahlung.TabIndex = 0;
            this.btn_ks_eczahlung.Text = "EC\r\nZAHLUNG";
            this.btn_ks_eczahlung.UseVisualStyleBackColor = true;
            this.btn_ks_eczahlung.Click += new System.EventHandler(this.btn_ks_eczahlung_Click);
            // 
            // btn_ks_barzahlung
            // 
            this.btn_ks_barzahlung.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ks_barzahlung.Location = new System.Drawing.Point(704, 556);
            this.btn_ks_barzahlung.Name = "btn_ks_barzahlung";
            this.btn_ks_barzahlung.Size = new System.Drawing.Size(201, 119);
            this.btn_ks_barzahlung.TabIndex = 0;
            this.btn_ks_barzahlung.Text = "BAR";
            this.btn_ks_barzahlung.UseVisualStyleBackColor = true;
            this.btn_ks_barzahlung.Click += new System.EventHandler(this.btn_ks_barzahlung_Click);
            // 
            // Kasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1331, 728);
            this.Controls.Add(this.lbl_kasse_rueckgeld);
            this.Controls.Add(this.btn_ks_clear);
            this.Controls.Add(this.lbl_kasse_rabatt);
            this.Controls.Add(this.btn_ks_zweihunderteuro);
            this.Controls.Add(this.lbl_kasse_gegeben);
            this.Controls.Add(this.btn_ks_drei);
            this.Controls.Add(this.lbl_kasse_summe);
            this.Controls.Add(this.btn_ks_fuenfzigeuro);
            this.Controls.Add(this.tb_kasse_gegeben);
            this.Controls.Add(this.btn_ks_sechs);
            this.Controls.Add(this.tb_kasse_rueckgeld);
            this.Controls.Add(this.tb_kasse_rabatt);
            this.Controls.Add(this.btn_ks_eczahlung);
            this.Controls.Add(this.tb_kasse_summe);
            this.Controls.Add(this.btn_ks_neun);
            this.Controls.Add(this.btn_ks_zehneuro);
            this.Controls.Add(this.btn_ks_null);
            this.Controls.Add(this.btn_ks_barzahlung);
            this.Controls.Add(this.btn_ks_zwei);
            this.Controls.Add(this.btn_ks_hunderteuro);
            this.Controls.Add(this.btn_ks_fuenf);
            this.Controls.Add(this.btn_ks_zwanzigeuro);
            this.Controls.Add(this.btn_ks_acht);
            this.Controls.Add(this.btn_ks_komma);
            this.Controls.Add(this.btn_ks_eins);
            this.Controls.Add(this.btn_ks_fuenfeuro);
            this.Controls.Add(this.btn_ks_vier);
            this.Controls.Add(this.btn_ks_sieben);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kasse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kasse";
            this.Load += new System.EventHandler(this.Kasse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_kasse_summe;
        private System.Windows.Forms.TextBox tb_kasse_gegeben;
        private System.Windows.Forms.TextBox tb_kasse_rueckgeld;
        private System.Windows.Forms.TextBox tb_kasse_rabatt;
        private System.Windows.Forms.TextBox tb_kasse_summe;
        private System.Windows.Forms.Label lbl_kasse_rueckgeld;
        private System.Windows.Forms.Label lbl_kasse_rabatt;
        private System.Windows.Forms.Label lbl_kasse_gegeben;
        private System.Windows.Forms.Button btn_ks_sieben;
        private System.Windows.Forms.Button btn_ks_neun;
        private System.Windows.Forms.Button btn_ks_acht;
        private System.Windows.Forms.Button btn_ks_clear;
        private System.Windows.Forms.Button btn_ks_drei;
        private System.Windows.Forms.Button btn_ks_sechs;
        private System.Windows.Forms.Button btn_ks_null;
        private System.Windows.Forms.Button btn_ks_zwei;
        private System.Windows.Forms.Button btn_ks_fuenf;
        private System.Windows.Forms.Button btn_ks_komma;
        private System.Windows.Forms.Button btn_ks_eins;
        private System.Windows.Forms.Button btn_ks_vier;
        private System.Windows.Forms.Button btn_ks_fuenfeuro;
        private System.Windows.Forms.Button btn_ks_zweihunderteuro;
        private System.Windows.Forms.Button btn_ks_fuenfzigeuro;
        private System.Windows.Forms.Button btn_ks_zehneuro;
        private System.Windows.Forms.Button btn_ks_hunderteuro;
        private System.Windows.Forms.Button btn_ks_zwanzigeuro;
        private System.Windows.Forms.Button btn_ks_eczahlung;
        private System.Windows.Forms.Button btn_ks_barzahlung;
    }
}