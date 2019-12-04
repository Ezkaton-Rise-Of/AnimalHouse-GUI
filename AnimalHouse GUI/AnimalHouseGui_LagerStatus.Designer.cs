namespace AnimalHouse_GUI
{
    partial class AnimalHouseGui_LagerStatus
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalHouseGui_LagerStatus));
            this.test_LagerDataSet = new AnimalHouse_GUI.Test_LagerDataSet();
            this.lagerStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lagerStatusTableAdapter = new AnimalHouse_GUI.Test_LagerDataSetTableAdapters.LagerStatusTableAdapter();
            this.button_Tilbage = new System.Windows.Forms.Button();
            this.groupBox_LagerStatus = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_VareNavn = new System.Windows.Forms.TextBox();
            this.button_SøgLagerStatus = new System.Windows.Forms.Button();
            this.dataGridView_LagerStatus = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_UdskriftStatus = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_PrintNavn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_PrintStatus = new System.Windows.Forms.Button();
            this.button_UdskriftStatus = new System.Windows.Forms.Button();
            this.richTextBox_UdskrivStatus = new System.Windows.Forms.RichTextBox();
            this.label_hjælpe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.test_LagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagerStatusBindingSource)).BeginInit();
            this.groupBox_LagerStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LagerStatus)).BeginInit();
            this.groupBox_UdskriftStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // test_LagerDataSet
            // 
            this.test_LagerDataSet.DataSetName = "Test_LagerDataSet";
            this.test_LagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lagerStatusBindingSource
            // 
            this.lagerStatusBindingSource.DataMember = "LagerStatus";
            this.lagerStatusBindingSource.DataSource = this.test_LagerDataSet;
            // 
            // lagerStatusTableAdapter
            // 
            this.lagerStatusTableAdapter.ClearBeforeFill = true;
            // 
            // button_Tilbage
            // 
            this.button_Tilbage.AutoSize = true;
            this.button_Tilbage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Tilbage.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Tilbage.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_Tilbage.Location = new System.Drawing.Point(414, 551);
            this.button_Tilbage.Margin = new System.Windows.Forms.Padding(2);
            this.button_Tilbage.Name = "button_Tilbage";
            this.button_Tilbage.Size = new System.Drawing.Size(105, 44);
            this.button_Tilbage.TabIndex = 106;
            this.button_Tilbage.Text = "Tilbage";
            this.button_Tilbage.UseVisualStyleBackColor = false;
            this.button_Tilbage.Click += new System.EventHandler(this.button_Tilbage_Click);
            // 
            // groupBox_LagerStatus
            // 
            this.groupBox_LagerStatus.Controls.Add(this.label4);
            this.groupBox_LagerStatus.Controls.Add(this.textBox1);
            this.groupBox_LagerStatus.Controls.Add(this.label1);
            this.groupBox_LagerStatus.Controls.Add(this.textBox_VareNavn);
            this.groupBox_LagerStatus.Controls.Add(this.button_SøgLagerStatus);
            this.groupBox_LagerStatus.Controls.Add(this.dataGridView_LagerStatus);
            this.groupBox_LagerStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_LagerStatus.Location = new System.Drawing.Point(12, 12);
            this.groupBox_LagerStatus.Name = "groupBox_LagerStatus";
            this.groupBox_LagerStatus.Size = new System.Drawing.Size(552, 637);
            this.groupBox_LagerStatus.TabIndex = 108;
            this.groupBox_LagerStatus.TabStop = false;
            this.groupBox_LagerStatus.Text = "Lager Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(143, 581);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 16);
            this.label4.TabIndex = 115;
            this.label4.Text = "Søg efter Varenummer";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 600);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(486, 22);
            this.textBox1.TabIndex = 114;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 530);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 113;
            this.label1.Text = "Søg efter Vare Navn";
            // 
            // textBox_VareNavn
            // 
            this.textBox_VareNavn.Location = new System.Drawing.Point(33, 552);
            this.textBox_VareNavn.Name = "textBox_VareNavn";
            this.textBox_VareNavn.Size = new System.Drawing.Size(486, 22);
            this.textBox_VareNavn.TabIndex = 112;
            // 
            // button_SøgLagerStatus
            // 
            this.button_SøgLagerStatus.AutoSize = true;
            this.button_SøgLagerStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_SøgLagerStatus.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SøgLagerStatus.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_SøgLagerStatus.Location = new System.Drawing.Point(33, 503);
            this.button_SøgLagerStatus.Margin = new System.Windows.Forms.Padding(2);
            this.button_SøgLagerStatus.Name = "button_SøgLagerStatus";
            this.button_SøgLagerStatus.Size = new System.Drawing.Size(105, 44);
            this.button_SøgLagerStatus.TabIndex = 111;
            this.button_SøgLagerStatus.Text = "Søgning";
            this.button_SøgLagerStatus.UseVisualStyleBackColor = false;
            this.button_SøgLagerStatus.Click += new System.EventHandler(this.button_SøgLager_Click);
            // 
            // dataGridView_LagerStatus
            // 
            this.dataGridView_LagerStatus.AllowUserToDeleteRows = false;
            this.dataGridView_LagerStatus.AutoGenerateColumns = false;
            this.dataGridView_LagerStatus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView_LagerStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_LagerStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView_LagerStatus.DataSource = this.lagerStatusBindingSource;
            this.dataGridView_LagerStatus.Location = new System.Drawing.Point(33, 20);
            this.dataGridView_LagerStatus.Name = "dataGridView_LagerStatus";
            this.dataGridView_LagerStatus.RowHeadersWidth = 62;
            this.dataGridView_LagerStatus.Size = new System.Drawing.Size(486, 478);
            this.dataGridView_LagerStatus.TabIndex = 104;
            this.dataGridView_LagerStatus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_LagerStatus_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Varenummer";
            this.dataGridViewTextBoxColumn1.HeaderText = "Varenummer";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 110;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Vare Navn";
            this.dataGridViewTextBoxColumn2.HeaderText = "Vare Navn";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 89;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Minimums Antal";
            this.dataGridViewTextBoxColumn3.HeaderText = "Minimums Antal";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 115;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Antal";
            this.dataGridViewTextBoxColumn4.HeaderText = "Antal";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 63;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Pris DKK";
            this.dataGridViewTextBoxColumn5.HeaderText = "Pris DKK";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 78;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Ekslusiv Moms";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ekslusiv Moms";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 113;
            // 
            // groupBox_UdskriftStatus
            // 
            this.groupBox_UdskriftStatus.Controls.Add(this.label3);
            this.groupBox_UdskriftStatus.Controls.Add(this.textBox_PrintNavn);
            this.groupBox_UdskriftStatus.Controls.Add(this.label2);
            this.groupBox_UdskriftStatus.Controls.Add(this.button_Tilbage);
            this.groupBox_UdskriftStatus.Controls.Add(this.button_PrintStatus);
            this.groupBox_UdskriftStatus.Controls.Add(this.button_UdskriftStatus);
            this.groupBox_UdskriftStatus.Controls.Add(this.richTextBox_UdskrivStatus);
            this.groupBox_UdskriftStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_UdskriftStatus.Location = new System.Drawing.Point(620, 12);
            this.groupBox_UdskriftStatus.Name = "groupBox_UdskriftStatus";
            this.groupBox_UdskriftStatus.Size = new System.Drawing.Size(551, 654);
            this.groupBox_UdskriftStatus.TabIndex = 109;
            this.groupBox_UdskriftStatus.TabStop = false;
            this.groupBox_UdskriftStatus.Text = "Udskriv Lager";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 531);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 16);
            this.label3.TabIndex = 116;
            this.label3.Text = "Udskriv Lagerstatus til monitor";
            // 
            // textBox_PrintNavn
            // 
            this.textBox_PrintNavn.Location = new System.Drawing.Point(33, 600);
            this.textBox_PrintNavn.Name = "textBox_PrintNavn";
            this.textBox_PrintNavn.Size = new System.Drawing.Size(486, 22);
            this.textBox_PrintNavn.TabIndex = 115;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 579);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 114;
            this.label2.Text = "Indtast Fil Navn (.txt)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button_PrintStatus
            // 
            this.button_PrintStatus.AutoSize = true;
            this.button_PrintStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_PrintStatus.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PrintStatus.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_PrintStatus.Location = new System.Drawing.Point(33, 551);
            this.button_PrintStatus.Margin = new System.Windows.Forms.Padding(2);
            this.button_PrintStatus.Name = "button_PrintStatus";
            this.button_PrintStatus.Size = new System.Drawing.Size(105, 44);
            this.button_PrintStatus.TabIndex = 108;
            this.button_PrintStatus.Text = "Print";
            this.button_PrintStatus.UseVisualStyleBackColor = false;
            // 
            // button_UdskriftStatus
            // 
            this.button_UdskriftStatus.AutoSize = true;
            this.button_UdskriftStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_UdskriftStatus.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_UdskriftStatus.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_UdskriftStatus.Location = new System.Drawing.Point(33, 503);
            this.button_UdskriftStatus.Margin = new System.Windows.Forms.Padding(2);
            this.button_UdskriftStatus.Name = "button_UdskriftStatus";
            this.button_UdskriftStatus.Size = new System.Drawing.Size(105, 44);
            this.button_UdskriftStatus.TabIndex = 107;
            this.button_UdskriftStatus.Text = "Udskriv";
            this.button_UdskriftStatus.UseVisualStyleBackColor = false;
            // 
            // richTextBox_UdskrivStatus
            // 
            this.richTextBox_UdskrivStatus.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox_UdskrivStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox_UdskrivStatus.Location = new System.Drawing.Point(33, 20);
            this.richTextBox_UdskrivStatus.Name = "richTextBox_UdskrivStatus";
            this.richTextBox_UdskrivStatus.Size = new System.Drawing.Size(486, 478);
            this.richTextBox_UdskrivStatus.TabIndex = 105;
            this.richTextBox_UdskrivStatus.Text = "";
            // 
            // label_hjælpe
            // 
            this.label_hjælpe.AutoSize = true;
            this.label_hjælpe.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hjælpe.Location = new System.Drawing.Point(11, 652);
            this.label_hjælpe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_hjælpe.Name = "label_hjælpe";
            this.label_hjælpe.Size = new System.Drawing.Size(15, 17);
            this.label_hjælpe.TabIndex = 110;
            this.label_hjælpe.Text = "?";
            // 
            // AnimalHouseGui_LagerStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 678);
            this.Controls.Add(this.label_hjælpe);
            this.Controls.Add(this.groupBox_UdskriftStatus);
            this.Controls.Add(this.groupBox_LagerStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnimalHouseGui_LagerStatus";
            this.Text = "Animal House";
            this.Load += new System.EventHandler(this.AnimalHouseGui_Lager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.test_LagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lagerStatusBindingSource)).EndInit();
            this.groupBox_LagerStatus.ResumeLayout(false);
            this.groupBox_LagerStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LagerStatus)).EndInit();
            this.groupBox_UdskriftStatus.ResumeLayout(false);
            this.groupBox_UdskriftStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Test_LagerDataSet test_LagerDataSet;
        private System.Windows.Forms.BindingSource lagerStatusBindingSource;
        private Test_LagerDataSetTableAdapters.LagerStatusTableAdapter lagerStatusTableAdapter;
        private System.Windows.Forms.Button button_Tilbage;
        private System.Windows.Forms.GroupBox groupBox_LagerStatus;
        private System.Windows.Forms.DataGridView dataGridView_LagerStatus;
        private System.Windows.Forms.GroupBox groupBox_UdskriftStatus;
        private System.Windows.Forms.RichTextBox richTextBox_UdskrivStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_VareNavn;
        private System.Windows.Forms.Button button_SøgLagerStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_PrintStatus;
        private System.Windows.Forms.Button button_UdskriftStatus;
        private System.Windows.Forms.Label label_hjælpe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_PrintNavn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}