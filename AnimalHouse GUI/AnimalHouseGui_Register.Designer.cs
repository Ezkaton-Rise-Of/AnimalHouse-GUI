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
            this.label_EjerType = new System.Windows.Forms.Label();
            this.textBox_EjerType = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ejer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Ejer
            // 
            this.dataGridView_Ejer.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Ejer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Ejer.Location = new System.Drawing.Point(411, 180);
            this.dataGridView_Ejer.Name = "dataGridView_Ejer";
            this.dataGridView_Ejer.ReadOnly = true;
            this.dataGridView_Ejer.Size = new System.Drawing.Size(739, 343);
            this.dataGridView_Ejer.TabIndex = 22;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Email.Location = new System.Drawing.Point(22, 313);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(322, 22);
            this.textBox_Email.TabIndex = 21;
            // 
            // textBox_Fornavn
            // 
            this.textBox_Fornavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Fornavn.Location = new System.Drawing.Point(22, 247);
            this.textBox_Fornavn.Name = "textBox_Fornavn";
            this.textBox_Fornavn.Size = new System.Drawing.Size(158, 22);
            this.textBox_Fornavn.TabIndex = 19;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email.Location = new System.Drawing.Point(19, 294);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(52, 16);
            this.label_Email.TabIndex = 15;
            this.label_Email.Text = "E-mail";
            // 
            // label_Fornavn
            // 
            this.label_Fornavn.AutoSize = true;
            this.label_Fornavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Fornavn.Location = new System.Drawing.Point(19, 228);
            this.label_Fornavn.Name = "label_Fornavn";
            this.label_Fornavn.Size = new System.Drawing.Size(64, 16);
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
            this.label_AnimalHouse2.Location = new System.Drawing.Point(12, 9);
            this.label_AnimalHouse2.Name = "label_AnimalHouse2";
            this.label_AnimalHouse2.Size = new System.Drawing.Size(287, 67);
            this.label_AnimalHouse2.TabIndex = 27;
            this.label_AnimalHouse2.Text = "Animal House";
            // 
            // button_RegEjer
            // 
            this.button_RegEjer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_RegEjer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RegEjer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_RegEjer.Location = new System.Drawing.Point(575, 533);
            this.button_RegEjer.Name = "button_RegEjer";
            this.button_RegEjer.Size = new System.Drawing.Size(158, 54);
            this.button_RegEjer.TabIndex = 16;
            this.button_RegEjer.Text = "Registrer";
            this.button_RegEjer.UseVisualStyleBackColor = false;
            this.button_RegEjer.Click += new System.EventHandler(this.button_RegEjer_Click);
            // 
            // textBox_Vejnavn
            // 
            this.textBox_Vejnavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Vejnavn.Location = new System.Drawing.Point(22, 435);
            this.textBox_Vejnavn.Name = "textBox_Vejnavn";
            this.textBox_Vejnavn.Size = new System.Drawing.Size(322, 22);
            this.textBox_Vejnavn.TabIndex = 29;
            // 
            // label_Vejnavn
            // 
            this.label_Vejnavn.AutoSize = true;
            this.label_Vejnavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Vejnavn.Location = new System.Drawing.Point(19, 419);
            this.label_Vejnavn.Name = "label_Vejnavn";
            this.label_Vejnavn.Size = new System.Drawing.Size(64, 16);
            this.label_Vejnavn.TabIndex = 30;
            this.label_Vejnavn.Text = "Vejnavn";
            // 
            // button_SletEjer
            // 
            this.button_SletEjer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_SletEjer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SletEjer.ForeColor = System.Drawing.Color.Red;
            this.button_SletEjer.Location = new System.Drawing.Point(739, 533);
            this.button_SletEjer.Name = "button_SletEjer";
            this.button_SletEjer.Size = new System.Drawing.Size(158, 54);
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
            this.label_Ejer.Location = new System.Drawing.Point(404, 137);
            this.label_Ejer.Name = "label_Ejer";
            this.label_Ejer.Size = new System.Drawing.Size(77, 37);
            this.label_Ejer.TabIndex = 47;
            this.label_Ejer.Text = "Ejer";
            // 
            // textBox_Telefon
            // 
            this.textBox_Telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Telefon.Location = new System.Drawing.Point(22, 375);
            this.textBox_Telefon.Name = "textBox_Telefon";
            this.textBox_Telefon.Size = new System.Drawing.Size(322, 22);
            this.textBox_Telefon.TabIndex = 49;
            // 
            // label_Telefon
            // 
            this.label_Telefon.AutoSize = true;
            this.label_Telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Telefon.Location = new System.Drawing.Point(19, 356);
            this.label_Telefon.Name = "label_Telefon";
            this.label_Telefon.Size = new System.Drawing.Size(61, 16);
            this.label_Telefon.TabIndex = 50;
            this.label_Telefon.Text = "Telefon";
            // 
            // label_EjerReg
            // 
            this.label_EjerReg.AutoSize = true;
            this.label_EjerReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EjerReg.Location = new System.Drawing.Point(477, 150);
            this.label_EjerReg.Name = "label_EjerReg";
            this.label_EjerReg.Size = new System.Drawing.Size(70, 20);
            this.label_EjerReg.TabIndex = 51;
            this.label_EjerReg.Text = "register";
            // 
            // textBox_Efternavn
            // 
            this.textBox_Efternavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Efternavn.Location = new System.Drawing.Point(189, 247);
            this.textBox_Efternavn.Name = "textBox_Efternavn";
            this.textBox_Efternavn.Size = new System.Drawing.Size(158, 22);
            this.textBox_Efternavn.TabIndex = 52;
            // 
            // label_Efternavn
            // 
            this.label_Efternavn.AutoSize = true;
            this.label_Efternavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Efternavn.Location = new System.Drawing.Point(186, 228);
            this.label_Efternavn.Name = "label_Efternavn";
            this.label_Efternavn.Size = new System.Drawing.Size(73, 16);
            this.label_Efternavn.TabIndex = 53;
            this.label_Efternavn.Text = "Efternavn";
            // 
            // textBox_By
            // 
            this.textBox_By.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_By.Location = new System.Drawing.Point(22, 565);
            this.textBox_By.Name = "textBox_By";
            this.textBox_By.Size = new System.Drawing.Size(322, 22);
            this.textBox_By.TabIndex = 55;
            // 
            // textBox_Postnummer
            // 
            this.textBox_Postnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Postnummer.Location = new System.Drawing.Point(22, 501);
            this.textBox_Postnummer.Name = "textBox_Postnummer";
            this.textBox_Postnummer.Size = new System.Drawing.Size(322, 22);
            this.textBox_Postnummer.TabIndex = 56;
            // 
            // label_Postnummer
            // 
            this.label_Postnummer.AutoSize = true;
            this.label_Postnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Postnummer.Location = new System.Drawing.Point(19, 482);
            this.label_Postnummer.Name = "label_Postnummer";
            this.label_Postnummer.Size = new System.Drawing.Size(93, 16);
            this.label_Postnummer.TabIndex = 57;
            this.label_Postnummer.Text = "Postnummer";
            this.label_Postnummer.Click += new System.EventHandler(this.label4_Click);
            // 
            // label_By
            // 
            this.label_By.AutoSize = true;
            this.label_By.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_By.Location = new System.Drawing.Point(19, 546);
            this.label_By.Name = "label_By";
            this.label_By.Size = new System.Drawing.Size(26, 16);
            this.label_By.TabIndex = 58;
            this.label_By.Text = "By";
            // 
            // button_Søgning
            // 
            this.button_Søgning.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Søgning.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Søgning.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_Søgning.Location = new System.Drawing.Point(411, 533);
            this.button_Søgning.Name = "button_Søgning";
            this.button_Søgning.Size = new System.Drawing.Size(158, 54);
            this.button_Søgning.TabIndex = 59;
            this.button_Søgning.Text = "Søgning";
            this.button_Søgning.UseVisualStyleBackColor = false;
            this.button_Søgning.Click += new System.EventHandler(this.button_Søgning_Click);
            // 
            // label_EjerType
            // 
            this.label_EjerType.AutoSize = true;
            this.label_EjerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EjerType.Location = new System.Drawing.Point(22, 161);
            this.label_EjerType.Name = "label_EjerType";
            this.label_EjerType.Size = new System.Drawing.Size(76, 16);
            this.label_EjerType.TabIndex = 44;
            this.label_EjerType.Text = "Ejer Type";
            // 
            // textBox_EjerType
            // 
            this.textBox_EjerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EjerType.Location = new System.Drawing.Point(25, 180);
            this.textBox_EjerType.Name = "textBox_EjerType";
            this.textBox_EjerType.Size = new System.Drawing.Size(322, 22);
            this.textBox_EjerType.TabIndex = 43;
            // 
            // AnimalHouseGui_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 678);
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
            this.Controls.Add(this.label_EjerType);
            this.Controls.Add(this.textBox_EjerType);
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
            this.Name = "AnimalHouseGui_Register";
            this.Text = "Animal House";
            this.Load += new System.EventHandler(this.AnimalHouseGui_Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ejer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
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
        private System.Windows.Forms.Label label_EjerType;
        private System.Windows.Forms.TextBox textBox_EjerType;
    }
}