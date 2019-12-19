namespace AnimalHouse_GUI
{
    partial class AnimalHouseGui_Lager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalHouseGui_Lager));
            this.button_PrintStatus = new System.Windows.Forms.Button();
            this.button_UdskriftStatus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_SøgId = new System.Windows.Forms.TextBox();
            this.button_SøgLagerStatus = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox_UdskriftStatus = new System.Windows.Forms.GroupBox();
            this.richTextBox_UdskrivStatus = new System.Windows.Forms.RichTextBox();
            this.dataGridView_LagerStatus = new System.Windows.Forms.DataGridView();
            this.groupBox_LagerStatus = new System.Windows.Forms.GroupBox();
            this.label_hjælpe = new System.Windows.Forms.Label();
            this.button_Tilbage = new System.Windows.Forms.Button();
            this.tabController = new System.Windows.Forms.TabControl();
            this.tabStatus = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.tabTilføj = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Tilbage2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button_Update = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Produkt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Antal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Tilføj = new System.Windows.Forms.Button();
            this.textBox_Pris = new System.Windows.Forms.TextBox();
            this.dataGridView_LagerTilføj = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox_UdskriftStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LagerStatus)).BeginInit();
            this.groupBox_LagerStatus.SuspendLayout();
            this.tabController.SuspendLayout();
            this.tabStatus.SuspendLayout();
            this.tabTilføj.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LagerTilføj)).BeginInit();
            this.SuspendLayout();
            // 
            // button_PrintStatus
            // 
            this.button_PrintStatus.AutoSize = true;
            this.button_PrintStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_PrintStatus.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PrintStatus.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_PrintStatus.Location = new System.Drawing.Point(33, 551);
            this.button_PrintStatus.Margin = new System.Windows.Forms.Padding(2);
            this.button_PrintStatus.Name = "button_PrintStatus";
            this.button_PrintStatus.Size = new System.Drawing.Size(105, 44);
            this.button_PrintStatus.TabIndex = 108;
            this.button_PrintStatus.Text = "Export";
            this.button_PrintStatus.UseVisualStyleBackColor = false;
            this.button_PrintStatus.Click += new System.EventHandler(this.button_PrintStatus_Click_1);
            // 
            // button_UdskriftStatus
            // 
            this.button_UdskriftStatus.AutoSize = true;
            this.button_UdskriftStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_UdskriftStatus.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_UdskriftStatus.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_UdskriftStatus.Location = new System.Drawing.Point(33, 503);
            this.button_UdskriftStatus.Margin = new System.Windows.Forms.Padding(2);
            this.button_UdskriftStatus.Name = "button_UdskriftStatus";
            this.button_UdskriftStatus.Size = new System.Drawing.Size(105, 44);
            this.button_UdskriftStatus.TabIndex = 107;
            this.button_UdskriftStatus.Text = "Print";
            this.button_UdskriftStatus.UseVisualStyleBackColor = false;
            this.button_UdskriftStatus.Click += new System.EventHandler(this.button_UdskriftStatus_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 531);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 16);
            this.label1.TabIndex = 117;
            this.label1.Text = "Søg i lageret ved hjælp af Produkt Id";
            // 
            // textBox_SøgId
            // 
            this.textBox_SøgId.Location = new System.Drawing.Point(33, 552);
            this.textBox_SøgId.Name = "textBox_SøgId";
            this.textBox_SøgId.Size = new System.Drawing.Size(486, 22);
            this.textBox_SøgId.TabIndex = 116;
            this.textBox_SøgId.TextChanged += new System.EventHandler(this.textBox_SøgId_TextChanged);
            // 
            // button_SøgLagerStatus
            // 
            this.button_SøgLagerStatus.AutoSize = true;
            this.button_SøgLagerStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_SøgLagerStatus.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SøgLagerStatus.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_SøgLagerStatus.Location = new System.Drawing.Point(33, 503);
            this.button_SøgLagerStatus.Margin = new System.Windows.Forms.Padding(2);
            this.button_SøgLagerStatus.Name = "button_SøgLagerStatus";
            this.button_SøgLagerStatus.Size = new System.Drawing.Size(105, 44);
            this.button_SøgLagerStatus.TabIndex = 111;
            this.button_SøgLagerStatus.Text = "Søgning";
            this.button_SøgLagerStatus.UseVisualStyleBackColor = false;
            this.button_SøgLagerStatus.Click += new System.EventHandler(this.button_SøgLagerStatus_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(143, 579);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 16);
            this.label4.TabIndex = 117;
            this.label4.Text = "Export Database som .txt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 531);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 16);
            this.label3.TabIndex = 116;
            this.label3.Text = "Udskriv Lagerstatus til monitor";
            // 
            // groupBox_UdskriftStatus
            // 
            this.groupBox_UdskriftStatus.Controls.Add(this.label4);
            this.groupBox_UdskriftStatus.Controls.Add(this.label3);
            this.groupBox_UdskriftStatus.Controls.Add(this.button_PrintStatus);
            this.groupBox_UdskriftStatus.Controls.Add(this.button_UdskriftStatus);
            this.groupBox_UdskriftStatus.Controls.Add(this.richTextBox_UdskrivStatus);
            this.groupBox_UdskriftStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_UdskriftStatus.Location = new System.Drawing.Point(596, 25);
            this.groupBox_UdskriftStatus.Name = "groupBox_UdskriftStatus";
            this.groupBox_UdskriftStatus.Size = new System.Drawing.Size(551, 608);
            this.groupBox_UdskriftStatus.TabIndex = 116;
            this.groupBox_UdskriftStatus.TabStop = false;
            this.groupBox_UdskriftStatus.Text = "Udskriv Lager";
            // 
            // richTextBox_UdskrivStatus
            // 
            this.richTextBox_UdskrivStatus.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox_UdskrivStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox_UdskrivStatus.Location = new System.Drawing.Point(33, 20);
            this.richTextBox_UdskrivStatus.Name = "richTextBox_UdskrivStatus";
            this.richTextBox_UdskrivStatus.ReadOnly = true;
            this.richTextBox_UdskrivStatus.Size = new System.Drawing.Size(486, 478);
            this.richTextBox_UdskrivStatus.TabIndex = 105;
            this.richTextBox_UdskrivStatus.Text = "";
            this.richTextBox_UdskrivStatus.TextChanged += new System.EventHandler(this.richTextBox_UdskrivStatus_TextChanged);
            // 
            // dataGridView_LagerStatus
            // 
            this.dataGridView_LagerStatus.AllowUserToDeleteRows = false;
            this.dataGridView_LagerStatus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView_LagerStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_LagerStatus.Location = new System.Drawing.Point(33, 20);
            this.dataGridView_LagerStatus.Name = "dataGridView_LagerStatus";
            this.dataGridView_LagerStatus.ReadOnly = true;
            this.dataGridView_LagerStatus.RowHeadersWidth = 62;
            this.dataGridView_LagerStatus.Size = new System.Drawing.Size(486, 478);
            this.dataGridView_LagerStatus.TabIndex = 104;
            this.dataGridView_LagerStatus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_LagerStatus_CellContentClick_1);
            // 
            // groupBox_LagerStatus
            // 
            this.groupBox_LagerStatus.Controls.Add(this.label1);
            this.groupBox_LagerStatus.Controls.Add(this.textBox_SøgId);
            this.groupBox_LagerStatus.Controls.Add(this.button_SøgLagerStatus);
            this.groupBox_LagerStatus.Controls.Add(this.dataGridView_LagerStatus);
            this.groupBox_LagerStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_LagerStatus.Location = new System.Drawing.Point(38, 25);
            this.groupBox_LagerStatus.Name = "groupBox_LagerStatus";
            this.groupBox_LagerStatus.Size = new System.Drawing.Size(552, 608);
            this.groupBox_LagerStatus.TabIndex = 115;
            this.groupBox_LagerStatus.TabStop = false;
            this.groupBox_LagerStatus.Text = "Lager Status";
            // 
            // label_hjælpe
            // 
            this.label_hjælpe.AutoSize = true;
            this.label_hjælpe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hjælpe.Location = new System.Drawing.Point(35, 664);
            this.label_hjælpe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_hjælpe.Name = "label_hjælpe";
            this.label_hjælpe.Size = new System.Drawing.Size(17, 18);
            this.label_hjælpe.TabIndex = 117;
            this.label_hjælpe.Text = "?";
            this.label_hjælpe.Click += new System.EventHandler(this.label_hjælpe_Click);
            // 
            // button_Tilbage
            // 
            this.button_Tilbage.AutoSize = true;
            this.button_Tilbage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Tilbage.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Tilbage.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_Tilbage.Location = new System.Drawing.Point(1042, 638);
            this.button_Tilbage.Margin = new System.Windows.Forms.Padding(2);
            this.button_Tilbage.Name = "button_Tilbage";
            this.button_Tilbage.Size = new System.Drawing.Size(105, 44);
            this.button_Tilbage.TabIndex = 114;
            this.button_Tilbage.Text = "Tilbage";
            this.button_Tilbage.UseVisualStyleBackColor = false;
            this.button_Tilbage.Click += new System.EventHandler(this.button_Tilbage_Click_1);
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.tabStatus);
            this.tabController.Controls.Add(this.tabTilføj);
            this.tabController.Location = new System.Drawing.Point(12, 11);
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(1197, 725);
            this.tabController.TabIndex = 118;
            // 
            // tabStatus
            // 
            this.tabStatus.Controls.Add(this.label10);
            this.tabStatus.Controls.Add(this.groupBox_LagerStatus);
            this.tabStatus.Controls.Add(this.label_hjælpe);
            this.tabStatus.Controls.Add(this.button_Tilbage);
            this.tabStatus.Controls.Add(this.groupBox_UdskriftStatus);
            this.tabStatus.Location = new System.Drawing.Point(4, 22);
            this.tabStatus.Name = "tabStatus";
            this.tabStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatus.Size = new System.Drawing.Size(1189, 699);
            this.tabStatus.TabIndex = 0;
            this.tabStatus.Text = "Status";
            this.tabStatus.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1044, 680);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 16);
            this.label10.TabIndex = 137;
            this.label10.Text = "Til Hoved Menu";
            // 
            // tabTilføj
            // 
            this.tabTilføj.Controls.Add(this.label7);
            this.tabTilføj.Controls.Add(this.label2);
            this.tabTilføj.Controls.Add(this.button_Tilbage2);
            this.tabTilføj.Controls.Add(this.groupBox1);
            this.tabTilføj.Location = new System.Drawing.Point(4, 22);
            this.tabTilføj.Name = "tabTilføj";
            this.tabTilføj.Padding = new System.Windows.Forms.Padding(3);
            this.tabTilføj.Size = new System.Drawing.Size(1189, 699);
            this.tabTilføj.TabIndex = 1;
            this.tabTilføj.Text = "Tilføj";
            this.tabTilføj.UseVisualStyleBackColor = true;
            this.tabTilføj.Click += new System.EventHandler(this.tabTilføj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1044, 680);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 136;
            this.label2.Text = "Til Hoved Menu";
            // 
            // button_Tilbage2
            // 
            this.button_Tilbage2.AutoSize = true;
            this.button_Tilbage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Tilbage2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Tilbage2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_Tilbage2.Location = new System.Drawing.Point(1042, 638);
            this.button_Tilbage2.Margin = new System.Windows.Forms.Padding(2);
            this.button_Tilbage2.Name = "button_Tilbage2";
            this.button_Tilbage2.Size = new System.Drawing.Size(105, 44);
            this.button_Tilbage2.TabIndex = 118;
            this.button_Tilbage2.Text = "Tilbage";
            this.button_Tilbage2.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.button_Update);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox_Produkt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox_Antal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button_Tilføj);
            this.groupBox1.Controls.Add(this.textBox_Pris);
            this.groupBox1.Controls.Add(this.dataGridView_LagerTilføj);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1109, 608);
            this.groupBox1.TabIndex = 116;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lager Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(634, 338);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 16);
            this.label11.TabIndex = 137;
            this.label11.Text = "Opdater lagerstatus";
            // 
            // button_Update
            // 
            this.button_Update.AutoSize = true;
            this.button_Update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Update.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_Update.Location = new System.Drawing.Point(524, 323);
            this.button_Update.Margin = new System.Windows.Forms.Padding(2);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(105, 44);
            this.button_Update.TabIndex = 136;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(525, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 135;
            this.label9.Text = "Produkt ID";
            // 
            // textBox_Produkt
            // 
            this.textBox_Produkt.Location = new System.Drawing.Point(525, 213);
            this.textBox_Produkt.Name = "textBox_Produkt";
            this.textBox_Produkt.Size = new System.Drawing.Size(486, 22);
            this.textBox_Produkt.TabIndex = 134;
            this.textBox_Produkt.TextChanged += new System.EventHandler(this.textBox_Produkt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(525, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 131;
            this.label8.Text = "Antal";
            // 
            // textBox_Antal
            // 
            this.textBox_Antal.Location = new System.Drawing.Point(525, 125);
            this.textBox_Antal.Name = "textBox_Antal";
            this.textBox_Antal.Size = new System.Drawing.Size(486, 22);
            this.textBox_Antal.TabIndex = 130;
            this.textBox_Antal.TextChanged += new System.EventHandler(this.textBox_Antal_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(525, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 122;
            this.label6.Text = "Pris";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(634, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 16);
            this.label5.TabIndex = 119;
            this.label5.Text = "Tilføj produkt til lager";
            // 
            // button_Tilføj
            // 
            this.button_Tilføj.AutoSize = true;
            this.button_Tilføj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Tilføj.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Tilføj.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_Tilføj.Location = new System.Drawing.Point(524, 255);
            this.button_Tilføj.Margin = new System.Windows.Forms.Padding(2);
            this.button_Tilføj.Name = "button_Tilføj";
            this.button_Tilføj.Size = new System.Drawing.Size(105, 44);
            this.button_Tilføj.TabIndex = 118;
            this.button_Tilføj.Text = "Tilføj";
            this.button_Tilføj.UseVisualStyleBackColor = false;
            this.button_Tilføj.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_Pris
            // 
            this.textBox_Pris.Location = new System.Drawing.Point(525, 37);
            this.textBox_Pris.Name = "textBox_Pris";
            this.textBox_Pris.Size = new System.Drawing.Size(486, 22);
            this.textBox_Pris.TabIndex = 116;
            this.textBox_Pris.TextChanged += new System.EventHandler(this.textBox_Pris_TextChanged);
            // 
            // dataGridView_LagerTilføj
            // 
            this.dataGridView_LagerTilføj.AllowUserToDeleteRows = false;
            this.dataGridView_LagerTilføj.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView_LagerTilføj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_LagerTilføj.Location = new System.Drawing.Point(33, 20);
            this.dataGridView_LagerTilføj.Name = "dataGridView_LagerTilføj";
            this.dataGridView_LagerTilføj.ReadOnly = true;
            this.dataGridView_LagerTilføj.RowHeadersWidth = 62;
            this.dataGridView_LagerTilføj.Size = new System.Drawing.Size(486, 478);
            this.dataGridView_LagerTilføj.TabIndex = 104;
            this.dataGridView_LagerTilføj.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 664);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 18);
            this.label7.TabIndex = 137;
            this.label7.Text = "?";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // AnimalHouseGui_Lager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 748);
            this.Controls.Add(this.tabController);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnimalHouseGui_Lager";
            this.Text = "Animal House";
            this.Load += new System.EventHandler(this.AnimalHouseGui_Lager_Load);
            this.groupBox_UdskriftStatus.ResumeLayout(false);
            this.groupBox_UdskriftStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LagerStatus)).EndInit();
            this.groupBox_LagerStatus.ResumeLayout(false);
            this.groupBox_LagerStatus.PerformLayout();
            this.tabController.ResumeLayout(false);
            this.tabStatus.ResumeLayout(false);
            this.tabStatus.PerformLayout();
            this.tabTilføj.ResumeLayout(false);
            this.tabTilføj.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LagerTilføj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_PrintStatus;
        private System.Windows.Forms.Button button_UdskriftStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_SøgId;
        private System.Windows.Forms.Button button_SøgLagerStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox_UdskriftStatus;
        private System.Windows.Forms.RichTextBox richTextBox_UdskrivStatus;
        private System.Windows.Forms.DataGridView dataGridView_LagerStatus;
        private System.Windows.Forms.GroupBox groupBox_LagerStatus;
        private System.Windows.Forms.Button button_Tilbage;
        private System.Windows.Forms.Label label_hjælpe;
        public  System.Windows.Forms.TabControl tabController;
        public System.Windows.Forms.TabPage tabStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Tilføj;
        private System.Windows.Forms.TextBox textBox_Pris;
        private System.Windows.Forms.DataGridView dataGridView_LagerTilføj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Produkt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Antal;
        private System.Windows.Forms.Button button_Tilbage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_Update;
        public System.Windows.Forms.TabPage tabTilføj;
        private System.Windows.Forms.Label label7;
    }
}