namespace AnimalHouse_GUI
{
    partial class AnimaHouseGui_AnsatForm
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
            this.textBox_ansatNavn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_stelling = new System.Windows.Forms.ComboBox();
            this.buttonTilbage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Hent = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Slet = new System.Windows.Forms.Button();
            this.textBox_navn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_tlf = new System.Windows.Forms.TextBox();
            this.button_Register = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(860, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(838, 433);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // textBox_ansatNavn
            // 
            this.textBox_ansatNavn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_ansatNavn.Location = new System.Drawing.Point(970, 191);
            this.textBox_ansatNavn.Name = "textBox_ansatNavn";
            this.textBox_ansatNavn.Size = new System.Drawing.Size(322, 26);
            this.textBox_ansatNavn.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1320, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Søgning";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_stelling
            // 
            this.comboBox_stelling.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_stelling.FormattingEnabled = true;
            this.comboBox_stelling.Items.AddRange(new object[] {
            "Dyrlæge",
            "Reciptionist",
            "veterinærsygeplejerske"});
            this.comboBox_stelling.Location = new System.Drawing.Point(164, 137);
            this.comboBox_stelling.Name = "comboBox_stelling";
            this.comboBox_stelling.Size = new System.Drawing.Size(263, 32);
            this.comboBox_stelling.TabIndex = 3;
            // 
            // buttonTilbage
            // 
            this.buttonTilbage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTilbage.AutoSize = true;
            this.buttonTilbage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTilbage.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTilbage.Location = new System.Drawing.Point(1371, 682);
            this.buttonTilbage.Name = "buttonTilbage";
            this.buttonTilbage.Size = new System.Drawing.Size(151, 70);
            this.buttonTilbage.TabIndex = 4;
            this.buttonTilbage.Text = "Tilbage";
            this.buttonTilbage.UseVisualStyleBackColor = false;
            this.buttonTilbage.Click += new System.EventHandler(this.buttonTilbage_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(864, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ansat navn";
            // 
            // button_Hent
            // 
            this.button_Hent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Hent.AutoSize = true;
            this.button_Hent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Hent.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Hent.Location = new System.Drawing.Point(861, 682);
            this.button_Hent.Name = "button_Hent";
            this.button_Hent.Size = new System.Drawing.Size(163, 70);
            this.button_Hent.TabIndex = 6;
            this.button_Hent.Text = "Hent alle ansate";
            this.button_Hent.UseVisualStyleBackColor = false;
            this.button_Hent.Click += new System.EventHandler(this.button_Hent_Click);
            // 
            // button_Update
            // 
            this.button_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Update.AutoSize = true;
            this.button_Update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Update.Enabled = false;
            this.button_Update.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.Location = new System.Drawing.Point(1042, 682);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(144, 70);
            this.button_Update.TabIndex = 7;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Slet
            // 
            this.button_Slet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Slet.AutoSize = true;
            this.button_Slet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Slet.Enabled = false;
            this.button_Slet.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Slet.ForeColor = System.Drawing.Color.Red;
            this.button_Slet.Location = new System.Drawing.Point(1199, 682);
            this.button_Slet.Name = "button_Slet";
            this.button_Slet.Size = new System.Drawing.Size(146, 70);
            this.button_Slet.TabIndex = 8;
            this.button_Slet.Text = "Slet";
            this.button_Slet.UseVisualStyleBackColor = false;
            this.button_Slet.Click += new System.EventHandler(this.button_Slet_Click);
            // 
            // textBox_navn
            // 
            this.textBox_navn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_navn.Location = new System.Drawing.Point(164, 52);
            this.textBox_navn.Name = "textBox_navn";
            this.textBox_navn.Size = new System.Drawing.Size(263, 30);
            this.textBox_navn.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ansat navn";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Stelling";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_tlf);
            this.groupBox1.Controls.Add(this.button_Register);
            this.groupBox1.Controls.Add(this.comboBox_stelling);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_navn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(55, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 479);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ansat Register";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tlf.";
            // 
            // textBox_tlf
            // 
            this.textBox_tlf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_tlf.Location = new System.Drawing.Point(152, 224);
            this.textBox_tlf.Name = "textBox_tlf";
            this.textBox_tlf.Size = new System.Drawing.Size(275, 30);
            this.textBox_tlf.TabIndex = 14;
            // 
            // button_Register
            // 
            this.button_Register.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Register.AutoSize = true;
            this.button_Register.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Register.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Register.Location = new System.Drawing.Point(164, 274);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(143, 50);
            this.button_Register.TabIndex = 13;
            this.button_Register.Text = "Tilføje";
            this.button_Register.UseVisualStyleBackColor = false;
            this.button_Register.Click += new System.EventHandler(this.button_Register_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 1001);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "?";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // AnimaHouseGui_AnsatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 1043);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Slet);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Hent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTilbage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_ansatNavn);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnimaHouseGui_AnsatForm";
            this.Text = "Animal House";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_ansatNavn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_stelling;
        private System.Windows.Forms.Button buttonTilbage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Hent;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Slet;
        private System.Windows.Forms.TextBox textBox_navn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Register;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_tlf;
    }
}