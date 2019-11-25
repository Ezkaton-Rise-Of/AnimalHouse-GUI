namespace AnimalHouse_GUI
{
    partial class AnimalHouseGui_Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalHouseGui_Register));
            this.dataGridView_Ejer = new System.Windows.Forms.DataGridView();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_Fornavn = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Fornavn = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label_AnimalHouse2 = new System.Windows.Forms.Label();
            this.button_RegEjer = new System.Windows.Forms.Button();
            this.textBox_Vejnavn = new System.Windows.Forms.TextBox();
            this.label_Vejnavn = new System.Windows.Forms.Label();
            this.button_SletEjer = new System.Windows.Forms.Button();
            this.label_Ejer = new System.Windows.Forms.Label();
            this.textBox_Telefon = new System.Windows.Forms.TextBox();
            this.label_Telefon = new System.Windows.Forms.Label();
            this.label_EjerReg = new System.Windows.Forms.Label();
            this.textBox_Efternavn = new System.Windows.Forms.TextBox();
            this.label_Efternavn = new System.Windows.Forms.Label();
            this.textBox_By = new System.Windows.Forms.TextBox();
            this.textBox_Postnummer = new System.Windows.Forms.TextBox();
            this.label_Postnummer = new System.Windows.Forms.Label();
            this.label_By = new System.Windows.Forms.Label();
            this.button_Søgning = new System.Windows.Forms.Button();
            this.TilbageBtn = new System.Windows.Forms.Button();
            this.radioButton_Private = new System.Windows.Forms.RadioButton();
            this.radioButton_Erhverv = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ejer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Ejer
            // 
            this.dataGridView_Ejer.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Ejer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Ejer.Location = new System.Drawing.Point(616, 277);
            this.dataGridView_Ejer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_Ejer.Name = "dataGridView_Ejer";
            this.dataGridView_Ejer.ReadOnly = true;
            this.dataGridView_Ejer.RowHeadersWidth = 62;
            this.dataGridView_Ejer.Size = new System.Drawing.Size(1108, 528);
            this.dataGridView_Ejer.TabIndex = 22;
            this.dataGridView_Ejer.DoubleClick += new System.EventHandler(this.dataGridView_Ejer_DoubleClick);
            // 
            // textBox_Email
            // 
            this.textBox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Email.Location = new System.Drawing.Point(33, 482);
            this.textBox_Email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(481, 30);
            this.textBox_Email.TabIndex = 21;
            // 
            // textBox_Fornavn
            // 
            this.textBox_Fornavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Fornavn.Location = new System.Drawing.Point(33, 380);
            this.textBox_Fornavn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Fornavn.Name = "textBox_Fornavn";
            this.textBox_Fornavn.Size = new System.Drawing.Size(235, 30);
            this.textBox_Fornavn.TabIndex = 19;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email.Location = new System.Drawing.Point(28, 452);
            this.label_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(73, 25);
            this.label_Email.TabIndex = 15;
            this.label_Email.Text = "E-mail";
            // 
            // label_Fornavn
            // 
            this.label_Fornavn.AutoSize = true;
            this.label_Fornavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Fornavn.Location = new System.Drawing.Point(28, 351);
            this.label_Fornavn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Fornavn.Name = "label_Fornavn";
            this.label_Fornavn.Size = new System.Drawing.Size(91, 25);
            this.label_Fornavn.TabIndex = 13;
            this.label_Fornavn.Text = "Fornavn";
            this.label_Fornavn.Click += new System.EventHandler(this.Label_ForNavn_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label_AnimalHouse2
            // 
            this.label_AnimalHouse2.AutoSize = true;
            this.label_AnimalHouse2.Font = new System.Drawing.Font("Haettenschweiler", 48F);
            this.label_AnimalHouse2.Location = new System.Drawing.Point(18, 14);
            this.label_AnimalHouse2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_AnimalHouse2.Name = "label_AnimalHouse2";
            this.label_AnimalHouse2.Size = new System.Drawing.Size(424, 101);
            this.label_AnimalHouse2.TabIndex = 27;
            this.label_AnimalHouse2.Text = "Animal House";
            // 
            // button_RegEjer
            // 
            this.button_RegEjer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_RegEjer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RegEjer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_RegEjer.Location = new System.Drawing.Point(862, 820);
            this.button_RegEjer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_RegEjer.Name = "button_RegEjer";
            this.button_RegEjer.Size = new System.Drawing.Size(237, 83);
            this.button_RegEjer.TabIndex = 25;
            this.button_RegEjer.Text = "Registrer";
            this.button_RegEjer.UseVisualStyleBackColor = false;
            this.button_RegEjer.Click += new System.EventHandler(this.button_RegEjer_Click);
            // 
            // textBox_Vejnavn
            // 
            this.textBox_Vejnavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Vejnavn.Location = new System.Drawing.Point(33, 669);
            this.textBox_Vejnavn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Vejnavn.Name = "textBox_Vejnavn";
            this.textBox_Vejnavn.Size = new System.Drawing.Size(481, 30);
            this.textBox_Vejnavn.TabIndex = 23;
            // 
            // label_Vejnavn
            // 
            this.label_Vejnavn.AutoSize = true;
            this.label_Vejnavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Vejnavn.Location = new System.Drawing.Point(28, 645);
            this.label_Vejnavn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Vejnavn.Name = "label_Vejnavn";
            this.label_Vejnavn.Size = new System.Drawing.Size(91, 25);
            this.label_Vejnavn.TabIndex = 30;
            this.label_Vejnavn.Text = "Vejnavn";
            // 
            // button_SletEjer
            // 
            this.button_SletEjer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_SletEjer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SletEjer.ForeColor = System.Drawing.Color.Red;
            this.button_SletEjer.Location = new System.Drawing.Point(1108, 820);
            this.button_SletEjer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_SletEjer.Name = "button_SletEjer";
            this.button_SletEjer.Size = new System.Drawing.Size(237, 83);
            this.button_SletEjer.TabIndex = 31;
            this.button_SletEjer.Text = "Slet";
            this.button_SletEjer.UseVisualStyleBackColor = false;
            this.button_SletEjer.Click += new System.EventHandler(this.button_SletEjer_Click);
            // 
            // label_Ejer
            // 
            this.label_Ejer.AutoSize = true;
            this.label_Ejer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Ejer.ForeColor = System.Drawing.Color.Red;
            this.label_Ejer.Location = new System.Drawing.Point(606, 211);
            this.label_Ejer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Ejer.Name = "label_Ejer";
            this.label_Ejer.Size = new System.Drawing.Size(113, 55);
            this.label_Ejer.TabIndex = 47;
            this.label_Ejer.Text = "Ejer";
            // 
            // textBox_Telefon
            // 
            this.textBox_Telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Telefon.Location = new System.Drawing.Point(33, 577);
            this.textBox_Telefon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Telefon.Name = "textBox_Telefon";
            this.textBox_Telefon.Size = new System.Drawing.Size(481, 30);
            this.textBox_Telefon.TabIndex = 22;
            // 
            // label_Telefon
            // 
            this.label_Telefon.AutoSize = true;
            this.label_Telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Telefon.Location = new System.Drawing.Point(28, 548);
            this.label_Telefon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Telefon.Name = "label_Telefon";
            this.label_Telefon.Size = new System.Drawing.Size(85, 25);
            this.label_Telefon.TabIndex = 50;
            this.label_Telefon.Text = "Telefon";
            // 
            // label_EjerReg
            // 
            this.label_EjerReg.AutoSize = true;
            this.label_EjerReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EjerReg.Location = new System.Drawing.Point(716, 231);
            this.label_EjerReg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_EjerReg.Name = "label_EjerReg";
            this.label_EjerReg.Size = new System.Drawing.Size(103, 29);
            this.label_EjerReg.TabIndex = 51;
            this.label_EjerReg.Text = "register";
            // 
            // textBox_Efternavn
            // 
            this.textBox_Efternavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Efternavn.Location = new System.Drawing.Point(284, 380);
            this.textBox_Efternavn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Efternavn.Name = "textBox_Efternavn";
            this.textBox_Efternavn.Size = new System.Drawing.Size(235, 30);
            this.textBox_Efternavn.TabIndex = 20;
            // 
            // label_Efternavn
            // 
            this.label_Efternavn.AutoSize = true;
            this.label_Efternavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Efternavn.Location = new System.Drawing.Point(279, 351);
            this.label_Efternavn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Efternavn.Name = "label_Efternavn";
            this.label_Efternavn.Size = new System.Drawing.Size(104, 25);
            this.label_Efternavn.TabIndex = 53;
            this.label_Efternavn.Text = "Efternavn";
            // 
            // textBox_By
            // 
            this.textBox_By.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_By.Location = new System.Drawing.Point(33, 869);
            this.textBox_By.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_By.Name = "textBox_By";
            this.textBox_By.Size = new System.Drawing.Size(481, 30);
            this.textBox_By.TabIndex = 55;
            // 
            // textBox_Postnummer
            // 
            this.textBox_Postnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Postnummer.Location = new System.Drawing.Point(33, 771);
            this.textBox_Postnummer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Postnummer.Name = "textBox_Postnummer";
            this.textBox_Postnummer.Size = new System.Drawing.Size(481, 30);
            this.textBox_Postnummer.TabIndex = 24;
            this.textBox_Postnummer.Leave += new System.EventHandler(this.textBox_Postnummer_Leave);
            // 
            // label_Postnummer
            // 
            this.label_Postnummer.AutoSize = true;
            this.label_Postnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Postnummer.Location = new System.Drawing.Point(28, 742);
            this.label_Postnummer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Postnummer.Name = "label_Postnummer";
            this.label_Postnummer.Size = new System.Drawing.Size(132, 25);
            this.label_Postnummer.TabIndex = 57;
            this.label_Postnummer.Text = "Postnummer";
            this.label_Postnummer.Click += new System.EventHandler(this.label4_Click);
            // 
            // label_By
            // 
            this.label_By.AutoSize = true;
            this.label_By.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_By.Location = new System.Drawing.Point(28, 840);
            this.label_By.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_By.Name = "label_By";
            this.label_By.Size = new System.Drawing.Size(37, 25);
            this.label_By.TabIndex = 58;
            this.label_By.Text = "By";
            // 
            // button_Søgning
            // 
            this.button_Søgning.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Søgning.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Søgning.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_Søgning.Location = new System.Drawing.Point(616, 820);
            this.button_Søgning.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Søgning.Name = "button_Søgning";
            this.button_Søgning.Size = new System.Drawing.Size(237, 83);
            this.button_Søgning.TabIndex = 59;
            this.button_Søgning.Text = "Søgning";
            this.button_Søgning.UseVisualStyleBackColor = false;
            this.button_Søgning.Click += new System.EventHandler(this.button_Søgning_Click);
            // 
            // TilbageBtn
            // 
            this.TilbageBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TilbageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TilbageBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TilbageBtn.Location = new System.Drawing.Point(1368, 820);
            this.TilbageBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TilbageBtn.Name = "TilbageBtn";
            this.TilbageBtn.Size = new System.Drawing.Size(237, 83);
            this.TilbageBtn.TabIndex = 26;
            this.TilbageBtn.Text = "Tilbage";
            this.TilbageBtn.UseVisualStyleBackColor = false;
            this.TilbageBtn.Click += new System.EventHandler(this.TilbageBtn_Click);
            // 
            // radioButton_Private
            // 
            this.radioButton_Private.AutoSize = true;
            this.radioButton_Private.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Private.Location = new System.Drawing.Point(25, 44);
            this.radioButton_Private.Name = "radioButton_Private";
            this.radioButton_Private.Size = new System.Drawing.Size(88, 28);
            this.radioButton_Private.TabIndex = 17;
            this.radioButton_Private.TabStop = true;
            this.radioButton_Private.Text = "Private";
            this.radioButton_Private.UseVisualStyleBackColor = true;
            // 
            // radioButton_Erhverv
            // 
            this.radioButton_Erhverv.AutoSize = true;
            this.radioButton_Erhverv.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Erhverv.Location = new System.Drawing.Point(238, 45);
            this.radioButton_Erhverv.Name = "radioButton_Erhverv";
            this.radioButton_Erhverv.Size = new System.Drawing.Size(95, 28);
            this.radioButton_Erhverv.TabIndex = 18;
            this.radioButton_Erhverv.TabStop = true;
            this.radioButton_Erhverv.Text = "Erhverv";
            this.radioButton_Erhverv.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_Erhverv);
            this.groupBox1.Controls.Add(this.radioButton_Private);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 98);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ejer type";
            // 
            // AnimalHouseGui_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 1043);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TilbageBtn);
            this.Controls.Add(this.button_Søgning);
            this.Controls.Add(this.label_By);
            this.Controls.Add(this.label_Postnummer);
            this.Controls.Add(this.textBox_Postnummer);
            this.Controls.Add(this.textBox_By);
            this.Controls.Add(this.label_Efternavn);
            this.Controls.Add(this.textBox_Efternavn);
            this.Controls.Add(this.label_EjerReg);
            this.Controls.Add(this.label_Telefon);
            this.Controls.Add(this.textBox_Telefon);
            this.Controls.Add(this.label_Ejer);
            this.Controls.Add(this.button_SletEjer);
            this.Controls.Add(this.label_Vejnavn);
            this.Controls.Add(this.textBox_Vejnavn);
            this.Controls.Add(this.label_AnimalHouse2);
            this.Controls.Add(this.dataGridView_Ejer);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_Fornavn);
            this.Controls.Add(this.button_RegEjer);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_Fornavn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AnimalHouseGui_Register";
            this.Text = "Animal House";
            this.Load += new System.EventHandler(this.AnimalHouseGui_Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ejer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Ejer;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_Fornavn;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Fornavn;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label_AnimalHouse2;
        private System.Windows.Forms.Button button_RegEjer;
        private System.Windows.Forms.TextBox textBox_Vejnavn;
        private System.Windows.Forms.Label label_Vejnavn;
        private System.Windows.Forms.Button button_SletEjer;
        private System.Windows.Forms.Label label_Ejer;
        private System.Windows.Forms.Label label_Telefon;
        private System.Windows.Forms.TextBox textBox_Telefon;
        private System.Windows.Forms.TextBox textBox_Postnummer;
        private System.Windows.Forms.TextBox textBox_By;
        private System.Windows.Forms.Label label_Efternavn;
        private System.Windows.Forms.TextBox textBox_Efternavn;
        private System.Windows.Forms.Label label_EjerReg;
        private System.Windows.Forms.Label label_Postnummer;
        private System.Windows.Forms.Label label_By;
        private System.Windows.Forms.Button button_Søgning;
        private System.Windows.Forms.Button TilbageBtn;
        private System.Windows.Forms.RadioButton radioButton_Erhverv;
        private System.Windows.Forms.RadioButton radioButton_Private;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}