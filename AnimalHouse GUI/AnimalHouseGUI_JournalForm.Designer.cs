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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Gem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_beskrivelse = new System.Windows.Forms.TextBox();
            this.comboBox_behandler = new System.Windows.Forms.ComboBox();
            this.button_Søg = new System.Windows.Forms.Button();
            this.button_Slet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ejerTlf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_dyr = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(657, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1086, 788);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button2.Location = new System.Drawing.Point(1582, 919);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 70);
            this.button2.TabIndex = 2;
            this.button2.Text = "Tilbage";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_dyr);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_ejerTlf);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox_behandler);
            this.groupBox1.Controls.Add(this.textBox_beskrivelse);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 880);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Journal info";
            // 
            // button_Gem
            // 
            this.button_Gem.AutoSize = true;
            this.button_Gem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Gem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Gem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_Gem.Location = new System.Drawing.Point(164, 898);
            this.button_Gem.Name = "button_Gem";
            this.button_Gem.Size = new System.Drawing.Size(161, 70);
            this.button_Gem.TabIndex = 4;
            this.button_Gem.Text = "Gem";
            this.button_Gem.UseVisualStyleBackColor = false;
            this.button_Gem.Click += new System.EventHandler(this.button_Gem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Behhandler:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Beskrivelse:";
            // 
            // textBox_beskrivelse
            // 
            this.textBox_beskrivelse.Location = new System.Drawing.Point(19, 425);
            this.textBox_beskrivelse.Multiline = true;
            this.textBox_beskrivelse.Name = "textBox_beskrivelse";
            this.textBox_beskrivelse.Size = new System.Drawing.Size(490, 449);
            this.textBox_beskrivelse.TabIndex = 2;
            // 
            // comboBox_behandler
            // 
            this.comboBox_behandler.FormattingEnabled = true;
            this.comboBox_behandler.Location = new System.Drawing.Point(146, 56);
            this.comboBox_behandler.Name = "comboBox_behandler";
            this.comboBox_behandler.Size = new System.Drawing.Size(304, 32);
            this.comboBox_behandler.TabIndex = 3;
            // 
            // button_Søg
            // 
            this.button_Søg.AutoSize = true;
            this.button_Søg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Søg.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Søg.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_Søg.Location = new System.Drawing.Point(657, 919);
            this.button_Søg.Name = "button_Søg";
            this.button_Søg.Size = new System.Drawing.Size(161, 70);
            this.button_Søg.TabIndex = 5;
            this.button_Søg.Text = "Søgning";
            this.button_Søg.UseVisualStyleBackColor = false;
            // 
            // button_Slet
            // 
            this.button_Slet.AutoSize = true;
            this.button_Slet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Slet.Enabled = false;
            this.button_Slet.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Slet.ForeColor = System.Drawing.Color.Red;
            this.button_Slet.Location = new System.Drawing.Point(842, 919);
            this.button_Slet.Name = "button_Slet";
            this.button_Slet.Size = new System.Drawing.Size(161, 70);
            this.button_Slet.TabIndex = 6;
            this.button_Slet.Text = "Slet";
            this.button_Slet.UseVisualStyleBackColor = false;
            this.button_Slet.Click += new System.EventHandler(this.button_Slet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ejer tlf:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 1010);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "?";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox_ejerTlf
            // 
            this.textBox_ejerTlf.Location = new System.Drawing.Point(146, 124);
            this.textBox_ejerTlf.Name = "textBox_ejerTlf";
            this.textBox_ejerTlf.Size = new System.Drawing.Size(304, 30);
            this.textBox_ejerTlf.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Dyr:";
            // 
            // comboBox_dyr
            // 
            this.comboBox_dyr.FormattingEnabled = true;
            this.comboBox_dyr.Location = new System.Drawing.Point(146, 212);
            this.comboBox_dyr.Name = "comboBox_dyr";
            this.comboBox_dyr.Size = new System.Drawing.Size(304, 32);
            this.comboBox_dyr.TabIndex = 7;
            // 
            // AnimalHouseGUI_JournalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 1043);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_Slet);
            this.Controls.Add(this.button_Søg);
            this.Controls.Add(this.button_Gem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AnimalHouseGUI_JournalForm";
            this.Text = "Animal House";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_behandler;
        private System.Windows.Forms.TextBox textBox_beskrivelse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Gem;
        private System.Windows.Forms.Button button_Søg;
        private System.Windows.Forms.Button button_Slet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_ejerTlf;
        private System.Windows.Forms.ComboBox comboBox_dyr;
        private System.Windows.Forms.Label label5;
    }
}