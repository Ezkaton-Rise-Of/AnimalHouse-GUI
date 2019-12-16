namespace AnimalHouse_GUI
{
    partial class AnimalHouseGUI_JournalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalHouseGUI_JournalForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_søg = new System.Windows.Forms.Button();
            this.comboBox_ejer = new System.Windows.Forms.ComboBox();
            this.comboBox_dyr = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_behandler = new System.Windows.Forms.ComboBox();
            this.textBox_beskrivelse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_søgning = new System.Windows.Forms.Button();
            this.button_slet = new System.Windows.Forms.Button();
            this.button_gem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_behandler2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_annulere = new System.Windows.Forms.Button();
            this.button_hent_record = new System.Windows.Forms.Button();
            this.button_hent_alle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_info4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_info3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_info2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_info1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(636, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1107, 424);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button2.Location = new System.Drawing.Point(1615, 966);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Tilbage";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_søg);
            this.groupBox1.Controls.Add(this.comboBox_ejer);
            this.groupBox1.Controls.Add(this.comboBox_dyr);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox_behandler);
            this.groupBox1.Controls.Add(this.textBox_beskrivelse);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 844);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "tilføj et nyt record";
            // 
            // button_søg
            // 
            this.button_søg.AutoSize = true;
            this.button_søg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_søg.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_søg.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_søg.Location = new System.Drawing.Point(136, 197);
            this.button_søg.Name = "button_søg";
            this.button_søg.Size = new System.Drawing.Size(137, 44);
            this.button_søg.TabIndex = 11;
            this.button_søg.Text = "Søg";
            this.button_søg.UseVisualStyleBackColor = false;
            this.button_søg.Click += new System.EventHandler(this.button_søg_Click);
            // 
            // comboBox_ejer
            // 
            this.comboBox_ejer.FormattingEnabled = true;
            this.comboBox_ejer.Location = new System.Drawing.Point(136, 146);
            this.comboBox_ejer.Name = "comboBox_ejer";
            this.comboBox_ejer.Size = new System.Drawing.Size(347, 32);
            this.comboBox_ejer.TabIndex = 8;
            this.comboBox_ejer.SelectedIndexChanged += new System.EventHandler(this.comboBox_ejer_SelectedIndexChanged);
            // 
            // comboBox_dyr
            // 
            this.comboBox_dyr.FormattingEnabled = true;
            this.comboBox_dyr.Location = new System.Drawing.Point(136, 286);
            this.comboBox_dyr.Name = "comboBox_dyr";
            this.comboBox_dyr.Size = new System.Drawing.Size(347, 32);
            this.comboBox_dyr.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kunde";
            // 
            // comboBox_behandler
            // 
            this.comboBox_behandler.FormattingEnabled = true;
            this.comboBox_behandler.Location = new System.Drawing.Point(136, 69);
            this.comboBox_behandler.Name = "comboBox_behandler";
            this.comboBox_behandler.Size = new System.Drawing.Size(347, 32);
            this.comboBox_behandler.TabIndex = 4;
            // 
            // textBox_beskrivelse
            // 
            this.textBox_beskrivelse.Location = new System.Drawing.Point(6, 382);
            this.textBox_beskrivelse.Multiline = true;
            this.textBox_beskrivelse.Name = "textBox_beskrivelse";
            this.textBox_beskrivelse.Size = new System.Drawing.Size(577, 438);
            this.textBox_beskrivelse.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Beskrivelse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dyr";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Behandler";
            // 
            // button_søgning
            // 
            this.button_søgning.AutoSize = true;
            this.button_søgning.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_søgning.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_søgning.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_søgning.Location = new System.Drawing.Point(1180, 136);
            this.button_søgning.Name = "button_søgning";
            this.button_søgning.Size = new System.Drawing.Size(137, 51);
            this.button_søgning.TabIndex = 4;
            this.button_søgning.Text = "Søgning";
            this.button_søgning.UseVisualStyleBackColor = false;
            this.button_søgning.Click += new System.EventHandler(this.button_søgning_Click);
            // 
            // button_slet
            // 
            this.button_slet.AutoSize = true;
            this.button_slet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_slet.Enabled = false;
            this.button_slet.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_slet.ForeColor = System.Drawing.Color.Red;
            this.button_slet.Location = new System.Drawing.Point(936, 634);
            this.button_slet.Name = "button_slet";
            this.button_slet.Size = new System.Drawing.Size(137, 51);
            this.button_slet.TabIndex = 5;
            this.button_slet.Text = "Slet";
            this.button_slet.UseVisualStyleBackColor = false;
            this.button_slet.Click += new System.EventHandler(this.button_slet_Click);
            // 
            // button_gem
            // 
            this.button_gem.AutoSize = true;
            this.button_gem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_gem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_gem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_gem.Location = new System.Drawing.Point(115, 878);
            this.button_gem.Name = "button_gem";
            this.button_gem.Size = new System.Drawing.Size(137, 68);
            this.button_gem.TabIndex = 6;
            this.button_gem.Text = "Gem";
            this.button_gem.UseVisualStyleBackColor = false;
            this.button_gem.Click += new System.EventHandler(this.button_gem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 1010);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "?";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboBox_behandler2
            // 
            this.comboBox_behandler2.FormattingEnabled = true;
            this.comboBox_behandler2.Location = new System.Drawing.Point(812, 147);
            this.comboBox_behandler2.Name = "comboBox_behandler2";
            this.comboBox_behandler2.Size = new System.Drawing.Size(347, 28);
            this.comboBox_behandler2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(713, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Behandler";
            // 
            // button_annulere
            // 
            this.button_annulere.AutoSize = true;
            this.button_annulere.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_annulere.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_annulere.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_annulere.Location = new System.Drawing.Point(300, 878);
            this.button_annulere.Name = "button_annulere";
            this.button_annulere.Size = new System.Drawing.Size(137, 68);
            this.button_annulere.TabIndex = 10;
            this.button_annulere.Text = "Annullere";
            this.button_annulere.UseVisualStyleBackColor = false;
            this.button_annulere.Click += new System.EventHandler(this.button_annulere_Click);
            // 
            // button_hent_record
            // 
            this.button_hent_record.AutoSize = true;
            this.button_hent_record.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_hent_record.Enabled = false;
            this.button_hent_record.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hent_record.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_hent_record.Location = new System.Drawing.Point(793, 634);
            this.button_hent_record.Name = "button_hent_record";
            this.button_hent_record.Size = new System.Drawing.Size(137, 51);
            this.button_hent_record.TabIndex = 11;
            this.button_hent_record.Text = "Hent record";
            this.button_hent_record.UseVisualStyleBackColor = false;
            this.button_hent_record.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_hent_alle
            // 
            this.button_hent_alle.AutoSize = true;
            this.button_hent_alle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_hent_alle.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hent_alle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_hent_alle.Location = new System.Drawing.Point(636, 634);
            this.button_hent_alle.Name = "button_hent_alle";
            this.button_hent_alle.Size = new System.Drawing.Size(137, 51);
            this.button_hent_alle.TabIndex = 12;
            this.button_hent_alle.Text = "Vis alle";
            this.button_hent_alle.UseVisualStyleBackColor = false;
            this.button_hent_alle.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_info4);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox_info3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox_info2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox_info1);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(636, 691);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1007, 269);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Journal information";
            // 
            // textBox_info4
            // 
            this.textBox_info4.Location = new System.Drawing.Point(495, 32);
            this.textBox_info4.Name = "textBox_info4";
            this.textBox_info4.ReadOnly = true;
            this.textBox_info4.Size = new System.Drawing.Size(207, 26);
            this.textBox_info4.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(444, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 19);
            this.label10.TabIndex = 6;
            this.label10.Text = "Dato";
            // 
            // textBox_info3
            // 
            this.textBox_info3.Location = new System.Drawing.Point(137, 131);
            this.textBox_info3.Multiline = true;
            this.textBox_info3.Name = "textBox_info3";
            this.textBox_info3.ReadOnly = true;
            this.textBox_info3.Size = new System.Drawing.Size(850, 117);
            this.textBox_info3.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "Beskrivelse";
            // 
            // textBox_info2
            // 
            this.textBox_info2.Location = new System.Drawing.Point(137, 77);
            this.textBox_info2.Name = "textBox_info2";
            this.textBox_info2.ReadOnly = true;
            this.textBox_info2.Size = new System.Drawing.Size(207, 26);
            this.textBox_info2.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Dyr";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Behandler";
            // 
            // textBox_info1
            // 
            this.textBox_info1.Location = new System.Drawing.Point(137, 34);
            this.textBox_info1.Name = "textBox_info1";
            this.textBox_info1.ReadOnly = true;
            this.textBox_info1.Size = new System.Drawing.Size(207, 26);
            this.textBox_info1.TabIndex = 0;
            // 
            // AnimalHouseGUI_JournalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 1043);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_hent_alle);
            this.Controls.Add(this.button_hent_record);
            this.Controls.Add(this.button_annulere);
            this.Controls.Add(this.comboBox_behandler2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_gem);
            this.Controls.Add(this.button_slet);
            this.Controls.Add(this.button_søgning);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnimalHouseGUI_JournalForm";
            this.Text = "Animal House";
            this.Load += new System.EventHandler(this.AnimalHouseGUI_JournalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_behandler;
        private System.Windows.Forms.TextBox textBox_beskrivelse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_søgning;
        private System.Windows.Forms.Button button_slet;
        private System.Windows.Forms.Button button_gem;
        private System.Windows.Forms.ComboBox comboBox_dyr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_behandler2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_annulere;
        private System.Windows.Forms.ComboBox comboBox_ejer;
        private System.Windows.Forms.Button button_søg;
        private System.Windows.Forms.Button button_hent_record;
        private System.Windows.Forms.Button button_hent_alle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_info3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_info2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_info1;
        private System.Windows.Forms.TextBox textBox_info4;
        private System.Windows.Forms.Label label10;
    }
}