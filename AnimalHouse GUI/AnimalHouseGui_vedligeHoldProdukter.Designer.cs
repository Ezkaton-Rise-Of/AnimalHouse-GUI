namespace AnimalHouse_GUI
{
    partial class AnimalHouseGui_vedligeHoldProdukter
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
            this.Navn_InputBox = new System.Windows.Forms.TextBox();
            this.Pris_Inputbox = new System.Windows.Forms.TextBox();
            this.Beskrive_InputBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ProduktId_Label = new System.Windows.Forms.Label();
            this.ProduktId_ShowId = new System.Windows.Forms.Label();
            this.Produkt_Navn = new System.Windows.Forms.Label();
            this.Label_Beskrivelse = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ServiceType_Label = new System.Windows.Forms.Label();
            this.Pris_Label = new System.Windows.Forms.Label();
            this.Button_slet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tilbage_button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Navn_InputBox
            // 
            this.Navn_InputBox.Location = new System.Drawing.Point(9, 67);
            this.Navn_InputBox.Name = "Navn_InputBox";
            this.Navn_InputBox.Size = new System.Drawing.Size(315, 20);
            this.Navn_InputBox.TabIndex = 0;
            this.Navn_InputBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Pris_Inputbox
            // 
            this.Pris_Inputbox.Location = new System.Drawing.Point(9, 304);
            this.Pris_Inputbox.Name = "Pris_Inputbox";
            this.Pris_Inputbox.Size = new System.Drawing.Size(315, 20);
            this.Pris_Inputbox.TabIndex = 2;
            this.Pris_Inputbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Beskrive_InputBox
            // 
            this.Beskrive_InputBox.Location = new System.Drawing.Point(9, 109);
            this.Beskrive_InputBox.Multiline = true;
            this.Beskrive_InputBox.Name = "Beskrive_InputBox";
            this.Beskrive_InputBox.Size = new System.Drawing.Size(315, 176);
            this.Beskrive_InputBox.TabIndex = 3;
            this.Beskrive_InputBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Button_slet);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.Pris_Label);
            this.groupBox1.Controls.Add(this.ServiceType_Label);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.Label_Beskrivelse);
            this.groupBox1.Controls.Add(this.Produkt_Navn);
            this.groupBox1.Controls.Add(this.ProduktId_ShowId);
            this.groupBox1.Controls.Add(this.ProduktId_Label);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Navn_InputBox);
            this.groupBox1.Controls.Add(this.Beskrive_InputBox);
            this.groupBox1.Controls.Add(this.Pris_Inputbox);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 401);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opdater Service Produkter";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Tilføj Produkt";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Updater Produkt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProduktId_Label
            // 
            this.ProduktId_Label.AutoSize = true;
            this.ProduktId_Label.Location = new System.Drawing.Point(6, 21);
            this.ProduktId_Label.Name = "ProduktId_Label";
            this.ProduktId_Label.Size = new System.Drawing.Size(56, 13);
            this.ProduktId_Label.TabIndex = 9;
            this.ProduktId_Label.Text = "Produkt Id";
            // 
            // ProduktId_ShowId
            // 
            this.ProduktId_ShowId.AutoSize = true;
            this.ProduktId_ShowId.Location = new System.Drawing.Point(68, 21);
            this.ProduktId_ShowId.Name = "ProduktId_ShowId";
            this.ProduktId_ShowId.Size = new System.Drawing.Size(35, 13);
            this.ProduktId_ShowId.TabIndex = 10;
            this.ProduktId_ShowId.Text = "empty";
            // 
            // Produkt_Navn
            // 
            this.Produkt_Navn.AutoSize = true;
            this.Produkt_Navn.Location = new System.Drawing.Point(9, 48);
            this.Produkt_Navn.Name = "Produkt_Navn";
            this.Produkt_Navn.Size = new System.Drawing.Size(36, 13);
            this.Produkt_Navn.TabIndex = 11;
            this.Produkt_Navn.Text = "Navn:";
            // 
            // Label_Beskrivelse
            // 
            this.Label_Beskrivelse.AutoSize = true;
            this.Label_Beskrivelse.Location = new System.Drawing.Point(10, 90);
            this.Label_Beskrivelse.Name = "Label_Beskrivelse";
            this.Label_Beskrivelse.Size = new System.Drawing.Size(61, 13);
            this.Label_Beskrivelse.TabIndex = 12;
            this.Label_Beskrivelse.Text = "Beskrivelse";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 343);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(315, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // ServiceType_Label
            // 
            this.ServiceType_Label.AutoSize = true;
            this.ServiceType_Label.Location = new System.Drawing.Point(6, 327);
            this.ServiceType_Label.Name = "ServiceType_Label";
            this.ServiceType_Label.Size = new System.Drawing.Size(67, 13);
            this.ServiceType_Label.TabIndex = 14;
            this.ServiceType_Label.Text = "ServiceType";
            this.ServiceType_Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pris_Label
            // 
            this.Pris_Label.AutoSize = true;
            this.Pris_Label.Location = new System.Drawing.Point(6, 288);
            this.Pris_Label.Name = "Pris_Label";
            this.Pris_Label.Size = new System.Drawing.Size(24, 13);
            this.Pris_Label.TabIndex = 8;
            this.Pris_Label.Text = "Pris";
            // 
            // Button_slet
            // 
            this.Button_slet.Location = new System.Drawing.Point(125, 370);
            this.Button_slet.Name = "Button_slet";
            this.Button_slet.Size = new System.Drawing.Size(75, 23);
            this.Button_slet.TabIndex = 15;
            this.Button_slet.Text = "Slet";
            this.Button_slet.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(380, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 401);
            this.dataGridView1.TabIndex = 6;
            // 
            // Tilbage_button
            // 
            this.Tilbage_button.Location = new System.Drawing.Point(849, 579);
            this.Tilbage_button.Name = "Tilbage_button";
            this.Tilbage_button.Size = new System.Drawing.Size(75, 23);
            this.Tilbage_button.TabIndex = 7;
            this.Tilbage_button.Text = "Tilbage";
            this.Tilbage_button.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 430);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // AnimalHouseGui_vedligeHoldProdukter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 614);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Tilbage_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AnimalHouseGui_vedligeHoldProdukter";
            this.Text = "Produkt vedligehold";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Navn_InputBox;
        private System.Windows.Forms.TextBox Pris_Inputbox;
        private System.Windows.Forms.TextBox Beskrive_InputBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label ServiceType_Label;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Label_Beskrivelse;
        private System.Windows.Forms.Label Produkt_Navn;
        private System.Windows.Forms.Label ProduktId_ShowId;
        private System.Windows.Forms.Label ProduktId_Label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Button_slet;
        private System.Windows.Forms.Label Pris_Label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Tilbage_button;
        private System.Windows.Forms.Button button3;
    }
}