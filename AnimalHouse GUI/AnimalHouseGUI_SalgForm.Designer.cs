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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_fjerne = new System.Windows.Forms.Button();
            this.listBox_produkter = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_annullere = new System.Windows.Forms.Button();
            this.button_print = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_antal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_gem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_tilbage
            // 
            this.button_tilbage.AutoSize = true;
            this.button_tilbage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_tilbage.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tilbage.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_tilbage.Location = new System.Drawing.Point(1608, 959);
            this.button_tilbage.Name = "button_tilbage";
            this.button_tilbage.Size = new System.Drawing.Size(143, 61);
            this.button_tilbage.TabIndex = 0;
            this.button_tilbage.Text = "Tilbage";
            this.button_tilbage.UseVisualStyleBackColor = false;
            this.button_tilbage.Click += new System.EventHandler(this.button_tilbage_Click);
            // 
            // label_hjælpe
            // 
            this.label_hjælpe.AutoSize = true;
            this.label_hjælpe.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hjælpe.Location = new System.Drawing.Point(12, 1010);
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
            this.label1.Location = new System.Drawing.Point(120, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "vælg kunde:";
            // 
            // comboBox_kunde
            // 
            this.comboBox_kunde.FormattingEnabled = true;
            this.comboBox_kunde.Location = new System.Drawing.Point(268, 20);
            this.comboBox_kunde.Name = "comboBox_kunde";
            this.comboBox_kunde.Size = new System.Drawing.Size(290, 28);
            this.comboBox_kunde.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vælg produktkategori:";
            // 
            // comboBox_kategori
            // 
            this.comboBox_kategori.FormattingEnabled = true;
            this.comboBox_kategori.Location = new System.Drawing.Point(268, 67);
            this.comboBox_kategori.Name = "comboBox_kategori";
            this.comboBox_kategori.Size = new System.Drawing.Size(290, 28);
            this.comboBox_kategori.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vælg produkt:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(268, 119);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(290, 28);
            this.comboBox1.TabIndex = 7;
            // 
            // button_fjerne
            // 
            this.button_fjerne.AutoSize = true;
            this.button_fjerne.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_fjerne.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_fjerne.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_fjerne.Location = new System.Drawing.Point(415, 296);
            this.button_fjerne.Name = "button_fjerne";
            this.button_fjerne.Size = new System.Drawing.Size(143, 61);
            this.button_fjerne.TabIndex = 8;
            this.button_fjerne.Text = "Fjerne";
            this.button_fjerne.UseVisualStyleBackColor = false;
            this.button_fjerne.Click += new System.EventHandler(this.button_fjerne_Click);
            // 
            // listBox_produkter
            // 
            this.listBox_produkter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBox_produkter.FormattingEnabled = true;
            this.listBox_produkter.ItemHeight = 20;
            this.listBox_produkter.Location = new System.Drawing.Point(25, 379);
            this.listBox_produkter.Name = "listBox_produkter";
            this.listBox_produkter.Size = new System.Drawing.Size(636, 284);
            this.listBox_produkter.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(229, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 61);
            this.button1.TabIndex = 10;
            this.button1.Text = "Tilføje";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(747, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1015, 388);
            this.dataGridView1.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 672);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 26);
            this.textBox1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 672);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Rabat i %";
            // 
            // textBox_total
            // 
            this.textBox_total.Location = new System.Drawing.Point(528, 672);
            this.textBox_total.Name = "textBox_total";
            this.textBox_total.ReadOnly = true;
            this.textBox_total.Size = new System.Drawing.Size(105, 26);
            this.textBox_total.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(447, 672);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total";
            // 
            // button_annullere
            // 
            this.button_annullere.AutoSize = true;
            this.button_annullere.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_annullere.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_annullere.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_annullere.Location = new System.Drawing.Point(518, 727);
            this.button_annullere.Name = "button_annullere";
            this.button_annullere.Size = new System.Drawing.Size(143, 50);
            this.button_annullere.TabIndex = 16;
            this.button_annullere.Text = "Annullere";
            this.button_annullere.UseVisualStyleBackColor = false;
            // 
            // button_print
            // 
            this.button_print.AutoSize = true;
            this.button_print.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_print.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_print.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_print.Location = new System.Drawing.Point(150, 724);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(143, 53);
            this.button_print.TabIndex = 17;
            this.button_print.Text = "Print faktura";
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
            // textBox_antal
            // 
            this.textBox_antal.Location = new System.Drawing.Point(266, 171);
            this.textBox_antal.Name = "textBox_antal";
            this.textBox_antal.Size = new System.Drawing.Size(72, 26);
            this.textBox_antal.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(638, 675);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "Kr.";
            // 
            // button_gem
            // 
            this.button_gem.AutoSize = true;
            this.button_gem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_gem.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_gem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_gem.Location = new System.Drawing.Point(25, 724);
            this.button_gem.Name = "button_gem";
            this.button_gem.Size = new System.Drawing.Size(110, 53);
            this.button_gem.TabIndex = 21;
            this.button_gem.Text = "Gem";
            this.button_gem.UseVisualStyleBackColor = false;
            this.button_gem.Click += new System.EventHandler(this.button_gem_Click);
            // 
            // AnimalHouseGUI_SalgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 1043);
            this.Controls.Add(this.button_gem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_antal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_print);
            this.Controls.Add(this.button_annullere);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox_produkter);
            this.Controls.Add(this.button_fjerne);
            this.Controls.Add(this.comboBox1);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_fjerne;
        private System.Windows.Forms.ListBox listBox_produkter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_annullere;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_antal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_gem;
    }
}