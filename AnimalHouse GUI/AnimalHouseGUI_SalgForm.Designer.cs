namespace AnimalHouse_GUI
{
    partial class AnimalHouseGUI_SalgForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalHouseGUI_SalgForm));
            this.button_tilbage = new System.Windows.Forms.Button();
            this.label_hjælpe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_kunde = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_kategori = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_produkter = new System.Windows.Forms.ComboBox();
            this.listBox_produkter = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_rabat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.button_annullere = new System.Windows.Forms.Button();
            this.button_print = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label_res = new System.Windows.Forms.Label();
            this.button_gem = new System.Windows.Forms.Button();
            this.button_hentAlle = new System.Windows.Forms.Button();
            this.button_søg = new System.Windows.Forms.Button();
            this.button_visRecord = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_info5 = new System.Windows.Forms.TextBox();
            this.textBox_info4 = new System.Windows.Forms.TextBox();
            this.textBox_info3 = new System.Windows.Forms.TextBox();
            this.textBox_info1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_info2 = new System.Windows.Forms.TextBox();
            this.textBox_info6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_beregn = new System.Windows.Forms.Button();
            this.numericUpDown_antal = new System.Windows.Forms.NumericUpDown();
            this.comboBox_kunde2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_antal)).BeginInit();
            this.SuspendLayout();
            // 
            // button_tilbage
            // 
            this.button_tilbage.AutoSize = true;
            this.button_tilbage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_tilbage.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tilbage.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_tilbage.Location = new System.Drawing.Point(1558, 971);
            this.button_tilbage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_tilbage.Name = "button_tilbage";
            this.button_tilbage.Size = new System.Drawing.Size(193, 58);
            this.button_tilbage.TabIndex = 0;
            this.button_tilbage.Text = "Tilbage";
            this.button_tilbage.UseVisualStyleBackColor = false;
            this.button_tilbage.Click += new System.EventHandler(this.button_tilbage_Click);
            // 
            // label_hjælpe
            // 
            this.label_hjælpe.AutoSize = true;
            this.label_hjælpe.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hjælpe.Location = new System.Drawing.Point(8, 1012);
            this.label_hjælpe.Name = "label_hjælpe";
            this.label_hjælpe.Size = new System.Drawing.Size(22, 24);
            this.label_hjælpe.TabIndex = 1;
            this.label_hjælpe.Text = "?";
            this.label_hjælpe.Click += new System.EventHandler(this.label_hjælpe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "vælg kunde:";
            // 
            // comboBox_kunde
            // 
            this.comboBox_kunde.FormattingEnabled = true;
            this.comboBox_kunde.Location = new System.Drawing.Point(268, 22);
            this.comboBox_kunde.Name = "comboBox_kunde";
            this.comboBox_kunde.Size = new System.Drawing.Size(290, 28);
            this.comboBox_kunde.TabIndex = 3;
            this.comboBox_kunde.SelectedIndexChanged += new System.EventHandler(this.comboBox_kunde_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vælg produktkategori:";
            // 
            // comboBox_kategori
            // 
            this.comboBox_kategori.FormattingEnabled = true;
            this.comboBox_kategori.Location = new System.Drawing.Point(268, 68);
            this.comboBox_kategori.Name = "comboBox_kategori";
            this.comboBox_kategori.Size = new System.Drawing.Size(290, 28);
            this.comboBox_kategori.TabIndex = 5;
            this.comboBox_kategori.SelectedIndexChanged += new System.EventHandler(this.comboBox_kategori_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vælg produkt:";
            // 
            // comboBox_produkter
            // 
            this.comboBox_produkter.FormattingEnabled = true;
            this.comboBox_produkter.Location = new System.Drawing.Point(268, 118);
            this.comboBox_produkter.Name = "comboBox_produkter";
            this.comboBox_produkter.Size = new System.Drawing.Size(522, 28);
            this.comboBox_produkter.TabIndex = 7;
            // 
            // listBox_produkter
            // 
            this.listBox_produkter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBox_produkter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_produkter.FormattingEnabled = true;
            this.listBox_produkter.HorizontalScrollbar = true;
            this.listBox_produkter.ItemHeight = 21;
            this.listBox_produkter.Location = new System.Drawing.Point(266, 225);
            this.listBox_produkter.Name = "listBox_produkter";
            this.listBox_produkter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox_produkter.Size = new System.Drawing.Size(523, 403);
            this.listBox_produkter.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(106, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 62);
            this.button1.TabIndex = 10;
            this.button1.Text = "Tilføje";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(880, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(788, 323);
            this.dataGridView1.TabIndex = 11;
            // 
            // textBox_rabat
            // 
            this.textBox_rabat.Location = new System.Drawing.Point(375, 678);
            this.textBox_rabat.Name = "textBox_rabat";
            this.textBox_rabat.Size = new System.Drawing.Size(42, 26);
            this.textBox_rabat.TabIndex = 12;
            this.textBox_rabat.Text = "0";
            this.textBox_rabat.TextChanged += new System.EventHandler(this.textBox_rabat_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(270, 678);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Rabat i %";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.Location = new System.Drawing.Point(526, 678);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(57, 24);
            this.label_total.TabIndex = 15;
            this.label_total.Text = "Total";
            // 
            // button_annullere
            // 
            this.button_annullere.AutoSize = true;
            this.button_annullere.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_annullere.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_annullere.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_annullere.Location = new System.Drawing.Point(106, 378);
            this.button_annullere.Name = "button_annullere";
            this.button_annullere.Size = new System.Drawing.Size(142, 62);
            this.button_annullere.TabIndex = 16;
            this.button_annullere.Text = "Annullere";
            this.button_annullere.UseVisualStyleBackColor = false;
            this.button_annullere.Click += new System.EventHandler(this.button_annullere_Click);
            // 
            // button_print
            // 
            this.button_print.AutoSize = true;
            this.button_print.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_print.Enabled = false;
            this.button_print.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_print.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_print.Location = new System.Drawing.Point(725, 375);
            this.button_print.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(224, 40);
            this.button_print.TabIndex = 17;
            this.button_print.Text = "Print kvittering";
            this.button_print.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(189, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Antal";
            // 
            // label_res
            // 
            this.label_res.AutoSize = true;
            this.label_res.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_res.Location = new System.Drawing.Point(602, 672);
            this.label_res.Name = "label_res";
            this.label_res.Size = new System.Drawing.Size(76, 33);
            this.label_res.TabIndex = 20;
            this.label_res.Text = "0 Kr.";
            // 
            // button_gem
            // 
            this.button_gem.AutoSize = true;
            this.button_gem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_gem.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_gem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_gem.Location = new System.Drawing.Point(375, 712);
            this.button_gem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_gem.Name = "button_gem";
            this.button_gem.Size = new System.Drawing.Size(110, 52);
            this.button_gem.TabIndex = 21;
            this.button_gem.Text = "Gem";
            this.button_gem.UseVisualStyleBackColor = false;
            this.button_gem.Click += new System.EventHandler(this.button_gem_Click);
            // 
            // button_hentAlle
            // 
            this.button_hentAlle.AutoSize = true;
            this.button_hentAlle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_hentAlle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hentAlle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_hentAlle.Location = new System.Drawing.Point(880, 457);
            this.button_hentAlle.Name = "button_hentAlle";
            this.button_hentAlle.Size = new System.Drawing.Size(142, 49);
            this.button_hentAlle.TabIndex = 22;
            this.button_hentAlle.Text = "Hent Alle";
            this.button_hentAlle.UseVisualStyleBackColor = false;
            this.button_hentAlle.Click += new System.EventHandler(this.button_hentAlle_Click);
            // 
            // button_søg
            // 
            this.button_søg.AutoSize = true;
            this.button_søg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_søg.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_søg.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_søg.Location = new System.Drawing.Point(1340, 58);
            this.button_søg.Name = "button_søg";
            this.button_søg.Size = new System.Drawing.Size(116, 42);
            this.button_søg.TabIndex = 25;
            this.button_søg.Text = "Søg";
            this.button_søg.UseVisualStyleBackColor = false;
            this.button_søg.Click += new System.EventHandler(this.button_søg_Click);
            // 
            // button_visRecord
            // 
            this.button_visRecord.AutoSize = true;
            this.button_visRecord.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_visRecord.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_visRecord.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_visRecord.Location = new System.Drawing.Point(1028, 457);
            this.button_visRecord.Name = "button_visRecord";
            this.button_visRecord.Size = new System.Drawing.Size(244, 49);
            this.button_visRecord.TabIndex = 26;
            this.button_visRecord.Text = "Vis kvittering info.";
            this.button_visRecord.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_info5);
            this.groupBox1.Controls.Add(this.textBox_info4);
            this.groupBox1.Controls.Add(this.textBox_info3);
            this.groupBox1.Controls.Add(this.textBox_info1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBox_info2);
            this.groupBox1.Controls.Add(this.textBox_info6);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button_print);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(795, 523);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(956, 429);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kvittering info.";
            // 
            // textBox_info5
            // 
            this.textBox_info5.Location = new System.Drawing.Point(401, 340);
            this.textBox_info5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_info5.Name = "textBox_info5";
            this.textBox_info5.ReadOnly = true;
            this.textBox_info5.Size = new System.Drawing.Size(260, 30);
            this.textBox_info5.TabIndex = 39;
            // 
            // textBox_info4
            // 
            this.textBox_info4.Location = new System.Drawing.Point(119, 337);
            this.textBox_info4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_info4.Name = "textBox_info4";
            this.textBox_info4.ReadOnly = true;
            this.textBox_info4.Size = new System.Drawing.Size(62, 30);
            this.textBox_info4.TabIndex = 38;
            // 
            // textBox_info3
            // 
            this.textBox_info3.Location = new System.Drawing.Point(595, 39);
            this.textBox_info3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_info3.Name = "textBox_info3";
            this.textBox_info3.ReadOnly = true;
            this.textBox_info3.Size = new System.Drawing.Size(278, 30);
            this.textBox_info3.TabIndex = 37;
            // 
            // textBox_info1
            // 
            this.textBox_info1.Location = new System.Drawing.Point(108, 42);
            this.textBox_info1.Name = "textBox_info1";
            this.textBox_info1.ReadOnly = true;
            this.textBox_info1.Size = new System.Drawing.Size(278, 30);
            this.textBox_info1.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(0, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 24);
            this.label12.TabIndex = 35;
            this.label12.Text = "faktura ID";
            // 
            // textBox_info2
            // 
            this.textBox_info2.Location = new System.Drawing.Point(108, 93);
            this.textBox_info2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_info2.Name = "textBox_info2";
            this.textBox_info2.ReadOnly = true;
            this.textBox_info2.Size = new System.Drawing.Size(278, 30);
            this.textBox_info2.TabIndex = 30;
            // 
            // textBox_info6
            // 
            this.textBox_info6.Location = new System.Drawing.Point(9, 185);
            this.textBox_info6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_info6.Multiline = true;
            this.textBox_info6.Name = "textBox_info6";
            this.textBox_info6.ReadOnly = true;
            this.textBox_info6.Size = new System.Drawing.Size(940, 120);
            this.textBox_info6.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 143);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 24);
            this.label11.TabIndex = 34;
            this.label11.Text = "produkter list";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 340);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 24);
            this.label10.TabIndex = 33;
            this.label10.Text = "Rabat i %";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 99);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 24);
            this.label9.TabIndex = 32;
            this.label9.Text = "kunde";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(481, 39);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 24);
            this.label7.TabIndex = 31;
            this.label7.Text = "dato";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(329, 346);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "Total";
            // 
            // button_beregn
            // 
            this.button_beregn.AutoSize = true;
            this.button_beregn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_beregn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_beregn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_beregn.Location = new System.Drawing.Point(264, 712);
            this.button_beregn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_beregn.Name = "button_beregn";
            this.button_beregn.Size = new System.Drawing.Size(103, 52);
            this.button_beregn.TabIndex = 28;
            this.button_beregn.Text = "Beregne";
            this.button_beregn.UseVisualStyleBackColor = false;
            this.button_beregn.Click += new System.EventHandler(this.button_beregn_Click);
            // 
            // numericUpDown_antal
            // 
            this.numericUpDown_antal.Location = new System.Drawing.Point(274, 172);
            this.numericUpDown_antal.Name = "numericUpDown_antal";
            this.numericUpDown_antal.Size = new System.Drawing.Size(74, 26);
            this.numericUpDown_antal.TabIndex = 29;
            // 
            // comboBox_kunde2
            // 
            this.comboBox_kunde2.FormattingEnabled = true;
            this.comboBox_kunde2.Location = new System.Drawing.Point(1034, 68);
            this.comboBox_kunde2.Name = "comboBox_kunde2";
            this.comboBox_kunde2.Size = new System.Drawing.Size(290, 28);
            this.comboBox_kunde2.TabIndex = 31;
            this.comboBox_kunde2.MouseEnter += new System.EventHandler(this.comboBox_kunde2_MouseEnter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(885, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 24);
            this.label8.TabIndex = 30;
            this.label8.Text = "vælg kunde:";
            // 
            // AnimalHouseGUI_SalgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 1043);
            this.Controls.Add(this.comboBox_kunde2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown_antal);
            this.Controls.Add(this.button_beregn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_visRecord);
            this.Controls.Add(this.button_søg);
            this.Controls.Add(this.button_hentAlle);
            this.Controls.Add(this.button_gem);
            this.Controls.Add(this.label_res);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_annullere);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_rabat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox_produkter);
            this.Controls.Add(this.comboBox_produkter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_kategori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_kunde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_hjælpe);
            this.Controls.Add(this.button_tilbage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnimalHouseGUI_SalgForm";
            this.Text = "Animal House";
            this.Load += new System.EventHandler(this.AnimalHouseGUI_SalgForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_antal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_tilbage;
        private System.Windows.Forms.Label label_hjælpe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_kunde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_kategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_produkter;
        private System.Windows.Forms.ListBox listBox_produkter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_rabat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Button button_annullere;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_res;
        private System.Windows.Forms.Button button_gem;
        private System.Windows.Forms.Button button_hentAlle;
        private System.Windows.Forms.Button button_søg;
        private System.Windows.Forms.Button button_visRecord;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_beregn;
        private System.Windows.Forms.NumericUpDown numericUpDown_antal;
        private System.Windows.Forms.TextBox textBox_info5;
        private System.Windows.Forms.TextBox textBox_info4;
        private System.Windows.Forms.TextBox textBox_info3;
        private System.Windows.Forms.TextBox textBox_info1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_info2;
        private System.Windows.Forms.TextBox textBox_info6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_kunde2;
        private System.Windows.Forms.Label label8;
    }
}