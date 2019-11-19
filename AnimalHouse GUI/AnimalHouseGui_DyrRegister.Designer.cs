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
            this.textBox_EjerNavn = new System.Windows.Forms.TextBox();
            this.button_RegDyr = new System.Windows.Forms.Button();
            this.label_Art = new System.Windows.Forms.Label();
            this.label_EjerIdDyr = new System.Windows.Forms.Label();
            this.dataGridView_Dyr = new System.Windows.Forms.DataGridView();
            this.textBox_Køn = new System.Windows.Forms.TextBox();
            this.label_Køn = new System.Windows.Forms.Label();
            this.button_SletDyr = new System.Windows.Forms.Button();
            this.label_Dyr = new System.Windows.Forms.Label();
            this.textBox_Race = new System.Windows.Forms.TextBox();
            this.label_Race = new System.Windows.Forms.Label();
            this.label_DyrReg = new System.Windows.Forms.Label();
            this.button_SøgningDyr = new System.Windows.Forms.Button();
            this.textBox_Alder = new System.Windows.Forms.TextBox();
            this.label_Alder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Dyr)).BeginInit();
            this.SuspendLayout();
            // 
            // label_AnimalHouse3
            // 
            this.label_AnimalHouse3.AutoSize = true;
            this.label_AnimalHouse3.Font = new System.Drawing.Font("Haettenschweiler", 48F);
            this.label_AnimalHouse3.Location = new System.Drawing.Point(12, 9);
            this.label_AnimalHouse3.Name = "label_AnimalHouse3";
            this.label_AnimalHouse3.Size = new System.Drawing.Size(287, 67);
            this.label_AnimalHouse3.TabIndex = 69;
            this.label_AnimalHouse3.Text = "Animal House";
            // 
            // textBox_Art
            // 
            this.textBox_Art.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Art.Location = new System.Drawing.Point(22, 314);
            this.textBox_Art.Name = "textBox_Art";
            this.textBox_Art.Size = new System.Drawing.Size(325, 22);
            this.textBox_Art.TabIndex = 74;
            // 
            // textBox_EjerNavn
            // 
            this.textBox_EjerNavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EjerNavn.Location = new System.Drawing.Point(22, 247);
            this.textBox_EjerNavn.Name = "textBox_EjerNavn";
            this.textBox_EjerNavn.Size = new System.Drawing.Size(325, 22);
            this.textBox_EjerNavn.TabIndex = 73;
            // 
            // button_RegDyr
            // 
            this.button_RegDyr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_RegDyr.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RegDyr.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_RegDyr.Location = new System.Drawing.Point(575, 533);
            this.button_RegDyr.Name = "button_RegDyr";
            this.button_RegDyr.Size = new System.Drawing.Size(158, 54);
            this.button_RegDyr.TabIndex = 72;
            this.button_RegDyr.Text = "Registrer";
            this.button_RegDyr.UseVisualStyleBackColor = false;
            this.button_RegDyr.Click += new System.EventHandler(this.button_RegDyr_Click);
            // 
            // label_Art
            // 
            this.label_Art.AutoSize = true;
            this.label_Art.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Art.Location = new System.Drawing.Point(19, 295);
            this.label_Art.Name = "label_Art";
            this.label_Art.Size = new System.Drawing.Size(27, 16);
            this.label_Art.TabIndex = 71;
            this.label_Art.Text = "Art";
            // 
            // label_EjerIdDyr
            // 
            this.label_EjerIdDyr.AutoSize = true;
            this.label_EjerIdDyr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EjerIdDyr.Location = new System.Drawing.Point(19, 228);
            this.label_EjerIdDyr.Name = "label_EjerIdDyr";
            this.label_EjerIdDyr.Size = new System.Drawing.Size(76, 16);
            this.label_EjerIdDyr.TabIndex = 70;
            this.label_EjerIdDyr.Text = "Ejer Navn";
            // 
            // dataGridView_Dyr
            // 
            this.dataGridView_Dyr.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Dyr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Dyr.Location = new System.Drawing.Point(411, 180);
            this.dataGridView_Dyr.Name = "dataGridView_Dyr";
            this.dataGridView_Dyr.ReadOnly = true;
            this.dataGridView_Dyr.Size = new System.Drawing.Size(739, 343);
            this.dataGridView_Dyr.TabIndex = 75;
            // 
            // textBox_Køn
            // 
            this.textBox_Køn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Køn.Location = new System.Drawing.Point(22, 436);
            this.textBox_Køn.Name = "textBox_Køn";
            this.textBox_Køn.Size = new System.Drawing.Size(325, 22);
            this.textBox_Køn.TabIndex = 76;
            // 
            // label_Køn
            // 
            this.label_Køn.AutoSize = true;
            this.label_Køn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Køn.Location = new System.Drawing.Point(19, 420);
            this.label_Køn.Name = "label_Køn";
            this.label_Køn.Size = new System.Drawing.Size(34, 16);
            this.label_Køn.TabIndex = 77;
            this.label_Køn.Text = "Køn";
            // 
            // button_SletDyr
            // 
            this.button_SletDyr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_SletDyr.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SletDyr.ForeColor = System.Drawing.Color.Red;
            this.button_SletDyr.Location = new System.Drawing.Point(739, 533);
            this.button_SletDyr.Name = "button_SletDyr";
            this.button_SletDyr.Size = new System.Drawing.Size(158, 54);
            this.button_SletDyr.TabIndex = 78;
            this.button_SletDyr.Text = "Slet";
            this.button_SletDyr.UseVisualStyleBackColor = false;
            // 
            // label_Dyr
            // 
            this.label_Dyr.AutoSize = true;
            this.label_Dyr.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Dyr.ForeColor = System.Drawing.Color.Red;
            this.label_Dyr.Location = new System.Drawing.Point(404, 137);
            this.label_Dyr.Name = "label_Dyr";
            this.label_Dyr.Size = new System.Drawing.Size(69, 37);
            this.label_Dyr.TabIndex = 81;
            this.label_Dyr.Text = "Dyr";
            // 
            // textBox_Race
            // 
            this.textBox_Race.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Race.Location = new System.Drawing.Point(22, 376);
            this.textBox_Race.Name = "textBox_Race";
            this.textBox_Race.Size = new System.Drawing.Size(325, 22);
            this.textBox_Race.TabIndex = 82;
            // 
            // label_Race
            // 
            this.label_Race.AutoSize = true;
            this.label_Race.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Race.Location = new System.Drawing.Point(19, 357);
            this.label_Race.Name = "label_Race";
            this.label_Race.Size = new System.Drawing.Size(45, 16);
            this.label_Race.TabIndex = 83;
            this.label_Race.Text = "Race";
            this.label_Race.Click += new System.EventHandler(this.label_Underart_Click);
            // 
            // label_DyrReg
            // 
            this.label_DyrReg.AutoSize = true;
            this.label_DyrReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DyrReg.Location = new System.Drawing.Point(477, 150);
            this.label_DyrReg.Name = "label_DyrReg";
            this.label_DyrReg.Size = new System.Drawing.Size(70, 20);
            this.label_DyrReg.TabIndex = 84;
            this.label_DyrReg.Text = "register";
            // 
            // button_SøgningDyr
            // 
            this.button_SøgningDyr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_SøgningDyr.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SøgningDyr.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_SøgningDyr.Location = new System.Drawing.Point(411, 533);
            this.button_SøgningDyr.Name = "button_SøgningDyr";
            this.button_SøgningDyr.Size = new System.Drawing.Size(158, 54);
            this.button_SøgningDyr.TabIndex = 91;
            this.button_SøgningDyr.Text = "Søgning";
            this.button_SøgningDyr.UseVisualStyleBackColor = false;
            // 
            // textBox_Alder
            // 
            this.textBox_Alder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Alder.Location = new System.Drawing.Point(22, 501);
            this.textBox_Alder.Name = "textBox_Alder";
            this.textBox_Alder.Size = new System.Drawing.Size(325, 22);
            this.textBox_Alder.TabIndex = 92;
            // 
            // label_Alder
            // 
            this.label_Alder.AutoSize = true;
            this.label_Alder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Alder.Location = new System.Drawing.Point(19, 482);
            this.label_Alder.Name = "label_Alder";
            this.label_Alder.Size = new System.Drawing.Size(45, 16);
            this.label_Alder.TabIndex = 93;
            this.label_Alder.Text = "Alder";
            // 
            // AnimalHouseGui_DyrRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 678);
            this.Controls.Add(this.label_Alder);
            this.Controls.Add(this.textBox_Alder);
            this.Controls.Add(this.button_SøgningDyr);
            this.Controls.Add(this.label_DyrReg);
            this.Controls.Add(this.label_Race);
            this.Controls.Add(this.textBox_Race);
            this.Controls.Add(this.label_Dyr);
            this.Controls.Add(this.button_SletDyr);
            this.Controls.Add(this.label_Køn);
            this.Controls.Add(this.textBox_Køn);
            this.Controls.Add(this.dataGridView_Dyr);
            this.Controls.Add(this.textBox_Art);
            this.Controls.Add(this.textBox_EjerNavn);
            this.Controls.Add(this.button_RegDyr);
            this.Controls.Add(this.label_Art);
            this.Controls.Add(this.label_EjerIdDyr);
            this.Controls.Add(this.label_AnimalHouse3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnimalHouseGui_DyrRegister";
            this.Text = "Animal House";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Dyr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_AnimalHouse3;
        private System.Windows.Forms.TextBox textBox_Art;
        private System.Windows.Forms.TextBox textBox_EjerNavn;
        private System.Windows.Forms.Button button_RegDyr;
        private System.Windows.Forms.Label label_Art;
        private System.Windows.Forms.Label label_EjerIdDyr;
        private System.Windows.Forms.DataGridView dataGridView_Dyr;
        private System.Windows.Forms.TextBox textBox_Køn;
        private System.Windows.Forms.Label label_Køn;
        private System.Windows.Forms.Button button_SletDyr;
        private System.Windows.Forms.Label label_Dyr;
        private System.Windows.Forms.TextBox textBox_Race;
        private System.Windows.Forms.Label label_Race;
        private System.Windows.Forms.Label label_DyrReg;
        private System.Windows.Forms.Button button_SøgningDyr;
        private System.Windows.Forms.TextBox textBox_Alder;
        private System.Windows.Forms.Label label_Alder;
    }
}