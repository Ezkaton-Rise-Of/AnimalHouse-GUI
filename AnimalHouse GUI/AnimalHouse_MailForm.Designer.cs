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
            this.button_Send = new System.Windows.Forms.Button();
            this.button_Tilbage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox_modtager_list = new System.Windows.Forms.ListBox();
            this.textBox_inhold = new System.Windows.Forms.TextBox();
            this.textBox_subjekt = new System.Windows.Forms.TextBox();
            this.Lable_Body = new System.Windows.Forms.Label();
            this.label_Subjekt = new System.Windows.Forms.Label();
            this.Lable_To = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_fjern = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_tilføj = new System.Windows.Forms.Button();
            this.textBox_days = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_hjælpe = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button_visAlle = new System.Windows.Forms.Button();
            this.button_print = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_annullere = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Send
            // 
            this.button_Send.AutoSize = true;
            this.button_Send.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Send.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Send.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_Send.Location = new System.Drawing.Point(128, 911);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(136, 48);
            this.button_Send.TabIndex = 0;
            this.button_Send.Text = "Send";
            this.button_Send.UseVisualStyleBackColor = false;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // button_Tilbage
            // 
            this.button_Tilbage.AutoSize = true;
            this.button_Tilbage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Tilbage.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Tilbage.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_Tilbage.Location = new System.Drawing.Point(1599, 951);
            this.button_Tilbage.Name = "button_Tilbage";
            this.button_Tilbage.Size = new System.Drawing.Size(157, 68);
            this.button_Tilbage.TabIndex = 1;
            this.button_Tilbage.Text = "Tilbage";
            this.button_Tilbage.UseVisualStyleBackColor = false;
            this.button_Tilbage.Click += new System.EventHandler(this.button_Tilbage_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_annullere);
            this.groupBox1.Controls.Add(this.listBox_modtager_list);
            this.groupBox1.Controls.Add(this.textBox_inhold);
            this.groupBox1.Controls.Add(this.textBox_subjekt);
            this.groupBox1.Controls.Add(this.Lable_Body);
            this.groupBox1.Controls.Add(this.label_Subjekt);
            this.groupBox1.Controls.Add(this.Lable_To);
            this.groupBox1.Controls.Add(this.button_Send);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 969);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Email info";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // listBox_modtager_list
            // 
            this.listBox_modtager_list.FormattingEnabled = true;
            this.listBox_modtager_list.ItemHeight = 29;
            this.listBox_modtager_list.Location = new System.Drawing.Point(156, 42);
            this.listBox_modtager_list.Name = "listBox_modtager_list";
            this.listBox_modtager_list.Size = new System.Drawing.Size(583, 149);
            this.listBox_modtager_list.TabIndex = 6;
            // 
            // textBox_inhold
            // 
            this.textBox_inhold.Location = new System.Drawing.Point(11, 328);
            this.textBox_inhold.Multiline = true;
            this.textBox_inhold.Name = "textBox_inhold";
            this.textBox_inhold.Size = new System.Drawing.Size(728, 577);
            this.textBox_inhold.TabIndex = 5;
            // 
            // textBox_subjekt
            // 
            this.textBox_subjekt.Location = new System.Drawing.Point(156, 251);
            this.textBox_subjekt.Name = "textBox_subjekt";
            this.textBox_subjekt.Size = new System.Drawing.Size(583, 35);
            this.textBox_subjekt.TabIndex = 4;
            // 
            // Lable_Body
            // 
            this.Lable_Body.AutoSize = true;
            this.Lable_Body.Location = new System.Drawing.Point(13, 295);
            this.Lable_Body.Name = "Lable_Body";
            this.Lable_Body.Size = new System.Drawing.Size(137, 29);
            this.Lable_Body.TabIndex = 3;
            this.Lable_Body.Text = "Meddelelsen:";
            // 
            // label_Subjekt
            // 
            this.label_Subjekt.AutoSize = true;
            this.label_Subjekt.Location = new System.Drawing.Point(60, 253);
            this.label_Subjekt.Name = "label_Subjekt";
            this.label_Subjekt.Size = new System.Drawing.Size(91, 29);
            this.label_Subjekt.TabIndex = 2;
            this.label_Subjekt.Text = "Subjekt:";
            // 
            // Lable_To
            // 
            this.Lable_To.AutoSize = true;
            this.Lable_To.Location = new System.Drawing.Point(106, 42);
            this.Lable_To.Name = "Lable_To";
            this.Lable_To.Size = new System.Drawing.Size(44, 29);
            this.Lable_To.TabIndex = 1;
            this.Lable_To.Text = "To:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(729, 735);
            this.dataGridView1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(1004, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(758, 787);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kunde mail list";
            // 
            // button_fjern
            // 
            this.button_fjern.AutoSize = true;
            this.button_fjern.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_fjern.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_fjern.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_fjern.Location = new System.Drawing.Point(807, 233);
            this.button_fjern.Name = "button_fjern";
            this.button_fjern.Size = new System.Drawing.Size(157, 68);
            this.button_fjern.TabIndex = 6;
            this.button_fjern.Text = "Fjern";
            this.button_fjern.UseVisualStyleBackColor = false;
            this.button_fjern.Click += new System.EventHandler(this.button_fjern_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button2.Location = new System.Drawing.Point(1114, 834);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 48);
            this.button2.TabIndex = 7;
            this.button2.Text = "Vis";
            this.button2.UseVisualStyleBackColor = false;
            //this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_tilføj
            // 
            this.button_tilføj.AutoSize = true;
            this.button_tilføj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_tilføj.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tilføj.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_tilføj.Location = new System.Drawing.Point(807, 123);
            this.button_tilføj.Name = "button_tilføj";
            this.button_tilføj.Size = new System.Drawing.Size(157, 68);
            this.button_tilføj.TabIndex = 7;
            this.button_tilføj.Text = "Tilføj";
            this.button_tilføj.UseVisualStyleBackColor = false;
            this.button_tilføj.Click += new System.EventHandler(this.button_tilføj_Click);
            // 
            // textBox_days
            // 
            this.textBox_days.Location = new System.Drawing.Point(1008, 848);
            this.textBox_days.Name = "textBox_days";
            this.textBox_days.Size = new System.Drawing.Size(100, 26);
            this.textBox_days.TabIndex = 8;
            this.textBox_days.Text = "365";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1004, 807);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dage siden sidste besøg";
            // 
            // label_hjælpe
            // 
            this.label_hjælpe.AutoSize = true;
            this.label_hjælpe.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hjælpe.Location = new System.Drawing.Point(16, 1010);
            this.label_hjælpe.Name = "label_hjælpe";
            this.label_hjælpe.Size = new System.Drawing.Size(20, 24);
            this.label_hjælpe.TabIndex = 10;
            this.label_hjælpe.Text = "?";
            this.label_hjælpe.Click += new System.EventHandler(this.label_hjælpe_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(807, 359);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(178, 26);
            this.textBox4.TabIndex = 11;
            // 
            // button_visAlle
            // 
            this.button_visAlle.AutoSize = true;
            this.button_visAlle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_visAlle.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_visAlle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_visAlle.Location = new System.Drawing.Point(1266, 834);
            this.button_visAlle.Name = "button_visAlle";
            this.button_visAlle.Size = new System.Drawing.Size(138, 48);
            this.button_visAlle.TabIndex = 12;
            this.button_visAlle.Text = "Vis alle";
            this.button_visAlle.UseVisualStyleBackColor = false;
            //this.button_visAlle.Click += new System.EventHandler(this.button_visAlle_Click);
            // 
            // button_print
            // 
            this.button_print.AutoSize = true;
            this.button_print.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_print.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_print.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_print.Location = new System.Drawing.Point(1424, 834);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(138, 48);
            this.button_print.TabIndex = 13;
            this.button_print.Text = "Print list";
            this.button_print.UseVisualStyleBackColor = false;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(828, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 48);
            this.button1.TabIndex = 7;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_annullere
            // 
            this.button_annullere.AutoSize = true;
            this.button_annullere.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_annullere.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_annullere.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_annullere.Location = new System.Drawing.Point(342, 911);
            this.button_annullere.Name = "button_annullere";
            this.button_annullere.Size = new System.Drawing.Size(136, 48);
            this.button_annullere.TabIndex = 7;
            this.button_annullere.Text = "Annullere";
            this.button_annullere.UseVisualStyleBackColor = false;
            this.button_annullere.Click += new System.EventHandler(this.button_annullere_Click);
            // 
            // AnimalHouse_MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 1043);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_print);
            this.Controls.Add(this.button_visAlle);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label_hjælpe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_days);
            this.Controls.Add(this.button_tilføj);
            this.Controls.Add(this.button_fjern);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Tilbage);
            this.Name = "AnimalHouse_MailForm";
            this.Text = "Animal House";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.Button button_Tilbage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox_modtager_list;
        private System.Windows.Forms.TextBox textBox_inhold;
        private System.Windows.Forms.TextBox textBox_subjekt;
        private System.Windows.Forms.Label Lable_Body;
        private System.Windows.Forms.Label label_Subjekt;
        private System.Windows.Forms.Label Lable_To;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_fjern;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_tilføj;
        private System.Windows.Forms.TextBox textBox_days;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_hjælpe;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button_visAlle;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_annullere;
    }
}