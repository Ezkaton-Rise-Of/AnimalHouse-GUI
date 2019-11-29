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
            this.Lable_To = new System.Windows.Forms.Label();
            this.label_Subjekt = new System.Windows.Forms.Label();
            this.Lable_Body = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_fjern = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_tilføj = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_hjælpe = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
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
            // Lable_To
            // 
            this.Lable_To.AutoSize = true;
            this.Lable_To.Location = new System.Drawing.Point(106, 42);
            this.Lable_To.Name = "Lable_To";
            this.Lable_To.Size = new System.Drawing.Size(44, 29);
            this.Lable_To.TabIndex = 1;
            this.Lable_To.Text = "To:";
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
            // Lable_Body
            // 
            this.Lable_Body.AutoSize = true;
            this.Lable_Body.Location = new System.Drawing.Point(13, 295);
            this.Lable_Body.Name = "Lable_Body";
            this.Lable_Body.Size = new System.Drawing.Size(137, 29);
            this.Lable_Body.TabIndex = 3;
            this.Lable_Body.Text = "Meddelelsen:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 251);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(583, 35);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(11, 328);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(728, 577);
            this.textBox2.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(156, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(583, 149);
            this.listBox1.TabIndex = 6;
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
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button2.Location = new System.Drawing.Point(1111, 857);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 48);
            this.button2.TabIndex = 7;
            this.button2.Text = "Send påmindelse";
            this.button2.UseVisualStyleBackColor = false;
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
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1005, 871);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "365";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1001, 830);
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
            // AnimalHouse_MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 1043);
            this.Controls.Add(this.label_hjælpe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Lable_Body;
        private System.Windows.Forms.Label label_Subjekt;
        private System.Windows.Forms.Label Lable_To;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_fjern;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_tilføj;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_hjælpe;
    }
}