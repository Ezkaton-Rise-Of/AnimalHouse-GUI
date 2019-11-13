namespace AnimalHouse_GUI
{
    partial class AnimalHouseGui_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalHouseGui_Main));
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUserReg = new System.Windows.Forms.Button();
            this.buttonSale = new System.Windows.Forms.Button();
            this.buttonBooking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Haettenschweiler", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 67);
            this.label4.TabIndex = 26;
            this.label4.Text = "Animal House";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "Main Menu";
            // 
            // buttonUserReg
            // 
            this.buttonUserReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUserReg.Location = new System.Drawing.Point(117, 220);
            this.buttonUserReg.Name = "buttonUserReg";
            this.buttonUserReg.Size = new System.Drawing.Size(275, 46);
            this.buttonUserReg.TabIndex = 27;
            this.buttonUserReg.Text = "Register User";
            this.buttonUserReg.UseVisualStyleBackColor = true;
            // 
            // buttonSale
            // 
            this.buttonSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSale.Location = new System.Drawing.Point(117, 324);
            this.buttonSale.Name = "buttonSale";
            this.buttonSale.Size = new System.Drawing.Size(275, 46);
            this.buttonSale.TabIndex = 32;
            this.buttonSale.Text = "Sales";
            this.buttonSale.UseVisualStyleBackColor = true;
            // 
            // buttonBooking
            // 
            this.buttonBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBooking.Location = new System.Drawing.Point(117, 272);
            this.buttonBooking.Name = "buttonBooking";
            this.buttonBooking.Size = new System.Drawing.Size(275, 46);
            this.buttonBooking.TabIndex = 33;
            this.buttonBooking.Text = "Booking";
            this.buttonBooking.UseVisualStyleBackColor = true;
            // 
            // AnimalHouseGui_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(509, 481);
            this.Controls.Add(this.buttonBooking);
            this.Controls.Add(this.buttonSale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonUserReg);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnimalHouseGui_Main";
            this.Text = "Animal House";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonUserReg;
        private System.Windows.Forms.Button buttonSale;
        private System.Windows.Forms.Button buttonBooking;
    }
}

