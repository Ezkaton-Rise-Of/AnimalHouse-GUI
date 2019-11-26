﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimalHouseBLL;

namespace AnimalHouse_GUI
{
    public partial class AnimalHouseGui_Register : Form
    {
        private int id;
        MainController controller = new MainController();

        public AnimalHouseGui_Register()
        {
            InitializeComponent();
        }

        private void Label_ForNavn_Click(object sender, EventArgs e)
        {

        }

        private void Label_Sygdom_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AnimalHouseGui_Register_Load(object sender, EventArgs e)
        {

        }

        private void button_RegEjer_Click(object sender, EventArgs e)
        {
            string kundetype = null;
            if (radioButton_Private.Checked)
            {
                radioButton_Erhverv.Checked = false;
                kundetype = "Private";
            }
            if (radioButton_Erhverv.Checked)
            {
                radioButton_Private.Checked = false;
                kundetype = "Erhverv";
            }
            //string fnavn, string lnavn, string adresse, string postnummer, string tlf, string kundetype, string by, string email
            string answer = controller.OpretKunde(textBox_Fornavn.Text, textBox_Efternavn.Text,textBox_Vejnavn.Text, textBox_Postnummer.Text, textBox_Telefon.Text, kundetype, textBox_By.Text = controller.HentBynavn(textBox_Postnummer.Text), textBox_Email.Text);
            MessageBox.Show(answer);
            FillDataGridView();
            ClearForm();
            ; 
        }

        private void button_SletEjer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Delete transfer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
               MessageBox.Show(controller.SletEjer(id), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillDataGridView();
            }
        }

        private void FillDataGridView()
        {
            dataGridView_Ejer.DataSource = controller.HentAlleKunde();
            dataGridView_Ejer.Columns[0].Visible = false;
        }

        private void button_Søgning_Click(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void TilbageBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AnimalHouseGui_Main main = new AnimalHouseGui_Main();
            main.ShowDialog();
        }

        private void textBox_Postnummer_Leave(object sender, EventArgs e)
        {
            textBox_By.Text = controller.HentBynavn(textBox_Postnummer.Text);
        }

        private void ClearForm()
        {
            textBox_Fornavn.Text = "";
            textBox_Efternavn.Text = "";
            textBox_By.Text = "";
            textBox_Email.Text = "";
            textBox_Postnummer.Text = "";
            textBox_Telefon.Text = "";
            textBox_Vejnavn.Text = "";
        }

        private void dataGridView_Ejer_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_Ejer.CurrentRow.Index != -1)
                {
                    id = Convert.ToInt32(dataGridView_Ejer.CurrentRow.Cells[0].Value.ToString());
                    button_SletEjer.Enabled = true;
                    

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
