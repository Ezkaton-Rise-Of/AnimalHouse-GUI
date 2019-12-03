using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimalHouseBLL;
using AnimalHouse_Entities;
using AnimalHouse_Entites;
using System.Diagnostics;

namespace AnimalHouse_GUI
{
    public partial class AnimalHouseGui_Booking : Form
    {
        MainController controller = new MainController();


        public AnimalHouseGui_Booking()
        {
            InitializeComponent();
        }

        private void AnimalHouseGui_Booking_Load(object sender, EventArgs e)
        {

        }

        private void textBox_DyrIdBooking_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_EjerIdBooking_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                controller.HentKundeByTlf(Convert.ToString(textBox_EjerIdBooking.Text));

                controller.HentAlleKundesDyr(controller.K[0].Id);

                foreach (Dyr item in controller.D)
                {
                    comboBox1.Items.Add(item.DyrId + " " + item.Art + " " + item.Race);
                }

                Navn_empty.Text = controller.K[0].Fnavn + " " + controller.K[0].Lnavn;
                Addresse_empty.Text = controller.K[0].Adresse;
                By_empty.Text = controller.K[0].By;
                Postnummer_empty.Text = controller.K[0].Postnummer;
            }
            catch (Exception)
            {
                
                throw;
            }


        }

        private void textBox_EjerIdBooking_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
