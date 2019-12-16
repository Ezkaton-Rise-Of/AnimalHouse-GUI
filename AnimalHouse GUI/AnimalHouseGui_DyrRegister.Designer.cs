namespace AnimalHouse_GUI
{
    partial class AnimalHouseGui_DyrRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalHouseGui_DyrRegister));
            this.label_AnimalHouse3 = new System.Windows.Forms.Label();
            this.textBox_Art = new System.Windows.Forms.TextBox();
            this.button_RegDyr = new System.Windows.Forms.Button();
            this.label_Art = new System.Windows.Forms.Label();
            this.dataGridView_Dyr = new System.Windows.Forms.DataGridView();
            this.button_SletDyr = new System.Windows.Forms.Button();
            this.label_Dyr = new System.Windows.Forms.Label();
            this.textBox_Race = new System.Windows.Forms.TextBox();
            this.label_Race = new System.Windows.Forms.Label();
            this.label_DyrReg = new System.Windows.Forms.Label();
            this.button_SøgningDyr = new System.Windows.Forms.Button();
            this.textBox_Alder = new System.Windows.Forms.TextBox();
            this.label_Alder = new System.Windows.Forms.Label();
            this.TilbageBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.label_hjælpe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Søg = new System.Windows.Forms.TextBox();
            this.button_Søg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox_behandler = new System.Windows.Forms.ComboBox();
            this.button_tilknyt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Dyr)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_AnimalHouse3
            // 
            this.label_AnimalHouse3.AutoSize = true;
            this.label_AnimalHouse3.Font = new System.Drawing.Font("Haettenschweiler", 48F);
            this.label_AnimalHouse3.Location = new System.Drawing.Point(18, 14);
            this.label_AnimalHouse3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_AnimalHouse3.Name = "label_AnimalHouse3";
            this.label_AnimalHouse3.Size = new System.Drawing.Size(424, 101);
            this.label_AnimalHouse3.TabIndex = 69;
            this.label_AnimalHouse3.Text = "Animal House";
            // 
            // textBox_Art
            // 
            this.textBox_Art.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Art.Location = new System.Drawing.Point(33, 375);
            this.textBox_Art.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Art.Name = "textBox_Art";
            this.textBox_Art.Size = new System.Drawing.Size(486, 30);
            this.textBox_Art.TabIndex = 74;
            // 
            // button_RegDyr
            // 
            this.button_RegDyr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_RegDyr.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RegDyr.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_RegDyr.Location = new System.Drawing.Point(862, 820);
            this.button_RegDyr.Margin = new System.Windows.Forms.Padding(4);
            this.button_RegDyr.Name = "button_RegDyr";
            this.button_RegDyr.Size = new System.Drawing.Size(237, 83);
            this.button_RegDyr.TabIndex = 72;
            this.button_RegDyr.Text = "Registrer";
            this.button_RegDyr.UseVisualStyleBackColor = false;
            this.button_RegDyr.Click += new System.EventHandler(this.button_RegDyr_Click);
            // 
            // label_Art
            // 
            this.label_Art.AutoSize = true;
            this.label_Art.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Art.Location = new System.Drawing.Point(30, 335);
            this.label_Art.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Art.Name = "label_Art";
            this.label_Art.Size = new System.Drawing.Size(40, 25);
            this.label_Art.TabIndex = 71;
            this.label_Art.Text = "Art";
            // 
            // dataGridView_Dyr
            // 
            this.dataGridView_Dyr.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Dyr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Dyr.Location = new System.Drawing.Point(616, 277);
            this.dataGridView_Dyr.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Dyr.Name = "dataGridView_Dyr";
            this.dataGridView_Dyr.ReadOnly = true;
            this.dataGridView_Dyr.RowHeadersWidth = 62;
            this.dataGridView_Dyr.Size = new System.Drawing.Size(1108, 528);
            this.dataGridView_Dyr.TabIndex = 75;
            this.dataGridView_Dyr.DoubleClick += new System.EventHandler(this.dataGridView_Dyr_DoubleClick);
            // 
            // button_SletDyr
            // 
            this.button_SletDyr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_SletDyr.Enabled = false;
            this.button_SletDyr.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SletDyr.ForeColor = System.Drawing.Color.Red;
            this.button_SletDyr.Location = new System.Drawing.Point(1108, 820);
            this.button_SletDyr.Margin = new System.Windows.Forms.Padding(4);
            this.button_SletDyr.Name = "button_SletDyr";
            this.button_SletDyr.Size = new System.Drawing.Size(237, 83);
            this.button_SletDyr.TabIndex = 78;
            this.button_SletDyr.Text = "Slet";
            this.button_SletDyr.UseVisualStyleBackColor = false;
            this.button_SletDyr.Click += new System.EventHandler(this.button_SletDyr_Click);
            // 
            // label_Dyr
            // 
            this.label_Dyr.AutoSize = true;
            this.label_Dyr.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Dyr.ForeColor = System.Drawing.Color.Red;
            this.label_Dyr.Location = new System.Drawing.Point(606, 59);
            this.label_Dyr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Dyr.Name = "label_Dyr";
            this.label_Dyr.Size = new System.Drawing.Size(102, 55);
            this.label_Dyr.TabIndex = 81;
            this.label_Dyr.Text = "Dyr";
            // 
            // textBox_Race
            // 
            this.textBox_Race.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Race.Location = new System.Drawing.Point(35, 475);
            this.textBox_Race.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Race.Name = "textBox_Race";
            this.textBox_Race.Size = new System.Drawing.Size(486, 30);
            this.textBox_Race.TabIndex = 82;
            // 
            // label_Race
            // 
            this.label_Race.AutoSize = true;
            this.label_Race.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Race.Location = new System.Drawing.Point(30, 436);
            this.label_Race.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Race.Name = "label_Race";
            this.label_Race.Size = new System.Drawing.Size(61, 25);
            this.label_Race.TabIndex = 83;
            this.label_Race.Text = "Race";
            // 
            // label_DyrReg
            // 
            this.label_DyrReg.AutoSize = true;
            this.label_DyrReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DyrReg.Location = new System.Drawing.Point(716, 79);
            this.label_DyrReg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DyrReg.Name = "label_DyrReg";
            this.label_DyrReg.Size = new System.Drawing.Size(103, 29);
            this.label_DyrReg.TabIndex = 84;
            this.label_DyrReg.Text = "register";
            // 
            // button_SøgningDyr
            // 
            this.button_SøgningDyr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_SøgningDyr.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SøgningDyr.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_SøgningDyr.Location = new System.Drawing.Point(616, 820);
            this.button_SøgningDyr.Margin = new System.Windows.Forms.Padding(4);
            this.button_SøgningDyr.Name = "button_SøgningDyr";
            this.button_SøgningDyr.Size = new System.Drawing.Size(237, 83);
            this.button_SøgningDyr.TabIndex = 91;
            this.button_SøgningDyr.Text = "Søgning";
            this.button_SøgningDyr.UseVisualStyleBackColor = false;
            this.button_SøgningDyr.Click += new System.EventHandler(this.button_SøgningDyr_Click);
            // 
            // textBox_Alder
            // 
            this.textBox_Alder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Alder.Location = new System.Drawing.Point(33, 722);
            this.textBox_Alder.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Alder.Name = "textBox_Alder";
            this.textBox_Alder.Size = new System.Drawing.Size(486, 30);
            this.textBox_Alder.TabIndex = 92;
            // 
            // label_Alder
            // 
            this.label_Alder.AutoSize = true;
            this.label_Alder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Alder.Location = new System.Drawing.Point(28, 693);
            this.label_Alder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Alder.Name = "label_Alder";
            this.label_Alder.Size = new System.Drawing.Size(63, 25);
            this.label_Alder.TabIndex = 93;
            this.label_Alder.Text = "Alder";
            // 
            // TilbageBtn
            // 
            this.TilbageBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TilbageBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TilbageBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TilbageBtn.Location = new System.Drawing.Point(1365, 820);
            this.TilbageBtn.Margin = new System.Windows.Forms.Padding(4);
            this.TilbageBtn.Name = "TilbageBtn";
            this.TilbageBtn.Size = new System.Drawing.Size(237, 83);
            this.TilbageBtn.TabIndex = 94;
            this.TilbageBtn.Text = "Tilbage";
            this.TilbageBtn.UseVisualStyleBackColor = false;
            this.TilbageBtn.Click += new System.EventHandler(this.TilbageBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_female);
            this.groupBox1.Controls.Add(this.radioButton_male);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 543);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 134);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Køn";
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Location = new System.Drawing.Point(190, 54);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(102, 28);
            this.radioButton_female.TabIndex = 1;
            this.radioButton_female.TabStop = true;
            this.radioButton_female.Text = "Female";
            this.radioButton_female.UseVisualStyleBackColor = true;
            this.radioButton_female.CheckedChanged += new System.EventHandler(this.radioButton_female_CheckedChanged);
            // 
            // radioButton_male
            // 
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.Location = new System.Drawing.Point(17, 54);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(79, 28);
            this.radioButton_male.TabIndex = 0;
            this.radioButton_male.TabStop = true;
            this.radioButton_male.Text = "Male";
            this.radioButton_male.UseVisualStyleBackColor = true;
            this.radioButton_male.CheckedChanged += new System.EventHandler(this.radioButton_male_CheckedChanged);
            // 
            // label_hjælpe
            // 
            this.label_hjælpe.AutoSize = true;
            this.label_hjælpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hjælpe.Location = new System.Drawing.Point(4, 1009);
            this.label_hjælpe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_hjælpe.Name = "label_hjælpe";
            this.label_hjælpe.Size = new System.Drawing.Size(24, 25);
            this.label_hjælpe.TabIndex = 96;
            this.label_hjælpe.Text = "?";
            this.label_hjælpe.Click += new System.EventHandler(this.label_hjælpe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 97;
            this.label1.Text = "Ejer tlf / navn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_Søg
            // 
            this.textBox_Søg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Søg.Location = new System.Drawing.Point(33, 205);
            this.textBox_Søg.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Søg.Name = "textBox_Søg";
            this.textBox_Søg.Size = new System.Drawing.Size(488, 30);
            this.textBox_Søg.TabIndex = 98;
            // 
            // button_Søg
            // 
            this.button_Søg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Søg.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Søg.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_Søg.Location = new System.Drawing.Point(170, 260);
            this.button_Søg.Margin = new System.Windows.Forms.Padding(4);
            this.button_Søg.Name = "button_Søg";
            this.button_Søg.Size = new System.Drawing.Size(168, 58);
            this.button_Søg.TabIndex = 99;
            this.button_Søg.Text = "Søg";
            this.button_Søg.UseVisualStyleBackColor = false;
            this.button_Søg.Click += new System.EventHandler(this.button_Søg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 813);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 25);
            this.label2.TabIndex = 100;
            this.label2.Text = "Tilknyt en behandler";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(254, 818);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(22, 21);
            this.checkBox1.TabIndex = 101;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox_behandler
            // 
            this.comboBox_behandler.FormattingEnabled = true;
            this.comboBox_behandler.Location = new System.Drawing.Point(35, 872);
            this.comboBox_behandler.Name = "comboBox_behandler";
            this.comboBox_behandler.Size = new System.Drawing.Size(329, 28);
            this.comboBox_behandler.TabIndex = 102;
            this.comboBox_behandler.Visible = false;
            // 
            // button_tilknyt
            // 
            this.button_tilknyt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_tilknyt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tilknyt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_tilknyt.Location = new System.Drawing.Point(123, 907);
            this.button_tilknyt.Margin = new System.Windows.Forms.Padding(4);
            this.button_tilknyt.Name = "button_tilknyt";
            this.button_tilknyt.Size = new System.Drawing.Size(113, 58);
            this.button_tilknyt.TabIndex = 103;
            this.button_tilknyt.Text = "Tilknyt";
            this.button_tilknyt.UseVisualStyleBackColor = false;
            this.button_tilknyt.Visible = false;
            this.button_tilknyt.Click += new System.EventHandler(this.button_tilknyt_Click);
            // 
            // AnimalHouseGui_DyrRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 1043);
            this.Controls.Add(this.button_tilknyt);
            this.Controls.Add(this.comboBox_behandler);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Søg);
            this.Controls.Add(this.textBox_Søg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_hjælpe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TilbageBtn);
            this.Controls.Add(this.label_Alder);
            this.Controls.Add(this.textBox_Alder);
            this.Controls.Add(this.button_SøgningDyr);
            this.Controls.Add(this.label_DyrReg);
            this.Controls.Add(this.label_Race);
            this.Controls.Add(this.textBox_Race);
            this.Controls.Add(this.label_Dyr);
            this.Controls.Add(this.button_SletDyr);
            this.Controls.Add(this.dataGridView_Dyr);
            this.Controls.Add(this.textBox_Art);
            this.Controls.Add(this.button_RegDyr);
            this.Controls.Add(this.label_Art);
            this.Controls.Add(this.label_AnimalHouse3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnimalHouseGui_DyrRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animal House";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Dyr)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_AnimalHouse3;
        private System.Windows.Forms.TextBox textBox_Art;
        private System.Windows.Forms.Button button_RegDyr;
        private System.Windows.Forms.Label label_Art;
        private System.Windows.Forms.DataGridView dataGridView_Dyr;
        private System.Windows.Forms.Button button_SletDyr;
        private System.Windows.Forms.Label label_Dyr;
        private System.Windows.Forms.TextBox textBox_Race;
        private System.Windows.Forms.Label label_Race;
        private System.Windows.Forms.Label label_DyrReg;
        private System.Windows.Forms.Button button_SøgningDyr;
        private System.Windows.Forms.TextBox textBox_Alder;
        private System.Windows.Forms.Label label_Alder;
        private System.Windows.Forms.Button TilbageBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.Label label_hjælpe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Søg;
        private System.Windows.Forms.Button button_Søg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox_behandler;
        private System.Windows.Forms.Button button_tilknyt;
    }
}