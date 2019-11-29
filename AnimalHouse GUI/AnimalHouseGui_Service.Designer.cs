namespace AnimalHouse_GUI
{
    partial class AnimalHouseGui_Service
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
            this.textBox_InsertNewService = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_InsertNewService = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_beskrivelse = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_price = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_Slet = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.test102DataSet = new AnimalHouse_GUI.test102DataSet();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceTableAdapter = new AnimalHouse_GUI.test102DataSetTableAdapters.ServiceTableAdapter();
            this.serviceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produktIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicetypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beskrivelseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test102DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_InsertNewService
            // 
            this.textBox_InsertNewService.Location = new System.Drawing.Point(9, 32);
            this.textBox_InsertNewService.Name = "textBox_InsertNewService";
            this.textBox_InsertNewService.Size = new System.Drawing.Size(100, 20);
            this.textBox_InsertNewService.TabIndex = 0;
            this.textBox_InsertNewService.TextChanged += new System.EventHandler(this.textBox_InsertNewService_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Navn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_InsertNewService
            // 
            this.button_InsertNewService.Location = new System.Drawing.Point(9, 346);
            this.button_InsertNewService.Name = "button_InsertNewService";
            this.button_InsertNewService.Size = new System.Drawing.Size(75, 23);
            this.button_InsertNewService.TabIndex = 2;
            this.button_InsertNewService.Text = "TilFøj";
            this.button_InsertNewService.UseVisualStyleBackColor = true;
            this.button_InsertNewService.Click += new System.EventHandler(this.button_InsertNewService_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_price);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label_beskrivelse);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_InsertNewService);
            this.groupBox1.Controls.Add(this.textBox_InsertNewService);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 373);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ny Service";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 75);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 222);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_beskrivelse
            // 
            this.label_beskrivelse.AutoSize = true;
            this.label_beskrivelse.Location = new System.Drawing.Point(9, 59);
            this.label_beskrivelse.Name = "label_beskrivelse";
            this.label_beskrivelse.Size = new System.Drawing.Size(61, 13);
            this.label_beskrivelse.TabIndex = 4;
            this.label_beskrivelse.Text = "Beskrivelse";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 320);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(12, 304);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(24, 13);
            this.label_price.TabIndex = 6;
            this.label_price.Text = "Pris";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button_Slet);
            this.groupBox2.Location = new System.Drawing.Point(219, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(729, 372);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vedligehold";
            // 
            // button_Slet
            // 
            this.button_Slet.Location = new System.Drawing.Point(6, 343);
            this.button_Slet.Name = "button_Slet";
            this.button_Slet.Size = new System.Drawing.Size(75, 23);
            this.button_Slet.TabIndex = 1;
            this.button_Slet.Text = "Slet";
            this.button_Slet.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceIdDataGridViewTextBoxColumn,
            this.produktIdDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.servicetypeDataGridViewTextBoxColumn,
            this.beskrivelseDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.serviceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(722, 317);
            this.dataGridView1.TabIndex = 3;
            // 
            // test102DataSet
            // 
            this.test102DataSet.DataSetName = "test102DataSet";
            this.test102DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.test102DataSet;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // serviceIdDataGridViewTextBoxColumn
            // 
            this.serviceIdDataGridViewTextBoxColumn.DataPropertyName = "ServiceId";
            this.serviceIdDataGridViewTextBoxColumn.HeaderText = "ServiceId";
            this.serviceIdDataGridViewTextBoxColumn.Name = "serviceIdDataGridViewTextBoxColumn";
            this.serviceIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produktIdDataGridViewTextBoxColumn
            // 
            this.produktIdDataGridViewTextBoxColumn.DataPropertyName = "ProduktId";
            this.produktIdDataGridViewTextBoxColumn.HeaderText = "ProduktId";
            this.produktIdDataGridViewTextBoxColumn.Name = "produktIdDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // servicetypeDataGridViewTextBoxColumn
            // 
            this.servicetypeDataGridViewTextBoxColumn.DataPropertyName = "Servicetype";
            this.servicetypeDataGridViewTextBoxColumn.HeaderText = "Servicetype";
            this.servicetypeDataGridViewTextBoxColumn.Name = "servicetypeDataGridViewTextBoxColumn";
            // 
            // beskrivelseDataGridViewTextBoxColumn
            // 
            this.beskrivelseDataGridViewTextBoxColumn.DataPropertyName = "Beskrivelse";
            this.beskrivelseDataGridViewTextBoxColumn.HeaderText = "Beskrivelse";
            this.beskrivelseDataGridViewTextBoxColumn.Name = "beskrivelseDataGridViewTextBoxColumn";
            // 
            // AnimalHouseGui_Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 394);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AnimalHouseGui_Service";
            this.Text = "AnimalHouseGui_Service";
            this.Load += new System.EventHandler(this.AnimalHouseGui_Service_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test102DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_InsertNewService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_InsertNewService;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_beskrivelse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_Slet;
        private test102DataSet test102DataSet;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private test102DataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produktIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicetypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beskrivelseDataGridViewTextBoxColumn;
    }
}