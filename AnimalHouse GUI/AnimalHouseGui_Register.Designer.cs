namespace AnimalHouse_GUI
{
    partial class AnimalHouseGui_Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalHouseGui_Register));
            this.dataGridView_User = new System.Windows.Forms.DataGridView();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_EfterNavn = new System.Windows.Forms.TextBox();
            this.textBox_ForNavn = new System.Windows.Forms.TextBox();
            this.Label_Email = new System.Windows.Forms.Label();
            this.Label_EfterNavn = new System.Windows.Forms.Label();
            this.Label_ForNavn = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.button_RegisterUser = new System.Windows.Forms.Button();
            this.textBox_Adresse = new System.Windows.Forms.TextBox();
            this.Label_Adresse = new System.Windows.Forms.Label();
            this.button_DeleteUser = new System.Windows.Forms.Button();
            this.button_DeleteAnimal = new System.Windows.Forms.Button();
            this.Label_Medicin = new System.Windows.Forms.Label();
            this.textBox_Medicin = new System.Windows.Forms.TextBox();
            this.textBox_Behandling = new System.Windows.Forms.TextBox();
            this.textBox_DyrNavn = new System.Windows.Forms.TextBox();
            this.textBox_IDdyr = new System.Windows.Forms.TextBox();
            this.button_RegisterAnimal = new System.Windows.Forms.Button();
            this.Label_Behandling = new System.Windows.Forms.Label();
            this.Label_DyrNavn = new System.Windows.Forms.Label();
            this.Label_IDdyr = new System.Windows.Forms.Label();
            this.textBox_IDUserdyr = new System.Windows.Forms.TextBox();
            this.textBox_IDUser = new System.Windows.Forms.TextBox();
            this.Label_IDUser = new System.Windows.Forms.Label();
            this.Label_IDUserdyr = new System.Windows.Forms.Label();
            this.dataGridView_Dyr = new System.Windows.Forms.DataGridView();
            this.Label_Owner = new System.Windows.Forms.Label();
            this.Label_Animal = new System.Windows.Forms.Label();
            this.textBox_telefon = new System.Windows.Forms.TextBox();
            this.Label_telefon = new System.Windows.Forms.Label();
            this.textBox_Sygdom = new System.Windows.Forms.TextBox();
            this.Label_Sygdom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Dyr)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_User
            // 
            this.dataGridView_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_User.Location = new System.Drawing.Point(496, 28);
            this.dataGridView_User.Name = "dataGridView_User";
            this.dataGridView_User.ReadOnly = true;
            this.dataGridView_User.Size = new System.Drawing.Size(658, 262);
            this.dataGridView_User.TabIndex = 22;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(127, 218);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(313, 20);
            this.textBox_Email.TabIndex = 21;
            // 
            // textBox_EfterNavn
            // 
            this.textBox_EfterNavn.Location = new System.Drawing.Point(127, 192);
            this.textBox_EfterNavn.Name = "textBox_EfterNavn";
            this.textBox_EfterNavn.Size = new System.Drawing.Size(313, 20);
            this.textBox_EfterNavn.TabIndex = 20;
            // 
            // textBox_ForNavn
            // 
            this.textBox_ForNavn.Location = new System.Drawing.Point(127, 166);
            this.textBox_ForNavn.Name = "textBox_ForNavn";
            this.textBox_ForNavn.Size = new System.Drawing.Size(313, 20);
            this.textBox_ForNavn.TabIndex = 19;
            // 
            // Label_Email
            // 
            this.Label_Email.AutoSize = true;
            this.Label_Email.Location = new System.Drawing.Point(58, 218);
            this.Label_Email.Name = "Label_Email";
            this.Label_Email.Size = new System.Drawing.Size(35, 13);
            this.Label_Email.TabIndex = 15;
            this.Label_Email.Text = "E-mail";
            // 
            // Label_EfterNavn
            // 
            this.Label_EfterNavn.AutoSize = true;
            this.Label_EfterNavn.Location = new System.Drawing.Point(58, 192);
            this.Label_EfterNavn.Name = "Label_EfterNavn";
            this.Label_EfterNavn.Size = new System.Drawing.Size(58, 13);
            this.Label_EfterNavn.TabIndex = 14;
            this.Label_EfterNavn.Text = "Last Name";
            // 
            // Label_ForNavn
            // 
            this.Label_ForNavn.AutoSize = true;
            this.Label_ForNavn.Location = new System.Drawing.Point(58, 166);
            this.Label_ForNavn.Name = "Label_ForNavn";
            this.Label_ForNavn.Size = new System.Drawing.Size(57, 13);
            this.Label_ForNavn.TabIndex = 13;
            this.Label_ForNavn.Text = "First Name";
            this.Label_ForNavn.Click += new System.EventHandler(this.Label_ForNavn_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Haettenschweiler", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 67);
            this.label1.TabIndex = 27;
            this.label1.Text = "Animal House";
            // 
            // button_RegisterUser
            // 
            this.button_RegisterUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RegisterUser.Location = new System.Drawing.Point(127, 296);
            this.button_RegisterUser.Name = "button_RegisterUser";
            this.button_RegisterUser.Size = new System.Drawing.Size(107, 54);
            this.button_RegisterUser.TabIndex = 16;
            this.button_RegisterUser.Text = "Register";
            this.button_RegisterUser.UseVisualStyleBackColor = true;
            // 
            // textBox_Adresse
            // 
            this.textBox_Adresse.Location = new System.Drawing.Point(127, 270);
            this.textBox_Adresse.Name = "textBox_Adresse";
            this.textBox_Adresse.Size = new System.Drawing.Size(313, 20);
            this.textBox_Adresse.TabIndex = 29;
            // 
            // Label_Adresse
            // 
            this.Label_Adresse.AutoSize = true;
            this.Label_Adresse.Location = new System.Drawing.Point(58, 270);
            this.Label_Adresse.Name = "Label_Adresse";
            this.Label_Adresse.Size = new System.Drawing.Size(39, 13);
            this.Label_Adresse.TabIndex = 30;
            this.Label_Adresse.Text = "Adress";
            // 
            // button_DeleteUser
            // 
            this.button_DeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DeleteUser.ForeColor = System.Drawing.Color.Red;
            this.button_DeleteUser.Location = new System.Drawing.Point(240, 296);
            this.button_DeleteUser.Name = "button_DeleteUser";
            this.button_DeleteUser.Size = new System.Drawing.Size(107, 54);
            this.button_DeleteUser.TabIndex = 31;
            this.button_DeleteUser.Text = "Delete";
            this.button_DeleteUser.UseVisualStyleBackColor = true;
            // 
            // button_DeleteAnimal
            // 
            this.button_DeleteAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DeleteAnimal.ForeColor = System.Drawing.Color.Red;
            this.button_DeleteAnimal.Location = new System.Drawing.Point(240, 598);
            this.button_DeleteAnimal.Name = "button_DeleteAnimal";
            this.button_DeleteAnimal.Size = new System.Drawing.Size(107, 54);
            this.button_DeleteAnimal.TabIndex = 41;
            this.button_DeleteAnimal.Text = "Delete";
            this.button_DeleteAnimal.UseVisualStyleBackColor = true;
            // 
            // Label_Medicin
            // 
            this.Label_Medicin.AutoSize = true;
            this.Label_Medicin.Location = new System.Drawing.Point(58, 572);
            this.Label_Medicin.Name = "Label_Medicin";
            this.Label_Medicin.Size = new System.Drawing.Size(59, 13);
            this.Label_Medicin.TabIndex = 40;
            this.Label_Medicin.Text = "Medication";
            // 
            // textBox_Medicin
            // 
            this.textBox_Medicin.Location = new System.Drawing.Point(127, 572);
            this.textBox_Medicin.Name = "textBox_Medicin";
            this.textBox_Medicin.Size = new System.Drawing.Size(313, 20);
            this.textBox_Medicin.TabIndex = 39;
            // 
            // textBox_Behandling
            // 
            this.textBox_Behandling.Location = new System.Drawing.Point(127, 546);
            this.textBox_Behandling.Name = "textBox_Behandling";
            this.textBox_Behandling.Size = new System.Drawing.Size(313, 20);
            this.textBox_Behandling.TabIndex = 38;
            // 
            // textBox_DyrNavn
            // 
            this.textBox_DyrNavn.Location = new System.Drawing.Point(127, 494);
            this.textBox_DyrNavn.Name = "textBox_DyrNavn";
            this.textBox_DyrNavn.Size = new System.Drawing.Size(313, 20);
            this.textBox_DyrNavn.TabIndex = 37;
            // 
            // textBox_IDdyr
            // 
            this.textBox_IDdyr.Location = new System.Drawing.Point(127, 468);
            this.textBox_IDdyr.Name = "textBox_IDdyr";
            this.textBox_IDdyr.Size = new System.Drawing.Size(313, 20);
            this.textBox_IDdyr.TabIndex = 36;
            // 
            // button_RegisterAnimal
            // 
            this.button_RegisterAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RegisterAnimal.Location = new System.Drawing.Point(127, 598);
            this.button_RegisterAnimal.Name = "button_RegisterAnimal";
            this.button_RegisterAnimal.Size = new System.Drawing.Size(107, 54);
            this.button_RegisterAnimal.TabIndex = 35;
            this.button_RegisterAnimal.Text = "Register";
            this.button_RegisterAnimal.UseVisualStyleBackColor = true;
            // 
            // Label_Behandling
            // 
            this.Label_Behandling.AutoSize = true;
            this.Label_Behandling.Location = new System.Drawing.Point(58, 546);
            this.Label_Behandling.Name = "Label_Behandling";
            this.Label_Behandling.Size = new System.Drawing.Size(55, 13);
            this.Label_Behandling.TabIndex = 34;
            this.Label_Behandling.Text = "Treatment";
            // 
            // Label_DyrNavn
            // 
            this.Label_DyrNavn.AutoSize = true;
            this.Label_DyrNavn.Location = new System.Drawing.Point(58, 494);
            this.Label_DyrNavn.Name = "Label_DyrNavn";
            this.Label_DyrNavn.Size = new System.Drawing.Size(35, 13);
            this.Label_DyrNavn.TabIndex = 33;
            this.Label_DyrNavn.Text = "Name";
            // 
            // Label_IDdyr
            // 
            this.Label_IDdyr.AutoSize = true;
            this.Label_IDdyr.Location = new System.Drawing.Point(58, 468);
            this.Label_IDdyr.Name = "Label_IDdyr";
            this.Label_IDdyr.Size = new System.Drawing.Size(52, 13);
            this.Label_IDdyr.TabIndex = 32;
            this.Label_IDdyr.Text = "Animal ID";
            // 
            // textBox_IDUserdyr
            // 
            this.textBox_IDUserdyr.Location = new System.Drawing.Point(127, 442);
            this.textBox_IDUserdyr.Name = "textBox_IDUserdyr";
            this.textBox_IDUserdyr.Size = new System.Drawing.Size(313, 20);
            this.textBox_IDUserdyr.TabIndex = 42;
            // 
            // textBox_IDUser
            // 
            this.textBox_IDUser.Location = new System.Drawing.Point(127, 140);
            this.textBox_IDUser.Name = "textBox_IDUser";
            this.textBox_IDUser.Size = new System.Drawing.Size(313, 20);
            this.textBox_IDUser.TabIndex = 43;
            // 
            // Label_IDUser
            // 
            this.Label_IDUser.AutoSize = true;
            this.Label_IDUser.Location = new System.Drawing.Point(58, 140);
            this.Label_IDUser.Name = "Label_IDUser";
            this.Label_IDUser.Size = new System.Drawing.Size(52, 13);
            this.Label_IDUser.TabIndex = 44;
            this.Label_IDUser.Text = "Owner ID";
            // 
            // Label_IDUserdyr
            // 
            this.Label_IDUserdyr.AutoSize = true;
            this.Label_IDUserdyr.Location = new System.Drawing.Point(58, 442);
            this.Label_IDUserdyr.Name = "Label_IDUserdyr";
            this.Label_IDUserdyr.Size = new System.Drawing.Size(52, 13);
            this.Label_IDUserdyr.TabIndex = 45;
            this.Label_IDUserdyr.Text = "Owner ID";
            // 
            // dataGridView_Dyr
            // 
            this.dataGridView_Dyr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Dyr.Location = new System.Drawing.Point(496, 330);
            this.dataGridView_Dyr.Name = "dataGridView_Dyr";
            this.dataGridView_Dyr.ReadOnly = true;
            this.dataGridView_Dyr.Size = new System.Drawing.Size(658, 262);
            this.dataGridView_Dyr.TabIndex = 46;
            // 
            // Label_Owner
            // 
            this.Label_Owner.AutoSize = true;
            this.Label_Owner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Owner.Location = new System.Drawing.Point(57, 99);
            this.Label_Owner.Name = "Label_Owner";
            this.Label_Owner.Size = new System.Drawing.Size(41, 20);
            this.Label_Owner.TabIndex = 47;
            this.Label_Owner.Text = "Ejer";
            // 
            // Label_Animal
            // 
            this.Label_Animal.AutoSize = true;
            this.Label_Animal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Animal.Location = new System.Drawing.Point(57, 399);
            this.Label_Animal.Name = "Label_Animal";
            this.Label_Animal.Size = new System.Drawing.Size(36, 20);
            this.Label_Animal.TabIndex = 48;
            this.Label_Animal.Text = "Dyr";
            // 
            // textBox_telefon
            // 
            this.textBox_telefon.Location = new System.Drawing.Point(127, 244);
            this.textBox_telefon.Name = "textBox_telefon";
            this.textBox_telefon.Size = new System.Drawing.Size(313, 20);
            this.textBox_telefon.TabIndex = 49;
            // 
            // Label_telefon
            // 
            this.Label_telefon.AutoSize = true;
            this.Label_telefon.Location = new System.Drawing.Point(58, 244);
            this.Label_telefon.Name = "Label_telefon";
            this.Label_telefon.Size = new System.Drawing.Size(55, 13);
            this.Label_telefon.TabIndex = 50;
            this.Label_telefon.Text = "Mobile Nr.";
            // 
            // textBox_Sygdom
            // 
            this.textBox_Sygdom.Location = new System.Drawing.Point(127, 520);
            this.textBox_Sygdom.Name = "textBox_Sygdom";
            this.textBox_Sygdom.Size = new System.Drawing.Size(313, 20);
            this.textBox_Sygdom.TabIndex = 51;
            // 
            // Label_Sygdom
            // 
            this.Label_Sygdom.AutoSize = true;
            this.Label_Sygdom.Location = new System.Drawing.Point(58, 520);
            this.Label_Sygdom.Name = "Label_Sygdom";
            this.Label_Sygdom.Size = new System.Drawing.Size(50, 13);
            this.Label_Sygdom.TabIndex = 52;
            this.Label_Sygdom.Text = "Sickness";
            // 
            // AnimalHouseGui_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 678);
            this.Controls.Add(this.Label_Sygdom);
            this.Controls.Add(this.textBox_Sygdom);
            this.Controls.Add(this.Label_telefon);
            this.Controls.Add(this.textBox_telefon);
            this.Controls.Add(this.Label_Animal);
            this.Controls.Add(this.Label_Owner);
            this.Controls.Add(this.dataGridView_Dyr);
            this.Controls.Add(this.Label_IDUserdyr);
            this.Controls.Add(this.Label_IDUser);
            this.Controls.Add(this.textBox_IDUser);
            this.Controls.Add(this.textBox_IDUserdyr);
            this.Controls.Add(this.button_DeleteAnimal);
            this.Controls.Add(this.Label_Medicin);
            this.Controls.Add(this.textBox_Medicin);
            this.Controls.Add(this.textBox_Behandling);
            this.Controls.Add(this.textBox_DyrNavn);
            this.Controls.Add(this.textBox_IDdyr);
            this.Controls.Add(this.button_RegisterAnimal);
            this.Controls.Add(this.Label_Behandling);
            this.Controls.Add(this.Label_DyrNavn);
            this.Controls.Add(this.Label_IDdyr);
            this.Controls.Add(this.button_DeleteUser);
            this.Controls.Add(this.Label_Adresse);
            this.Controls.Add(this.textBox_Adresse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_User);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_EfterNavn);
            this.Controls.Add(this.textBox_ForNavn);
            this.Controls.Add(this.button_RegisterUser);
            this.Controls.Add(this.Label_Email);
            this.Controls.Add(this.Label_EfterNavn);
            this.Controls.Add(this.Label_ForNavn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnimalHouseGui_Register";
            this.Text = "Animal House";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Dyr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_User;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_EfterNavn;
        private System.Windows.Forms.TextBox textBox_ForNavn;
        private System.Windows.Forms.Label Label_Email;
        private System.Windows.Forms.Label Label_EfterNavn;
        private System.Windows.Forms.Label Label_ForNavn;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_RegisterUser;
        private System.Windows.Forms.TextBox textBox_Adresse;
        private System.Windows.Forms.Label Label_Adresse;
        private System.Windows.Forms.Button button_DeleteUser;
        private System.Windows.Forms.Button button_DeleteAnimal;
        private System.Windows.Forms.Label Label_Medicin;
        private System.Windows.Forms.TextBox textBox_Medicin;
        private System.Windows.Forms.TextBox textBox_Behandling;
        private System.Windows.Forms.TextBox textBox_DyrNavn;
        private System.Windows.Forms.TextBox textBox_IDdyr;
        private System.Windows.Forms.Button button_RegisterAnimal;
        private System.Windows.Forms.Label Label_Behandling;
        private System.Windows.Forms.Label Label_DyrNavn;
        private System.Windows.Forms.Label Label_IDdyr;
        private System.Windows.Forms.TextBox textBox_IDUser;
        private System.Windows.Forms.TextBox textBox_IDUserdyr;
        private System.Windows.Forms.Label Label_Animal;
        private System.Windows.Forms.Label Label_Owner;
        private System.Windows.Forms.DataGridView dataGridView_Dyr;
        private System.Windows.Forms.Label Label_IDUserdyr;
        private System.Windows.Forms.Label Label_IDUser;
        private System.Windows.Forms.Label Label_telefon;
        private System.Windows.Forms.TextBox textBox_telefon;
        private System.Windows.Forms.Label Label_Sygdom;
        private System.Windows.Forms.TextBox textBox_Sygdom;
    }
}