namespace AnimalHouse_GUI
{
    partial class AnimalHouseGui_Booking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalHouseGui_Booking));
            this.dateTimePicker_StartDato = new System.Windows.Forms.DateTimePicker();
            this.label_StartDato = new System.Windows.Forms.Label();
            this.dateTimePicker_SlutDato = new System.Windows.Forms.DateTimePicker();
            this.textBox_EjerIdBooking = new System.Windows.Forms.TextBox();
            this.label_BehandlerIdBooking = new System.Windows.Forms.Label();
            this.label_EjerIdBooking = new System.Windows.Forms.Label();
            this.button_RegBooking = new System.Windows.Forms.Button();
            this.button_AnulBooking = new System.Windows.Forms.Button();
            this.button_Søgning = new System.Windows.Forms.Button();
            this.label_DyrIdBooking = new System.Windows.Forms.Label();
            this.label_BookingType = new System.Windows.Forms.Label();
            this.comboBox_BookingType = new System.Windows.Forms.ComboBox();
            this.label_BookingBur = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Navn_empty = new System.Windows.Forms.Label();
            this.Addresse_empty = new System.Windows.Forms.Label();
            this.By_empty = new System.Windows.Forms.Label();
            this.Postnummer_empty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker_StartDato
            // 
            this.dateTimePicker_StartDato.Location = new System.Drawing.Point(15, 73);
            this.dateTimePicker_StartDato.Name = "dateTimePicker_StartDato";
            this.dateTimePicker_StartDato.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_StartDato.TabIndex = 107;
            // 
            // label_StartDato
            // 
            this.label_StartDato.AutoSize = true;
            this.label_StartDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StartDato.Location = new System.Drawing.Point(22, 40);
            this.label_StartDato.Name = "label_StartDato";
            this.label_StartDato.Size = new System.Drawing.Size(77, 16);
            this.label_StartDato.TabIndex = 109;
            this.label_StartDato.Text = "Start Dato";
            // 
            // dateTimePicker_SlutDato
            // 
            this.dateTimePicker_SlutDato.Location = new System.Drawing.Point(15, 124);
            this.dateTimePicker_SlutDato.Name = "dateTimePicker_SlutDato";
            this.dateTimePicker_SlutDato.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_SlutDato.TabIndex = 112;
            // 
            // textBox_EjerIdBooking
            // 
            this.textBox_EjerIdBooking.Location = new System.Drawing.Point(43, 55);
            this.textBox_EjerIdBooking.Name = "textBox_EjerIdBooking";
            this.textBox_EjerIdBooking.Size = new System.Drawing.Size(200, 20);
            this.textBox_EjerIdBooking.TabIndex = 113;
            this.textBox_EjerIdBooking.TextChanged += new System.EventHandler(this.textBox_EjerIdBooking_TextChanged);
            // 
            // label_BehandlerIdBooking
            // 
            this.label_BehandlerIdBooking.AutoSize = true;
            this.label_BehandlerIdBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BehandlerIdBooking.Location = new System.Drawing.Point(231, 40);
            this.label_BehandlerIdBooking.Name = "label_BehandlerIdBooking";
            this.label_BehandlerIdBooking.Size = new System.Drawing.Size(115, 16);
            this.label_BehandlerIdBooking.TabIndex = 114;
            this.label_BehandlerIdBooking.Text = "BehandlerNavn";
            // 
            // label_EjerIdBooking
            // 
            this.label_EjerIdBooking.AutoSize = true;
            this.label_EjerIdBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EjerIdBooking.Location = new System.Drawing.Point(40, 33);
            this.label_EjerIdBooking.Name = "label_EjerIdBooking";
            this.label_EjerIdBooking.Size = new System.Drawing.Size(52, 16);
            this.label_EjerIdBooking.TabIndex = 115;
            this.label_EjerIdBooking.Text = "Ejer tlf";
            this.label_EjerIdBooking.Click += new System.EventHandler(this.label_EjerIdBooking_Click);
            // 
            // button_RegBooking
            // 
            this.button_RegBooking.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_RegBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RegBooking.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_RegBooking.Location = new System.Drawing.Point(316, 545);
            this.button_RegBooking.Name = "button_RegBooking";
            this.button_RegBooking.Size = new System.Drawing.Size(200, 55);
            this.button_RegBooking.TabIndex = 116;
            this.button_RegBooking.Text = "Registrer Booking";
            this.button_RegBooking.UseVisualStyleBackColor = false;
            // 
            // button_AnulBooking
            // 
            this.button_AnulBooking.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_AnulBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AnulBooking.ForeColor = System.Drawing.Color.Red;
            this.button_AnulBooking.Location = new System.Drawing.Point(763, 545);
            this.button_AnulBooking.Name = "button_AnulBooking";
            this.button_AnulBooking.Size = new System.Drawing.Size(200, 55);
            this.button_AnulBooking.TabIndex = 117;
            this.button_AnulBooking.Text = "Annuller Booking";
            this.button_AnulBooking.UseVisualStyleBackColor = false;
            // 
            // button_Søgning
            // 
            this.button_Søgning.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Søgning.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Søgning.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_Søgning.Location = new System.Drawing.Point(15, 173);
            this.button_Søgning.Name = "button_Søgning";
            this.button_Søgning.Size = new System.Drawing.Size(98, 41);
            this.button_Søgning.TabIndex = 118;
            this.button_Søgning.Text = "Søgning";
            this.button_Søgning.UseVisualStyleBackColor = false;
            // 
            // label_DyrIdBooking
            // 
            this.label_DyrIdBooking.AutoSize = true;
            this.label_DyrIdBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DyrIdBooking.Location = new System.Drawing.Point(40, 167);
            this.label_DyrIdBooking.Name = "label_DyrIdBooking";
            this.label_DyrIdBooking.Size = new System.Drawing.Size(32, 16);
            this.label_DyrIdBooking.TabIndex = 120;
            this.label_DyrIdBooking.Text = "Dyr";
            // 
            // label_BookingType
            // 
            this.label_BookingType.AutoSize = true;
            this.label_BookingType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BookingType.Location = new System.Drawing.Point(231, 105);
            this.label_BookingType.Name = "label_BookingType";
            this.label_BookingType.Size = new System.Drawing.Size(95, 16);
            this.label_BookingType.TabIndex = 123;
            this.label_BookingType.Text = "Service type";
            // 
            // comboBox_BookingType
            // 
            this.comboBox_BookingType.FormattingEnabled = true;
            this.comboBox_BookingType.Items.AddRange(new object[] {
            "Konsultation",
            "Behandling",
            "Operation"});
            this.comboBox_BookingType.Location = new System.Drawing.Point(234, 124);
            this.comboBox_BookingType.Name = "comboBox_BookingType";
            this.comboBox_BookingType.Size = new System.Drawing.Size(200, 21);
            this.comboBox_BookingType.TabIndex = 124;
            // 
            // label_BookingBur
            // 
            this.label_BookingBur.AutoSize = true;
            this.label_BookingBur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BookingBur.Location = new System.Drawing.Point(10, 27);
            this.label_BookingBur.Name = "label_BookingBur";
            this.label_BookingBur.Size = new System.Drawing.Size(110, 16);
            this.label_BookingBur.TabIndex = 126;
            this.label_BookingBur.Text = "Booking Af Bur";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(316, 293);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(255, 235);
            this.dataGridView1.TabIndex = 129;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(763, 293);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(266, 235);
            this.dataGridView2.TabIndex = 130;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(43, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 48);
            this.button1.TabIndex = 131;
            this.button1.Text = "Søgning";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(43, 186);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 132;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(234, 72);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 133;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 134;
            this.label1.Text = "slut Dato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 140;
            this.label2.Text = "slut Dato";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button2.Location = new System.Drawing.Point(13, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 45);
            this.button2.TabIndex = 138;
            this.button2.Text = "Søgning";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 158);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 137;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 136;
            this.label3.Text = "Start Dato";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(13, 107);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 135;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_StartDato);
            this.groupBox1.Controls.Add(this.dateTimePicker_StartDato);
            this.groupBox1.Controls.Add(this.dateTimePicker_SlutDato);
            this.groupBox1.Controls.Add(this.label_BehandlerIdBooking);
            this.groupBox1.Controls.Add(this.button_Søgning);
            this.groupBox1.Controls.Add(this.label_BookingType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_BookingType);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Location = new System.Drawing.Point(316, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 237);
            this.groupBox1.TabIndex = 141;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_BookingBur);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Location = new System.Drawing.Point(787, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 243);
            this.groupBox2.TabIndex = 142;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 143;
            this.label4.Text = "Navn:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 144;
            this.label5.Text = "Addresse:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 145;
            this.label6.Text = "By";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(770, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 148;
            this.label8.Text = "TilFørte bookinger";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(316, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 149;
            this.label9.Text = "Funde resultater";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 150;
            this.label10.Text = "Postnummer:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button3.Location = new System.Drawing.Point(152, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 48);
            this.button3.TabIndex = 151;
            this.button3.Text = "Tilføj kunde";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(595, 293);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 235);
            this.textBox1.TabIndex = 152;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(595, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 153;
            this.label7.Text = "Notat";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Navn_empty
            // 
            this.Navn_empty.AutoSize = true;
            this.Navn_empty.Location = new System.Drawing.Point(131, 235);
            this.Navn_empty.Name = "Navn_empty";
            this.Navn_empty.Size = new System.Drawing.Size(36, 13);
            this.Navn_empty.TabIndex = 154;
            this.Navn_empty.Text = "Empty";
            // 
            // Addresse_empty
            // 
            this.Addresse_empty.AutoSize = true;
            this.Addresse_empty.Location = new System.Drawing.Point(131, 256);
            this.Addresse_empty.Name = "Addresse_empty";
            this.Addresse_empty.Size = new System.Drawing.Size(36, 13);
            this.Addresse_empty.TabIndex = 155;
            this.Addresse_empty.Text = "Empty";
            // 
            // By_empty
            // 
            this.By_empty.AutoSize = true;
            this.By_empty.Location = new System.Drawing.Point(131, 279);
            this.By_empty.Name = "By_empty";
            this.By_empty.Size = new System.Drawing.Size(36, 13);
            this.By_empty.TabIndex = 156;
            this.By_empty.Text = "Empty";
            // 
            // Postnummer_empty
            // 
            this.Postnummer_empty.AutoSize = true;
            this.Postnummer_empty.Location = new System.Drawing.Point(131, 305);
            this.Postnummer_empty.Name = "Postnummer_empty";
            this.Postnummer_empty.Size = new System.Drawing.Size(36, 13);
            this.Postnummer_empty.TabIndex = 157;
            this.Postnummer_empty.Text = "Empty";
            // 
            // AnimalHouseGui_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 678);
            this.Controls.Add(this.Postnummer_empty);
            this.Controls.Add(this.By_empty);
            this.Controls.Add(this.Addresse_empty);
            this.Controls.Add(this.Navn_empty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_DyrIdBooking);
            this.Controls.Add(this.button_AnulBooking);
            this.Controls.Add(this.button_RegBooking);
            this.Controls.Add(this.label_EjerIdBooking);
            this.Controls.Add(this.textBox_EjerIdBooking);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnimalHouseGui_Booking";
            this.Text = "Animal House";
            this.Load += new System.EventHandler(this.AnimalHouseGui_Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker_StartDato;
        private System.Windows.Forms.Label label_StartDato;
        private System.Windows.Forms.DateTimePicker dateTimePicker_SlutDato;
        private System.Windows.Forms.TextBox textBox_EjerIdBooking;
        private System.Windows.Forms.Label label_BehandlerIdBooking;
        private System.Windows.Forms.Label label_EjerIdBooking;
        private System.Windows.Forms.Button button_RegBooking;
        private System.Windows.Forms.Button button_AnulBooking;
        private System.Windows.Forms.Button button_Søgning;
        private System.Windows.Forms.Label label_DyrIdBooking;
        private System.Windows.Forms.Label label_BookingType;
        private System.Windows.Forms.ComboBox comboBox_BookingType;
        private System.Windows.Forms.Label label_BookingBur;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Navn_empty;
        private System.Windows.Forms.Label Addresse_empty;
        private System.Windows.Forms.Label By_empty;
        private System.Windows.Forms.Label Postnummer_empty;
    }
}