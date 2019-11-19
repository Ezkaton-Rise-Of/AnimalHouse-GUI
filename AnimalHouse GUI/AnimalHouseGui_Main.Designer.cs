﻿namespace AnimalHouse_GUI
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
            this.label_AnimalHouse1 = new System.Windows.Forms.Label();
            this.label_HovedMenu = new System.Windows.Forms.Label();
            this.button_EjerReg = new System.Windows.Forms.Button();
            this.button_Salg = new System.Windows.Forms.Button();
            this.button_DyrReg = new System.Windows.Forms.Button();
            this.button_Booking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_AnimalHouse1
            // 
            this.label_AnimalHouse1.AutoSize = true;
            this.label_AnimalHouse1.Font = new System.Drawing.Font("Haettenschweiler", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AnimalHouse1.Location = new System.Drawing.Point(105, 9);
            this.label_AnimalHouse1.Name = "label_AnimalHouse1";
            this.label_AnimalHouse1.Size = new System.Drawing.Size(287, 67);
            this.label_AnimalHouse1.TabIndex = 26;
            this.label_AnimalHouse1.Text = "Animal House";
            this.label_AnimalHouse1.Click += new System.EventHandler(this.label_AnimalHouse1_Click);
            // 
            // label_HovedMenu
            // 
            this.label_HovedMenu.AutoSize = true;
            this.label_HovedMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_HovedMenu.Location = new System.Drawing.Point(199, 159);
            this.label_HovedMenu.Name = "label_HovedMenu";
            this.label_HovedMenu.Size = new System.Drawing.Size(120, 24);
            this.label_HovedMenu.TabIndex = 31;
            this.label_HovedMenu.Text = "Hoved Menu";
            // 
            // button_EjerReg
            // 
            this.button_EjerReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_EjerReg.Location = new System.Drawing.Point(117, 220);
            this.button_EjerReg.Name = "button_EjerReg";
            this.button_EjerReg.Size = new System.Drawing.Size(275, 46);
            this.button_EjerReg.TabIndex = 27;
            this.button_EjerReg.Text = "Registrere Ejer";
            this.button_EjerReg.UseVisualStyleBackColor = true;
            // 
            // button_Salg
            // 
            this.button_Salg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Salg.Location = new System.Drawing.Point(117, 376);
            this.button_Salg.Name = "button_Salg";
            this.button_Salg.Size = new System.Drawing.Size(275, 46);
            this.button_Salg.TabIndex = 32;
            this.button_Salg.Text = "Salg";
            this.button_Salg.UseVisualStyleBackColor = true;
            // 
            // button_DyrReg
            // 
            this.button_DyrReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DyrReg.Location = new System.Drawing.Point(117, 272);
            this.button_DyrReg.Name = "button_DyrReg";
            this.button_DyrReg.Size = new System.Drawing.Size(275, 46);
            this.button_DyrReg.TabIndex = 33;
            this.button_DyrReg.Text = "Registrere Dyr";
            this.button_DyrReg.UseVisualStyleBackColor = true;
            // 
            // button_Booking
            // 
            this.button_Booking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Booking.Location = new System.Drawing.Point(117, 324);
            this.button_Booking.Name = "button_Booking";
            this.button_Booking.Size = new System.Drawing.Size(275, 46);
            this.button_Booking.TabIndex = 34;
            this.button_Booking.Text = "Booking";
            this.button_Booking.UseVisualStyleBackColor = true;
            // 
            // AnimalHouseGui_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(509, 481);
            this.Controls.Add(this.button_Booking);
            this.Controls.Add(this.button_DyrReg);
            this.Controls.Add(this.button_Salg);
            this.Controls.Add(this.label_HovedMenu);
            this.Controls.Add(this.button_EjerReg);
            this.Controls.Add(this.label_AnimalHouse1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnimalHouseGui_Main";
            this.Text = "Animal House";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_AnimalHouse1;
        private System.Windows.Forms.Label label_HovedMenu;
        private System.Windows.Forms.Button button_EjerReg;
        private System.Windows.Forms.Button button_Salg;
        private System.Windows.Forms.Button button_DyrReg;
        private System.Windows.Forms.Button button_Booking;
    }
}

