namespace AnimalHouse_GUI
{
    partial class AnimalHouse_LagerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_søge = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Tilbage = new System.Windows.Forms.Button();
            this.label_hjælpe = new System.Windows.Forms.Label();
            this.button_Print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(691, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vare navn:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(785, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 26);
            this.textBox1.TabIndex = 1;
            // 
            // button_søge
            // 
            this.button_søge.AutoSize = true;
            this.button_søge.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_søge.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_søge.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_søge.Location = new System.Drawing.Point(1082, 85);
            this.button_søge.Name = "button_søge";
            this.button_søge.Size = new System.Drawing.Size(96, 39);
            this.button_søge.TabIndex = 2;
            this.button_søge.Text = "Søg";
            this.button_søge.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(695, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1040, 758);
            this.dataGridView1.TabIndex = 3;
            // 
            // button_Tilbage
            // 
            this.button_Tilbage.AutoSize = true;
            this.button_Tilbage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Tilbage.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Tilbage.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_Tilbage.Location = new System.Drawing.Point(1626, 917);
            this.button_Tilbage.Name = "button_Tilbage";
            this.button_Tilbage.Size = new System.Drawing.Size(109, 49);
            this.button_Tilbage.TabIndex = 4;
            this.button_Tilbage.Text = "Tilbage";
            this.button_Tilbage.UseVisualStyleBackColor = false;
            this.button_Tilbage.Click += new System.EventHandler(this.button_Tilbage_Click);
            // 
            // label_hjælpe
            // 
            this.label_hjælpe.AutoSize = true;
            this.label_hjælpe.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hjælpe.Location = new System.Drawing.Point(12, 1010);
            this.label_hjælpe.Name = "label_hjælpe";
            this.label_hjælpe.Size = new System.Drawing.Size(20, 24);
            this.label_hjælpe.TabIndex = 5;
            this.label_hjælpe.Text = "?";
            // 
            // button_Print
            // 
            this.button_Print.AutoSize = true;
            this.button_Print.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Print.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Print.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_Print.Location = new System.Drawing.Point(695, 917);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(192, 49);
            this.button_Print.TabIndex = 6;
            this.button_Print.Text = "print Lager Status";
            this.button_Print.UseVisualStyleBackColor = false;
            // 
            // AnimalHouse_LagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 1043);
            this.Controls.Add(this.button_Print);
            this.Controls.Add(this.label_hjælpe);
            this.Controls.Add(this.button_Tilbage);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_søge);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "AnimalHouse_LagerForm";
            this.Text = "Animal House";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_søge;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Tilbage;
        private System.Windows.Forms.Label label_hjælpe;
        private System.Windows.Forms.Button button_Print;
    }
}