namespace AnimalHouse_GUI
{
    partial class AnimalHouse_MailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalHouse_MailForm));
            this.button_Tilbage = new System.Windows.Forms.Button();
            this.button_print = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_visAlle = new System.Windows.Forms.Button();
            this.button_fjern = new System.Windows.Forms.Button();
            this.textBox_days = new System.Windows.Forms.TextBox();
            this.button_tilføj = new System.Windows.Forms.Button();
            this.label_hjælpe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox_modtagere = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_subjekt = new System.Windows.Forms.TextBox();
            this.textBox_inhold = new System.Windows.Forms.TextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.button_annullere = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Tilbage
            // 
            this.button_Tilbage.AutoSize = true;
            this.button_Tilbage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Tilbage.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Tilbage.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_Tilbage.Location = new System.Drawing.Point(1597, 945);
            this.button_Tilbage.Name = "button_Tilbage";
            this.button_Tilbage.Size = new System.Drawing.Size(158, 68);
            this.button_Tilbage.TabIndex = 14;
            this.button_Tilbage.Text = "Tilbage";
            this.button_Tilbage.UseVisualStyleBackColor = false;
            this.button_Tilbage.Click += new System.EventHandler(this.button_Tilbage_Click);
            // 
            // button_print
            // 
            this.button_print.AutoSize = true;
            this.button_print.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_print.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_print.Location = new System.Drawing.Point(1424, 834);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(138, 48);
            this.button_print.TabIndex = 13;
            this.button_print.Text = "Print list";
            this.button_print.UseVisualStyleBackColor = false;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(1004, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(758, 788);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kunde mail list";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(729, 735);
            this.dataGridView1.TabIndex = 4;
            // 
            // button_visAlle
            // 
            this.button_visAlle.AutoSize = true;
            this.button_visAlle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_visAlle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_visAlle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_visAlle.Location = new System.Drawing.Point(1266, 834);
            this.button_visAlle.Name = "button_visAlle";
            this.button_visAlle.Size = new System.Drawing.Size(138, 48);
            this.button_visAlle.TabIndex = 12;
            this.button_visAlle.Text = "Vis alle";
            this.button_visAlle.UseVisualStyleBackColor = false;
            this.button_visAlle.Click += new System.EventHandler(this.button_visAlle_Click);
            // 
            // button_fjern
            // 
            this.button_fjern.AutoSize = true;
            this.button_fjern.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_fjern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_fjern.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_fjern.Location = new System.Drawing.Point(807, 232);
            this.button_fjern.Name = "button_fjern";
            this.button_fjern.Size = new System.Drawing.Size(158, 68);
            this.button_fjern.TabIndex = 6;
            this.button_fjern.Text = "Fjern";
            this.button_fjern.UseVisualStyleBackColor = false;
            this.button_fjern.Click += new System.EventHandler(this.button_fjern_Click_1);
            // 
            // textBox_days
            // 
            this.textBox_days.Location = new System.Drawing.Point(1008, 848);
            this.textBox_days.Name = "textBox_days";
            this.textBox_days.Size = new System.Drawing.Size(100, 26);
            this.textBox_days.TabIndex = 8;
            this.textBox_days.Text = "365";
            // 
            // button_tilføj
            // 
            this.button_tilføj.AutoSize = true;
            this.button_tilføj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_tilføj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tilføj.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_tilføj.Location = new System.Drawing.Point(807, 123);
            this.button_tilføj.Name = "button_tilføj";
            this.button_tilføj.Size = new System.Drawing.Size(158, 68);
            this.button_tilføj.TabIndex = 7;
            this.button_tilføj.Text = "Tilføj";
            this.button_tilføj.UseVisualStyleBackColor = false;
            this.button_tilføj.Click += new System.EventHandler(this.button_tilføj_Click);
            // 
            // label_hjælpe
            // 
            this.label_hjælpe.AutoSize = true;
            this.label_hjælpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hjælpe.Location = new System.Drawing.Point(16, 1009);
            this.label_hjælpe.Name = "label_hjælpe";
            this.label_hjælpe.Size = new System.Drawing.Size(24, 25);
            this.label_hjælpe.TabIndex = 10;
            this.label_hjælpe.Text = "?";
            this.label_hjælpe.Click += new System.EventHandler(this.label_hjælpe_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1004, 808);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dage siden sidste besøg";
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button2.Location = new System.Drawing.Point(1114, 834);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 48);
            this.button2.TabIndex = 7;
            this.button2.Text = "Vis";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_annullere);
            this.groupBox1.Controls.Add(this.button_send);
            this.groupBox1.Controls.Add(this.textBox_inhold);
            this.groupBox1.Controls.Add(this.textBox_subjekt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.listBox_modtagere);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(52, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 947);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Email information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Liste over modtagere";
            // 
            // listBox_modtagere
            // 
            this.listBox_modtagere.FormattingEnabled = true;
            this.listBox_modtagere.ItemHeight = 24;
            this.listBox_modtagere.Location = new System.Drawing.Point(35, 74);
            this.listBox_modtagere.Name = "listBox_modtagere";
            this.listBox_modtagere.Size = new System.Drawing.Size(629, 220);
            this.listBox_modtagere.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Subjekt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Indhold";
            // 
            // textBox_subjekt
            // 
            this.textBox_subjekt.Location = new System.Drawing.Point(35, 342);
            this.textBox_subjekt.Name = "textBox_subjekt";
            this.textBox_subjekt.Size = new System.Drawing.Size(490, 30);
            this.textBox_subjekt.TabIndex = 4;
            // 
            // textBox_inhold
            // 
            this.textBox_inhold.Location = new System.Drawing.Point(35, 422);
            this.textBox_inhold.Multiline = true;
            this.textBox_inhold.Name = "textBox_inhold";
            this.textBox_inhold.Size = new System.Drawing.Size(629, 411);
            this.textBox_inhold.TabIndex = 5;
            // 
            // button_send
            // 
            this.button_send.AutoSize = true;
            this.button_send.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_send.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_send.Location = new System.Drawing.Point(137, 849);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(136, 48);
            this.button_send.TabIndex = 16;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = false;
            this.button_send.Click += new System.EventHandler(this.button_send_Click_1);
            // 
            // button_annullere
            // 
            this.button_annullere.AutoSize = true;
            this.button_annullere.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_annullere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_annullere.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_annullere.Location = new System.Drawing.Point(300, 849);
            this.button_annullere.Name = "button_annullere";
            this.button_annullere.Size = new System.Drawing.Size(136, 48);
            this.button_annullere.TabIndex = 16;
            this.button_annullere.Text = "annullere";
            this.button_annullere.UseVisualStyleBackColor = false;
            this.button_annullere.Click += new System.EventHandler(this.button_annullere_Click);
            // 
            // AnimalHouse_MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 1043);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Tilbage);
            this.Controls.Add(this.button_print);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_visAlle);
            this.Controls.Add(this.button_fjern);
            this.Controls.Add(this.textBox_days);
            this.Controls.Add(this.button_tilføj);
            this.Controls.Add(this.label_hjælpe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnimalHouse_MailForm";
            this.Text = "Animal House";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Tilbage;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_visAlle;
        private System.Windows.Forms.Button button_fjern;
        private System.Windows.Forms.TextBox textBox_days;
        private System.Windows.Forms.Button button_tilføj;
        private System.Windows.Forms.Label label_hjælpe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_annullere;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.TextBox textBox_inhold;
        private System.Windows.Forms.TextBox textBox_subjekt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox_modtagere;
        private System.Windows.Forms.Label label3;
    }
}